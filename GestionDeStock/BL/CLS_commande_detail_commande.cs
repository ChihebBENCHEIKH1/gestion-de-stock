using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
     class CLS_commande_detail_commande
    {
        private dbStockContext db = new dbStockContext();
        private Commande clscommande;
        private Details_Commande details;
        public int idcommande;
        public void ajouterCommande(DateTime dateCommande,int idclient,string totalht,string tva,string totalttc)
        {
            clscommande = new Commande();
            clscommande.DATE_Commande = dateCommande;
            clscommande.ID_Client= idclient;
            clscommande.Total_HT= totalht;
            clscommande.TVA= tva;
            clscommande.Total_TTC= totalttc;
            db.Commandes.Add(clscommande);
           
            db.SaveChanges(); 
            idcommande = clscommande.ID_Commande;
        }
        public void Ajouter_detail(int idproduit,string NomProduit,int quantite,string prix,string remis,string total)
        {
            details = new Details_Commande();
            details.ID_Commande = idcommande;
            details.ID_Produit= idproduit;
            details.Quantite = quantite;
            details.Nom_Produit = NomProduit;
            details.Prix = prix;
            details.Remise = remis;
            details.Total = total;
            
            db.Details_Commande.Add(details);
            db.SaveChanges();

        }
    }
}
