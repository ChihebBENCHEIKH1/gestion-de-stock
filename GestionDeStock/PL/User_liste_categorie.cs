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
using Microsoft.Reporting.WinForms;
using Microsoft.Office.Interop.Excel;

namespace GestionDeStock.PL
{
    public partial class User_liste_categorie : UserControl
    {
        private static User_liste_categorie usercat;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-672AMT3;Initial Catalog=GESTION_DE_STOCK;Integrated Security=True");
        private dbStockContext db;
        public static User_liste_categorie Instance
        {
            get
            {
                if (usercat == null)
                {
                    usercat = new User_liste_categorie();
                }
                return usercat;

            }
        }
        public User_liste_categorie()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PL.Ajouter_categorie frm = new Ajouter_categorie(this);
            if (dvgcategorie.Columns[e.ColumnIndex].Name == "Modifier")
            {
                frm.idcategorie = (int)dvgcategorie.Rows[e.RowIndex].Cells[0].Value;
                frm.lbltitre.Text = "Modifier categorie";
                frm.textnom.Text = dvgcategorie.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.ShowDialog();
            }
            else if (dvgcategorie.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                BL.CLS_categorie cls = new BL.CLS_categorie();
                DialogResult pr = MessageBox.Show("Voulez vous supprimer ces données", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pr == DialogResult.Yes)
                {
                    int idcategorie = (int)dvgcategorie.Rows[e.RowIndex].Cells[0].Value;
                    int p = db.Produits.Count(s => s.ID_CATEGORIE == idcategorie);
                    if (p == 0)
                    {
                        cls.SupprimerCategorie(idcategorie);
                        MessageBox.Show("Categorie supprimer", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        remplirgrid();

                    }
                    else
                    {
                        DialogResult dial = MessageBox.Show("Il y a " + p + " dans cette categorie ,Voulez vous vraiment supprimer", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dial == DialogResult.Yes)
                        {
                            cls.SupprimerCategorie(idcategorie);
                            MessageBox.Show("Categorie supprimer", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            remplirgrid();
                        }
                        else
                        {
                            MessageBox.Show("Suppression annulé", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }

            }
            remplirgrid();
        }

        private void txtrechercheprod_Enter(object sender, EventArgs e)
        {
            if (txtrecherchecat.Text == "Recherche")
            {
                txtrecherchecat.Text = "";
                txtrecherchecat.ForeColor = Color.Silver;
            }
        }
        public void remplirgrid()
        {
            string sqlselect = "select * from Categorie";
            SqlDataAdapter sda = new SqlDataAdapter(sqlselect, conn);
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds, "Categorie");
            dvgcategorie.DataSource = ds.Tables[0];
        }
        private void User_liste_categorie_Load(object sender, EventArgs e)
        {
            remplirgrid();
        }

        private void dvgcategorie_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void buttajoute_Click(object sender, EventArgs e)
        {
            PL.Ajouter_categorie cat = new Ajouter_categorie(this);
            cat.ShowDialog();
        }

        private void txtrecherchecat_TextChanged(object sender, EventArgs e)
        {
            string requette = "select * from Categorie where Nom_Categorie like \'" + txtrecherchecat.Text + "%\'";
            SqlDataAdapter sda = new SqlDataAdapter(requette, conn);
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds, "Categorie");
            dvgcategorie.DataSource = ds.Tables[0];
        }

        private void buttselectTout_Click(object sender, EventArgs e)
        {
            rap.FRM_rapport frm = new rap.FRM_rapport();
            db = new dbStockContext();
            try
            {
                var listecategorie = db.Categories.ToList();
                int nbcategorie = db.Categories.Count();
                frm.RPTfichier.LocalReport.ReportEmbeddedResource = "GestionDeStock.rap.liste_categorie.rdlc";
                frm.RPTfichier.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Databasecategorie", listecategorie));
                ReportParameter date = new ReportParameter("Date", DateTime.Now.ToString());
                ReportParameter nb = new ReportParameter("NBcategorie", nbcategorie.ToString());
                frm.RPTfichier.LocalReport.SetParameters(new ReportParameter[] { date, nb });
                frm.RPTfichier.RefreshReport();
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string selectveriff()
        {
            int nbselect = 0;
            for (int i = 0; i < dvgcategorie.Rows.Count; i++)
            {
                if ((bool)dvgcategorie.Rows[i].Selected == true)
                {
                    nbselect++;

                }
            }
            if (nbselect == 0)
                return "Selectionner la categorie";
            if (nbselect > 1)
            {
                return "Selectionner une seule categorie à modifier";
            }


            return null;
        }




        private void buttselect_Click(object sender, EventArgs e)
        {
            db = new dbStockContext();
            string nomcategorie = "";
            int idcategorie = 0;
            if (selectveriff() != null)
            {
                MessageBox.Show(selectveriff(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SaveFileDialog sf = new SaveFileDialog() { Filter = "Excel workbook|*xlsx", ValidateNames = true })
                {
                    if (DialogResult.OK == sf.ShowDialog())
                    {
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)app.ActiveSheet;
                        app.Visible = false;
                        for (int i1 = 0; i1 < dvgcategorie.Rows.Count; i1++)
                        {
                            if ((bool)dvgcategorie.Rows[i1].Selected == true)
                            {
                                nomcategorie = dvgcategorie.Rows[i1].Cells[1].Value.ToString();
                                idcategorie = (int)dvgcategorie.Rows[i1].Cells[0].Value;
                            }
                        }
                        ws.Range["A1:D1"].Merge();
                        ws.Range["A1:D1"].Value = nomcategorie;
                        ws.Cells[2, 1] = "Id Produit";
                        ws.Cells[2, 2] = "Nom Produit";
                        ws.Cells[2, 3] = "Quantité";
                        ws.Cells[2, 4] = "Prix";
                        var listeproduits = db.Produits.Where(s => s.ID_CATEGORIE == idcategorie).ToList();
                        int i = 3;
                        foreach(var pl in listeproduits)
                        {
                            ws.Cells[i, 1] =pl.Id_Produit;
                            ws.Cells[i, 2] =pl.Nom_Produit;
                            ws.Cells[i, 3] =pl.Quantite_Produit;
                            ws.Cells[i, 4] =pl.Prix_Produit;
                            i++;
                        }
                        ws.Range["A2:D2"].Interior.Color=Color.Teal;
                        ws.Range["A2:D2"].Font.Color=Color.White;
                        ws.Range["A2:D2"].Font.Size = 15;
                        ws.Range["A1:D1"].Interior.Color=Color.DarkGreen;
                        ws.Range["A1:D1"].Font.Color=Color.White;
                        ws.Range["A1:D1"].Font.Size = 15;
                        ws.Range["A:D"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        ws.Range["A2:D2"].ColumnWidth = 16;
                        wb.SaveAs(sf.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false);
                        app.Quit();
                        MessageBox.Show("Sauvgarde avec success dans Excel", "Sauvgardage", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                    }
                }
            }
        }

        private void txtrecherchecat_Leave(object sender, EventArgs e)
        {
            if(txtrecherchecat.Text=="")
            {
                txtrecherchecat.Text = "Recherche";
                txtrecherchecat.ForeColor = Color.Black;
            }
        }
    }
}

