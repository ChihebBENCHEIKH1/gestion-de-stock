namespace GestionDeStock.PL
{
    partial class FRM_prod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_prod));
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lbltitre = new System.Windows.Forms.Label();
            this.textprix = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textquantite = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textnomProd = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btneregistrer = new System.Windows.Forms.Button();
            this.btnactualiser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picproduit = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttparcourir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picproduit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox8
            // 
            this.pictureBox8.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.ErrorImage")));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(605, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(33, 30);
            this.pictureBox8.TabIndex = 46;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.Color.Snow;
            this.lbltitre.Location = new System.Drawing.Point(201, 12);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(245, 39);
            this.lbltitre.TabIndex = 24;
            this.lbltitre.Text = "Ajouter Produit";
            this.lbltitre.Click += new System.EventHandler(this.lbltitre_Click);
            // 
            // textprix
            // 
            this.textprix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textprix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textprix.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textprix.ForeColor = System.Drawing.Color.Snow;
            this.textprix.Location = new System.Drawing.Point(419, 277);
            this.textprix.Name = "textprix";
            this.textprix.Size = new System.Drawing.Size(194, 20);
            this.textprix.TabIndex = 37;
            this.textprix.Text = "Prix";
            this.textprix.TextChanged += new System.EventHandler(this.textprix_TextChanged);
            this.textprix.Enter += new System.EventHandler(this.textprix_Enter);
            this.textprix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textprix_KeyPress);
            this.textprix.Leave += new System.EventHandler(this.textprix_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GestionDeStock.Properties.Resources.prix_32;
            this.pictureBox4.Location = new System.Drawing.Point(375, 272);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 35);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Snow;
            this.panel8.Location = new System.Drawing.Point(413, 303);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 1);
            this.panel8.TabIndex = 39;
            // 
            // textquantite
            // 
            this.textquantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textquantite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textquantite.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textquantite.ForeColor = System.Drawing.Color.Snow;
            this.textquantite.Location = new System.Drawing.Point(419, 207);
            this.textquantite.Name = "textquantite";
            this.textquantite.Size = new System.Drawing.Size(194, 20);
            this.textquantite.TabIndex = 40;
            this.textquantite.Text = "Quantité";
            this.textquantite.Enter += new System.EventHandler(this.textquantite_Enter);
            this.textquantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textquantite_KeyPress);
            this.textquantite.Leave += new System.EventHandler(this.textquantite_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GestionDeStock.Properties.Resources.Quantie_32;
            this.pictureBox5.Location = new System.Drawing.Point(375, 202);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 35);
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Snow;
            this.panel9.Location = new System.Drawing.Point(413, 233);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 1);
            this.panel9.TabIndex = 42;
            // 
            // textnomProd
            // 
            this.textnomProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textnomProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textnomProd.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnomProd.ForeColor = System.Drawing.Color.Snow;
            this.textnomProd.Location = new System.Drawing.Point(419, 137);
            this.textnomProd.Name = "textnomProd";
            this.textnomProd.Size = new System.Drawing.Size(194, 20);
            this.textnomProd.TabIndex = 29;
            this.textnomProd.Text = "Nom produit";
            this.textnomProd.TextChanged += new System.EventHandler(this.textnomProd_TextChanged);
            this.textnomProd.Enter += new System.EventHandler(this.textnomProd_Enter);
            this.textnomProd.Leave += new System.EventHandler(this.textnomProd_Leave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.ErrorImage = global::GestionDeStock.Properties.Resources.product_32;
            this.pictureBox7.Image = global::GestionDeStock.Properties.Resources.product_32;
            this.pictureBox7.Location = new System.Drawing.Point(374, 129);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 35);
            this.pictureBox7.TabIndex = 31;
            this.pictureBox7.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Snow;
            this.panel11.Location = new System.Drawing.Point(413, 163);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 1);
            this.panel11.TabIndex = 33;
            // 
            // btneregistrer
            // 
            this.btneregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btneregistrer.FlatAppearance.BorderSize = 0;
            this.btneregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneregistrer.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneregistrer.ForeColor = System.Drawing.Color.Snow;
            this.btneregistrer.Location = new System.Drawing.Point(376, 348);
            this.btneregistrer.Name = "btneregistrer";
            this.btneregistrer.Size = new System.Drawing.Size(237, 48);
            this.btneregistrer.TabIndex = 47;
            this.btneregistrer.Text = "Enregistrer";
            this.btneregistrer.UseVisualStyleBackColor = false;
            this.btneregistrer.Click += new System.EventHandler(this.btneregistrer_Click);
            this.btneregistrer.Leave += new System.EventHandler(this.btneregistrer_Leave);
            // 
            // btnactualiser
            // 
            this.btnactualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.btnactualiser.FlatAppearance.BorderSize = 0;
            this.btnactualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualiser.ForeColor = System.Drawing.Color.Snow;
            this.btnactualiser.Location = new System.Drawing.Point(52, 348);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(237, 48);
            this.btnactualiser.TabIndex = 48;
            this.btnactualiser.Text = "Actualiser";
            this.btnactualiser.UseVisualStyleBackColor = false;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 4);
            this.panel1.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 4);
            this.panel2.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(646, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 429);
            this.panel3.TabIndex = 51;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 429);
            this.panel4.TabIndex = 52;
            // 
            // picproduit
            // 
            this.picproduit.BackColor = System.Drawing.Color.Snow;
            this.picproduit.Location = new System.Drawing.Point(99, 97);
            this.picproduit.Name = "picproduit";
            this.picproduit.Size = new System.Drawing.Size(214, 176);
            this.picproduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picproduit.TabIndex = 53;
            this.picproduit.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Snow;
            this.textBox1.Location = new System.Drawing.Point(25, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 54;
            this.textBox1.Text = "Image:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Snow;
            this.textBox2.Location = new System.Drawing.Point(330, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 55;
            this.textBox2.Text = "Categorie:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(425, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 56;
            // 
            // buttparcourir
            // 
            this.buttparcourir.BackColor = System.Drawing.Color.SteelBlue;
            this.buttparcourir.FlatAppearance.BorderSize = 0;
            this.buttparcourir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttparcourir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttparcourir.ForeColor = System.Drawing.Color.Snow;
            this.buttparcourir.Location = new System.Drawing.Point(187, 279);
            this.buttparcourir.Margin = new System.Windows.Forms.Padding(0);
            this.buttparcourir.Name = "buttparcourir";
            this.buttparcourir.Size = new System.Drawing.Size(126, 28);
            this.buttparcourir.TabIndex = 57;
            this.buttparcourir.Text = "Parcourire...";
            this.buttparcourir.UseVisualStyleBackColor = false;
            this.buttparcourir.Click += new System.EventHandler(this.buttparcourir_Click);
            // 
            // FRM_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(650, 437);
            this.Controls.Add(this.buttparcourir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picproduit);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnactualiser);
            this.Controls.Add(this.btneregistrer);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.textnomProd);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.textquantite);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textprix);
            this.Controls.Add(this.lbltitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_prod";
            this.Load += new System.EventHandler(this.FRM_prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picproduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.Label lbltitre;
        public System.Windows.Forms.TextBox textprix;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox textquantite;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.TextBox textnomProd;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btneregistrer;
        public System.Windows.Forms.Button btnactualiser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttparcourir;
        public System.Windows.Forms.PictureBox picproduit;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}