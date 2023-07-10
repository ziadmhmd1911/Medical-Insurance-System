using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZIASystem.Models;

namespace ZIASystem.Controllers
{
    class ClinicConroller : Interfaces.IClinic
    {
        public OracleDataAdapter GetClinics()
        {
            string cmdstr = "select * from CLINICS";
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmdstr, Controllers.DBConnection.getConnection());
            return dataAdapter;
        }
    }
}