namespace Personal_Project_Time_Tracker
{
    partial class Form1
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
            this.cbProjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtTotalProjectTime = new System.Windows.Forms.TextBox();
            this.lblTotalTimeForProject = new System.Windows.Forms.Label();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbTask = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetials = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbProjects
            // 
            this.cbProjects.FormattingEnabled = true;
            this.cbProjects.Location = new System.Drawing.Point(24, 190);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(501, 24);
            this.cbProjects.TabIndex = 0;
            this.cbProjects.SelectedIndexChanged += new System.EventHandler(this.cbProjects_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 44F);
            this.label1.Location = new System.Drawing.Point(88, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 89);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personal Project Time Tracker";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(621, 267);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 79);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Time";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(984, 267);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(151, 79);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stope Time";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStope_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // txtTotalProjectTime
            // 
            this.txtTotalProjectTime.BackColor = System.Drawing.Color.White;
            this.txtTotalProjectTime.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtTotalProjectTime.ForeColor = System.Drawing.Color.Black;
            this.txtTotalProjectTime.Location = new System.Drawing.Point(882, 190);
            this.txtTotalProjectTime.Name = "txtTotalProjectTime";
            this.txtTotalProjectTime.ReadOnly = true;
            this.txtTotalProjectTime.Size = new System.Drawing.Size(253, 40);
            this.txtTotalProjectTime.TabIndex = 9;
            // 
            // lblTotalTimeForProject
            // 
            this.lblTotalTimeForProject.AutoSize = true;
            this.lblTotalTimeForProject.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTotalTimeForProject.Location = new System.Drawing.Point(617, 190);
            this.lblTotalTimeForProject.Name = "lblTotalTimeForProject";
            this.lblTotalTimeForProject.Size = new System.Drawing.Size(259, 24);
            this.lblTotalTimeForProject.TabIndex = 12;
            this.lblTotalTimeForProject.Text = "Total Time For Project (M) :";
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(621, 416);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(218, 79);
            this.btnAddProject.TabIndex = 2;
            this.btnAddProject.Text = "Add New Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 22F);
            this.lblTimer.Location = new System.Drawing.Point(795, 284);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(166, 45);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "00:00:00";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(905, 416);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(218, 79);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add New Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbTask
            // 
            this.cbTask.FormattingEnabled = true;
            this.cbTask.Location = new System.Drawing.Point(24, 267);
            this.cbTask.Name = "cbTask";
            this.cbTask.Size = new System.Drawing.Size(501, 24);
            this.cbTask.TabIndex = 15;
            this.cbTask.SelectedIndexChanged += new System.EventHandler(this.cbTask_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(20, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Projects :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(20, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tasks :";
            // 
            // txtDetials
            // 
            this.txtDetials.Location = new System.Drawing.Point(24, 320);
            this.txtDetials.Multiline = true;
            this.txtDetials.Name = "txtDetials";
            this.txtDetials.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetials.Size = new System.Drawing.Size(501, 175);
            this.txtDetials.TabIndex = 18;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddProject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 554);
            this.Controls.Add(this.txtDetials);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.lblTotalTimeForProject);
            this.Controls.Add(this.txtTotalProjectTime);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txtTotalProjectTime;
        private System.Windows.Forms.Label lblTotalTimeForProject;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetials;
    }
}

