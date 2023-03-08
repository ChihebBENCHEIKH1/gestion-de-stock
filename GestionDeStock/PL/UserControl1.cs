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
    public partial class UserControl1 : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-672AMT3;Initial Catalog=GESTION_DE_STOCK;Integrated Security=True");
        private static UserControl1 userclient;
        private dbStockContext db;
        public static UserControl1 Instance
        {
            get
            {
                if (userclient == null)
                {
                    userclient = new UserControl1();
                }
                return userclient;
            }
        }

        public UserControl1()
        {
            InitializeComponent();
            db = new dbStockContext();
            txtrecherchecl.Enabled = false;
        }
       
        private void UserControl1_Load(object sender, EventArgs e)
        {
                actualiserclient();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifier_Client ajouteModifcl = new PL.FRM_Ajoute_Modifier_Client(this);
            ajouteModifcl.ShowDialog();

        }
        public int ID_select;
        public string selectverif()
        {
            int nbselect = 0;
            for (int i = 0; i < dvgclient.Rows.Count; i++)
            {
                if ((bool)dvgclient.Rows[i].Selected == true)
                {
                    nbselect++;

                }
           }
                if (nbselect == 0)
                    return "Selectionner le client que vous voulez modifier";
                if(nbselect >1)
                {
                    return "Selectionner un seul client à modifier";
                }
               
            
 return null;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (BL.Myconnection.type == "A")
            {
                PL.FRM_Ajoute_Modifier_Client ajouteModifcl = new FRM_Ajoute_Modifier_Client(this);
                if (selectverif() == null)
                {
                    for (int i = 0; i < dvgclient.Rows.Count; i++)
                    {
                        if (dvgclient.SelectedRows.Count > 0)
                        {
                            ID_select = (int)dvgclient.SelectedRows[0].Cells[0].Value;
                            ajouteModifcl.textnom.Text = dvgclient.SelectedRows[0].Cells[1].Value.ToString();
                            ajouteModifcl.textprenom.Text = dvgclient.SelectedRows[0].Cells[2].Value.ToString();
                            ajouteModifcl.textville.Text = dvgclient.SelectedRows[0].Cells[3].Value.ToString();
                            ajouteModifcl.texttl.Text = dvgclient.SelectedRows[0].Cells[4].Value.ToString();
                            ajouteModifcl.textpays.Text = dvgclient.SelectedRows[0].Cells[5].Value.ToString();
                            ajouteModifcl.textadr.Text = dvgclient.SelectedRows[0].Cells[6].Value.ToString();
                            ajouteModifcl.textmail.Text = dvgclient.SelectedRows[0].Cells[7].Value.ToString();
                            /*dgvResults.SelectedRows[0].Cells["yourColumnName"].Value.ToString();
                            dgvResults.SelectedRows[0].Cells["yourColumnName"].Value.ToString();
                            dgvResults.SelectedRows[0].Cells["yourColumnName"].Value.ToString();
                            dgvResults.SelectedRows[0].Cells["yourColumnName"].Value.ToString();*/

                        }
                    }
                    ajouteModifcl.lbltitre.Text = "Modifier client";
                    ajouteModifcl.lbltitre.Visible = true;
                    ajouteModifcl.ShowDialog();
                }
                else
                {
                    MessageBox.Show(selectverif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (BL.Myconnection.type == "U")
                MessageBox.Show("Tu n'as le droit d'access");
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            actualiserclient();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from client", conn);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill (ds, "tact");
            dvgclient.DataSource = ds.Tables["tact"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtrecherchecl.Enabled = true;
            txtrecherchecl.Text = "";
            if (comborecherchecl.SelectedIndex == 0)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from client", conn);
                DataSet ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "tact");
                dvgclient.DataSource = ds.Tables["tact"];
            }
        }

        private void dvgclient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BL.Myconnection.type == "A")
            {
                int nbselect = 0;
                for (int i = 0; i < dvgclient.Rows.Count; i++)
                {
                    if ((bool)dvgclient.Rows[i].Selected == true)
                    {
                        nbselect++;

                    }
                }
                if (nbselect == 0)
                    MessageBox.Show("Aucun client n'est sélectionner", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                else
                {
                    DialogResult r = MessageBox.Show("Voulez vous supprimer le client", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        for (int i = 0; i < dvgclient.Rows.Count; i++)
                        {
                            if (dvgclient.SelectedRows.Count > 0)
                            {

                                BL.CLS_client cls = new BL.CLS_client();
                                int id = (int)dvgclient.SelectedRows[0].Cells[0].Value;
                                cls.Supprimer_client(id);

                            }
                        }

                    }
                }
            }
            else
                MessageBox.Show("Tu n'as pas le droit d'access");
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            if (comborecherchecl.SelectedIndex == 1)
            {
                string v = "select * from Client where Nom_Client like " + '\'' + txtrecherchecl.Text + '%' + '\'';
                SqlDataAdapter sda = new SqlDataAdapter(v, conn);
                DataSet ds = new System.Data.DataSet();
                sda.Fill(ds, "Client");
                dvgclient.DataSource = ds.Tables[0];
            }
            else if (comborecherchecl.SelectedIndex == 2)
            {
                string v = "select * from Client where Prenom_Client like " + '\'' + txtrecherchecl.Text + '%' + '\'';
                SqlDataAdapter sda = new SqlDataAdapter(v, conn);
                DataSet ds = new System.Data.DataSet();
                sda.Fill(ds, "Client");
                dvgclient.DataSource = ds.Tables[0];
            }
            else if (comborecherchecl.SelectedIndex == 2)
            {
                string v = "select * from Client where Prenom_Client like " + '\'' + txtrecherchecl.Text + '%' + '\'';
                SqlDataAdapter sda = new SqlDataAdapter(v, conn);
                DataSet ds = new System.Data.DataSet();
                sda.Fill(ds, "Client");
                dvgclient.DataSource = ds.Tables[0];
            }/*Ville
Pays
Adresse
Mail
Telephone*/
            else if (comborecherchecl.SelectedIndex == 3)
            {
                string v = "select * from Client where Ville_Client like " + '\'' + txtrecherchecl.Text + '%' + '\'';
                SqlDataAdapter sda = new SqlDataAdapter(v, conn);
                DataSet ds = new System.Data.DataSet();
                sda.Fill(ds, "Client");
                dvgclient.DataSource = ds.Tables[0];
            }
            else if (comborecherchecl.SelectedIndex == 4)
            {
                string v = "select * from Client where Pays_Client like " + '\'' + txtrecherchecl.Text + '%' + '\'';
                SqlDataAdapter sda = new SqlDataAdapter(v, conn);
                DataSet ds = new System.Data.DataSet();
                sda.Fill(ds, "Client");
                dvgclient.DataSource = ds.Tables[0];
            }
            else if (comborecherchecl.SelectedIndex == 5)
            {
                string v = "select * from Client where Adresse_Client like " + '\'' + txtrecherchecl.Text + '%' + '\'';
                SqlDataAdapter sda = new SqlDataAdapter(v, conn);
                DataSet ds = new System.Data.DataSet();
                sda.Fill(ds, "Client");
                dvgclient.DataSource = ds.Tables[0];
            }
            else if (comborecherchecl.SelectedIndex == 6)
            {
                string v = "select * from Client where  Email like " + '\'' + txtrecherchecl.Text + '%' + '\'';
                SqlDataAdapter sda = new SqlDataAdapter(v, conn);
                DataSet ds = new System.Data.DataSet();
                sda.Fill(ds, "Client");
                dvgclient.DataSource = ds.Tables[0];
            }  
            else if (comborecherchecl.SelectedIndex == 7)
            {
                string v = "select * from Client where  Telephonne_Client like " + '\'' + txtrecherchecl.Text + '%' + '\'';
                SqlDataAdapter sda = new SqlDataAdapter(v, conn);
                DataSet ds = new System.Data.DataSet();
                sda.Fill(ds, "Client");
                dvgclient.DataSource = ds.Tables[0];
            }
           



        }
        public void buttonoff()
        {
            button4.Visible = false;
            button5.Visible = false;

        }
        public void buttonon()
        {
            button4.Visible = true;
            button5.Visible = true;

        }

        private void txtrecherche_Leave(object sender, EventArgs e)
        {
            if (txtrecherchecl.Text == "")
            {
                txtrecherchecl.Text = "Recherche";
                txtrecherchecl.ForeColor = Color.Black;
            }
        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if (txtrecherchecl.Text == "Recherche")
            {
                txtrecherchecl.Text = "";
                txtrecherchecl.ForeColor = Color.Black;
            }
        }
        public void actualiserclient()
        {
            string sqlselect = "select * from Client";
            SqlDataAdapter sda = new SqlDataAdapter(sqlselect, conn);
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds, "Client");
            dvgclient.DataSource = ds.Tables[0];
        }
        private void button2_Leave(object sender, EventArgs e)
        {
            actualiserclient();
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            actualiserclient();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
