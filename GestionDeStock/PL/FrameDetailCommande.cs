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
    public partial class FrameDetailCommande : Form
    {
        private BddStockContext bdd;
        public FrameDetailCommande()
        {
            InitializeComponent();
            bdd = new BddStockContext();
        }

        //Function remplier data grid
        private void actualiserDataGrid()
        {
            bdd = new BddStockContext();
            //Vide le data Grid
            data_grid_commande_produit.Rows.Clear();

            foreach (var pr in bdd.Produits)
            {
                //categorie = bdd.Categories.SingleOrDefault(s => s.ID_Categorie == produit.ID_Categorie);//si idCategorie present dans la table Produit = IdCategorie dans table Categorie
                //ajouter les clients  a la liste dataGrid
                data_grid_commande_produit.Rows.Add(pr.ID_Produit, pr.Nom_Produit, pr.Quantite_Produit, pr.Prix_Produit);
            }
        }

        private void FrameDetailCommande_Load(object sender, EventArgs e)
        {
            actualiserDataGrid();
        }

        private void btn_connexion_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_parcourire_client_Click(object sender, EventArgs e)
        {
            PL.FrameClientCommande frm = new PL.FrameClientCommande();
            frm.ShowDialog();
            //afficher les informations de client
            txt_nom_client.Text = frm.data_grid_client_commande.CurrentRow.Cells[1].Value.ToString();
            txt_prenom_client.Text = frm.data_grid_client_commande.CurrentRow.Cells[2].Value.ToString();
            txt_telephone_client.Text = frm.data_grid_client_commande.CurrentRow.Cells[3].Value.ToString();
            txt_email_client.Text = frm.data_grid_client_commande.CurrentRow.Cells[4].Value.ToString();
            txt_pays_client.Text = frm.data_grid_client_commande.CurrentRow.Cells[5].Value.ToString();
            txt_ville_client.Text = frm.data_grid_client_commande.CurrentRow.Cells[6].Value.ToString();
        }

        private void data_grid_commande_produit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
