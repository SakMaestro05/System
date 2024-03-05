using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Rev
{
    public partial class Admin_Main : Form
    {
        private Font defaultFont;
        private string _username;

        public Admin_Main()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20;
                Rectangle rect = new Rectangle(0, 0, picbpxBg.Width, picbpxBg.Height);
                path.AddLine(rect.Left + radius, rect.Top, rect.Right - radius, rect.Top);
                path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
                path.AddLine(rect.Right, rect.Top + radius, rect.Right, rect.Bottom - radius);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddLine(rect.Right - radius, rect.Bottom, rect.Left + radius, rect.Bottom);
                path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
                path.AddLine(rect.Left, rect.Bottom - radius, rect.Left, rect.Top + radius);
                path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
                picbpxBg.Region = new Region(path);
            }
        }

        private void Admin_Main_Paint(object sender, PaintEventArgs e)
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

        private void lblmanage_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblManage.Font, FontStyle.Underline);
            lblManage.Font = font;
            lblManage.BackColor = Color.LightGray;
            lblManage.Cursor = Cursors.Hand;
        }

        private void lblManage_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblManage.Font = defaultFont;
            lblManage.BackColor = SystemColors.Control;
            lblManage.Cursor = Cursors.Default;
        }

        private void lblSignout_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblSignout.Font, FontStyle.Underline);
            lblSignout.Font = font;
            lblSignout.BackColor = Color.LightGray;
            lblSignout.Cursor = Cursors.Hand;
        }

        private void lblSignout_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblSignout.Font = defaultFont;
            lblSignout.BackColor = SystemColors.Control;
            lblSignout.Cursor = Cursors.Default;
        }

        private void lblSignout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to sign out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_Login admin_Login = new frm_Login();
                admin_Login.Show();
                this.Hide();
            }
            else
            {
                // do nothing
            }


        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblExit.Font, FontStyle.Underline);
            lblExit.Font = font;
            lblExit.BackColor = Color.LightGray;
            lblExit.Cursor = Cursors.Hand;
        }


        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to sign exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // do nothing
            }
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblExit.Font = defaultFont;
            lblExit.BackColor = SystemColors.Control;
            lblExit.Cursor = Cursors.Default;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            lblSignout.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            lblSignout.Cursor = Cursors.Default;
        }

        private void lblCreate_Click(object sender, EventArgs e)
        {

            Admin_Create Admin_Create = new Admin_Create();
            Admin_Create.Show();
            this.Hide();
        }

        private void picbpxBg_Click(object sender, EventArgs e)
        {

        }

        private void picboxCreate_MouseEnter(object sender, EventArgs e)
        {

            Font font = new Font(picboxCreate.Font, FontStyle.Underline);
            picboxCreate.Font = font;
            picboxCreate.BackColor = Color.LightGray;
            picboxCreate.Cursor = Cursors.Hand;
        }

        private void lblCreate_MouseEnter(object sender, EventArgs e)
        {

            Font font = new Font(lblCreate.Font, FontStyle.Underline);
            lblCreate.Font = font;
            lblCreate.BackColor = Color.LightGray;
            lblCreate.Cursor = Cursors.Hand;
        }

        private void picboxArrow_MouseEnter(object sender, EventArgs e)
        {

            Font font = new Font(picboxArrow.Font, FontStyle.Underline);
            picboxArrow.Font = font;
            picboxArrow.BackColor = Color.LightGray;
            picboxArrow.Cursor = Cursors.Hand;
        }

        private void lblDashboard_MouseEnter(object sender, EventArgs e)
        {

            Font font = new Font(lblDashboard.Font, FontStyle.Underline);
            lblDashboard.Font = font;
            lblDashboard.BackColor = Color.LightGray;
            lblDashboard.Cursor = Cursors.Hand;
        }

        private void lblDashboard_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblDashboard.Font = defaultFont;
            lblDashboard.BackColor = SystemColors.Control;
            lblDashboard.Cursor = Cursors.Default;
        }


        private void lblDashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_dashboard = new Admin_Dashboard();
            admin_dashboard.Show();
            this.Hide();
        }

        private void Admin_Main_Load(object sender, EventArgs e)
        {
            lblManage.BackColor = Color.Gray;
            lblManage.Enabled = false;
        }
    }
}
