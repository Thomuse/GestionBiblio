using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ConnectionString

    {
        private static SqlConnection _oDatabase = null;

        public static SqlConnection oDatabase
        {

            get
            {
                if (_oDatabase == null || _oDatabase.State != ConnectionState.Open)
                {
                    _oDatabase = new SqlConnection();
                    _oDatabase.ConnectionString = Globals._DefaultConnectionString;

                }
                return _oDatabase;
            }
        }
    }
}
