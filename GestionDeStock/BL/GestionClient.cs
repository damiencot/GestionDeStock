using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class GestionClient
    {
        private BddStockContext bdd = new BddStockContext();
        private Client clientTable;

        //Add Client
        public bool addClient(string nom, string prenom, string adresse, string telephone, string email, string pays, string ville)
        {
            clientTable = new Client();
            clientTable.Nom_Client = nom;
            clientTable.Prenom_Client = prenom;
            clientTable.Adresse_Client = adresse;
            clientTable.Telephone_Client = telephone;
            clientTable.Email_Client = email;
            clientTable.Pays_Client = pays;
            clientTable.Ville_Client = ville;

            //Verifie si le nom et prenom existe dans la BDD
            if (bdd.Clients.SingleOrDefault(s => s.Nom_Client == nom && s.Prenom_Client == prenom) == null)// si n'existe pas
            {
                bdd.Clients.Add(clientTable);// Ajouter dans la BDD
                bdd.SaveChanges();//Enregistre dans la BDD
                return true;
            }else // si existe dans la BDD
            {
                return false;
            }
        }

    }
}
