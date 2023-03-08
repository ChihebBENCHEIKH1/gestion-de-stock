namespace GestionDeStock.PL
{
    partial class UserControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvgclient = new System.Windows.Forms.DataGridView();
            this.iDClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephonneClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_DE_STOCKDataSet3 = new GestionDeStock.GESTION_DE_STOCKDataSet3();
            this.clientTableAdapter = new GestionDeStock.GESTION_DE_STOCKDataSet3TableAdapters.ClientTableAdapter();
            this.comborecherchecl = new System.Windows.Forms.ComboBox();
            this.txtrecherchecl = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(632, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 2);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dvgclient
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgclient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dvgclient.AutoGenerateColumns = false;
            this.dvgclient.BackgroundColor = System.Drawing.Color.Snow;
            this.dvgclient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgclient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dvgclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClientDataGridViewTextBoxColumn,
            this.nomClientDataGridViewTextBoxColumn,
            this.prenomClientDataGridViewTextBoxColumn,
            this.adresseClientDataGridViewTextBoxColumn,
            this.telephonneClientDataGridViewTextBoxColumn,
            this.paysClientDataGridViewTextBoxColumn,
            this.villeClientDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dvgclient.DataSource = this.clientBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgclient.DefaultCellStyle = dataGridViewCellStyle15;
            this.dvgclient.EnableHeadersVisualStyles = false;
            this.dvgclient.Location = new System.Drawing.Point(39, 236);
            this.dvgclient.Name = "dvgclient";
            this.dvgclient.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgclient.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dvgclient.Size = new System.Drawing.Size(1042, 283);
            this.dvgclient.TabIndex = 17;
            this.dvgclient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgclient_CellClick);
            this.dvgclient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            this.iDClientDataGridViewTextBoxColumn.DataPropertyName = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            this.iDClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDClientDataGridViewTextBoxColumn.Width = 120;
            // 
            // nomClientDataGridViewTextBoxColumn
            // 
            this.nomClientDataGridViewTextBoxColumn.DataPropertyName = "Nom_Client";
            this.nomClientDataGridViewTextBoxColumn.HeaderText = "Nom ";
            this.nomClientDataGridViewTextBoxColumn.Name = "nomClientDataGridViewTextBoxColumn";
            this.nomClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomClientDataGridViewTextBoxColumn.Width = 120;
            // 
            // prenomClientDataGridViewTextBoxColumn
            // 
            this.prenomClientDataGridViewTextBoxColumn.DataPropertyName = "Prenom_Client";
            this.prenomClientDataGridViewTextBoxColumn.HeaderText = "Prénom ";
            this.prenomClientDataGridViewTextBoxColumn.Name = "prenomClientDataGridViewTextBoxColumn";
            this.prenomClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomClientDataGridViewTextBoxColumn.Width = 120;
            // 
            // adresseClientDataGridViewTextBoxColumn
            // 
            this.adresseClientDataGridViewTextBoxColumn.DataPropertyName = "Adresse_Client";
            this.adresseClientDataGridViewTextBoxColumn.HeaderText = "Adresse ";
            this.adresseClientDataGridViewTextBoxColumn.Name = "adresseClientDataGridViewTextBoxColumn";
            this.adresseClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseClientDataGridViewTextBoxColumn.Width = 120;
            // 
            // telephonneClientDataGridViewTextBoxColumn
            // 
            this.telephonneClientDataGridViewTextBoxColumn.DataPropertyName = "Telephonne_Client";
            this.telephonneClientDataGridViewTextBoxColumn.HeaderText = "Telephonne (+216)";
            this.telephonneClientDataGridViewTextBoxColumn.Name = "telephonneClientDataGridViewTextBoxColumn";
            this.telephonneClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephonneClientDataGridViewTextBoxColumn.Width = 140;
            // 
            // paysClientDataGridViewTextBoxColumn
            // 
            this.paysClientDataGridViewTextBoxColumn.DataPropertyName = "Pays_Client";
            this.paysClientDataGridViewTextBoxColumn.HeaderText = "Pays ";
            this.paysClientDataGridViewTextBoxColumn.Name = "paysClientDataGridViewTextBoxColumn";
            this.paysClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.paysClientDataGridViewTextBoxColumn.Width = 120;
            // 
            // villeClientDataGridViewTextBoxColumn
            // 
            this.villeClientDataGridViewTextBoxColumn.DataPropertyName = "Ville_Client";
            this.villeClientDataGridViewTextBoxColumn.HeaderText = "Ville ";
            this.villeClientDataGridViewTextBoxColumn.Name = "villeClientDataGridViewTextBoxColumn";
            this.villeClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.villeClientDataGridViewTextBoxColumn.Width = 120;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 140;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.gESTION_DE_STOCKDataSet3;
            // 
            // gESTION_DE_STOCKDataSet3
            // 
            this.gESTION_DE_STOCKDataSet3.DataSetName = "GESTION_DE_STOCKDataSet3";
            this.gESTION_DE_STOCKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // comborecherchecl
            // 
            this.comborecherchecl.FormattingEnabled = true;
            this.comborecherchecl.Items.AddRange(new object[] {
            "Tout",
            "Nom",
            "Prénom",
            "Ville",
            "Pays",
            "Adresse",
            "Mail",
            "Telephone"});
            this.comborecherchecl.Location = new System.Drawing.Point(233, 140);
            this.comborecherchecl.Name = "comborecherchecl";
            this.comborecherchecl.Size = new System.Drawing.Size(212, 21);
            this.comborecherchecl.TabIndex = 19;
            this.comborecherchecl.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtrecherchecl
            // 
            this.txtrecherchecl.BackColor = System.Drawing.SystemColors.Control;
            this.txtrecherchecl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherchecl.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherchecl.Location = new System.Drawing.Point(701, 127);
            this.txtrecherchecl.Name = "txtrecherchecl";
            this.txtrecherchecl.Size = new System.Drawing.Size(211, 31);
            this.txtrecherchecl.TabIndex = 20;
            this.txtrecherchecl.Text = "Recherche";
            this.txtrecherchecl.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            this.txtrecherchecl.Enter += new System.EventHandler(this.txtrecherche_Enter);
            this.txtrecherchecl.Leave += new System.EventHandler(this.txtrecherche_Leave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Snow;
            this.button5.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(452, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(260, 50);
            this.button5.TabIndex = 13;
            this.button5.Text = "       Modifier";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.Leave += new System.EventHandler(this.button5_Leave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Image = global::GestionDeStock.Properties.Resources.Button_Delete_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(843, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(255, 50);
            this.button4.TabIndex = 12;
            this.button4.Text = "    Supprimer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.Leave += new System.EventHandler(this.button4_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(77, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "        Ajouter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Leave += new System.EventHandler(this.button2_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(781, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Powered by Chiheb Ben Cheikh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(822, 911);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrecherchecl);
            this.Controls.Add(this.comborecherchecl);
            this.Controls.Add(this.dvgclient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private GESTION_DE_STOCKDataSet3 gESTION_DE_STOCKDataSet3;
        private GESTION_DE_STOCKDataSet3TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ComboBox comborecherchecl;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephonneClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtrecherchecl;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.DataGridView dvgclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
