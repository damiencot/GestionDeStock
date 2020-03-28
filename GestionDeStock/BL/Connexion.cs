using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class Connexion
    {

        public bool connexionValide(BddStockContext bdd, string Nom, string password)
        {
            //Nom_Utilisateur
            //Mot_De_Passe
            Utilisateur user = new Utilisateur();
            user.Nom_Utilisateur = Nom;
            user.Nom_Utilisateur = password;
            //Si le Nom et Mot de passe existe dans la BDD
            if(bdd.Utilisateurs.SingleOrDefault(s=>s.Nom_Utilisateur == Nom && s.Mot_De_Passe == password) != null)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
