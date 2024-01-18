namespace ToDo.Winform.Forms
{
    partial class frm_NewTaskLog
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_TaskLogTitle = new System.Windows.Forms.TextBox();
            this.lbl_TaskLogTitle = new System.Windows.Forms.Label();
            this.lbl_taskLogDescription = new System.Windows.Forms.Label();
            this.txt_taskLogDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(449, 351);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(133, 41);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Add New Task Log";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_TaskLogTitle
            // 
            this.txt_TaskLogTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TaskLogTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaskLogTitle.Location = new System.Drawing.Point(12, 35);
            this.txt_TaskLogTitle.Name = "txt_TaskLogTitle";
            this.txt_TaskLogTitle.Size = new System.Drawing.Size(570, 36);
            this.txt_TaskLogTitle.TabIndex = 2;
            // 
            // lbl_TaskLogTitle
            // 
            this.lbl_TaskLogTitle.AutoSize = true;
            this.lbl_TaskLogTitle.Location = new System.Drawing.Point(9, 18);
            this.lbl_TaskLogTitle.Name = "lbl_TaskLogTitle";
            this.lbl_TaskLogTitle.Size = new System.Drawing.Size(92, 14);
            this.lbl_TaskLogTitle.TabIndex = 4;
            this.lbl_TaskLogTitle.Text = "Task Log Title :";
            // 
            // lbl_taskLogDescription
            // 
            this.lbl_taskLogDescription.AutoSize = true;
            this.lbl_taskLogDescription.Location = new System.Drawing.Point(9, 76);
            this.lbl_taskLogDescription.Name = "lbl_taskLogDescription";
            this.lbl_taskLogDescription.Size = new System.Drawing.Size(128, 14);
            this.lbl_taskLogDescription.TabIndex = 6;
            this.lbl_taskLogDescription.Text = "Task Log Description :";
            // 
            // txt_taskLogDescription
            // 
            this.txt_taskLogDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_taskLogDescription.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taskLogDescription.Location = new System.Drawing.Point(12, 93);
            this.txt_taskLogDescription.Multiline = true;
            this.txt_taskLogDescription.Name = "txt_taskLogDescription";
            this.txt_taskLogDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_taskLogDescription.Size = new System.Drawing.Size(570, 252);
            this.txt_taskLogDescription.TabIndex = 5;
            // 
            // frm_NewTaskLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 404);
            this.Controls.Add(this.lbl_taskLogDescription);
            this.Controls.Add(this.txt_taskLogDescription);
            this.Controls.Add(this.lbl_TaskLogTitle);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_TaskLogTitle);
            this.Name = "frm_NewTaskLog";
            this.Text = "New Task Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_TaskLogTitle;
        private System.Windows.Forms.Label lbl_TaskLogTitle;
        private System.Windows.Forms.Label lbl_taskLogDescription;
        private System.Windows.Forms.TextBox txt_taskLogDescription;
    }
}