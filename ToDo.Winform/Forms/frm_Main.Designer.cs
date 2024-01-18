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
            this.lbl_MyTask = new System.Windows.Forms.Label();
            this.btn_NewTask = new System.Windows.Forms.Button();
            this.statusStrip_Tasky = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_TaskLogs = new System.Windows.Forms.Label();
            this.btn_AddNewTaskLog = new System.Windows.Forms.Button();
            this.dg_tasks = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompleteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dt_TaskLog = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip_Tasky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_TaskLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MyTask
            // 
            this.lbl_MyTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MyTask.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_MyTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_MyTask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MyTask.ForeColor = System.Drawing.Color.Black;
            this.lbl_MyTask.Location = new System.Drawing.Point(10, 18);
            this.lbl_MyTask.Name = "lbl_MyTask";
            this.lbl_MyTask.Size = new System.Drawing.Size(242, 41);
            this.lbl_MyTask.TabIndex = 2;
            this.lbl_MyTask.Text = "My Tasks";
            this.lbl_MyTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_NewTask
            // 
            this.btn_NewTask.Location = new System.Drawing.Point(258, 18);
            this.btn_NewTask.Name = "btn_NewTask";
            this.btn_NewTask.Size = new System.Drawing.Size(43, 41);
            this.btn_NewTask.TabIndex = 3;
            this.btn_NewTask.Text = "+";
            this.btn_NewTask.UseVisualStyleBackColor = true;
            this.btn_NewTask.Click += new System.EventHandler(this.btn_NewTask_Click);
            // 
            // statusStrip_Tasky
            // 
            this.statusStrip_Tasky.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip_Tasky.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_ID});
            this.statusStrip_Tasky.Location = new System.Drawing.Point(0, 428);
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
            // lbl_TaskLogs
            // 
            this.lbl_TaskLogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TaskLogs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_TaskLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TaskLogs.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaskLogs.ForeColor = System.Drawing.Color.Black;
            this.lbl_TaskLogs.Location = new System.Drawing.Point(307, 18);
            this.lbl_TaskLogs.Name = "lbl_TaskLogs";
            this.lbl_TaskLogs.Size = new System.Drawing.Size(621, 48);
            this.lbl_TaskLogs.TabIndex = 7;
            this.lbl_TaskLogs.Text = "Task Logs";
            this.lbl_TaskLogs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AddNewTaskLog
            // 
            this.btn_AddNewTaskLog.Location = new System.Drawing.Point(934, 18);
            this.btn_AddNewTaskLog.Name = "btn_AddNewTaskLog";
            this.btn_AddNewTaskLog.Size = new System.Drawing.Size(43, 41);
            this.btn_AddNewTaskLog.TabIndex = 9;
            this.btn_AddNewTaskLog.Text = "+";
            this.btn_AddNewTaskLog.UseVisualStyleBackColor = true;
            this.btn_AddNewTaskLog.Click += new System.EventHandler(this.btn_AddNewTaskLog_Click);
            // 
            // dg_tasks
            // 
            this.dg_tasks.AllowUserToAddRows = false;
            this.dg_tasks.AllowUserToDeleteRows = false;
            this.dg_tasks.AllowUserToResizeRows = false;
            this.dg_tasks.AutoGenerateColumns = false;
            this.dg_tasks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_tasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.isCompleteDataGridViewCheckBoxColumn});
            this.dg_tasks.DataSource = this.taskBindingSource;
            this.dg_tasks.Location = new System.Drawing.Point(10, 65);
            this.dg_tasks.Name = "dg_tasks";
            this.dg_tasks.ReadOnly = true;
            this.dg_tasks.RowHeadersVisible = false;
            this.dg_tasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_tasks.RowTemplate.Height = 30;
            this.dg_tasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dg_tasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_tasks.Size = new System.Drawing.Size(291, 352);
            this.dg_tasks.TabIndex = 10;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isCompleteDataGridViewCheckBoxColumn
            // 
            this.isCompleteDataGridViewCheckBoxColumn.DataPropertyName = "IsComplete";
            this.isCompleteDataGridViewCheckBoxColumn.HeaderText = "IsComplete";
            this.isCompleteDataGridViewCheckBoxColumn.Name = "isCompleteDataGridViewCheckBoxColumn";
            this.isCompleteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isCompleteDataGridViewCheckBoxColumn.Width = 80;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(ToDo.Winform.ServiceReference_TaskManager.Task);
            this.taskBindingSource.CurrentChanged += new System.EventHandler(this.taskBindingSource_CurrentChanged);
            // 
            // dt_TaskLog
            // 
            this.dt_TaskLog.AllowUserToAddRows = false;
            this.dt_TaskLog.AllowUserToDeleteRows = false;
            this.dt_TaskLog.AllowUserToResizeRows = false;
            this.dt_TaskLog.AutoGenerateColumns = false;
            this.dt_TaskLog.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dt_TaskLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dt_TaskLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Description,
            this.creationDateDataGridViewTextBoxColumn});
            this.dt_TaskLog.DataSource = this.taskLogBindingSource;
            this.dt_TaskLog.Location = new System.Drawing.Point(307, 65);
            this.dt_TaskLog.Name = "dt_TaskLog";
            this.dt_TaskLog.ReadOnly = true;
            this.dt_TaskLog.RowHeadersVisible = false;
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
            // 
            // taskLogBindingSource
            // 
            this.taskLogBindingSource.DataSource = typeof(ToDo.Winform.ServiceReference_TaskLog.TaskLog);
            this.taskLogBindingSource.CurrentChanged += new System.EventHandler(this.taskLogBindingSource_CurrentChanged);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.dt_TaskLog);
            this.Controls.Add(this.dg_tasks);
            this.Controls.Add(this.btn_AddNewTaskLog);
            this.Controls.Add(this.lbl_TaskLogs);
            this.Controls.Add(this.statusStrip_Tasky);
            this.Controls.Add(this.btn_NewTask);
            this.Controls.Add(this.lbl_MyTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Main";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.statusStrip_Tasky.ResumeLayout(false);
            this.statusStrip_Tasky.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_TaskLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskLogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_MyTask;
        private System.Windows.Forms.Button btn_NewTask;
        private System.Windows.Forms.StatusStrip statusStrip_Tasky;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ID;
        private System.Windows.Forms.Label lbl_TaskLogs;
        private System.Windows.Forms.Button btn_AddNewTaskLog;
        private System.Windows.Forms.DataGridView dg_tasks;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCompleteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dt_TaskLog;
        private System.Windows.Forms.BindingSource taskLogBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
    }
}