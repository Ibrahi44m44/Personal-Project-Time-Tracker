using Personal_Project_Time_Tracker.DAL;
using Personal_Project_Time_Tracker.Forms;
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
        DateTime StartTime;
        DateTime EndTime;

        clsTask GetSelectedTask()
        {
            clsTask selected = cbTask.SelectedItem as clsTask;
            return selected;
        }

        int GetSelectedProjectID()
        {
            return Convert.ToInt32(cbProjects.SelectedValue);
        }

        void StartNotifications()
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "OverDue";
            notifyIcon1.BalloonTipText = "The Time For Project : " + ProjectService.GetNameById(GetSelectedProjectID()) + " IS Over";
            notifyIcon1.ShowBalloonTip(1000);
        }

        void FillProjectsComboBox()
        {
            isRefreshing = true;
            cbProjects.DataSource = null;
            cbProjects.DataSource = ProjectService.ProjectsList;
            cbProjects.DisplayMember = "Name";
            cbProjects.ValueMember = "ID";
            isRefreshing = false;
            if (cbProjects.Items.Count > 0)
                cbProjects.SelectedIndex = cbProjects.Items.Count - 1;
        }
        void FillTasksComboBox()
        {
            isRefreshing = true;
            cbTask.DataSource = null;
            cbTask.DataSource = ProjectService.GetList(GetSelectedProjectID());
            isRefreshing = false;
        }
        void RefreshTask()
        {
            if (cbProjects.SelectedIndex == -1) return;
            FillTasksComboBox();
        }
        void RefreshTaskDetials()
        {
            clsTask SelectedTask = GetSelectedTask();
            if (SelectedTask == null) return;

            string timeTemplate = "00:00:00";

            if (SelectedTask != null)
            {
                TimeSpan t = TimeSpan.FromSeconds(SelectedTask.TotalTime);
                timeTemplate = string.Format("{0:D2}:{1:D2}:{2:D2}", (int)t.TotalHours, t.Minutes, t.Seconds);
            }

            txtDetials.AppendText(Environment.NewLine + "Task Name : " + SelectedTask.Name.TrimEnd());
            txtDetials.AppendText(Environment.NewLine + "Task Description : " + SelectedTask.Description.TrimEnd());
            txtDetials.AppendText(Environment.NewLine + "Task Time : " + timeTemplate);
        }
        void RefreshProjectDetils(string Name, string Description, int ProjectSeconds)
        {
            txtDetials.AppendText("Project Name : " + Name.TrimEnd());
            txtDetials.AppendText(Environment.NewLine + "Project Description : " + Description.TrimEnd());
            txtDetials.AppendText(Environment.NewLine + "Project Expected Time : " + ProjectService.FormatSecondsToTime(ProjectSeconds));

        }

        void UpdateRemainingTime(int ID)
        {
            int remainingSeconds = ProjectService.GetProjectRemainingTime(ID);
            bool IsOverdue = ProjectService.IsProjectOverdue(ID);
            txtTotalProjectTime.Text = ProjectService.FormatSecondsToTime(remainingSeconds);
            txtTotalProjectTime.ForeColor = IsOverdue ? Color.Red : Color.Black;

            if (IsOverdue)
                StartNotifications();

        }
        void RefreshDetials()
        {

            txtDetials.Clear();

            int ID = GetSelectedProjectID();
            string Name, Description;
            int ExpectedTime;
            ProjectService.GetProjectDataByID(ID, out Name, out Description, out ExpectedTime);

            if (ID != -1)
            {
                RefreshProjectDetils(Name, Description, ExpectedTime);

                if (ProjectService.GetList(ID) != null && ProjectService.GetList(ID).Count > 0)
                    RefreshTaskDetials();

                UpdateRemainingTime(ID);
            }
            else
            {
                txtTotalProjectTime.Clear();
            }

        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            frmProjectAdd frm = new frmProjectAdd();
            frm.ShowDialog();
            FillProjectsComboBox();
            RefreshDetials();
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (cbProjects.SelectedIndex != -1)
            {
                frmAddTask frm = new frmAddTask(GetSelectedProjectID());
                frm.ShowDialog();

                RefreshTask();

                if (cbTask.Items.Count > 0)
                {
                    cbTask.SelectedIndex = cbTask.Items.Count - 1;
                }
                RefreshDetials();
            }
        }



        private void btnStart_Click(object sender, EventArgs e)
        {

            if (cbTask.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task first.");
                return;
            }

            StartTime = DateTime.Now;

            lblTimer.Text = "00:00:00";

            btnStop.Enabled = true;
            btnStart.Enabled = false;

            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan duration = DateTime.Now - StartTime;
            lblTimer.Text = duration.ToString(@"hh\:mm\:ss");

        }
        private void btnStope_Click(object sender, EventArgs e)
        {

            EndTime = DateTime.Now;
            clsTask selectedTask = GetSelectedTask();

            if (selectedTask != null)
            {
                ProjectService.UpdateTaskTime(selectedTask, StartTime, EndTime);

                RefreshDetials();
            }

            timer1.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;

        }


        private void cbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isRefreshing || cbProjects.SelectedValue == null) return;

            RefreshTask();
            RefreshDetials();
        }
        private void cbTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isRefreshing) return;

            RefreshDetials();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEdit frm = new frmEdit(GetSelectedProjectID());
            frm.ShowDialog();
            FillProjectsComboBox();
            RefreshDetials();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int projectID = GetSelectedProjectID();

            if (projectID == -1) return;

            string ProjectName = ProjectService.GetNameById(projectID);

            if (MessageBox.Show($"Are you sure you want to delete: {ProjectName}?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ProjectService.DeleteProject(projectID);

                FillProjectsComboBox();

                if (ProjectService.ProjectsList.Count == 0)
                {
                    cbTask.DataSource = null;
                    txtDetials.Clear();
                    txtTotalProjectTime.Clear();
                }
                else
                {
                    RefreshDetials();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ProjectService.LoadData();
            cbProjects.DataSource = ProjectService.ProjectsList;
            btnStop.Enabled = false;
        }
    }
}
