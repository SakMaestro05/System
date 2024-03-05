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
    public partial class Employee_Login : Form
    {
        public Employee_Login()
        {
            InitializeComponent();
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
            if (username == "Employee" && password == "EmployeeNo@05")
            {
                // If correct, show the Admin Dashboard form
                Employee_Main employeemain = new Employee_Main();
                employeemain.Show();

                // Hide the current form
                this.Hide();
            }
            else
            {
                // If incorrect, show an error message
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
