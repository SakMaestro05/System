using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RMS_Rev
{
    public partial class Splash : Form
    {

        private Timer timer;
        private List<string> progressTexts;

        public Splash()
        {
            InitializeComponent();

            progressTexts = new List<string>
            {
                "Loading resources...",
            "Initializing modules...",
            "Preparing data...",
            "Optimizing algorithms...",
            "Checking dependencies...",
            "Configuring settings...",
            "Generating reports...",
            "Processing requests...",
            "Executing tasks...",
            "Verifying credentials..."
            };

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += tmrSplash_Tick;
            timer.Start();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            int index = new Random().Next(progressTexts.Count);
            prgSplash.Value = (prgSplash.Value + 1) % (prgSplash.Maximum + 1);
            prgSplash.CreateGraphics().DrawString(progressTexts[index], new Font("Segoe UI", 10), Brushes.Black,
                new PointF(prgSplash.Width / 2 - 50, prgSplash.Height / 2 - 10));
            if (prgSplash.Value == prgSplash.Maximum)
            {
                timer.Stop();
                frm_Login Admin_Login = new frm_Login();
                Admin_Login.Show();
                Hide();
            }
        }

        private void prgSplash_Click(object sender, EventArgs e)
        {
        }

        private void Splash_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 50;
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
                path.AddLine(rect.Left + radius, rect.Top, rect.Right - radius, rect.Top);
                path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
                path.AddLine(rect.Right, rect.Top + radius, rect.Right, rect.Bottom - radius);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddLine(rect.Right - radius, rect.Bottom, rect.Left + radius, rect.Bottom);
                path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
                path.AddLine(rect.Left, rect.Bottom - radius, rect.Left, rect.Top + radius);
                path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
                this.Region = new Region(path);
            }
        }
    }
}
