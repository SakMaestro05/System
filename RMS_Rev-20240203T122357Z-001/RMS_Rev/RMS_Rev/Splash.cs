using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                Authentication authentication = new Authentication();
                authentication.Show();
                Hide();
            }
        }

        private void prgSplash_Click(object sender, EventArgs e)
        {
        }
    }
}

