namespace GestionDeStock.PL
{
    partial class FramePhotoProduit
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_produit = new System.Windows.Forms.PictureBox();
            this.lbl_produitNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_produit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connexion_quitter
            // 
            this.btn_connexion_quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_connexion_quitter.FlatAppearance.BorderSize = 0;
            this.btn_connexion_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connexion_quitter.Image = global::GestionDeStock.Properties.Resources.Button_Delete_icon;
            this.btn_connexion_quitter.Location = new System.Drawing.Point(641, 16);
            this.btn_connexion_quitter.Name = "btn_connexion_quitter";
            this.btn_connexion_quitter.Size = new System.Drawing.Size(44, 43);
            this.btn_connexion_quitter.TabIndex = 46;
            this.btn_connexion_quitter.UseVisualStyleBackColor = false;
            this.btn_connexion_quitter.Click += new System.EventHandler(this.btn_connexion_quitter_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 487);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(681, 10);
            this.panel4.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 487);
            this.panel2.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(691, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 487);
            this.panel3.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 10);
            this.panel1.TabIndex = 42;
            // 
            // picture_produit
            // 
            this.picture_produit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_produit.BackColor = System.Drawing.Color.Silver;
            this.picture_produit.Location = new System.Drawing.Point(16, 80);
            this.picture_produit.Name = "picture_produit";
            this.picture_produit.Size = new System.Drawing.Size(669, 401);
            this.picture_produit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_produit.TabIndex = 47;
            this.picture_produit.TabStop = false;
            this.picture_produit.Click += new System.EventHandler(this.picture_produit_Click);
            // 
            // lbl_produitNom
            // 
            this.lbl_produitNom.AutoSize = true;
            this.lbl_produitNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produitNom.ForeColor = System.Drawing.Color.White;
            this.lbl_produitNom.Location = new System.Drawing.Point(28, 29);
            this.lbl_produitNom.Name = "lbl_produitNom";
            this.lbl_produitNom.Size = new System.Drawing.Size(78, 29);
            this.lbl_produitNom.TabIndex = 48;
            this.lbl_produitNom.Text = "Label";
            this.lbl_produitNom.Click += new System.EventHandler(this.lbl_produitNom_Click);
            // 
            // FramePhotoProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(701, 497);
            this.Controls.Add(this.lbl_produitNom);
            this.Controls.Add(this.picture_produit);
            this.Controls.Add(this.btn_connexion_quitter);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FramePhotoProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FramePhotoProduit";
            ((System.ComponentModel.ISupportInitialize)(this.picture_produit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connexion_quitter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox picture_produit;
        public System.Windows.Forms.Label lbl_produitNom;
    }
}