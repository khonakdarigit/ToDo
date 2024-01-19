namespace ToDo.Winform.Forms
{
    partial class frm_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip_Tasky = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStripTasky = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCompletedTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_MyTask = new System.Windows.Forms.Label();
            this.btn_NewTask = new System.Windows.Forms.Button();
            this.lbl_TaskLogs = new System.Windows.Forms.Label();
            this.btn_AddNewTaskLog = new System.Windows.Forms.Button();
            this.dg_tasks = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompleteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dt_TaskLog = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_EditTask = new System.Windows.Forms.Button();
            this.btn_DeleteTask = new System.Windows.Forms.Button();
            this.toolTipTasky = new System.Windows.Forms.ToolTip(this.components);
            this.btn_DeletTaskLog = new System.Windows.Forms.Button();
            this.btn_EditTaskLog = new System.Windows.Forms.Button();
            this.statusStrip_Tasky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskLogBindingSource)).BeginInit();
            this.menuStripTasky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_TaskLog)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip_Tasky
            // 
            this.statusStrip_Tasky.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip_Tasky.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_ID});
            this.statusStrip_Tasky.Location = new System.Drawing.Point(0, 445);
            this.statusStrip_Tasky.Name = "statusStrip_Tasky";
            this.statusStrip_Tasky.Size = new System.Drawing.Size(991, 22);
            this.statusStrip_Tasky.TabIndex = 5;
            this.statusStrip_Tasky.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_ID
            // 
            this.toolStripStatusLabel_ID.Name = "toolStripStatusLabel_ID";
            this.toolStripStatusLabel_ID.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel_ID.Text = "toolStripStatusLabel_ID";
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(ToDo.Winform.ServiceReference_TaskManager.Task);
            this.taskBindingSource.CurrentChanged += new System.EventHandler(this.taskBindingSource_CurrentChanged);
            // 
            // taskLogBindingSource
            // 
            this.taskLogBindingSource.DataSource = typeof(ToDo.Winform.ServiceReference_TaskLog.TaskLog);
            this.taskLogBindingSource.CurrentChanged += new System.EventHandler(this.taskLogBindingSource_CurrentChanged);
            // 
            // menuStripTasky
            // 
            this.menuStripTasky.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.userInfoToolStripMenuItem});
            this.menuStripTasky.Location = new System.Drawing.Point(0, 0);
            this.menuStripTasky.Name = "menuStripTasky";
            this.menuStripTasky.Size = new System.Drawing.Size(991, 24);
            this.menuStripTasky.TabIndex = 12;
            this.menuStripTasky.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Checked = true;
            this.viewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCompletedTaskToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showCompletedTaskToolStripMenuItem
            // 
            this.showCompletedTaskToolStripMenuItem.Checked = true;
            this.showCompletedTaskToolStripMenuItem.CheckOnClick = true;
            this.showCompletedTaskToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCompletedTaskToolStripMenuItem.Name = "showCompletedTaskToolStripMenuItem";
            this.showCompletedTaskToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.showCompletedTaskToolStripMenuItem.Text = "Show Completed Task";
            this.showCompletedTaskToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showCompletedTaskToolStripMenuItem_CheckedChanged);
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginInformationToolStripMenuItem});
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.userInfoToolStripMenuItem.Text = "User Info";
            // 
            // loginInformationToolStripMenuItem
            // 
            this.loginInformationToolStripMenuItem.Name = "loginInformationToolStripMenuItem";
            this.loginInformationToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.loginInformationToolStripMenuItem.Text = "Login Information";
            // 
            // lbl_MyTask
            // 
            this.lbl_MyTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MyTask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_MyTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_MyTask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MyTask.ForeColor = System.Drawing.Color.Black;
            this.lbl_MyTask.Location = new System.Drawing.Point(10, 32);
            this.lbl_MyTask.Name = "lbl_MyTask";
            this.lbl_MyTask.Size = new System.Drawing.Size(144, 41);
            this.lbl_MyTask.TabIndex = 2;
            this.lbl_MyTask.Text = "My Tasks";
            this.lbl_MyTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_NewTask
            // 
            this.btn_NewTask.Location = new System.Drawing.Point(160, 32);
            this.btn_NewTask.Name = "btn_NewTask";
            this.btn_NewTask.Size = new System.Drawing.Size(43, 41);
            this.btn_NewTask.TabIndex = 3;
            this.btn_NewTask.Text = "➕";
            this.btn_NewTask.UseVisualStyleBackColor = true;
            this.btn_NewTask.Click += new System.EventHandler(this.btn_NewTask_Click);
            this.btn_NewTask.MouseHover += new System.EventHandler(this.btn_NewTask_MouseHover);
            // 
            // lbl_TaskLogs
            // 
            this.lbl_TaskLogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TaskLogs.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_TaskLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TaskLogs.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaskLogs.ForeColor = System.Drawing.Color.Black;
            this.lbl_TaskLogs.Location = new System.Drawing.Point(307, 32);
            this.lbl_TaskLogs.Name = "lbl_TaskLogs";
            this.lbl_TaskLogs.Size = new System.Drawing.Size(523, 41);
            this.lbl_TaskLogs.TabIndex = 7;
            this.lbl_TaskLogs.Text = "Task Logs";
            this.lbl_TaskLogs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AddNewTaskLog
            // 
            this.btn_AddNewTaskLog.Location = new System.Drawing.Point(836, 32);
            this.btn_AddNewTaskLog.Name = "btn_AddNewTaskLog";
            this.btn_AddNewTaskLog.Size = new System.Drawing.Size(43, 41);
            this.btn_AddNewTaskLog.TabIndex = 9;
            this.btn_AddNewTaskLog.Text = "➕";
            this.btn_AddNewTaskLog.UseVisualStyleBackColor = true;
            this.btn_AddNewTaskLog.Click += new System.EventHandler(this.btn_AddNewTaskLog_Click);
            this.btn_AddNewTaskLog.MouseHover += new System.EventHandler(this.btn_AddNewTaskLog_MouseHover);
            // 
            // dg_tasks
            // 
            this.dg_tasks.AllowUserToAddRows = false;
            this.dg_tasks.AllowUserToDeleteRows = false;
            this.dg_tasks.AllowUserToResizeColumns = false;
            this.dg_tasks.AllowUserToResizeRows = false;
            this.dg_tasks.AutoGenerateColumns = false;
            this.dg_tasks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_tasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.isCompleteDataGridViewCheckBoxColumn});
            this.dg_tasks.DataSource = this.taskBindingSource;
            this.dg_tasks.Location = new System.Drawing.Point(10, 79);
            this.dg_tasks.Name = "dg_tasks";
            this.dg_tasks.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dg_tasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_tasks.RowHeadersVisible = false;
            this.dg_tasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_tasks.RowTemplate.Height = 30;
            this.dg_tasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dg_tasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_tasks.Size = new System.Drawing.Size(291, 352);
            this.dg_tasks.TabIndex = 10;
            this.dg_tasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dg_tasks_MouseDoubleClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // isCompleteDataGridViewCheckBoxColumn
            // 
            this.isCompleteDataGridViewCheckBoxColumn.DataPropertyName = "IsComplete";
            this.isCompleteDataGridViewCheckBoxColumn.HeaderText = "IsComplete";
            this.isCompleteDataGridViewCheckBoxColumn.Name = "isCompleteDataGridViewCheckBoxColumn";
            this.isCompleteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isCompleteDataGridViewCheckBoxColumn.Width = 80;
            // 
            // dt_TaskLog
            // 
            this.dt_TaskLog.AllowUserToAddRows = false;
            this.dt_TaskLog.AllowUserToDeleteRows = false;
            this.dt_TaskLog.AllowUserToResizeRows = false;
            this.dt_TaskLog.AutoGenerateColumns = false;
            this.dt_TaskLog.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_TaskLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_TaskLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dt_TaskLog.ColumnHeadersVisible = false;
            this.dt_TaskLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Description,
            this.creationDateDataGridViewTextBoxColumn});
            this.dt_TaskLog.DataSource = this.taskLogBindingSource;
            this.dt_TaskLog.Location = new System.Drawing.Point(307, 79);
            this.dt_TaskLog.MultiSelect = false;
            this.dt_TaskLog.Name = "dt_TaskLog";
            this.dt_TaskLog.ReadOnly = true;
            this.dt_TaskLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dt_TaskLog.RowTemplate.Height = 30;
            this.dt_TaskLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dt_TaskLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_TaskLog.Size = new System.Drawing.Size(670, 352);
            this.dt_TaskLog.TabIndex = 11;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 200;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.creationDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // btn_EditTask
            // 
            this.btn_EditTask.Location = new System.Drawing.Point(209, 32);
            this.btn_EditTask.Name = "btn_EditTask";
            this.btn_EditTask.Size = new System.Drawing.Size(43, 41);
            this.btn_EditTask.TabIndex = 13;
            this.btn_EditTask.Text = "✏️";
            this.btn_EditTask.UseVisualStyleBackColor = true;
            this.btn_EditTask.Click += new System.EventHandler(this.btn_EditTask_Click);
            this.btn_EditTask.MouseHover += new System.EventHandler(this.btn_EditTask_MouseHover);
            // 
            // btn_DeleteTask
            // 
            this.btn_DeleteTask.Location = new System.Drawing.Point(258, 32);
            this.btn_DeleteTask.Name = "btn_DeleteTask";
            this.btn_DeleteTask.Size = new System.Drawing.Size(43, 41);
            this.btn_DeleteTask.TabIndex = 14;
            this.btn_DeleteTask.Text = "🗑️";
            this.btn_DeleteTask.UseVisualStyleBackColor = true;
            this.btn_DeleteTask.Click += new System.EventHandler(this.btn_DeleteTask_Click);
            this.btn_DeleteTask.MouseHover += new System.EventHandler(this.btn_DeleteTask_MouseHover);
            // 
            // btn_DeletTaskLog
            // 
            this.btn_DeletTaskLog.Location = new System.Drawing.Point(934, 32);
            this.btn_DeletTaskLog.Name = "btn_DeletTaskLog";
            this.btn_DeletTaskLog.Size = new System.Drawing.Size(43, 41);
            this.btn_DeletTaskLog.TabIndex = 16;
            this.btn_DeletTaskLog.Text = "🗑️";
            this.btn_DeletTaskLog.UseVisualStyleBackColor = true;
            this.btn_DeletTaskLog.Click += new System.EventHandler(this.btn_DeletTaskLog_Click);
            this.btn_DeletTaskLog.MouseHover += new System.EventHandler(this.btn_DeleteTaskLog_MouseHover);
            // 
            // btn_EditTaskLog
            // 
            this.btn_EditTaskLog.Location = new System.Drawing.Point(885, 32);
            this.btn_EditTaskLog.Name = "btn_EditTaskLog";
            this.btn_EditTaskLog.Size = new System.Drawing.Size(43, 41);
            this.btn_EditTaskLog.TabIndex = 15;
            this.btn_EditTaskLog.Text = "✏️";
            this.btn_EditTaskLog.UseVisualStyleBackColor = true;
            this.btn_EditTaskLog.Click += new System.EventHandler(this.btn_EditTaskLog_Click);
            this.btn_EditTaskLog.MouseHover += new System.EventHandler(this.btn_EditTaskLog_MouseHover);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 467);
            this.Controls.Add(this.btn_DeletTaskLog);
            this.Controls.Add(this.btn_EditTaskLog);
            this.Controls.Add(this.btn_DeleteTask);
            this.Controls.Add(this.btn_EditTask);
            this.Controls.Add(this.dt_TaskLog);
            this.Controls.Add(this.dg_tasks);
            this.Controls.Add(this.btn_AddNewTaskLog);
            this.Controls.Add(this.lbl_TaskLogs);
            this.Controls.Add(this.statusStrip_Tasky);
            this.Controls.Add(this.menuStripTasky);
            this.Controls.Add(this.btn_NewTask);
            this.Controls.Add(this.lbl_MyTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripTasky;
            this.Name = "frm_Main";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.statusStrip_Tasky.ResumeLayout(false);
            this.statusStrip_Tasky.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskLogBindingSource)).EndInit();
            this.menuStripTasky.ResumeLayout(false);
            this.menuStripTasky.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_TaskLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip_Tasky;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ID;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.BindingSource taskLogBindingSource;
        private System.Windows.Forms.MenuStrip menuStripTasky;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCompletedTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginInformationToolStripMenuItem;
        private System.Windows.Forms.Label lbl_MyTask;
        private System.Windows.Forms.Button btn_NewTask;
        private System.Windows.Forms.Label lbl_TaskLogs;
        private System.Windows.Forms.Button btn_AddNewTaskLog;
        private System.Windows.Forms.DataGridView dg_tasks;
        private System.Windows.Forms.DataGridView dt_TaskLog;
        private System.Windows.Forms.Button btn_EditTask;
        private System.Windows.Forms.Button btn_DeleteTask;
        private System.Windows.Forms.ToolTip toolTipTasky;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_DeletTaskLog;
        private System.Windows.Forms.Button btn_EditTaskLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCompleteDataGridViewCheckBoxColumn;
    }
}