using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RMS_Rev
{
    public partial class Admin_ResetPass : Form
    {
        private string username;
        private ErrorProvider errorProvider;

        public Admin_ResetPass(string username)
        {
            InitializeComponent();
            this.username = username;
            txtNewPass.TextChanged += txtNewPass_TextChanged;
            txtConfirm.TextChanged += txtConfirm_TextChanged;
            errorProvider = new ErrorProvider();
            txtNewPass.UseSystemPasswordChar = true; // Set the UseSystemPasswordChar property to true
            txtConfirm.UseSystemPasswordChar = true; // Set the UseSystemPasswordChar property to true
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            string password = txtNewPass.Text;

            bool isStrong = CheckPasswordStrength(password);
            lblPasswordStrength.Text = isStrong ? "Strong Password" : "Weak Password";
            lblPasswordStrength.ForeColor = isStrong ? Color.Green : Color.Red;
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            string password = txtNewPass.Text;
            string confirm = txtConfirm.Text;

            bool passwordsMatch = password.Equals(confirm, StringComparison.OrdinalIgnoreCase);
            txtConfirm.ForeColor = passwordsMatch ? Color.Green : Color.Red;

            // Display error if passwords do not match
            if (!passwordsMatch)
                errorProvider.SetError(txtConfirm, "Passwords do not match");
            else
                errorProvider.SetError(txtConfirm, "");
        }

        private bool CheckPasswordStrength(string password)
        {
            // Implement your password complexity rules here
            // Return true if the password meets the complexity requirements, false otherwise

            // Example rules:
            // Password must be at least 8 characters long
            // Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character

            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            if (password.Length >= 8)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                        hasUpperCase = true;
                    else if (char.IsLower(c))
                        hasLowerCase = true;
                    else if (char.IsDigit(c))
                        hasDigit = true;
                    else if (char.IsSymbol(c) || char.IsPunctuation(c))
                        hasSpecialChar = true;
                }
            }

            return hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPass.Text;
            string confirmPassword = txtConfirm.Text;

            // Check if the new password meets the complexity requirements
            bool isStrong = CheckPasswordStrength(newPassword);

            if (!isStrong)
            {
                MessageBox.Show("Password does not meet the complexity requirements. Please choose a stronger password.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please enter the same password in both fields.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the password in the database
            bool passwordUpdated = UpdatePassword(username, newPassword);

            if (passwordUpdated)
            {
                MessageBox.Show("Password reset successful. You can now login with your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate back to the login form
                frm_Login frmlogin = new frm_Login();
                frmlogin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to reset password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdatePassword(string username, string newPassword)
        {
            // Update the password in the database
            // Perform the necessary database operations here and return true if the password is updated successfully, false otherwise

            // Replace this code with your actual database update query
            // Example using SqlConnection and SqlCommand
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Table_Login SET Password = @NewPassword WHERE Username = @Username", connection);
                command.Parameters.AddWithValue("@NewPassword", newPassword);
                command.Parameters.AddWithValue("@Username", username);
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        private void Admin_ResetPass_Load(object sender, EventArgs e)
        {

        }

        private void Admin_ResetPass_Paint(object sender, PaintEventArgs e)
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
    }
}
