using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Data
    {
        public static List<Doctor> ListDoctors = new List<Doctor>() ;
        public static List<Patient> ListPatient = new List<Patient>()
        { 
            new Patient() {Name = "Alex", Surname = "Makedonskii"},
            new Patient() {Name = "Olena", Surname = "Pchilka"}
        }
        ;
        public static List<Admin> ListAdmin = new List<Admin>();

        public Data()
        {
            
        }
        public Data(Doctor doctor)
        {
            ListDoctors.Add(doctor);
        }

        public Data(Patient patient)
        {
            ListPatient.Add(patient);
        }

        public Data(Admin admin)
        {
            ListAdmin.Add(admin);
        }

        public List<Doctor> GiveDoctors()
        {
            return ListDoctors;
        }
        public List<Patient> GivePatient()
        {
            return ListPatient;
        }
        public List<Admin> GiveAdmins()
        {
            return ListAdmin;
        }
    }
}
