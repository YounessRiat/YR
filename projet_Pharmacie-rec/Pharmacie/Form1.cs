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
    public partial class FrmAcceuil : Form
    {
        public FrmAcceuil()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "Pharmacie" && tbPass.Text == "123456")
            {
                menuStrip1.Visible = true;
                tbLogin.Visible = false;
                tbPass.Visible = false;
                btnLogin.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                pictureBox1.Visible = true;
            }
            else
                MessageBox.Show("The login or the password isn't correct !");
                
        }
        

        private void FrmAcceuil_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void laboratoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLaboratoire f = new FrmLaboratoire();
            f.ShowDialog();
        }

        private void familleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFamille f = new FrmFamille();
            f.ShowDialog();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmForm f = new FrmForm();
            f.ShowDialog();
        }

        private void entreéEtSortieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntree_Sortie f = new FrmEntree_Sortie();
            f.ShowDialog();
        }

        private void medicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicament f = new FrmMedicament();
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, KeyEventArgs e)
        {

        }
    }
}
