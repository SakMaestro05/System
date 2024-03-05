using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Rev
{
    public partial class Add_Transaction : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6QJF4DK;Initial Catalog=RMS_Rev;Persist Security Info=True;User ID=sa;Password=krtaxldlssnts@05");
        private AutoCompleteStringCollection autoCompleteCollection;

        string g;
        public Add_Transaction()
        {
            InitializeComponent();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtfn.Text == "" || txtln.Text == ""  || txtHomeAddress.Text == "" || cboStatus.Text == "" || cbotrans.Text == "" || cbopay.Text == "")
                {

                    MessageBox.Show("Please Fill all the Blanks.");
                    return;

                }

                if (optbtnphone.Checked == true)
                {
                    g = "Phone";
                }
                else
                {
                    g = "Computer";

                }

                data();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tbl_info values ('" + txtTransactionNo.Text + "','" + lbltodate.Text + "','" + lbltimer.Text + "','" + txtfn.Text + "','" + txtmn.Text + "','" + txtln.Text + "','" + txtsuf.Text + "','" + txtPhoneNumber.Text + "','" + txtHomeAddress.Text + "','" + txtdeviceinfo.Text + "','" + g + "','" + cbotrans.Text + "','" + txtprice.Text + "','" + cboStatus.Text + "','" + cbopay.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                data();

                MessageBox.Show("Successfully Added!");
                DialogResult Add;

                Add = MessageBox.Show("Do you want to add transaction?", "Access Connect", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Add == DialogResult.Yes)
                {
                    data();
                    // Create an instance of the existing form that contains a textbox for the last name
                    Add_Transaction ADD_TRANSACTION = new Add_Transaction();
                    ADD_TRANSACTION.Show();

                }

                txtTransactionNo.Text = "";
                txtfn.Text = "";
                txtmn.Text = "";
                txtln.Text = "";
                txtsuf.Text = "";
                txtPhoneNumber.Text = "";
                txtHomeAddress.Text = "";
                txtTransactionNo.Text = "";
                cboStatus.Text = "";
                cbopay.Text = "";
                lbltimer.Text = "";
                lbltimer.Text = "";
                lbltodate.Text = "";
                cbotrans.Text = "";
                optbtnphone.Checked = false;
                optbtnlaptop.Checked = false;

                {
                    if (dtGridView.SelectedRows.Count > 0) ; // make sure user select at least 1 row 

                }



            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Add_Transaction_Load(object sender, EventArgs e)
        {
            
            cbopay.Visible  = false;
            cboStatus.Visible = false;
            lblStatus.Visible = false;
            lblpay.Visible = false; 
            tmr.Start();
            optbtnphone.Checked = false;
            optbtnlaptop.Checked = false;
            data();

            Random rnd = new Random();
            int randomnum = rnd.Next(100000000, 999999999);
            txtTransactionNo.Text = randomnum.ToString();
            Refresh();




            try
            {
                con.Open();
                SqlCommand cmdsearch = new SqlCommand("SELECT TOP 1 * from tbl_info ORDER BY First_Name ASC", con);
                SqlDataReader da = cmdsearch.ExecuteReader();
                while (da.Read())
                {


                    txtfn.Text = da.GetValue(1).ToString();
                    txtmn.Text = da.GetValue(2).ToString();
                    txtln.Text = da.GetValue(3).ToString();
                    txtsuf.Text = da.GetValue(4).ToString();
                    txtPhoneNumber.Text = da.GetValue(5).ToString();
                    txtHomeAddress.Text = da.GetValue(6).ToString();




                    txtfn.ReadOnly = true;
                    txtfn.Enabled = false;
                    txtmn.ReadOnly = true;
                    txtmn.Enabled = false;
                    txtln.ReadOnly = true;
                    txtln.Enabled = false;
                    txtsuf.ReadOnly = true;
                    txtsuf.Enabled = false;
                    txtPhoneNumber.ReadOnly = true;
                    txtPhoneNumber.Enabled = false;
                    txtHomeAddress.ReadOnly = true;
                    txtHomeAddress.Enabled = false;



                    con.Close();
                }


            }
            catch

            {
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

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction Transaction = new Transaction();
            Transaction.ShowDialog();
            this.Show();
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

        private void Add_Transaction_Paint(object sender, PaintEventArgs e)
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

        private void lblPrint_Click(object sender, EventArgs e)
        {
                Records records = new Records();
                records.Show();
                this.Hide();
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

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to sign out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // do nothing
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Admin_Main admin_main = new Admin_Main();
            admin_main.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Admin_Main admin_Main = new Admin_Main();
            admin_Main.Show();
            this.Hide();
        }
    }
    }

