using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            if (txtUser.Text == "Please Enter Your Username...")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtuser_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                txtUser.Text = "Please Enter Your Username...";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtpass_MouseEnter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Please Enter Your Password...")
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '●';
                txtPass.ForeColor = Color.Black;
            }

        }

        private void txtpass_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.Text = "Please Enter Your Password...";
                txtPass.PasswordChar = '\0';
                txtPass.ForeColor = Color.Gray;
            }
        }


        private void btnhidepass_Click(object sender, EventArgs e)
        {

            if (txtPass.PasswordChar == '\0')
            {
                btnshowpass.BringToFront();
                txtPass.PasswordChar = '●';
            }
        }

        private void btnshowpass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '●')
            {
                btnhidepass.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key pressed
            {
                e.Handled = true; // Suppress beep sound
                btnSignup.PerformClick(); // Simulate button click
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
            btnSignup.Cursor = Cursors.Hand;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnSignup.Cursor = Cursors.Default;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnSignup.Cursor = Cursors.Hand;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnSignup.Cursor = Cursors.Default;
        }

        private void Employee_Login_Paint(object sender, PaintEventArgs e)
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            // SignupForm.cs

            if (ValidateInputs())
            {
                try
                {
                    // Establish a connection to the database
                    using (SqlConnection con = new SqlConnection("Data Source=Leah-Oquindo\\SQLSERVER;Initial Catalog=projectrecord;User ID=wolfserver;Password=wolf2g@ng23"))
                    {
                        con.Open();

                        // Check if the username already exists
                        SqlCommand checkUsernameCmd = new SqlCommand("SELECT COUNT(*) FROM Loginnn WHERE Username = @Username", con);
                        checkUsernameCmd.Parameters.AddWithValue("@Username", txtUser.Text);
                        int usernameCount = (int)checkUsernameCmd.ExecuteScalar();

                        if (usernameCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.");
                            return;
                        }

                        // Get the selected user type
                        string userType = GetSelectedUserType();

                        // Insert the new account details into the database with a "Pending" status
                        SqlCommand createAccountCmd = new SqlCommand("INSERT INTO Loginnn (Username, Password, Gmail, usertype, status) VALUES (@Username, @Password, @Email, @usertype, @status)", con);
                        createAccountCmd.Parameters.AddWithValue("@Username", txtUser.Text);
                        createAccountCmd.Parameters.AddWithValue("@Password", txtPass.Text);
                        createAccountCmd.Parameters.AddWithValue("@Email", txtemail.Text);
                        createAccountCmd.Parameters.AddWithValue("@usertype", userType);
                        createAccountCmd.Parameters.AddWithValue("@status", "Pending");

                        createAccountCmd.ExecuteNonQuery();

                        MessageBox.Show("Account created successfully. Waiting for admin approval.");

                        // Close the signup form
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating account: " + ex.Message);
                }
            }
        }
    

            //    if (ValidateInputs())
            //    {
            //        try
            //        {
            //            // Establish a connection to the database
            //            using (SqlConnection con = new SqlConnection("Data Source=Leah-Oquindo\\SQLSERVER;Initial Catalog=projectrecord;User ID=wolfserver;Password=wolf2g@ng23"))
            //            {
            //                con.Open();

            //                // Check if the username already exists
            //                SqlCommand checkUsernameCmd = new SqlCommand("SELECT COUNT(*) FROM LoginN WHERE username = @Username", con);
            //                checkUsernameCmd.Parameters.AddWithValue("@Username", txtUser.Text);
            //                int usernameCount = (int)checkUsernameCmd.ExecuteScalar();

            //                if (usernameCount > 0)
            //                {
            //                    MessageBox.Show("Username already exists. Please choose a different username.");
            //                    return;
            //                }

            //                // Get the selected user type
            //                string userType = GetSelectedUserType();

            //                // Insert the new account details into the database
            //                SqlCommand createAccountCmd = new SqlCommand("INSERT INTO LoginN (Username, Password, Gmail, usertype) VALUES (@Username, @Password, @Email, @usertype)", con);
            //                createAccountCmd.Parameters.AddWithValue("@username", txtUser.Text);
            //                createAccountCmd.Parameters.AddWithValue("@password", txtPass.Text);
            //                createAccountCmd.Parameters.AddWithValue("@email", txtemail.Text);
            //                createAccountCmd.Parameters.AddWithValue("@usertype", userType);

            //                createAccountCmd.ExecuteNonQuery();

            //                MessageBox.Show("Account created successfully.");

            //                // Close the create account form
            //                this.Close();
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Error creating account: " + ex.Message);
            //        }
            //    }
            //}

            private string GetSelectedUserType()
        {
            if (rbAdmin.Checked)
                return "Admin";
            else if (rbEmployee.Checked)
                return "Employee";
            else
                return ""; // Return an empty string or handle the case when no radio button is selected
        }

        private bool ValidateInputs()
        {
            // Perform input validation here (e.g., checking for empty fields, password strength, etc.)
            // Return true if inputs are valid; otherwise, return false

            // Example validation: Checking if required fields are not empty
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text) || string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Please enter all required fields.");
                return false;
            }

            // Example validation: Checking if a user type is selected
            if (!rbAdmin.Checked && !rbEmployee.Checked)
            {
                MessageBox.Show("Please select a user type.");
                return false;
            }

            return true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void linklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
  
