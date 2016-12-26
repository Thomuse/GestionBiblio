using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public static class DataLecteur
    {
        public static DataSet ListeEmprunts(int p_Id)
        {
            BibliothequeEntities oDb = new BibliothequeEntities();
            
                var oData = new DataSet();
                var oSqlAdapter = new SqlDataAdapter();
                var oCommand = new SqlCommand();
                try
                {
                    List<Liste_EmpruntsByID_Result> ListEmprunts = oDb.Liste_EmpruntsByID(p_Id).ToList();
                    oSqlAdapter.SelectCommand = oCommand;
                    oSqlAdapter.Fill(oData);
                    //je résouds le problème ce soir ou demain, je sais que Fievez fait ça dans une de ses vidéos
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

                finally
                {
                    if (ConnectionString.oDatabase.State == ConnectionState.Open)

                        ConnectionString.oDatabase.Close();
                }
                return oData;
            }
        }
    }

