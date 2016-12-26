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
                o_dataGridView.Columns["Nom"].ReadOnly = true;
                o_dataGridView.Columns["Titre"].ReadOnly = true;
                o_dataGridView.Columns["Code_Exemp"].ReadOnly = true;
                o_dataGridView.Columns["Nom_Biblio"].ReadOnly = true;
                o_dataGridView.Columns["Date_Emprunt"].ReadOnly = true;
                o_dataGridView.Columns["Date_Retour"].ReadOnly = true;
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

        private void button_Valider_Click(object sender, EventArgs e)
        //Ne fonctionne pas.. Problème de procédure..
        {
            try
            {
                int IdExemp = Convert.ToInt32(textBox_ID_Exemplaire.Text);
                int IdLecteur = Convert.ToInt32(textBox_ID_Lecteur.Text);
                BL.DataAdmin.RetourExemplaire(IdExemp, IdLecteur);
                textBox_ID_Exemplaire.Clear();
                textBox_ID_Lecteur.Clear();
                DateTime Date = DateTime.Now;
                DialogResult res = MessageBox.Show("Exemplaire à nouveau disponible", "Confirmation" + " " + Date, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
