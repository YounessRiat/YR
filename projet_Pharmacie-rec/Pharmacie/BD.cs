using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
namespace Pharmacie
{


   public static class DB
    {

        static SqlConnection cn = new SqlConnection();
        static DataSet ds = new DataSet();


        static public void ouvrirConnection()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cs1"].ToString();

                cn.Open();
            }
        }

        static public void fermerConnection()
        {

            cn.Close();
        }


        static public void remplirListe(ListControl l, string t, string dm, string vm, BindingSource bs)
        {
            ouvrirConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, cn);

            if (!ds.Tables.Contains(t))
                da.Fill(ds, t);
            da = null;


            bs.DataSource = ds;
            bs.DataMember = t;

            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;
            fermerConnection();


        }


        static public BindingSource getTable(string t)
        {

            BindingSource bs = new BindingSource();
            ouvrirConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, cn);

            if (!ds.Tables.Contains(t))
                da.Fill(ds, t);
            da = null;


            bs.DataSource = ds;
            bs.DataMember = t;

            fermerConnection();
            return bs;

        }

        static public BindingSource getTable(string sql, string t)
        {

            BindingSource bs = new BindingSource();
            ouvrirConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);

            if (!ds.Tables.Contains(t))
                da.Fill(ds, t);
            da = null;


            bs.DataSource = ds;
            bs.DataMember = t;

            fermerConnection();
            return bs;

        }


        static public void Synchronizer(string t)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds.Tables[t]);
            da = null;
            cb = null;


        }



        static public void remplirListe(ListControl l, string sql, string t, string dm, string vm, BindingSource bs)
        {
            ouvrirConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);

            if (!ds.Tables.Contains(t))
                da.Fill(ds, t);
            da = null;


            bs.DataSource = ds;
            bs.DataMember = t;

            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;
            fermerConnection();


        }




        static public void remplirGrille(DataGridView l, string t, BindingSource bs)
        {
            ouvrirConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, cn);

            if (!ds.Tables.Contains(t))
                da.Fill(ds, t);
            da = null;


            bs.DataSource = ds;
            bs.DataMember = t;

            l.DataSource = bs;


            fermerConnection();


        }



             
        static public void remplirGrille(DataGridView l, string sql, string t, BindingSource bs)
        {
            ouvrirConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);

            if (!ds.Tables.Contains(t))
                da.Fill(ds, t);
            da = null;


            bs.DataSource = ds;
            bs.DataMember = t;

            l.DataSource = bs;


            fermerConnection();


        }


        static public void creerRelation(string tpk, string tfk, string pk, string fk)
        {
            string nomRelation = "rel_" + tpk + "_" + tfk;
            if (!ds.Relations.Contains(nomRelation))
            {
                DataColumn c1 = ds.Tables[tpk].Columns[pk];
                DataColumn c2 = ds.Tables[tfk].Columns[fk];
                DataRelation r = new DataRelation(nomRelation, c1, c2);
                ds.Relations.Add(r);
            }

        }



        static public void remplirListeRel(ListControl l, string t, string dm, string vm, BindingSource bs, string tPK, string pk, string fk, BindingSource bsPK)
        {

            ouvrirConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, cn);

            if (!ds.Tables.Contains(t))
                da.Fill(ds, t);


            da = null;

            creerRelation(tPK, t, pk, fk);


            bs.DataSource = bsPK;
            bs.DataMember = "rel_" + tPK + "_" + t;

            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;
            fermerConnection();



        }








    }
}
