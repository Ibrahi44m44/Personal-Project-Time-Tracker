using System;
using BusinessLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Personal_Project_Time_Tracker
{
    public partial class frmAddTask : Form
    {
        Task _Task = new Task();
        int ProjectID = -1;
        public frmAddTask(int ProjectID)
        {
            this.ProjectID = ProjectID;
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskName.Text))
            {
                return;
            }
            _Task.Name = txtTaskName.Text;
            _Task.Description = txtTaskDesc.Text;
            _Task.ProjectID = ProjectID;
            if (_Task.Save())
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
