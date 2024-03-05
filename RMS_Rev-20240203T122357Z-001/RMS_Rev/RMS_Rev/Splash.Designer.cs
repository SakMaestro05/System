namespace RMS_Rev
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.prgSplash = new System.Windows.Forms.ProgressBar();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.lblSplash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prgSplash
            // 
            this.prgSplash.BackColor = System.Drawing.Color.Gainsboro;
            this.prgSplash.ForeColor = System.Drawing.Color.Gainsboro;
            this.prgSplash.Location = new System.Drawing.Point(0, 428);
            this.prgSplash.Name = "prgSplash";
            this.prgSplash.Size = new System.Drawing.Size(801, 23);
            this.prgSplash.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgSplash.TabIndex = 0;
            this.prgSplash.Click += new System.EventHandler(this.prgSplash_Click);
            // 
            // tmrSplash
            // 
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // lblSplash
            // 
            this.lblSplash.AutoSize = true;
            this.lblSplash.BackColor = System.Drawing.Color.Transparent;
            this.lblSplash.Font = new System.Drawing.Font("The Bold Font", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplash.Location = new System.Drawing.Point(12, 59);
            this.lblSplash.Name = "lblSplash";
            this.lblSplash.Size = new System.Drawing.Size(688, 324);
            this.lblSplash.TabIndex = 1;
            this.lblSplash.Text = "Records \r\nManagement \r\nSystem";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSplash);
            this.Controls.Add(this.prgSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgSplash;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.Label lblSplash;
    }
}

