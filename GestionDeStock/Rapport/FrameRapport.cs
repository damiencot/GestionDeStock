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
    public partial class FrameRapport : Form
    {
        public FrameRapport()
        {
            InitializeComponent();
        }

        private void FrameRapport_Load(object sender, EventArgs e)
        {

            this.rapport_show_produit.RefreshReport();
        }

        private void rapport_show_produit_Load(object sender, EventArgs e)
        {

        }
    }
}
