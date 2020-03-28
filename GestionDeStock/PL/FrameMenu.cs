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
    public partial class FrameMenu : Form
    {
        public FrameMenu()
        {
            InitializeComponent();
            //initialise Panel after program Start
            panel_menu.Size = new Size(69, 630);
            panel_parametre.Visible = false;
        }


        //Desactiver les Bouton aux démarages de la Frame
        private void desactiverForm()
        {
            btn_client.Enabled = false;
            btn_produit.Enabled = false;
            btn_categorie.Enabled = false;
            btn_utilisateur.Enabled = false;
            btn_copie.Enabled = false;
            btn_restaure_copie.Enabled = false;
            btn_commande.Enabled = false;
            btn_deconnecter.Enabled = false;
            panel_button.Enabled = false;
            //bouton connecter
            btn_connecter.Enabled = true;
        }

        //active parametre Formulaire
        public void activeForm()
        {
            btn_client.Enabled = true;
            btn_produit.Enabled = true;
            btn_categorie.Enabled = true;
            btn_utilisateur.Enabled = true;
            btn_copie.Enabled = true;
            btn_restaure_copie.Enabled = true;
            btn_commande.Enabled = true;
            btn_deconnecter.Enabled = true;
            panel_button.Enabled = true;
            //bouton connecter
            btn_connecter.Enabled = false;
            panel_parametre.Visible = false;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_resize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Resize Menu after click boutton
        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (panel_menu.Width == 235)
            {
                panel_menu.Size = new Size(69, 630);
            }
            else
            {
                panel_menu.Size = new Size(235, 630);
            }
        }

        private void btn_produit_Click(object sender, EventArgs e)
        {
            panel_button.Top = btn_produit.Top;
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            panel_button.Top = btn_client.Top;
            if(!panel_afficher_client.Controls.Contains(UserListClient.instance))
            {
                panel_afficher_client.Controls.Add(UserListClient.instance);
                UserListClient.instance.Dock = DockStyle.Fill;
                UserListClient.instance.BringToFront();
            }
            else
            {
                UserListClient.instance.BringToFront();
            }
            
        }

        private void btn_categorie_Click(object sender, EventArgs e)
        {
            panel_button.Top = btn_categorie.Top;
        }

        private void btn_commande_Click(object sender, EventArgs e)
        {
            panel_button.Top = btn_commande.Top;
        }

        private void btn_utilisateur_Click(object sender, EventArgs e)
        {
            panel_button.Top = btn_utilisateur.Top;
        }

        private void btn_parametre_Click(object sender, EventArgs e)
        {
            panel_parametre.Size = new Size(322, 269);
            panel_parametre.Visible = !panel_parametre.Visible;
        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
            //Afficher formulaire connexion
            FrameConnexion formConnexion = new FrameConnexion(this);//this=FrameMenu
            formConnexion.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //chargement de la Frame
        private void FrameMenu_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void btn_deconnecter_Click(object sender, EventArgs e)
        {
            desactiverForm();
        }
    }
}
