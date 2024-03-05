using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RMS_Rev
{
    public partial class Admin_Dashboard : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            // Connect to the database
            string connectionString = "Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05";
            connection = new SqlConnection(connectionString);
            connection.Open();

            // Retrieve data from the table
            string query = "SELECT * FROM Table_Login";
            dataAdapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Create columns programmatically
            dataGridView1.AutoGenerateColumns = false;

            // Column: Username
            DataGridViewTextBoxColumn usernameColumn = new DataGridViewTextBoxColumn();
            usernameColumn.Name = "Username";
            usernameColumn.DataPropertyName = "Username";
            usernameColumn.HeaderText = "Username";
            dataGridView1.Columns.Add(usernameColumn);

            // Column: Status
            DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn();
            statusColumn.Name = "Status";
            statusColumn.DataPropertyName = "Status";
            statusColumn.HeaderText = "Status";
            dataGridView1.Columns.Add(statusColumn);

            // Bind data to DataGridView
            dataGridView1.DataSource = dataTable;

            // Set the label text with the row count
            int rowCount = dataTable.Rows.Count;
            lblTotal.Text = rowCount.ToString();

            // Move the ActivationButton column to the last position
            dataGridView1.Columns["ActivationButton"].DisplayIndex = dataGridView1.Columns.Count - 1;

            // Count the number of active and inactive rows
            int administratorCount = 0;
            int employeeCount = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                string status = row["UserType"].ToString();

                if (status.Equals("Administrator", StringComparison.OrdinalIgnoreCase))
                {
                    administratorCount++;
                }
                else if (status.Equals("Employee", StringComparison.OrdinalIgnoreCase))
                {
                    employeeCount++;
                }
            }

            // Set the label text with the active and inactive counts
            lblActive.Text = administratorCount.ToString();
            lblInactive.Text = employeeCount.ToString();

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

            // Create the chart areas and series
            ChartArea chartArea = new ChartArea();
            Series series = new Series();

            // Set the chart type to pie
            series.ChartType = SeriesChartType.Pie;

            // Add data points to the series
            series.Points.Add(administratorCount);
            series.Points.Add(employeeCount);

            // Add the series to the chart
            chart1.Series.Clear();
            chart1.Series.Add(series);
            chart1.ChartAreas.Add(chartArea);

            // Update the chart appearance and layout
            chartArea.BackColor = Color.Transparent;
            chartArea.AxisX.MajorTickMark.Enabled = false;
            chartArea.AxisY.MajorTickMark.Enabled = false;
            chartArea.AxisX.LabelStyle.Enabled = false;
            chartArea.AxisY.LabelStyle.Enabled = false;
            chartArea.AxisX.LineWidth = 0;
            chartArea.AxisY.LineWidth = 0;

            // Calculate the position and size of the chart
            int chartWidth = 300;
            int chartHeight = 300;
            int chartX = chart1.ClientSize.Width / 2 - chartWidth / 2;
            int chartY = chart1.ClientSize.Height / 2 - chartHeight / 2;

            // Set the position and size of the chart
            chartArea.Position = new ElementPosition(chartX, chartY, chartWidth, chartHeight);

            lblDashboard.BackColor = Color.Gray;
            lblDashboard.Enabled = false;
            timer1.Start();
        }

        private void btnActivateDeactivate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Get the selected row index
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Get the current status value from the selected row
                string currentStatus = dataGridView1.Rows[rowIndex].Cells["Status"].Value.ToString();

                // Determine the current status based on the cell value
                bool isActive = currentStatus.Equals("Active", StringComparison.OrdinalIgnoreCase);

                // Invert the status
                bool newStatus = !isActive;

                // Update the status value in the database
                UpdateStatusInDatabase(newStatus, rowIndex);

                // Update the status value in the DataTable
                dataTable.Rows[rowIndex]["Status"] = newStatus ? "Active" : "Inactive";

                // Update the button text in the DataGridView
                dataGridView1.Rows[rowIndex].Cells["ActivationButton"].Value = newStatus ? "Deactivate" : "Activate";

                // Update the chart
                UpdateChart();

                DialogResult result = MessageBox.Show("Account Modified", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    
                }
            }
        }

        private void UpdateStatusInDatabase(bool newStatus, int rowIndex)
        {
            // Get the value of the unique identifier for the selected row
            string uniqueIdentifierValue = dataGridView1.Rows[rowIndex].Cells["Username"].Value.ToString();

            // Update the status in the database
            string updateQuery = "UPDATE Table_Login SET Status = @Status WHERE Username = @Username";
            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
            {
                updateCommand.Parameters.AddWithValue("@Status", newStatus ? "Active" : "Inactive");
                updateCommand.Parameters.AddWithValue("@Username", uniqueIdentifierValue);
                updateCommand.ExecuteNonQuery();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if it's the "Status" column
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Status")
                {
                    // Get the cell
                    DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Check if the cell value is not null
                    if (cell.Value != null)
                    {
                        // Get the value of the "Status" cell
                        string status = cell.Value.ToString();

                        // Set cell color based on the status value
                        if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                        {
                            // Set green color for active status
                            e.CellStyle.BackColor = Color.Green;
                        }
                        else if (status.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                        {
                            // Set red color for inactive status
                            e.CellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void UpdateChart()
        {
            // Count the number of active and inactive rows
            int activeCount = 0;
            int inactiveCount = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                string status = row["Status"].ToString();

                if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                {
                    activeCount++;
                }
                else if (status.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                {
                    inactiveCount++;
                }
            }

            // Clear the existing series and points
            chart1.Series.Clear();

            // Create a new series
            Series series = new Series();

            // Set the chart type to pie
            series.ChartType = SeriesChartType.Pie;

            // Add data points to the series
            DataPoint activePoint = series.Points.Add(activeCount);
            activePoint.LegendText = "Active: " + activeCount;
            activePoint.Color = Color.Green; // Set green color for active slice

            DataPoint inactivePoint = series.Points.Add(inactiveCount);
            inactivePoint.LegendText = "Inactive: " + inactiveCount;
            inactivePoint.Color = Color.Red; // Set red color for inactive slice

            // Add the series to the chart
            chart1.Series.Add(series);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBox1.SelectedItem.ToString();

            if (selectedFilter.Equals("Active", StringComparison.OrdinalIgnoreCase))
            {
                // Show only active rows
                dataTable.DefaultView.RowFilter = "Status = 'Active'";
            }
            else if (selectedFilter.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
            {
                // Show only inactive rows
                dataTable.DefaultView.RowFilter = "Status = 'Inactive'";
            }
            else if (selectedFilter.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                // Show all rows
                dataTable.DefaultView.RowFilter = string.Empty;
            }
        }

        private void label3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Dashboard_Paint(object sender, PaintEventArgs e)
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

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(label4.Font, FontStyle.Underline);
            label4.Font = font;
            label4.BackColor = Color.LightGray;
            label4.Cursor = Cursors.Hand;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            label4.Font = defaultFont;
            label4.BackColor = SystemColors.Control;
            label4.Cursor = Cursors.Default;
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

        private void lblSignout_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblSignout.Font = defaultFont;
            lblSignout.BackColor = SystemColors.Control;
            lblSignout.Cursor = Cursors.Default;
        }

        private void lblSignout_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblSignout.Font, FontStyle.Underline);
            lblSignout.Font = font;
            lblSignout.BackColor = Color.LightGray;
            lblSignout.Cursor = Cursors.Hand;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // do nothing
            }
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            Font defaultFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            lblExit.Font = defaultFont;
            lblExit.BackColor = SystemColors.Control;
            lblExit.Cursor = Cursors.Default;
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            Font font = new Font(lblExit.Font, FontStyle.Underline);
            lblExit.Font = font;
            lblExit.BackColor = Color.LightGray;
            lblExit.Cursor = Cursors.Hand;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            this.lbltimer.Text = date.ToLongDateString();
            lbltodate.Text = DateTime.Now.ToLongTimeString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Admin_Create admin_create = new Admin_Create();
            admin_create.Show();
            this.Hide();
        }

        private void lbltodate_Click(object sender, EventArgs e)
        {

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Admin_Main admin_Main = new Admin_Main();
            admin_Main.Show();
            this.Hide();
        }
    }
    }

