namespace Personal_Project_Time_Tracker
{
    partial class frmAddTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 32F);
            this.label1.Location = new System.Drawing.Point(100, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 65);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add New Task";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(184, 307);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(200, 39);
            this.btnAddTask.TabIndex = 14;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(46, 226);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 17);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(46, 148);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(75, 17);
            this.lblProjectName.TabIndex = 11;
            this.lblProjectName.Text = "Task Name";
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(143, 200);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(397, 72);
            this.txtTaskDescription.TabIndex = 9;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(143, 145);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(397, 24);
            this.txtTaskName.TabIndex = 8;
            // 
            // frmAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 378);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTask);
            this.Name = "frmAddTask";
            this.Text = "frmAddTask";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.TextBox txtTaskName;
    }
}