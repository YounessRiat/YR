using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Pharmacie
{
    public partial class FrmLaboratoire : Form
        
    {
        BindingSource bs = new BindingSource();
         
   


        public FrmLaboratoire()
        {
            InitializeComponent();
        }

        private void FrmLaboratoire_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Voulez vraiment vraiment supprimer cette Laboratoire !!", "supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            { bs.RemoveCurrent();
            }
            else
            {
                bs.CancelEdit();
            }
           
        }
            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message =
                "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //DB.ouvrirConnection();
            //string sql = "select *from Laboratoire ";
            //SqlCommand com = new SqlCommand(sql, cn);
            //SqlDataReader dr = com.ExecuteReader();
            //tbNumLabo.Clear();
            //tbNomLabo.Clear();

            //while (dr.Read())
            //{
            //    tbNumLabo.Text = dr["ID_Labo"].ToString();
            //    tbNomLabo.Text = dr["Libele"].ToString();

            //}
        }


    }
    }

