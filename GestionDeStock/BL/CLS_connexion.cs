using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_connexion
    {
        public bool connexionvalide(dbStockContext db, string nom,string mdp)
        {
            Utilisateur u = new Utilisateur();
            u.NomUtilisateur = nom;
            u.Mot_De_Passe= mdp;
            if (db.Utilisateurs.SingleOrDefault(s => s.NomUtilisateur == nom && s.Mot_De_Passe == mdp) != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
