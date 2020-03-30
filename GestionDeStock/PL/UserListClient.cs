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
            //Exemple ajout des lignes
            data_grid_client.Rows.Add();
            data_grid_client.Rows[0].Cells[1].Value = "Paul";
            data_grid_client.Rows[0].Cells[2].Value = "Mathieu";
        }

        private void btn_ajouter_client_Click(object sender, EventArgs e)
        {
            PL.FrameAjouterModifierClient frmAjout = new FrameAjouterModifierClient();
            frmAjout.ShowDialog();
        }

        private void btn_modifier_client_Click(object sender, EventArgs e)
        {
            PL.FrameAjouterModifierClient frmClient = new FrameAjouterModifierClient();
            frmClient.lbl_titre_frameAjoutModifier.Text = "Modifier Client";
            frmClient.btn_actualiser_client.Visible = false;
            frmClient.ShowDialog();
        }
    }
}
