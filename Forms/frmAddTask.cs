using Personal_Project_Time_Tracker.DAL;
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
        private int _ID;
        public frmAddTask(int ID)
        {
            InitializeComponent();
            this._ID = ID;
        }


        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            if (ProjectService.IsInputInvalid(txtTaskDescription.Text) || ProjectService.IsInputInvalid(txtTaskName.Text))
            {
                MessageBox.Show("The Name And Description Cannot Contian # or : ");
                return;
            }

            clsTask NewTask = new clsTask(txtTaskName.Text, txtTaskDescription.Text);
            ProjectService.AddNewTaskToProject(_ID, NewTask);

            this.Close();
        }
    }
}
