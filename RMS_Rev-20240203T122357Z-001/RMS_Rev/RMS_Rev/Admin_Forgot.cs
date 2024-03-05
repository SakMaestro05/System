using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Rev
{
    public partial class Admin_Forgot : Form
    {
        public Admin_Forgot()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;

            // Validate the username
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            // Search the user credentials file for the user record
            string newPassword = null;
            foreach (string line in File.ReadAllLines("Admin_Forgot.txt"))
            {
                string[] parts = line.Split(',');
                if (parts[0] == username)
                
                    // Prompt the user to enter a new password and confirm it
                    Admin_ResetPass adminreset = new Admin_ResetPass();
                    if (adminreset.ShowDialog() == DialogResult.OK)
                    {
                        string password = adminreset.txtAdminnewpass.Text;
                        string confirmPassword = adminreset.txtAdminconfirmpass.Text;

                        // Validate the new password and confirm password
                        if (password == confirmPassword && IsValidPassword(password))
                        {
                            // Update the password for the user in the file
                            string newLine = $"{parts[0]},{HashPassword(password)}";
                            File.WriteAllLines("Admin_Forgot.txt", File.ReadAllLines("Admin_Forgot.txt").Select(l => l.StartsWith(parts[0] + ",") ? newLine : l));

                            newPassword = password;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Invalid password.");
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                
            }

            if (newPassword != null)
            {
                // Open the password reset form and pass the username as a parameter
       
                Admin_ResetPass adminreset = new Admin_ResetPass();
                adminreset.Show();
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private bool IsValidPassword(string password)
        {
            // Add password validation logic here
            // For example: password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number
            return password.Length >= 8 && password.Any(c => char.IsUpper(c)) && password.Any(c => char.IsLower(c)) && password.Any(c => char.IsDigit(c));
        }

        private string HashPassword(string password)
        {
            // Hash the password using SHA256
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = SHA256.Create().ComputeHash(passwordBytes);
            return Convert.ToBase64String(hashBytes);
        }


        }
    }

