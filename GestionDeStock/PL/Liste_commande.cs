using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace GestionDeStock.PL
{
    public partial class Liste_commande : UserControl
    {
        private static Liste_commande user_liste_commande;
        private dbStockContext db;
        public static Liste_commande Instance
        {
            get
            {
                if(user_liste_commande == null)
                {
                    user_liste_commande = new Liste_commande();
                }
                return user_liste_commande;
            }
        }
        public Liste_commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
        public void remmplirData()
        {
            Client c = new Client();
            string nomPrenom;
            foreach(var lc in db.Commandes)
            {
                c=db.Clients.SingleOrDefault(s=>s.ID_Client==lc.ID_Client);
                nomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                dvgcommande.Rows.Add(lc.ID_Commande, lc.DATE_Commande, nomPrenom, lc.Total_HT, lc.TVA, lc.Total_TTC);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var listecommande = db.Commandes.ToList();
            if(dvgcommande.Rows.Count!=0)
            {
                listecommande = listecommande.Where(s => s.DATE_Commande.Date >= dd.Value.Date && s.DATE_Commande.Date <= df.Value.Date).ToList();
                dvgcommande.Rows.Clear();
                Client c = new Client();
                string nomPrenom;
                foreach (var lc in listecommande)
                {
                    c = db.Clients.SingleOrDefault(s => s.ID_Client == lc.ID_Client);
                    nomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                    dvgcommande.Rows.Add(lc.ID_Commande, lc.DATE_Commande, nomPrenom, lc.Total_HT, lc.TVA, lc.Total_TTC);
                }
            }
        }

        private void Liste_commande_Load(object sender, EventArgs e)
        {
            remmplirData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttajoute_Click(object sender, EventArgs e)
        {
            PL.Detail_commande detail = new Detail_commande(this);
            detail.ShowDialog();
            
        }

        private void buttselectTout_Click(object sender, EventArgs e)
        {
            rap.FRM_rapport frmrap = new rap.FRM_rapport();
            db = new dbStockContext();
            try 
            {
                int idcommande = (int)dvgcommande.CurrentRow.Cells[0].Value;
                var commande = db.Commandes.Single(s => s.ID_Commande == idcommande);
                var clientCommande = db.Clients.Single(s => s.ID_Client == commande.ID_Client);
                var listedetails=db.Details_Commande.Where(s => s.ID_Commande == idcommande).ToList();
                frmrap.RPTfichier.LocalReport.ReportEmbeddedResource = "GestionDeStock.rap.RPT_commande.rdlc";
                frmrap.RPTfichier.LocalReport.DataSources.Add(new ReportDataSource("Datacommande",listedetails));
                ReportParameter NomPrenom = new ReportParameter("NomprenomClient", clientCommande.Nom_Client + " " + clientCommande.Prenom_Client);
                ReportParameter adresse = new ReportParameter("AdresseC", clientCommande.Adresse_Client );
                ReportParameter telephone = new ReportParameter("TelephoneC", clientCommande.Telephonne_Client );
                ReportParameter mail = new ReportParameter("MailC", clientCommande.Email);
                ReportParameter idcomm = new ReportParameter("idCommande", idcommande.ToString());
                ReportParameter dateCommande = new ReportParameter("DateCommande", commande.DATE_Commande.ToString());
                ReportParameter totalht = new ReportParameter("totalht", commande.Total_HT);
                ReportParameter tva = new ReportParameter("tva", commande.TVA);
                ReportParameter totalttc = new ReportParameter("totalttc", commande.Total_TTC);
                frmrap.RPTfichier.LocalReport.SetParameters(new ReportParameter[] { NomPrenom, adresse, telephone, mail, idcomm, dateCommande, totalht, tva, totalttc });//save parameters
                frmrap.RPTfichier.RefreshReport();
                frmrap.ShowDialog();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dvgcommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
