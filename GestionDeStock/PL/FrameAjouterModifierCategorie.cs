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
    public partial class FrameAjouterModifierCategorie : Form
    {
        private UserControl userCat;
        public int idCategorie;
        public FrameAjouterModifierCategorie(UserControl userCategorie)
        {
            InitializeComponent();
            this.userCat = userCategorie;
        }

        private void btn_connexion_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrameAjouterModifierCategorie_Load(object sender, EventArgs e)
        {

        }

        private void txt_nom_ajout_categorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nom_ajout_categorie_Enter(object sender, EventArgs e)
        {
            if(txt_nom_ajout_categorie.Text == "Nom de Categorie")
            {
                txt_nom_ajout_categorie.Text = "";
                txt_nom_ajout_categorie.ForeColor = Color.White;
            }
        }

        private void btn_enregistrer_categorie_Click(object sender, EventArgs e)
        {
            BL.GestionCategorie classCategorie = new BL.GestionCategorie();
            if (txt_nom_ajout_categorie.Text == "" || txt_nom_ajout_categorie.Text == "Nom de Categorie")
            {
                MessageBox.Show("Entrer nom de categorie","Ajouter Categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);//textbox = vide
            }
            else
            {

                if (lbl_titre_frameAjoutModifier.Text == "Ajouter Categorie")
                {
                    if(classCategorie.addCategorie(txt_nom_ajout_categorie.Text) == false)
                    {
                        MessageBox.Show("La Categorie existe deja", "Ajouter Categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);//textbox = vide
                        (userCat as UserListCategorie).actualiserDataGrid();
                    }else
                    {
                        MessageBox.Show("Categorie ajouter avec succes", "Ajouter Categorie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userCat as UserListCategorie).actualiserDataGrid();
                    }
                }

                if(lbl_titre_frameAjoutModifier.Text == "Modifier Categorie")
                {
                    DialogResult dr = MessageBox.Show("Voulez-vous vraiment le modifier", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        classCategorie.updateCategorie(idCategorie, txt_nom_ajout_categorie.Text);
                        MessageBox.Show("Categorie modifier avec succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userCat as UserListCategorie).actualiserDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Modifier annuler", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }
    }
}
