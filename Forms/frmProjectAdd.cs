using Personal_Project_Time_Tracker.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Project_Time_Tracker
{
    public partial class frmProjectAdd : Form
    {
        public frmProjectAdd()
        {
            InitializeComponent();
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            if (ProjectService.IsInputInvalid(txtProjectDescription.Text) || ProjectService.IsInputInvalid(txtProjectName.Text))
            {
                MessageBox.Show("The Name And Description Cannot Contian # or : ");
                return;
            }

            int ExpTime = (int)(nudExpectedHours.Value * 3600 + nudExpectedMinutes.Value * 60);
            int NewId = ProjectService.GetNextProjectID();
            clsProject NewProject = new clsProject(NewId, txtProjectName.Text, txtProjectDescription.Text, ExpTime);

            ProjectService.AddNewProject(NewProject);
            this.Close();
        }
    }
}
