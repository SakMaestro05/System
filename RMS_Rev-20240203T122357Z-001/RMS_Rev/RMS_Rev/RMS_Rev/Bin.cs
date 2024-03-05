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
    public partial class Bin : Form
    {
        private List<DataGridViewRow> selectedRows;

        public Bin()
        {
            InitializeComponent();
            selectedRows = new List<DataGridViewRow>(); // Initialize the list
        }

        public Bin(List<DataGridViewRow> selectedRows)
        {
            InitializeComponent();
            this.selectedRows = selectedRows;
        }

        private void dtBin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtBin.Columns["Payment_Status"].Index && e.Value != null)
            {
                string paymentStatus = e.Value.ToString();
                if (paymentStatus == "Unpaid")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (paymentStatus == "Paid")
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void lblRestore_Click(object sender, EventArgs e)
        {
            if (dtBin.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtBin.SelectedRows[0];
                DataGridView firstDataGridView = ((Transaction)Application.OpenForms["Transaction"]).dtGridView;
                firstDataGridView.Rows.Add(selectedRow.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());

                dtBin.Rows.Remove(selectedRow);

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05"))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Table_Bin WHERE Transaction_No = @Transaction_No";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@Transaction_No", selectedRow.Cells["Transaction_No"].Value.ToString());

                    command.ExecuteNonQuery();
                    this.Hide();
                }
            }
        }

        private void Bin_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05"))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM Table_Bin";
                    SqlCommand command = new SqlCommand(selectQuery, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }

                // Assign DataPropertyName for each column
                dtBin.Columns["Transaction_No"].DataPropertyName = "Transaction_No";
                dtBin.Columns["Date_Today"].DataPropertyName = "Date_Today";
                dtBin.Columns["Time"].DataPropertyName = "Time";
                dtBin.Columns["First_Name"].DataPropertyName = "First_Name";
                dtBin.Columns["Middle_Name"].DataPropertyName = "Middle_Name";
                dtBin.Columns["Last_Name"].DataPropertyName = "Last_Name";
                dtBin.Columns["Suffix"].DataPropertyName = "Suffix";
                dtBin.Columns["Phone"].DataPropertyName = "Phone";
                dtBin.Columns["Address"].DataPropertyName = "Address";
                dtBin.Columns["Device"].DataPropertyName = "Device";
                dtBin.Columns["Category"].DataPropertyName = "Category";
                dtBin.Columns["Service"].DataPropertyName = "Service";
                dtBin.Columns["Initial_Price"].DataPropertyName = "Initial_Price";
                dtBin.Columns["Status"].DataPropertyName = "Status";
                dtBin.Columns["Payment_Status"].DataPropertyName = "Payment_Status";

                dtBin.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
            }
            label3.BackColor = Color.Gray;
            label3.Enabled = false;
        }

        private void Bin_Paint(object sender, PaintEventArgs e)
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

        private void lblhome_Click(object sender, EventArgs e)
        {

                Employee_Main employee_main = new Employee_Main();
                employee_main.Show();
                this.Hide();
           
        }

        private void lbldashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void lblPay_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Records records = new Records();
            records.Show();
            this.Hide();
        }

        private void lblSignout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Signout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_Login frm_login = new frm_Login();
                frm_login.Show();
                this.Hide();
            }
            else
            {
                // do nothing
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // do nothing
            }
        }
    }
}
