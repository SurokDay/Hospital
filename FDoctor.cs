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
    public partial class FDoctor : Form
    {
        Form LogInForm;

        Data data = new Data();

        Patient CurrentPatient;

        Doctor doctor = new Doctor();

        public FDoctor(LogInForm logInForm, Doctor doctor)
        {
            InitializeComponent();

            LogInForm = logInForm;

            this.doctor = doctor;



            LBWelcome.Text = $"Welcome {doctor.Name} {doctor.Surname}";

            foreach (var item in data.GivePatient())
            {
                CBDoctor.Items.Add($"{item.Name} {item.Surname}");
            }
        }

      

        private void CBAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in data.GivePatient())
            {
                if (CBDoctor.Text == item.Name +" " +item.Surname)
                {
                    LBName.Text = item.Name;
                    LBEmail.Text = item.Email;
                    LBSurname.Text = item.Surname;

                    CurrentPatient = item;
                }
            }
        }

        private void BTNreturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNReceipt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created receipt");

            Receipt receipt = new Receipt(TBReceipt.Text, doctor);

            CurrentPatient.receipt = receipt;


           

            if (CheckB.Checked)
            {
                CurrentPatient.OutPatientTreatment = true;
            }
        }
    }
}