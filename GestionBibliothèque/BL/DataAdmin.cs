using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public static class DataAdmin
    {
        public static void ListEmprunts(ref DataSet oDataSet)
        {
           
                DataSet oData;
                oData = DAL.DataAdmin.ListEmprunts();
                oDataSet = oData;
        }

        public static void AjoutExemplaire(string p_CodeExemplaire, int p_Emprunte, int p_Id_Biblio, int p_Id_Livre)
        {
            
                string Code_Exemplaire = "";
                int Emprunte = 0;
                int Id_Biblio = 0;
                int Id_Livre = 0;
                Code_Exemplaire = p_CodeExemplaire;
                Id_Biblio = p_Id_Biblio;
                Id_Livre = p_Id_Livre;
                DAL.DataAdmin.CreationExemplaire(ref p_CodeExemplaire, ref Emprunte, ref p_Id_Biblio, ref p_Id_Livre);
            
            
        }
        public static void RetourExemplaire(int p_IdExemp, int p_IdLecteur)
        {
           
                int IdExemp = 0;
                int IdLecteur = 0;
                IdExemp = p_IdExemp;
                IdLecteur = p_IdLecteur;
                DAL.DataAdmin.RetourLivre(IdExemp, IdLecteur);
            
           
        }
        public static void ChercherLivre(ref string p_NomLivre,ref DataSet oData)
        {
            
                var oDataSet = new DataSet();

                string NomLivre = "";
                NomLivre = p_NomLivre;
                oDataSet = DAL.DataAdmin.RechercherLivre(NomLivre);
                oData = oDataSet;

        }

    }
}

