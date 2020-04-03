using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestionDeStock.PL
{
    public partial class UserListProduit : UserControl
    {
        private static UserListProduit userClient;
        private BddStockContext bdd;


        //Créér une instance pour le userControle
        public static UserListProduit instance
        {
            get
            {
                if (userClient == null)
                {
                    userClient = new UserListProduit();
                }
                return userClient;
            }
        }

        public UserListProduit()
        {
            InitializeComponent();
            bdd = new BddStockContext(); 
        }

        private void UserListProduit_Load(object sender, EventArgs e)
        {
            actualiserDataGrid();
        }

        public void actualiserDataGrid()
        {
            bdd = new BddStockContext();
            //Vide le data Grid
            data_grid_produit.Rows.Clear();
            //Afficher nom categorie à partir de idCategorie
            Categorie categorie = new Categorie();

            foreach (var produit in bdd.Produits)
            {
                categorie = bdd.Categories.SingleOrDefault(s => s.ID_Categorie == produit.ID_Categorie);//si idCategorie present dans la table Produit = IdCategorie dans table Categorie
                //ajouter les clients  a la liste dataGrid
                data_grid_produit.Rows.Add(false, produit.ID_Produit, produit.Nom_Produit, produit.Quantite_Produit, produit.Prix_Produit, categorie.Nom_Categorie);
            }
        }

        public string selectRows()
        {
            int nbrRows = 0;
            for (int i = 0; i < data_grid_produit.Rows.Count; i++)
            {
                if ((bool)data_grid_produit.Rows[i].Cells[0].Value == true)//ligne selectionner
                {
                    nbrRows++; //nbrRows + 1
                }
            }
            if (nbrRows == 0)
            {
                return "Selectionner le produit";
            }
            if (nbrRows > 1)
            {
                return "Selectionner seulement 1 produit";
            }
            return null;
        }


        private void txt_recherche_produit_Enter(object sender, EventArgs e)
        {
            if (txt_recherche_produit.Text == "Rechercher")
            {
                txt_recherche_produit.Text = "";
                txt_recherche_produit.ForeColor = Color.Black;

            }
        }

        private void btn_ajouter_produit_Click(object sender, EventArgs e)
        {
            PL.FrameAjouterModifierProduit frmAjout = new FrameAjouterModifierProduit(this);
            frmAjout.ShowDialog();
        }

        private void btn_modifier_produit_Click(object sender, EventArgs e)
        {
            Produit classProduit = new Produit();

            if(selectRows() != null)
            {
                MessageBox.Show(selectRows(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                FrameAjouterModifierProduit frmProduit = new FrameAjouterModifierProduit(this);
                frmProduit.lbl_titre_frameAjoutModifier.Text = "Modifier Produit";
                for (int i = 0; i < data_grid_produit.Rows.Count; i++)//verifie liggne selectionner
                {
                    if ((bool)data_grid_produit.Rows[i].Cells[0].Value == true)//si ligne selectionner
                    {
                        int idSelect = (int)data_grid_produit.Rows[i].Cells[1].Value; // id de la ligne selectionner
                        classProduit = bdd.Produits.SingleOrDefault(s => s.ID_Produit == idSelect);//verifier si id produit = id selectionner
                        if (classProduit != null)// if existe
                        {

                            frmProduit.idProduit = (int)data_grid_produit.Rows[i].Cells[1].Value;
                            frmProduit.lbl_categorie_combobox.Text = data_grid_produit.Rows[i].Cells[5].Value.ToString();
                            frmProduit.txt_nom_ajout_produit.Text = data_grid_produit.Rows[i].Cells[2].Value.ToString();
                            frmProduit.txt_quantite_ajout_produit.Text = data_grid_produit.Rows[i].Cells[3].Value.ToString();
                            frmProduit.txt_prix_ajout_produit.Text = data_grid_produit.Rows[i].Cells[4].Value.ToString();
                            frmProduit.lbl_categorie_combobox.Text = data_grid_produit.Rows[i].Cells[5].Value.ToString();
                        }
                        //affiche image
                        MemoryStream memoryStream = new MemoryStream(classProduit.Image_Produit);//convertir image de produit pour l'affiche dans le pictureBox 
                        frmProduit.pictureBox_produit.Image = Image.FromStream(memoryStream);

                    }
                }
                //frmProduit.btn_actualiser_produit.Visible = false;
                frmProduit.ShowDialog();
            }
        }

        private void data_grid_produit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_photo_produit_Click(object sender, EventArgs e)
        {
            Produit classProduit = new Produit();

            if(selectRows() != null)
            {
                MessageBox.Show(selectRows(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i < data_grid_produit.Rows.Count; i++)//verifie liggne selectionner
                {
                    if ((bool)data_grid_produit.Rows[i].Cells[0].Value == true)//si ligne selectionner
                    {
                        int idSelect = (int)data_grid_produit.Rows[i].Cells[1].Value; // id de la ligne selectionner
                        classProduit = bdd.Produits.SingleOrDefault(s => s.ID_Produit == idSelect);//verifier si id produit = id selectionner
                        if(classProduit != null)//
                        {
                            FramePhotoProduit framePhoto = new FramePhotoProduit();
                            MemoryStream memoryStream = new MemoryStream(classProduit.Image_Produit);//convertir image de produit pour l'affiche dans le pictureBox 
                            framePhoto.picture_produit.Image = Image.FromStream(memoryStream);
                            framePhoto.lbl_produitNom.Text = data_grid_produit.Rows[i].Cells[2].Value.ToString();
                            //afficher formulaire
                            framePhoto.ShowDialog();
                        }
                    }
                }
            }
        }

        private void btn_supprimer_produit_Click(object sender, EventArgs e)
        {
            BL.GestionProduit classProduit = new BL.GestionProduit();

            int select = 0;
            for (int i = 0; i < data_grid_produit.Rows.Count; i++)
            {
                if ((bool)data_grid_produit.Rows[i].Cells[0].Value == true)
                {
                    select++; // nbr de ligne selectionées
                }
            }

            if (select == 0)
            {
                MessageBox.Show("Aucun produit selectionner", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    //pour supprimer tous les clients selectionée
                    for (int i = 0; i < data_grid_produit.Rows.Count; i++)
                    {
                        if ((bool)data_grid_produit.Rows[i].Cells[0].Value == true)
                        {
                            int idSelect = (int)(data_grid_produit.Rows[i].Cells[1].Value);
                            classProduit.deleteProduit(idSelect); //id Produit
                        }
                    }
                    //actualiser data
                    actualiserDataGrid();
                    MessageBox.Show("Produit supprimer", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Suppresion annulé", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
