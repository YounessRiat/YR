using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie
{
    public partial class FrmFamille : Form
    {
        BindingSource bs = new BindingSource();
        public FrmFamille()
        {
            InitializeComponent();
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmFamille_Load(object sender, EventArgs e)
        {
            string req = "Select distinct DESIGNATION from Famille  ";
            DB.remplirGrille(dataGridView1, "Famille", bs);
            DB.remplirListe(cbChercher,req ,"Famille", "DESIGNATION", "DESIGNATION", bs);
        }

        private void tbnTerminer_Click(object sender, EventArgs e)
        {
        
        }

        private void btnMiseaj_Click(object sender, EventArgs e)
        {
          
        }

        private void mise_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
