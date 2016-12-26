using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Connexion
    {
        public static DataSet ChoixBiblio()
        {
           
            SqlCommand oCommand = new SqlCommand();
            var oData = new DataSet();
            var oSqlAdapter = new SqlDataAdapter();

            try
            {
                ConnectionString.oDatabase.Open();
                oCommand.Connection = ConnectionString.oDatabase;
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.CommandText = "List_Biblio";
                oSqlAdapter.SelectCommand = oCommand;
                oSqlAdapter.Fill(oData, "ListeBiblio");

            }
            catch (SqlException SqlNumber)
            {
                int IdError = 999;
                string sMessage;
                switch (SqlNumber.Number)
                {
                    case 201:
                        IdError = 1;
                        break;
                    case 2627:
                        IdError = 2;
                        break;
                    default:
                        sMessage = SqlNumber.Message + " -- " + SqlNumber.Number;
                        break;
                }
            
              
            }
            finally
            {
                if (ConnectionString.oDatabase.State == ConnectionState.Open)

                    ConnectionString.oDatabase.Close();
            }
            return oData;
        }// ne fonctionne pas



        }
    }

