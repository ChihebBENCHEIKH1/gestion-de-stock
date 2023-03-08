using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionDeStock.PL
{
    public partial class Detail_commande : Form
    {
        private dbStockContext db;
        private UserControl usercommande;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-672AMT3;Initial Catalog=GESTION_DE_STOCK;Integrated Security=True");


        public Detail_commande(UserControl user)
        {
            InitializeComponent();
            db = new dbStockContext();
            usercommande = user;
        }
        public void remplirdvgproduit()
        {

            string v = "select Id_Produit as ID ,Nom_Produit as Nom,Quantite_Produit as Quantité,Prix_Produit as Prix, Nom_Categorie as Categorie from Produit,Categorie where Produit.ID_CATEGORIE=Categorie.ID_CATEGORIE";
            SqlDataAdapter sda = new SqlDataAdapter(v, conn);
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds);
            dvgproduit.DataSource = ds.Tables[0];

        }

        private void Detail_commande_Load(object sender, EventArgs e)
        {
            remplirdvgproduit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.frm_client_commande frm = new frm_client_commande();
            frm.ShowDialog();
            idclient= (int)frm.dvgclient.CurrentRow.Cells[0].Value;
            textnom.Text = frm.dvgclient.CurrentRow.Cells[1].Value.ToString();
            textprenom.Text = frm.dvgclient.CurrentRow.Cells[2].Value.ToString();
            textmail.Text = frm.dvgclient.CurrentRow.Cells[7].Value.ToString();
            texttlf.Text = frm.dvgclient.CurrentRow.Cells[4].Value.ToString();
            textpays.Text = frm.dvgclient.CurrentRow.Cells[5].Value.ToString();
            textville.Text = frm.dvgclient.CurrentRow.Cells[6].Value.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
            BL.D_commande.liste_commande.Clear();
        }

        private void textrechercheprod_TextChanged(object sender, EventArgs e)
        {
            string v = "select Id_Produit,Nom_Produit,Quantite_Produit,Prix_Produit, Nom_Categorie from Produit,Categorie  where Categorie.ID_CATEGORIE=Produit.ID_CATEGORIE and  Nom_Produit like " + '\'' + textrechercheprod.Text + '%' + '\'';
            SqlDataAdapter sda = new SqlDataAdapter(v, conn);
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds);
            dvgproduit.DataSource = ds.Tables[0];
        }

        private void textrechercheprod_Enter(object sender, EventArgs e)
        {
            if(textrechercheprod.Text=="Recherche")
            {
                textrechercheprod.Text = "";
                textrechercheprod.ForeColor = Color.Silver;
            }
        }

        private void dvgproduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void Actualiser_detail_commande()
        {
            dvgcommande.Rows.Clear();
            float totalht = 0,tva=0,totalttc=0;
            if(texttva.Text!="")
            {
                tva = float.Parse(texttva.Text);
            }
            foreach (var l in BL.D_commande.liste_commande)
            {
                dvgcommande.Rows.Add(l.ID, l.Nom, l.Quantite, l.Prix, l.Remise, l.Total);
                totalht =totalht+ float.Parse(l.Total);
            }
            texttotalHTT.Text = totalht.ToString();
            texttotalHTT.Refresh();
            totalttc = totalht + (totalht * tva / 100);
            texttotalTTC.Text = totalttc.ToString();
            texttotalTTC.Refresh();
        }
        private void dvgproduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_produit_commande frm = new FRM_produit_commande(this);
            frm.lblid.Text = dvgproduit.CurrentRow.Cells[0].Value.ToString();
            frm.labelnom.Text = dvgproduit.CurrentRow.Cells[1].Value.ToString();
            frm.lblstock.Text = dvgproduit.CurrentRow.Cells[2].Value.ToString();
            frm.lblprix.Text = dvgproduit.CurrentRow.Cells[3].Value.ToString();
            frm.texttotal.Text = dvgproduit.CurrentRow.Cells[4].Value.ToString();
            frm.ShowDialog();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_produit_commande frm = new FRM_produit_commande(this);
            Produit pr = new Produit();
            if (dvgcommande.CurrentRow != null)
            {
                frm.grpproduit.Text = "Modifer Produit";
                frm.lblid.Text = dvgcommande.CurrentRow.Cells[0].Value.ToString();
                frm.labelnom.Text = dvgcommande.CurrentRow.Cells[1].Value.ToString();
                int idp = int.Parse(dvgcommande.CurrentRow.Cells[0].Value.ToString());
                pr = db.Produits.SingleOrDefault(s => s.Id_Produit == idp);
                frm.lblstock.Text = pr.Quantite_Produit.ToString();
                frm.lblprix.Text = dvgcommande.CurrentRow.Cells[3].Value.ToString();
                frm.textquantite.Text = dvgcommande.CurrentRow.Cells[2].Value.ToString();
                frm.textremise.Text = dvgcommande.CurrentRow.Cells[4].Value.ToString();
                frm.texttotal.Text = dvgcommande.CurrentRow.Cells[5].Value.ToString();
                frm.ShowDialog();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dvgcommande.CurrentRow != null)
            {
                DialogResult pr = MessageBox.Show("Voulez vous éffectuée la suppression", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(pr==DialogResult.Yes)
                {
                    int index = BL.D_commande.liste_commande.FindIndex(s => s.ID == int.Parse(dvgcommande.CurrentRow.Cells[0].Value.ToString()));
                    BL.D_commande.liste_commande.RemoveAt(index);
                    Actualiser_detail_commande();
                    MessageBox.Show("Données supprimés", "supprimer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression annulée", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void textpays_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttva_TextChanged(object sender, EventArgs e)
        {
            Actualiser_detail_commande();
        }

        private void texttotalHTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttotalHTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void texttva_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        public int idclient;
        private void btneregistrer_Click(object sender, EventArgs e)
        {
            BL.CLS_commande_detail_commande cls = new BL.CLS_commande_detail_commande();
            if(dvgcommande.Rows.Count==0)
            {
                MessageBox.Show("Ajouter des produits", "ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(textnom.Text=="")
                {
                    MessageBox.Show("Ajouter un client", "ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cls.ajouterCommande(datecommande.Value, idclient, texttotalHTT.Text, texttva.Text, texttotalTTC.Text);
                    foreach(var ld in BL.D_commande.liste_commande)
                    {
                        cls.Ajouter_detail(ld.ID, ld.Nom, ld.Quantite, ld.Prix, ld.Remise, ld.Total);
                    }
                    (usercommande as Liste_commande).remmplirData();
                    BL.D_commande.liste_commande.Clear();
                    Close();
                    MessageBox.Show("Commande ajoutée", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void dvgcommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
