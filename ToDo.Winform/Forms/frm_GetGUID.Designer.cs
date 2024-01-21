namespace ToDo.Winform.Forms
{
    partial class frm_GetGUID
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
            this.txt_GUID = new System.Windows.Forms.TextBox();
            this.lbl_GUID = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.linkLabel_Register = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txt_GUID
            // 
            this.txt_GUID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GUID.Location = new System.Drawing.Point(12, 56);
            this.txt_GUID.Name = "txt_GUID";
            this.txt_GUID.Size = new System.Drawing.Size(638, 30);
            this.txt_GUID.TabIndex = 0;
            this.txt_GUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_GUID
            // 
            this.lbl_GUID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GUID.Location = new System.Drawing.Point(12, 13);
            this.lbl_GUID.Name = "lbl_GUID";
            this.lbl_GUID.Size = new System.Drawing.Size(638, 40);
            this.lbl_GUID.TabIndex = 1;
            this.lbl_GUID.Text = "Enter Your GUID :";
            this.lbl_GUID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(536, 92);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(114, 42);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // linkLabel_Register
            // 
            this.linkLabel_Register.AutoSize = true;
            this.linkLabel_Register.Location = new System.Drawing.Point(9, 120);
            this.linkLabel_Register.Name = "linkLabel_Register";
            this.linkLabel_Register.Size = new System.Drawing.Size(117, 14);
            this.linkLabel_Register.TabIndex = 4;
            this.linkLabel_Register.TabStop = true;
            this.linkLabel_Register.Text = "Register (Get GUID)";
            this.linkLabel_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Register_LinkClicked);
            // 
            // frm_GetGUID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 143);
            this.Controls.Add(this.linkLabel_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_GUID);
            this.Controls.Add(this.txt_GUID);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "frm_GetGUID";
            this.Text = "GUID";
            this.Load += new System.EventHandler(this.frm_GetGUID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_GUID;
        private System.Windows.Forms.Label lbl_GUID;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.LinkLabel linkLabel_Register;
    }
}