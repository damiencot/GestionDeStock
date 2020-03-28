namespace GestionDeStock.PL
{
    partial class FrameConnexion
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
            this.panel_connexion = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_connexion_quitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_connexion_user = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_connexion_password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_connexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_connexion
            // 
            this.panel_connexion.BackColor = System.Drawing.Color.Red;
            this.panel_connexion.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_connexion.Location = new System.Drawing.Point(420, 0);
            this.panel_connexion.Name = "panel_connexion";
            this.panel_connexion.Size = new System.Drawing.Size(2, 436);
            this.panel_connexion.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 2);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 434);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(2, 434);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 2);
            this.panel3.TabIndex = 3;
            // 
            // btn_connexion_quitter
            // 
            this.btn_connexion_quitter.FlatAppearance.BorderSize = 0;
            this.btn_connexion_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connexion_quitter.Image = global::GestionDeStock.Properties.Resources.Button_Delete_icon;
            this.btn_connexion_quitter.Location = new System.Drawing.Point(375, 3);
            this.btn_connexion_quitter.Name = "btn_connexion_quitter";
            this.btn_connexion_quitter.Size = new System.Drawing.Size(44, 43);
            this.btn_connexion_quitter.TabIndex = 4;
            this.btn_connexion_quitter.UseVisualStyleBackColor = false;
            this.btn_connexion_quitter.Click += new System.EventHandler(this.btn_connexion_quitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(108, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Connexion";
            // 
            // txt_connexion_user
            // 
            this.txt_connexion_user.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_connexion_user.Location = new System.Drawing.Point(66, 189);
            this.txt_connexion_user.Name = "txt_connexion_user";
            this.txt_connexion_user.Size = new System.Drawing.Size(329, 22);
            this.txt_connexion_user.TabIndex = 6;
            this.txt_connexion_user.Text = "Utilisateurs";
            this.txt_connexion_user.Enter += new System.EventHandler(this.txt_connexion_user_Enter);
            this.txt_connexion_user.Leave += new System.EventHandler(this.txt_connexion_user_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Honeydew;
            this.panel4.Location = new System.Drawing.Point(65, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(329, 1);
            this.panel4.TabIndex = 7;
            // 
            // txt_connexion_password
            // 
            this.txt_connexion_password.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_connexion_password.Location = new System.Drawing.Point(65, 251);
            this.txt_connexion_password.Name = "txt_connexion_password";
            this.txt_connexion_password.PasswordChar = '*';
            this.txt_connexion_password.Size = new System.Drawing.Size(330, 22);
            this.txt_connexion_password.TabIndex = 8;
            this.txt_connexion_password.Text = "Mot de Passe";
            this.txt_connexion_password.Enter += new System.EventHandler(this.txt_connexion_password_Enter);
            this.txt_connexion_password.Leave += new System.EventHandler(this.txt_connexion_password_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionDeStock.Properties.Resources.login_32;
            this.pictureBox1.Location = new System.Drawing.Point(12, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestionDeStock.Properties.Resources.Motdepasse_32;
            this.pictureBox2.Location = new System.Drawing.Point(12, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Location = new System.Drawing.Point(65, 278);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(329, 1);
            this.panel5.TabIndex = 8;
            // 
            // btn_connexion
            // 
            this.btn_connexion.BackColor = System.Drawing.Color.Red;
            this.btn_connexion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connexion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_connexion.Location = new System.Drawing.Point(65, 323);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(329, 51);
            this.btn_connexion.TabIndex = 11;
            this.btn_connexion.Text = "Se Connecter";
            this.btn_connexion.UseVisualStyleBackColor = false;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // FrameConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(422, 436);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_connexion_password);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_connexion_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_connexion_quitter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_connexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrameConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_connexion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_connexion_quitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_connexion_user;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_connexion_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_connexion;
    }
}