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
    interface IEmployer
    {
        bool CancelReservation(int reservationId);
        bool reserveClinic(int clinicId, int M_Id);
        OracleDataAdapter GetMedicalRecords(int employerId);
    }
}