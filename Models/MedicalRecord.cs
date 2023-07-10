using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIASystem.Models
{
    class MedicalRecord
    {
        private int id;
        private int employerId;
        private int CompanyId;
        private int clinicId;
        private DateTime date;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int EmployerId
        {
            get { return employerId; }
            set { employerId = value; }
        }

        public int CompanyId1
        {
            get { return CompanyId; }
            set { CompanyId = value; }
        }

        public int ClinicId
        {
            get { return clinicId; }
            set { clinicId = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
