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
    public partial class frmProjectAdd : Form
    {
        public frmProjectAdd()
        {
            InitializeComponent();
        }

        public void btnAddProject_Click(object sender, EventArgs e)
        {
            if (txtProjectDescription.Text == string.Empty)
                return;
            if (txtProjectName.Text == string.Empty)
                return;
            if (nudExpectedTime.Value <= 0)
                nudExpectedTime.Value = 1;



            clsProject NewProject = new clsProject();
            NewProject.Name = txtProjectName.Text;
            NewProject.Description = txtProjectDescription.Text;
            NewProject.ExpectedTime = (int)nudExpectedTime.Value;
            AppData.ProjectsList.Add(NewProject);
            this.Close();
        }
    }
}
