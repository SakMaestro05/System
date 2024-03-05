namespace RMS_Rev
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblhome = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblSignout = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lbldashboard = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lblPrint = new System.Windows.Forms.Label();
            this.panellabor = new System.Windows.Forms.Panel();
            this.lbllbllabor = new System.Windows.Forms.Label();
            this.lbllabor = new System.Windows.Forms.Label();
            this.lbltodate = new System.Windows.Forms.Label();
            this.panelentries = new System.Windows.Forms.Panel();
            this.lblunpaid = new System.Windows.Forms.Label();
            this.lbllblentries = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.picboxRms = new System.Windows.Forms.PictureBox();
            this.picbpxBg = new System.Windows.Forms.PictureBox();
            this.lbltimer = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rMSRevDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rMS_RevDataSet = new RMS_Rev.RMS_RevDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rMSRevDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.panellabor.SuspendLayout();
            this.panelentries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbpxBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSRevDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMS_RevDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rMSRevDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhome
            // 
            this.lblhome.AutoSize = true;
            this.lblhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhome.Location = new System.Drawing.Point(442, 17);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(39, 13);
            this.lblhome.TabIndex = 53;
            this.lblhome.Text = "Home";
            this.lblhome.Click += new System.EventHandler(this.lblhome_Click);
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(588, 17);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(55, 13);
            this.lblPay.TabIndex = 39;
            this.lblPay.Text = "Payment";
            this.lblPay.Click += new System.EventHandler(this.lblPay_Click);
            // 
            // lblSignout
            // 
            this.lblSignout.AutoSize = true;
            this.lblSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignout.Location = new System.Drawing.Point(773, 17);
            this.lblSignout.Name = "lblSignout";
            this.lblSignout.Size = new System.Drawing.Size(56, 13);
            this.lblSignout.TabIndex = 40;
            this.lblSignout.Text = "Sign Out";
            this.lblSignout.Click += new System.EventHandler(this.lblSignout_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(848, 17);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(28, 13);
            this.lblExit.TabIndex = 41;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lbldashboard
            // 
            this.lbldashboard.AutoSize = true;
            this.lbldashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldashboard.Location = new System.Drawing.Point(502, 17);
            this.lbldashboard.Name = "lbldashboard";
            this.lbldashboard.Size = new System.Drawing.Size(68, 13);
            this.lbldashboard.TabIndex = 52;
            this.lbldashboard.Text = "Dashboard";
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrint.Location = new System.Drawing.Point(661, 17);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(54, 13);
            this.lblPrint.TabIndex = 51;
            this.lblPrint.Text = "Records";
            this.lblPrint.Click += new System.EventHandler(this.lblPrint_Click);
            // 
            // panellabor
            // 
            this.panellabor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panellabor.Controls.Add(this.lbllbllabor);
            this.panellabor.Controls.Add(this.lbllabor);
            this.panellabor.Location = new System.Drawing.Point(289, 118);
            this.panellabor.Name = "panellabor";
            this.panellabor.Size = new System.Drawing.Size(337, 98);
            this.panellabor.TabIndex = 66;
            // 
            // lbllbllabor
            // 
            this.lbllbllabor.AutoSize = true;
            this.lbllbllabor.BackColor = System.Drawing.Color.Transparent;
            this.lbllbllabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllbllabor.ForeColor = System.Drawing.Color.Black;
            this.lbllbllabor.Location = new System.Drawing.Point(102, 61);
            this.lbllbllabor.Name = "lbllbllabor";
            this.lbllbllabor.Size = new System.Drawing.Size(93, 13);
            this.lbllbllabor.TabIndex = 44;
            this.lbllbllabor.Text = "Sales Revenue";
            this.lbllbllabor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbllabor
            // 
            this.lbllabor.AutoSize = true;
            this.lbllabor.Font = new System.Drawing.Font("The Bold Font", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllabor.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbllabor.Location = new System.Drawing.Point(52, 16);
            this.lbllabor.Name = "lbllabor";
            this.lbllabor.Size = new System.Drawing.Size(41, 37);
            this.lbllabor.TabIndex = 9;
            this.lbllabor.Text = "0";
            // 
            // lbltodate
            // 
            this.lbltodate.AutoSize = true;
            this.lbltodate.BackColor = System.Drawing.Color.Transparent;
            this.lbltodate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltodate.ForeColor = System.Drawing.Color.Black;
            this.lbltodate.Location = new System.Drawing.Point(36, 57);
            this.lbltodate.Name = "lbltodate";
            this.lbltodate.Size = new System.Drawing.Size(87, 16);
            this.lbltodate.TabIndex = 59;
            this.lbltodate.Text = "DATE TODAY";
            // 
            // panelentries
            // 
            this.panelentries.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelentries.Controls.Add(this.lblunpaid);
            this.panelentries.Controls.Add(this.lbllblentries);
            this.panelentries.Location = new System.Drawing.Point(289, 222);
            this.panelentries.Name = "panelentries";
            this.panelentries.Size = new System.Drawing.Size(337, 98);
            this.panelentries.TabIndex = 60;
            // 
            // lblunpaid
            // 
            this.lblunpaid.AutoSize = true;
            this.lblunpaid.Font = new System.Drawing.Font("The Bold Font", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunpaid.ForeColor = System.Drawing.Color.Red;
            this.lblunpaid.Location = new System.Drawing.Point(56, 17);
            this.lblunpaid.Name = "lblunpaid";
            this.lblunpaid.Size = new System.Drawing.Size(41, 37);
            this.lblunpaid.TabIndex = 12;
            this.lblunpaid.Text = "0";
            // 
            // lbllblentries
            // 
            this.lbllblentries.AutoSize = true;
            this.lbllblentries.BackColor = System.Drawing.Color.Transparent;
            this.lbllblentries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblentries.ForeColor = System.Drawing.Color.Black;
            this.lbllblentries.Location = new System.Drawing.Point(100, 71);
            this.lbllblentries.Name = "lbllblentries";
            this.lbllblentries.Size = new System.Drawing.Size(128, 13);
            this.lbllblentries.TabIndex = 44;
            this.lbllblentries.Text = "Accounts Receivable";
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // picboxRms
            // 
            this.picboxRms.BackColor = System.Drawing.Color.Transparent;
            this.picboxRms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxRms.BackgroundImage")));
            this.picboxRms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxRms.Location = new System.Drawing.Point(39, 10);
            this.picboxRms.Name = "picboxRms";
            this.picboxRms.Size = new System.Drawing.Size(48, 26);
            this.picboxRms.TabIndex = 37;
            this.picboxRms.TabStop = false;
            // 
            // picbpxBg
            // 
            this.picbpxBg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbpxBg.BackgroundImage")));
            this.picbpxBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbpxBg.Location = new System.Drawing.Point(12, 42);
            this.picbpxBg.Name = "picbpxBg";
            this.picbpxBg.Size = new System.Drawing.Size(878, 401);
            this.picbpxBg.TabIndex = 38;
            this.picbpxBg.TabStop = false;
            this.picbpxBg.Click += new System.EventHandler(this.picbpxBg_Click);
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.BackColor = System.Drawing.Color.Transparent;
            this.lbltimer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.ForeColor = System.Drawing.Color.Black;
            this.lbltimer.Location = new System.Drawing.Point(36, 73);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(85, 16);
            this.lbltimer.TabIndex = 58;
            this.lbltimer.Text = "TIME TODAY";
            this.lbltimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.rMSRevDataSetBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(24, 118);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(259, 306);
            this.chart1.TabIndex = 100;
            this.chart1.Text = "chart1";
            // 
            // rMSRevDataSetBindingSource
            // 
            this.rMSRevDataSetBindingSource.DataSource = this.rMS_RevDataSet;
            this.rMSRevDataSetBindingSource.Position = 0;
            // 
            // rMS_RevDataSet
            // 
            this.rMS_RevDataSet.DataSetName = "RMS_RevDataSet";
            this.rMS_RevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(100, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Total Transaction";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(289, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 98);
            this.panel1.TabIndex = 61;
            // 
            // rMSRevDataSetBindingSource1
            // 
            this.rMSRevDataSetBindingSource1.DataSource = this.rMS_RevDataSet;
            this.rMSRevDataSetBindingSource1.Position = 0;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(632, 118);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(249, 306);
            this.chart2.TabIndex = 101;
            this.chart2.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(721, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Bin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panellabor);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.lbltodate);
            this.Controls.Add(this.panelentries);
            this.Controls.Add(this.lblhome);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.picboxRms);
            this.Controls.Add(this.lbldashboard);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblSignout);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.picbpxBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Dashboard_Paint);
            this.panellabor.ResumeLayout(false);
            this.panellabor.PerformLayout();
            this.panelentries.ResumeLayout(false);
            this.panelentries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbpxBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSRevDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMS_RevDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rMSRevDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbpxBg;
        private System.Windows.Forms.PictureBox picboxRms;
        private System.Windows.Forms.Label lblhome;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblSignout;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lbldashboard;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Panel panellabor;
        private System.Windows.Forms.Label lbllbllabor;
        private System.Windows.Forms.Label lbllabor;
        private System.Windows.Forms.Label lbltodate;
        private System.Windows.Forms.Panel panelentries;
        private System.Windows.Forms.Label lblunpaid;
        private System.Windows.Forms.Label lbllblentries;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource rMSRevDataSetBindingSource;
        private RMS_RevDataSet rMS_RevDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource rMSRevDataSetBindingSource1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label3;
    }
}