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
    public partial class FrmLogin : Form
    {
        //String connectionstring = "Server=SARAN;Database=CSharpBatch;Trusted_Connection=True;";
        login lg = null;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            lg = new login();
            Int32 count = lg.CountUser(txtname.Text.Trim(), txtpss.Text.Trim());
            if (count == 1)
            {
                this.Hide();
                UserLog userLog = new UserLog();
                userLog.Show();
            }
            else
            {
                MessageBox.Show("password and user name are not matched...");
            }
        }

       
    }
}
