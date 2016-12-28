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
        public static void ChoixBiblio()
        {
            string NomBiblio = "";
            SqlCommand oSelect = new SqlCommand();


            try
            {
                ConnectionString.oDatabase.Open();

                oSelect.Connection = ConnectionString.oDatabase;
                oSelect.CommandType = CommandType.StoredProcedure;
                oSelect.CommandText = "List_Biblio";
                SqlDataReader oData = oSelect.ExecuteReader();

                while (oData.Read())
                {
                    // ReadSingleRow((IDataRecord)oData);
                    NomBiblio = oData.GetString(0);
                    //comboBox_Biblio.Items.Add(NomBiblio);
                   
                }

            }
            catch (SqlException exSQL)
            {
                string sMessage = "";
                switch (exSQL.Number)
                {
                    case 18456:
                        sMessage = "Mauvais user";
                        break;
                    case 4060:
                        sMessage = "Mauvaise DB";
                        break;
                    default:
                        sMessage = exSQL.Message + " -- " + exSQL.Number;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ConnectionString.oDatabase.State == ConnectionState.Open)

                    ConnectionString.oDatabase.Close();
            }

            



        }
    }
}

