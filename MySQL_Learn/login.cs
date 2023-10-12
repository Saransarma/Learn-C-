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
    public class login
    {
        String connectionstring = "Server=SARAN;Database=CSharpBatch;Trusted_Connection=True;";

        public Int32 CountUser(string username, string password)
        {
            Int32 count = 0;
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                ConnectionState state = con.State;
                if (state != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select count(id) from users where username='"+username+"' and password='"+password+"'", con);
                count = Convert.ToInt32(cmd.ExecuteScalar());

                
                cmd.Dispose();
                con.Close();
                return count;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }

            
           }
       
    }
}
