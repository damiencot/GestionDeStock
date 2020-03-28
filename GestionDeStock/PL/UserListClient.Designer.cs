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
            this.btn_ajouter_client = new System.Windows.Forms.Button();
            this.btn_modifier_client = new System.Windows.Forms.Button();
            this.btn_supprimer_client = new System.Windows.Forms.Button();
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
            this.btn_ajouter_client.Location = new System.Drawing.Point(110, 42);
            this.btn_ajouter_client.Name = "btn_ajouter_client";
            this.btn_ajouter_client.Size = new System.Drawing.Size(257, 66);
            this.btn_ajouter_client.TabIndex = 0;
            this.btn_ajouter_client.Text = "Ajouter";
            this.btn_ajouter_client.UseVisualStyleBackColor = false;
            // 
            // btn_modifier_client
            // 
            this.btn_modifier_client.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_modifier_client.FlatAppearance.BorderSize = 0;
            this.btn_modifier_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier_client.ForeColor = System.Drawing.Color.White;
            this.btn_modifier_client.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.btn_modifier_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modifier_client.Location = new System.Drawing.Point(427, 42);
            this.btn_modifier_client.Name = "btn_modifier_client";
            this.btn_modifier_client.Size = new System.Drawing.Size(257, 66);
            this.btn_modifier_client.TabIndex = 1;
            this.btn_modifier_client.Text = "Modifier";
            this.btn_modifier_client.UseVisualStyleBackColor = false;
            // 
            // btn_supprimer_client
            // 
            this.btn_supprimer_client.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_supprimer_client.FlatAppearance.BorderSize = 0;
            this.btn_supprimer_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer_client.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer_client.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.btn_supprimer_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supprimer_client.Location = new System.Drawing.Point(754, 42);
            this.btn_supprimer_client.Name = "btn_supprimer_client";
            this.btn_supprimer_client.Size = new System.Drawing.Size(257, 66);
            this.btn_supprimer_client.TabIndex = 2;
            this.btn_supprimer_client.Text = "Supprimer";
            this.btn_supprimer_client.UseVisualStyleBackColor = false;
            // 
            // UserListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_supprimer_client);
            this.Controls.Add(this.btn_modifier_client);
            this.Controls.Add(this.btn_ajouter_client);
            this.Name = "UserListClient";
            this.Size = new System.Drawing.Size(1137, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter_client;
        private System.Windows.Forms.Button btn_modifier_client;
        private System.Windows.Forms.Button btn_supprimer_client;
    }
}
