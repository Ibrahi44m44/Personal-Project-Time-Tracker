using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Project_Time_Tracker.Forms
{
    public partial class frmEdit : Form
    {
        private int _ID;
        private TimeSpan Time;
        public frmEdit(int ID)
        {
            _ID = ID;
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            string Name, Description;
            int ExpectedTime;

            ProjectService.GetProjectDataByID(_ID, out Name, out Description, out ExpectedTime);

            txtProjectName.Text = Name;
            txtProjectDescription.Text = Description;

            TimeSpan t = TimeSpan.FromSeconds(ExpectedTime);
            nudExpectedHours.Value = (int)t.TotalHours;
            nudExpectedMinutes.Value = t.Minutes;
        }
        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            if (ProjectService.IsInputInvalid(txtProjectDescription.Text) || ProjectService.IsInputInvalid(txtProjectName.Text))
            {
                MessageBox.Show("The Name And Description Cannot Contian # or : ");
                return;
            }

            int ExpTime = (int)(nudExpectedHours.Value * 3600 + nudExpectedMinutes.Value * 60);


            if (ProjectService.UpdateProject(_ID, txtProjectName.Text, txtProjectDescription.Text, ExpTime))
                MessageBox.Show("Update Sussccfuly");
            else
                MessageBox.Show("Error");
            this.Close();
        }


    }
}
