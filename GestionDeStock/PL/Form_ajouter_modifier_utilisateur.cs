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
    public partial class Form_ajouter_modifier_utilisateur : Form
    {
        private UserControl user;
        public int selectid;
        public Form_ajouter_modifier_utilisateur(UserControl user)
        {
            InitializeComponent();
            this.user = user;

        }
        

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                txtnom.Text = "Nom d'Utilisateur";
                txtnom.ForeColor = Color.Silver;
            }
        }

        private void txtmdp_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtmdp_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                txtnom.Text = "Mot de Passe";
                txtnom.ForeColor = Color.Silver;
            }
        }

        private void txtypeutilisateur_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtypeutilisateur_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                txtnom.Text = "Type d'Utilisateur";
                txtnom.ForeColor = Color.Silver;
            }
        }
        public string testObligatoire()
        {
            if (txtnom.Text == "" || txtnom.Text == "Nom d'Utilisateur")
            {
                return "Entrer le nom d'Utilisateur";
            }
            if (txtmdp.Text == "" || txtmdp.Text == "Mot de Passe")
                return "Enter le mpt de passe de l'utilisateur";

            if (txtypeutilisateur.Text == "" || txtypeutilisateur.Text == "Type d'Utilisateur")
            {
                return "Entrer le Type d'utilisateur(admin ou utilisateur)";
            }
           
            
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            User_liste_utilisateur us = new User_liste_utilisateur();
            if (testObligatoire() != null)
            {
                MessageBox.Show(testObligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lbltitre.Text == "Ajouter Utilisateur")
            {
                
                BL.CLS_aouter_modifier_supprimer_utilisateur uti = new BL.CLS_aouter_modifier_supprimer_utilisateur();
                if (uti.AjouterUtilisateur(txtnom.Text,txtmdp.Text,txtypeutilisateur.Text) == true)
                {
                    
                    MessageBox.Show("Utilisateur ajouté avec success", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (user as User_liste_utilisateur).actualiserutilisateur();



                }
                else
                {

                    MessageBox.Show("Nom du l'utilisateur existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                BL.CLS_aouter_modifier_supprimer_utilisateur utili = new BL.CLS_aouter_modifier_supprimer_utilisateur();
                User_liste_utilisateur user = new User_liste_utilisateur();
                DialogResult r = MessageBox.Show("Voulez vous vraiment modifier ces informations", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    utili.Modifier_Utilisateur(selectid, txtnom.Text, txtmdp.Text, txtypeutilisateur.Text);
                    MessageBox.Show("Modification éffectuer avec success", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (user as User_liste_utilisateur).actualiserutilisateur();

                }
                else
                {
                    MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                 
            }
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text == "Nom d'Utilisateur")
            {
                txtnom.Text = "";
                txtnom.ForeColor = Color.Silver;
            }
        }

        private void txtmdp_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text == "Mot de Passe")
            {
                txtnom.Text = "";
                txtnom.ForeColor = Color.Silver;
            }
        }

        private void txtypeutilisateur_Enter(object sender, EventArgs e)
        {
            if (txtypeutilisateur.Text == "Type d'Utilisateur")
            {
                txtypeutilisateur.Text = "";
                txtypeutilisateur.ForeColor = Color.Silver;
            }
        }
    }
}
