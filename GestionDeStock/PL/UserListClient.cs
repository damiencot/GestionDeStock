using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class UserListClient : UserControl
    {

        private static UserListClient userClient;
        private BddStockContext bdd;

        //Créér une instance pour le userControle
        public static UserListClient instance
        {
            get
            {
                if(userClient==null)
                {
                    userClient = new UserListClient();
                }
                return userClient;
            }
        }
        public UserListClient()
        {
            InitializeComponent();
            bdd = new BddStockContext();
        }

        //Ajouter dans la DataGrid
        public void actualiserDataGrid()
        {
            //Vide le data Grid
            data_grid_client.Rows.Clear();
            foreach(var client in bdd.Clients)
            {
                //ajouter les clients  a la liste dataGrid
                data_grid_client.Rows.Add(false,client.Nom_Client, client.Prenom_Client, client.Adresse_Client, client.Telephone_Client,client.Email_Client,client.Pays_Client,client.Ville_Client);
            }
        }

        private void txt_recherche_client_Enter(object sender, EventArgs e)
        {
            if(txt_recherche_client.Text == "Rechercher")
            {
                txt_recherche_client.Text = "";
                txt_recherche_client.ForeColor = Color.Black;

            }
        }


        private void UserListClient_Load(object sender, EventArgs e)
        {
            actualiserDataGrid();
        }

        private void btn_ajouter_client_Click(object sender, EventArgs e)
        {
            PL.FrameAjouterModifierClient frmAjout = new FrameAjouterModifierClient(this);
            frmAjout.ShowDialog();
        }

        private void btn_modifier_client_Click(object sender, EventArgs e)
        {
            PL.FrameAjouterModifierClient frmClient = new FrameAjouterModifierClient(this);
            frmClient.lbl_titre_frameAjoutModifier.Text = "Modifier Client";
            frmClient.btn_actualiser_client.Visible = false;
            frmClient.ShowDialog();
        }
    }
}
