namespace RMS_Rev
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.tmrAdminlogin = new System.Windows.Forms.Timer(this.components);
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbluserline = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblpassline = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.linklblForgot = new System.Windows.Forms.LinkLabel();
            this.picboxRms = new System.Windows.Forms.PictureBox();
            this.btnShowpass = new System.Windows.Forms.Button();
            this.btnHidepass = new System.Windows.Forms.Button();
            this.lblForgot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrAdminlogin
            // 
            this.tmrAdminlogin.Interval = 2000;
            this.tmrAdminlogin.Tick += new System.EventHandler(this.tmrAdminlogin_Tick);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(354, 124);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(172, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Location = new System.Drawing.Point(350, 170);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(176, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpass_KeyPress);
            // 
            // lbluserline
            // 
            this.lbluserline.AutoSize = true;
            this.lbluserline.BackColor = System.Drawing.Color.Transparent;
            this.lbluserline.Location = new System.Drawing.Point(351, 135);
            this.lbluserline.Name = "lbluserline";
            this.lbluserline.Size = new System.Drawing.Size(181, 13);
            this.lbluserline.TabIndex = 3;
            this.lbluserline.Text = "_____________________________";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("The Bold Font", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(287, 46);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(71, 24);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login";
            // 
            // lblpassline
            // 
            this.lblpassline.AutoSize = true;
            this.lblpassline.BackColor = System.Drawing.Color.Transparent;
            this.lblpassline.Location = new System.Drawing.Point(347, 180);
            this.lblpassline.Name = "lblpassline";
            this.lblpassline.Size = new System.Drawing.Size(181, 13);
            this.lblpassline.TabIndex = 5;
            this.lblpassline.Text = "_____________________________";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(339, 264);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(420, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // linklblForgot
            // 
            this.linklblForgot.AutoSize = true;
            this.linklblForgot.Location = new System.Drawing.Point(434, 210);
            this.linklblForgot.Name = "linklblForgot";
            this.linklblForgot.Size = new System.Drawing.Size(62, 13);
            this.linklblForgot.TabIndex = 11;
            this.linklblForgot.TabStop = true;
            this.linklblForgot.Text = "Reset here.";
            this.linklblForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogin_LinkClicked);
            // 
            // picboxRms
            // 
            this.picboxRms.BackColor = System.Drawing.Color.Transparent;
            this.picboxRms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxRms.BackgroundImage")));
            this.picboxRms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxRms.Location = new System.Drawing.Point(502, 6);
            this.picboxRms.Name = "picboxRms";
            this.picboxRms.Size = new System.Drawing.Size(48, 26);
            this.picboxRms.TabIndex = 12;
            this.picboxRms.TabStop = false;
            // 
            // btnShowpass
            // 
            this.btnShowpass.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowpass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowpass.BackgroundImage")));
            this.btnShowpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowpass.FlatAppearance.BorderSize = 0;
            this.btnShowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowpass.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowpass.Location = new System.Drawing.Point(517, 175);
            this.btnShowpass.Name = "btnShowpass";
            this.btnShowpass.Size = new System.Drawing.Size(25, 19);
            this.btnShowpass.TabIndex = 16;
            this.btnShowpass.UseVisualStyleBackColor = false;
            this.btnShowpass.Click += new System.EventHandler(this.btnshowpass_Click);
            this.btnShowpass.MouseEnter += new System.EventHandler(this.btnshowpass_MouseEnter);
            this.btnShowpass.MouseLeave += new System.EventHandler(this.btnshowpass_MouseLeave);
            // 
            // btnHidepass
            // 
            this.btnHidepass.BackColor = System.Drawing.SystemColors.Control;
            this.btnHidepass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHidepass.BackgroundImage")));
            this.btnHidepass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHidepass.FlatAppearance.BorderSize = 0;
            this.btnHidepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHidepass.ForeColor = System.Drawing.Color.Transparent;
            this.btnHidepass.Location = new System.Drawing.Point(517, 172);
            this.btnHidepass.Name = "btnHidepass";
            this.btnHidepass.Size = new System.Drawing.Size(25, 20);
            this.btnHidepass.TabIndex = 17;
            this.btnHidepass.UseVisualStyleBackColor = false;
            this.btnHidepass.Click += new System.EventHandler(this.btnhidepass_Click);
            this.btnHidepass.MouseEnter += new System.EventHandler(this.btnhidepass_MouseEnter);
            this.btnHidepass.MouseLeave += new System.EventHandler(this.btnhidepass_MouseLeave);
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.Location = new System.Drawing.Point(344, 210);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(92, 13);
            this.lblForgot.TabIndex = 18;
            this.lblForgot.Text = "Forgot Password?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(285, 131);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(67, 13);
            this.lblUsername.TabIndex = 36;
            this.lblUsername.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 339);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblForgot);
            this.Controls.Add(this.btnShowpass);
            this.Controls.Add(this.btnHidepass);
            this.Controls.Add(this.picboxRms);
            this.Controls.Add(this.linklblForgot);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbluserline);
            this.Controls.Add(this.lblpassline);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Login";
            this.Load += new System.EventHandler(this.Admin_Login_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Admin_Login_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picboxRms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrAdminlogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbluserline;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblpassline;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel linklblForgot;
        private System.Windows.Forms.PictureBox picboxRms;
        private System.Windows.Forms.Button btnShowpass;
        private System.Windows.Forms.Button btnHidepass;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}