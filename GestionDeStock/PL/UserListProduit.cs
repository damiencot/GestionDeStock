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
using Microsoft.Reporting.WinForms;
using Microsoft.Office.Interop.Excel;


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

        private void btn_imprimer_selection_Click(object sender, EventArgs e)
        {
            bdd = new BddStockContext();
            int idSelect = 0;
            string nomCategorie = null;
            FrameRapport frmRapport = new FrameRapport();
            Produit classProduit = new Produit();
            if(selectRows() != null)
            {
                MessageBox.Show(selectRows(), "Imprimer Produit", MessageBoxButtons.OK, MessageBoxIcon.Error);// plusieur ligne de cocher
            }else
            {
                for(int i = 0; i < data_grid_produit.Rows.Count; i++)
                {
                    if((bool)data_grid_produit.Rows[i].Cells[0].Value == true)//si ligne cocher
                    {
                        idSelect = (int)data_grid_produit.Rows[i].Cells[1].Value; // id de ligne selectionner
                        nomCategorie = data_grid_produit.Rows[i].Cells[5].Value.ToString(); // recupere la categorie dans la ligne selectionner
                    }
                }
                //-------//
                classProduit = bdd.Produits.SingleOrDefault(s => s.ID_Produit == idSelect);
                if(classProduit != null)//si produit existe
                {
                    
                    frmRapport.rapport_show_produit.LocalReport.ReportEmbeddedResource = "GestionDeStock.Rapport.RptProduit.rdlc"; //chemin du rapport
                    ReportParameter produitCategorie = new ReportParameter("RPCategorie", nomCategorie);
                    ReportParameter produitNom = new ReportParameter("RPNom", classProduit.Nom_Produit);
                    ReportParameter produitQuantite = new ReportParameter("RPQuantité", classProduit.Quantite_Produit.ToString());
                    ReportParameter produitPrix = new ReportParameter("RPPrix", classProduit.Prix_Produit.ToString());
                    //Image
                    string imageString = Convert.ToBase64String(classProduit.Image_Produit);
                    ReportParameter produitImage = new ReportParameter("RPImage", imageString);//image convertis en string base x64
                    //save les nouveaux paramettre dans le rapport
                    frmRapport.rapport_show_produit.LocalReport.SetParameters(new ReportParameter[] { produitCategorie, produitNom, produitQuantite, produitPrix, produitImage });
                    frmRapport.rapport_show_produit.RefreshReport();
                    frmRapport.ShowDialog();//afficher formulaire
                }
            }
        }

        private void btn_imprimer_total_Click(object sender, EventArgs e)
        {
            try
            {
                FrameRapport frmRpt = new FrameRapport();
                bdd = new BddStockContext();
                var listProduit = bdd.Produits.ToList();
                frmRpt.rapport_show_produit.LocalReport.ReportEmbeddedResource = "GestionDeStock.Rapport.RptListProduits.rdlc"; //chemin du rapport
                //ajouter data source
                frmRpt.rapport_show_produit.LocalReport.DataSources.Add(new ReportDataSource("databaseproduit", listProduit));//liste des produits
                ReportParameter date = new ReportParameter("Date", DateTime.Now.ToString());//date systeme
                frmRpt.rapport_show_produit.LocalReport.SetParameters(new ReportParameter[] { date });
                frmRpt.rapport_show_produit.RefreshReport();
                frmRpt.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exel_produit_Click(object sender, EventArgs e)
        {
            bdd = new BddStockContext();
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsw", ValidateNames = true })//filtrer seulement fichier exel
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    //Ajouter les ligne au fichier excel
                    ws.Cells[1, 1] = "Id Produit";
                    ws.Cells[1, 2] = "Nom Produit";
                    ws.Cells[1, 3] = "Quantité";
                    ws.Cells[1, 4] = "Prix";
                    //Ajouter liste de produit de la base de donnée dans le fichier excel
                    var listProduit = bdd.Produits.ToList();//listes des produits
                    int i = 2;
                    foreach (var L in listProduit)
                    {
                        ws.Cells[i, 1] = L.ID_Produit;
                        ws.Cells[i, 2] = L.Nom_Produit;
                        ws.Cells[i, 3] = L.Quantite_Produit;
                        ws.Cells[i, 4] = L.Prix_Produit;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName);//sauvegarde fichier excel
                    app.Quit();
                    MessageBox.Show("Succés de la Sauvegarde", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
