using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class Connexion
    {
        public static void ChoixExemplaire()
        {
            try
            {
                List<Model.BiblioModel> lstNomBiblio = new List<Model.BiblioModel>();
                DAL.Connexion.ChoixBiblio(lstNomBiblio);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}   
