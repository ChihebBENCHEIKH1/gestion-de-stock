using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_client
    {
        private dbStockContext db=new dbStockContext();
        private Client c;
        public bool AjouterClient(string nom,string prenom,string adr,string ville,string telephone,string pays,string mail)
        {
            c = new Client();
            c.Adresse_Client = adr;
            c.Nom_Client = nom;
            c.Prenom_Client = prenom;
            c.Telephonne_Client = telephone;
            c.Ville_Client = ville;
            c.Pays_Client = pays;
            c.Email= mail;
            if(db.Clients.SingleOrDefault(s=>s.Nom_Client==nom && c.Prenom_Client==prenom)==null)
            {
                db.Clients.Add(c);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public void Modifier_client(int id,string nom, string prenom, string adr, string ville, string telephone, string pays, string mail)
        {
            c = new Client();
            c = db.Clients.SingleOrDefault(s => s.Nom_Client == nom && s.Prenom_Client==prenom );
            if (c != null)
            {
                c.Nom_Client = nom;
                c.Prenom_Client = prenom;
                c.Adresse_Client = adr;
                c.Ville_Client = ville;
                c.Telephonne_Client = telephone;
                c.Pays_Client = pays;
                c.Email = mail;
                db.SaveChanges();
            }
            

        }
        public void Supprimer_client(int id)
        {
            c = new Client();
            c = db.Clients.SingleOrDefault(s => s.ID_Client == id);
            if (c != null)
            {
                db.Clients.Remove(c);
                db.SaveChanges();
            }


        }

    }
}
