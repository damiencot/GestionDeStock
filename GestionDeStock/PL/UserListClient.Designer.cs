namespace GestionDeStock.PL
{
    partial class UserListClient
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ajouter_client = new System.Windows.Forms.Button();
            this.btn_modifier_client = new System.Windows.Forms.Button();
            this.btn_supprimer_client = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_recherche_client = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_recherche = new System.Windows.Forms.ComboBox();
            this.data_grid_client = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_client)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajouter_client
            // 
            this.btn_ajouter_client.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ajouter_client.FlatAppearance.BorderSize = 0;
            this.btn_ajouter_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter_client.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter_client.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btn_ajouter_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ajouter_client.Location = new System.Drawing.Point(87, 42);
            this.btn_ajouter_client.Name = "btn_ajouter_client";
            this.btn_ajouter_client.Size = new System.Drawing.Size(257, 66);
            this.btn_ajouter_client.TabIndex = 0;
            this.btn_ajouter_client.Text = "Ajouter";
            this.btn_ajouter_client.UseVisualStyleBackColor = false;
            this.btn_ajouter_client.Click += new System.EventHandler(this.btn_ajouter_client_Click);
            // 
            // btn_modifier_client
            // 
            this.btn_modifier_client.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_modifier_client.FlatAppearance.BorderSize = 0;
            this.btn_modifier_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier_client.ForeColor = System.Drawing.Color.White;
            this.btn_modifier_client.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.btn_modifier_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modifier_client.Location = new System.Drawing.Point(404, 42);
            this.btn_modifier_client.Name = "btn_modifier_client";
            this.btn_modifier_client.Size = new System.Drawing.Size(257, 66);
            this.btn_modifier_client.TabIndex = 1;
            this.btn_modifier_client.Text = "Modifier";
            this.btn_modifier_client.UseVisualStyleBackColor = false;
            this.btn_modifier_client.Click += new System.EventHandler(this.btn_modifier_client_Click);
            // 
            // btn_supprimer_client
            // 
            this.btn_supprimer_client.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_supprimer_client.FlatAppearance.BorderSize = 0;
            this.btn_supprimer_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer_client.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer_client.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.btn_supprimer_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supprimer_client.Location = new System.Drawing.Point(746, 42);
            this.btn_supprimer_client.Name = "btn_supprimer_client";
            this.btn_supprimer_client.Size = new System.Drawing.Size(257, 66);
            this.btn_supprimer_client.TabIndex = 2;
            this.btn_supprimer_client.Text = "Supprimer";
            this.btn_supprimer_client.UseVisualStyleBackColor = false;
            this.btn_supprimer_client.Click += new System.EventHandler(this.btn_supprimer_client_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(110, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 5);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(110, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 5);
            this.panel2.TabIndex = 4;
            // 
            // txt_recherche_client
            // 
            this.txt_recherche_client.BackColor = System.Drawing.Color.White;
            this.txt_recherche_client.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_recherche_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recherche_client.Location = new System.Drawing.Point(532, 153);
            this.txt_recherche_client.Multiline = true;
            this.txt_recherche_client.Name = "txt_recherche_client";
            this.txt_recherche_client.Size = new System.Drawing.Size(319, 50);
            this.txt_recherche_client.TabIndex = 5;
            this.txt_recherche_client.Text = "Rechercher";
            this.txt_recherche_client.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_recherche_client.TextChanged += new System.EventHandler(this.txt_recherche_client_TextChanged);
            this.txt_recherche_client.Enter += new System.EventHandler(this.txt_recherche_client_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Location = new System.Drawing.Point(531, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 5);
            this.panel3.TabIndex = 5;
            // 
            // comboBox_recherche
            // 
            this.comboBox_recherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_recherche.FormattingEnabled = true;
            this.comboBox_recherche.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Telephone",
            "Ville",
            "Pays"});
            this.comboBox_recherche.Location = new System.Drawing.Point(213, 163);
            this.comboBox_recherche.Name = "comboBox_recherche";
            this.comboBox_recherche.Size = new System.Drawing.Size(245, 37);
            this.comboBox_recherche.TabIndex = 7;
            this.comboBox_recherche.SelectedIndexChanged += new System.EventHandler(this.comboBox_recherche_SelectedIndexChanged);
            // 
            // data_grid_client
            // 
            this.data_grid_client.AllowUserToAddRows = false;
            this.data_grid_client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_client.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column7,
            this.Column6});
            this.data_grid_client.EnableHeadersVisualStyles = false;
            this.data_grid_client.Location = new System.Drawing.Point(3, 235);
            this.data_grid_client.Name = "data_grid_client";
            this.data_grid_client.RowHeadersVisible = false;
            this.data_grid_client.RowHeadersWidth = 51;
            this.data_grid_client.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_grid_client.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.data_grid_client.RowTemplate.Height = 24;
            this.data_grid_client.Size = new System.Drawing.Size(1123, 447);
            this.data_grid_client.TabIndex = 8;
            this.data_grid_client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_client_CellContentClick);
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
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prenom";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adresse";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telephone";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Email";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Pays";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ville";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // UserListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_grid_client);
            this.Controls.Add(this.comboBox_recherche);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_recherche_client);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_supprimer_client);
            this.Controls.Add(this.btn_modifier_client);
            this.Controls.Add(this.btn_ajouter_client);
            this.Name = "UserListClient";
            this.Size = new System.Drawing.Size(1129, 694);
            this.Load += new System.EventHandler(this.UserListClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter_client;
        private System.Windows.Forms.Button btn_modifier_client;
        private System.Windows.Forms.Button btn_supprimer_client;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_recherche_client;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox_recherche;
        private System.Windows.Forms.DataGridView data_grid_client;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
