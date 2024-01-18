namespace ToDo.Winform.Forms
{
    partial class frm_NewTask
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
            this.txt_TaskTitle = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_TaskTitle
            // 
            this.txt_TaskTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TaskTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaskTitle.Location = new System.Drawing.Point(12, 21);
            this.txt_TaskTitle.Name = "txt_TaskTitle";
            this.txt_TaskTitle.Size = new System.Drawing.Size(570, 36);
            this.txt_TaskTitle.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(462, 63);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 41);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Add New Task";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 117);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_TaskTitle);
            this.Name = "frm_NewTask";
            this.Text = "New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TaskTitle;
        private System.Windows.Forms.Button btn_Save;
    }
}