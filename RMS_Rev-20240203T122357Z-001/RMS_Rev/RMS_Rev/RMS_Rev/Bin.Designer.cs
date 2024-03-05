namespace RMS_Rev
{
    partial class Bin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bin));
            this.dtBin = new System.Windows.Forms.DataGridView();
            this.Transaction_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Today = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Middle_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Initial_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picboxRecords = new System.Windows.Forms.PictureBox();
            this.lblhome = new System.Windows.Forms.Label();
            this.lbldashboard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.picboxRms = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblSignout = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRestore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtBin
            // 
            this.dtBin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtBin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transaction_No,
            this.Date_Today,
            this.Time,
            this.First_Name,
            this.Middle_Name,
            this.Last_Name,
            this.Suffix,
            this.Phone,
            this.Address,
            this.Device,
            this.Category,
            this.Service,
            this.Initial_Price,
            this.Status,
            this.Payment_Status});
            this.dtBin.Location = new System.Drawing.Point(30, 125);
            this.dtBin.Name = "dtBin";
            this.dtBin.Size = new System.Drawing.Size(737, 247);
            this.dtBin.TabIndex = 89;
            this.dtBin.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtBin_CellFormatting);
            // 
            // Transaction_No
            // 
            this.Transaction_No.HeaderText = "Transaction_No";
            this.Transaction_No.Name = "Transaction_No";
            // 
            // Date_Today
            // 
            this.Date_Today.HeaderText = "Date_Today";
            this.Date_Today.Name = "Date_Today";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // First_Name
            // 
            this.First_Name.HeaderText = "First_Name";
            this.First_Name.Name = "First_Name";
            // 
            // Middle_Name
            // 
            this.Middle_Name.HeaderText = "Middle_Name";
            this.Middle_Name.Name = "Middle_Name";
            // 
            // Last_Name
            // 
            this.Last_Name.HeaderText = "Last_Name";
            this.Last_Name.Name = "Last_Name";
            // 
            // Suffix
            // 
            this.Suffix.HeaderText = "Suffix";
            this.Suffix.Name = "Suffix";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Device
            // 
            this.Device.HeaderText = "Device";
            this.Device.Name = "Device";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Service
            // 
            this.Service.HeaderText = "Service";
            this.Service.Name = "Service";
            // 
            // Initial_Price
            // 
            this.Initial_Price.HeaderText = "Initial_Price";
            this.Initial_Price.Name = "Initial_Price";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Payment_Status
            // 
            this.Payment_Status.HeaderText = "Payment_Status";
            this.Payment_Status.Name = "Payment_Status";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(31, 99);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(328, 20);
            this.txtSearch.TabIndex = 104;
            // 
            // picboxRecords
            // 
            this.picboxRecords.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxRecords.BackgroundImage")));
            this.picboxRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxRecords.Location = new System.Drawing.Point(9, 55);
            this.picboxRecords.Name = "picboxRecords";
            this.picboxRecords.Size = new System.Drawing.Size(783, 333);
            this.picboxRecords.TabIndex = 105;
            this.picboxRecords.TabStop = false;
            // 
            // lblhome
            // 
            this.lblhome.AutoSize = true;
            this.lblhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhome.Location = new System.Drawing.Point(412, 28);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(39, 13);
            this.lblhome.TabIndex = 116;
            this.lblhome.Text = "Home";
            this.lblhome.Click += new System.EventHandler(this.lblhome_Click);
            // 
            // lbldashboard
            // 
            this.lbldashboard.AutoSize = true;
            this.lbldashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldashboard.Location = new System.Drawing.Point(457, 28);
            this.lbldashboard.Name = "lbldashboard";
            this.lbldashboard.Size = new System.Drawing.Size(68, 13);
            this.lbldashboard.TabIndex = 115;
            this.lbldashboard.Text = "Dashboard";
            this.lbldashboard.Click += new System.EventHandler(this.lbldashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 114;
            this.label1.Text = "Records";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(530, 28);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(55, 13);
            this.lblPay.TabIndex = 113;
            this.lblPay.Text = "Payment";
            this.lblPay.Click += new System.EventHandler(this.lblPay_Click);
            // 
            // picboxRms
            // 
            this.picboxRms.BackColor = System.Drawing.Color.Transparent;
            this.picboxRms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxRms.BackgroundImage")));
            this.picboxRms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxRms.Location = new System.Drawing.Point(30, 15);
            this.picboxRms.Name = "picboxRms";
            this.picboxRms.Size = new System.Drawing.Size(48, 26);
            this.picboxRms.TabIndex = 111;
            this.picboxRms.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(365, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(752, 28);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(28, 13);
            this.lblExit.TabIndex = 107;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblSignout
            // 
            this.lblSignout.AutoSize = true;
            this.lblSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignout.Location = new System.Drawing.Point(677, 28);
            this.lblSignout.Name = "lblSignout";
            this.lblSignout.Size = new System.Drawing.Size(56, 13);
            this.lblSignout.TabIndex = 106;
            this.lblSignout.Text = "Sign Out";
            this.lblSignout.Click += new System.EventHandler(this.lblSignout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "Search and restore deleted records.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 118;
            this.label3.Text = "Bin";
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestore.Location = new System.Drawing.Point(412, 102);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(51, 13);
            this.lblRestore.TabIndex = 119;
            this.lblRestore.Text = "Restore";
            this.lblRestore.Click += new System.EventHandler(this.lblRestore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 120;
            this.label4.Text = "Restore All";
            // 
            // Bin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRestore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblhome);
            this.Controls.Add(this.lbldashboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.picboxRms);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblSignout);
            this.Controls.Add(this.dtBin);
            this.Controls.Add(this.picboxRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bin";
            this.Load += new System.EventHandler(this.Bin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Bin_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dtBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtBin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Today;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Middle_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suffix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Initial_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_Status;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picboxRecords;
        private System.Windows.Forms.Label lblhome;
        private System.Windows.Forms.Label lbldashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.PictureBox picboxRms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblSignout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRestore;
        private System.Windows.Forms.Label label4;
    }
}