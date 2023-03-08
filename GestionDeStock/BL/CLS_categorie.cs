using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_categorie
    {
        private dbStockContext db=new dbStockContext();
        private Categorie cat;
        public bool Ajoutercategorie(string nomcategorie)
        {
            cat=new Categorie();
            cat.Nom_Categorie=nomcategorie;
            if(db.Categories.SingleOrDefault(s=>s.Nom_Categorie==nomcategorie)==null)
            {
                db.Categories.Add(cat);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ModifierCategorie(int idcategorie,string nomcategorie)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == idcategorie);
            if(cat!=null)
            {
                cat.Nom_Categorie = nomcategorie;
                db.SaveChanges();
            }
        }
        public void SupprimerCategorie(int idcategorie)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == idcategorie);
            if(cat!=null)
            {
                db.Categories.Remove(cat);
                db.SaveChanges();

            }
        }
    }
}
