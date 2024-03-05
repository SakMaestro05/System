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
    public partial class ApprovedUsersForm : Form
    {
        private DataTable approvedAndRejectedUsers;
        public ApprovedUsersForm()
        {
            InitializeComponent();
        }

        private void ApprovedUsersForm_Load(object sender, EventArgs e)
        {
            LoadApprovedAndRejectedUsers();
        }

        public void LoadApprovedAndRejectedUsers()
        {

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=Leah-Oquindo\\SQLSERVER;Initial Catalog=projectrecord;User ID=wolfserver;Password=wolf2g@ng23"))
                {
                    con.Open();

                    // Retrieve the approved and rejected user accounts from the database
                    SqlCommand getApprovedAndRejectedUsersCmd = new SqlCommand("SELECT * FROM Loginnn WHERE Status = 'Approved' OR Status = 'Rejected'", con);

                    SqlDataAdapter adapter = new SqlDataAdapter(getApprovedAndRejectedUsersCmd);
                    approvedAndRejectedUsers = new DataTable();
                    adapter.Fill(approvedAndRejectedUsers);

                    // Bind the combined list of approved and rejected users to the DataGridView
                    dataGridView1.DataSource = approvedAndRejectedUsers;

                    // Customize the appearance of the rows based on the account status
                    //        foreach (DataGridViewRow row in dataGridView1.Rows)
                    //        {
                    //            // Get the cell based on the column name
                    //            DataGridViewCell cell = row.Cells["Status"];

                    //            // Check if the cell and its value are not null
                    //            if (cell != null && cell.Value != null)
                    //            {
                    //                string status = cell.Value.ToString();

                    //                if (status == "Approved")
                    //                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    //                else if (status == "Rejected")
                    //                    row.DefaultCellStyle.BackColor = Color.Red;
                    //            }
                    //        }

                    //    }
                    //}
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        // Get the cell based on the column name
                        DataGridViewCell cell = row.Cells["Status"];

                        // Check if the cell and its value are not null
                        if (cell != null && cell.Value != null)
                        {
                            string status = cell.Value.ToString();

                            if (status == "Approved")
                                cell.Style.BackColor = Color.LightGreen;
                            else if (status == "Rejected")
                                cell.Style.BackColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading approved and rejected users: " + ex.Message);
            }
        }
    }
}