namespace GestionDeStock.PL
{
    partial class FrameAjouterModifierCategorie
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
            this.btn_connexion_quitter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_enregistrer_categorie = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_nom_ajout_categorie = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbl_titre_frameAjoutModifier = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connexion_quitter
            // 
            this.btn_connexion_quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_connexion_quitter.FlatAppearance.BorderSize = 0;
            this.btn_connexion_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connexion_quitter.Image = global::GestionDeStock.Properties.Resources.Button_Delete_icon;
            this.btn_connexion_quitter.Location = new System.Drawing.Point(442, 16);
            this.btn_connexion_quitter.Name = "btn_connexion_quitter";
            this.btn_connexion_quitter.Size = new System.Drawing.Size(44, 43);
            this.btn_connexion_quitter.TabIndex = 15;
            this.btn_connexion_quitter.UseVisualStyleBackColor = false;
            this.btn_connexion_quitter.Click += new System.EventHandler(this.btn_connexion_quitter_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(492, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 233);
            this.panel3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 10);
            this.panel1.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 10);
            this.panel4.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 233);
            this.panel2.TabIndex = 17;
            // 
            // btn_enregistrer_categorie
            // 
            this.btn_enregistrer_categorie.BackColor = System.Drawing.Color.Silver;
            this.btn_enregistrer_categorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enregistrer_categorie.Location = new System.Drawing.Point(32, 161);
            this.btn_enregistrer_categorie.Name = "btn_enregistrer_categorie";
            this.btn_enregistrer_categorie.Size = new System.Drawing.Size(439, 56);
            this.btn_enregistrer_categorie.TabIndex = 20;
            this.btn_enregistrer_categorie.Text = "Enregistrer";
            this.btn_enregistrer_categorie.UseVisualStyleBackColor = false;
            this.btn_enregistrer_categorie.Click += new System.EventHandler(this.btn_enregistrer_categorie_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Silver;
            this.panel9.Location = new System.Drawing.Point(61, 115);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(369, 5);
            this.panel9.TabIndex = 19;
            // 
            // txt_nom_ajout_categorie
            // 
            this.txt_nom_ajout_categorie.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_nom_ajout_categorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nom_ajout_categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom_ajout_categorie.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_nom_ajout_categorie.Location = new System.Drawing.Point(61, 83);
            this.txt_nom_ajout_categorie.Multiline = true;
            this.txt_nom_ajout_categorie.Name = "txt_nom_ajout_categorie";
            this.txt_nom_ajout_categorie.Size = new System.Drawing.Size(369, 28);
            this.txt_nom_ajout_categorie.TabIndex = 18;
            this.txt_nom_ajout_categorie.Text = "Nom de Categorie";
            this.txt_nom_ajout_categorie.TextChanged += new System.EventHandler(this.txt_nom_ajout_categorie_TextChanged);
            this.txt_nom_ajout_categorie.Enter += new System.EventHandler(this.txt_nom_ajout_categorie_Enter);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GestionDeStock.Properties.Resources.Categorize_32;
            this.pictureBox5.Location = new System.Drawing.Point(16, 73);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 38);
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // lbl_titre_frameAjoutModifier
            // 
            this.lbl_titre_frameAjoutModifier.AutoSize = true;
            this.lbl_titre_frameAjoutModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_frameAjoutModifier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_titre_frameAjoutModifier.Location = new System.Drawing.Point(50, 19);
            this.lbl_titre_frameAjoutModifier.Name = "lbl_titre_frameAjoutModifier";
            this.lbl_titre_frameAjoutModifier.Size = new System.Drawing.Size(218, 29);
            this.lbl_titre_frameAjoutModifier.TabIndex = 22;
            this.lbl_titre_frameAjoutModifier.Text = "Ajouter Categorie";
            // 
            // FrameAjouterModifierCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(502, 243);
            this.Controls.Add(this.lbl_titre_frameAjoutModifier);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btn_enregistrer_categorie);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txt_nom_ajout_categorie);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_connexion_quitter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrameAjouterModifierCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrameAjouterModifierCategorie";
            this.Load += new System.EventHandler(this.FrameAjouterModifierCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connexion_quitter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_enregistrer_categorie;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.TextBox txt_nom_ajout_categorie;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Label lbl_titre_frameAjoutModifier;
    }
}