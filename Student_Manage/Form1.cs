using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Manage
{
    public partial class Form1 : Form
    {
        Helper obj = new Helper();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {


            if (obj.TextBoxvalidation(txtFname, "Please Enter First Name"))
            {
                if (obj.TextBoxvalidation(txtLname, "Please Enter Last Name"))
                {
                    string fullName = obj.GetFullname("Saran", "Sarma");
                    MessageBox.Show(fullName);
                }
            }


            /*if (String.IsNullOrEmpty(txtFname.Text))
            {
                MessageBox.Show("Please Enter the First Name!!!");
                txtFname.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtLname.Text))
            {
                MessageBox.Show("Please Enter the Last Name!!!");
                txtLname.Focus();
                return;
            }*/

        }


        private void btnClose_Click(object sender, EventArgs e)
        {

            //DialogResult dialogResult = MessageBox.Show("Are you sure to Close?", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            //if (dialogResult==DialogResult.Yes)
            //{
            Application.Exit();
            //}

            //this.Close();

        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           Helper.Formclose(e);

        }

       
    }
    }
