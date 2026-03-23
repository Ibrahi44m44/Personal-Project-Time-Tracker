using System;
using BusinessLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessServices;

namespace Personal_Project_Time_Tracker
{
    public partial class frmEditTask : Form
    {
        static int _TaskID { get; set; } = -1;
        Task _Task;
        public frmEditTask(int TaskID)
        {
            InitializeComponent();
            _TaskID = TaskID;
            _Task = Task.Find(_TaskID);
        }

        private void frmEditTask_Load(object sender, EventArgs e)
        {

            if (_Task != null)
            {
                txtTaskDesc.Text = _Task.Description;
                txtTaskName.Text = _Task.Name;
                DataTable dataTable = Status.GetAllStatus();
                foreach (DataRow Row in dataTable.Rows)
                {
                    cbStatus.Items.Add(Row["Name"].ToString());
                }

                cbStatus.SelectedIndex = 0;
            }
            else
                this.Close();
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskName.Text))
            {
                return;
            }
            _Task.Name = txtTaskName.Text;
            _Task.Description = txtTaskDesc.Text;
            _Task.StatusID = Status.GetStatusID(cbStatus.SelectedItem.ToString());
            if (_Task.Save())
                MessageBox.Show("Edit Task " + _TaskID + " Successfully");
            else
                MessageBox.Show("Edit Task " + _TaskID + " Faild");

            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
