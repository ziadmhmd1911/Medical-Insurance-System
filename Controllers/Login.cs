using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ZIASystem.Controllers
{
    class Login
    {
        private string ssn;
        private string password;

        public Login(string ssn, string password)
        {
            this.ssn = ssn;
            this.password = password;
        }

        public int check(string ssn)
        {
            string[] x = ssn.Split('@');
            if (x.Length < 2)
                return -1;
            if (x[1].Equals("e"))
            {
                this.ssn = x[0];
                return 1;
            }
            else if (x[1].Equals("a"))
            {
                this.ssn = x[0];
                return 0;
            }
            else
                return -1;
        }

        public int loging()
        {
            OracleDataReader reader;
            int che = check(ssn);

            if (che == 0)
            {
                reader = Controllers.DBReader.GetReader("select * from ADMINS");
                while (reader.Read())
                {
                    if (reader[2].ToString().Equals(ssn) && reader[3].ToString().Equals(password))
                    {
                        Controllers.AdminController.adminId = Convert.ToInt32(reader[0].ToString());
                        return 0;
                    }
                }
                MessageBox.Show("wrong ssn or password");
            }
            else if (che == 1)
            {
                reader = Controllers.DBReader.GetReader("select * from EMPLOYERS");
                while (reader.Read())
                {
                    if (reader[4].ToString().Equals(ssn) && reader[5].ToString().Equals(password))
                    {
                        Controllers.EmployerConroller.employerId = Convert.ToInt32(reader[0].ToString());
                        Controllers.EmployerConroller.companyId = Convert.ToInt32(reader[3].ToString());
                        return 1;
                    }
                }
                MessageBox.Show("wrong ssn or password");
            }
            else
            {
                MessageBox.Show("wrong format");
                return -1;
            }
            return -1;
        }
    }
}