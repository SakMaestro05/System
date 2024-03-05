namespace RMS_Rev
{
    partial class Admin_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxAdminlogin = new System.Windows.Forms.PictureBox();
            this.pnlAdminlogin = new System.Windows.Forms.PictureBox();
            this.tmrAdminlogin = new System.Windows.Forms.Timer(this.components);
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lbluserline = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpassline = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picboxUsericon = new System.Windows.Forms.PictureBox();
            this.picboxPassicon = new System.Windows.Forms.PictureBox();
            this.lblForgot = new System.Windows.Forms.Label();
            this.linklblLogin = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdminlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAdminlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUsericon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPassicon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picboxAdminlogin);
            this.panel1.Controls.Add(this.pnlAdminlogin);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 452);
            this.panel1.TabIndex = 0;
            // 
            // picboxAdminlogin
            // 
            this.picboxAdminlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxAdminlogin.Image = global::RMS_Rev.Properties.Resources.pexels_karina_zhukovskaya_6446709;
            this.picboxAdminlogin.Location = new System.Drawing.Point(0, 0);
            this.picboxAdminlogin.Name = "picboxAdminlogin";
            this.picboxAdminlogin.Size = new System.Drawing.Size(279, 452);
            this.picboxAdminlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxAdminlogin.TabIndex = 1;
            this.picboxAdminlogin.TabStop = false;
            // 
            // pnlAdminlogin
            // 
            this.pnlAdminlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAdminlogin.Location = new System.Drawing.Point(0, 2);
            this.pnlAdminlogin.Name = "pnlAdminlogin";
            this.pnlAdminlogin.Size = new System.Drawing.Size(279, 450);
            this.pnlAdminlogin.TabIndex = 0;
            this.pnlAdminlogin.TabStop = false;
            // 
            // tmrAdminlogin
            // 
            this.tmrAdminlogin.Interval = 2000;
            this.tmrAdminlogin.Tick += new System.EventHandler(this.tmrAdminlogin_Tick);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.Control;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Location = new System.Drawing.Point(339, 146);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(172, 20);
            this.txtuser.TabIndex = 1;
            this.txtuser.MouseEnter += new System.EventHandler(this.txtuser_MouseEnter);
            this.txtuser.MouseLeave += new System.EventHandler(this.txtuser_MouseLeave);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.Control;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Location = new System.Drawing.Point(335, 193);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(176, 20);
            this.txtpass.TabIndex = 2;
            this.txtpass.MouseEnter += new System.EventHandler(this.txtpass_MouseEnter);
            this.txtpass.MouseLeave += new System.EventHandler(this.txtpass_MouseLeave);
            // 
            // lbluserline
            // 
            this.lbluserline.AutoSize = true;
            this.lbluserline.BackColor = System.Drawing.Color.Transparent;
            this.lbluserline.Location = new System.Drawing.Point(336, 157);
            this.lbluserline.Name = "lbluserline";
            this.lbluserline.Size = new System.Drawing.Size(181, 13);
            this.lbluserline.TabIndex = 3;
            this.lbluserline.Text = "_____________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("The Bold Font", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // lblpassline
            // 
            this.lblpassline.AutoSize = true;
            this.lblpassline.BackColor = System.Drawing.Color.Transparent;
            this.lblpassline.Location = new System.Drawing.Point(332, 202);
            this.lblpassline.Name = "lblpassline";
            this.lblpassline.Size = new System.Drawing.Size(181, 13);
            this.lblpassline.TabIndex = 5;
            this.lblpassline.Text = "_____________________________";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(344, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(425, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // picboxUsericon
            // 
            this.picboxUsericon.BackColor = System.Drawing.Color.Transparent;
            this.picboxUsericon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxUsericon.BackgroundImage")));
            this.picboxUsericon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxUsericon.Location = new System.Drawing.Point(308, 146);
            this.picboxUsericon.Name = "picboxUsericon";
            this.picboxUsericon.Size = new System.Drawing.Size(29, 24);
            this.picboxUsericon.TabIndex = 8;
            this.picboxUsericon.TabStop = false;
            // 
            // picboxPassicon
            // 
            this.picboxPassicon.BackColor = System.Drawing.Color.Transparent;
            this.picboxPassicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxPassicon.BackgroundImage")));
            this.picboxPassicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxPassicon.Location = new System.Drawing.Point(306, 193);
            this.picboxPassicon.Name = "picboxPassicon";
            this.picboxPassicon.Size = new System.Drawing.Size(29, 24);
            this.picboxPassicon.TabIndex = 9;
            this.picboxPassicon.TabStop = false;
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.Location = new System.Drawing.Point(311, 238);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(92, 13);
            this.lblForgot.TabIndex = 10;
            this.lblForgot.Text = "Forgot Password?";
            // 
            // linklblLogin
            // 
            this.linklblLogin.AutoSize = true;
            this.linklblLogin.Location = new System.Drawing.Point(400, 238);
            this.linklblLogin.Name = "linklblLogin";
            this.linklblLogin.Size = new System.Drawing.Size(33, 13);
            this.linklblLogin.TabIndex = 11;
            this.linklblLogin.TabStop = true;
            this.linklblLogin.Text = "Login";
            this.linklblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogin_LinkClicked);
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 379);
            this.Controls.Add(this.linklblLogin);
            this.Controls.Add(this.lblForgot);
            this.Controls.Add(this.picboxPassicon);
            this.Controls.Add(this.picboxUsericon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbluserline);
            this.Controls.Add(this.lblpassline);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdminlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAdminlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUsericon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPassicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pnlAdminlogin;
        private System.Windows.Forms.Timer tmrAdminlogin;
        private System.Windows.Forms.PictureBox picboxAdminlogin;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lbluserline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpassline;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picboxUsericon;
        private System.Windows.Forms.PictureBox picboxPassicon;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.LinkLabel linklblLogin;
    }
}