
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

namespace Personal_Project_Time_Tracker
{
    public partial class frmAddProject : Form
    {
        Projects _Project = new Projects();

        public frmAddProject()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProjectName.Text) || (nudHours.Value <= 0 && nudMnutes.Value <= 0))
            {
                MessageBox.Show("Name And Time Requerd");
                return;
            }
            _Project.Name = txtProjectName.Text;
            _Project.Description = txtProjectDesc.Text;
            _Project.TotalTime = Projects.ConvertTimeToSecound((int)nudHours.Value, (int)nudMnutes.Value);
            _Project.ActualTime = 0;
            if (_Project.Save())
            {
                MessageBox.Show("ADD Successfully");
            }
            else
            {
                MessageBox.Show("ADD Faild");
            }
            this.Close();
        }
    }
}
