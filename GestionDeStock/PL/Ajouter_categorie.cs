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
    public partial class Ajouter_categorie : Form
    {
        private UserControl usercat;
        public int idcategorie;
        public Ajouter_categorie(UserControl usercat)
        {
            InitializeComponent();
            this.usercat = usercat;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textnom_Enter(object sender, EventArgs e)
        {
            if(textnom.Text=="Nom du categorie")
            {
                textnom.Text = "";
                textnom.ForeColor = Color.Silver;
            }
        }

        private void textnom_Leave(object sender, EventArgs e)
        {
            if (textnom.Text == "")
            {
                textnom.Text = "Nom du categorie";
                textnom.ForeColor = Color.Silver;
            }

        }


        private void btneregistrercat_Click(object sender, EventArgs e)
        {
            BL.CLS_categorie fr = new BL.CLS_categorie();
            if(textnom.Text=="" || textnom.Text=="Nom du categorie")
            {
                MessageBox.Show("Enter le nom du categorie","Ajouter categorie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if(lbltitre.Text=="Ajouter Categorie")
                {
                    
                    if(fr.Ajoutercategorie(textnom.Text)==false)
                    {
                        MessageBox.Show("Categorie existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Categorie ajouter avec success", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usercat as User_liste_categorie).remplirgrid();
                    }
                }
                else if (lbltitre.Text == "Modifier categorie")
                {
                    BL.CLS_categorie cls = new BL.CLS_categorie();
                    DialogResult r = MessageBox.Show("Voulez vous sauvgarder les changement", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == r)
                    {
                        cls.ModifierCategorie(idcategorie, textnom.Text);
                        MessageBox.Show("Categorie modifier", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usercat as User_liste_categorie).remplirgrid();
                    }

                }
            }
        }

        private void btneregistrercat_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textnom_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                BL.CLS_categorie fr = new BL.CLS_categorie();
                if (textnom.Text == "" || textnom.Text == "Nom du categorie")
                {
                    MessageBox.Show("Enter le nom du categorie", "Ajouter categorie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (lbltitre.Text == "Ajouter Categorie")
                    {

                        if (fr.Ajoutercategorie(textnom.Text) == false)
                        {
                            MessageBox.Show("Categorie existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Categorie ajouter avec success", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            (usercat as User_liste_categorie).remplirgrid();

                        }
                    }
                    else if (lbltitre.Text == "Modifier categorie")
                    {
                        BL.CLS_categorie cls = new BL.CLS_categorie();
                        DialogResult r = MessageBox.Show("Voulez vous sauvgarder les changement", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == r)
                        {
                            cls.ModifierCategorie(idcategorie, textnom.Text);
                            MessageBox.Show("Categorie modifier", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            (usercat as User_liste_categorie).remplirgrid();
                        }

                    }
                }
            }
        }

        private void textnom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
