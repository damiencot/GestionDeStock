using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class GestionProduit
    {
        private BddStockContext bdd = new BddStockContext();
        private Produit produitTable;

        public bool addProduit(string nom, int quantite, int prix, byte[] imageProduit, int idCategorie)
        {
            produitTable = new Produit();
            produitTable.Nom_Produit = nom;
            produitTable.Quantite_Produit = quantite;
            produitTable.Prix_Produit = prix;
            produitTable.Image_Produit = imageProduit;
            produitTable.ID_Categorie = idCategorie;


            //Verifie si produit existe dans la BDD
            if (bdd.Produits.SingleOrDefault(s => s.Nom_Produit == nom) == null)// si n'existe pas
            {
                bdd.Produits.Add(produitTable);// Ajouter dans la BDD
                bdd.SaveChanges();//Enregistre dans la BDD
                return true;
            }
            else // si existe dans la BDD
            {
                return false;
            }
        }

        public void updateProduit(int id, string nom, int quantite, int prix, byte[] imageProduit, int idCategorie )
        {
            produitTable = new Produit();
            produitTable = bdd.Produits.SingleOrDefault(s => s.ID_Produit == id); //verifier si id est deja present
            if (produitTable != null)//existe
            {
                produitTable.Nom_Produit = nom;
                produitTable.Quantite_Produit = quantite;
                produitTable.Prix_Produit = prix;
                produitTable.Image_Produit = imageProduit;
                produitTable.ID_Categorie = idCategorie;
                bdd.SaveChanges();
            }
        }

        public void deleteProduit(int id)
        {
            produitTable = new Produit();
            produitTable = bdd.Produits.SingleOrDefault(s => s.ID_Produit == id);
            if (produitTable != null) //existe
            {
                bdd.Produits.Remove(produitTable);//delete Produit
                bdd.SaveChanges();
            }
        }

    }
}
