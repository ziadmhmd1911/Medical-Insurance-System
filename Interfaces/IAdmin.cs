using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using ZIASystem.Models;

namespace ZIASystem.Interfaces
{
    interface IAdmin
    {
        OracleDataAdapter getDayMedicalRecods(DateTime date);
        bool AddCompany(Company company);
        bool RemoveCompany(int companyId);
        bool AddHospital(Hospital hospital);
        bool RemoveHospital(int hospitalId);

        OracleDataAdapter getHospitals();
        OracleDataAdapter getCompanies();

    }
}
