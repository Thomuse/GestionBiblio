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
                oCommand.CommandText = "Liste_EmpruntsAvecTarifs";
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

            finally
            {
                if (ConnectionString.oDatabase.State == ConnectionState.Open)
                {
                    ConnectionString.oDatabase.Close();
                }




            }
            return oDataSet;
        }
        public static void CreationExemplaire(ref string p_CodeExemplaire,ref int p_Emprunte,ref int p_Id_Biblio, ref int p_Id_Livre)
        {
            SqlCommand oInsert = new SqlCommand();

            try
            {
                ConnectionString.oDatabase.Open();
                oInsert.Connection = ConnectionString.oDatabase;
                oInsert.CommandType = CommandType.StoredProcedure;
                oInsert.CommandText = "Creation_Exemplaire";

                SqlParameter oInsParamCodeExemplaire = new SqlParameter("@Code_Exemp", p_CodeExemplaire);
                SqlParameter oInsParamEmprunte = new SqlParameter("@Emprunte", p_Emprunte);
                SqlParameter oInsParamIdBiblio = new SqlParameter("@Id_Biblio ", p_Id_Biblio);
                SqlParameter oInsParamIdLivre = new SqlParameter("@Id_Livre", p_Id_Livre);

                if (p_CodeExemplaire != "" && p_Id_Biblio != 0 && p_Id_Livre != 0)
                {

                    oInsert.Parameters.Add(oInsParamCodeExemplaire);
                    oInsert.Parameters.Add(oInsParamIdBiblio);
                    oInsert.Parameters.Add(oInsParamIdLivre);
                    oInsert.Parameters.Add(oInsParamEmprunte);
                }


                int RowsModified = oInsert.ExecuteNonQuery();
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
                {
                    ConnectionString.oDatabase.Close();
                }
            }

        }
        public static void RetourLivre(int p_IdExemp, int p_IdLecteur)
        {
            SqlCommand oCommand = new SqlCommand();

            try
            {
                ConnectionString.oDatabase.Open();
                oCommand.Connection = ConnectionString.oDatabase;
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.CommandText = "Retour_Livre";

                SqlParameter oParamIdExemp = new SqlParameter("@IdExem", p_IdExemp);
                SqlParameter oParamIdLecteur = new SqlParameter("@IdLecteur", p_IdLecteur);
             

                if (p_IdExemp != 0 && p_IdLecteur != 0)
                {
                    oCommand.Parameters.Add(oParamIdExemp);
                    oCommand.Parameters.Add(oParamIdLecteur);
              
                }
                int RowsModified = oCommand.ExecuteNonQuery();
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
                {
                    ConnectionString.oDatabase.Close();
                }
            }
        }
        public static DataSet RechercherLivre(string p_NomLivre)
        {
            var oDataSet = new DataSet();

            var oCommand = new SqlCommand();

            var oSqlAdapter = new SqlDataAdapter();

            try
            {
                ConnectionString.oDatabase.Open();
                oCommand.Connection = ConnectionString.oDatabase;
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.CommandText = "ChercherLivre";
                SqlParameter oParamNomLivre = new SqlParameter("@NomLivre", p_NomLivre);
                if (p_NomLivre != "")
                {
                    oCommand.Parameters.Add(oParamNomLivre);
                }
                oSqlAdapter.SelectCommand = oCommand;
                oSqlAdapter.Fill(oDataSet, "ListeLivre");
                int RowsModified = oCommand.ExecuteNonQuery();

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
                {
                    ConnectionString.oDatabase.Close();
                }




            }
            return oDataSet;
        }
    }
}
