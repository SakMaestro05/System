using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                txtpass.ForeColor = Color.Black;
            }
        }

        private void txtpass_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                txtpass.Text = "Please Enter Your Password...";
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
    }
}
