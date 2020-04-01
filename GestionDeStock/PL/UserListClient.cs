﻿using System;
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
            bdd = new BddStockContext();
            //Vide le data Grid
            data_grid_client.Rows.Clear();
            foreach(var client in bdd.Clients)
            {
                //ajouter les clients  a la liste dataGrid
                data_grid_client.Rows.Add(false,client.ID_Client,client.Nom_Client, client.Prenom_Client, client.Adresse_Client, client.Telephone_Client,client.Email_Client,client.Pays_Client,client.Ville_Client);
            }
        }

        //ligne selectionner
        public string selectRows()
        {
            int nbrRows = 0;
            for(int i = 0; i < data_grid_client.Rows.Count; i++)
            {
                if((bool)data_grid_client.Rows[i].Cells[0].Value == true)//ligne selectionner
                {
                    nbrRows++; //nbrRows + 1
                }
            }
            if(nbrRows == 0)
            {
                return "Selectionner le client";
            }
            if (nbrRows > 1)
            {
                return "Selectionner seulement 1 client";
            }
            return null;
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
            if (selectRows() == null)
            {
                for(int i = 0; i < data_grid_client.Rows.Count; i++)
                {
                    if((bool)data_grid_client.Rows[i].Cells[0].Value == true)//si checkbox == true afficher dans la frame
                    {
                        frmClient.idSelect = (int)data_grid_client.Rows[i].Cells[1].Value;
                        frmClient.txt_nom_ajout_client.Text = data_grid_client.Rows[i].Cells[2].Value.ToString();
                        frmClient.txt_prenom_ajout_client.Text = data_grid_client.Rows[i].Cells[3].Value.ToString();
                        frmClient.txt_adresse_ajout_client.Text = data_grid_client.Rows[i].Cells[4].Value.ToString();
                        frmClient.txt_telephone_ajout_client.Text = data_grid_client.Rows[i].Cells[5].Value.ToString();
                        frmClient.txt_email_ajout_client.Text = data_grid_client.Rows[i].Cells[6].Value.ToString();
                        frmClient.txt_pays_ajout_client.Text = data_grid_client.Rows[i].Cells[7].Value.ToString();
                        frmClient.txt_ville_ajout_client.Text = data_grid_client.Rows[i].Cells[8].Value.ToString();

                    }
                }
                frmClient.lbl_titre_frameAjoutModifier.Text = "Modifier Client";
                frmClient.btn_actualiser_client.Visible = false;
                frmClient.ShowDialog();
            }else
            {
                MessageBox.Show(selectRows(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_supprimer_client_Click(object sender, EventArgs e)
        {
            BL.GestionClient classClient = new BL.GestionClient();

            int select = 0;
            for(int i=0; i < data_grid_client.Rows.Count;i++)
            {
                if((bool)data_grid_client.Rows[i].Cells[0].Value == true)
                {
                    select++; // nbr de ligne selectionées
                }
            }

            if(select ==0)
            {
                MessageBox.Show("Aucun client selectionner", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R == DialogResult.Yes)
                {
                    //pour supprimer tous les clients selectionée
                    for (int i = 0; i < data_grid_client.Rows.Count; i++)
                    {
                        if ((bool)data_grid_client.Rows[i].Cells[0].Value == true)
                        {
                            classClient.deleteClient(int.Parse(data_grid_client.Rows[i].Cells[1].Value.ToString())); //id Client
                        }
                    }
                    //actualiser data
                    actualiserDataGrid();
                    MessageBox.Show("Client supprimer", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }else
                {
                    MessageBox.Show("Suppresion annulé", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
