using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class LogInForm : Form
    {
        Form main;

        Doctor doctor;

        public LogInForm(Form form, Doctor doctor)
        {
            this.doctor = doctor;
            main = form;
            InitializeComponent();
        }

        private void BTNreturn_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            if (TBlogin!.Text!=""&&TBpass.Text!="")
            {
                
            }
            else
            {
                MessageBox.Show("Enter all the fields!");
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
