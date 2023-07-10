using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ZIASystem.Controllers
{
    class DBReader
    {
        static private OracleDataReader reader;
        static private void Initiate(string commmandText)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Controllers.DBConnection.getConnection(); ;
            cmd.CommandText = commmandText;
            cmd.CommandType = System.Data.CommandType.Text;
            reader = cmd.ExecuteReader();
        }

        static public OracleDataReader GetReader(string cmt)
        {
            Initiate(cmt);
            return reader;
        }
    }
}
