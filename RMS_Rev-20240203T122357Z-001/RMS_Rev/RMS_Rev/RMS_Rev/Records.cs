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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq.Expressions;

namespace RMS_Rev
{
    public partial class Records : Form
    {
        // DATABASE CONNECTION 
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05");

        public Records()
        {
            InitializeComponent();
        }

        private void Records_Paint(object sender, PaintEventArgs e)
        {
            // Code for custom shape
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

        private void lbldashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Code for label click event
        }

        private void lblPay_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }

        private void lblhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Main Home = new Employee_Main();
            Home.ShowDialog();
            this.Show();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            data();
            label1.BackColor = Color.Gray;
            label1.Enabled = false;
        }
        void data()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("Select * from Table_Trans", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dtRecords.DataSource = dt;
            

        }


        private void lblPrint_Click(object sender, EventArgs e)
        {
            if (dtRecords.Rows.Count <= 0)
            {
                DialogResult dialogprint = MessageBox.Show("There is nothing to print, do you still want to print this page?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogprint == DialogResult.Yes)
                {
                    printPreviewDialog1.Document = printDocument1;
                    printDocument1.DefaultPageSettings.Landscape = true;
                    printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Legal", 800, 1300);
                    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            else if (dtRecords.Rows.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to print this page?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    printPreviewDialog1.Document = printDocument1;
                    printDocument1.DefaultPageSettings.Landscape = true;
                    printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Legal", 800, 1300);
                    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    return;
                }
            }
       

            //ExportToPDF(dtRecords);
        }

        private void lblExport_Click(object sender, EventArgs e)
        {
            // Code for export button click event
        }

        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05");
            con.Open();
            string query = "Select * from Table_Trans where (Transaction_No) like '%" + txtSearch.Text + "%'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dtRecords.DataSource = dt;
            con.Close();
        }

        private void ExportToPDF(DataGridView dtRecords)
        {
            //// Create a new PDF document
            //Document doc = new Document(PageSize.A4.Rotate());

            //// Set the output file path
            //string outputPath = @"C:\Users\Administrator\Desktop\RMS_Rev\output.pdf";
            //FileStream outputStream = new FileStream(outputPath, FileMode.Create);

            //// Create a PDF writer instance
            //PdfWriter writer = PdfWriter.GetInstance(doc, outputStream);

            //// Open the document for writing
            //doc.Open();

            //// Create a new table with the same number of columns as the DataGridView
            //PdfPTable table = new PdfPTable(dtRecords.ColumnCount);

            //// Add the column headers to the table
            //for (int i = 0; i < dtRecords.ColumnCount; i++)
            //{
            //    table.AddCell(new Phrase(dtRecords.Columns[i].HeaderText));
            //}

            //// Add the rows to the table
            //for (int i = 0; i < dtRecords.RowCount; i++)
            //{
            //    for (int j = 0; j < dtRecords.ColumnCount; j++)
            //    {
            //        table.AddCell(new Phrase(dtRecords[j, i].Value.ToString()));
            //    }
            //}

            //// Add the table to the document
            //doc.Add(table);

            //// Close the document
            //doc.Close();

            //// Open the PDF file in the default viewer
            //try
            //{
            //    Process.Start(outputPath);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error occurred while opening the PDF file: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(dtRecords.Width, dtRecords.Height);
            dtRecords.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, dtRecords.Width, dtRecords.Height));
            e.Graphics.DrawImage(bitmap, 20, 20);
            Margins margins = new Margins(100, 100, 100, 100);
            printDocument1.DefaultPageSettings.Landscape = true;
        }
    }
}
