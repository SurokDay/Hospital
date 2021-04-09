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
        public Main()
        {
            InitializeComponent();
        }

        List<Doctor> DoctorsList= new List<Doctor>();
        


        private void SignIn_Click(object sender, EventArgs e)
        {
            if (Status.Text == "" && Login.Text =="" && Password.Text=="")
            {
                MessageBox.Show("Enter all the fields!");
            }
            else if (Status.Text == "Doctor" && Status.Text != "" && Login.Text != "" && Password.Text != "")
            {
                Doctor doctor = new Doctor();

                doctor.Name = Login.Text;
                doctor.Password = Password.Text;


                DoctorsList.Add(doctor);
            }
        }

        private void eye_Click(object sender, EventArgs e)
        {
            if (Password.PasswordChar=='*')
            {
                Password.PasswordChar = '\0';
            }
            else if(Password.PasswordChar == '\0')
            {
                Password.PasswordChar = '*';
            }
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            

           /* LogInForm logInForm = new LogInForm();
            logInForm.Show();*/
            


        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==(char)Keys.Q)
            {
                this.Close();
            }
        } // Q
    }
}
