using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Rev
{
    public partial class Employee_Create_Transaction : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Leah-Oquindo\\SQLSERVER;Initial Catalog=projectrecord;User ID=wolfserver;Password=wolf2g@ng23");
        string g;

        public Employee_Create_Transaction()
        {
            InitializeComponent();
        }

        private void Employee_Create_Transaction_Load(object sender, EventArgs e)
        {
                optbtnphone.Checked = false;
                optbtnlaptop.Checked = false;
                data();
            Random rnd = new Random();
            int randomnum = rnd.Next(100000000, 999999999);
            txtTransactionNo.Text = randomnum.ToString();
            Refresh();
        }


        //CONNECTION IN THE DATAGRIDVIEW //
        void data()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("Select * from tbl_info", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dtGridView.DataSource = dt;

        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtfn.Text == "" || txtsur.Text == "" || txtdeviceinfo.Text == "" || txtHomeAddress.Text == "" || cboStatus.Text == "" || cbotrans.Text == "" || cbopay.Text == "" || cbotrans.Text == "")
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
            SqlCommand cmd = new SqlCommand("insert into tbl_info values ('" + txtTransactionNo.Text + "','" + txtfn.Text + "','" + txtmn.Text + "','" + txtsur.Text + "','" + txtsuf.Text + "','" + txtPhoneNumber.Text + "','" + txtHomeAddress.Text + "','" + txtEmailAddress.Text + "','" + txtdeviceinfo.Text + "','" + g + "','" + cbotrans.Text + "','" + txtprice.Text + "','" + cboStatus.Text + "','" + cbopay.Text + "','" + dtpstart.Text + "','" + dtpend.Text + "')", con);
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
               Employee_Add_Transaction ADD_TRANSACTION = new Employee_Add_Transaction();
                ADD_TRANSACTION.Show();

            }

            txtTransactionNo.Text = "";
            txtfn.Text = "";
            txtmn.Text = "";
            txtsur.Text = "";
            txtsuf.Text = "";
            txtdeviceinfo.Text = "";
            txtPhoneNumber.Text = "";
            txtHomeAddress.Text = "";
            txtEmailAddress.Text = "";
            txtTransactionNo.Text = "";
            cboStatus.Text = "";
            cbotrans.Text = "";
            cbopay.Text = "";
            txtprice.Text = "";
            dtpstart.Text = "";
            dtpend.Text = "";
            optbtnphone.Checked = false;
            optbtnlaptop.Checked = false;

            {
                if (dtGridView.SelectedRows.Count > 0) ; // make sure user select at least 1 row 

            }



        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // VIEW SELECTED COLUMN IN DATAGRIDVIEW //

                if (dtGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {

                    string accno = dtGridView.SelectedRows[0].Cells[0].Value + string.Empty;
                    string firstname = dtGridView.SelectedRows[0].Cells[1].Value + string.Empty;
                    string Middlename = dtGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                    string Surname = dtGridView.SelectedRows[0].Cells[3].Value + string.Empty;
                    string Suffix = dtGridView.SelectedRows[0].Cells[4].Value + string.Empty;
                    string phonenumber = dtGridView.SelectedRows[0].Cells[5].Value + string.Empty;
                    string homeaddress = dtGridView.SelectedRows[0].Cells[6].Value + string.Empty;
                    string email = dtGridView.SelectedRows[0].Cells[7].Value + string.Empty;
                    string device = dtGridView.SelectedRows[0].Cells[8].Value + string.Empty;
                    string category = dtGridView.SelectedRows[0].Cells[9].Value + string.Empty;
                    string service = dtGridView.SelectedRows[0].Cells[10].Value + string.Empty;
                    string price = dtGridView.SelectedRows[0].Cells[11].Value + string.Empty;
                    string status = dtGridView.SelectedRows[0].Cells[12].Value + string.Empty;
                    string payment = dtGridView.SelectedRows[0].Cells[13].Value + string.Empty;
                    string start = dtGridView.SelectedRows[0].Cells[14].Value + string.Empty;
                    string end = dtGridView.SelectedRows[0].Cells[15].Value + string.Empty;
                    if (optbtnphone.Checked == true)
                    {
                        g = "Phone";


                    }

                    if (optbtnlaptop.Checked == true)
                    {
                        g = "Laptop";

                    }

                    txtTransactionNo.Text = accno;
                    txtfn.Text = firstname;
                    txtmn.Text = Middlename;
                    txtsur.Text = Surname;
                    txtsuf.Text = Suffix;
                    txtPhoneNumber.Text = phonenumber;
                    txtHomeAddress.Text = homeaddress;
                    txtEmailAddress.Text = email;
                    txtdeviceinfo.Text = device;
                    cbotrans.Text = service;
                    txtprice.Text = price;
                    cboStatus.Text = status;
                    cbopay.Text = payment;
                    dtpstart.Text = start;
                    dtpend.Text = end;
                    int items;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            iDelete();
        
         }
        private void iDelete()
        {
            if (txtTransactionNo.Text != "")
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete tbl_info where Transaction_No='" + txtTransactionNo.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                data();


                txtfn.Text = "";
                txtmn.Text = "";
                txtsur.Text = "";
                txtsuf.Text = "";
                txtdeviceinfo.Text = "";
                txtPhoneNumber.Text = "";
                txtHomeAddress.Text = "";
                txtEmailAddress.Text = "";
                txtTransactionNo.Text = "";
                cboStatus.Text = "";
                cbopay.Text = "";
                cbotrans.Text = "";
                txtprice.Text = "";
                dtpstart.Text = "";
                dtpend.Text = "";
                optbtnphone.Checked = false;
                optbtnlaptop.Checked = false;


                MessageBox.Show("Successfully Deleted!");
            }
            else
            {
                MessageBox.Show("Enter Value in table informaion field.");
            }
        }
        Bitmap bitmap;
        private string s;

        private void prntDocs_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            iReset();
        }

        private void iReset()
        {

            /* txtFirstName.Text = string.Empty;
             txtMiddleName.Text = string.Empty;
             txtSurname.Text = string.Empty;
             txtPhoneNumber.Text = string.Empty;
             txtHomeAddress.Text = string.Empty;
             txtEmailAddress.Text = string.Empty;
             txtTransNo.Text = string.Empty;
            //===============Clear All TextBox Data==========================

            foreach (var c in this.Controls)
             {
                 if (c is TextBox)
                 {
                     ((TextBox)c).Text=String.Empty;
                 }
             } */
            cboStatus.Text = string.Empty;
            txtdeviceinfo.Text = string.Empty; 
            cbotrans.Text = string.Empty;
            cbopay.Text = string.Empty;
            txtprice.Text = string.Empty;
            dtGridView.ClearSelection();
            optbtnlaptop.Checked = false;
            optbtnphone.Checked = false;
            dtpstart.Value = DateTime.Now;
            dtpend.Value = DateTime.Now;

            foreach (Control c in grpboxnewinfo.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    c.Text = "";
                }
            }
            if (optbtnphone.Checked)
            {
                optbtnphone.Checked = true;
            }
            else if (optbtnphone.Checked)
            {
                optbtnphone.Checked = false;
            }
      
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MeExit();

        }

        private void MeExit()
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void txtTransactionNo_TextChanged(object sender, EventArgs e)
        {
            if (txtTransactionNo.Text.Length < 9)
            {
                txtTransactionNo.ForeColor = Color.OrangeRed;

            }
            else
            {
                txtTransactionNo.ForeColor = Color.White;
                btnAddNew.Enabled = true;
            }
            if (string.IsNullOrEmpty(txtTransactionNo.Text))
            {
                txtTransactionNo.ResetText();
                return;
            }
            txtTransactionNo.Text = txtTransactionNo.Text;
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

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            txtprice.ReadOnly = true;
        }

        private void optbtnphone_CheckedChanged(object sender, EventArgs e)
        {
            if (optbtnphone.Checked == true)
            {
                g = "Phone";

            }

            optbtnlaptop.Checked = false;

            optbtnphone.ForeColor = Color.White;
            optbtnlaptop.ForeColor = Color.White;
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
            optbtnphone.ForeColor = Color.White;
            optbtnlaptop.ForeColor = Color.White;

            cbotrans.Items.Clear();
            cbotrans.Items.Add("Screen Damage");
            cbotrans.Items.Add("Password Removal");
            cbotrans.Items.Add("Hardware Issues");
            cbotrans.Items.Add("Software Issues");
            cbotrans.Items.Add("Data Recovery and Backup");
            cbotrans.Items.Add("Troubleshooting and Networking Support");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
              Bitmap bmp = new Bitmap(dtGridView.Width, dtGridView.Height);
                dtGridView.DrawToBitmap(bmp, new Rectangle(0, 0, dtGridView.Width, dtGridView.Height));
                e.Graphics.DrawImage(bmp, e.MarginBounds.Location);

          
        }
    }
    
}

