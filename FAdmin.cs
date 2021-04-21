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

            foreach (var item in data.GiveDoctors())
            {
                CBDoctor.Items.Add(item.Name + " " + item.Surname);
            }

            foreach (var item in data.GivePatient())
            {
                CBPatient.Items.Add(item.Name + " " + item.Surname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in data.GiveDoctors())
            {
                if (CBDoctor.Text == item.Name + " " + item.Surname)
                {

                }
            }
        }
    }
}
