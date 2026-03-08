namespace Personal_Project_Time_Tracker.Forms
{
    partial class frmEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.nudExpectedMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.lblExpectedTime = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.nudExpectedHours = new System.Windows.Forms.NumericUpDown();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Expected time (M)";
            // 
            // nudExpectedMinutes
            // 
            this.nudExpectedMinutes.Location = new System.Drawing.Point(177, 391);
            this.nudExpectedMinutes.Name = "nudExpectedMinutes";
            this.nudExpectedMinutes.Size = new System.Drawing.Size(120, 24);
            this.nudExpectedMinutes.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 32F);
            this.label1.Location = new System.Drawing.Point(142, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 65);
            this.label1.TabIndex = 17;
            this.label1.Text = "Edit Project";
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Location = new System.Drawing.Point(330, 360);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(200, 39);
            this.btnSaveProject.TabIndex = 16;
            this.btnSaveProject.Text = "Save";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // lblExpectedTime
            // 
            this.lblExpectedTime.AutoSize = true;
            this.lblExpectedTime.Location = new System.Drawing.Point(37, 343);
            this.lblExpectedTime.Name = "lblExpectedTime";
            this.lblExpectedTime.Size = new System.Drawing.Size(119, 17);
            this.lblExpectedTime.TabIndex = 15;
            this.lblExpectedTime.Text = "Expected time (H)";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(37, 244);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 17);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(37, 126);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(91, 17);
            this.lblProjectName.TabIndex = 13;
            this.lblProjectName.Text = "Project Name";
            // 
            // nudExpectedHours
            // 
            this.nudExpectedHours.Location = new System.Drawing.Point(177, 343);
            this.nudExpectedHours.Name = "nudExpectedHours";
            this.nudExpectedHours.Size = new System.Drawing.Size(120, 24);
            this.nudExpectedHours.TabIndex = 12;
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(134, 189);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(397, 121);
            this.txtProjectDescription.TabIndex = 11;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(134, 123);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.ReadOnly = true;
            this.txtProjectName.Size = new System.Drawing.Size(397, 24);
            this.txtProjectName.TabIndex = 10;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudExpectedMinutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveProject);
            this.Controls.Add(this.lblExpectedTime);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.nudExpectedHours);
            this.Controls.Add(this.txtProjectDescription);
            this.Controls.Add(this.txtProjectName);
            this.Name = "frmEdit";
            this.Text = "frmEdit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudExpectedMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.Label lblExpectedTime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.NumericUpDown nudExpectedHours;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.TextBox txtProjectName;
    }
}