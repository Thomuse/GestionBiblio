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
            //if (comboBox_Biblio.SelectedItem is Model.BiblioModel)
            //{
            //    Model.BiblioModel oNomBiblio = (Model.BiblioModel)comboBox_Biblio.SelectedItem;
            //}




        }
        private void button_Charger_Nom_Biblio_Click(object sender, EventArgs e)
        {
            //Model.BiblioModel oNomBiblio = (Model.BiblioModel)comboBox_Biblio.SelectedItem;

        }
    }
}
