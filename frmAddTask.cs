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
    public partial class frmAddTask : Form
    {
        private int ProjectIndex;
        public frmAddTask(int ProjectIndex)
        {
            InitializeComponent();
            this.ProjectIndex = ProjectIndex;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (txtTaskName.Text == string.Empty)
                return;
            if (txtTaskDescription.Text == String.Empty)
                return;

            clsProject SelectedProject = AppData.ProjectsList[ProjectIndex];
            clsTask NewTask = new clsTask();
            NewTask.Name = txtTaskName.Text;
            NewTask.Description = txtTaskDescription.Text;
            SelectedProject.Tasks.Add(NewTask);
            this.Close();
        }


    }
}
