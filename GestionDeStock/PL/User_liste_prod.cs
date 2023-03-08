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
using System.Configuration;
using Microsoft.Reporting.WinForms;
using Microsoft.Office.Interop.Excel;

namespace GestionDeStock.PL
{
    public partial class User_liste_prod : UserControl
    {
        private static User_liste_prod userprod;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-672AMT3;Initial Catalog=GESTION_DE_STOCK;Integrated Security=True");
        private dbStockContext db;
        public static User_liste_prod Instance
        {
            get
            {
                if (userprod == null)
                {
                    userprod = new User_liste_prod();
                }
                return userprod;
            }
        }

        public object ConfigurationManager { get; private set; }

        public User_liste_prod()
        {
            InitializeComponent();
            db=new dbStockContext();
           
        }
        public int id;
        public void actualiserdvgprod()
        {

            string v = "select Id_Produit as ID,Nom_Produit as Nom,Quantite_Produit as Quantité,Prix_Produit as Prix, Nom_Categorie as Categorie from Produit,Categorie  where Categorie.ID_CATEGORIE=Produit.ID_CATEGORIE" ;
            SqlDataAdapter sda = new SqlDataAdapter(v, conn);
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds);
            dvgprod.DataSource = ds.Tables[0];
            


        }
        public void buttonvisiblityoff()
        {
            buttsupprimer.Visible = false;
            buttsupprimer.Visible = false;
        }
        public void buttonvisiblityon()
        {
            buttsupprimer.Visible = true;
            buttsupprimer.Visible = true;
        }
        private void User_liste_prod_Load(object sender, EventArgs e)
        {
            
           
                
            actualiserdvgprod(); 




        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (BL.Myconnection.type == "A")
            {
                Produit pr = new Produit();
                if (selectveriff() != null)
                {
                    MessageBox.Show(selectveriff(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PL.FRM_prod fRM_Prod = new PL.FRM_prod();
                    fRM_Prod.btnactualiser.Visible = false;

                    fRM_Prod.lbltitre.Text = "Modifier Produit";
                    for (int i = 0; i < dvgprod.Rows.Count; i++)
                    {
                        if ((bool)dvgprod.Rows[i].Selected == true)
                        {
                            int id = (int)dvgprod.Rows[i].Cells[0].Value;
                            pr = db.Produits.SingleOrDefault(s => s.Id_Produit == id);
                            if (pr != null)
                            {
                                fRM_Prod.comboBox1.Text = dvgprod.Rows[i].Cells[4].Value.ToString();
                                fRM_Prod.textnomProd.Text = dvgprod.Rows[i].Cells[1].Value.ToString();
                                fRM_Prod.textprix.Text = dvgprod.Rows[i].Cells[3].Value.ToString();
                                fRM_Prod.quantite = (int)dvgprod.Rows[i].Cells[2].Value;
                                MemoryStream ms = new MemoryStream(pr.Image_Produit);
                                fRM_Prod.picproduit.Image = Image.FromStream(ms);
                            }

                        }


                        fRM_Prod.ShowDialog();

                    }

                }


            }
            else if (BL.Myconnection.type == "U")
                MessageBox.Show("Tu n'as pas le droit d'access");
                 
        }
            
    public string selectveriff()
            {
                int nbselect = 0;
                for (int i = 0; i < dvgprod.Rows.Count; i++)
                {
                    if ((bool)dvgprod.Rows[i].Selected == true)
                    {
                        nbselect++;

                    }
                }
                if (nbselect == 0)
                    return "Selectionner le Produit";
                if (nbselect > 1)
                {
                    return "Selectionner un seul produit à modifier";
                }


                return null;
            }

            

            
       

        private void buttajoute_Click(object sender, EventArgs e)
        {
            FRM_prod fr = new FRM_prod();
            fr.Show();
           
        }

        private void buttafficher_Click(object sender, EventArgs e)
        {
            
        }

        private void comborecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comborecherche.SelectedIndex == 0)
            {

                actualiserdvgprod();
            }
        }

        private void buttafficher_Click_1(object sender, EventArgs e)
        {
            Produit pr = new Produit();
            if (selectveriff() != null)
            {
                MessageBox.Show(selectveriff(), "Affiche", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                for (int i = 0; i < dvgprod.Rows.Count; i++)
                {
                    if ((bool)dvgprod.Rows[i].Selected == true)
                    {
                        int idSelect = (int)dvgprod.Rows[i].Cells[0].Value;
                        pr = db.Produits.SingleOrDefault(s => s.Id_Produit == idSelect);
                        if (pr != null)
                        {
                            FRM_affichePhoto fr = new FRM_affichePhoto();
                            MemoryStream ms = new MemoryStream(pr.Image_Produit);
                            fr.imageProduit.Image = Image.FromStream(ms);
                            fr.nomProduit.Text = dvgprod.Rows[i].Cells[1].Value.ToString();
                            fr.ShowDialog();
                        }

                    }
                }
                actualiserdvgprod();
            }
        }

        private void buttajoute_Click_1(object sender, EventArgs e)
        {
            FRM_prod fr = new FRM_prod();
            fr.ShowDialog();
        }

        private void comborecherche_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if(comborecherche.SelectedIndex == 0)
            {
                actualiserdvgprod();
            }
            else if (comborecherche.SelectedIndex == 1)
            {
                txtrechercheprod.Enabled = true;
                string v = "select Id_Produit,Nom_Produit,Quantite_Produit,Prix_Produit, Nom_Categorie from Produit,Categorie  where Categorie.ID_CATEGORIE=Produit.ID_CATEGORIE and  Nom_Produit like " + '\'' + txtrechercheprod.Text + '%' + '\'';
                SqlDataAdapter sda = new SqlDataAdapter(v, conn);
                DataSet ds = new System.Data.DataSet();
                sda.Fill(ds);
                dvgprod.DataSource = ds.Tables[0];
            }

        }

