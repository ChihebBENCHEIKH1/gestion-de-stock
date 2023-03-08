namespace GestionDeStock.rap
{
    partial class FRM_rapport
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
            this.RPTfichier = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RPTfichier
            // 
            this.RPTfichier.LocalReport.ReportEmbeddedResource = "GestionDeStock.rap.RPT_produit.rdlc";
            this.RPTfichier.Location = new System.Drawing.Point(-1, 1);
            this.RPTfichier.Name = "RPTfichier";
            this.RPTfichier.ServerReport.BearerToken = null;
            this.RPTfichier.Size = new System.Drawing.Size(803, 452);
            this.RPTfichier.TabIndex = 0;
            // 
            // FRM_rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RPTfichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_rapport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rapporte";
            this.Load += new System.EventHandler(this.FRM_rapport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RPTfichier;
    }
}