using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Data
    {
        public static List<Doctor> ListDoctors = new List<Doctor>()
        {
            new Doctor() {Name = "DOleg", Surname = "Kosenko", Password="1" ,Email = "formonchuk@gmail.com"},
            new Doctor() {Name = "DMax", Surname = "Sherbia", Password="1" ,Email = "sherbia@gmail.com"}
        };
        public static List<Patient> ListPatient = new List<Patient>()
        { 
            new Patient() {Name = "PAlex", Surname = "Makedonskii",Password="1" , Email = "Alex@gmail.com"},
            new Patient() {Name = "POlena", Surname = "Pchilka",Password="1" , Email = "Olena@gmail.com"}
        };
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
        public void DeleteDoctors(Doctor doctor)
        {
            ListDoctors.Remove(doctor);
        }
        public void DeletePatient(Patient patient)
        {
            ListPatient.Remove(patient);
        }
    }
}