        private void buttsupprimer_Click(object sender, EventArgs e)
        {
            if (BL.Myconnection.type == "A")
            {
                if (selectveriff() == "Selectionner le Produit")
                {
                    MessageBox.Show(selectveriff(), "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Voulez vous supprimer ces données", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        for (int i = 0; i < dvgprod.Rows.Count; i++)
                        {
                            if ((bool)dvgprod.Rows[i].Selected == true)
                            {
                                BL.Cls_ajouter_produit cls = new BL.Cls_ajouter_produit();
                                cls.supprimerProd((int)dvgprod.Rows[i].Cells[0].Value);
                            }
                        }
                        actualiserdvgprod();

                    }
                    else
                    {
                        MessageBox.Show("Suppression annulée", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }


                }
            }
            else if (BL.Myconnection.type == "U")
                MessageBox.Show("Tu n'as pas le droit d'access");
        }
    

        private void txtrechercheprod_TextChanged(object sender, EventArgs e)
        {


            txtrechercheprod.Enabled = true;
            string v = "select Id_Produit,Nom_Produit,Quantite_Produit,Prix_Produit, Nom_Categorie from Produit,Categorie  where Categorie.ID_CATEGORIE=Produit.ID_CATEGORIE and  Nom_Produit like " + '\'' + txtrechercheprod.Text + '%' + '\'';
            SqlDataAdapter sda = new SqlDataAdapter(v, conn);
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds);
            dvgprod.DataSource = ds.Tables[0];

        }

        private void txtrechercheprod_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void buttselect_Click(object sender, EventArgs e)
        {
            rap.FRM_rapport frmm = new rap.FRM_rapport();
            Produit pr = new Produit();
            int idSelected=0;
            string nomcategorie="" ;
            db = new dbStockContext();
            if (selectveriff() != null)
            {
                MessageBox.Show(selectveriff(), "Imprimer produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < dvgprod.Rows.Count; i++)
                {
                    if ((bool)dvgprod.Rows[i].Selected == true)
                    {
                         idSelected =(int) dvgprod.Rows[i].Cells[0].Value;
                        nomcategorie = dvgprod.Rows[i].Cells[4].Value.ToString();


                    }
                }
                pr = db.Produits.SingleOrDefault(s => s.Id_Produit == idSelected);
                if(pr!=null)
                {
                    string imageProduit = Convert.ToBase64String(pr.Image_Produit);
                    frmm.RPTfichier.LocalReport.ReportEmbeddedResource = "GestionDeStock.rap.RPT_produit.rdlc";
                    ReportParameter pcategorie = new ReportParameter("RPCategorie",nomcategorie);
                    ReportParameter pnom = new ReportParameter("RPNom",pr.Nom_Produit);
                    ReportParameter pquantite = new ReportParameter("RPQuantite",pr.Quantite_Produit.ToString());
                    ReportParameter pprix = new ReportParameter("RPprix",pr.Prix_Produit);
                    ReportParameter pimage = new ReportParameter("RPImage",imageProduit);
                    frmm.RPTfichier.LocalReport.SetParameters(new ReportParameter[] {pcategorie,pnom,pquantite,pprix,pimage});
                    frmm.RPTfichier.RefreshReport();
                    frmm.ShowDialog();

                }
                
            }
        }

        private void buttselectTout_Click(object sender, EventArgs e)
        {
            rap.FRM_rapport frm = new rap.FRM_rapport();
            db = new dbStockContext();
            try
            {

                var listeproduit = db.Produits.ToList();
                frm.RPTfichier.LocalReport.ReportEmbeddedResource = "GestionDeStock.rap.produits.rdlc";
                frm.RPTfichier.LocalReport.DataSources.Add(new ReportDataSource("Databaseproduit", listeproduit));
                ReportParameter date = new ReportParameter("Date", DateTime.Now.ToString());
                frm.RPTfichier.LocalReport.SetParameters(new ReportParameter[] { date });
                frm.RPTfichier.RefreshReport();
                frm.ShowDialog();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void buttexcel_Click(object sender, EventArgs e)
        {
            db = new dbStockContext();
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    ws.Cells[1, 1] = "ID produit";
                    ws.Cells[1, 2] = "Nom produit";
                    ws.Cells[1, 3] = "Quantité";
                    ws.Cells[1, 4] = "Prix";
                    var listeproduits = db.Produits.ToList();
                    int i = 2;
                    foreach (var l in listeproduits)
                    {
                        ws.Cells[i, 1] = l.Id_Produit;
                        ws.Cells[i, 2] = l.Nom_Produit;
                        ws.Cells[i, 3] = l.Quantite_Produit;
                        ws.Cells[i, 4] = l.Prix_Produit;
                        i++;
                    }
                    ws.Range["A1:D1"].Interior.Color = Color.Teal;
                    wb.SaveAs(sfd.FileName);
                    app.Quit();
                    MessageBox.Show("Sauvgardage avec success dans Excel", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void dvgprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            actualiserdvgprod();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void txtrechercheprod_Enter(object sender, EventArgs e)
        {
            if(txtrechercheprod.Text=="Recherche")
            {
                txtrechercheprod.Text = "";
                txtrechercheprod.ForeColor = Color.Black;
            }
        }

        private void txtrechercheprod_Leave(object sender, EventArgs e)
        {
            if (txtrechercheprod.Text == "")
            {
                txtrechercheprod.Text = "Recherche";
                txtrechercheprod.ForeColor = Color.Black;
            }
        }
    }
}
