using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Receipt
    {
        public string info { get; set; }

        public Doctor doctor;

        public Receipt(string info, Doctor doctor)
        {
            this.info = info;
            this.doctor = doctor;
        }

    }
}
