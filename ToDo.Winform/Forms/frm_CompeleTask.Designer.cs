namespace ToDo.Winform.Forms
{
    partial class frm_CompeleTask
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
            this.btn_NotComplete = new System.Windows.Forms.Button();
            this.txt_TaskTitle = new System.Windows.Forms.TextBox();
            this.btn_Complete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NotComplete
            // 
            this.btn_NotComplete.Location = new System.Drawing.Point(462, 54);
            this.btn_NotComplete.Name = "btn_NotComplete";
            this.btn_NotComplete.Size = new System.Drawing.Size(120, 41);
            this.btn_NotComplete.TabIndex = 1;
            this.btn_NotComplete.Text = "Not Complete";
            this.btn_NotComplete.UseVisualStyleBackColor = true;
            this.btn_NotComplete.Click += new System.EventHandler(this.btn_NotComplete_Click);
            // 
            // txt_TaskTitle
            // 
            this.txt_TaskTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TaskTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaskTitle.Location = new System.Drawing.Point(12, 12);
            this.txt_TaskTitle.Name = "txt_TaskTitle";
            this.txt_TaskTitle.ReadOnly = true;
            this.txt_TaskTitle.Size = new System.Drawing.Size(570, 36);
            this.txt_TaskTitle.TabIndex = 2;
            this.txt_TaskTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Complete
            // 
            this.btn_Complete.Location = new System.Drawing.Point(336, 54);
            this.btn_Complete.Name = "btn_Complete";
            this.btn_Complete.Size = new System.Drawing.Size(120, 41);
            this.btn_Complete.TabIndex = 0;
            this.btn_Complete.Text = "✔️ Complete";
            this.btn_Complete.UseVisualStyleBackColor = true;
            this.btn_Complete.Click += new System.EventHandler(this.btn_Complete_Click);
            // 
            // frm_CompeleTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 106);
            this.Controls.Add(this.btn_Complete);
            this.Controls.Add(this.btn_NotComplete);
            this.Controls.Add(this.txt_TaskTitle);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "frm_CompeleTask";
            this.Text = "Compele Task";
            this.Load += new System.EventHandler(this.frm_CompeleTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NotComplete;
        private System.Windows.Forms.TextBox txt_TaskTitle;
        private System.Windows.Forms.Button btn_Complete;
    }
}