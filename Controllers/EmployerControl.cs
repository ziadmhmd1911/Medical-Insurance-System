using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZIASystem.Interfaces;


namespace ZIASystem.Controllers
{
    class EmployerConroller : IEmployer
    {
        public static int employerId;
        public static int companyId;
        public bool CancelReservation(int reservationId)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Controllers.DBConnection.getConnection();
            cmd.CommandText = "Delete from MEDICAL_HISTORY where M_ID =:C_ID";
            cmd.Parameters.Add("C_ID", reservationId);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                return true;
            }
            return false;
        }

        public OracleDataAdapter GetMedicalRecords(int employerId)
        {
            string cmdstr = "select * from MEDICAL_HISTORY where EMP_ID =  " + employerId.ToString();
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmdstr, Controllers.DBConnection.getConnection());
            return dataAdapter;


        }

        public bool reserveClinic(int clinicId, int M_Id)
        {
            OracleCommand cmmd = new OracleCommand();
            cmmd.Connection = Controllers.DBConnection.getConnection();
            cmmd.CommandText = "MaxId";
            cmmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmmd.Parameters.Add("M_Id", OracleDbType.Int32,System.Data.ParameterDirection.Output);
            cmmd.ExecuteNonQuery();
            M_Id = Convert.ToInt32(cmmd.Parameters["M_Id"].Value.ToString()) + 1;


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Controllers.DBConnection.getConnection();
            cmd.CommandType = System.Data.CommandType.Text;
            string datenow = DateTime.Now.ToString("dd-MMM-yy");
            cmd.CommandText = "insert into MEDICAL_HISTORY values (:M_ID ,:EMP_ID,:COMP_ID,:CLINIC_ID,:M_DATE) ";
            cmd.Parameters.Add("M_ID", M_Id);
            cmd.Parameters.Add("EMP_ID", employerId);
            cmd.Parameters.Add("COMP_ID", companyId);
            cmd.Parameters.Add("CLINIC_ID", clinicId);
            cmd.Parameters.Add("M_DATE", datenow);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                return true;
            }
            return false;
        }

        public OracleDataAdapter GetClinics()
        {
            ClinicConroller clinicConroller = new ClinicConroller();
            return clinicConroller.GetClinics();
        }
    }
}