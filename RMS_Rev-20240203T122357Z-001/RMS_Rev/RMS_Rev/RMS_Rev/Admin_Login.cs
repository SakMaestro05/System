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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RMS_Rev
{
    public partial class Admin_Login : Form
    {
        private List<Image> _carouselImages = new List<Image>();
        private int _currentImageIndex = 0;


        public Admin_Login()
        {
            InitializeComponent();

            // Load your carousel images into the _carouselImages list
            _carouselImages.Add(Image.FromFile("pexels-karina-zhukovskaya-6446709.jpg"));
            _carouselImages.Add(Image.FromFile("pexels-luis-quintero-2148216.jpg"));
            _carouselImages.Add(Image.FromFile("pexels-pixabay-207589.jpg"));

            // Start the Timer to transition between images
            tmrAdminlogin.Start();

            // Create the line-only text box
        }

        private void tmrAdminlogin_Tick(object sender, EventArgs e)
        {
            // Update the PictureBox control to display the next image in the carousel
            _currentImageIndex++;
            if (_currentImageIndex >= _carouselImages.Count)
            {
                _currentImageIndex = 0;
            }
            picboxAdminlogin.Image = _carouselImages[_currentImageIndex];
        }


        private void txtuser_MouseEnter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Please Enter Your Username...")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtuser.Text))
            {
                txtuser.Text = "Please Enter Your Username...";
                txtuser.ForeColor = Color.Gray;
            }
           
        }
        private void txtpass_MouseEnter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Please Enter Your Password...")
            {
                txtpass.Text = "";
                txtpass.PasswordChar = '\0'; // reset the PasswordChar property
                txtpass.ForeColor = Color.Black;
            }
        }

        private void txtpass_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                txtpass.Text = "Please Enter Your Password...";
                txtpass.PasswordChar = '\0'; // reset the PasswordChar property
                txtpass.ForeColor = Color.Gray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;

            // Check if the username and password are correct
            if (username == "Administrator" && password == "Administrator@05")
            {
                // If correct, show the Admin Dashboard form
                Admin_Main adminmain = new Admin_Main();
                MessageBox.Show("Login successful.");
                adminmain.Show();

                // Hide the current form
                this.Hide();
            }
            else
            {
                // If incorrect, show an error message
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Forgot adminforgot = new Admin_Forgot();
            adminforgot.Show();

        }

        private void Admin_Login_Paint(object sender, PaintEventArgs e)
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

        private void btnhidepass_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '\0')
            {
                btnshowpass.BringToFront();
                txtpass.PasswordChar = '●';
            }
        }

        private void btnshowpass_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '●')
            {
                btnhidepass.BringToFront();
                txtpass.PasswordChar = '\0';
            }
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key pressed
            {
                e.Handled = true; // Suppress beep sound
                btnLogin.PerformClick(); // Simulate button click
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key pressed
            {
                e.Handled = true; // Suppress beep sound
                btnLogin.PerformClick(); // Simulate button click
            }
        }

        private void btnhidepass_MouseEnter(object sender, EventArgs e)
        {
            btnhidepass.Cursor = Cursors.Hand;
        }

        private void btnhidepass_MouseLeave(object sender, EventArgs e)
        {
            btnhidepass.Cursor = Cursors.Default;
        }

        private void btnshowpass_MouseEnter(object sender, EventArgs e)
        {
            btnshowpass.Cursor = Cursors.Hand;
        }

        private void btnshowpass_MouseLeave(object sender, EventArgs e)
        {
            btnshowpass.Cursor = Cursors.Default;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.Cursor = Cursors.Hand;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.Cursor = Cursors.Default;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.Cursor = Cursors.Hand;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Cursor = Cursors.Default;
        }

       
        }
    }
