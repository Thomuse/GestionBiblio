using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DataAdmin
    {
        public static DataSet ListEmprunts()
        {
            var oDataSet = new DataSet();

            var oCommand = new SqlCommand();

            var oSqlAdapter = new SqlDataAdapter();

            try
            {
                ConnectionString.oDatabase.Open();
                oCommand.Connection = ConnectionString.oDatabase;
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.CommandText = "Liste_Emprunts";
                oSqlAdapter.SelectCommand = oCommand;
                oSqlAdapter.Fill(oDataSet, "Emprunts");
                return oDataSet;
            }
                
            catch (SqlException exSQL)
            {
                int IdError = 999;
                switch (exSQL.Number)
                {
                    case 4060:
                        IdError = 3;
                        break;
                    case 18456:
                        IdError = 4;
                        break;
                }
            }
            
                finally{
                if (ConnectionString.oDatabase.State == ConnectionState.Open){
                    ConnectionString.oDatabase.Close();
                }
                
              


           }
            return oDataSet;
            }

      
    }
    }

