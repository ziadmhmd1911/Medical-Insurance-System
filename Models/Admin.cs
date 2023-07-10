using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIASystem.Models
{
    class Admin
    {
        private int id;
        private string name;
        private string SSn;
        private string password;
        private DateTime birthdate;


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

        public string SSN
        {
            get { return SSn; }
            set { SSn = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
    }
}
