using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Learn
{
    public partial class ALogin
    {
        String connectionstring = "Server=SARAN;Database=CSharpBatch;Trusted_Connection=True;";
        public Int32 CountAdmin(string username, string password)
        {
            Int32 adminCount = 0;
            try
            {
                System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionstring);
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select count(id) from Admin where username='" + username + "' and password='" + password + "'", con);
                adminCount = Convert.ToInt32(cmd.ExecuteScalar());


                cmd.Dispose();
                con.Close();
                return adminCount;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }
        public DataTable getHistory(String Username, String Password)        {            DataTable dt = new DataTable();            try            {                SqlConnection con = new SqlConnection(connectionstring);                ConnectionState state = con.State;                if (state != ConnectionState.Open)                {                    con.Open();                }                SqlCommand cmd = new SqlCommand($"Select [id],[user_id],[login_time],[logout_time] from [dbo].[Admin] where [username]='{Username}' and [password]='{Password}'", con);                SqlDataReader dr = cmd.ExecuteReader();                if (dr.HasRows)                {                    dt.Load(dr);                }                return dt;            }            catch (Exception ex)            {                MessageBox.Show(ex.Message.ToString());                return null;            }        }

    }
}
