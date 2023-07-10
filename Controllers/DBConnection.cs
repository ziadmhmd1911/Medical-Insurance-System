using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ZIASystem.Controllers
{
    static class DBConnection
    {
        static private OracleConnection con;

        static private void Intiate()
        {
            con = new OracleConnection("DATA SOURCE=localhost:1521/orcl;PERSIST SECURITY INFO=True;USER ID=ZIA; PASSWORD=zia;");
            con.Open();
        }

        static public OracleConnection getConnection()
        {
            if (con == null)
                Intiate();

            return con;
        }

        static public string getConnectionString()
        {
            return "DATA SOURCE=localhost:1521/orcl;PERSIST SECURITY INFO=True;USER ID=ZIA; PASSWORD=zia;";
        }
    }
}
