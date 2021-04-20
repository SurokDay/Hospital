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
        public FDoctor()
        {
            InitializeComponent();

            LBList.Text = "";

            Data data = new Data();

            foreach (var item in data.GivePatient())
            {
                LBList.Text += item.Name + " " + item.Surname+'\n';

            }

            RadioButton radioButton = new RadioButton()
            {
                Text = "",
                Location = new Point(10, 10),
                TabIndex = 10
            };



            for (int i = 0; i < data.GivePatient().Count; i++)
            {
                

            }






        }
    }
}
