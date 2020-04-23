using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class GestionCategorie
    {
        private BddStockContext bdd = new BddStockContext();
        private Categorie classCategorie;
        //private Produit produitTable;


        public bool addCategorie(string nomCat)
        {
            classCategorie = new Categorie();
            classCategorie.Nom_Categorie = nomCat;
            if(bdd.Categories.SingleOrDefault(s => s.Nom_Categorie == nomCat)== null)
            {
                bdd.Categories.Add(classCategorie);
                bdd.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void updateCategorie(int id, string nomCat)
        {
            classCategorie = new Categorie();
            classCategorie = bdd.Categories.SingleOrDefault(s => s.ID_Categorie == id); //verifier si id est deja present
            if (classCategorie != null)//existe
            {
                classCategorie.Nom_Categorie = nomCat;
                bdd.SaveChanges();
            }
        }

        public void deleteCategorie(int id)
        {
            classCategorie = new Categorie();
            classCategorie = bdd.Categories.SingleOrDefault(s => s.ID_Categorie == id);
            if (classCategorie != null) //existe
            {
                bdd.Categories.Remove(classCategorie);//delete Produit
                bdd.SaveChanges();
            }
        }
    }

}
