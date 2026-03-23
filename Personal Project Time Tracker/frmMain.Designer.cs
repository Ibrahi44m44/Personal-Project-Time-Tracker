namespace Personal_Project_Time_Tracker
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainPanelProject = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvProjects = new System.Windows.Forms.TreeView();
            this.cmsProjects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.MainPanelTime = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTaskTime = new System.Windows.Forms.Label();
            this.lblProjectTime = new System.Windows.Forms.Label();
            this.btnEndTimer = new System.Windows.Forms.Button();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.cbTasks = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainPanelTask = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.MainPanelProject.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cmsProjects.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MainPanelTime.SuspendLayout();
            this.panel9.SuspendLayout();
            this.MainPanelTask.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainPanelProject
            // 
            this.MainPanelProject.Controls.Add(this.panel2);
            this.MainPanelProject.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanelProject.Location = new System.Drawing.Point(0, 0);
            this.MainPanelProject.Name = "MainPanelProject";
            this.MainPanelProject.Size = new System.Drawing.Size(267, 664);
            this.MainPanelProject.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.panel2.Controls.Add(this.tvProjects);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 666);
            this.panel2.TabIndex = 3;
            // 
            // tvProjects
            // 
            this.tvProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.tvProjects.ContextMenuStrip = this.cmsProjects;
            this.tvProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvProjects.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvProjects.ForeColor = System.Drawing.SystemColors.Window;
            this.tvProjects.Location = new System.Drawing.Point(0, 92);
            this.tvProjects.Name = "tvProjects";
            this.tvProjects.Size = new System.Drawing.Size(246, 493);
            this.tvProjects.TabIndex = 7;
            this.tvProjects.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvProjects_NodeMouseClick);
            // 
            // cmsProjects
            // 
            this.cmsProjects.BackColor = global::Personal_Project_Time_Tracker.Properties.Settings.Default.test;
            this.cmsProjects.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Personal_Project_Time_Tracker.Properties.Settings.Default, "test", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmsProjects.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Personal_Project_Time_Tracker.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmsProjects.ForeColor = global::Personal_Project_Time_Tracker.Properties.Settings.Default.TextColor;
            this.cmsProjects.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsProjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsProjects.Name = "cmsProjects";
            this.cmsProjects.Size = new System.Drawing.Size(211, 80);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 92);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Projects";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnAddProject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 585);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 81);
            this.panel1.TabIndex = 2;
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.btnAddProject.FlatAppearance.BorderSize = 0;
            this.btnAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.ForeColor = System.Drawing.Color.White;
            this.btnAddProject.Location = new System.Drawing.Point(53, 21);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(130, 46);
            this.btnAddProject.TabIndex = 0;
            this.btnAddProject.Text = "Add";
            this.btnAddProject.UseVisualStyleBackColor = false;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // MainPanelTime
            // 
            this.MainPanelTime.Controls.Add(this.label5);
            this.MainPanelTime.Controls.Add(this.lbl);
            this.MainPanelTime.Controls.Add(this.lblTaskTime);
            this.MainPanelTime.Controls.Add(this.lblProjectTime);
            this.MainPanelTime.Controls.Add(this.btnEndTimer);
            this.MainPanelTime.Controls.Add(this.btnStartTimer);
            this.MainPanelTime.Controls.Add(this.panel9);
            this.MainPanelTime.Controls.Add(this.cbTasks);
            this.MainPanelTime.Controls.Add(this.label4);
            this.MainPanelTime.Controls.Add(this.label3);
            this.MainPanelTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainPanelTime.Location = new System.Drawing.Point(1088, 0);
            this.MainPanelTime.Name = "MainPanelTime";
            this.MainPanelTime.Size = new System.Drawing.Size(284, 664);
            this.MainPanelTime.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Task Time :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(24, 511);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(163, 29);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "Project Time :";
            // 
            // lblTaskTime
            // 
            this.lblTaskTime.AutoSize = true;
            this.lblTaskTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskTime.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblTaskTime.ForeColor = System.Drawing.Color.White;
            this.lblTaskTime.Location = new System.Drawing.Point(129, 449);
            this.lblTaskTime.Name = "lblTaskTime";
            this.lblTaskTime.Size = new System.Drawing.Size(107, 29);
            this.lblTaskTime.TabIndex = 4;
            this.lblTaskTime.Text = "00:00:00";
            // 
            // lblProjectTime
            // 
            this.lblProjectTime.AutoSize = true;
            this.lblProjectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectTime.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblProjectTime.ForeColor = System.Drawing.Color.White;
            this.lblProjectTime.Location = new System.Drawing.Point(153, 511);
            this.lblProjectTime.Name = "lblProjectTime";
            this.lblProjectTime.Size = new System.Drawing.Size(107, 29);
            this.lblProjectTime.TabIndex = 9;
            this.lblProjectTime.Text = "00:00:00";
            // 
            // btnEndTimer
            // 
            this.btnEndTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.btnEndTimer.FlatAppearance.BorderSize = 0;
            this.btnEndTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndTimer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndTimer.ForeColor = System.Drawing.Color.White;
            this.btnEndTimer.Location = new System.Drawing.Point(165, 333);
            this.btnEndTimer.Name = "btnEndTimer";
            this.btnEndTimer.Size = new System.Drawing.Size(113, 45);
            this.btnEndTimer.TabIndex = 8;
            this.btnEndTimer.Text = "End";
            this.btnEndTimer.UseVisualStyleBackColor = false;
            this.btnEndTimer.Click += new System.EventHandler(this.btnEndTimer_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.btnStartTimer.FlatAppearance.BorderSize = 0;
            this.btnStartTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTimer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTimer.ForeColor = System.Drawing.Color.White;
            this.btnStartTimer.Location = new System.Drawing.Point(29, 333);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(113, 45);
            this.btnStartTimer.TabIndex = 4;
            this.btnStartTimer.Text = "Start";
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.panel9.Controls.Add(this.lblTimer);
            this.panel9.Location = new System.Drawing.Point(29, 216);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(216, 73);
            this.panel9.TabIndex = 7;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(51, 20);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(125, 33);
            this.lblTimer.TabIndex = 8;
            this.lblTimer.Text = "00:00:00";
            // 
            // cbTasks
            // 
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Location = new System.Drawing.Point(55, 149);
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.Size = new System.Drawing.Size(168, 32);
            this.cbTasks.TabIndex = 6;
            this.cbTasks.SelectedIndexChanged += new System.EventHandler(this.cbTasks_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Task :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Timer";
            // 
            // MainPanelTask
            // 
            this.MainPanelTask.Controls.Add(this.panel8);
            this.MainPanelTask.Controls.Add(this.panel5);
            this.MainPanelTask.Controls.Add(this.panel4);
            this.MainPanelTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelTask.Location = new System.Drawing.Point(267, 0);
            this.MainPanelTask.Name = "MainPanelTask";
            this.MainPanelTask.Size = new System.Drawing.Size(821, 664);
            this.MainPanelTask.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.panel8.Controls.Add(this.dgvTasks);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 92);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(821, 491);
            this.panel8.TabIndex = 7;
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTasks.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTasks.Location = new System.Drawing.Point(0, 0);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTasks.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTasks.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dgvTasks.RowTemplate.Height = 26;
            this.dgvTasks.Size = new System.Drawing.Size(821, 491);
            this.dgvTasks.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(821, 92);
            this.panel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task For Projects";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDeleteTask);
            this.panel4.Controls.Add(this.btnAddTask);
            this.panel4.Controls.Add(this.btnEditTask);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 583);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(821, 81);
            this.panel4.TabIndex = 3;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDeleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.btnDeleteTask.FlatAppearance.BorderSize = 0;
            this.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTask.Location = new System.Drawing.Point(650, 23);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(130, 46);
            this.btnDeleteTask.TabIndex = 3;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(38, 23);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(130, 46);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEditTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(142)))));
            this.btnEditTask.FlatAppearance.BorderSize = 0;
            this.btnEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTask.ForeColor = System.Drawing.Color.White;
            this.btnEditTask.Location = new System.Drawing.Point(344, 23);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(130, 46);
            this.btnEditTask.TabIndex = 2;
            this.btnEditTask.Text = "Edit";
            this.btnEditTask.UseVisualStyleBackColor = false;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1372, 664);
            this.Controls.Add(this.MainPanelTask);
            this.Controls.Add(this.MainPanelTime);
            this.Controls.Add(this.MainPanelProject);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.Text = "Project Time Tracker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MainPanelProject.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.cmsProjects.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.MainPanelTime.ResumeLayout(false);
            this.MainPanelTime.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.MainPanelTask.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel MainPanelProject;
        private System.Windows.Forms.Panel MainPanelTime;
        private System.Windows.Forms.Panel MainPanelTask;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ComboBox cbTasks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEndTimer;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.TreeView tvProjects;
        private System.Windows.Forms.Label lblTaskTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblProjectTime;
        private System.Windows.Forms.ContextMenuStrip cmsProjects;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

