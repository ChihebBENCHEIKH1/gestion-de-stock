namespace GestionDeStock.PL
{
    partial class User_liste_prod
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtrechercheprod = new System.Windows.Forms.TextBox();
            this.comborecherche = new System.Windows.Forms.ComboBox();
            this.dvgprod = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gESTION_DE_STOCKDataSet12 = new GestionDeStock.GESTION_DE_STOCKDataSet12();
            this.buttselectTout = new System.Windows.Forms.Button();
            this.buttexcel = new System.Windows.Forms.Button();
            this.buttselect = new System.Windows.Forms.Button();
            this.buttafficher = new System.Windows.Forms.Button();
            this.buttmodifier = new System.Windows.Forms.Button();
            this.buttsupprimer = new System.Windows.Forms.Button();
            this.buttajoute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgprod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrechercheprod
            // 
            this.txtrechercheprod.BackColor = System.Drawing.SystemColors.Control;
            this.txtrechercheprod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrechercheprod.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrechercheprod.Location = new System.Drawing.Point(660, 161);
            this.txtrechercheprod.Name = "txtrechercheprod";
            this.txtrechercheprod.Size = new System.Drawing.Size(211, 31);
            this.txtrechercheprod.TabIndex = 27;
            this.txtrechercheprod.Text = "Recherche";
            this.txtrechercheprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrechercheprod.TextChanged += new System.EventHandler(this.txtrechercheprod_TextChanged);
            this.txtrechercheprod.Enter += new System.EventHandler(this.txtrechercheprod_Enter);
            this.txtrechercheprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrechercheprod_KeyPress);
            this.txtrechercheprod.Leave += new System.EventHandler(this.txtrechercheprod_Leave);
            // 
            // comborecherche
            // 
            this.comborecherche.FormattingEnabled = true;
            this.comborecherche.Items.AddRange(new object[] {
            "Tout",
            "Nom_Produit",
            ""});
            this.comborecherche.Location = new System.Drawing.Point(240, 174);
            this.comborecherche.Name = "comborecherche";
            this.comborecherche.Size = new System.Drawing.Size(212, 21);
            this.comborecherche.TabIndex = 26;
            this.comborecherche.SelectedIndexChanged += new System.EventHandler(this.comborecherche_SelectedIndexChanged_1);
            // 
            // dvgprod
            // 
            this.dvgprod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dvgprod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgprod.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgprod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgprod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dvgprod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgprod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dvgprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgprod.DefaultCellStyle = dataGridViewCellStyle20;
            this.dvgprod.EnableHeadersVisualStyles = false;
            this.dvgprod.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dvgprod.Location = new System.Drawing.Point(23, 242);
            this.dvgprod.Name = "dvgprod";
            this.dvgprod.ReadOnly = true;
            this.dvgprod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgprod.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dvgprod.RowHeadersWidth = 40;
            this.dvgprod.Size = new System.Drawing.Size(1054, 249);
            this.dvgprod.TabIndex = 200;
            this.dvgprod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgprod_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(639, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 2);
            this.panel1.TabIndex = 24;
            // 
            // gESTION_DE_STOCKDataSet12
            // 
            this.gESTION_DE_STOCKDataSet12.DataSetName = "GESTION_DE_STOCKDataSet12";
            this.gESTION_DE_STOCKDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttselectTout
            // 
            this.buttselectTout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttselectTout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttselectTout.FlatAppearance.BorderSize = 0;
            this.buttselectTout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttselectTout.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttselectTout.ForeColor = System.Drawing.Color.Snow;
            this.buttselectTout.Image = global::GestionDeStock.Properties.Resources.print_icon;
            this.buttselectTout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttselectTout.Location = new System.Drawing.Point(446, 554);
            this.buttselectTout.Name = "buttselectTout";
            this.buttselectTout.Size = new System.Drawing.Size(260, 61);
            this.buttselectTout.TabIndex = 31;
            this.buttselectTout.Text = "       Imprimer toutes";
            this.buttselectTout.UseVisualStyleBackColor = false;
            this.buttselectTout.Click += new System.EventHandler(this.buttselectTout_Click);
            // 
            // buttexcel
            // 
            this.buttexcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttexcel.FlatAppearance.BorderSize = 0;
            this.buttexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttexcel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttexcel.ForeColor = System.Drawing.Color.Snow;
            this.buttexcel.Image = global::GestionDeStock.Properties.Resources.Excel_icon;
            this.buttexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttexcel.Location = new System.Drawing.Point(831, 554);
            this.buttexcel.Name = "buttexcel";
            this.buttexcel.Size = new System.Drawing.Size(255, 61);
            this.buttexcel.TabIndex = 30;
            this.buttexcel.Text = "      Sauvgarder dans Excel";
            this.buttexcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttexcel.UseVisualStyleBackColor = false;
            this.buttexcel.Click += new System.EventHandler(this.buttexcel_Click);
            // 
            // buttselect
            // 
            this.buttselect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttselect.FlatAppearance.BorderSize = 0;
            this.buttselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttselect.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttselect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttselect.Image = global::GestionDeStock.Properties.Resources.Imprimer;
            this.buttselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttselect.Location = new System.Drawing.Point(68, 554);
            this.buttselect.Name = "buttselect";
            this.buttselect.Size = new System.Drawing.Size(254, 61);
            this.buttselect.TabIndex = 29;
            this.buttselect.Text = "        Imprimer PR cocher";
            this.buttselect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttselect.UseVisualStyleBackColor = true;
            this.buttselect.Click += new System.EventHandler(this.buttselect_Click);
            // 
            // buttafficher
            // 
            this.buttafficher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttafficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttafficher.FlatAppearance.BorderSize = 0;
            this.buttafficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttafficher.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttafficher.ForeColor = System.Drawing.Color.Snow;
            this.buttafficher.Image = global::GestionDeStock.Properties.Resources.Pictures_icon;
            this.buttafficher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttafficher.Location = new System.Drawing.Point(868, 63);
            this.buttafficher.Name = "buttafficher";
            this.buttafficher.Size = new System.Drawing.Size(218, 50);
            this.buttafficher.TabIndex = 28;
            this.buttafficher.Text = "    Afficher Photo";
            this.buttafficher.UseVisualStyleBackColor = false;
            this.buttafficher.Click += new System.EventHandler(this.buttafficher_Click_1);
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
            this.buttmodifier.Location = new System.Drawing.Point(303, 63);
            this.buttmodifier.Name = "buttmodifier";
            this.buttmodifier.Size = new System.Drawing.Size(194, 50);
            this.buttmodifier.TabIndex = 23;
            this.buttmodifier.Text = "       Modifier";
            this.buttmodifier.UseVisualStyleBackColor = false;
            this.buttmodifier.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttsupprimer
            // 
            this.buttsupprimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttsupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttsupprimer.FlatAppearance.BorderSize = 0;
            this.buttsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttsupprimer.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttsupprimer.ForeColor = System.Drawing.Color.Snow;
            this.buttsupprimer.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.buttsupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttsupprimer.Location = new System.Drawing.Point(600, 63);
            this.buttsupprimer.Name = "buttsupprimer";
            this.buttsupprimer.Size = new System.Drawing.Size(206, 50);
            this.buttsupprimer.TabIndex = 22;
            this.buttsupprimer.Text = "    Supprimer";
            this.buttsupprimer.UseVisualStyleBackColor = false;
            this.buttsupprimer.Click += new System.EventHandler(this.buttsupprimer_Click);
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
            this.buttajoute.Location = new System.Drawing.Point(43, 63);
            this.buttajoute.Name = "buttajoute";
            this.buttajoute.Size = new System.Drawing.Size(190, 50);
            this.buttajoute.TabIndex = 21;
            this.buttajoute.Text = "        Ajouter";
            this.buttajoute.UseVisualStyleBackColor = false;
            this.buttajoute.Click += new System.EventHandler(this.buttajoute_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(781, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 201;
            this.label1.Text = "Powered by Chiheb Ben Cheikh";
            // 
            // User_liste_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttselectTout);
            this.Controls.Add(this.buttexcel);
            this.Controls.Add(this.buttselect);
            this.Controls.Add(this.buttafficher);
            this.Controls.Add(this.txtrechercheprod);
            this.Controls.Add(this.comborecherche);
            this.Controls.Add(this.dvgprod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttmodifier);
            this.Controls.Add(this.buttsupprimer);
            this.Controls.Add(this.buttajoute);
            this.Name = "User_liste_prod";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.Load += new System.EventHandler(this.User_liste_prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgprod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrechercheprod;
        private System.Windows.Forms.ComboBox comborecherche;
        private System.Windows.Forms.DataGridView dvgprod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttajoute;
        private System.Windows.Forms.Button buttafficher;
        private System.Windows.Forms.Button buttselectTout;
        private System.Windows.Forms.Button buttexcel;
        private System.Windows.Forms.Button buttselect;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCATEGORIEDataGridViewTextBoxColumn;
        private GESTION_DE_STOCKDataSet12 gESTION_DE_STOCKDataSet12;
        public System.Windows.Forms.Button buttmodifier;
        public System.Windows.Forms.Button buttsupprimer;
        private System.Windows.Forms.Label label1;
    }
}
