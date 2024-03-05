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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ZXing;
using System.Drawing.Printing;

namespace RMS_Rev
{
    public partial class Payment : Form
    {
        // DATABASE CONNECTION 
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05");


        public Payment()
        {
            InitializeComponent();
        }
        void data()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Table_Trans", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dtPayment.DataSource = dt;
            con.Close();
        }
        private void txtTransno_MouseEnter(object sender, EventArgs e)
        {
            //txtTransno.Text = "";
        }


        private void txtTransno_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void txtTransno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is a digit
            if (!char.IsDigit(e.KeyChar))
            {
                // If it's not a digit, cancel the key press event
                e.Handled = true;
            }
        }

        private void txtTransno_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05");



            con.Open();
            string query = "Select * from Table_Trans where (Transaction_No) like '%" + txtTransno.Text + "%'";
            //string query = "select * from tbl_info where Transaction_No = '" + txtTr + "'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dtPayment.DataSource = dt;
            con.Close();
            //try
            //{
            //    con.Open();

            //    SqlCommand cmdsearch = new SqlCommand("Select * from tbl_info", con);
            //    cmdsearch.Parameters.AddWithValue("@TransactionNo", int.Parse(txtTransno.Text));
            //    SqlDataReader da = cmdsearch.ExecuteReader();

            //    while (da.Read())
            //    {
            //        DataTable dataTable = new DataTable();

            //        // Use a SqlDataAdapter to fill the DataTable with data from the query
            //        SqlDataAdapter adapter = new SqlDataAdapter(cmdsearch);
            //        adapter.Fill(dataTable);

            //        // Bind the DataTable to the DataGridView

            //        dtPayment.DataSource = dataTable;

            //    }

            //    con.Close();
            //}
            //catch

            //{

            //}

            //if (txtTransno.Text == "")

            //{

            //    dtPayment.ResetText();

            //}

            //else

            //    return;

        }



        private void Payment_Paint(object sender, PaintEventArgs e)
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

        private void lblSignout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_Login frm_login = new frm_Login();
                frm_login.Show();
            }
            else
            {
                // do nothing
            }
        }

        private void lblhome_Click(object sender, EventArgs e)
        {
            Employee_Main employee_main= new Employee_Main();
            employee_main.Show();
            this.Hide();
        }

        private void lblPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            Records records = new Records();
            records.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            data();
            lblPay.BackColor = Color.Gray;
            lblPay.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void lblCreate_Click(object sender, EventArgs e)
        {


            if (dtPayment.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtPayment.SelectedRows[0];
                string transactionNumber = selectedRow.Cells["Transaction_No"].Value.ToString();
                string initialPrice = selectedRow.Cells["Initial_Price"].Value.ToString();

                if (decimal.TryParse(txtAmount.Text, out decimal paymentAmount))
                {
                    decimal initialAmount = decimal.Parse(initialPrice);
                    decimal change = paymentAmount - initialAmount;

                    // Update the Payment_Status and cell color
                    selectedRow.Cells["Payment_Status"].Value = "Paid";
                    selectedRow.Cells["Payment_Status"].Style.BackColor = Color.Green;

                    // Update the Payment_Status in the database
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05"))
                    {
                        con.Open();
                        string query = "UPDATE Table_Trans SET Payment_Status = 'Paid' WHERE Transaction_No = @TransactionNo";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@TransactionNo", transactionNumber);
                        cmd.ExecuteNonQuery();
                    }

                    // get value from the "Initial_Price" column in the DataGridView
                    decimal servicePrice = decimal.Parse(initialPrice);
                    decimal customerMoney = decimal.Parse(txtAmount.Text);

                    // calculate the total and change
                    decimal total = servicePrice;
                    decimal change2 = customerMoney - total;

                    // create receipt string
                    string repairman = "Kurt Pogi";
                    string date = DateTime.Now.ToShortDateString();
                    string time = DateTime.Now.ToShortTimeString();
                    string receipt = "---------------------------\n"
                        + "       WolfGang Electronics\n"
                        + "---------------------------\n"
                        + "Repairman: ".PadRight(20) + repairman + "\n"
                        + "Date: ".PadRight(20) + date.PadLeft(10) + "\n"
                        + "Time: ".PadRight(20) + time.PadLeft(10) + "\n"
                        + "Service Due: ".PadRight(20) + servicePrice.ToString("C").PadLeft(10) + "\n"
                        + "---------------------------\n"
                        + "Total: ".PadRight(20) + total.ToString("C").PadLeft(10) + "\n"
                        + "Amount: ".PadRight(20) + customerMoney.ToString("C").PadLeft(10) + "\n"
                        + "Change: ".PadRight(20) + change2.ToString("C").PadLeft(10) + "\n"
                        + "---------------------------\n"
                        + "         Quality Service is Our Recipe!\n"
                        + "---------------------------\n\n";

                    // generate barcode image
                    BarcodeWriter barcodeWriter = new BarcodeWriter();
                    barcodeWriter.Format = BarcodeFormat.CODE_93;
                    barcodeWriter.Options.PureBarcode = true;
                    Bitmap barcodeImage = barcodeWriter.Write(total.ToString());

                    // create picture box for barcode image
                    PictureBox BarcodePictureBox = new PictureBox();
                    BarcodePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    BarcodePictureBox.Size = new Size(225, 125);
                    BarcodePictureBox.Image = barcodeImage;

                    // show print preview dialog
                    using (PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog())
                    {
                        // create PrintDocument object
                        PrintDocument document = new PrintDocument();

                        // add event handler for document's PrintPage event
                        document.PrintPage += (s, ev) =>
                        {
                            // set font and print receipt text
                            Font font = new Font("Courier New", 12);
                            StringFormat stringFormat = new StringFormat();
                            stringFormat.Alignment = StringAlignment.Center;
                            RectangleF receiptRect = new RectangleF(0, 0, ev.PageBounds.Width, ev.PageBounds.Height);
                            ev.Graphics.DrawString(receipt, font, Brushes.Black, receiptRect, stringFormat);
                            //ev.Graphics.DrawString(receipt, font, Brushes.Black, new PointF(0, 0));
                            int barcodeX = (ev.PageBounds.Width - BarcodePictureBox.Width) / 2;
                            int barcodeY = ev.PageBounds.Height - 100 - BarcodePictureBox.Height;

                            // add barcode image to the print page
                            //ev.Graphics.DrawImage(BarcodePictureBox.Image, new Point(0, ev.PageBounds.Height - 900));
                            int x = (ev.PageBounds.Width - BarcodePictureBox.Width) / 2;
                            int y = ev.PageBounds.Height - BarcodePictureBox.Height - 750;
                            ev.Graphics.DrawImage(BarcodePictureBox.Image, new Point(x, y));
                        };

                        // set document as print preview dialog's document
                        printPreviewDialog.Document = document;
                        printPreviewDialog.ShowDialog();

                        // show
                    }

                    MessageBox.Show($"Change: {change}");

                    // Clear the textbox
                    txtAmount.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid payment amount. Please enter a valid number.");
                }
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

            private void dtPayment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtPayment.Columns["Payment_Status"].Index)
            {
                DataGridViewCell cell = dtPayment.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    string paymentStatus = cell.Value.ToString();
                    if (paymentStatus == "Paid")
                    {
                        cell.Style.BackColor = Color.Green;
                        cell.Style.ForeColor = Color.White;
                    }
                    else if (paymentStatus == "Unpaid")
                    {
                        cell.Style.BackColor = Color.Red;
                        cell.Style.ForeColor = Color.White;
                    }
                    else
                    {
                        cell.Style.BackColor = dtPayment.DefaultCellStyle.BackColor;
                        cell.Style.ForeColor = dtPayment.DefaultCellStyle.ForeColor;
                    }
                }
            }
        }

        private void picboxArrow_Click(object sender, EventArgs e)
        {
            if (dtPayment.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtPayment.SelectedRows[0];
                string transactionNumber = selectedRow.Cells["Transaction_No"].Value.ToString();
                string initialPrice = selectedRow.Cells["Initial_Price"].Value.ToString();

                if (decimal.TryParse(txtAmount.Text, out decimal paymentAmount))
                {
                    decimal initialAmount = decimal.Parse(initialPrice);
                    decimal change = paymentAmount - initialAmount;

                    // Update the Payment_Status and cell color
                    selectedRow.Cells["Payment_Status"].Value = "Paid";
                    selectedRow.Cells["Payment_Status"].Style.BackColor = Color.Green;

                    // Update the Payment_Status in the database
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05"))
                    {
                        con.Open();
                        string query = "UPDATE Table_Trans SET Payment_Status = 'Paid' WHERE Transaction_No = @TransactionNo";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@TransactionNo", transactionNumber);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Payment Successfully");

                    // Clear the textbox
                    txtAmount.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid payment amount. Please enter a valid number.");
                }
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void picboxCreate_Click(object sender, EventArgs e)
        {
            if (dtPayment.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtPayment.SelectedRows[0];
                string transactionNumber = selectedRow.Cells["Transaction_No"].Value.ToString();
                string initialPrice = selectedRow.Cells["Initial_Price"].Value.ToString();

                if (decimal.TryParse(txtAmount.Text, out decimal paymentAmount))
                {
                    decimal initialAmount = decimal.Parse(initialPrice);
                    decimal change = paymentAmount - initialAmount;

                    // Update the Payment_Status and cell color
                    selectedRow.Cells["Payment_Status"].Value = "Paid";
                    selectedRow.Cells["Payment_Status"].Style.BackColor = Color.Green;

                    // Update the Payment_Status in the database
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05"))
                    {
                        con.Open();
                        string query = "UPDATE Table_Trans SET Payment_Status = 'Paid' WHERE Transaction_No = @TransactionNo";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@TransactionNo", transactionNumber);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Change: {change}");

                    // Clear the textbox
                    txtAmount.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid payment amount. Please enter a valid number.");
                }
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void label3_Click_1(object sender, EventArgs e)
        {
            Bin bin = new Bin();
            bin.Show();
            this.Hide();
        }

        private void lbldashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
    }
    



         
