using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Patient : IUser
    {
        public string Name { get; set; }
        public string Surname { get; set ; }
        public string Password { get; set; }
        public string Email { get; set; }

        public string Receipt { get; set; }
        public bool OutPatientTreatment { get; set; }



    }
}
