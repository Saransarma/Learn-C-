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
    public partial class AdminLogin : Form
    {
        String connectionstring = "Server=SARAN;Database=CSharpBatch;Trusted_Connection=True;";

        ALogin Alg = null;
        private string Login_time = DateTime.Now.ToString();
        private int userid=0;

        
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {

            //int userid = 0;
            Alg = new ALogin();
            Int32 adminCount = Alg.CountAdmin(txtAdminUN.Text.Trim(), txtAdminPW.Text.Trim());
            if (adminCount == 1)
            {
                
                //userid = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                TimeChart.setTime();
                TimeChart.Login_time = DateTime.Now.ToString();
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
            else
            {
                MessageBox.Show("password and user name are not matched...");
            }
        }

      
    }
}
