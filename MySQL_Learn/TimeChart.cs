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
    public partial class TimeChart : Form
    {
        public static String connectionstring = "Server=SARAN;Database=CSharpBatch;Trusted_Connection=True;";
        public static int userid = 0;
        public static String Login_time = null;
        public static String Logout_time = null;
        //private string id;

        public TimeChart()
        {
            InitializeComponent();
        }

        private void dataGridTime_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void TimeChart_Load(object sender, EventArgs e)
        {

        }

        public static void setTime()
        {
            Login_time = DateTime.Now.ToString();
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into TimeChart1(Login_time)values('"+ Login_time + "')", con);
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
        public static void setTime1()
        {
            Logout_time = DateTime.Now.ToString();
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into TimeChart1(Logout_time)values('" + Logout_time + "')", con);
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
       

        private void btnTime_Click(object sender, EventArgs e)
        {
            GetAll(dataGridTime);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            using (con)
            {
                SqlCommand cmd = new SqlCommand("select id,username from Admin", con);
                using (cmd)
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridTime.DataSource = dt;
                    con.Close();
                }

            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            using (con)
            {
                SqlCommand cmd = new SqlCommand("select id,username from users", con);
                using (cmd)
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridTime.DataSource = dt;
                    con.Close();
                }

            }
        }
        public static void GetAll(DataGridView dgv)        {            try            {                SqlConnection con = new SqlConnection(connectionstring);                using (con)                {                    SqlCommand cmd = new SqlCommand("select*from TimeChart1", con);                    using (cmd)                    {                        ConnectionState state = con.State;                        if (state != ConnectionState.Open)                        {                            con.Open();                        }                        DataTable dt = new DataTable();                        dt.Load(cmd.ExecuteReader());                        dgv.DataSource = dt;                        con.Close();                    }                }            }            catch (Exception ex)            {                MessageBox.Show(ex.Message.ToString());                throw;            }


        }

        //private void dataGridTime_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    SqlConnection con = new SqlConnection(connectionstring);
        //    using (con)
        //    {
        //        SqlCommand cmd = new SqlCommand("select userid,Login_Time,Logout_Time from Timechart1", con);
        //        using (cmd)
        //        {
        //            con.Open();
        //            DataTable dt = new DataTable();
        //            dt.Load(cmd.ExecuteReader());
        //            dataGridTime.DataSource = dt;
        //            con.Close();
        //        }

        //    }
        //    this.userid = dataGridTime.SelectedRows[1].Cells["userid"].Value.ToString();


        //}
    }
}
