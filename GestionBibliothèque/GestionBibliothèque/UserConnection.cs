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
    public partial class UserConnection : Form
    {
        public UserConnection()
        {
            InitializeComponent();
        }

        private void textBox_Id_Lecteur_TextChanged(object sender, EventArgs e)
        {

                
        }

        private void button_ListeEmprunts_By_ID_Click(object sender, EventArgs e)
        {
             BibliothequeEntities1 oDb = new BibliothequeEntities1();
            List<Liste_EmpruntsByID_Result> ListEmprunts =oDb.Liste_EmpruntsByID(Convert.ToInt32(textBox_Id_Lecteur.Text)).ToList();
                
                    o_DatagridView.DataSource = ListEmprunts.ToList();
                    }

        private void button_emprunter_Click(object sender, EventArgs e)
        {
            BibliothequeEntities1 oDb = new BibliothequeEntities1();
            oDb.EmpruntLivre(Convert.ToInt32(textBox_ID_Lecteur_Pret.Text),Convert.ToInt32(textBox_ID_Exemplaire.Text));
        }

        private void button_Reserver_Click(object sender, EventArgs e)
        {
            BibliothequeEntities1 oDb = new BibliothequeEntities1();
            oDb.ReserverLivre(Convert.ToInt32(textBox_ID_Lecteur_Reservation.Text), Convert.ToInt32(textBox_ID_Livre_Reservation.Text));
        }


      
            }
        }
    

