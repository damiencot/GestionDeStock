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
    }
}
