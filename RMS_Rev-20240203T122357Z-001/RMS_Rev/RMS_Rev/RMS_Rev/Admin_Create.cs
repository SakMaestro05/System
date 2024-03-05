using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace RMS_Rev
{
    public partial class Admin_Create : Form
    {
        private ErrorProvider usernameErrorProvider;
        private ErrorProvider passwordErrorProvider;
        private ErrorProvider confirmPasswordErrorProvider;

        private const int WM_PAINT = 0xF;

        // Add your connection string here
        private string connectionString = "Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05";

        public Admin_Create()
        {
            InitializeComponent();
            InitializeErrorProviders();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

        }

        private void InitializeErrorProviders()
        {
            usernameErrorProvider = new ErrorProvider();
            passwordErrorProvider = new ErrorProvider();
            confirmPasswordErrorProvider = new ErrorProvider();

            usernameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            passwordErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            confirmPasswordErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            ClearErrorMessages();

            string username = txtUser.Text.Trim();
            string password = txtPass.Text;
            string confirmPassword = txtConfirmPass.Text;
            string userType = "";

            // Determine the selected user type based on the radio button
            if (optbtnAdmin.Checked)
            {
                userType = "Administrator";
            }
            else if (optbtnEmployee.Checked)
            {
                userType = "Employee";
            }

            if (!IsValidUsername(username))
            {
                usernameErrorProvider.SetError(txtUser, "Invalid username. Please enter a valid username.");
                usernameErrorProvider.SetIconPadding(txtUser, -20);
            }

            if (!IsValidPassword(password))
            {
                passwordErrorProvider.SetError(txtPass, "Invalid password. Please enter a valid password.");
                passwordErrorProvider.SetIconPadding(txtPass, -20);
            }

            if (password != confirmPassword)
            {
                confirmPasswordErrorProvider.SetError(txtConfirmPass, "Passwords do not match.");
                confirmPasswordErrorProvider.SetIconPadding(txtConfirmPass, -20);
            }

            if (usernameErrorProvider.GetError(txtUser) != "" || passwordErrorProvider.GetError(txtPass) != "" || confirmPasswordErrorProvider.GetError(txtConfirmPass) != "")
                return;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the username or password already exists in the table
                    string checkQuery = "SELECT COUNT(*) FROM Table_Login WHERE Username = @Username OR Password = @Password";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Username", username);
                        checkCommand.Parameters.AddWithValue("@Password", password);

                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username or password already exists. Please choose a different username or password.");
                            return;
                        }
                    }

                    // Insert the data into the table
                    string insertQuery = "INSERT INTO Table_Login (Username, Password, UserType, Status) VALUES (@Username, @Password, @UserType, 'Active')";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@UserType", userType);

                        command.ExecuteNonQuery();
                    }

                    // Update the status of the newly created account to "Active"
                    string updateQuery = "UPDATE Table_Login SET Status = 'Active' WHERE Username = @Username";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@Username", username);

                        updateCommand.ExecuteNonQuery();
                    }
                }

                // Account creation successful
                MessageBox.Show("Account created successfully!");
            }
            catch (Exception ex)
            {
                // Handle any database or exception errors
                MessageBox.Show("An error occurred while creating the account: " + ex.Message);
            }
            txtUser.Text="";
            txtPass.Text = "";
            txtConfirmPass.Text = "";
        }

        private bool IsValidUsername(string username)
        {
            // Placeholder method for username validation
            return !string.IsNullOrWhiteSpace(username);
        }

        private bool IsValidPassword(string password)
        {
            // Placeholder method for password validation
            return !string.IsNullOrWhiteSpace(password);
        }

        // Existing methods...

        private void ClearErrorMessages()
        {
            usernameErrorProvider.SetError(txtUser, string.Empty);
            passwordErrorProvider.SetError(txtPass, string.Empty);
            confirmPasswordErrorProvider.SetError(txtConfirmPass, string.Empty);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_Login login = new frm_Login();
                login.Show();
                this.Hide();
            }
        }

        private void picboxAdminlogin_Click(object sender, EventArgs e)
        {

        }

        private void picbpxBg_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to signout", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_Login login = new frm_Login();
                login.Show();
                this.Hide();
            }
        }

        private void Admin_Create_Paint(object sender, PaintEventArgs e)
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

        private void picbpxBg_Paint(object sender, PaintEventArgs e)
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

        private void picboxAdminlogin_Paint(object sender, PaintEventArgs e)
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

        private void Admin_Create_Load(object sender, EventArgs e)
        {
            lblCreate.BackColor = Color.Gray;
            lblCreate.Enabled = false;
        }

        private void btnHidepass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                btnShowpass.BringToFront();
                txtPass.PasswordChar = '●';
            }
        }

        private void btnShowpass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '●')
            {
                btnHidepass.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.PasswordChar == '●')
            {
                btnHidepass.BringToFront();
                txtConfirmPass.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.PasswordChar == '\0')
            {
                btnShowpass.BringToFront();
                txtConfirmPass.PasswordChar = '●';
            }
        }

        private void lblRecord_Click(object sender, EventArgs e)
        {
            Records records = new Records();
            records.Show();
            this.Hide();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_dashboard = new Admin_Dashboard();
            admin_dashboard.Show();
            this.Hide();
        }

        

        private void lblCreate_MouseEnter(object sender, EventArgs e)
        {

            Font font = new Font(lblCreate.Font, FontStyle.Underline);
            lblCreate.Font = font;
            lblCreate.BackColor = Color.LightGray;
            lblCreate.Cursor = Cursors.Hand;
        }

        private void lblRecord_MouseEnter(object sender, EventArgs e)
        {

            Font font = new Font(lblRecord.Font, FontStyle.Underline);
            lblRecord.Font = font;
            lblRecord.BackColor = Color.LightGray;
            lblRecord.Cursor = Cursors.Hand;
        }

        private void lblDashboard_MouseEnter(object sender, EventArgs e)
        {

            Font font = new Font(lblDashboard.Font, FontStyle.Underline);
            lblDashboard.Font = font;
            lblDashboard.BackColor = Color.LightGray;
            lblDashboard.Cursor = Cursors.Hand;
        }

        private void lblManage_MouseEnter(object sender, EventArgs e)
        {

           
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {

            Font font = new Font(lblExit.Font, FontStyle.Underline);
            lblExit.Font = font;
            lblExit.BackColor = Color.LightGray;
            lblExit.Cursor = Cursors.Hand;
        }

        private void lblCreate_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblCreate.Font = defaultFont;
            lblCreate.BackColor = SystemColors.Control;
            lblCreate.Cursor = Cursors.Default;
        }

        private void lblRecord_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblRecord.Font = defaultFont;
            lblRecord.BackColor = SystemColors.Control;
            lblRecord.Cursor = Cursors.Default;
        }

        private void lblDashboard_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblDashboard.Font = defaultFont;
            lblDashboard.BackColor = SystemColors.Control;
            lblDashboard.Cursor = Cursors.Default;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblExit.Font = defaultFont;
            lblExit.BackColor = SystemColors.Control;
            lblExit.Cursor = Cursors.Default;
        }

        private void lblCreate_Click(object sender, EventArgs e)
        {

        }

        private void lblManage_Click(object sender, EventArgs e)
        {

        }

        private void lblSignout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to sign out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_Login admin_Login = new frm_Login();
                admin_Login.Show();
                this.Hide();
            }
            else
            {
                // do nothing
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Admin_Main admin_Main = new Admin_Main();
            admin_Main.Show();
            this.Hide();
        }
    } 
}
