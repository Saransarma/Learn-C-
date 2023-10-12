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

namespace MySQL_Learn
{
    public partial class Form1 : Form
    {
        String connectionstring = "Server=SARAN;Database=CSharpBatch;Trusted_Connection=True;";
        String id = null;
        private string userid;

        public string Logout_time { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);

            try
            {
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();
                    MessageBox.Show("Connection Open");

                }
               // MessageBox.Show(state.ToString());
                con.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message.ToString());
                throw;
            }
        }

        private void btnDatareader_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Student_DB1",con);
            SqlDataReader SqlDataReader = cmd.ExecuteReader();
            while (SqlDataReader.Read())
            {
                MessageBox.Show(SqlDataReader.GetValue(0).ToString());
                MessageBox.Show(SqlDataReader.GetValue(1).ToString());
                MessageBox.Show(SqlDataReader.GetValue(2).ToString());
                MessageBox.Show(SqlDataReader.GetValue(3).ToString());
                MessageBox.Show(SqlDataReader.GetValue(4).ToString());
                MessageBox.Show(SqlDataReader.GetValue(5).ToString());


            }
            SqlDataReader.Close();
            cmd.Dispose();
            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDatagrid_Click(object sender, EventArgs e)
        {
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
                    con.Close();
                }

            }  
            //SqlDataReader SqlDataReader = cmd.ExecuteReader();
            //SqlDataReader.Close();
           // cmd.Dispose();
            
        }
        public void Validation()
        {
            if (string.IsNullOrEmpty(txtFname.Text))
            {
                MessageBox.Show("Enter the First Name!");
                txtFname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtLname.Text))
            {
                MessageBox.Show("Enter the Last Name!");
                txtLname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtGender.Text))
            {
                MessageBox.Show("Enter the Gender!");
                txtGender.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Enter the Address!");
                txtAddress.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Enter the Age!");
                txtAge.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtGrade.Text))
            {
                MessageBox.Show("Enter the Grade!");
                txtGrade.Focus();
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Validation();
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into Student_DB1(FirstName,LastName,Gender,Age,Address,Grade)values('"+txtFname.Text+"','"+txtLname.Text+"','"+txtGender.Text+"','"+txtAddress.Text+"','"+txtAge.Text+"','"+txtGrade.Text+"')", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
            btnDatagrid_Click(sender, e);
            Reset();

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtFname.Text = dataGridView1.SelectedRows[0].Cells["FirstName"].Value.ToString();
            txtLname.Text = dataGridView1.SelectedRows[0].Cells["LastName"].Value.ToString();
            txtGender.Text = dataGridView1.SelectedRows[0].Cells["Gender"].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells["Address"].Value.ToString();
            txtAge.Text = dataGridView1.SelectedRows[0].Cells["Age"].Value.ToString();
            txtGrade.Text = dataGridView1.SelectedRows[0].Cells["Grade"].Value.ToString();
            this.id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Validation();
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("update Student_DB1 set FirstName='" + txtFname.Text + "',LastName='" + txtLname.Text + "',Gender='" + txtGender.Text + "',Age='" + txtAge.Text + "',Address='" + txtAddress.Text + "',Grade='" + txtGrade.Text + "' where id='" + this.id + "'", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
            btnDatagrid_Click(sender, e);
            Reset();
        }

        private void Reset()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtGender.Text = "";
            txtAddress.Text = "";
            txtAge.Text = "";
            txtGrade.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("delete from Student_DB1  where id='" + this.id + "'", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
            btnDatagrid_Click(sender, e);
            Reset();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDatagrid_Click(sender, e);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Logout?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else
            {
                TimeChart.setTime1();
                TimeChart.Logout_time = DateTime.Now.ToString();
                Application.Exit();
            }
            
        }

        private void btnTimechart_Click(object sender, EventArgs e)
        {
            TimeChart timeChart = new TimeChart();
            timeChart.Show();
        }
    }
}
