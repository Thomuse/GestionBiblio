
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibliothèque
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();

            //SqlCommand oSelect = new SqlCommand();



            //try
            //{
            //    ConnectionString.oDatabase.Open();

            //    oSelect.Connection = ConnectionString.oDatabase;
            //    oSelect.CommandType = CommandType.StoredProcedure;
            //    oSelect.CommandText = "List_Biblio";
            //    SqlDataReader oData = oSelect.ExecuteReader();

            //    while (oData.Read())
            //    {
            //        string NomBiblio = oData.GetString(0);
            //        comboBox_Biblio.Items.Add(NomBiblio);
            //    }


            //}
            //catch (SqlException exSQL)
            //{
            //    string sMessage = "";
            //    switch (exSQL.Number)
            //    {
            //        case 18456:
            //            sMessage = "Mauvais user";
            //            break;
            //        case 4060:
            //            sMessage = "Mauvaise DB";
            //            break;
            //        default:
            //            sMessage = exSQL.Message + " -- " + exSQL.Number;
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    if (ConnectionString.oDatabase.State == ConnectionState.Open)

            //        ConnectionString.oDatabase.Close();
            //}
            
            

        }

        private void button_TestAdmin_Click(object sender, EventArgs e)
        {
            AdminConnection ofrm = new AdminConnection();
            ofrm.ShowDialog();
        }

        private void button_Test_User_Click(object sender, EventArgs e)
        {
            UserConnection ofrm = new UserConnection();
            ofrm.ShowDialog();
        }

        private void comboBox_Biblio_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
        

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "admin" && textBox_Password.Text == "admin")
            {
                AdminConnection ofrm = new AdminConnection();
                ofrm.ShowDialog();
            }
            else if (textBox_Login.Text == "user" && textBox_Password.Text == "user")
            {
                UserConnection ofrm = new UserConnection();
                ofrm.ShowDialog();

            }
            textBox_Login.Clear();
            textBox_Password.Clear();
        }

       
    }
}
