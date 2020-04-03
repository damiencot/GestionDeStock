using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace GestionDeStock.PL
{
    public partial class FrameAjouterModifierProduit : Form
    {
        private BddStockContext bdd;
        private UserControl userProduit;
        public int idProduit;

        public FrameAjouterModifierProduit(UserControl user)
        {
            InitializeComponent();
            bdd = new BddStockContext();
            this.userProduit = user;
            //afficher les categories dans combocBox
            comboBox_categorie_produit.DataSource = bdd.Categories.ToList();
            //filtrer affichage
            comboBox_categorie_produit.DisplayMember = "Nom_Categorie";
            comboBox_categorie_produit.ValueMember = "ID_Categorie";
        }

        private void txt_nom_ajout_produit_Enter(object sender, EventArgs e)
        {
            if (txt_nom_ajout_produit.Text == "Nom Produit")
            {
                txt_nom_ajout_produit.Text = "";
                txt_nom_ajout_produit.ForeColor = Color.White;
            }
        }

        private string champsObligatoire()
        {
            if (txt_nom_ajout_produit.Text == "" || txt_nom_ajout_produit.Text == "Nom Produit")
            {
                return "Entrer le Nom du Produit";
            }
            if (txt_quantite_ajout_produit.Text == "" || txt_quantite_ajout_produit.Text == "Quantité")
            {
                return "Entrer la quantité du produit";
            }
            if (txt_prix_ajout_produit.Text == "" || txt_prix_ajout_produit.Text == "Prix")
            {
                return "Entrer le prix du produit";
            }
            if (pictureBox_produit.Image == null)
            {
                return "Entrer l'image du produit";
            }
            if (comboBox_categorie_produit.Text == "")
            {
                return "Entrer Categorie";
            }
            return null;
        }


        private void txt_nom_ajout_produit_Leave(object sender, EventArgs e)
        {
            if (txt_nom_ajout_produit.Text == "")
            {
                txt_nom_ajout_produit.Text = "Nom Produit";
                txt_nom_ajout_produit.ForeColor = Color.Silver;
            }
        }
        private void txt_quantite_ajout_produit_Enter(object sender, EventArgs e)
        {
            if (txt_quantite_ajout_produit.Text == "Quantité")
            {
                txt_quantite_ajout_produit.Text = "";
                txt_quantite_ajout_produit.ForeColor = Color.White;
            }
        }

        private void txt_quantite_ajout_produit_Leave(object sender, EventArgs e)
        {
            if (txt_quantite_ajout_produit.Text == "")
            {
                txt_quantite_ajout_produit.Text = "Quantité";
                txt_quantite_ajout_produit.ForeColor = Color.Silver;
            }
        }

        private void txt_prix_ajout_produit_Enter(object sender, EventArgs e)
        {
            if (txt_prix_ajout_produit.Text == "Prix")
            {
                txt_prix_ajout_produit.Text = "";
                txt_prix_ajout_produit.ForeColor = Color.White;
            }
        }

        private void txt_prix_ajout_produit_Leave(object sender, EventArgs e)
        {
            if (txt_prix_ajout_produit.Text == "")
            {
                txt_prix_ajout_produit.Text = "Prix";
                txt_prix_ajout_produit.ForeColor = Color.Silver;
            }
        }

        private void btn_connexion_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_parcourire_image_Click(object sender, EventArgs e)
        {
            //dossiers images
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP";//seulement ces types d'images
            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBox_produit.Image = Image.FromFile(open.FileName);
            }
        }

        private void btn_actualiser_produit_Click(object sender, EventArgs e)
        {
            //vider les champs
            txt_nom_ajout_produit.Text = "Nom Produit";
            txt_nom_ajout_produit.ForeColor = Color.Silver;
            txt_quantite_ajout_produit.Text = "Quantité";
            txt_quantite_ajout_produit.ForeColor = Color.Silver;
            txt_prix_ajout_produit.Text = "Prix";
            txt_prix_ajout_produit.ForeColor = Color.Silver;
            comboBox_categorie_produit.Text = "";
            pictureBox_produit.Image = null;

        }

        private void txt_nom_ajout_produit_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_quantite_ajout_produit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox numerique
            if (e.KeyChar < 48 || e.KeyChar > 57) // code ASCI des numero
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void txt_prix_ajout_produit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox numerique
            if (e.KeyChar < 48 || e.KeyChar > 57) // code ASCI des numero
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void btn_enregistrer_produit_Click(object sender, EventArgs e)
        {
            if (champsObligatoire() != null)
            {
                MessageBox.Show(champsObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lbl_titre_frameAjoutModifier.Text == "Ajouter Produit")
                {
                    BL.GestionProduit classeProduit = new BL.GestionProduit();
                    //convertir image au formet byte
                    MemoryStream memory = new MemoryStream();
                    pictureBox_produit.Image.Save(memory, pictureBox_produit.Image.RawFormat);
                    byte[] byteImageP = memory.ToArray();//convertir image en format bvyte[]

                    if (classeProduit.addProduit(txt_nom_ajout_produit.Text, int.Parse(txt_quantite_ajout_produit.Text), int.Parse(txt_prix_ajout_produit.Text), byteImageP, Convert.ToInt32(comboBox_categorie_produit.SelectedValue)) == true)
                    {
                        MessageBox.Show("Produit ajouter avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //Actualiser dataGrid auto
                        (userProduit as UserListProduit).actualiserDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Produit deja existant", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    //convertir image au formet byte
                    MemoryStream memory = new MemoryStream();
                    pictureBox_produit.Image.Save(memory, pictureBox_produit.Image.RawFormat);
                    byte[] byteImageP = memory.ToArray();//convertir image en format bvyte[]
                    BL.GestionProduit classProduit = new BL.GestionProduit();
                    DialogResult r = MessageBox.Show("Voulez-vous vraiment modifier le produit", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        classProduit.updateProduit(idProduit, txt_nom_ajout_produit.Text, int.Parse(txt_quantite_ajout_produit.Text), int.Parse(txt_prix_ajout_produit.Text), byteImageP, Convert.ToInt32(comboBox_categorie_produit.SelectedValue));
                        (userProduit as UserListProduit).actualiserDataGrid();
                        MessageBox.Show("Modification avec succés", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Modification annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }


    }
}
