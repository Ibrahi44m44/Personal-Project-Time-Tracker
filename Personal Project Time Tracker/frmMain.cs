using BusinessLayer;
using Personal_Project_Time_Tracker.Project_Forms;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Personal_Project_Time_Tracker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Notfication
        void StartTimeNotfi()
        {
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.ShowBalloonTip(1500, "Time Tracking", "Time Start ", ToolTipIcon.Warning);

        }
        void StartTimeOverDue()
        {
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.ShowBalloonTip(1500, "NO!", "OVERDUE", ToolTipIcon.Error);
        }

        // Refresh UI
        void _fillCbTasks()
        {
            cbTasks.Items.Clear();
            cbTasks.Text = "";
            DataTable dataTable = Task.GetAllTasks();
            foreach (DataRow Row in dataTable.Rows)
            {
                cbTasks.Items.Add(Row["Name"].ToString());
            }
            if (cbTasks.Items.Count > 0)
                cbTasks.SelectedIndex = 0;
        }
        void _RefreshProject()
        {
            tvProjects.Nodes.Clear();
            DataTable Data = Projects.GetAllProjects();
            for (int i = 0; i < Data.Rows.Count; i++)
            {
                tvProjects.Nodes.Add(Data.Rows[i][1].ToString());
                tvProjects.Nodes[i].Nodes.Add(Data.Rows[i][0].ToString());
                tvProjects.Nodes[i].Nodes.Add("Description : " + Data.Rows[i][2].ToString());
                tvProjects.Nodes[i].Nodes.Add("Total Time : " + Projects.GetTimeString((int)Data.Rows[i][3]));

            }

        }
        void _RefreshTask()
        {
            DataTable dataTable = Task.GetAllTasks();
            dgvTasks.DataSource = dataTable;
            _fillCbTasks();
        }
        void _RefreshTotalTime(bool IsStart = false)
        {
            if (dgvTasks.ColumnCount > 0)
            {

                TimeSpan totalTaskTime = TimeSpan.Zero;

                Task task = Task.Find(cbTasks.Text);
                if (IsStart)
                {
                    if (task.StatusID == 1)
                    {
                        task.StatusID = 2;
                        if (!task.Save())
                        {
                            MessageBox.Show("Task Status Update Faild");
                            return;
                        }
                        _RefreshTask();
                    }
                }
                totalTaskTime = WorkSession.GetTotalTimeForTask(task.Id);
                lblTaskTime.Text = totalTaskTime.ToString(@"hh\:mm\:ss");
                lblTimer.Text = "00:00:00";

                Projects project = Projects.Find(task.ProjectID);
                _RefreshProjectTotalTime(project.Id);




                //DataTable dataTable = Task.GetAllTasks();
                //foreach (DataRow Row in dataTable.Rows)
                //{
                //    if ((string)Row["Name"] == cbTasks.Text)
                //    {
                //        totalTaskTime = WorkSession.GetTotalTimeForTask((int)Row["TaskID"]);
                //    }
                //}

            }

        }
        void _RefreshProjectTotalTime(int projectId)
        {
            Projects projects = Projects.Find(projectId);
            if (projects != null)
            {
                if (projects.CheckOverDue())
                {
                    StartTimeOverDue();
                    lblProjectTime.Text = "OVERDUE";
                    btnStartTimer.Enabled = false;
                }
                else
                {
                    TimeSpan projectTotal = WorkSession.GetTotalTimeForProject(projectId);
                    int TotalSeconds = (int)projectTotal.TotalSeconds;
                    projects.ActualTime = TotalSeconds;
                    if (!projects.Save())
                    {
                        MessageBox.Show("Error in Save Time");
                    }
                    lblProjectTime.Text = projectTotal.ToString(@"hh\:mm\:ss");
                    btnStartTimer.Enabled = true;

                }
            }

        }
        private void cbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            _RefreshTotalTime();
        }
        private void tvProjects_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.GetNodeCount(false) > 0)
            {
                int ProjectID = int.Parse(e.Node.Nodes[0].Text);
                _RefreshProjectTotalTime(ProjectID);
                return;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            _RefreshProject();
            _RefreshTask();
            _fillCbTasks();

            if (cbTasks.Items.Count > 0)
            {

                Task selectedTask = Task.Find(cbTasks.Text);
                if (selectedTask != null)
                {
                    _RefreshTotalTime();
                }
            }

        }

        // Project Operation
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            frmAddProject frm = new frmAddProject();
            frm.ShowDialog();
            _RefreshProject();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvProjects.SelectedNode != null)
            {
                frmEditProject frm = new frmEditProject(int.Parse(tvProjects.SelectedNode.Nodes[0].Text));
                frm.ShowDialog();
                _RefreshProject();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvProjects.SelectedNode != null)
            {
                if (Projects.DeleteProject(int.Parse(tvProjects.SelectedNode.Nodes[0].Text)))
                    MessageBox.Show("Delete Successfully");
                else
                    MessageBox.Show("Delete Faild");
                _RefreshProject();
                _RefreshTask();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        // Task Operation
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (tvProjects.SelectedNode != null)
            {
                int.TryParse(tvProjects.SelectedNode.Nodes[0].Text, out int Id);
                int ID = Id;
                frmAddTask frm = new frmAddTask(Id);
                frm.ShowDialog();
                _RefreshTask();
            }
            else
                MessageBox.Show("Plase Select Project To Add Task");
        }
        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow != null)
            {
                frmEditTask frm = new frmEditTask((int)dgvTasks.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                _RefreshTask();
            }
            else
                MessageBox.Show("Plase Select Task To Edit");
        }
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (Task.DeleteTask((int)dgvTasks.CurrentRow.Cells[0].Value))
                MessageBox.Show("Deleted Successfully");
            else
                MessageBox.Show("Deleted Faild");

            _RefreshTask();
            _RefreshTotalTime();
            _fillCbTasks();
        }

        // Time Operation
        WorkSession session;
        TimeSpan TimeForShow = TimeSpan.Zero;
        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeForShow = TimeForShow.Add(TimeSpan.FromSeconds(1));
            lblTimer.Text = TimeForShow.ToString(@"hh\:mm\:ss");


        }
        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            Task task = Task.Find(cbTasks.Text);
            session = new WorkSession();
            session.StartTime = DateTime.Now;
            session.TaskID = task.Id;
            if (session.AddWorkSession())
            {
                StartTimeNotfi();
                timer1.Start();
            }
            else
                MessageBox.Show("Error");
        }
        private void btnEndTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            session.UpdateWorkSession(DateTime.Now);
            _RefreshTotalTime(true);
            TimeForShow = TimeSpan.Zero;
        }





    }
}
