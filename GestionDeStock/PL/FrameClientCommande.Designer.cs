namespace GestionDeStock.PL
{
    partial class FrameClientCommande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_grid_client_commande = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_client_commande)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_client_commande
            // 
            this.data_grid_client_commande.AllowUserToAddRows = false;
            this.data_grid_client_commande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_client_commande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid_client_commande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_client_commande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column7,
            this.Column6});
            this.data_grid_client_commande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_grid_client_commande.EnableHeadersVisualStyles = false;
            this.data_grid_client_commande.Location = new System.Drawing.Point(0, 0);
            this.data_grid_client_commande.Name = "data_grid_client_commande";
            this.data_grid_client_commande.RowHeadersVisible = false;
            this.data_grid_client_commande.RowHeadersWidth = 51;
            this.data_grid_client_commande.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_grid_client_commande.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.data_grid_client_commande.RowTemplate.Height = 24;
            this.data_grid_client_commande.Size = new System.Drawing.Size(1011, 518);
            this.data_grid_client_commande.TabIndex = 9;
            this.data_grid_client_commande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_client_commande_CellContentClick);
            this.data_grid_client_commande.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_client_commande_CellContentDoubleClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
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
            // FrameClientCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 518);
            this.Controls.Add(this.data_grid_client_commande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrameClientCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste Client";
            this.Load += new System.EventHandler(this.FrameClientCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_client_commande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView data_grid_client_commande;
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