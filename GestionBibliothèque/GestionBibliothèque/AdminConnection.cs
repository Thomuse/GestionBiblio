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
    }
}
