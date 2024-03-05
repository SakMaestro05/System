namespace RMS_Rev
{
    partial class Admin_ResetPass
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
            this.txtAdminnewpass = new System.Windows.Forms.TextBox();
            this.txtAdminconfirmpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAdminnewpass
            // 
            this.txtAdminnewpass.Location = new System.Drawing.Point(174, 113);
            this.txtAdminnewpass.Name = "txtAdminnewpass";
            this.txtAdminnewpass.Size = new System.Drawing.Size(100, 20);
            this.txtAdminnewpass.TabIndex = 0;
            // 
            // txtAdminconfirmpass
            // 
            this.txtAdminconfirmpass.Location = new System.Drawing.Point(174, 159);
            this.txtAdminconfirmpass.Name = "txtAdminconfirmpass";
            this.txtAdminconfirmpass.Size = new System.Drawing.Size(100, 20);
            this.txtAdminconfirmpass.TabIndex = 1;
            // 
            // Admin_ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAdminconfirmpass);
            this.Controls.Add(this.txtAdminnewpass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_ResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_ResetPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtAdminnewpass;
        public System.Windows.Forms.TextBox txtAdminconfirmpass;
    }
}