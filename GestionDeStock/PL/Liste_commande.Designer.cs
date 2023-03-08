namespace GestionDeStock.PL
{
    partial class Liste_commande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgcommande = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_commande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomprenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dd = new System.Windows.Forms.DateTimePicker();
            this.df = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttajoute = new System.Windows.Forms.Button();
            this.buttselectTout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgcommande
            // 
            this.dvgcommande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgcommande.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgcommande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgcommande.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgcommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dvgcommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgcommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.date_commande,
            this.nomprenom,
            this.totalht,
            this.TVA,
            this.TotalTTC});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgcommande.DefaultCellStyle = dataGridViewCellStyle10;
            this.dvgcommande.EnableHeadersVisualStyles = false;
            this.dvgcommande.Location = new System.Drawing.Point(8, 105);
            this.dvgcommande.Name = "dvgcommande";
            this.dvgcommande.ReadOnly = true;
            this.dvgcommande.Size = new System.Drawing.Size(1116, 341);
            this.dvgcommande.TabIndex = 0;
            this.dvgcommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgcommande_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Commande";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 180;
            // 
            // date_commande
            // 
            this.date_commande.HeaderText = "Date Commande";
            this.date_commande.Name = "date_commande";
            this.date_commande.ReadOnly = true;
            this.date_commande.Width = 180;
            // 
            // nomprenom
            // 
            this.nomprenom.HeaderText = "Nom complet";
            this.nomprenom.Name = "nomprenom";
            this.nomprenom.ReadOnly = true;
            this.nomprenom.Width = 180;
            // 
            // totalht
            // 
            this.totalht.HeaderText = "Total HT";
            this.totalht.Name = "totalht";
            this.totalht.ReadOnly = true;
            this.totalht.Width = 180;
            // 
            // TVA
            // 
            this.TVA.HeaderText = "TVA(%)";
            this.TVA.Name = "TVA";
            this.TVA.ReadOnly = true;
            this.TVA.Width = 180;
            // 
            // TotalTTC
            // 
            this.TotalTTC.HeaderText = "Total TTC";
            this.TotalTTC.Name = "TotalTTC";
            this.TotalTTC.ReadOnly = true;
            this.TotalTTC.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(270, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Date debut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(611, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "Date fin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dd
            // 
            this.dd.Font = new System.Drawing.Font("Microsoft Himalaya", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd.Location = new System.Drawing.Point(410, 41);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(181, 22);
            this.dd.TabIndex = 25;
            this.dd.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // df
            // 
            this.df.Font = new System.Drawing.Font("Microsoft Himalaya", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.df.Location = new System.Drawing.Point(741, 41);
            this.df.Name = "df";
            this.df.Size = new System.Drawing.Size(200, 22);
            this.df.TabIndex = 26;
            this.df.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::GestionDeStock.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(1015, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttajoute
            // 
            this.buttajoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttajoute.FlatAppearance.BorderSize = 0;
            this.buttajoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttajoute.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttajoute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttajoute.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.buttajoute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttajoute.Location = new System.Drawing.Point(32, 26);
            this.buttajoute.Name = "buttajoute";
            this.buttajoute.Size = new System.Drawing.Size(190, 50);
            this.buttajoute.TabIndex = 22;
            this.buttajoute.Text = "        Ajouter";
            this.buttajoute.UseVisualStyleBackColor = false;
            this.buttajoute.Click += new System.EventHandler(this.buttajoute_Click);
            // 
            // buttselectTout
            // 
            this.buttselectTout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttselectTout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttselectTout.FlatAppearance.BorderSize = 0;
            this.buttselectTout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttselectTout.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttselectTout.ForeColor = System.Drawing.Color.Snow;
            this.buttselectTout.Image = global::GestionDeStock.Properties.Resources.print_icon;
            this.buttselectTout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttselectTout.Location = new System.Drawing.Point(754, 413);
            this.buttselectTout.Name = "buttselectTout";
            this.buttselectTout.Size = new System.Drawing.Size(298, 61);
            this.buttselectTout.TabIndex = 34;
            this.buttselectTout.Text = "       Imprimer Commande";
            this.buttselectTout.UseVisualStyleBackColor = false;
            this.buttselectTout.Click += new System.EventHandler(this.buttselectTout_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(781, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "©Powered by Chiheb Ben Cheikh";
            // 
            // Liste_commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttselectTout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.df);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttajoute);
            this.Controls.Add(this.dvgcommande);
            this.Name = "Liste_commande";
            this.Size = new System.Drawing.Size(1175, 720);
            this.Load += new System.EventHandler(this.Liste_commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgcommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttajoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dd;
        private System.Windows.Forms.DateTimePicker df;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dvgcommande;
        private System.Windows.Forms.Button buttselectTout;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomprenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalht;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTTC;
        private System.Windows.Forms.Label label3;
    }
}
