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
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
        }
        private void btnconfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=Leah-Oquindo\\SQLSERVER;Initial Catalog=projectrecord;User ID=wolfserver");

            try
            {
                conn.Open();

                string query = "SELECT * FROM LOGIN_ACCOUNT WHERE Username = '" + txt_user.Text + "' AND Password ='" + txt_pass.Text + "' ";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                MessageBox.Show("Successfully Confirmed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                global_login.confirmed = "true";
                this.Hide();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                global_login.confirmed = "false";
                txt_user.Clear();
                txt_pass.Clear();
                this.Hide();

            }

        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
        }



        //private void btn_showpass_Click(object sender, EventArgs e)
        //{
        //    txt_pass.UseSystemPasswordChar = false;
        //    btn_hidepass.Visible = true;
        //    btn_showpass.Visible = false;
        //}

        //private void btn_hidepass_Click(object sender, EventArgs e)
        //{
        //    txt_pass.UseSystemPasswordChar = true;
        //    btn_showpass.Visible = true;
        //    btn_hidepass.Visible = false;
        //}




        private Point _mouseLoc;


        private void Confirm_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void Confirm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void btnShowpass_Click(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = false;
            btnHidepass.Visible = true;
            btnShowpass.Visible = false;
         
        }

        private void btnHidepass_Click(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
            btnShowpass.Visible = true;
            btnHidepass.Visible = false;
        }
    }
}



    
public static class global_login
{
    public static string confirmed = "false";
}

