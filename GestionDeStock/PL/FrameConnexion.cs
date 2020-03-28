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
    public partial class FrameConnexion : Form
    {

        //Bdd
        private BddStockContext bdd;
        
        //Frame
        private Form frameMenu;

        //Classe
        BL.Connexion classeConnect = new BL.Connexion();


        public FrameConnexion(Form Menu)
        {
            InitializeComponent();
            this.frameMenu = Menu;
            //initialiser bdd
            bdd = new BddStockContext();
        }

        private void btn_connexion_quitter_Click(object sender, EventArgs e)
        {
            //Quitter le formulaire
            this.Close();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        
        //Vider TextBox Utilisateur
        private void txt_connexion_user_Enter(object sender, EventArgs e)
        {
            if(txt_connexion_user.Text == "Utilisateurs")
            {
                txt_connexion_user.Text = "";
                txt_connexion_user.ForeColor = Color.WhiteSmoke;

            }
        }

        private void txt_connexion_password_Enter(object sender, EventArgs e)
        {
            if (txt_connexion_password.Text == "Mot de Passe")
            {
                txt_connexion_password.Text = "";
                txt_connexion_password.UseSystemPasswordChar = false;
                txt_connexion_password.PasswordChar = '*';
                txt_connexion_password.ForeColor = Color.WhiteSmoke;

            }
        }

        //Remplir TextBox Utilisateur
        private void txt_connexion_user_Leave(object sender, EventArgs e)
        {
            if (txt_connexion_user.Text == "")
            {
                txt_connexion_user.Text = "Utilisateurs";
                txt_connexion_user.ForeColor = Color.Silver;

            }
        }

        private void txt_connexion_password_Leave(object sender, EventArgs e)
        {
            if (txt_connexion_user.Text == "")
            {
                txt_connexion_user.Text = "Mot de Passe";
                txt_connexion_password.UseSystemPasswordChar = true;
                txt_connexion_password.PasswordChar = '*';
                txt_connexion_user.ForeColor = Color.Silver;

            }
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            if(champsRequis() == null)
            {
                //Si un utilisateur existe
                if(classeConnect.connexionValide(bdd,txt_connexion_user.Text,txt_connexion_password.Text) == true)
                {
                    MessageBox.Show("Connexion réussi", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frameMenu as FrameMenu).activeForm();
                    this.Close();//quitter formulaire connexion
                }
                else
                {
                    MessageBox.Show("Connexion échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(champsRequis(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string champsRequis()
        {
            if(txt_connexion_user.Text == "" || txt_connexion_user.Text == "Utilisateurs")
            {
                return "Entre votre Nom";
            }
            if(txt_connexion_password.Text == "" || txt_connexion_password.Text == "Mot de Passe")
            {
                return "Entre votre Mot de Passe";
            }
            return null;

        }
    }
}
