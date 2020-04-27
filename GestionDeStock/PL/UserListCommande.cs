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
    public partial class UserListCommande : UserControl
    {
        private static UserListCommande userCommande;
        private BddStockContext bdd;

        public static UserListCommande instance
        {
            get
            {
                if(userCommande == null)
                {
                    userCommande = new UserListCommande();
                }

                return userCommande;
            }
        }
        public UserListCommande()
        {
            InitializeComponent();
        }

        private void UserListCommande_Load(object sender, EventArgs e)
        {
            //actualiserDataGrid();
        }

        private void btn_ajouter_categorie_Click(object sender, EventArgs e)
        {
            PL.FrameDetailCommande frm = new FrameDetailCommande();
            frm.ShowDialog();
        }

        private void data_grid_categorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
