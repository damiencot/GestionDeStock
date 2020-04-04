namespace GestionDeStock.PL
{
    partial class UserListProduit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_grid_produit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_recherche = new System.Windows.Forms.ComboBox();
            this.txt_recherche_produit = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_supprimer_produit = new System.Windows.Forms.Button();
            this.btn_modifier_produit = new System.Windows.Forms.Button();
            this.btn_ajouter_produit = new System.Windows.Forms.Button();
            this.btn_photo_produit = new System.Windows.Forms.Button();
            this.btn_exel_produit = new System.Windows.Forms.Button();
            this.btn_imprimer_total = new System.Windows.Forms.Button();
            this.btn_imprimer_selection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_produit)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_produit
            // 
            this.data_grid_produit.AllowUserToAddRows = false;
            this.data_grid_produit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_produit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_grid_produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_produit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.data_grid_produit.EnableHeadersVisualStyles = false;
            this.data_grid_produit.Location = new System.Drawing.Point(3, 216);
            this.data_grid_produit.Name = "data_grid_produit";
            this.data_grid_produit.RowHeadersVisible = false;
            this.data_grid_produit.RowHeadersWidth = 51;
            this.data_grid_produit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_grid_produit.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data_grid_produit.RowTemplate.Height = 24;
            this.data_grid_produit.Size = new System.Drawing.Size(1343, 395);
            this.data_grid_produit.TabIndex = 17;
            this.data_grid_produit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_produit_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Categorie";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Location = new System.Drawing.Point(560, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 5);
            this.panel3.TabIndex = 14;
            // 
            // comboBox_recherche
            // 
            this.comboBox_recherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_recherche.FormattingEnabled = true;
            this.comboBox_recherche.Items.AddRange(new object[] {
            "Nom",
            "Categorie"});
            this.comboBox_recherche.Location = new System.Drawing.Point(241, 144);
            this.comboBox_recherche.Name = "comboBox_recherche";
            this.comboBox_recherche.Size = new System.Drawing.Size(245, 37);
            this.comboBox_recherche.TabIndex = 16;
            // 
            // txt_recherche_produit
            // 
            this.txt_recherche_produit.BackColor = System.Drawing.Color.White;
            this.txt_recherche_produit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_recherche_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recherche_produit.Location = new System.Drawing.Point(560, 134);
            this.txt_recherche_produit.Multiline = true;
            this.txt_recherche_produit.Name = "txt_recherche_produit";
            this.txt_recherche_produit.Size = new System.Drawing.Size(319, 50);
            this.txt_recherche_produit.TabIndex = 15;
            this.txt_recherche_produit.Text = "Rechercher";
            this.txt_recherche_produit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_recherche_produit.Enter += new System.EventHandler(this.txt_recherche_produit_Enter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(161, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 5);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(161, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 5);
            this.panel1.TabIndex = 12;
            // 
            // btn_supprimer_produit
            // 
            this.btn_supprimer_produit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_supprimer_produit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_supprimer_produit.FlatAppearance.BorderSize = 0;
            this.btn_supprimer_produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer_produit.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer_produit.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.btn_supprimer_produit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supprimer_produit.Location = new System.Drawing.Point(694, 23);
            this.btn_supprimer_produit.Name = "btn_supprimer_produit";
            this.btn_supprimer_produit.Size = new System.Drawing.Size(266, 66);
            this.btn_supprimer_produit.TabIndex = 11;
            this.btn_supprimer_produit.Text = "Supprimer";
            this.btn_supprimer_produit.UseVisualStyleBackColor = false;
            this.btn_supprimer_produit.Click += new System.EventHandler(this.btn_supprimer_produit_Click);
            // 
            // btn_modifier_produit
            // 
            this.btn_modifier_produit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_modifier_produit.FlatAppearance.BorderSize = 0;
            this.btn_modifier_produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier_produit.ForeColor = System.Drawing.Color.White;
            this.btn_modifier_produit.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.btn_modifier_produit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modifier_produit.Location = new System.Drawing.Point(302, 23);
            this.btn_modifier_produit.Name = "btn_modifier_produit";
            this.btn_modifier_produit.Size = new System.Drawing.Size(272, 66);
            this.btn_modifier_produit.TabIndex = 10;
            this.btn_modifier_produit.Text = "Modifier";
            this.btn_modifier_produit.UseVisualStyleBackColor = false;
            this.btn_modifier_produit.Click += new System.EventHandler(this.btn_modifier_produit_Click);
            // 
            // btn_ajouter_produit
            // 
            this.btn_ajouter_produit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ajouter_produit.FlatAppearance.BorderSize = 0;
            this.btn_ajouter_produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter_produit.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter_produit.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btn_ajouter_produit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ajouter_produit.Location = new System.Drawing.Point(20, 23);
            this.btn_ajouter_produit.Name = "btn_ajouter_produit";
            this.btn_ajouter_produit.Size = new System.Drawing.Size(254, 66);
            this.btn_ajouter_produit.TabIndex = 9;
            this.btn_ajouter_produit.Text = "Ajouter";
            this.btn_ajouter_produit.UseVisualStyleBackColor = false;
            this.btn_ajouter_produit.Click += new System.EventHandler(this.btn_ajouter_produit_Click);
            // 
            // btn_photo_produit
            // 
            this.btn_photo_produit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_photo_produit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_photo_produit.FlatAppearance.BorderSize = 0;
            this.btn_photo_produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_photo_produit.ForeColor = System.Drawing.Color.White;
            this.btn_photo_produit.Image = global::GestionDeStock.Properties.Resources.Pictures_icon;
            this.btn_photo_produit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_photo_produit.Location = new System.Drawing.Point(1081, 23);
            this.btn_photo_produit.Name = "btn_photo_produit";
            this.btn_photo_produit.Size = new System.Drawing.Size(265, 66);
            this.btn_photo_produit.TabIndex = 18;
            this.btn_photo_produit.Text = "Afficher photo";
            this.btn_photo_produit.UseVisualStyleBackColor = false;
            this.btn_photo_produit.Click += new System.EventHandler(this.btn_photo_produit_Click);
            // 
            // btn_exel_produit
            // 
            this.btn_exel_produit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exel_produit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_exel_produit.FlatAppearance.BorderSize = 0;
            this.btn_exel_produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exel_produit.ForeColor = System.Drawing.Color.White;
            this.btn_exel_produit.Image = global::GestionDeStock.Properties.Resources.Excel_icon;
            this.btn_exel_produit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exel_produit.Location = new System.Drawing.Point(1081, 642);
            this.btn_exel_produit.Name = "btn_exel_produit";
            this.btn_exel_produit.Size = new System.Drawing.Size(278, 66);
            this.btn_exel_produit.TabIndex = 21;
            this.btn_exel_produit.Text = "Export Exel";
            this.btn_exel_produit.UseVisualStyleBackColor = false;
            this.btn_exel_produit.Click += new System.EventHandler(this.btn_exel_produit_Click);
            // 
            // btn_imprimer_total
            // 
            this.btn_imprimer_total.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_imprimer_total.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_imprimer_total.FlatAppearance.BorderSize = 0;
            this.btn_imprimer_total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimer_total.ForeColor = System.Drawing.Color.White;
            this.btn_imprimer_total.Image = global::GestionDeStock.Properties.Resources.Imprimer;
            this.btn_imprimer_total.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imprimer_total.Location = new System.Drawing.Point(543, 643);
            this.btn_imprimer_total.Name = "btn_imprimer_total";
            this.btn_imprimer_total.Size = new System.Drawing.Size(290, 66);
            this.btn_imprimer_total.TabIndex = 20;
            this.btn_imprimer_total.Text = "Imprimer tout les produits";
            this.btn_imprimer_total.UseVisualStyleBackColor = false;
            this.btn_imprimer_total.Click += new System.EventHandler(this.btn_imprimer_total_Click);
            // 
            // btn_imprimer_selection
            // 
            this.btn_imprimer_selection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_imprimer_selection.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_imprimer_selection.FlatAppearance.BorderSize = 0;
            this.btn_imprimer_selection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimer_selection.ForeColor = System.Drawing.Color.White;
            this.btn_imprimer_selection.Image = global::GestionDeStock.Properties.Resources.Imprimer;
            this.btn_imprimer_selection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imprimer_selection.Location = new System.Drawing.Point(31, 642);
            this.btn_imprimer_selection.Name = "btn_imprimer_selection";
            this.btn_imprimer_selection.Size = new System.Drawing.Size(269, 66);
            this.btn_imprimer_selection.TabIndex = 19;
            this.btn_imprimer_selection.Text = "Imprimer selection";
            this.btn_imprimer_selection.UseVisualStyleBackColor = false;
            this.btn_imprimer_selection.Click += new System.EventHandler(this.btn_imprimer_selection_Click);
            // 
            // UserListProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_exel_produit);
            this.Controls.Add(this.btn_imprimer_total);
            this.Controls.Add(this.btn_imprimer_selection);
            this.Controls.Add(this.btn_photo_produit);
            this.Controls.Add(this.data_grid_produit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.comboBox_recherche);
            this.Controls.Add(this.txt_recherche_produit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_supprimer_produit);
            this.Controls.Add(this.btn_modifier_produit);
            this.Controls.Add(this.btn_ajouter_produit);
            this.Name = "UserListProduit";
            this.Size = new System.Drawing.Size(1372, 746);
            this.Load += new System.EventHandler(this.UserListProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_produit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView data_grid_produit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox_recherche;
        private System.Windows.Forms.TextBox txt_recherche_produit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_supprimer_produit;
        private System.Windows.Forms.Button btn_modifier_produit;
        private System.Windows.Forms.Button btn_ajouter_produit;
        private System.Windows.Forms.Button btn_photo_produit;
        private System.Windows.Forms.Button btn_exel_produit;
        private System.Windows.Forms.Button btn_imprimer_total;
        private System.Windows.Forms.Button btn_imprimer_selection;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
