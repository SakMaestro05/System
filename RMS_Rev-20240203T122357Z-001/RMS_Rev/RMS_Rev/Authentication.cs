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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();

            // Set panel shape to circle
            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(0, 0, pnlAdmin.Width, pnlAdmin.Height);
            pnlAdmin.Region = new Region(circlePath);

            circlePath = new GraphicsPath();
            circlePath.AddEllipse(0, 0, pnlEmployee.Width, pnlEmployee.Height);
            pnlEmployee.Region = new Region(circlePath);

            pnlAdmin.BackColor = Color.Transparent;
            pnlEmployee.BackColor = Color.Transparent;
        }

        private void pnlAdmin_MouseEnter(object sender, EventArgs e)
        {
            pnlAdmin.BackColor = Color.LightGreen; // Set the background color to light green
            //pnlAdmin.Size = new Size(pnlAdmin.Width + 10, pnlAdmin.Height + 10); // Increase the size of the panel by 10 pixels in both dimensions
            // Enlarge PictureBox and Label inside the panel
            foreach (Control c in pnlAdmin.Controls)
            {
                if (c is PictureBox)
                {
                    c.Size = new Size(c.Width + 10, c.Height + 10);
                }
                else if (c is Label)
                {
                    c.Font = new Font(c.Font.FontFamily, c.Font.Size + 2, FontStyle.Bold);
                }
            }
        }

        private void pnlAdmin_MouseLeave(object sender, EventArgs e)
        {
            pnlAdmin.BackColor = SystemColors.Control; // Reset the background color to the default control color
           /* pnlAdmin.Size = new Size(pnlAdmin.Width - 10, pnlAdmin.Height - 10);*/ // Decrease the size of the panel by 10 pixels in both dimensions to revert to the original size
            // Shrink PictureBox and Label inside the panel
            foreach (Control c in pnlAdmin.Controls)
            {
                if (c is PictureBox)
                {
                    c.Size = new Size(c.Width - 10, c.Height - 10);
                }
                else if (c is Label)
                {
                    c.Font = new Font(c.Font.FontFamily, c.Font.Size - 2, FontStyle.Regular);
                }
            }
        }

        private void pnlEmployee_MouseEnter_1(object sender, EventArgs e)
        {
            pnlEmployee.BackColor = Color.LightPink; // Set the background color to light green
            /* pnlEmployee.Size = new Size(pnlEmployee.Width + 10, pnlEmployee.Height + 10); // Increase the size of *//*the panel by 10 pixels in both dimensions*/
            foreach (Control c in pnlEmployee.Controls)
            {
                if (c is PictureBox)
                {
                    c.Size = new Size(c.Width + 10, c.Height + 10);
                }
                else if (c is Label)
                {
                    c.Font = new Font(c.Font.FontFamily, c.Font.Size + 2, FontStyle.Bold);
                }
            }
        }

        private void pnlEmployee_MouseLeave_1(object sender, EventArgs e)
            {
                pnlEmployee.BackColor = SystemColors.Control; // Reset the background color to the default control color
            /*pnlEmployee.Size = new Size(pnlEmployee.Width - 10, pnlEmployee.Height - 10);*/ // Decrease the size of the panel by 10 pixels in both dimensions to revert to the original size
            foreach (Control c in pnlEmployee.Controls)
            {
                if (c is PictureBox)
                {
                    c.Size = new Size(c.Width - 10, c.Height - 10);
                }
                else if (c is Label)
                {
                    c.Font = new Font(c.Font.FontFamily, c.Font.Size - 2, FontStyle.Regular);
                }
            }
        }

        private void pnlAdmin_Click(object sender, EventArgs e)
        {
            Admin_Login admin = new Admin_Login();
            admin.Show();
            Hide();
        }

        private void picboxAdmin_Click(object sender, EventArgs e)
        {
            Admin_Login admin = new Admin_Login();
            admin.Show();
            Hide();
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            Admin_Login admin = new Admin_Login();
            admin.Show();
            Hide();
        }

        private void pnlEmployee_Click(object sender, EventArgs e)
        {
            Employee_Login employ = new Employee_Login();
            employ.Show();
            Hide();
        }

        private void picboxEmployee_Click(object sender, EventArgs e)
        {
            Employee_Login employ = new Employee_Login();
            employ.Show();
            Hide();
        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {
            Employee_Login employ = new Employee_Login();
            employ.Show();
            Hide();
        }
    }
    }
    

