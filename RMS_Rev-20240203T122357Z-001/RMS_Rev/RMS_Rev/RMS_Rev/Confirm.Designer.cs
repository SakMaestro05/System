namespace RMS_Rev
{
    partial class Confirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm));
            this.btnconfirm = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btnShowpass = new System.Windows.Forms.Button();
            this.btnHidepass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(610, 373);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 0;
            this.btnconfirm.Text = "button1";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(391, 170);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(100, 20);
            this.txt_user.TabIndex = 1;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(391, 208);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_pass.TabIndex = 2;
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
            this.btnShowpass.Location = new System.Drawing.Point(497, 209);
            this.btnShowpass.Name = "btnShowpass";
            this.btnShowpass.Size = new System.Drawing.Size(25, 19);
            this.btnShowpass.TabIndex = 33;
            this.btnShowpass.UseVisualStyleBackColor = false;
            this.btnShowpass.Click += new System.EventHandler(this.btnShowpass_Click);
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
            this.btnHidepass.Location = new System.Drawing.Point(497, 209);
            this.btnHidepass.Name = "btnHidepass";
            this.btnHidepass.Size = new System.Drawing.Size(25, 20);
            this.btnHidepass.TabIndex = 34;
            this.btnHidepass.UseVisualStyleBackColor = false;
            this.btnHidepass.Click += new System.EventHandler(this.btnHidepass_Click);
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowpass);
            this.Controls.Add(this.btnHidepass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btnconfirm);
            this.Name = "Confirm";
            this.Text = "Confirm";
            this.Load += new System.EventHandler(this.Confirm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Confirm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Confirm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btnShowpass;
        private System.Windows.Forms.Button btnHidepass;
    }
}