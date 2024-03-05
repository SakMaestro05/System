using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RMS_Rev
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=Leah-Oquindo\\SQLSERVER;Initial Catalog=projectrecord;User ID=wolfserver");

        private void Signup_Load(object sender, EventArgs e)
        {
           txtPass.UseSystemPasswordChar = true;
        }
        private void btnHidepass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            btnShowpass.Visible = true;
            btnHidepass.Visible = false;
        }

        private void btnShowpass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            btnHidepass.Visible = true;
            btnShowpass.Visible = false;
        }
        //private void btn_showpass_Click(object sender, EventArgs e)
        //{
        //    txtPassword.UseSystemPasswordChar = false;
        //    btnHidepass.Visible = true;
        //    btn_showpass.Visible = false;
        //}

        //private void btn_hidepass_Click(object sender, EventArgs e)
        //{
        //    txtPassword.UseSystemPasswordChar = true;
        //    btn_showpass.Visible = true;
        //    btn_hidepass.Visible = false;
        //}



        private void lblLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtfn.Text == "" || txtln.Text == "" || cbogender.Text == "" || txtPass.Text == "" || txtUser.Text == "" || txtconfirm.Text == "" || rbtn_admin.Checked == false && rbtn_employee.Checked == false)
            {
                MessageBox.Show("Please fill up the missing information!\nChoose type of Account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (txtPass.Text == txtconfirm.Text)
            {

                if (txtPass.Text.Length >= 8 && txtPass.Text.Length <= 15)
                {

                    if (rbtn_admin.Checked == true)
                    {
                        global_login.confirmed = "false";
                        Confirm confim = new Confirm();
                        confim.ShowDialog();

                        if (global_login.confirmed == "true")

                        {
                            try
                            {
                                con.Open();
                                SqlCommand cmd = new SqlCommand("insert into LOGIN_ACCOUNT (First_name,Middle_name,Last_name,Suffix,Gender,Birthday,Password,Username) VALUES ('" + txtfn.Text + "','" + txtmn.Text + "','" + txtln.Text + "','" + cbosuf.Text + "','" + cbogender.Text + "','" + dtpbirth.Text + "','" + txtUser.Text + "','" + txtPass.Text + "')", con);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Successfully create Admin account ", "Signin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtUser.Clear();
                                txtPass.Clear();
                                txtconfirm.Clear();
                                txtfn.Clear();
                                txtln.Clear();
                                txtmn.Clear();
                                cbogender.ResetText();
                                cbosuf.ResetText();
                                rbtn_admin.Checked = false;
                                con.Close();
                            }
                            catch (Exception er)
                            {
                                MessageBox.Show("" + er, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else if (rbtn_employee.Checked == true)
                    {
                        global_login.confirmed = "false";
                        Confirm confim = new Confirm();
                        confim.ShowDialog();


                        if (global_login.confirmed == "true")

                        {

                            try
                            {
                                con.Open();
                                SqlCommand cmd = new SqlCommand("insert into LOGIN_EMPLOYEE (First_name,Middle_name,Last_name,Suffix,Gender,Birthday,Password,Username) VALUES ('" + txtfn.Text + "','" + txtmn.Text + "','" + txtln.Text + "','" + cbosuf.Text + "','" + cbogender.Text + "','" + dtpbirth.Text + "','" + txtUser.Text + "','" + txtPass.Text + "')", con);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Successfully create employee account ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtUser.Clear();
                                txtPass.Clear();
                                txtconfirm.Clear();
                                txtfn.Clear();
                                txtln.Clear();
                                txtmn.Clear();
                                cbogender.ResetText();
                                cbosuf.ResetText();
                                rbtn_admin.Checked = false;
                                con.Close();
                                con.Close();
                            }
                            catch (Exception er)
                            {
                                MessageBox.Show("" + er, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                    }

                }
                else
                {
                    MessageBox.Show("Password is too Short!\n\nMin 8 char and max 15 char", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Password and Confirm Password Did not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close(); 
        
        }

       
    }
}
