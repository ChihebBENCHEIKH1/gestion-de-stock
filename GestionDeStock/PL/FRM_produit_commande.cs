using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_produit_commande : Form
    {
        public Form frmdetail;
        public FRM_produit_commande(Form frmdetail)
        {
            InitializeComponent();
            this.frmdetail = frmdetail;
        }

        private void FRM_produit_commande_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void textremise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textquantite.Text!="")
            {
                int quantite=int.Parse(textquantite.Text);
                int prix=int.Parse(lblprix.Text);
                if(int.Parse(lblstock.Text)<quantite)
                {
                    MessageBox.Show("Il y a seulement " + int.Parse(lblstock.Text) + " disponible dans le stock ","Disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textquantite.Text = "";
                    texttotal.Text=lblprix.Text;


                }
                else
                {
                    texttotal.Text = (quantite * prix).ToString();

                }
                
            }
            else
            {
                texttotal.Text = lblstock.Text;
            }
        }

        private void textremise_TextChanged(object sender, EventArgs e)
        {
            if (textremise.Text != "")
            { int quantite = 1;
                if (textquantite.Text != "")
                {
                    quantite = int.Parse((string)textquantite.Text);

                }
                int prix = int.Parse(lblprix.Text);
                int total = quantite * prix;
                int remise = int.Parse(textremise.Text);
                texttotal.Text = (total - (total / 100)).ToString();
            }
            else
            {
                int quantite=1;
                if (textquantite.Text != "")
                {
                    quantite = int.Parse((string)textquantite.Text);

                }
                int prix = int.Parse(lblprix.Text);
                int total=quantite * prix;
                texttotal.Text = (total).ToString();
            }
            }

        private void btneregistrer_Click(object sender, EventArgs e)
        {


            BL.D_commande DETAIL = new BL.D_commande
            {
                Nom = labelnom.Text,
                Quantite = int.Parse(textquantite.Text),
                Prix = lblprix.Text,
             Remise = textremise.Text,
             Total = texttotal.Text, 
                ID = Convert.ToInt16(lblid.Text),
        };
            
          if(grpproduit.Text=="Vendre Produit")
            {

                if (BL.D_commande.liste_commande.SingleOrDefault(s => s.ID == DETAIL.ID) != null)
                {
                    MessageBox.Show("Produit déjà existe dans la commande", "exsiste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    BL.D_commande.liste_commande.Add(DETAIL);
            }
          else
            {
                DialogResult pr = MessageBox.Show("Voulez vous vraiment sauvgarder ces données", "Modifer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(pr==DialogResult.Yes)
                {
                    int index = BL.D_commande.liste_commande.FindIndex(s => s.ID == int.Parse(lblid.Text));
                    BL.D_commande.liste_commande[index] = DETAIL;
                    MessageBox.Show("Modification éffectuer", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Modification annulé", "Annulé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

            (frmdetail as Detail_commande).Actualiser_detail_commande();
        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }
    }
    }

