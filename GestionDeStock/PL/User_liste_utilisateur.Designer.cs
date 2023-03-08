namespace GestionDeStock.PL
{
    partial class User_liste_utilisateur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtrechercheuti = new System.Windows.Forms.TextBox();
            this.dvgutilisateur = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttmodifier = new System.Windows.Forms.Button();
            this.buttsupprimer = new System.Windows.Forms.Button();
            this.buttajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgutilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrechercheuti
            // 
            this.txtrechercheuti.BackColor = System.Drawing.SystemColors.Control;
            this.txtrechercheuti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrechercheuti.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrechercheuti.Location = new System.Drawing.Point(482, 144);
            this.txtrechercheuti.Name = "txtrechercheuti";
            this.txtrechercheuti.Size = new System.Drawing.Size(211, 31);
            this.txtrechercheuti.TabIndex = 27;
            this.txtrechercheuti.Text = "Recherche";
            this.txtrechercheuti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrechercheuti.TextChanged += new System.EventHandler(this.txtrecherchecl_TextChanged);
            this.txtrechercheuti.Enter += new System.EventHandler(this.txtrechercheuti_Enter);
            this.txtrechercheuti.Leave += new System.EventHandler(this.txtrechercheuti_Leave);
            // 
            // dvgutilisateur
            // 
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgutilisateur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dvgutilisateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgutilisateur.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgutilisateur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgutilisateur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgutilisateur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dvgutilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgutilisateur.DefaultCellStyle = dataGridViewCellStyle27;
            this.dvgutilisateur.EnableHeadersVisualStyles = false;
            this.dvgutilisateur.Location = new System.Drawing.Point(58, 254);
            this.dvgutilisateur.Name = "dvgutilisateur";
            this.dvgutilisateur.ReadOnly = true;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgutilisateur.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dvgutilisateur.Size = new System.Drawing.Size(1021, 324);
            this.dvgutilisateur.TabIndex = 25;
            this.dvgutilisateur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgutilisateur_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(357, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 2);
            this.panel1.TabIndex = 24;
            // 
            // buttmodifier
            // 
            this.buttmodifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttmodifier.FlatAppearance.BorderSize = 0;
            this.buttmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttmodifier.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttmodifier.ForeColor = System.Drawing.Color.Snow;
            this.buttmodifier.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.buttmodifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttmodifier.Location = new System.Drawing.Point(433, 46);
            this.buttmodifier.Name = "buttmodifier";
            this.buttmodifier.Size = new System.Drawing.Size(260, 50);
            this.buttmodifier.TabIndex = 23;
            this.buttmodifier.Text = "       Modifier";
            this.buttmodifier.UseVisualStyleBackColor = false;
            this.buttmodifier.Click += new System.EventHandler(this.buttmodifier_Click);
            // 
            // buttsupprimer
            // 
            this.buttsupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttsupprimer.FlatAppearance.BorderSize = 0;
            this.buttsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttsupprimer.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttsupprimer.ForeColor = System.Drawing.Color.Snow;
            this.buttsupprimer.Image = global::GestionDeStock.Properties.Resources.Button_Delete_icon;
            this.buttsupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttsupprimer.Location = new System.Drawing.Point(824, 46);
            this.buttsupprimer.Name = "buttsupprimer";
            this.buttsupprimer.Size = new System.Drawing.Size(255, 50);
            this.buttsupprimer.TabIndex = 22;
            this.buttsupprimer.Text = "    Supprimer";
            this.buttsupprimer.UseVisualStyleBackColor = false;
            this.buttsupprimer.Click += new System.EventHandler(this.buttsupprimer_Click);
            // 
            // buttajouter
            // 
            this.buttajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttajouter.FlatAppearance.BorderSize = 0;
            this.buttajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttajouter.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttajouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttajouter.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.buttajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttajouter.Location = new System.Drawing.Point(58, 46);
            this.buttajouter.Name = "buttajouter";
            this.buttajouter.Size = new System.Drawing.Size(254, 50);
            this.buttajouter.TabIndex = 21;
            this.buttajouter.Text = "        Ajouter";
            this.buttajouter.UseVisualStyleBackColor = false;
            this.buttajouter.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(781, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Powered by Chiheb Ben Cheikh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // User_liste_utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrechercheuti);
            this.Controls.Add(this.dvgutilisateur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttmodifier);
            this.Controls.Add(this.buttsupprimer);
            this.Controls.Add(this.buttajouter);
            this.Name = "User_liste_utilisateur";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.Load += new System.EventHandler(this.User_liste_utilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgutilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrechercheuti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttmodifier;
        private System.Windows.Forms.Button buttsupprimer;
        private System.Windows.Forms.Button buttajouter;
        public System.Windows.Forms.DataGridView dvgutilisateur;
        public System.Windows.Forms.Label label1;
    }
}
