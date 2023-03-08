using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace GestionDeStock.PL
{
    public partial class FRM_prod : Form
    {
        public int Idproduit;
        public int quantite;
        private dbStockContext db;
        UserControl User=new UserControl();
        public FRM_prod()
        {
            InitializeComponent();
            db=new dbStockContext();
            comboBox1.DataSource = db.Categories.ToList();
            comboBox1.DisplayMember = "Nom_Categorie";
            comboBox1.ValueMember = "ID_CATEGORIE";
        }

        private void lbltitre_Click(object sender, EventArgs e)
        {

        }
        string testobligatoire()
        {
            if(textnomProd.Text=="" || textnomProd.Text == "Nom produit")
            {
                return "Entrer le nom du produit";
            }
            if(textprix.Text=="" || textprix.Text == "Quantité")
            {
                return "Entrer le prix";
            }
            if(textquantite.Text=="" || textquantite.Text == "Prix")
            {
                return "Entrer la quantité";
            }
            if (picproduit.Image == null)
                return "Entrer l\'image du produit";
            return null;
        }
        private void FRM_prod_Load(object sender, EventArgs e)
        {

        }

        private void textnomProd_Enter(object sender, EventArgs e)
        {
            if(textnomProd.Text=="Nom produit")
            {
                textnomProd.Text = "";
                textnomProd.ForeColor = Color.Snow;
            }
        }

        private void textnomProd_Leave(object sender, EventArgs e)
        {
            if (textnomProd.Text == "")
            {
                textnomProd.Text = "Nom produit";
                textnomProd.ForeColor = Color.Snow;
            }

        }

        private void textquantite_Enter(object sender, EventArgs e)
        {
            if (textquantite.Text == "Quantité")
            {
                textquantite.Text = "";
                textquantite.ForeColor = Color.Snow;
            }
        }

        private void textquantite_Leave(object sender, EventArgs e)
        {
            if (textquantite.Text == "")
            {
                textquantite.Text = "Quantité";
                textquantite.ForeColor = Color.Snow;
            }

        }

        private void textprix_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textprix_Leave(object sender, EventArgs e)
        {
            if (textprix.Text == "")
            {
                textquantite.Text = "Prix";
                textquantite.ForeColor = Color.Snow;
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttparcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog op=new OpenFileDialog();
            op.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP";
            if(op.ShowDialog() == DialogResult.OK)
            {
                picproduit.Image=Image.FromFile(op.FileName);
            }

        }

        private void textnomProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            textnomProd.Text = "Nom produit";
            textnomProd.ForeColor = Color.Snow;
            textquantite.Text = "Quantité";
            textquantite.ForeColor = Color.Snow;
            textprix.Text = "Prix";
            textprix.ForeColor = Color.Snow;
            picproduit.Image = null;
            comboBox1.Text = "";
        }

        private void textprix_Enter(object sender, EventArgs e)
        {
            if (textprix.Text == "Prix")
            {
                textprix.Text = "";
                textprix.ForeColor = Color.Snow;
            }
        }

        private void textquantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        private void textprix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        private void btneregistrer_Click(object sender, EventArgs e)
        {
            if(testobligatoire()!=null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(lbltitre.Text=="Ajouter Produit")
            {
                User_liste_prod pr = new User_liste_prod();
                BL.Cls_ajouter_produit clprod=new BL.Cls_ajouter_produit();
                MemoryStream mr = new MemoryStream();
                picproduit.Image.Save(mr, picproduit.Image.RawFormat);
                byte[] byteimageP =mr.ToArray();
                if(clprod.Ajouterprod(textnomProd.Text,int.Parse(textquantite.Text),textprix.Text,byteimageP,Convert.ToInt32(comboBox1.SelectedValue))==true)
                    {
                    MessageBox.Show("Produit ajouter avec success", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    pr.actualiserdvgprod();
                }
                else
                {
                    MessageBox.Show("Produit déjà existe","Ajouter",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
            else if(lbltitre.Text=="Modifier Produit")
            {
                MemoryStream mr =new MemoryStream();
                picproduit.Image.Save(mr, picproduit.Image.RawFormat);
                byte[] byteimageP=mr.ToArray();
                BL.Cls_ajouter_produit cl= new BL.Cls_ajouter_produit();
                DialogResult r = MessageBox.Show("Vous voulez sauvgarder les modifications ", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(r==DialogResult.Yes)
                {
                    User_liste_prod pr = new User_liste_prod();

                    cl.Modifier_produit(pr.id, textnomProd.Text, int.Parse(textquantite.Text), textprix.Text, byteimageP,Convert.ToInt16(comboBox1.SelectedValue));
                    MessageBox.Show("Modification effectuée avex success", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    pr.actualiserdvgprod();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btneregistrer_Leave(object sender, EventArgs e)
        {
        }
    }
}
