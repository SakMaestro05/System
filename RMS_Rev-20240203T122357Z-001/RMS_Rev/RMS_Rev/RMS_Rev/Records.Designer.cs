namespace RMS_Rev
{
    partial class Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.dtRecords = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picboxRecords = new System.Windows.Forms.PictureBox();
            this.lblPrint = new System.Windows.Forms.Label();
            this.lblExport = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblSignout = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picboxRms = new System.Windows.Forms.PictureBox();
            this.lblhome = new System.Windows.Forms.Label();
            this.lbldashboard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecords)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRms)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRecords
            // 
            this.dtRecords.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRecords.Location = new System.Drawing.Point(26, 105);
            this.dtRecords.Name = "dtRecords";
            this.dtRecords.Size = new System.Drawing.Size(729, 307);
            this.dtRecords.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(26, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(328, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // picboxRecords
            // 
            this.picboxRecords.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxRecords.BackgroundImage")));
            this.picboxRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxRecords.Location = new System.Drawing.Point(5, 58);
            this.picboxRecords.Name = "picboxRecords";
            this.picboxRecords.Size = new System.Drawing.Size(761, 380);
            this.picboxRecords.TabIndex = 2;
            this.picboxRecords.TabStop = false;
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrint.Location = new System.Drawing.Point(34, 4);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(33, 13);
            this.lblPrint.TabIndex = 39;
            this.lblPrint.Text = "Print";
            this.lblPrint.Click += new System.EventHandler(this.lblPrint_Click);
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExport.Location = new System.Drawing.Point(439, 217);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(43, 13);
            this.lblExport.TabIndex = 40;
            this.lblExport.Text = "Export";
            this.lblExport.Click += new System.EventHandler(this.lblExport_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(727, 31);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(28, 13);
            this.lblExit.TabIndex = 92;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblSignout
            // 
            this.lblSignout.AutoSize = true;
            this.lblSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignout.Location = new System.Drawing.Point(666, 31);
            this.lblSignout.Name = "lblSignout";
            this.lblSignout.Size = new System.Drawing.Size(56, 13);
            this.lblSignout.TabIndex = 91;
            this.lblSignout.Text = "Sign Out";
            this.lblSignout.Click += new System.EventHandler(this.lblSignout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPrint);
            this.panel1.Location = new System.Drawing.Point(395, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 24);
            this.panel1.TabIndex = 95;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(358, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // picboxRms
            // 
            this.picboxRms.BackColor = System.Drawing.Color.Transparent;
            this.picboxRms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxRms.BackgroundImage")));
            this.picboxRms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxRms.Location = new System.Drawing.Point(26, 18);
            this.picboxRms.Name = "picboxRms";
            this.picboxRms.Size = new System.Drawing.Size(48, 26);
            this.picboxRms.TabIndex = 97;
            this.picboxRms.TabStop = false;
            // 
            // lblhome
            // 
            this.lblhome.AutoSize = true;
            this.lblhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhome.Location = new System.Drawing.Point(404, 31);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(39, 13);
            this.lblhome.TabIndex = 102;
            this.lblhome.Text = "Home";
            this.lblhome.Click += new System.EventHandler(this.lblhome_Click);
            // 
            // lbldashboard
            // 
            this.lbldashboard.AutoSize = true;
            this.lbldashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldashboard.Location = new System.Drawing.Point(449, 31);
            this.lbldashboard.Name = "lbldashboard";
            this.lbldashboard.Size = new System.Drawing.Size(68, 13);
            this.lbldashboard.TabIndex = 101;
            this.lbldashboard.Text = "Dashboard";
            this.lbldashboard.Click += new System.EventHandler(this.lbldashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Records";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(521, 31);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(55, 13);
            this.lblPay.TabIndex = 99;
            this.lblPay.Text = "Payment";
            this.lblPay.Click += new System.EventHandler(this.lblPay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Bin";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblhome);
            this.Controls.Add(this.lbldashboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.picboxRms);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblSignout);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtRecords);
            this.Controls.Add(this.picboxRecords);
            this.Controls.Add(this.lblExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.Load += new System.EventHandler(this.Records_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Records_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dtRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecords)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtRecords;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picboxRecords;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblSignout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picboxRms;
        private System.Windows.Forms.Label lblhome;
        private System.Windows.Forms.Label lbldashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}