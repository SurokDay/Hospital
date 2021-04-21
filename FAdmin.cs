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
    public partial class FAdmin : Form
    {


        Data data = new Data();
        public FAdmin()
        {
            InitializeComponent();

            InitializeComboBox();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in data.GiveDoctors().ToList())
            {
                if (CBDoctor.Text == item.Name + " " + item.Surname)
                {
                    MessageBox.Show($"{item.Name + " " + item.Surname} was deleted!");
                    data.DeleteDoctors(item);
                    
                }
            }

            foreach (var item in data.GivePatient().ToList())
            {
                if (CBPatient.Text == item.Name + " " + item.Surname)
                {
                    MessageBox.Show($"{item.Name + " " + item.Surname} was deleted!");
                    data.DeletePatient(item);

                }
            }
            InitializeComboBox();

        }

        private void InitializeComboBox()
        {
            CBDoctor.Items.Clear();
            CBPatient.Items.Clear();
            foreach (var item in data.GiveDoctors())
            {
                CBDoctor.Items.Add(item.Name + " " + item.Surname);
            }

            foreach (var item in data.GivePatient())
            {
                CBPatient.Items.Add(item.Name + " " + item.Surname);
            }
        }


        private void BTNreturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckBoxDoctor.Checked || CheckBoxPatient.Checked)
            {
                Main main = new Main(true);
                
                main.Show();
                this.Close();
            }
        }
    }
}
