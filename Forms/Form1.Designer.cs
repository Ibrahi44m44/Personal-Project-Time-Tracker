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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbProjects
            // 
            this.cbProjects.DisplayMember = "Name";
            this.cbProjects.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbProjects.FormattingEnabled = true;
            this.cbProjects.Location = new System.Drawing.Point(24, 192);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(501, 36);
            this.cbProjects.TabIndex = 0;
            this.cbProjects.ValueMember = "ID";
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
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
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
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
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
            this.txtTotalProjectTime.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.txtTotalProjectTime.ForeColor = System.Drawing.Color.Black;
            this.txtTotalProjectTime.Location = new System.Drawing.Point(882, 192);
            this.txtTotalProjectTime.Name = "txtTotalProjectTime";
            this.txtTotalProjectTime.ReadOnly = true;
            this.txtTotalProjectTime.Size = new System.Drawing.Size(253, 40);
            this.txtTotalProjectTime.TabIndex = 9;
            // 
            // lblTotalTimeForProject
            // 
            this.lblTotalTimeForProject.AutoSize = true;
            this.lblTotalTimeForProject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalTimeForProject.Location = new System.Drawing.Point(552, 192);
            this.lblTotalTimeForProject.Name = "lblTotalTimeForProject";
            this.lblTotalTimeForProject.Size = new System.Drawing.Size(287, 24);
            this.lblTotalTimeForProject.TabIndex = 12;
            this.lblTotalTimeForProject.Text = "Total Time For Project (M) :";
            // 
            // btnAddProject
            // 
            this.btnAddProject.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
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
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(778, 285);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(190, 45);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "00:00:00";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
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
            this.cbTask.DisplayMember = "Name";
            this.cbTask.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbTask.FormattingEnabled = true;
            this.cbTask.Location = new System.Drawing.Point(24, 267);
            this.cbTask.Name = "cbTask";
            this.cbTask.Size = new System.Drawing.Size(501, 36);
            this.cbTask.TabIndex = 15;
            this.cbTask.SelectedIndexChanged += new System.EventHandler(this.cbTask_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Projects :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tasks :";
            // 
            // txtDetials
            // 
            this.txtDetials.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtDetials.Location = new System.Drawing.Point(24, 320);
            this.txtDetials.Multiline = true;
            this.txtDetials.Name = "txtDetials";
            this.txtDetials.ReadOnly = true;
            this.txtDetials.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetials.Size = new System.Drawing.Size(501, 175);
            this.txtDetials.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(24, 522);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 79);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete Project";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(380, 522);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 79);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit Project";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddProject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1211, 614);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}

