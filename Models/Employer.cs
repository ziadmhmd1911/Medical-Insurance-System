using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIASystem.Models
{
    class Employer
    {
        private int id;
        private string name;
        private DateTime birthday;
        private int companyId;
        private string ssn;
        private string password;
        private string phone;

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

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }

        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
