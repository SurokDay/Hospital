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
    public partial class Main : Form
    {
        public bool Return = false;

        public Main()
        {
            InitializeComponent();
        }

        public Main(bool v)
        {
            InitializeComponent();
            Return = true;
        }


        private void SignIn_Click(object sender, EventArgs e) //create example of man and open register form
        {
            if (Status.Text == "" && Login.Text == "" && Password.Text == "")
            {
                MessageBox.Show("Enter all the fields!");
            }

            else if (Status.Text == "Doctor" && Status.Text != "" && Login.Text != "" && Password.Text != "")
            {
                Doctor doctor = new Doctor();

                doctor.Name = Login.Text;
                doctor.Password = Password.Text;
                doctor.Email = Email.Text;
                doctor.Surname = Surname.Text;

                Data data = new Data(doctor);

                Exit();
            }
            else if (Status.Text == "Patient" && Status.Text != "" && Login.Text != "" && Password.Text != "")
            {
                Patient patient = new Patient();

                patient.Name = Login.Text;
                patient.Password = Password.Text;
                patient.Email = Email.Text;
                patient.Surname = Surname.Text;

                Data data = new Data(patient);

                Exit();
            }
            else if (Status.Text == "Admin" && Status.Text != "" && Login.Text != "" && Password.Text != "")
            {
                Admin admin = new Admin();

                admin.Name = Login.Text;
                admin.Password = Password.Text;
                admin.Email = Email.Text;
                admin.Surname = Surname.Text;

                Data data = new Data(admin);

                Exit();

            }

            

        }

        private void Exit()
        {
            LogInForm logInForm = new LogInForm(this);

            if (Return)
            {
                FAdmin fAdmin = new FAdmin();
                Return = false;
                fAdmin.Show();
                this.Close();
            }
            else
            {
                logInForm.Show();

            }
        }

        private void eye_Click(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '*')
            {
                Password.PasswordChar = '\0';
            }
            else if (Password.PasswordChar == '\0')
            {
                Password.PasswordChar = '*';
            }
        }



        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Q)
            {
                this.Close();
            }
        }
    }
}
