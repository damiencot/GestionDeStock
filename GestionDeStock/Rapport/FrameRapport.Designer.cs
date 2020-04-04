namespace GestionDeStock.PL
{
    partial class FrameRapport
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
            this.rapport_show_produit = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rapport_show_produit
            // 
            this.rapport_show_produit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rapport_show_produit.Location = new System.Drawing.Point(0, 0);
            this.rapport_show_produit.Name = "rapport_show_produit";
            this.rapport_show_produit.ServerReport.BearerToken = null;
            this.rapport_show_produit.Size = new System.Drawing.Size(876, 546);
            this.rapport_show_produit.TabIndex = 0;
            this.rapport_show_produit.Load += new System.EventHandler(this.rapport_show_produit_Load);
            // 
            // FrameRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 546);
            this.Controls.Add(this.rapport_show_produit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrameRapport";
            this.Text = "FrameRapport";
            this.Load += new System.EventHandler(this.FrameRapport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rapport_show_produit;
    }
}