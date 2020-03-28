namespace GestionDeStock.PL
{
    partial class FrameMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_button = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_utilisateur = new System.Windows.Forms.Button();
            this.btn_commande = new System.Windows.Forms.Button();
            this.btn_categorie = new System.Windows.Forms.Button();
            this.btn_produit = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_parametre = new System.Windows.Forms.Panel();
            this.btn_deconnecter = new System.Windows.Forms.Button();
            this.btn_restaure_copie = new System.Windows.Forms.Button();
            this.btn_copie = new System.Windows.Forms.Button();
            this.btn_connecter = new System.Windows.Forms.Button();
            this.btn_parametre = new System.Windows.Forms.Button();
            this.btn_resize = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.panel_afficher_client = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_parametre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_menu.Controls.Add(this.panel_button);
            this.panel_menu.Controls.Add(this.btn_menu);
            this.panel_menu.Controls.Add(this.btn_utilisateur);
            this.panel_menu.Controls.Add(this.btn_commande);
            this.panel_menu.Controls.Add(this.btn_categorie);
            this.panel_menu.Controls.Add(this.btn_produit);
            this.panel_menu.Controls.Add(this.btn_client);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(247, 630);
            this.panel_menu.TabIndex = 0;
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.Red;
            this.panel_button.Location = new System.Drawing.Point(0, 103);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(16, 62);
            this.panel_button.TabIndex = 4;
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Image = global::GestionDeStock.Properties.Resources.Menu_32;
            this.btn_menu.Location = new System.Drawing.Point(195, 3);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(52, 40);
            this.btn_menu.TabIndex = 4;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_utilisateur
            // 
            this.btn_utilisateur.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_utilisateur.FlatAppearance.BorderSize = 0;
            this.btn_utilisateur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_utilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_utilisateur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_utilisateur.Image = global::GestionDeStock.Properties.Resources.customer_service_icon;
            this.btn_utilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_utilisateur.Location = new System.Drawing.Point(12, 416);
            this.btn_utilisateur.Name = "btn_utilisateur";
            this.btn_utilisateur.Size = new System.Drawing.Size(235, 62);
            this.btn_utilisateur.TabIndex = 8;
            this.btn_utilisateur.Text = "Utilisateur";
            this.btn_utilisateur.UseVisualStyleBackColor = false;
            this.btn_utilisateur.Click += new System.EventHandler(this.btn_utilisateur_Click);
            // 
            // btn_commande
            // 
            this.btn_commande.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_commande.FlatAppearance.BorderSize = 0;
            this.btn_commande.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_commande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_commande.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_commande.Image = global::GestionDeStock.Properties.Resources.shopping_icon;
            this.btn_commande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_commande.Location = new System.Drawing.Point(12, 337);
            this.btn_commande.Name = "btn_commande";
            this.btn_commande.Size = new System.Drawing.Size(235, 62);
            this.btn_commande.TabIndex = 7;
            this.btn_commande.Text = "Commande";
            this.btn_commande.UseVisualStyleBackColor = false;
            this.btn_commande.Click += new System.EventHandler(this.btn_commande_Click);
            // 
            // btn_categorie
            // 
            this.btn_categorie.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_categorie.FlatAppearance.BorderSize = 0;
            this.btn_categorie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_categorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categorie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_categorie.Image = global::GestionDeStock.Properties.Resources.Categorie;
            this.btn_categorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categorie.Location = new System.Drawing.Point(12, 260);
            this.btn_categorie.Name = "btn_categorie";
            this.btn_categorie.Size = new System.Drawing.Size(235, 62);
            this.btn_categorie.TabIndex = 6;
            this.btn_categorie.Text = "Categorie";
            this.btn_categorie.UseVisualStyleBackColor = false;
            this.btn_categorie.Click += new System.EventHandler(this.btn_categorie_Click);
            // 
            // btn_produit
            // 
            this.btn_produit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_produit.FlatAppearance.BorderSize = 0;
            this.btn_produit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_produit.Image = global::GestionDeStock.Properties.Resources.shop_cart_add_icon;
            this.btn_produit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_produit.Location = new System.Drawing.Point(12, 180);
            this.btn_produit.Name = "btn_produit";
            this.btn_produit.Size = new System.Drawing.Size(235, 62);
            this.btn_produit.TabIndex = 5;
            this.btn_produit.Text = "Produit";
            this.btn_produit.UseVisualStyleBackColor = false;
            this.btn_produit.Click += new System.EventHandler(this.btn_produit_Click);
            // 
            // btn_client
            // 
            this.btn_client.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_client.FlatAppearance.BorderSize = 0;
            this.btn_client.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_client.Image = global::GestionDeStock.Properties.Resources.Office_Client_Male_Light_icon;
            this.btn_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_client.Location = new System.Drawing.Point(12, 103);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(235, 62);
            this.btn_client.TabIndex = 4;
            this.btn_client.Text = "Client";
            this.btn_client.UseVisualStyleBackColor = false;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(247, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 22);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_parametre);
            this.panel1.Controls.Add(this.panel_afficher_client);
            this.panel1.Controls.Add(this.btn_parametre);
            this.panel1.Controls.Add(this.btn_resize);
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(247, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 608);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_parametre
            // 
            this.panel_parametre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_parametre.BackColor = System.Drawing.Color.DimGray;
            this.panel_parametre.Controls.Add(this.btn_deconnecter);
            this.panel_parametre.Controls.Add(this.btn_restaure_copie);
            this.panel_parametre.Controls.Add(this.btn_copie);
            this.panel_parametre.Controls.Add(this.btn_connecter);
            this.panel_parametre.Location = new System.Drawing.Point(52, 7);
            this.panel_parametre.Name = "panel_parametre";
            this.panel_parametre.Size = new System.Drawing.Size(322, 293);
            this.panel_parametre.TabIndex = 9;
            // 
            // btn_deconnecter
            // 
            this.btn_deconnecter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deconnecter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_deconnecter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_deconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deconnecter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_deconnecter.Image = global::GestionDeStock.Properties.Resources.Deconnecte;
            this.btn_deconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deconnecter.Location = new System.Drawing.Point(4, 202);
            this.btn_deconnecter.Name = "btn_deconnecter";
            this.btn_deconnecter.Size = new System.Drawing.Size(313, 60);
            this.btn_deconnecter.TabIndex = 3;
            this.btn_deconnecter.Text = "Deconneter";
            this.btn_deconnecter.UseVisualStyleBackColor = false;
            this.btn_deconnecter.Click += new System.EventHandler(this.btn_deconnecter_Click);
            // 
            // btn_restaure_copie
            // 
            this.btn_restaure_copie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaure_copie.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_restaure_copie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_restaure_copie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restaure_copie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_restaure_copie.Image = global::GestionDeStock.Properties.Resources.Download;
            this.btn_restaure_copie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_restaure_copie.Location = new System.Drawing.Point(4, 136);
            this.btn_restaure_copie.Name = "btn_restaure_copie";
            this.btn_restaure_copie.Size = new System.Drawing.Size(313, 60);
            this.btn_restaure_copie.TabIndex = 2;
            this.btn_restaure_copie.Text = "Restaurer une copie";
            this.btn_restaure_copie.UseVisualStyleBackColor = false;
            // 
            // btn_copie
            // 
            this.btn_copie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_copie.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_copie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_copie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_copie.Image = global::GestionDeStock.Properties.Resources.Download;
            this.btn_copie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copie.Location = new System.Drawing.Point(4, 70);
            this.btn_copie.Name = "btn_copie";
            this.btn_copie.Size = new System.Drawing.Size(313, 60);
            this.btn_copie.TabIndex = 1;
            this.btn_copie.Text = "Créer une copie de l\'application";
            this.btn_copie.UseVisualStyleBackColor = false;
            // 
            // btn_connecter
            // 
            this.btn_connecter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_connecter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_connecter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_connecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connecter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_connecter.Image = global::GestionDeStock.Properties.Resources.Connected_16;
            this.btn_connecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_connecter.Location = new System.Drawing.Point(4, 4);
            this.btn_connecter.Name = "btn_connecter";
            this.btn_connecter.Size = new System.Drawing.Size(313, 60);
            this.btn_connecter.TabIndex = 0;
            this.btn_connecter.Text = "Connecter";
            this.btn_connecter.UseVisualStyleBackColor = false;
            this.btn_connecter.Click += new System.EventHandler(this.btn_connecter_Click);
            // 
            // btn_parametre
            // 
            this.btn_parametre.FlatAppearance.BorderSize = 0;
            this.btn_parametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parametre.Image = global::GestionDeStock.Properties.Resources.Settings_32;
            this.btn_parametre.Location = new System.Drawing.Point(0, 0);
            this.btn_parametre.Name = "btn_parametre";
            this.btn_parametre.Size = new System.Drawing.Size(59, 49);
            this.btn_parametre.TabIndex = 8;
            this.btn_parametre.UseVisualStyleBackColor = true;
            this.btn_parametre.Click += new System.EventHandler(this.btn_parametre_Click);
            // 
            // btn_resize
            // 
            this.btn_resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_resize.FlatAppearance.BorderSize = 0;
            this.btn_resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resize.Image = global::GestionDeStock.Properties.Resources.Subtract_32;
            this.btn_resize.Location = new System.Drawing.Point(763, 4);
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.Size = new System.Drawing.Size(67, 48);
            this.btn_resize.TabIndex = 7;
            this.btn_resize.UseVisualStyleBackColor = true;
            this.btn_resize.Click += new System.EventHandler(this.btn_resize_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Image = global::GestionDeStock.Properties.Resources.Shutdown_32;
            this.btn_stop.Location = new System.Drawing.Point(836, 4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(67, 48);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // panel_afficher_client
            // 
            this.panel_afficher_client.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_afficher_client.BackColor = System.Drawing.Color.Silver;
            this.panel_afficher_client.Location = new System.Drawing.Point(6, 55);
            this.panel_afficher_client.Name = "panel_afficher_client";
            this.panel_afficher_client.Size = new System.Drawing.Size(886, 541);
            this.panel_afficher_client.TabIndex = 10;
            // 
            // FrameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrameMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrameMenu_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_parametre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Button btn_utilisateur;
        private System.Windows.Forms.Button btn_commande;
        private System.Windows.Forms.Button btn_categorie;
        private System.Windows.Forms.Button btn_produit;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_deconnecter;
        private System.Windows.Forms.Button btn_restaure_copie;
        private System.Windows.Forms.Button btn_copie;
        private System.Windows.Forms.Button btn_connecter;
        private System.Windows.Forms.Button btn_parametre;
        private System.Windows.Forms.Button btn_resize;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Panel panel_parametre;
        private System.Windows.Forms.Panel panel_afficher_client;
    }
}