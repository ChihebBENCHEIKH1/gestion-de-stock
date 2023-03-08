using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class Cls_ajouter_produit
    {
        private dbStockContext db=new dbStockContext();
        private Produit prod;
        public bool Ajouterprod(string nomP,int quantite,string prix,byte[] image, int idcategorie)//pour sauvgarder une image en BD elle doit etre en byte
        {
            prod=new Produit();
            prod.Prix_Produit = prix.ToString();
            prod.Quantite_Produit = quantite;
            prod.Image_Produit= image;
            prod.ID_CATEGORIE = idcategorie;
            prod.Nom_Produit = nomP;
            if(db.Produits.SingleOrDefault(s=>s.Nom_Produit==nomP)==null)
            {
                db.Produits.Add(prod);
                db.SaveChanges();
                return true;
            }
            else
                return false;


        }
        public void Modifier_produit(int idp, string nomp,int quantite,string prix, byte[] image, int id_categorie)
        {
           Produit  pr = new Produit();
            pr = db.Produits.SingleOrDefault(s => s.Nom_Produit == nomp);
            if(pr!=null)
            {
                pr.Nom_Produit = nomp;
                pr.Quantite_Produit = quantite;
                pr.Image_Produit= image;
                pr.ID_CATEGORIE = id_categorie;
                pr.Prix_Produit = prix;
                db.SaveChanges();

            }
        }
        public void supprimerProd(int id)
        {
            Produit c = new Produit();
            c = db.Produits.SingleOrDefault(s => s.Id_Produit == id);
            if(c!=null)
            {
                db.Produits.Remove(c);
                db.SaveChanges();

            }

        }
    }
}
