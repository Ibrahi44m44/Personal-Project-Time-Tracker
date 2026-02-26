using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Personal_Project_Time_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isRefreshing = false;
        clsProject GetSelectedProject()
        {
            clsProject SelectedProject = AppData.ProjectsList[cbProjects.SelectedIndex];
            return SelectedProject;
        }

        clsTask GetSelectedTask()
        {
            clsTask SelectedTask = (clsTask)GetSelectedProject().Tasks[cbTask.SelectedIndex];
            return SelectedTask;
        }

        // Notifications
        void StartNotifications()
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "OverDue";
            notifyIcon1.BalloonTipText = "The Time For Project : " + GetSelectedProject().ToString() + " IS Over";
            notifyIcon1.ShowBalloonTip(1000);
        }


        // Update Project Time After Work 
        void UpdateRemainingTime()
        {
            if (cbProjects.SelectedIndex == -1) return;

            clsProject selectedProject = GetSelectedProject();
            int totalTasksSeconds = 0;

            foreach (clsTask task in selectedProject.Tasks)
            {
                totalTasksSeconds += task.TotalTime;
            }

            int projectExpectedSeconds = selectedProject.ExpectedTime * 3600;

            int remainingSeconds = projectExpectedSeconds - totalTasksSeconds;

            if (remainingSeconds >= 0)
            {
                TimeSpan t = TimeSpan.FromSeconds(remainingSeconds);
                txtTotalProjectTime.Text = string.Format("{0}h {1}m remaining", (int)t.TotalHours, t.Minutes);
                txtTotalProjectTime.ForeColor = Color.Black;
            }
            else
            {
                txtTotalProjectTime.Text = "Overdue!";
                txtTotalProjectTime.ForeColor = Color.Red;
                StartNotifications();
            }
        }


        // Add Task To ComboBox
        void RefreshTask()
        {
            if (cbProjects.SelectedIndex == -1) return;

            isRefreshing = true;

            cbTask.Items.Clear();
            clsProject SelectedProject = GetSelectedProject();
            foreach (clsTask Task in SelectedProject.Tasks)
            {
                cbTask.Items.Add(Task);
            }

            if (cbTask.Items.Count > 0)
            {
                cbTask.SelectedIndex = 0;
            }
            else
            {
                cbTask.Text = "";
            }

            isRefreshing = false;
        }


        // Update TextBox according to the selected task. 
        void RefreshTaskDetials()
        {
            clsTask SelectedTask = GetSelectedTask();
            TimeSpan t = TimeSpan.FromSeconds(SelectedTask.TotalTime);
            string timeTemplate = string.Format("{0:D2}:{1:D2}:{2:D2}", (short)t.TotalHours, t.Minutes, t.Seconds);

            txtDetials.AppendText(Environment.NewLine + "Task Name : " + SelectedTask.Name);
            txtDetials.AppendText(Environment.NewLine + "Task Description : " + SelectedTask.Description);
            txtDetials.AppendText(Environment.NewLine + "Task Time : " + timeTemplate);
        }


        // Update TextBox according to the selected Project. 
        void RefreshProjectDetils()
        {
            clsProject SelectedProject = GetSelectedProject();

            txtDetials.Text = "Project Name : " + SelectedProject.Name;
            txtDetials.AppendText(Environment.NewLine + "Project Description : " + SelectedProject.Description);
            txtDetials.AppendText(Environment.NewLine + "Project Expected Time : " + SelectedProject.ExpectedTime + " H ");

        }


        void RefreshDetials()
        {

            if (cbProjects.SelectedIndex == -1) return;

            RefreshProjectDetils();

            if (cbTask.SelectedIndex != -1)
            {
                RefreshTaskDetials();
            }

            UpdateRemainingTime();

        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            frmProjectAdd frm = new frmProjectAdd();
            frm.ShowDialog();
            cbProjects.Items.Clear();

            foreach (clsProject Project in AppData.ProjectsList)
            {
                cbProjects.Items.Add(Project);
            }

            cbProjects.SelectedIndex = cbProjects.Items.Count - 1;
            if (AppData.ProjectsList.Count > 0)
                RefreshProjectDetils();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (cbProjects.SelectedIndex != -1)
            {
                frmAddTask frm = new frmAddTask(cbProjects.SelectedIndex);
                frm.ShowDialog();

                RefreshTask();

                if (cbTask.Items.Count > 0)
                {
                    cbTask.SelectedIndex = cbTask.Items.Count - 1;
                }

                RefreshDetials();
            }
        }


        TimeSpan time;
        DateTime StartTime;
        DateTime EndTime;
        private void btnStart_Click(object sender, EventArgs e)
        {

            StartTime = DateTime.Now;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            time = time.Add(TimeSpan.FromSeconds(1));

            lblTimer.Text = time.ToString(@"hh\:mm\:ss");

        }
        private void btnStope_Click(object sender, EventArgs e)
        {

            timer1.Stop();

            if (cbTask.SelectedIndex == -1) return;

            clsTask selectedTask = GetSelectedTask();
            EndTime = DateTime.Now;
            TimeSpan duration = EndTime - StartTime + TimeSpan.FromMinutes(60);

            selectedTask.TotalTime += (int)duration.TotalSeconds;

            time = TimeSpan.Zero;
            lblTimer.Text = "00:00:00";
            RefreshDetials();
            btnStop.Enabled = false;
            btnStart.Enabled = true;

        }


        private void cbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isRefreshing) return;

            RefreshTask();
            RefreshDetials();
        }
        private void cbTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isRefreshing) return;

            RefreshDetials();
        }



    }
}
