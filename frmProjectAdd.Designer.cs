namespace Personal_Project_Time_Tracker
{
    partial class frmProjectAdd
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
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.nudExpectedTime = new System.Windows.Forms.NumericUpDown();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblExpectedTime = new System.Windows.Forms.Label();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedTime)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(169, 134);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(397, 24);
            this.txtProjectName.TabIndex = 0;
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(169, 200);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(397, 121);
            this.txtProjectDescription.TabIndex = 1;
            // 
            // nudExpectedTime
            // 
            this.nudExpectedTime.Location = new System.Drawing.Point(185, 354);
            this.nudExpectedTime.Name = "nudExpectedTime";
            this.nudExpectedTime.Size = new System.Drawing.Size(120, 24);
            this.nudExpectedTime.TabIndex = 2;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(72, 137);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(91, 17);
            this.lblProjectName.TabIndex = 3;
            this.lblProjectName.Text = "Project Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(72, 255);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 17);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblExpectedTime
            // 
            this.lblExpectedTime.AutoSize = true;
            this.lblExpectedTime.Location = new System.Drawing.Point(72, 354);
            this.lblExpectedTime.Name = "lblExpectedTime";
            this.lblExpectedTime.Size = new System.Drawing.Size(96, 17);
            this.lblExpectedTime.TabIndex = 5;
            this.lblExpectedTime.Text = "Expected time";
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(366, 339);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(200, 39);
            this.btnAddProject.TabIndex = 6;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 32F);
            this.label1.Location = new System.Drawing.Point(105, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 65);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add New Project";
            // 
            // frmProjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.lblExpectedTime);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.nudExpectedTime);
            this.Controls.Add(this.txtProjectDescription);
            this.Controls.Add(this.txtProjectName);
            this.Name = "frmProjectAdd";
            this.Text = "frmProjectAdd";
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.NumericUpDown nudExpectedTime;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblExpectedTime;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Label label1;
    }
}