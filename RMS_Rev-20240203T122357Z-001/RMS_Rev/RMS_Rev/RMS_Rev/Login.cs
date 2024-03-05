using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace RMS_Rev
{
    public partial class frm_Login : Form
    {
       

        public frm_Login()
        {
            InitializeComponent();

            
        }

        private void tmrAdminlogin_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Enter the username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Enter the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05");
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Login WHERE Username = @Username AND Password = @Password", con);
                    cmd.Parameters.AddWithValue("@Username", txtUser.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string userType = reader["usertype"].ToString();
                        string username = reader["Username"].ToString();
                        string status = reader["Status"].ToString(); // Get the account status

                        if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                        {
                            if (userType == "Administrator")
                            {
                                // Redirect to admin form
                                Admin_Main adminMain = new Admin_Main();
                                adminMain.Show();
                            }
                            else if (userType == "Employee")
                            {
                                // Redirect to employee form
                                Employee_Main employeeMain = new Employee_Main();
                                employeeMain.Show();
                            }

                            // Hide the login form
                            this.Hide();
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Your account is disabled. Contact the Administrator for the activation of your account.", "Account Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                            if (result == DialogResult.OK)
                            {
                                txtPass.Text = "";
                                txtUser.Text = "";
                            }
                            else
                            {
                                // Do nothing or handle the alternative flow here
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or password is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
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
            if (txtPass.PasswordChar == '\0')
            {
                btnShowpass.BringToFront();
                txtPass.PasswordChar = '●';
            }
        }

        private void btnshowpass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '●')
            {
                btnHidepass.BringToFront();
                txtPass.PasswordChar = '\0';
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
            btnHidepass.Cursor = Cursors.Hand;
        }

        private void btnhidepass_MouseLeave(object sender, EventArgs e)
        {
            btnHidepass.Cursor = Cursors.Default;
        }

        private void btnshowpass_MouseEnter(object sender, EventArgs e)
        {
            btnShowpass.Cursor = Cursors.Hand;
        }

        private void btnshowpass_MouseLeave(object sender, EventArgs e)
        {
            btnShowpass.Cursor = Cursors.Default;
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

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MeExit();

        }

        private void MeExit()
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Login emply = new frm_Login();
            emply.Show();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
