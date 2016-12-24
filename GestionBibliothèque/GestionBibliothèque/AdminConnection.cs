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
    public partial class AdminConnection : Form
    {
        public AdminConnection()
        {
            InitializeComponent();
        }

        private void button_Liste_Emprunts_Click(object sender, EventArgs e)
        {
            try
            {
                var oDataSet = new DataSet();
                BL.DataAdmin.ListEmprunts(ref oDataSet);
                o_dataGridView.DataSource = oDataSet.Tables["Emprunts"].DefaultView;
            }

            catch (Erreur.BusinessError ex)
            {
                MessageBox.Show(ex.Message);
            }
                
            
        }
        
        private void o_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Creation_Exemplaire_Click(object sender, EventArgs e)
        {
            try
            {
                string Code_Exemplaire = textBox_Code_Exemplaire.Text;
                int Emprunte = 0;
                int Id_Biblio = Convert.ToInt32(textBox_Id_Biblio.Text);
                int Id_Livre = Convert.ToInt32(textBox_Id_Livre.Text);
                BL.DataAdmin.AjoutExemplaire(Code_Exemplaire,Emprunte, Id_Biblio, Id_Livre);
                textBox_Code_Exemplaire.Clear();
                textBox_Id_Biblio.Clear();
                textBox_Id_Livre.Clear();
                DateTime Date = DateTime.Now;
               DialogResult res = MessageBox.Show("Exemplaire créé avec succcès", "Confirmation" + " " + Date, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
