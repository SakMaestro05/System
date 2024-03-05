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
    public partial class Employee_Main : Form
    {
        public Employee_Main()
        {
            InitializeComponent();

        }

       

        private void lblManage_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblPay.Font = defaultFont;
            lblPay.BackColor = SystemColors.Control;
            lblPay.Cursor = Cursors.Default;
        }

        private void lblTrans_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblPay.Font, FontStyle.Underline);
            lblPay.Font = font;
            lblPay.BackColor = Color.LightGray;
            lblPay.Cursor = Cursors.Hand;
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

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblExit.Font = defaultFont;
            lblExit.BackColor = SystemColors.Control;
            lblExit.Cursor = Cursors.Default;
        }

        private void picboxSettings_MouseEnter(object sender, EventArgs e)
        {
            lblSignout.Cursor = Cursors.Hand;
        }

        private void picboxSettings_MouseLeave(object sender, EventArgs e)
        {
            lblSignout.Cursor = Cursors.Default;
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblExit.Font, FontStyle.Underline);
            lblExit.Font = font;
            lblExit.BackColor = Color.LightGray;
            lblExit.Cursor = Cursors.Hand;
        }

        private void lblTrans_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.ShowDialog();
            this.Show();

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

        private void lblSignout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to sign out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_Login employee_Login = new frm_Login();
                employee_Login.Show();
                this.Hide();
            }
            else
            {
                // do nothing
            }
        }

        private void Employee_Main_Paint(object sender, PaintEventArgs e)
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

        private void picboxCreate_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Show();
            this.Hide();
        }

       
        private void picboxArrow_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Show();
            this.Hide();
        }

        private void lblPrint_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblPrint.Font, FontStyle.Underline);
            lblPrint.Font = font;
            lblPrint.BackColor = Color.LightGray;
            lblPrint.Cursor = Cursors.Hand;
        }

        private void picboxCreate_MouseEnter(object sender, EventArgs e)
        {
            picboxCreate.Cursor = Cursors.Hand;
        }

        private void picboxCreate_MouseLeave(object sender, EventArgs e)
        {
            picboxCreate.Cursor = Cursors.Default;
        }

        private void lblCreate_MouseEnter(object sender, EventArgs e)
        {
            lblCreate.Cursor = Cursors.Hand;
        }

        private void lblCreate_MouseLeave(object sender, EventArgs e)
        {
            lblCreate.Cursor = Cursors.Default;
        }

        private void lblCreate_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Show();
            this.Hide();
        }

        private void picboxArrow_MouseEnter(object sender, EventArgs e)
        {
            picboxArrow.Cursor = Cursors.Hand;
        }

        private void picboxArrow_MouseLeave(object sender, EventArgs e)
        {
            picboxArrow.Cursor = Cursors.Default;
        }

        private void lbldashboard_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblPay.Font = defaultFont;
            lblPay.BackColor = SystemColors.Control;
            lblPay.Cursor = Cursors.Default;
        }

        private void lbldashboard_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblPay.Font, FontStyle.Underline);
            lblPay.Font = font;
            lblPay.BackColor = Color.LightGray;
            lblPay.Cursor = Cursors.Hand;
        }

        private void lblhome_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblPay.Font = defaultFont;
            lblPay.BackColor = SystemColors.Control;
            lblPay.Cursor = Cursors.Default;
        }

        private void lblhome_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblPay.Font, FontStyle.Underline);
            lblPay.Font = font;
            lblPay.BackColor = Color.LightGray;
            lblPay.Cursor = Cursors.Hand;
        }

        private void lbldashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Show();
          
        }

        private void picbpxBg_Click(object sender, EventArgs e)
        {

        }

        private void lblPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            Records records = new Records();
            records.ShowDialog();
            this.Show();
        }

        private void lblhome_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Main_Load(object sender, EventArgs e)
        {
            lblhome.Enabled = false;
            lblhome.BackColor = Color.Gray;
        }

        private void lbldashboard_MouseEnter_1(object sender, EventArgs e)
        {
            Font font = new Font(lbldashboard.Font, FontStyle.Underline);
            lbldashboard.Font = font;
            lbldashboard.BackColor = Color.LightGray;
            lbldashboard.Cursor = Cursors.Hand;
        }

        private void lblPay_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblPay.Font, FontStyle.Underline);
            lblPay.Font = font;
            lblPay.BackColor = Color.LightGray;
            lblPay.Cursor = Cursors.Hand;
        }

        private void lbldashboard_MouseLeave_1(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lbldashboard.Font = defaultFont;
            lbldashboard.BackColor = SystemColors.Control;
            lbldashboard.Cursor = Cursors.Default;
        }

        private void lblPay_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblPay.Font = defaultFont;
            lblPay.BackColor = SystemColors.Control;
            lblPay.Cursor = Cursors.Default;
        }

        private void lblPay_MouseEnter_1(object sender, EventArgs e)
        {
            Font font = new Font(lblPay.Font, FontStyle.Underline);
            lblPay.Font = font;
            lblPay.BackColor = Color.LightGray;
            lblPay.Cursor = Cursors.Hand;
        }

        private void lblPrint_MouseEnter_1(object sender, EventArgs e)
        {
            Font font = new Font(lblPrint.Font, FontStyle.Underline);
            lblPrint.Font = font;
            lblPrint.BackColor = Color.LightGray;
            lblPrint.Cursor = Cursors.Hand;
        }

        private void lblPrint_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblPrint.Font = defaultFont;
            lblPrint.BackColor = SystemColors.Control;
            lblPrint.Cursor = Cursors.Default;
        }

        private void lblSignout_MouseLeave_1(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblSignout.Font = defaultFont;
            lblSignout.BackColor = SystemColors.Control;
            lblSignout.Cursor = Cursors.Default;
        }

        private void lblSignout_MouseEnter_1(object sender, EventArgs e)
        {
            Font font = new Font(lblSignout.Font, FontStyle.Underline);
            lblSignout.Font = font;
            lblSignout.BackColor = Color.LightGray;
            lblSignout.Cursor = Cursors.Hand;
        }

        private void lblExit_MouseEnter_1(object sender, EventArgs e)
        {
            Font font = new Font(lblExit.Font, FontStyle.Underline);
            lblExit.Font = font;
            lblExit.BackColor = Color.LightGray;
            lblExit.Cursor = Cursors.Hand;
        }

        private void lblExit_MouseLeave_1(object sender, EventArgs e)
        {
            Font font = new Font(lblExit.Font, FontStyle.Underline);
            lblExit.Font = font;
            lblExit.BackColor = Color.LightGray;
            lblExit.Cursor = Cursors.Hand;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Bin bin = new Bin();
            bin.Show();
            this.Hide();

        }
    }
}
