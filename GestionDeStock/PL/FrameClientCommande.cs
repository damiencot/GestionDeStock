using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FrameClientCommande : Form
    {
        private BddStockContext bdd;
        public FrameClientCommande()
        {
            InitializeComponent();
            bdd = new BddStockContext();
        }

        private void FrameClientCommande_Load(object sender, EventArgs e)
        {
            bdd = new BddStockContext();
            //Vide le data Grid
            data_grid_client_commande.Rows.Clear();
            //Afficher nom categorie à partir de idCategorie
            //Categorie categorie = new Categorie();

            foreach (var i in bdd.Clients)
            {
                //categorie = bdd.Categories.SingleOrDefault(s => s.ID_Categorie == produit.ID_Categorie);//si idCategorie present dans la table Produit = IdCategorie dans table Categorie
                //ajouter les clients  a la liste dataGrid
                data_grid_client_commande.Rows.Add(i.ID_Client, i.Nom_Client, i.Prenom_Client, i.Adresse_Client, i.Telephone_Client, i.Email_Client, i.Pays_Client, i.Ville_Client);
            }
        }

        private void data_grid_client_commande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_grid_client_commande_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
