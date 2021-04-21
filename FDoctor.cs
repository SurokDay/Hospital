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

        Data data = new Data();

        string identify;
        public FDoctor()
        {
            InitializeComponent();

            foreach (var item in data.GivePatient())
            {
                CBDoctor.Items.Add(item.Name +" " +item.Surname);
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
                }
            }
        }
    }
}
