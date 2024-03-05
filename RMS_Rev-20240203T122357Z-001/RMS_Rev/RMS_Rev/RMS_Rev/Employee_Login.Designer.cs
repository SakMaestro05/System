namespace RMS_Rev
{
    partial class Employee_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxEmployeelogin = new System.Windows.Forms.PictureBox();
            this.pnlAdminlogin = new System.Windows.Forms.PictureBox();
            this.tmrAdminlogin = new System.Windows.Forms.Timer(this.components);
            this.linklblLogin = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUserline = new System.Windows.Forms.Label();
            this.lblPassline = new System.Windows.Forms.Label();
            this.picboxLock = new System.Windows.Forms.PictureBox();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            this.picboxRms = new System.Windows.Forms.PictureBox();
            this.btnshowpass = new System.Windows.Forms.Button();
            this.btnhidepass = new System.Windows.Forms.Button();
            this.linklblSignup = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmployeelogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAdminlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picboxEmployeelogin);
            this.panel1.Controls.Add(this.pnlAdminlogin);
            this.panel1.Location = new System.Drawing.Point(0, -56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 452);
            this.panel1.TabIndex = 12;
            // 
            // picboxEmployeelogin
            // 
            this.picboxEmployeelogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxEmployeelogin.Image = global::RMS_Rev.Properties.Resources.pexels_karina_zhukovskaya_6446709;
            this.picboxEmployeelogin.Location = new System.Drawing.Point(-21, 0);
            this.picboxEmployeelogin.Name = "picboxEmployeelogin";
            this.picboxEmployeelogin.Size = new System.Drawing.Size(279, 452);
            this.picboxEmployeelogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxEmployeelogin.TabIndex = 1;
            this.picboxEmployeelogin.TabStop = false;
            // 
            // pnlAdminlogin
            // 
            this.pnlAdminlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAdminlogin.Location = new System.Drawing.Point(-20, 2);
            this.pnlAdminlogin.Name = "pnlAdminlogin";
            this.pnlAdminlogin.Size = new System.Drawing.Size(279, 450);
            this.pnlAdminlogin.TabIndex = 0;
            this.pnlAdminlogin.TabStop = false;
            // 
            // tmrAdminlogin
            // 
            this.tmrAdminlogin.Interval = 2000;
            // 
            // linklblLogin
            // 
            this.linklblLogin.AutoSize = true;
            this.linklblLogin.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linklblLogin.Location = new System.Drawing.Point(355, 231);
            this.linklblLogin.Name = "linklblLogin";
            this.linklblLogin.Size = new System.Drawing.Size(92, 13);
            this.linklblLogin.TabIndex = 23;
            this.linklblLogin.TabStop = true;
            this.linklblLogin.Text = "Forgot Password?";
            this.linklblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogin_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(409, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(327, 253);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(75, 23);
            this.btnSignup.TabIndex = 18;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            this.btnSignup.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnSignup.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("The Bold Font", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(267, 51);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(85, 24);
            this.lblLogin.TabIndex = 16;
            this.lblLogin.Text = "SIGN UP";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Location = new System.Drawing.Point(302, 130);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(182, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.MouseEnter += new System.EventHandler(this.txtpass_MouseEnter);
            this.txtPass.MouseLeave += new System.EventHandler(this.txtpass_MouseLeave);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(306, 83);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(178, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            this.txtUser.MouseEnter += new System.EventHandler(this.txtuser_MouseEnter);
            this.txtUser.MouseLeave += new System.EventHandler(this.txtuser_MouseLeave);
            // 
            // lblUserline
            // 
            this.lblUserline.AutoSize = true;
            this.lblUserline.BackColor = System.Drawing.Color.Transparent;
            this.lblUserline.Location = new System.Drawing.Point(303, 94);
            this.lblUserline.Name = "lblUserline";
            this.lblUserline.Size = new System.Drawing.Size(187, 13);
            this.lblUserline.TabIndex = 15;
            this.lblUserline.Text = "______________________________";
            // 
            // lblPassline
            // 
            this.lblPassline.AutoSize = true;
            this.lblPassline.BackColor = System.Drawing.Color.Transparent;
            this.lblPassline.Location = new System.Drawing.Point(299, 139);
            this.lblPassline.Name = "lblPassline";
            this.lblPassline.Size = new System.Drawing.Size(187, 13);
            this.lblPassline.TabIndex = 17;
            this.lblPassline.Text = "______________________________";
            // 
            // picboxLock
            // 
            this.picboxLock.BackColor = System.Drawing.Color.Transparent;
            this.picboxLock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxLock.BackgroundImage")));
            this.picboxLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxLock.Location = new System.Drawing.Point(273, 130);
            this.picboxLock.Name = "picboxLock";
            this.picboxLock.Size = new System.Drawing.Size(29, 24);
            this.picboxLock.TabIndex = 21;
            this.picboxLock.TabStop = false;
            // 
            // picboxUser
            // 
            this.picboxUser.BackColor = System.Drawing.Color.Transparent;
            this.picboxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxUser.BackgroundImage")));
            this.picboxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxUser.Location = new System.Drawing.Point(275, 83);
            this.picboxUser.Name = "picboxUser";
            this.picboxUser.Size = new System.Drawing.Size(29, 24);
            this.picboxUser.TabIndex = 20;
            this.picboxUser.TabStop = false;
            // 
            // picboxRms
            // 
            this.picboxRms.BackColor = System.Drawing.Color.Transparent;
            this.picboxRms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxRms.BackgroundImage")));
            this.picboxRms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxRms.Location = new System.Drawing.Point(503, 8);
            this.picboxRms.Name = "picboxRms";
            this.picboxRms.Size = new System.Drawing.Size(48, 26);
            this.picboxRms.TabIndex = 24;
            this.picboxRms.TabStop = false;
            // 
            // btnshowpass
            // 
            this.btnshowpass.BackColor = System.Drawing.SystemColors.Control;
            this.btnshowpass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnshowpass.BackgroundImage")));
            this.btnshowpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshowpass.FlatAppearance.BorderSize = 0;
            this.btnshowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowpass.ForeColor = System.Drawing.Color.Transparent;
            this.btnshowpass.Location = new System.Drawing.Point(485, 132);
            this.btnshowpass.Name = "btnshowpass";
            this.btnshowpass.Size = new System.Drawing.Size(25, 19);
            this.btnshowpass.TabIndex = 25;
            this.btnshowpass.UseVisualStyleBackColor = false;
            this.btnshowpass.Click += new System.EventHandler(this.btnshowpass_Click);
            this.btnshowpass.MouseEnter += new System.EventHandler(this.btnshowpass_MouseEnter);
            this.btnshowpass.MouseLeave += new System.EventHandler(this.btnshowpass_MouseLeave);
            // 
            // btnhidepass
            // 
            this.btnhidepass.BackColor = System.Drawing.SystemColors.Control;
            this.btnhidepass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhidepass.BackgroundImage")));
            this.btnhidepass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhidepass.FlatAppearance.BorderSize = 0;
            this.btnhidepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhidepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhidepass.ForeColor = System.Drawing.Color.Transparent;
            this.btnhidepass.Location = new System.Drawing.Point(485, 131);
            this.btnhidepass.Name = "btnhidepass";
            this.btnhidepass.Size = new System.Drawing.Size(25, 20);
            this.btnhidepass.TabIndex = 26;
            this.btnhidepass.UseVisualStyleBackColor = false;
            this.btnhidepass.Click += new System.EventHandler(this.btnhidepass_Click);
            this.btnhidepass.MouseEnter += new System.EventHandler(this.btnhidepass_MouseEnter);
            this.btnhidepass.MouseLeave += new System.EventHandler(this.btnhidepass_MouseLeave);
            // 
            // linklblSignup
            // 
            this.linklblSignup.AutoSize = true;
            this.linklblSignup.Location = new System.Drawing.Point(311, 216);
            this.linklblSignup.Name = "linklblSignup";
            this.linklblSignup.Size = new System.Drawing.Size(124, 13);
            this.linklblSignup.TabIndex = 28;
            this.linklblSignup.Text = "Don\'t have account yet?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(434, 216);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 13);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(277, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 24);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.Control;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Location = new System.Drawing.Point(308, 165);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(178, 20);
            this.txtemail.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(305, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "______________________________";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(277, 314);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbAdmin.TabIndex = 38;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Location = new System.Drawing.Point(368, 314);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(71, 17);
            this.rbEmployee.TabIndex = 39;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Employee";
            this.rbEmployee.UseVisualStyleBackColor = true;
            // 
            // Employee_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 379);
            this.Controls.Add(this.rbEmployee);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linklblSignup);
            this.Controls.Add(this.btnshowpass);
            this.Controls.Add(this.btnhidepass);
            this.Controls.Add(this.picboxRms);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linklblLogin);
            this.Controls.Add(this.picboxLock);
            this.Controls.Add(this.picboxUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUserline);
            this.Controls.Add(this.lblPassline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Login";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Employee_Login_Paint);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmployeelogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAdminlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picboxEmployeelogin;
        private System.Windows.Forms.PictureBox pnlAdminlogin;
        private System.Windows.Forms.Timer tmrAdminlogin;
        private System.Windows.Forms.LinkLabel linklblLogin;
        private System.Windows.Forms.PictureBox picboxLock;
        private System.Windows.Forms.PictureBox picboxUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUserline;
        private System.Windows.Forms.Label lblPassline;
        private System.Windows.Forms.PictureBox picboxRms;
        private System.Windows.Forms.Button btnshowpass;
        private System.Windows.Forms.Button btnhidepass;
        private System.Windows.Forms.Label linklblSignup;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbEmployee;
    }
}