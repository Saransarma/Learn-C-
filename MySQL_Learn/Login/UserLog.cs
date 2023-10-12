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

namespace MySQL_Learn.Login
{
    public partial class UserLog : Form
    {
        String connectionstring = "Server=SARAN;Database=CSharpBatch;Trusted_Connection=True;";
        public UserLog()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TimeChart.setTime1();
            TimeChart.Logout_time = DateTime.Now.ToString();
            this.Close();
        }

        public void btnData_Click(object sender, EventArgs e)
        {
            int user_id = 0;
            SqlConnection con = new SqlConnection(connectionstring);
            using (con)
            {
                SqlCommand cmd = new SqlCommand("select * from Student_DB1", con);
                using (cmd)
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt;
                    user_id = Convert.ToInt32(dt.Rows[0]["id"].ToString());

                    con.Close();
                }

            }
        }

        private void UserLog_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void UserLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Logout?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                TimeChart.setTime1();
                TimeChart.Logout_time = DateTime.Now.ToString();
                e.Cancel = true;
            }
        }
    }
}
