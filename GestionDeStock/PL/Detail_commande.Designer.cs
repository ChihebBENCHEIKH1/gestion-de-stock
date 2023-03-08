namespace GestionDeStock.PL
{
    partial class Detail_commande
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.categorieTableAdapter1 = new GestionDeStock.GESTION_DE_STOCKDataSet10TableAdapters.CategorieTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnclient = new System.Windows.Forms.Button();
            this.textnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textprenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textpays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textville = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.texttlf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datecommande = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.texttotalTTC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.texttva = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.texttotalHTT = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dvgcommande = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btneregistrer = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textrechercheprod = new System.Windows.Forms.TextBox();
            this.dvgproduit = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnquitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcommande)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgproduit)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(4, 606);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1239, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(4, 598);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(4, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1239, 4);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(4, 602);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1239, 4);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(434, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajouter Commande";
            // 
            // categorieTableAdapter1
            // 
            this.categorieTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(590, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Location = new System.Drawing.Point(590, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 1);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.Location = new System.Drawing.Point(590, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 135);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.Location = new System.Drawing.Point(1219, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 135);
            this.panel4.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Snow;
            this.textBox1.Location = new System.Drawing.Point(597, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Client";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnclient
            // 
            this.btnclient.BackColor = System.Drawing.Color.Blue;
            this.btnclient.FlatAppearance.BorderSize = 0;
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclient.Location = new System.Drawing.Point(604, 112);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(28, 23);
            this.btnclient.TabIndex = 8;
            this.btnclient.Text = "...";
            this.btnclient.UseVisualStyleBackColor = false;
            this.btnclient.Click += new System.EventHandler(this.button1_Click);
            // 
            // textnom
            // 
            this.textnom.Enabled = false;
            this.textnom.Font = new System.Drawing.Font("Andalus", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnom.Location = new System.Drawing.Point(702, 112);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(94, 30);
            this.textnom.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(645, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(826, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Préom:";
            // 
            // textprenom
            // 
            this.textprenom.Enabled = false;
            this.textprenom.Font = new System.Drawing.Font("Andalus", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textprenom.Location = new System.Drawing.Point(894, 113);
            this.textprenom.Name = "textprenom";
            this.textprenom.Size = new System.Drawing.Size(100, 30);
            this.textprenom.TabIndex = 11;
            this.textprenom.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(1026, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pays:";
            // 
            // textpays
            // 
            this.textpays.Enabled = false;
            this.textpays.Font = new System.Drawing.Font("Andalus", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpays.Location = new System.Drawing.Point(1083, 111);
            this.textpays.Name = "textpays";
            this.textpays.Size = new System.Drawing.Size(100, 30);
            this.textpays.TabIndex = 13;
            this.textpays.TextChanged += new System.EventHandler(this.textpays_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(1026, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email:";
            // 
            // textmail
            // 
            this.textmail.Enabled = false;
            this.textmail.Font = new System.Drawing.Font("Andalus", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmail.Location = new System.Drawing.Point(1091, 173);
            this.textmail.Name = "textmail";
            this.textmail.Size = new System.Drawing.Size(100, 30);
            this.textmail.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(843, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ville:";
            // 
            // textville
            // 
            this.textville.Enabled = false;
            this.textville.Font = new System.Drawing.Font("Andalus", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textville.Location = new System.Drawing.Point(895, 175);
            this.textville.Name = "textville";
            this.textville.Size = new System.Drawing.Size(100, 30);
            this.textville.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(601, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Telephone:";
            // 
            // texttlf
            // 
            this.texttlf.Enabled = false;
            this.texttlf.Font = new System.Drawing.Font("Andalus", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttlf.Location = new System.Drawing.Point(702, 176);
            this.texttlf.Name = "texttlf";
            this.texttlf.Size = new System.Drawing.Size(100, 30);
            this.texttlf.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(667, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 28);
            this.label8.TabIndex = 21;
            this.label8.Text = "Date Commande";
            // 
            // datecommande
            // 
            this.datecommande.Location = new System.Drawing.Point(886, 239);
            this.datecommande.Name = "datecommande";
            this.datecommande.Size = new System.Drawing.Size(200, 20);
            this.datecommande.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(985, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 22);
            this.label9.TabIndex = 40;
            this.label9.Text = "Total TTC:";
            // 
            // texttotalTTC
            // 
            this.texttotalTTC.Enabled = false;
            this.texttotalTTC.Font = new System.Drawing.Font("Andalus", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttotalTTC.Location = new System.Drawing.Point(1084, 479);
            this.texttotalTTC.Name = "texttotalTTC";
            this.texttotalTTC.Size = new System.Drawing.Size(100, 30);
            this.texttotalTTC.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(840, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 22);
            this.label10.TabIndex = 38;
            this.label10.Text = "TVA:";
            // 
            // texttva
            // 
            this.texttva.Font = new System.Drawing.Font("Andalus", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttva.Location = new System.Drawing.Point(894, 479);
            this.texttva.Name = "texttva";
            this.texttva.Size = new System.Drawing.Size(53, 30);
            this.texttva.TabIndex = 37;
            this.texttva.TextChanged += new System.EventHandler(this.texttva_TextChanged);
            this.texttva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texttva_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Location = new System.Drawing.Point(630, 485);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 22);
            this.label11.TabIndex = 36;
            this.label11.Text = "Total HTT:";
            // 
            // texttotalHTT
            // 
            this.texttotalHTT.Enabled = false;
            this.texttotalHTT.Font = new System.Drawing.Font("Andalus", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttotalHTT.Location = new System.Drawing.Point(731, 479);
            this.texttotalHTT.Name = "texttotalHTT";
            this.texttotalHTT.ReadOnly = true;
            this.texttotalHTT.Size = new System.Drawing.Size(100, 30);
            this.texttotalHTT.TabIndex = 1;
            this.texttotalHTT.TextChanged += new System.EventHandler(this.texttotalHTT_TextChanged);
            this.texttotalHTT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texttotalHTT_KeyPress);
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ForeColor = System.Drawing.Color.Snow;
            this.textBox14.Location = new System.Drawing.Point(597, 265);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(118, 26);
            this.textBox14.TabIndex = 27;
            this.textBox14.Text = "Commande";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Snow;
            this.panel5.Location = new System.Drawing.Point(1219, 280);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 242);
            this.panel5.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Snow;
            this.panel6.Location = new System.Drawing.Point(590, 280);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 242);
            this.panel6.TabIndex = 24;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Snow;
            this.panel7.Location = new System.Drawing.Point(590, 521);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(630, 1);
            this.panel7.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Snow;
            this.panel8.Location = new System.Drawing.Point(590, 279);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(629, 1);
            this.panel8.TabIndex = 23;
            // 
            // dvgcommande
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Himalaya", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgcommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgcommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgcommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOM,
            this.Quantite,
            this.prix,
            this.Remise,
            this.Total});
            this.dvgcommande.ContextMenuStrip = this.contextMenuStrip2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgcommande.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgcommande.EnableHeadersVisualStyles = false;
            this.dvgcommande.Location = new System.Drawing.Point(615, 305);
            this.dvgcommande.Name = "dvgcommande";
            this.dvgcommande.RowTemplate.ReadOnly = true;
            this.dvgcommande.Size = new System.Drawing.Size(583, 164);
            this.dvgcommande.TabIndex = 41;
            this.dvgcommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgcommande_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 90;
            // 
            // NOM
            // 
            this.NOM.HeaderText = "Nom";
            this.NOM.Name = "NOM";
            this.NOM.Width = 90;
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            this.Quantite.Width = 90;
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix";
            this.prix.Name = "prix";
            this.prix.Width = 90;
            // 
            // Remise
            // 
            this.Remise.HeaderText = "Remise";
            this.Remise.Name = "Remise";
            this.Remise.Width = 90;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 90;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(130, 48);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // btneregistrer
            // 
            this.btneregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btneregistrer.FlatAppearance.BorderSize = 0;
            this.btneregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneregistrer.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneregistrer.ForeColor = System.Drawing.Color.Snow;
            this.btneregistrer.Location = new System.Drawing.Point(758, 547);
            this.btneregistrer.Name = "btneregistrer";
            this.btneregistrer.Size = new System.Drawing.Size(237, 48);
            this.btneregistrer.TabIndex = 42;
            this.btneregistrer.Text = "Enregistrer";
            this.btneregistrer.UseVisualStyleBackColor = false;
            this.btneregistrer.Click += new System.EventHandler(this.btneregistrer_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(12, 93);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(559, 1);
            this.flowLayoutPanel5.TabIndex = 43;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(12, 579);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(560, 1);
            this.flowLayoutPanel6.TabIndex = 44;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Snow;
            this.panel9.Location = new System.Drawing.Point(570, 93);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1, 486);
            this.panel9.TabIndex = 45;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Snow;
            this.panel10.Location = new System.Drawing.Point(12, 94);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 486);
            this.panel10.TabIndex = 46;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.Color.Snow;
            this.textBox11.Location = new System.Drawing.Point(52, 79);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(76, 26);
            this.textBox11.TabIndex = 47;
            this.textBox11.Text = "Produit";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(123, 163);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(320, 1);
            this.panel11.TabIndex = 48;
            // 
            // textrechercheprod
            // 
            this.textrechercheprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textrechercheprod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textrechercheprod.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textrechercheprod.ForeColor = System.Drawing.Color.Snow;
            this.textrechercheprod.Location = new System.Drawing.Point(209, 133);
            this.textrechercheprod.Name = "textrechercheprod";
            this.textrechercheprod.Size = new System.Drawing.Size(135, 28);
            this.textrechercheprod.TabIndex = 49;
            this.textrechercheprod.Text = "Recherche";
            this.textrechercheprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textrechercheprod.TextChanged += new System.EventHandler(this.textrechercheprod_TextChanged);
            this.textrechercheprod.Enter += new System.EventHandler(this.textrechercheprod_Enter);
            // 
            // dvgproduit
            // 
            this.dvgproduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgproduit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dvgproduit.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dvgproduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Himalaya", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgproduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgproduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgproduit.DefaultCellStyle = dataGridViewCellStyle4;
            this.dvgproduit.Location = new System.Drawing.Point(19, 194);
            this.dvgproduit.Name = "dvgproduit";
            this.dvgproduit.RowTemplate.ReadOnly = true;
            this.dvgproduit.Size = new System.Drawing.Size(545, 379);
            this.dvgproduit.TabIndex = 50;
            this.dvgproduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgproduit_CellContentClick);
            this.dvgproduit.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgproduit_CellContentDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(953, 482);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 24);
            this.label12.TabIndex = 51;
            this.label12.Text = "%";
            // 
            // btnquitter
            // 
            this.btnquitter.FlatAppearance.BorderSize = 0;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitter.Image = global::GestionDeStock.Properties.Resources.Button_Delete_icon;
            this.btnquitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnquitter.Location = new System.Drawing.Point(1189, 10);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(42, 44);
            this.btnquitter.TabIndex = 52;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // Detail_commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1243, 606);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dvgproduit);
            this.Controls.Add(this.textrechercheprod);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.btneregistrer);
            this.Controls.Add(this.dvgcommande);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.texttotalTTC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.texttva);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.texttotalHTT);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.datecommande);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textville);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.texttlf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textpays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textprenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.btnclient);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Detail_commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail_commande";
            this.Load += new System.EventHandler(this.Detail_commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgcommande)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgproduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private GESTION_DE_STOCKDataSet10TableAdapters.CategorieTableAdapter categorieTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textprenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textpays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textville;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texttlf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datecommande;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dvgcommande;
        private System.Windows.Forms.Button btneregistrer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox textrechercheprod;
        private System.Windows.Forms.DataGridView dvgproduit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        public System.Windows.Forms.TextBox texttotalTTC;
        public System.Windows.Forms.TextBox texttva;
        public System.Windows.Forms.TextBox texttotalHTT;
    }
}