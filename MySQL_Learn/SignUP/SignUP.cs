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

namespace MySQL_Learn.SignUP
{

    public partial class SignUP : Form
    {
        String connectionstring = "Server=SARAN;Database=CSharpBatch;Trusted_Connection=True;";
        public SignUP()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login.SignUp signUp = new Login.SignUp();
            signUp.Show();
           // this.Hide();
        }

        private void radioUser_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into users(username,password,firstname,lastname)values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtFname.Text + "','" + txtLname.Text + "')", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            

            Login.SignUp signUp = new Login.SignUp();
                
            if (radioUser.Checked == true)
            {
                this.Hide();
                signUp.Show();

                return;
            }
            else if (radioAdmin.Checked == true)
            {
                this.Hide();
                signUp.Show();
                return;
            }
            else
            {
                MessageBox.Show("Please select ar you admin or user!!!");
                return;
            }
        }

        private void radioAdmin_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into Admin(username,password,firstname,lastname)values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtFname.Text + "','" + txtLname.Text + "')", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void SignUP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Formclose.FormClose(e);
        }

        private void SignUP_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
