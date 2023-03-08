using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
     class CLS_aouter_modifier_supprimer_utilisateur
    {
        dbStockContext db = new dbStockContext();
        private PL.User_liste_utilisateur us;
        private Utilisateur utili;
        public bool AjouterUtilisateur(string nomU, string mdpU, string typeU)
        {
            us = new PL.User_liste_utilisateur();
            //int lastindex = (int)us.dvgutilisateur.Rows[0].Cells[0].Value
            //lastindex++;
            Utilisateur utili = new Utilisateur();
            utili.NomUtilisateur=nomU;
            utili.Mot_De_Passe= mdpU;
            utili.type_utilisateur=typeU;
            //utili.idUtilisateur=lastindex;

            if (db.Utilisateurs.SingleOrDefault(s => s.NomUtilisateur == nomU) == null)
            {
                db.Utilisateurs.Add(utili);
                db.SaveChanges();
                return true;
            }
            else
                return false;


        }
        public void Modifier_Utilisateur(int id,string nomU, string mdpU, string typeU)
        {
            utili = new Utilisateur();
            utili = db.Utilisateurs.SingleOrDefault(s => s.idUtilisateur == id);
            if (utili != null)
            {
                utili.NomUtilisateur = nomU;
                utili.Mot_De_Passe = mdpU;
                utili.type_utilisateur = typeU;
               
                db.SaveChanges();

            }
        }
        public void supprimerUtilisateur(int id)
        {
            Utilisateur UTIL = new Utilisateur();
            UTIL= db.Utilisateurs.SingleOrDefault(s => s.idUtilisateur == id);
            if (UTIL!= null)
            {
                db.Utilisateurs.Remove(UTIL);
                db.SaveChanges();

            }

        }
    }
}
