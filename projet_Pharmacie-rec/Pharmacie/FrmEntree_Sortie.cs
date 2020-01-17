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
    public partial class FrmEntree_Sortie : Form
    {
        BindingSource bs = new BindingSource();
        public FrmEntree_Sortie()
        {
            InitializeComponent();
        }

        private void FrmEntree_Sortie_Load(object sender, EventArgs e)
        {
            string REQ = "select MARQUEMEDICAMENT, prix, es.QTE,es.DATE,es.EVENEMENT,DATEEXPIRATION from MEDICAMENT m inner join Etre e on m.ID_MEDICAMENT = e.ID_MEDICAMENTinner join ENTREE_SORTIE es on es.ID_ES = e.ID_ES       ";



            DB.remplirGrille(dataGridView1, REQ, "Medicament", bs);
            DB.remplirListe(cbChercher, "Medicament", "MARQUEMEDICAMENT", "ID_MEDICAMENT", bs);
        }
    }
}
