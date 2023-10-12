using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Learn
{
    class Formclose
    {
        public static void FormClose(FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to Close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

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

        internal class dialogResult
    {
    }
}
}
