using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GestionDeStock.PL
{
    public partial class FrameAjouterModifierClient : Form
    {

        private UserControl userClient;

        public FrameAjouterModifierClient(UserControl userC)
        {
            InitializeComponent();
            this.userClient = userC;
        }
        
        //champs obligatoires
        private string champsObligatoire()
        {
            if(txt_nom_ajout_client.Text == "" || txt_nom_ajout_client.Text == "Nom de Client")
            {
                return "Entrer le Nom du Client";
            }
            if (txt_prenom_ajout_client.Text == "" || txt_prenom_ajout_client.Text == "Prenom de Client")
            {
                return "Entrer le Prenom du Client";
            }
            if (txt_adresse_ajout_client.Text == "" || txt_adresse_ajout_client.Text == "Adresse Client")
            {
                return "Entrer l'adresse du Client";
            }
            if (txt_telephone_ajout_client.Text == "" || txt_telephone_ajout_client.Text == "Telephone Client")
            {
                return "Entrer le Telephone du Client";
            }
            if (txt_email_ajout_client.Text == "" || txt_email_ajout_client.Text == "Email Client")
            {
                return "Entrer l'Email du Client";
            }
            if (txt_pays_ajout_client.Text == "" || txt_pays_ajout_client.Text == "Pays Client")
            {
                return "Entrer le Pays du Client";
            }
            if (txt_ville_ajout_client.Text == "" || txt_ville_ajout_client.Text == "Ville Client")
            {
                return "Entrer la Ville du Client";
            }
            if(txt_email_ajout_client.Text != "" || txt_email_ajout_client.Text == "Email Client")
            {
                try
                {
                    new MailAddress(txt_email_ajout_client.Text);//verification format email
                }catch(Exception e)
                {
                    return "Email invalide";
                }
            }
            return null;
        }


        private void txt_nom_ajout_client_Enter(object sender, EventArgs e)
        {
            if(txt_nom_ajout_client.Text == "Nom de Client")
            {
                txt_nom_ajout_client.Text = "";
                txt_nom_ajout_client.ForeColor = Color.White;
            }
        }

        private void txt_nom_ajout_client_Leave(object sender, EventArgs e)
        {
            if (txt_nom_ajout_client.Text == "")
            {
                txt_nom_ajout_client.Text = "Nom de Client";
                txt_nom_ajout_client.ForeColor = Color.Silver;
            }
        }

        private void txt_prenom_ajout_client_Enter(object sender, EventArgs e)
        {
            if (txt_prenom_ajout_client.Text == "Prenom de Client")
            {
                txt_prenom_ajout_client.Text = "";
                txt_prenom_ajout_client.ForeColor = Color.White;
            }
        }

        private void txt_prenom_ajout_client_Leave(object sender, EventArgs e)
        {
            if (txt_prenom_ajout_client.Text == "")
            {
                txt_prenom_ajout_client.Text = "Prenom de Client";
                txt_prenom_ajout_client.ForeColor = Color.Silver;
            }
        }

        private void txt_telephone_ajout_client_Enter(object sender, EventArgs e)
        {
            if (txt_telephone_ajout_client.Text == "Telephone Client")
            {
                txt_telephone_ajout_client.Text = "";
                txt_telephone_ajout_client.ForeColor = Color.White;
            }
        }

        private void txt_telephone_ajout_client_Leave(object sender, EventArgs e)
        {
            if (txt_telephone_ajout_client.Text == "")
            {
                txt_telephone_ajout_client.Text = "Telephone Client";
                txt_telephone_ajout_client.ForeColor = Color.Silver;
            }
        }

        private void txt_adresse_ajout_client_Enter(object sender, EventArgs e)
        {
            if (txt_adresse_ajout_client.Text == "Adresse Client")
            {
                txt_adresse_ajout_client.Text = "";
                txt_adresse_ajout_client.ForeColor = Color.White;
            }
        }
        private void txt_adresse_ajout_client_Leave(object sender, EventArgs e)
        {
            if (txt_adresse_ajout_client.Text == "")
            {
                txt_adresse_ajout_client.Text = "Adresse Client";
                txt_adresse_ajout_client.ForeColor = Color.Silver;
            }
        }

        private void txt_email_ajout_client_Enter(object sender, EventArgs e)
        {
            if (txt_email_ajout_client.Text == "Email Client")
            {
                txt_email_ajout_client.Text = "";
                txt_email_ajout_client.ForeColor = Color.White;
            }
        }
        private void txt_email_ajout_client_Leave(object sender, EventArgs e)
        {
            if (txt_email_ajout_client.Text == "")
            {
                txt_email_ajout_client.Text = "Email Client";
                txt_email_ajout_client.ForeColor = Color.Silver;
            }
        }

        private void txt_ville_ajout_client_Enter(object sender, EventArgs e)
        {
            if (txt_ville_ajout_client.Text == "Ville Client")
            {
                txt_ville_ajout_client.Text = "";
                txt_ville_ajout_client.ForeColor = Color.White;
            }
        }
        private void txt_ville_ajout_client_Leave(object sender, EventArgs e)
        {
            if (txt_ville_ajout_client.Text == "")
            {
                txt_ville_ajout_client.Text = "Ville Client";
                txt_ville_ajout_client.ForeColor = Color.Silver;
            }
        }

        private void txt_pays_ajout_client_Enter(object sender, EventArgs e)
        {
            if (txt_pays_ajout_client.Text == "Pays Client")
            {
                txt_pays_ajout_client.Text = "";
                txt_pays_ajout_client.ForeColor = Color.White;
            }
        }
        private void txt_pays_ajout_client_Leave(object sender, EventArgs e)
        {
            if (txt_pays_ajout_client.Text == "")
            {
                txt_pays_ajout_client.Text = "Pays Client";
                txt_pays_ajout_client.ForeColor = Color.Silver;
            }
        }

        private void btn_connexion_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_telephone_ajout_client_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox numerique
            if(e.KeyChar < 48 || e.KeyChar > 57) // code ASCI des numero
            {
                e.Handled = true;
            }
            if(e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void btn_enregistrer_client_Click(object sender, EventArgs e)
        {
            if(champsObligatoire() != null)
            {
                MessageBox.Show(champsObligatoire(), "Obligatoire", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                BL.GestionClient classeClient = new BL.GestionClient();
                if (classeClient.addClient(txt_nom_ajout_client.Text, txt_prenom_ajout_client.Text, txt_adresse_ajout_client.Text, txt_telephone_ajout_client.Text, txt_email_ajout_client.Text, txt_pays_ajout_client.Text, txt_ville_ajout_client.Text) == true)
                {
                    MessageBox.Show("Client ajouter avec succes", "Ajouter",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //Actualiser dataGrid auto
                    (userClient as UserListClient).actualiserDataGrid();
                }
                else
                {
                    MessageBox.Show("Client deja existant", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_actualiser_client_Click(object sender, EventArgs e)
        {
            //vider les champs
            txt_nom_ajout_client.Text = "Nom de Client";
            txt_nom_ajout_client.ForeColor = Color.Silver;
            txt_prenom_ajout_client.Text = "Prenom de Client";
            txt_prenom_ajout_client.ForeColor = Color.Silver;
            txt_adresse_ajout_client.Text = "Adresse Client";
            txt_adresse_ajout_client.ForeColor = Color.Silver;
            txt_telephone_ajout_client.Text = "Telephone Client";
            txt_telephone_ajout_client.ForeColor = Color.Silver;
            txt_pays_ajout_client.Text = "Pays Client";
            txt_pays_ajout_client.ForeColor = Color.Silver;
            txt_email_ajout_client.Text = "Email Client";
            txt_email_ajout_client.ForeColor = Color.Silver;
            txt_ville_ajout_client.Text = "Ville Client";
            txt_ville_ajout_client.ForeColor = Color.Silver;

        }
    }
}
