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
    public partial class FPatient : Form
    {
        public FPatient(LogInForm logInForm, Patient patient)
        {
            InitializeComponent();

            Lbname.Text = patient.Name;
            LBsurname.Text = patient.Surname;
            LBemail.Text = patient.Email;

            if (patient.Receipt == "")
            {
                LBReceipt.Text = "You haven't receipt";
            }
            else
            {
                LBReceipt.Text = "You have receipt";
            }

        }

        private void BTNreturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляю ! Вы смогли встать в очередь к врачу!!!");
        }

        
    }
}
