using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.Office.Interop.Excel;


namespace GestionDeStock.PL
{
    public partial class UserListCategorie : UserControl
    {
        private static UserListCategorie userCategorie;
        private BddStockContext bdd;
        
        //Creer une instance pour le userControlle
        public static UserListCategorie instance
        {
            get
            {
                if(userCategorie == null)
                {
                    userCategorie = new UserListCategorie();
                }
                return userCategorie;
            }
        }
        public UserListCategorie()
        {
            InitializeComponent();
            bdd = new BddStockContext();
        }

        public string selectRows()
        {
            int nbrRows = 0;
            for (int i = 0; i < data_grid_categorie.Rows.Count; i++)
            {
                if ((bool)data_grid_categorie.Rows[i].Cells[0].Value == true)//ligne selectionner
                {
                    nbrRows++; //nbrRows + 1
                }
            }
            if (nbrRows == 0)
            {
                return "Selectionner le categorie";
            }
            if (nbrRows > 1)
            {
                return "Selectionner seulement 1 categorie";
            }
            return null;
        }

        public void actualiserDataGrid()
        {
            bdd = new BddStockContext();
            //Vide le data Grid
            data_grid_categorie.Rows.Clear();
            //Afficher nom categorie à partir de idCategorie
            //Categorie categorie = new Categorie();

            foreach (var cat in bdd.Categories)
            {
                //categorie = bdd.Categories.SingleOrDefault(s => s.ID_Categorie == produit.ID_Categorie);//si idCategorie present dans la table Produit = IdCategorie dans table Categorie
                //ajouter les clients  a la liste dataGrid
                data_grid_categorie.Rows.Add(false, cat.ID_Categorie, cat.Nom_Categorie);
            }
        }

        private void UserListCategorie_Load(object sender, EventArgs e)
        {
            actualiserDataGrid();
        }

        private void btn_ajouter_categorie_Click(object sender, EventArgs e)
        {
            PL.FrameAjouterModifierCategorie frmCategorie = new FrameAjouterModifierCategorie(this);
            frmCategorie.ShowDialog();
        }

        private void data_grid_categorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PL.FrameAjouterModifierCategorie frmCategorie = new FrameAjouterModifierCategorie(this);
            if (data_grid_categorie.Columns[e.ColumnIndex].Name == "Modifier")//si le nom de l'index correspond a Modifier
            {
                frmCategorie.idCategorie = (int)data_grid_categorie.Rows[e.RowIndex].Cells[1].Value;
                frmCategorie.lbl_titre_frameAjoutModifier.Text = "Modifier Categorie";
                frmCategorie.txt_nom_ajout_categorie.Text = data_grid_categorie.Rows[e.RowIndex].Cells[2].Value.ToString(); //e.RowIndex = index de la ligne cliquer
                frmCategorie.ShowDialog();

            }
            if (data_grid_categorie.Columns[e.ColumnIndex].Name == "Supprimer")//si le nom de l'index correspond a Modifier
            {
                BL.GestionCategorie classCategorie = new BL.GestionCategorie();
                DialogResult dr = MessageBox.Show("voulez vous vraiment supprimer la categorie ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    int idCategorie = (int)data_grid_categorie.Rows[e.RowIndex].Cells[1].Value;
                    //verifier si il y a des produits dans cette categorie
                    int countProduit = bdd.Produits.Count(s => s.ID_Categorie == idCategorie);
                    if(countProduit == 0)
                    {
                        classCategorie.deleteCategorie(idCategorie);
                        MessageBox.Show("Categorie supprimer avec succes", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); ;
                        actualiserDataGrid();

                    }
                    else
                    {
                        //il y a des produits dans cette categorie
                        DialogResult dialogR = MessageBox.Show("Il y a : " + countProduit + "produits dans cette categorie, voulez-vous vraiment supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogR == DialogResult.Yes)
                        {
                            classCategorie.deleteCategorie(idCategorie);
                            MessageBox.Show("Categorie supprimer avec succes", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); ;
                            actualiserDataGrid();

                        }
                        else
                        {
                            MessageBox.Show("Suppression annulé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        }
                    }
                }else
                {
                    MessageBox.Show("Suppression annulé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                }
            }
        }

        private void btn_imprimer_total_Click(object sender, EventArgs e)
        {
            FrameRapport frmR = new FrameRapport();
            bdd = new BddStockContext();
            try
            {
                //Listes Categories
                var listeCat = bdd.Categories.ToList();
                //Nombre de categorie
                int nbrCategorie = bdd.Categories.Count();
                //ajouter dataSource
                frmR.rapport_show_produit.LocalReport.ReportEmbeddedResource = "GestionDeStock.Rapport.RptListCategorie.rdlc"; //chemin du rapport
                frmR.rapport_show_produit.LocalReport.DataSources.Add(new ReportDataSource("databasecategorie", listeCat));//
                //date
                ReportParameter date = new ReportParameter("Date", DateTime.Now.ToShortDateString());
                frmR.rapport_show_produit.LocalReport.SetParameters(new ReportParameter[] { date });
                frmR.rapport_show_produit.RefreshReport();
                frmR.ShowDialog();

            }
            catch (Exception ex)
            {

            }
        }

        private void btn_exel_categorie_Click(object sender, EventArgs e)
        {
            bdd = new BddStockContext();
            string nomCategorie = "";
            int idCategorie = 0;
            if (selectRows() != null)
            {
                MessageBox.Show(selectRows(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsw", ValidateNames = true })//filtrer seulement fichier exel
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)app.ActiveSheet;
                        app.Visible = false;
                        //Nom de categorie et id categorie
                        for(int i = 0; i < data_grid_categorie.Rows.Count; i++)
                        {
                            if((bool)data_grid_categorie.Rows[i].Cells[0].Value == true)
                            {
                                nomCategorie = data_grid_categorie.Rows[i].Cells[2].Value.ToString();
                                idCategorie = (int)data_grid_categorie.Rows[i].Cells[1].Value;
                            }
                        }
                        //Ecrire Nom de Categorie dans fichier excel
                        ws.Range["A1:D1"].Merge();
                        ws.Range["A1:D1"].Value = nomCategorie;
                        //ajout produit au cells
                        ws.Cells[2, 1] = "ID Produit";
                        ws.Cells[2, 2] = "Nom Produit";
                        ws.Cells[2, 3] = "Quantite";
                        ws.Cells[2, 4] = "Prix";
                        //Liste produit dans cette categorie
                        var listProduit = bdd.Produits.Where(s => s.ID_Categorie == idCategorie).ToList();
                        int count = 3;
                        foreach (var L in listProduit)
                        {
                            ws.Cells[count, 1] = L.ID_Produit;
                            ws.Cells[count, 2] = L.Nom_Produit;
                            ws.Cells[count, 3] = L.Quantite_Produit;
                            ws.Cells[count, 4] = L.Prix_Produit;
                            count++;
                        }

                        wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false);//sauvegarde fichier excel
                        app.Quit();
                        MessageBox.Show("Succés de la Sauvegarde", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }
    }
}
