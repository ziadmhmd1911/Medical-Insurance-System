using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIASystem.Models
{
    class Clinic
    {
        private int id;
        private string name;
        private string doctorName;
        private string phone;
        private int hospitalId;
        private string specialization;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public int HospitalId
        {
            get { return hospitalId; }
            set { hospitalId = value; }
        }

        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }
    }
}
