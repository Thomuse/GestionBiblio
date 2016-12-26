using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            try
            {
                var oDataSet = new DataSet();
                int ID = Convert.ToInt32(textBox_Id_Lecteur.Text);
                BL.DataLecteur.ListeEmprunts(ref oDataSet, ref ID);
                textBox_Id_Lecteur.Clear();
                o_DatagridView.DataSource = oDataSet.Tables[0].DefaultView;
            }
            catch (Erreur.BusinessError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
