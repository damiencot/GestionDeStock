namespace GestionDeStock.PL
{
    partial class UserListCategorie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ajouter_categorie = new System.Windows.Forms.Button();
            this.data_grid_categorie = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_exel_categorie = new System.Windows.Forms.Button();
            this.btn_imprimer_total = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_recherche_categorie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_categorie)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajouter_categorie
            // 
            this.btn_ajouter_categorie.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ajouter_categorie.FlatAppearance.BorderSize = 0;
            this.btn_ajouter_categorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter_categorie.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter_categorie.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btn_ajouter_categorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ajouter_categorie.Location = new System.Drawing.Point(14, 27);
            this.btn_ajouter_categorie.Name = "btn_ajouter_categorie";
            this.btn_ajouter_categorie.Size = new System.Drawing.Size(254, 66);
            this.btn_ajouter_categorie.TabIndex = 10;
            this.btn_ajouter_categorie.Text = "Ajouter";
            this.btn_ajouter_categorie.UseVisualStyleBackColor = false;
            this.btn_ajouter_categorie.Click += new System.EventHandler(this.btn_ajouter_categorie_Click);
            // 
            // data_grid_categorie
            // 
            this.data_grid_categorie.AllowUserToAddRows = false;
            this.data_grid_categorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_categorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid_categorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_categorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Modifier,
            this.Supprimer});
            this.data_grid_categorie.EnableHeadersVisualStyles = false;
            this.data_grid_categorie.Location = new System.Drawing.Point(3, 151);
            this.data_grid_categorie.Name = "data_grid_categorie";
            this.data_grid_categorie.RowHeadersVisible = false;
            this.data_grid_categorie.RowHeadersWidth = 51;
            this.data_grid_categorie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_grid_categorie.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data_grid_categorie.RowTemplate.Height = 24;
            this.data_grid_categorie.Size = new System.Drawing.Size(1123, 395);
            this.data_grid_categorie.TabIndex = 18;
            this.data_grid_categorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_categorie_CellContentClick);
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
            this.Column2.HeaderText = "Nom Categorie";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Modifier
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Modifier.DefaultCellStyle = dataGridViewCellStyle2;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.MinimumWidth = 6;
            this.Modifier.Name = "Modifier";
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Supprimer.DefaultCellStyle = dataGridViewCellStyle3;
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.MinimumWidth = 6;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // btn_exel_categorie
            // 
            this.btn_exel_categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exel_categorie.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_exel_categorie.FlatAppearance.BorderSize = 0;
            this.btn_exel_categorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exel_categorie.ForeColor = System.Drawing.Color.White;
            this.btn_exel_categorie.Image = global::GestionDeStock.Properties.Resources.Excel_icon;
            this.btn_exel_categorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exel_categorie.Location = new System.Drawing.Point(684, 586);
            this.btn_exel_categorie.Name = "btn_exel_categorie";
            this.btn_exel_categorie.Size = new System.Drawing.Size(278, 66);
            this.btn_exel_categorie.TabIndex = 23;
            this.btn_exel_categorie.Text = "Export Exel";
            this.btn_exel_categorie.UseVisualStyleBackColor = false;
            this.btn_exel_categorie.Click += new System.EventHandler(this.btn_exel_categorie_Click);
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
            this.btn_imprimer_total.Location = new System.Drawing.Point(146, 587);
            this.btn_imprimer_total.Name = "btn_imprimer_total";
            this.btn_imprimer_total.Size = new System.Drawing.Size(290, 66);
            this.btn_imprimer_total.TabIndex = 22;
            this.btn_imprimer_total.Text = "Imprimer tout les produits";
            this.btn_imprimer_total.UseVisualStyleBackColor = false;
            this.btn_imprimer_total.Click += new System.EventHandler(this.btn_imprimer_total_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Location = new System.Drawing.Point(508, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 5);
            this.panel3.TabIndex = 24;
            // 
            // txt_recherche_categorie
            // 
            this.txt_recherche_categorie.BackColor = System.Drawing.Color.White;
            this.txt_recherche_categorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_recherche_categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recherche_categorie.Location = new System.Drawing.Point(508, 43);
            this.txt_recherche_categorie.Multiline = true;
            this.txt_recherche_categorie.Name = "txt_recherche_categorie";
            this.txt_recherche_categorie.Size = new System.Drawing.Size(319, 50);
            this.txt_recherche_categorie.TabIndex = 25;
            this.txt_recherche_categorie.Text = "Rechercher";
            this.txt_recherche_categorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserListCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_recherche_categorie);
            this.Controls.Add(this.btn_exel_categorie);
            this.Controls.Add(this.btn_imprimer_total);
            this.Controls.Add(this.data_grid_categorie);
            this.Controls.Add(this.btn_ajouter_categorie);
            this.Name = "UserListCategorie";
            this.Size = new System.Drawing.Size(1129, 694);
            this.Load += new System.EventHandler(this.UserListCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_categorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter_categorie;
        private System.Windows.Forms.DataGridView data_grid_categorie;
        private System.Windows.Forms.Button btn_exel_categorie;
        private System.Windows.Forms.Button btn_imprimer_total;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_recherche_categorie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}
