using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZIASystem.Models;

namespace ZIASystem.Interfaces
{
    interface IClinic
    {
        Oracle.DataAccess.Client.OracleDataAdapter GetClinics();
    }
}
