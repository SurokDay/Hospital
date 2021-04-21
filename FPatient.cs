using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FPatient : Form
    {
        Patient Patient = new Patient();
        public FPatient(LogInForm logInForm, Patient patient)
        {
            InitializeComponent();

            Patient = patient;

            Lbname.Text = patient.Name;
            LBsurname.Text = patient.Surname;
            LBemail.Text = patient.Email;

            if (patient.receipt.info == "")
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

        private void MakeAppointment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulation! You are in que to the doctor :D");
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                string path = FolderBrowser.SelectedPath;

                File.WriteAllText($@"{path}\receipt.txt", $"Doctor: {Patient.receipt.doctor.Name} {Patient.receipt.doctor.Surname} \nInfo: \n{Patient.receipt.info}" );
                MessageBox.Show("Receipt.txt was created!");
            }
        }

       
    }
}
