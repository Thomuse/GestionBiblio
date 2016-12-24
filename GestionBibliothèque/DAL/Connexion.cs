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
        public static void ChoixBiblio(List<Model.BiblioModel>lstBiblio)
        {
           
            SqlCommand oCommand = new SqlCommand();
            

            List<Model.BiblioModel> listeBiblio = new List<Model.BiblioModel>();

            try
            {
                ConnectionString.oDatabase.Open();
                oCommand.Connection = ConnectionString.oDatabase;
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.CommandText = "List_Biblio";
                SqlDataReader oData = oCommand.ExecuteReader();

                while (oData.Read())
                {
                    string Nom_Biblio = oData.ToString();

                }

            }
            catch (Exception ex)
            {
              
            }
            finally
            {
                if (ConnectionString.oDatabase.State == ConnectionState.Open)

                    ConnectionString.oDatabase.Close();
            }
        }



        }
    }

