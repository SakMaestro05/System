using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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

            // Check if the entered username exists in the database
            bool usernameExists = CheckUsernameExists(username);

            if (usernameExists)
            {
                // Username exists, navigate to the password reset form
                Admin_ResetPass passwordResetForm = new Admin_ResetPass(username);
                passwordResetForm.Show();
                this.Hide();
            }
            else
            {
                // Username does not exist, display an error message
                MessageBox.Show("Username Not Found.");
            }
        }

        private bool CheckUsernameExists(string username)
        {
            // Query the database to check if the username exists
            // Perform the necessary database operations here and return true if the username exists, false otherwise

            // Replace this code with your actual database query
            // Example using SqlConnection and SqlCommand
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Table_Login WHERE Username = @Username", connection);
                command.Parameters.AddWithValue("@Username", username);
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
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

        private void Admin_Forgot_Paint(object sender, PaintEventArgs e)
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

        private void tmrAdminlogin_Tick(object sender, EventArgs e)
        {
           
           
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            frm_Login frm_login = new frm_Login();
                frm_login.Show();
                this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
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

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(label3.Font, FontStyle.Underline);
            label3.Font = font;
            label3.BackColor = Color.LightGray;
            label3.Cursor = Cursors.Hand;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            label3.Font = defaultFont;
            label3.BackColor = SystemColors.Control;
            label3.Cursor = Cursors.Default;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            label1.Font = defaultFont;
            label1.BackColor = SystemColors.Control;
            label1.Cursor = Cursors.Default;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(label1.Font, FontStyle.Underline);
            label1.Font = font;
            label1.BackColor = Color.LightGray;
            label1.Cursor = Cursors.Hand;
        }
    }
    }
