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
using System.Windows.Forms.DataVisualization.Charting;

namespace RMS_Rev
{
    public partial class Dashboard : Form
    {
        // DATABASE CONNECTION 
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05");

        public Dashboard()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            this.lbltimer.Text = date.ToLongDateString();
            lbltodate.Text = DateTime.Now.ToLongTimeString();
        }

        private void picbpxBg_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            tmr.Start();
            sales();
            countData();
            saless();
            DisplayStatusChart();
            Pie();
            DisplayRevenueVsReceivableChart();
            lbldashboard.Enabled = false;
            lbldashboard.BackColor = Color.Gray;
        }

        void countData()
        {
            con.Open();

            // Sum of Initial_Price for unpaid rows
            SqlCommand cmdUnpaid = new SqlCommand("SELECT SUM(Initial_Price) FROM Table_Trans WHERE Payment_Status = 'Unpaid'", con);
            object unpaidSum = cmdUnpaid.ExecuteScalar();

            if (unpaidSum != DBNull.Value && unpaidSum != null)
            {
                decimal totalUnpaid = Convert.ToDecimal(unpaidSum);
                string formattedTotalUnpaid = "₱ " + totalUnpaid.ToString("0.00");
                lblunpaid.Text = formattedTotalUnpaid;
            }
            else
            {
                lblunpaid.Text = "₱ 0.00";
            }

            // Sum of Initial_Price for paid rows
            SqlCommand cmdPaid = new SqlCommand("SELECT SUM(Initial_Price) FROM Table_Trans WHERE Payment_Status = 'Paid'", con);
            object paidSum = cmdPaid.ExecuteScalar();

            if (paidSum != DBNull.Value && paidSum != null)
            {
                decimal totalPaid = Convert.ToDecimal(paidSum);
                string formattedTotalPaid = "₱ " + totalPaid.ToString("0.00");
                lbllabor.Text = formattedTotalPaid;
            }
            else
            {
                lbllabor.Text = "₱ 0.00";
            }

            // Total row count
            SqlCommand cmdRowCount = new SqlCommand("SELECT COUNT(*) FROM Table_Trans", con);
            int rowCount = (int)cmdRowCount.ExecuteScalar();
            label1.Text = rowCount.ToString();

            con.Close();
        }

        void sales()
        {
            con.Open();

            // Total sales for paid rows
            SqlCommand cmdPaid = new SqlCommand("SELECT SUM(Initial_Price) FROM Table_Trans WHERE Payment_Status = 'Paid'", con);
            object result = cmdPaid.ExecuteScalar();

            if (result != DBNull.Value && result != null)
            {
                decimal totalSales = Convert.ToDecimal(result);
                string formattedTotalSales = "₱ " + totalSales.ToString("0.00");

                lbllabor.Text = formattedTotalSales;
            }
            else
            {
                lbllabor.Text = "₱ 0.00";
            }

            con.Close();
        }

        void saless()
        {
            // ...
        }

        private void DisplayStatusChart()
        {
            // ...
        }

        private void Pie()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Payment_Status, COUNT(*) AS PaymentStatusCount FROM Table_Trans GROUP BY Payment_Status", con);

            SqlDataReader reader = cmd.ExecuteReader();

            List<string> paymentStatuses = new List<string>();
            List<int> paymentStatusCounts = new List<int>();
            List<Color> paymentStatusColors = new List<Color>();

            while (reader.Read())
            {
                if (!reader.IsDBNull(0) && !reader.IsDBNull(1))
                {
                    string paymentStatus = reader.GetString(0);
                    int count = reader.GetInt32(1);

                    paymentStatuses.Add(paymentStatus);
                    paymentStatusCounts.Add(count);

                    // Assign color based on payment status
                    if (paymentStatus == "Paid")
                        paymentStatusColors.Add(Color.GreenYellow);
                    else if (paymentStatus == "Unpaid")
                        paymentStatusColors.Add(Color.Red);
                }
            }

            reader.Close();
            con.Close();

            // Clear existing series from the chart
            chart1.Series.Clear();

            // Create a new chart series
            Series series = new Series("PaymentStatus");
            series.ChartType = SeriesChartType.Pie;

            series.IsValueShownAsLabel = false;

            // Add data points to the series
            for (int i = 0; i < paymentStatuses.Count; i++)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = paymentStatuses[i];
                dataPoint.YValues = new double[] { paymentStatusCounts[i] };
                dataPoint.Color = paymentStatusColors[i]; // Set color for the data point
                series.Points.Add(dataPoint);
            }

            // Add the series to the chart
            chart1.Series.Add(series);

            // Set chart title
            chart1.Titles.Add("Payment Status");
        }

        private void DisplayRevenueVsReceivableChart()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(Initial_Price) AS Revenue, SUM(CASE WHEN Payment_Status = 'Unpaid' THEN Initial_Price ELSE 0 END) AS Receivable FROM Table_Trans", con);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                decimal revenue = reader["Revenue"] != DBNull.Value ? Convert.ToDecimal(reader["Revenue"]) : 0;
                decimal receivable = reader["Receivable"] != DBNull.Value ? Convert.ToDecimal(reader["Receivable"]) : 0;

                // Clear existing series from the chart
                chart2.Series.Clear();

                // Create the series for revenue
                Series revenueSeries = new Series("Revenue");
                revenueSeries.ChartType = SeriesChartType.Column;
                revenueSeries.Color = Color.YellowGreen;

                // Add the revenue data point
                DataPoint revenueDataPoint = new DataPoint();
                revenueDataPoint.AxisLabel = "Revenue";
                revenueDataPoint.YValues = new double[] { (double)revenue };
                revenueSeries.Points.Add(revenueDataPoint);

                // Create the series for accounts receivable
                Series receivableSeries = new Series("Accounts Receivable");
                receivableSeries.ChartType = SeriesChartType.Column;
                receivableSeries.Color = Color.Red;

                // Add the accounts receivable data point
                DataPoint receivableDataPoint = new DataPoint();
                receivableDataPoint.AxisLabel = "Accounts Receivable";
                receivableDataPoint.YValues = new double[] { (double)receivable };
                receivableSeries.Points.Add(receivableDataPoint);

                // Add the series to the chart
                chart2.Series.Add(revenueSeries);
                chart2.Series.Add(receivableSeries);

                // Set chart title
                chart2.Titles.Add("Revenue vs Accounts Receivable");
            }

            reader.Close();
            con.Close();
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

        private void Dashboard_Paint(object sender, PaintEventArgs e)
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
            this.Hide();
            Admin_Main admin_main = new Admin_Main();
            admin_main.Show();
            this.Show();
        }

        private void lblPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.ShowDialog();
            this.Show();
        }

        private void lblPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            Records records = new Records();
            records.ShowDialog();
            records.Show();
           
        }

        private void lblSignout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Signout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Show();
                frm_Login frm_login = new frm_Login();
                frm_login.ShowDialog();
                this.Hide();
            }
            else
            {
                // do nothing
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Show();
            Bin bin = new Bin();
            bin.Hide();
            this.Hide();
        }

        // ...
    }
}
