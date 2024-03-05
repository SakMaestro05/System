namespace RMS_Rev
{
    partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.picboxAdmin = new System.Windows.Forms.PictureBox();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.picboxEmployee = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).BeginInit();
            this.pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmployee)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdmin.Controls.Add(this.lblAdmin);
            this.pnlAdmin.Controls.Add(this.picboxAdmin);
            this.pnlAdmin.Location = new System.Drawing.Point(0, 98);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(415, 354);
            this.pnlAdmin.TabIndex = 0;
            this.pnlAdmin.Click += new System.EventHandler(this.pnlAdmin_Click);
            this.pnlAdmin.MouseEnter += new System.EventHandler(this.pnlAdmin_MouseEnter);
            this.pnlAdmin.MouseLeave += new System.EventHandler(this.pnlAdmin_MouseLeave);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(125, 251);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(167, 40);
            this.lblAdmin.TabIndex = 3;
            this.lblAdmin.Text = "       Manage and \r\nMonitor Your Business";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // picboxAdmin
            // 
            this.picboxAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxAdmin.BackgroundImage")));
            this.picboxAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxAdmin.Location = new System.Drawing.Point(88, 36);
            this.picboxAdmin.Name = "picboxAdmin";
            this.picboxAdmin.Size = new System.Drawing.Size(245, 203);
            this.picboxAdmin.TabIndex = 2;
            this.picboxAdmin.TabStop = false;
            this.picboxAdmin.Click += new System.EventHandler(this.picboxAdmin_Click);
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmployee.Controls.Add(this.lblEmployee);
            this.pnlEmployee.Controls.Add(this.picboxEmployee);
            this.pnlEmployee.Location = new System.Drawing.Point(421, 98);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(379, 354);
            this.pnlEmployee.TabIndex = 2;
            this.pnlEmployee.Click += new System.EventHandler(this.pnlEmployee_Click);
            this.pnlEmployee.MouseEnter += new System.EventHandler(this.pnlEmployee_MouseEnter_1);
            this.pnlEmployee.MouseLeave += new System.EventHandler(this.pnlEmployee_MouseLeave_1);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(122, 251);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(135, 40);
            this.lblEmployee.TabIndex = 5;
            this.lblEmployee.Text = "    Interact with\r\nValued Customers";
            this.lblEmployee.Click += new System.EventHandler(this.lblEmployee_Click);
            // 
            // picboxEmployee
            // 
            this.picboxEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxEmployee.BackgroundImage")));
            this.picboxEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxEmployee.Location = new System.Drawing.Point(80, 36);
            this.picboxEmployee.Name = "picboxEmployee";
            this.picboxEmployee.Size = new System.Drawing.Size(245, 203);
            this.picboxEmployee.TabIndex = 4;
            this.picboxEmployee.TabStop = false;
            this.picboxEmployee.Click += new System.EventHandler(this.picboxEmployee_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.flowLayoutPanel3);
            this.pnlTitle.Location = new System.Drawing.Point(0, -3);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(800, 101);
            this.pnlTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(48, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(675, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Are you an Admin or an Employee?";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(398, 101);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(402, 351);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlEmployee);
            this.Controls.Add(this.pnlAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).EndInit();
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmployee)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox picboxAdmin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.PictureBox picboxEmployee;
    }
}