using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp;
namespace Student_Manage
{
    public partial class Form2 : Form
    {
       
       
        public Form2(
            )
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Are you sure to Close?", "Confirm", MessageBoxButtons.YesNo);

            //if (dialogResult == DialogResult.Yes)
            //{
            this.Close();
            //}
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Are you sure to Close?", "Confirm", MessageBoxButtons.YesNo);

            //if (dialogResult == DialogResult.Yes)
            //{
                Application.Exit();
            //}
            
        }

        private void btnCallFunction_Click(object sender, EventArgs e)
        {
            Helper obj = new Helper();
            String fullname = obj.GetFullname("Saran", "Sarma");
            MessageBox.Show(fullname);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Helper.Formclose(e);
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
        }
    }
}
