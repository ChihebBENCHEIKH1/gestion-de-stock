using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GestionDeStock.PL
{
    public partial class FRM_Ajoute_Modifier_Client : Form
    {
        private UserControl userclient;
        public FRM_Ajoute_Modifier_Client(UserControl userc)
        {
            InitializeComponent();
            this.userclient = userc; 

        }
       public string testObligatoire()
        {
            if(textnom.Text=="" ||textnom.Text =="Nom du client")
            {
                return "Entrer le nom du client";
            }
            if (textadr.Text == "" || textadr.Text == "Adresse du client")
                return "Enter l\'adresse du client";
            
            if (texttl.Text == "" || texttl.Text == "Télephone du client")
            {
                return "Entrer le numéro du télephone du client";
            }
            if (texttl.Text.Length <8 || texttl.Text.Length >8 )
                return "numéro incorrecte";
            if (textville.Text == "" || textville.Text == "Ville du client")
            {
                return "Entrer la ville du client";
            }
            if (textprenom.Text == "" || textprenom.Text == "Prénom du client")
            {
                return "Entrer le prénom du client";
            }

             if (textpays.Text == "" || textpays.Text == "Pays du client")
            {
                return "Entrer le pays du client";
            }
            if (textmail.Text == "" || textmail.Text == "Mail du client")
            {
                return "Entrer le mail du client";
            }
            if (textmail.Text != "" || textmail.Text != "Mail du client")
            {
                try
                {
                    new MailAddress(textmail.Text);

                }
                catch(Exception e)
                {
                    return "mail invalide";
                }
            }

            return null;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_Ajoute_Modifier_Client_Load(object sender, EventArgs e)
        {

        }

        private void lbltitre_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textnom_Enter(object sender, EventArgs e)
        {
            if(textnom.Text=="Nom du client")
            {
                textnom.Text = "";
                textnom.ForeColor = Color.White;
            }
        }

        private void textnom_Leave(object sender, EventArgs e)
        {
            if(textnom.Text=="")
            {
                textnom.Text = "Nom du client";
                textnom.ForeColor= Color.Silver;

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textprenom_Enter(object sender, EventArgs e)
        {
            if (textprenom.Text == "Prénom du client")
            {
                textprenom.Text = "";
                textprenom.ForeColor = Color.Silver;

            }
        }

        private void textprenom_Leave(object sender, EventArgs e)
        {
            if (textprenom.Text == "")
            {
                textprenom.Text = "Prénom du client";
                textprenom.ForeColor = Color.Silver;

            }
        }

        private void textadr_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textadr_Leave(object sender, EventArgs e)
        {
            if (textadr.Text == "")
            {
                textadr.Text = "Adresse du client";
                textadr.ForeColor = Color.Silver;

            }
        }

        private void texttl_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void texttl_Enter(object sender, EventArgs e)
        {
            if (texttl.Text == "Télephone du client")
            {
                texttl.Text = "";
                texttl.ForeColor = Color.Silver;

            }

        }

        private void textadr_Enter(object sender, EventArgs e)
        {
            if (textadr.Text == "Adresse du client")
            {
                textadr.Text = "";
                textadr.ForeColor = Color.Silver;

            }

        }

        private void textprenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttl_Leave(object sender, EventArgs e)
        {
            if (texttl.Text == "")
            {
                texttl.Text = "Télephone du client";
                texttl.ForeColor = Color.Silver;

            }

        }

        private void textville_Enter(object sender, EventArgs e)
        {
            if (textville.Text == "Ville du client")
            {
                textville.Text = "";
                textville.ForeColor = Color.Silver;

            }
        }

        private void textville_Leave(object sender, EventArgs e)
        {
            if (textville.Text == "")
            {
                textville.Text = "Ville du client";
                textville.ForeColor = Color.Silver;

            }

        }

        private void textpays_Enter(object sender, EventArgs e)
        {

            if (textpays.Text == "Pays du client")
            {
                textpays.Text = "";
                textpays.ForeColor = Color.Silver;

            }
        }

        private void textpays_Leave(object sender, EventArgs e)
        {
            
                if (textpays.Text == "")
            {
                textpays.Text = "Pays du client";
                textpays.ForeColor = Color.Silver;

            }
        }

        private void textmail_Enter(object sender, EventArgs e)
        {


            if (textmail.Text == "Mail du client")
            {
                textmail.Text = "";
                textmail.ForeColor = Color.Silver;

            }
        }

        private void textmail_Leave(object sender, EventArgs e)
        {
            if (textmail.Text == "")
            {
                textmail.Text = "Mail du client";
                textmail.ForeColor = Color.Silver;

            }

        }

        private void textnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttl_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void texttl_KeyPress(object sender, KeyPressEventArgs e)
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
            if (testObligatoire() != null)
            {
                MessageBox.Show(testObligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lbltitre.Text == "Ajouter client")
            {
                BL.CLS_client clclient = new BL.CLS_client();
                if (clclient.AjouterClient(textnom.Text, textprenom.Text, textadr.Text, textville.Text, texttl.Text, textpays.Text, textmail.Text) == true)
                {
                    MessageBox.Show("Client ajouter avec success", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                    
                }
                else
                {

                    MessageBox.Show("Nom et prenom du client existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BL.CLS_client clclient = new BL.CLS_client();
                UserControl1 userControl1 = new UserControl1();
                DialogResult r = MessageBox.Show("Voulez vous vraiment modifier ces informations", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    clclient.Modifier_client(userControl1.ID_select, textnom.Text, textprenom.Text, textadr.Text, textville.Text, texttl.Text, textpays.Text, textmail.Text);
                    MessageBox.Show("Modification éffectuer avec success", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    userControl1.actualiserclient();
                }
                else
                {
                    MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            textnom.Text = "Nom du client";textnom.ForeColor = Color.Silver;
            textprenom.Text = "Préom du client";textprenom.ForeColor = Color.Silver;
            textadr.Text = "Adresse du client";textadr.ForeColor = Color.Silver;
            texttl.Text = "Télephone du client";texttl.ForeColor = Color.Silver;
            textville.Text = "Ville du client";textville.ForeColor = Color.Silver;
            textpays.Text = "Pays du client";textpays.ForeColor = Color.Silver;
            textmail.Text = "Mail du client";textmail.ForeColor = Color.Silver;
        }

        private void textprenom_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
