using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class DataAdmin
    {
        public static void ListEmprunts(ref DataSet oDataSet)
        {
            try
            {
                DataSet oData;
                oData = DAL.DataAdmin.ListEmprunts();
                oDataSet = oData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

       

