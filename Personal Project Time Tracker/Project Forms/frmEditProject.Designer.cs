namespace Personal_Project_Time_Tracker.Project_Forms
{
    partial class frmEditProject
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditProject = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMnutes = new System.Windows.Forms.NumericUpDown();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectDesc = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxEditTime = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMnutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "(Minutes)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "(Hours)";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(254, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 39);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEditProject
            // 
            this.btnEditProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.btnEditProject.FlatAppearance.BorderSize = 0;
            this.btnEditProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProject.Location = new System.Drawing.Point(59, 434);
            this.btnEditProject.Name = "btnEditProject";
            this.btnEditProject.Size = new System.Drawing.Size(162, 39);
            this.btnEditProject.TabIndex = 18;
            this.btnEditProject.Text = "Edit Project";
            this.btnEditProject.UseVisualStyleBackColor = false;
            this.btnEditProject.Click += new System.EventHandler(this.btnEditProject_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Expected Tiem :";
            // 
            // nudMnutes
            // 
            this.nudMnutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.nudMnutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudMnutes.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.nudMnutes.Enabled = false;
            this.nudMnutes.ForeColor = System.Drawing.Color.White;
            this.nudMnutes.Location = new System.Drawing.Point(213, 320);
            this.nudMnutes.Name = "nudMnutes";
            this.nudMnutes.Size = new System.Drawing.Size(100, 28);
            this.nudMnutes.TabIndex = 17;
            this.nudMnutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMnutes.UseWaitCursor = true;
            // 
            // nudHours
            // 
            this.nudHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.nudHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudHours.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.nudHours.Enabled = false;
            this.nudHours.ForeColor = System.Drawing.Color.White;
            this.nudHours.Location = new System.Drawing.Point(213, 282);
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(100, 28);
            this.nudHours.TabIndex = 16;
            this.nudHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHours.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Project Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Proejct Name :";
            // 
            // txtProjectDesc
            // 
            this.txtProjectDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.txtProjectDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjectDesc.ForeColor = System.Drawing.Color.White;
            this.txtProjectDesc.Location = new System.Drawing.Point(213, 214);
            this.txtProjectDesc.Name = "txtProjectDesc";
            this.txtProjectDesc.Size = new System.Drawing.Size(211, 25);
            this.txtProjectDesc.TabIndex = 15;
            // 
            // txtProjectName
            // 
            this.txtProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.txtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjectName.ForeColor = System.Drawing.Color.White;
            this.txtProjectName.Location = new System.Drawing.Point(213, 134);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(211, 25);
            this.txtProjectName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label3.Location = new System.Drawing.Point(110, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 36);
            this.label3.TabIndex = 23;
            this.label3.Text = "Add Edit Project";
            // 
            // checkBoxEditTime
            // 
            this.checkBoxEditTime.AutoSize = true;
            this.checkBoxEditTime.Location = new System.Drawing.Point(68, 368);
            this.checkBoxEditTime.Name = "checkBoxEditTime";
            this.checkBoxEditTime.Size = new System.Drawing.Size(182, 28);
            this.checkBoxEditTime.TabIndex = 26;
            this.checkBoxEditTime.Text = "I Need Edit Time";
            this.checkBoxEditTime.UseVisualStyleBackColor = true;
            this.checkBoxEditTime.CheckedChanged += new System.EventHandler(this.checkBoxEditTime_CheckedChanged);
            // 
            // frmEditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(466, 532);
            this.Controls.Add(this.checkBoxEditTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditProject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudMnutes);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProjectDesc);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmEditProject";
            this.Text = "frmEditProject";
            this.Load += new System.EventHandler(this.frmEditProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMnutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditProject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMnutes;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjectDesc;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxEditTime;
    }
}