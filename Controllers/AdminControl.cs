using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using ZIASystem.Interfaces;
using ZIASystem.Models;

namespace ZIASystem.Controllers
{
    class AdminController : IAdmin
    {
        public static int adminId;
        public bool AddCompany(Company company)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Controllers.DBConnection.getConnection();
            cmd.CommandText = "insert into COMPANIES values(:C_ID,:C_NAME,:C_ADDRESS)";
            cmd.Parameters.Add("C_ID", company.Id);
            cmd.Parameters.Add("C_NAME", company.Name);
            cmd.Parameters.Add("C_ADDRESS", company.Address);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddHospital(Hospital hospital)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Controllers.DBConnection.getConnection();
            cmd.CommandText = "insert into HOSPITALS values(:H_ID,:H_NAME,:H_ADDRESS,:H_PHONE)";
            cmd.Parameters.Add("H_ID", hospital.Id);
            cmd.Parameters.Add("H_NAME", hospital.Name);
            cmd.Parameters.Add("H_ADDRESS", hospital.Address);
            cmd.Parameters.Add("H_PHONE", hospital.Phone);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public OracleDataAdapter getCompanies()
        {
            string cmdstr = "select * from COMPANIES";
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmdstr, Controllers.DBConnection.getConnection());
            return dataAdapter;
        }

        public OracleDataAdapter getDayMedicalRecods(DateTime date)
        {
            string reqDate = date.ToString("dd-MMM-yy");
            string cmdstr = "select * from MEDICAL_HISTORY where M_DATE = '" + reqDate + "'";
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmdstr, Controllers.DBConnection.getConnection());
            return dataAdapter;
        }

        public OracleDataAdapter getHospitals()
        {
            string cmdstr = "select * from HOSPITALS";
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmdstr, Controllers.DBConnection.getConnection());
            return dataAdapter;
        }

        public bool RemoveCompany(int companyId)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Controllers.DBConnection.getConnection();
            cmd.CommandText = "Delete from COMPANIES where C_ID =:C_ID";
            cmd.Parameters.Add("C_ID", companyId);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                return true;
            }
            return false;
        }

        public bool RemoveHospital(int hospitalId)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Controllers.DBConnection.getConnection();
            cmd.CommandText = "Delete from HOSPITALS where H_ID =:H_ID";
            cmd.Parameters.Add("H_ID", hospitalId);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                return true;
            }
            return false;
        }
    }
}
