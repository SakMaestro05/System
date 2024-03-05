using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;
using System.Configuration;
//using System.Web.Http;
using Newtonsoft.Json;

namespace RMS_Rev
{
    public partial class Transaction : Form
    {
        // DATABASE CONNECTION 
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05");
        private AutoCompleteStringCollection autoCompleteCollection;

        string g;


        public Transaction()
        {
            InitializeComponent();
            autoCompleteCollection = new AutoCompleteStringCollection();
            txtdeviceinfo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtdeviceinfo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtdeviceinfo.AutoCompleteCustomSource = autoCompleteCollection;

        }
        private void lblSignout_MouseEnter(object sender, EventArgs e)
        {

            Font font = new Font(lblSignout.Font, FontStyle.Underline);
            lblSignout.Font = font;
            lblSignout.BackColor = Color.LightGray;
            lblSignout.Cursor = Cursors.Hand;
        }

        private void lblSignout_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblSignout.Font = defaultFont;
            lblSignout.BackColor = SystemColors.Control;
            lblSignout.Cursor = Cursors.Default;
        }

        private void lblSignout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to sign out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_Login employee_Login = new frm_Login();
                employee_Login.Show();
                this.Hide();
            }
            else
            {
                // do nothing
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
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

        private void lblAdd_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblAdd.Font, FontStyle.Underline);
            lblAdd.Font = font;
            lblAdd.BackColor = Color.LightGray;
            lblAdd.Cursor = Cursors.Hand;
        }

        private void lblAdd_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblAdd.Font = defaultFont;
            lblAdd.BackColor = SystemColors.Control;
            lblAdd.Cursor = Cursors.Default;
        }

        private void lblArchive_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblArchive.Font, FontStyle.Underline);
            lblArchive.Font = font;
            lblArchive.BackColor = Color.LightGray;
            lblArchive.Cursor = Cursors.Hand;
        }


        private void lblReset_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblReset.Font, FontStyle.Underline);
            lblReset.Font = font;
            lblReset.BackColor = Color.LightGray;
            lblReset.Cursor = Cursors.Hand;
        }

        private void lblReset_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblReset.Font = defaultFont;
            lblReset.BackColor = SystemColors.Control;
            lblReset.Cursor = Cursors.Default;
        }

        private void Transaction_Paint(object sender, PaintEventArgs e)
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

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Set the background color of alternate rows
            if (e.RowIndex % 2 == 0)
            {
                dtGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                dtGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Main Home = new Employee_Main();
            Home.ShowDialog();
            this.Show();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if all required fields are filled
                if (txtfn.Text == "" || txtln.Text == "" || txtdeviceinfo.Text == "" || txtHomeAddress.Text == "" || cbotrans.Text == "" || txtprice.Text == "")
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                // Determine the value of the "g" variable based on the selected radio button
                string g = optbtnphone.Checked ? "Phone" : "Computer";

                // Open the database connection
                con.Open();

                // Create the SQL command with parameters to avoid SQL injection
                SqlCommand cmd = new SqlCommand("INSERT INTO Table_Trans (Transaction_No, Date_TOday, Time, First_Name, Middle_Name, Last_Name, Suffix, Phone, Address, Device, Category, Service, Initial_Price, Status, Payment_Status) " +
                    "VALUES (@Transaction_No, @Date_Today, @Time, @First_Name, @Middle_Name, @Last_Name, @Suffix, @Phone, @Address, @Device, @Category, @Service, @Initial_Price, @Status, @Payment_Status)", con);

                // Set the parameter values
                cmd.Parameters.AddWithValue("@Transaction_No", txtTransactionNo.Text);
                cmd.Parameters.AddWithValue("@Date_Today", lbltodate.Text);
                cmd.Parameters.AddWithValue("@Time", lbltimer.Text);
                cmd.Parameters.AddWithValue("@First_Name", txtfn.Text);
                cmd.Parameters.AddWithValue("@Middle_Name", txtmn.Text);
                cmd.Parameters.AddWithValue("@Last_Name", txtln.Text);
                cmd.Parameters.AddWithValue("@Suffix", txtsuf.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtHomeAddress.Text);
                cmd.Parameters.AddWithValue("@Device", txtdeviceinfo.Text);
                cmd.Parameters.AddWithValue("@Category", g);
                cmd.Parameters.AddWithValue("@Service", cbotrans.Text);
                cmd.Parameters.AddWithValue("@Initial_Price", txtprice.Text);
                cmd.Parameters.AddWithValue("@Status", "Pending");
                cmd.Parameters.AddWithValue("@Payment_Status", "Unpaid");

                // Execute the SQL command
                cmd.ExecuteNonQuery();

                // Close the database connection
                con.Close();

                // Clear the form fields
                txtTransactionNo.Text = "";
                txtfn.Text = "";
                txtmn.Text = "";
                txtln.Text = "";
                txtsuf.Text = "";
                txtdeviceinfo.Text = "";
                txtPhoneNumber.Text = "";
                txtHomeAddress.Text = "";
                cbotrans.Text = "";
                txtprice.Text = "";
                dtpstart.Text = "";
                optbtnphone.Checked = false;
                optbtnlaptop.Checked = false;

                MessageBox.Show("Successfully Added!");

                DialogResult Add = MessageBox.Show("Do you want to add another transaction?", "Access Connect", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Add == DialogResult.Yes)
                {
                    // Create a new instance of the form and show it
                    Add_Transaction ADD_TRANSACTION = new Add_Transaction();
                    ADD_TRANSACTION.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

            cboStatus.Visible = false;
            cbopay.Visible = false;
            lblStatus.Visible = false;
            lblpay.Visible = false;

            // Load the device information data for autocomplete
            LoadDeviceInfoData();
            tmr.Start();
            optbtnphone.Checked = false;
            optbtnlaptop.Checked = false;
            data();

            Random rnd = new Random();
            int randomnum = rnd.Next(100000000, 999999999);
            txtTransactionNo.Text = randomnum.ToString();
            Refresh();
        }

        private void LoadDeviceInfoData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Model FROM Table_Model", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string deviceInfo = reader["Model"].ToString();
                    autoCompleteCollection.Add(deviceInfo);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading device information: " + ex.Message);
            }
        }
        void data()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("Select * from Table_Trans", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dtGridView.DataSource = dt;

        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            iReset();
        }

        private void iReset()
        {
            cboStatus.Text = string.Empty;
            txtdeviceinfo.Text = string.Empty;
            cbotrans.Text = string.Empty;
            cbopay.Text = string.Empty;
            txtprice.Text = string.Empty;
            dtGridView.ClearSelection();
            optbtnlaptop.Checked = false;
            optbtnphone.Checked = false;
            dtpstart.Text = "";
            txtfn.Text = "";
            txtmn.Text = "";
            txtln.Text = "";
            txtsuf.Text = "";
            txtdeviceinfo.Text = "";
            txtPhoneNumber.Text = "";
            txtHomeAddress.Text = "";


            if (optbtnphone.Checked)
            {

                optbtnphone.Checked = true;
            }
            else if (optbtnphone.Checked)
            {
                optbtnphone.Checked = false;
            }

        }


        private void lblArchive_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the original grid
            if (dtGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dtGridView.SelectedRows[0];

                // Extract data from the selected row
                string column1Value = selectedRow.Cells["Transaction_No"].Value.ToString();
                string column2Value = selectedRow.Cells["Date_Today"].Value.ToString();
                string column3Value = selectedRow.Cells["Time"].Value.ToString();
                string column4Value = selectedRow.Cells["First_Name"].Value.ToString();
                string column5Value = selectedRow.Cells["Middle_Name"].Value.ToString();
                string column6Value = selectedRow.Cells["Last_Name"].Value.ToString();
                string column7Value = selectedRow.Cells["Suffix"].Value.ToString();
                string column8Value = selectedRow.Cells["Phone"].Value.ToString();
                string column9Value = selectedRow.Cells["Address"].Value.ToString();
                string column10Value = selectedRow.Cells["Device"].Value.ToString();
                string column11Value = selectedRow.Cells["Category"].Value.ToString();
                string column12Value = selectedRow.Cells["Service"].Value.ToString();
                string column13Value = selectedRow.Cells["Initial_Price"].Value.ToString();
                string column14Value = selectedRow.Cells["Status"].Value.ToString();
                string column15Value = selectedRow.Cells["Payment_Status"].Value.ToString();

                // ...

                // Insert the extracted data into the second database table
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05"))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Table_Bin (Transaction_No, Date_Today, Time, First_Name, Middle_Name, Last_Name, Suffix, Phone, Address, Device, Category, Service, Initial_Price, Status, Payment_Status) VALUES (@Transaction_No, @Date_Today, @Time, @First_Name, @Middle_Name, @Last_Name, @Suffix, @Phone, @Address, @Device, @Category, @Service, @Initial_Price, @Status, @Payment_Status)";
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@Transaction_No", column1Value);
                    command.Parameters.AddWithValue("@Date_Today", column2Value);
                    command.Parameters.AddWithValue("@Time", column3Value);
                    command.Parameters.AddWithValue("@First_Name", column4Value);
                    command.Parameters.AddWithValue("@Middle_Name", column5Value);
                    command.Parameters.AddWithValue("@Last_Name", column6Value);
                    command.Parameters.AddWithValue("@Suffix", column7Value);
                    command.Parameters.AddWithValue("@Phone", column8Value);
                    command.Parameters.AddWithValue("@Address", column9Value);
                    command.Parameters.AddWithValue("@Device", column10Value);
                    command.Parameters.AddWithValue("@Category", column11Value);
                    command.Parameters.AddWithValue("@Service", column12Value);
                    command.Parameters.AddWithValue("@Initial_Price", column13Value);
                    command.Parameters.AddWithValue("@Status", column14Value);
                    command.Parameters.AddWithValue("@Payment_Status", column15Value);

                    // ...

                    command.ExecuteNonQuery();
                }

            
            // Create an instance of the second form
            Bin bin = new Bin();

                // Access the DataGridView in the second form
                DataGridView secondDataGridView = bin.dtBin;

                // Add the extracted row to the second grid
                secondDataGridView.Rows.Add(column1Value, column2Value, column3Value, column4Value, column5Value, column6Value, column7Value, column8Value, column9Value, column10Value, column11Value, column12Value, column13Value, column14Value, column15Value);

                // Show the second form
                bin.Show();

                // Delete the selected row from the original grid and the first database table
                dtGridView.Rows.Remove(selectedRow);

                // Delete the selected row from the first database table
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05"))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Table_Trans WHERE Transaction_No = @Transaction_No";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@Transaction_No", column1Value);
                    // ...

                    command.ExecuteNonQuery();
                }

            }
        }

        private void lblPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50); // Adjust margins as needed
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            // Calculate the total width and height required for printing the entire DataGridView
            int totalWidth = dtGridView.Width;
            int totalHeight = dtGridView.Height;

            // Create a new Bitmap with the calculated dimensions
            Bitmap bitmap = new Bitmap(totalWidth, totalHeight);

            // Draw the DataGridView onto the bitmap
            dtGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, totalWidth, totalHeight));

            // Draw the bitmap onto the print page
            e.Graphics.DrawImage(bitmap, e.MarginBounds.Left, e.MarginBounds.Top);

            // Check if there are more pages to print
            if (e.MarginBounds.Top + totalHeight < dtGridView.Height)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            bitmap.Dispose();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            this.lbltimer.Text = date.ToLongDateString();
            lbltodate.Text = DateTime.Now.ToLongTimeString();
        }


        private void txtTransactionNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtfn_TextChanged(object sender, EventArgs e)
        {
            if (txtfn.Text.Length > 0)
            {
                string firstLetter = txtfn.Text.Substring(0, 1); txtfn.Text = firstLetter.ToUpper() + txtfn.Text.Substring(1); txtfn.SelectionStart = txtfn.Text.Length;
            }

        }

        private void txtfn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmn_TextChanged(object sender, EventArgs e)
        {
            if (txtmn.Text.Length > 0)
            {
                string firstLetter = txtmn.Text.Substring(0, 1); txtmn.Text = firstLetter.ToUpper() + txtmn.Text.Substring(1); txtmn.SelectionStart = txtmn.Text.Length;
            }
        }

        private void txtmn_KeyPress(object sender, KeyPressEventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text.Trim();

            // Allowing backspace and space key
            if (e.KeyChar == '\b' || e.KeyChar == ' ')
            {
                return;
            }

            // Cancel the event if the key pressed is not a letter
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtln_TextChanged(object sender, EventArgs e)
        {
            if (txtln.Text.Length > 0)
            {
                string firstLetter = txtln.Text.Substring(0, 1); txtln.Text = firstLetter.ToUpper() + txtln.Text.Substring(1); txtln.SelectionStart = txtln.Text.Length;
            }
        }

        private void txtln_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsuf_TextChanged(object sender, EventArgs e)
        {
            if (txtsuf.Text.Length > 0)
            {
                string firstLetter = txtsuf.Text.Substring(0, 1); txtsuf.Text = firstLetter.ToUpper() + txtsuf.Text.Substring(1); txtsuf.SelectionStart = txtsuf.Text.Length;
            }
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            // Get the values of the first name, middle name, and combo boX

            string phoneNumber = txtPhoneNumber.Text.Trim();

            if (!Regex.IsMatch(phoneNumber, @"^(09|\+639)\d{9}$"))
            {
                e.Cancel = true;
                txtPhoneNumber.Select(0, txtPhoneNumber.Text.Length);
                MessageBox.Show("Invalid Phone Number", "Please check your input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text.Length < 11)
            {
                txtPhoneNumber.ForeColor = Color.Red;

            }
            else
            {
                txtPhoneNumber.ForeColor = Color.Black;
                lblAdd.Enabled = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbotrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*PHONE*/
            if (cbotrans.SelectedItem.ToString() == "Hardware Cleaning")
            { txtprice.Text = "250"; }
            else if (cbotrans.SelectedItem.ToString() == "Hardware Repair")
            { txtprice.Text = "1000"; }
            else if (cbotrans.SelectedItem.ToString() == "Water Damage")
            { txtprice.Text = "350"; }
            else if (cbotrans.SelectedItem.ToString() == "Battery Diagnostic and Repair")
            { txtprice.Text = "500"; }
            else if (cbotrans.SelectedItem.ToString() == "Power Button Repair")
            { txtprice.Text = "550"; }
            else if (cbotrans.SelectedItem.ToString() == "Cellphone Speaker Repair")
            { txtprice.Text = "600"; }

            /*LAPTOP*/
            else if (cbotrans.SelectedItem.ToString() == "Screen Damage")
            { txtprice.Text = "3500"; }
            else if (cbotrans.SelectedItem.ToString() == "Password Removal")
            { txtprice.Text = "450"; }
            else if (cbotrans.SelectedItem.ToString() == "Hardware Issues")
            { txtprice.Text = "800"; }
            else if (cbotrans.SelectedItem.ToString() == "Software Issues")
            { txtprice.Text = "550"; }
            else if (cbotrans.SelectedItem.ToString() == "Data Recovery and Backup")
            { txtprice.Text = "800"; }
            else if (cbotrans.SelectedItem.ToString() == "Troubleshooting and Networking Support")
            { txtprice.Text = "300"; }
            else
            { txtprice.Text = "0"; }
        }

        private void optbtnphone_CheckedChanged(object sender, EventArgs e)
        {
            if (optbtnphone.Checked == true)
            {
                g = "Phone";

            }

            optbtnlaptop.Checked = false;


            optbtnphone.ForeColor = Color.Black;
            optbtnlaptop.ForeColor = Color.Gray;
            //cbotrans.Text = "";
            //txtprice.Text = "";
            cbotrans.Items.Clear();
            cbotrans.Items.Add("Hardware Cleaning");
            cbotrans.Items.Add("Hardware Repair");
            cbotrans.Items.Add("Water Damage");
            cbotrans.Items.Add("Battery Diagnostic and Repair");
            cbotrans.Items.Add("Power Button Repair");
            cbotrans.Items.Add("Cellphone Speaker Repair");
        }

        private void optbtnlaptop_CheckedChanged(object sender, EventArgs e)
        {
            if (optbtnlaptop.Checked == true)
            {
                g = "Computer";
            }
            optbtnphone.Checked = false;


            //if (optbtnlaptop.Checked)
            //{
            //    dtGridView.Rows[0].Cells[7].Value = "Category";
            //}
            optbtnphone.ForeColor = Color.Gray;
            optbtnlaptop.ForeColor = Color.Black;

            cbotrans.Items.Clear();
            cbotrans.Items.Add("Screen Damage");
            cbotrans.Items.Add("Password Removal");
            cbotrans.Items.Add("Hardware Issues");
            cbotrans.Items.Add("Software Issues");
            cbotrans.Items.Add("Data Recovery and Backup");
            cbotrans.Items.Add("Troubleshooting and Networking Support");
        }

        private void optbtnlaptop_CheckedChanged_1(object sender, EventArgs e)
        {
            if (optbtnlaptop.Checked == true)
            {
                g = "Computer";
            }
            optbtnphone.Checked = false;
            optbtnphone.ForeColor = Color.Gray;
            optbtnlaptop.ForeColor = Color.Black;

            cbotrans.Items.Clear();
            cbotrans.Items.Add("Screen Damage");
            cbotrans.Items.Add("Password Removal");
            cbotrans.Items.Add("Hardware Issues");
            cbotrans.Items.Add("Software Issues");
            cbotrans.Items.Add("Data Recovery and Backup");
            cbotrans.Items.Add("Troubleshooting and Networking Support");
        }

        private void dtGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtGridView.Columns["Payment_Status"].Index && e.Value != null)
            {
                string Payment_Status = e.Value.ToString();
                if (Payment_Status == "Unpaid")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (Payment_Status == "Paid")
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void dtGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
            }

        private void dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbltimer_Click(object sender, EventArgs e)
        {

        }
    }
    }




