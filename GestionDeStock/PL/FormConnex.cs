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
    public partial class FormConnex : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-672AMT3;Initial Catalog=GESTION_DE_STOCK;Integrated Security=True");
        private dbStockContext db;
        BL.CLS_connexion c=new BL.CLS_connexion();
        private Form formmenu;
        private UserControl fr;
        public FormConnex( Form menu)
        {
            db=new dbStockContext();
            InitializeComponent();
            this.formmenu = menu;   
        }   
        string testobligatoire()
        {
            if (txtnom.Text == "" || txtnom.Text == "Nom d'Utilisateur")
            {
                return "Entrer votre Nom";
            }
            if (txtmdp.Text == "" || txtmdp.Text == "Mot de Passe")
            {
                return  "Entrer votre Mot de Passe";
            }
            return null;
        }
        private void FormConnex_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if(txtnom.Text=="Nom d'Utilisateur")
            {
                txtnom.Text = "";
                txtnom.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtmdp_Enter(object sender, EventArgs e)
        {
            if(txtmdp.Text=="Mot de Passe")
            {
                txtmdp.Text = "";
                txtmdp.UseSystemPasswordChar = false;
                txtmdp.PasswordChar = '*';
                txtmdp.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if(txtnom.Text=="")
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
            if(txtmdp.Text=="")
            {
                txtmdp.Text = "Mot de Passe";
                txtmdp.ForeColor = Color.Silver;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (testobligatoire() == null)
                {
                    using (con)
                    {
                        SqlCommand cmd = new SqlCommand("sp_role_login", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        cmd.Parameters.AddWithValue("@uname", txtnom.Text);
                        cmd.Parameters.AddWithValue("@upass", txtmdp.Text);
                        SqlDataReader rd = cmd.ExecuteReader();
                        if (rd.HasRows)
                        {
                            rd.Read();
                            if (rd[3].ToString() == "admin")
                            {
                                MessageBox.Show("Connexion réussi", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                BL.Myconnection.type = "A";
                                (formmenu as Form1).activerForm();


                            }
                            else if (rd[3].ToString()=="utilisateur")
                            {
                                MessageBox.Show("Connexion réussi", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                BL.Myconnection.type = "U";
                                (formmenu as Form1).activerFormUtilisateur();
                            }
                            this.Close();
                        }
                        else
                            MessageBox.Show("Erreur du connexion");

                    }
                }
                else
                {
                    MessageBox.Show(testobligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void button1_Enter(object sender, EventArgs e)
        {
          
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtmdp_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (testobligatoire() == null)
                    {
                        using (con)
                        {
                            SqlCommand cmd = new SqlCommand("sp_role_login", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            con.Open();
                            cmd.Parameters.AddWithValue("@uname", txtnom.Text);
                            cmd.Parameters.AddWithValue("@upass", txtmdp.Text);
                            SqlDataReader rd = cmd.ExecuteReader();
                            if (rd.HasRows)
                            {
                                rd.Read();
                                if (rd[3].ToString() == "admin")
                                {
                                    MessageBox.Show("Connexion réussi", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    BL.Myconnection.type = "A";
                                    (formmenu as Form1).activerForm();


                                }
                                else
                                {
                                    MessageBox.Show("Connexion réussi", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    BL.Myconnection.type = "U";
                                    (formmenu as Form1).activerFormUtilisateur();
                                }
                                this.Close();
                            }
                            else
                                MessageBox.Show("Erreur du connexion");

                        }
                    }
                    else
                    {
                        MessageBox.Show(testobligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
