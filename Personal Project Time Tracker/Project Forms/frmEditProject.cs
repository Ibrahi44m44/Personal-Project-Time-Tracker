using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Project_Time_Tracker.Project_Forms
{
    public partial class frmEditProject : Form
    {
        int _ProjectID = -1;
        Projects _Project = new Projects();
        public frmEditProject(int ProjectID)
        {
            InitializeComponent();
            _ProjectID = ProjectID;
        }
        private void frmEditProject_Load(object sender, EventArgs e)
        {
            _Project = Projects.Find(_ProjectID);
            if (_Project != null)
            {
                txtProjectDesc.Text = _Project.Description;
                txtProjectName.Text = _Project.Name;
                TimeSpan Time = TimeSpan.FromSeconds(_Project.TotalTime);
                nudHours.Value = Time.Hours;
                nudMnutes.Value = Time.Minutes;
            }

        }
        private void btnEditProject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProjectName.Text) || (nudHours.Value <= 0 && nudMnutes.Value <= 0))
            {
                MessageBox.Show("Name And Time Requerd");
                return;
            }
            _Project.Description = txtProjectDesc.Text;
            _Project.Name = txtProjectName.Text;
            int Total = Projects.ConvertTimeToSecound((int)nudHours.Value, (int)nudMnutes.Value);
            _Project.TotalTime = Total;

            if (_Project.Save())
                MessageBox.Show("Update SuccessFully");
            else
                MessageBox.Show("Update Falid");
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxEditTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEditTime.Checked)
            {
                nudMnutes.Enabled = true;
                nudHours.Enabled = true;
            }
        }
    }
}
