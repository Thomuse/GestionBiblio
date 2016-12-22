using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
   public static class Database
    {
       private static SqlConnection _oDatabase = null;

        public static SqlConnection oDatabase
        {

            get
            {
                if (_oDatabase == null || _oDatabase.State != ConnectionState.Open)
                {
                    _oDatabase = new SqlConnection();
                    _oDatabase.ConnectionString = Connection.DefaultConnectionString;

                }
                return _oDatabase;
            }
        }
    
    }
}
