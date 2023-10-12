using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Manage
{
    class Helper
    {
        public Boolean TextBoxvalidation(TextBox txt, String msg)
        {
            if (String.IsNullOrEmpty(txt.Text))
            {
                MessageBox.Show(msg);
                txt.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public string GetFullname(String fna, String lna)
        {
            String fname = fna;
            String lname = lna;

            String fullName = fname + lname;
            return fullName;
        }
        public static void Formclose(FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to Close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
