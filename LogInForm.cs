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

            Status.SelectedItem = "00";

        }

        private void BTNreturn_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            Data data = new Data();


            if (TBlogin!.Text == "" && TBpass.Text == "")
            {
                MessageBox.Show("Enter the fields!");
            }

            else if (Status.Text == "Doctor")
            {
                check(data.GiveDoctors());
            }
            else if (Status.Text == "Patient")
            {
                check(data.GivePatient());
            }
            else if (Status.Text == "Admin")
            {
                check(data.GiveAdmins());
            }
        }

        private void check(List<Doctor> doctors)
        {
            foreach (var item in doctors)
            {
                if (item.Name == TBlogin.Text && item.Password == TBpass.Text)
                {
                    Quit(doctors);
                }
            }
        }
        private void check(List<Patient> patients)
        {
            foreach (var item in patients)
            {
                if (item.Name == TBlogin.Text && item.Password == TBpass.Text)
                {
                    Quit(patients);
                }
            }
        }

        
        private void check(List<Admin> admins)
        {
            foreach (var item in admins)
            {
                if (item.Name == TBlogin.Text && item.Password == TBpass.Text)
                {
                    Quit(admins);
                }
            }
        }

       

        private void Quit(List<Doctor> doctors)
        {
            this.Close();

            FDoctor fDoctor = new FDoctor();
            fDoctor.Show();
        }
        private void Quit(List<Patient> patients)
        {
            this.Close();

            FPatient fPatient = new FPatient();
            fPatient.Show();
        }
        private void Quit(List<Admin> admins)
        {
            this.Close();

            FAdmin fAdmin = new FAdmin();
            fAdmin.Show();
        }

    }
}
