namespace GestionDeStock.PL
{
    partial class User_liste_categorie
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtrecherchecat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvgcategorie = new System.Windows.Forms.DataGridView();
            this.iDCATEGORIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_DE_STOCKDataSet5 = new GestionDeStock.GESTION_DE_STOCKDataSet5();
            this.categorieTableAdapter = new GestionDeStock.GESTION_DE_STOCKDataSet5TableAdapters.CategorieTableAdapter();
            this.buttselectTout = new System.Windows.Forms.Button();
            this.buttselect = new System.Windows.Forms.Button();
            this.buttajoute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrecherchecat
            // 
            this.txtrecherchecat.BackColor = System.Drawing.SystemColors.Control;
            this.txtrecherchecat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherchecat.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherchecat.Location = new System.Drawing.Point(621, 32);
            this.txtrecherchecat.Name = "txtrecherchecat";
            this.txtrecherchecat.Size = new System.Drawing.Size(211, 31);
            this.txtrecherchecat.TabIndex = 29;
            this.txtrecherchecat.Text = "Recherche";
            this.txtrecherchecat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrecherchecat.TextChanged += new System.EventHandler(this.txtrecherchecat_TextChanged);
            this.txtrecherchecat.Enter += new System.EventHandler(this.txtrechercheprod_Enter);
            this.txtrecherchecat.Leave += new System.EventHandler(this.txtrecherchecat_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(486, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 1);
            this.panel1.TabIndex = 28;
            // 
            // dvgcategorie
            // 
            this.dvgcategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgcategorie.AutoGenerateColumns = false;
            this.dvgcategorie.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgcategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgcategorie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgcategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dvgcategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgcategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCATEGORIEDataGridViewTextBoxColumn,
            this.nomCategorieDataGridViewTextBoxColumn,
            this.Modifier,
            this.Supprimer});
            this.dvgcategorie.DataSource = this.categorieBindingSource;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgcategorie.DefaultCellStyle = dataGridViewCellStyle30;
            this.dvgcategorie.EnableHeadersVisualStyles = false;
            this.dvgcategorie.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dvgcategorie.Location = new System.Drawing.Point(42, 119);
            this.dvgcategorie.Name = "dvgcategorie";
            this.dvgcategorie.ReadOnly = true;
            this.dvgcategorie.Size = new System.Drawing.Size(1110, 496);
            this.dvgcategorie.TabIndex = 30;
            this.dvgcategorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dvgcategorie.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dvgcategorie_DefaultValuesNeeded);
            // 
            // iDCATEGORIEDataGridViewTextBoxColumn
            // 
            this.iDCATEGORIEDataGridViewTextBoxColumn.DataPropertyName = "ID_CATEGORIE";
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            this.iDCATEGORIEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle26;
            this.iDCATEGORIEDataGridViewTextBoxColumn.HeaderText = "                                           ID";
            this.iDCATEGORIEDataGridViewTextBoxColumn.Name = "iDCATEGORIEDataGridViewTextBoxColumn";
            this.iDCATEGORIEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCATEGORIEDataGridViewTextBoxColumn.Width = 400;
            // 
            // nomCategorieDataGridViewTextBoxColumn
            // 
            this.nomCategorieDataGridViewTextBoxColumn.DataPropertyName = "Nom_Categorie";
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            this.nomCategorieDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle27;
            this.nomCategorieDataGridViewTextBoxColumn.HeaderText = "                                          Nom";
            this.nomCategorieDataGridViewTextBoxColumn.Name = "nomCategorieDataGridViewTextBoxColumn";
            this.nomCategorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomCategorieDataGridViewTextBoxColumn.Width = 400;
            // 
            // Modifier
            // 
            this.Modifier.DataPropertyName = "Modifer";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Modifier.DefaultCellStyle = dataGridViewCellStyle28;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            this.Supprimer.DataPropertyName = "Supprimer";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Red;
            this.Supprimer.DefaultCellStyle = dataGridViewCellStyle29;
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.gESTION_DE_STOCKDataSet5;
            // 
            // gESTION_DE_STOCKDataSet5
            // 
            this.gESTION_DE_STOCKDataSet5.DataSetName = "GESTION_DE_STOCKDataSet5";
            this.gESTION_DE_STOCKDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
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
            this.buttselectTout.Location = new System.Drawing.Point(793, 542);
            this.buttselectTout.Name = "buttselectTout";
            this.buttselectTout.Size = new System.Drawing.Size(260, 61);
            this.buttselectTout.TabIndex = 33;
            this.buttselectTout.Text = "       Imprimer toutes";
            this.buttselectTout.UseVisualStyleBackColor = false;
            this.buttselectTout.Click += new System.EventHandler(this.buttselectTout_Click);
            // 
            // buttselect
            // 
            this.buttselect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttselect.FlatAppearance.BorderSize = 0;
            this.buttselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttselect.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttselect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttselect.Image = global::GestionDeStock.Properties.Resources.Excel_icon;
            this.buttselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttselect.Location = new System.Drawing.Point(75, 542);
            this.buttselect.Name = "buttselect";
            this.buttselect.Size = new System.Drawing.Size(254, 61);
            this.buttselect.TabIndex = 32;
            this.buttselect.Text = "     Sauvgarder categorie";
            this.buttselect.UseVisualStyleBackColor = true;
            this.buttselect.Click += new System.EventHandler(this.buttselect_Click);
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
            this.buttajoute.Location = new System.Drawing.Point(57, 21);
            this.buttajoute.Name = "buttajoute";
            this.buttajoute.Size = new System.Drawing.Size(280, 50);
            this.buttajoute.TabIndex = 22;
            this.buttajoute.Text = "        Ajouter";
            this.buttajoute.UseVisualStyleBackColor = false;
            this.buttajoute.Click += new System.EventHandler(this.buttajoute_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(781, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Powered by Chiheb Ben Cheikh";
            // 
            // User_liste_categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttselectTout);
            this.Controls.Add(this.buttselect);
            this.Controls.Add(this.dvgcategorie);
            this.Controls.Add(this.txtrecherchecat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttajoute);
            this.Name = "User_liste_categorie";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.Load += new System.EventHandler(this.User_liste_categorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgcategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttajoute;
        private System.Windows.Forms.TextBox txtrecherchecat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dvgcategorie;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private GESTION_DE_STOCKDataSet5 gESTION_DE_STOCKDataSet5;
        private GESTION_DE_STOCKDataSet5TableAdapters.CategorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.Button buttselectTout;
        private System.Windows.Forms.Button buttselect;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCATEGORIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.Label label1;
    }
}
