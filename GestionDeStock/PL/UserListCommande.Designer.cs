namespace GestionDeStock.PL
{
    partial class UserListCommande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ajouter_categorie = new System.Windows.Forms.Button();
            this.data_grid_categorie = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_imprimer_commande = new System.Windows.Forms.Button();
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
            this.btn_ajouter_categorie.Location = new System.Drawing.Point(15, 15);
            this.btn_ajouter_categorie.Name = "btn_ajouter_categorie";
            this.btn_ajouter_categorie.Size = new System.Drawing.Size(193, 66);
            this.btn_ajouter_categorie.TabIndex = 11;
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
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.data_grid_categorie.EnableHeadersVisualStyles = false;
            this.data_grid_categorie.Location = new System.Drawing.Point(3, 87);
            this.data_grid_categorie.Name = "data_grid_categorie";
            this.data_grid_categorie.RowHeadersVisible = false;
            this.data_grid_categorie.RowHeadersWidth = 51;
            this.data_grid_categorie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_grid_categorie.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.data_grid_categorie.RowTemplate.Height = 24;
            this.data_grid_categorie.Size = new System.Drawing.Size(971, 329);
            this.data_grid_categorie.TabIndex = 19;
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
            this.Column2.HeaderText = "Date";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Client";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total HT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TVA";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total TTC";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.Green;
            this.lbl_date.Location = new System.Drawing.Point(214, 36);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(127, 25);
            this.lbl_date.TabIndex = 20;
            this.lbl_date.Text = "Date Début:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(554, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Date Début:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(337, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(677, 37);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(204, 22);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // btn_imprimer_commande
            // 
            this.btn_imprimer_commande.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_imprimer_commande.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_imprimer_commande.FlatAppearance.BorderSize = 0;
            this.btn_imprimer_commande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimer_commande.ForeColor = System.Drawing.Color.White;
            this.btn_imprimer_commande.Image = global::GestionDeStock.Properties.Resources.Imprimer;
            this.btn_imprimer_commande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imprimer_commande.Location = new System.Drawing.Point(649, 440);
            this.btn_imprimer_commande.Name = "btn_imprimer_commande";
            this.btn_imprimer_commande.Size = new System.Drawing.Size(290, 66);
            this.btn_imprimer_commande.TabIndex = 24;
            this.btn_imprimer_commande.Text = "Imprimer Commande";
            this.btn_imprimer_commande.UseVisualStyleBackColor = false;
            // 
            // UserListCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_imprimer_commande);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.data_grid_categorie);
            this.Controls.Add(this.btn_ajouter_categorie);
            this.Name = "UserListCommande";
            this.Size = new System.Drawing.Size(977, 524);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_categorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter_categorie;
        private System.Windows.Forms.DataGridView data_grid_categorie;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_imprimer_commande;
    }
}
