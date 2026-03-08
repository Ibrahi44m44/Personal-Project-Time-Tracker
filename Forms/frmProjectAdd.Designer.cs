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
            this.components = new System.ComponentModel.Container();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.nudExpectedHours = new System.Windows.Forms.NumericUpDown();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblExpectedTime = new System.Windows.Forms.Label();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudExpectedMinutes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedMinutes)).BeginInit();
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
            // nudExpectedHours
            // 
            this.nudExpectedHours.Location = new System.Drawing.Point(212, 354);
            this.nudExpectedHours.Name = "nudExpectedHours";
            this.nudExpectedHours.Size = new System.Drawing.Size(120, 24);
            this.nudExpectedHours.TabIndex = 2;
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
            this.lblExpectedTime.Size = new System.Drawing.Size(119, 17);
            this.lblExpectedTime.TabIndex = 5;
            this.lblExpectedTime.Text = "Expected time (H)";
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Location = new System.Drawing.Point(365, 371);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(200, 39);
            this.btnSaveProject.TabIndex = 4;
            this.btnSaveProject.Text = "Add Project";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nudExpectedMinutes
            // 
            this.nudExpectedMinutes.Location = new System.Drawing.Point(212, 402);
            this.nudExpectedMinutes.Name = "nudExpectedMinutes";
            this.nudExpectedMinutes.Size = new System.Drawing.Size(120, 24);
            this.nudExpectedMinutes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Expected time (M)";
            // 
            // frmProjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 465);
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
            this.Name = "frmProjectAdd";
            this.Text = "frmProjectAdd";
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.NumericUpDown nudExpectedHours;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblExpectedTime;
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown nudExpectedMinutes;
        private System.Windows.Forms.Label label2;
    }
}