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
    public partial class User_liste_utilisateur : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-672AMT3;Initial Catalog=GESTION_DE_STOCK;Integrated Security=True");
        private static User_liste_utilisateur userutilisateur;
        private dbStockContext db;
        
        public static User_liste_utilisateur Instance
        {
            get
            {
                if (userutilisateur == null)
                {
                    userutilisateur = new User_liste_utilisateur();
                }
                return userutilisateur;
            }
        }
        public User_liste_utilisateur()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_ajouter_modifier_utilisateur frmuti = new Form_ajouter_modifier_utilisateur(this);
            frmuti.ShowDialog();
        }
        public string selectverif()
        {
            int nbselect = 0;
            for (int i = 0; i < dvgutilisateur.Rows.Count; i++)
            {
                if ((bool)dvgutilisateur.Rows[i].Selected == true)
                {
                    nbselect++;

                }
            }
            if (nbselect == 0)
                return "Selectionner l'utilisateur que vous voulez modifier";
            if (nbselect > 1)
            {
                return "Selectionner un seul utilisateur à modifier";
            }


            return null;
        }
       
        private void buttmodifier_Click(object sender, EventArgs e)
        {
            PL.Form_ajouter_modifier_utilisateur ajouteModifcl = new Form_ajouter_modifier_utilisateur(this);
            if (selectverif() == null)
            {
                for (int i = 0; i < dvgutilisateur.Rows.Count; i++)
                {
                    if (dvgutilisateur.SelectedRows.Count > 0)
                    {
                        ajouteModifcl.txtnom.Text = dvgutilisateur.SelectedRows[0].Cells[1].Value.ToString();
                        ajouteModifcl.txtmdp.Text = dvgutilisateur.SelectedRows[0].Cells[2].Value.ToString();
                        ajouteModifcl.txtypeutilisateur.Text = dvgutilisateur.SelectedRows[0].Cells[3].Value.ToString();
                        

                    }
                }



                ajouteModifcl.lbltitre.Text = "Modifier Utilisateur";
                ajouteModifcl.lbltitre.Visible = true;
                ajouteModifcl.ShowDialog();
            }
            else
            {
                MessageBox.Show(selectverif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void buttsupprimer_Click(object sender, EventArgs e)
        {
            int nbselect = 0;
            for (int i = 0; i < dvgutilisateur.Rows.Count; i++)
            {
                if ((bool)dvgutilisateur.Rows[i].Selected == true)
                {
                    nbselect++;

                }
            }
            if (nbselect == 0)
                MessageBox.Show("Aucun utilisateur n'est sélectionné", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            else
            {
                DialogResult r = MessageBox.Show("Voulez vous supprimer l'utilisateur", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    for (int i = 0; i < dvgutilisateur.Rows.Count; i++)
                    {
                        if (dvgutilisateur.SelectedRows.Count > 0)
                        {
                            int id = (int)dvgutilisateur.CurrentRow.Cells[0].Value;
                            BL.CLS_aouter_modifier_supprimer_utilisateur cls = new BL.CLS_aouter_modifier_supprimer_utilisateur();
                            cls.supprimerUtilisateur(id);
                            actualiserutilisateur();
                             


                        }
                    }

                }
            }
        }
        public void actualiserutilisateur()
        {
            string sqlselect = "select idUtilisateur as ID, NomUtilisateur as Nom , Mot_De_Passe as 'Mot de Passe', type_utilisateur as Type from Utilisateur";
            SqlDataAdapter sda = new SqlDataAdapter(sqlselect, conn);
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds, "Utilisateur");
            dvgutilisateur.DataSource = ds.Tables[0];
        }

        private void dvgutilisateur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_liste_utilisateur_Load(object sender, EventArgs e)
        {
            actualiserutilisateur();
        }

        private void txtrecherchecl_TextChanged(object sender, EventArgs e)
        {
            string v = "select * from Utilisateur where NomUtilisateur like " + '\'' + txtrechercheuti.Text + '%' + '\'';
            SqlDataAdapter sda = new SqlDataAdapter(v, conn);
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds, "Utilisateur");
            dvgutilisateur.DataSource = ds.Tables[0];
        }

        private void txtrechercheuti_Enter(object sender, EventArgs e)
        {
            if(txtrechercheuti.Text=="Recherche")
            {
                txtrechercheuti.Text = "";
                txtrechercheuti.ForeColor = Color.Black;
            }
        }

        private void txtrechercheuti_Leave(object sender, EventArgs e)
        {
            if (txtrechercheuti.Text == "")
            {
                txtrechercheuti.Text = "Recherche";
                txtrechercheuti.ForeColor = Color.Black;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
