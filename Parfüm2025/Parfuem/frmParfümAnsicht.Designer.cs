namespace Parfüm2025
{
    partial class frmpafümAnsicht
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpafümAnsicht));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAlleParfüms = new System.Windows.Forms.TabPage();
            this.btnErstellePdfFueBestellteParfüms = new System.Windows.Forms.Button();
            this.lblParfuemCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnErstelleEineParfümListePdf = new System.Windows.Forms.Button();
            this.lbVorschläge = new System.Windows.Forms.ListBox();
            this.txtFilterWert = new System.Windows.Forms.TextBox();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.btnDatenAktualisieren = new System.Windows.Forms.Button();
            this.btnNeuParfümHinzufügen = new System.Windows.Forms.Button();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.txtParfümSuchen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvParfüm = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mehrDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.parfümHinzufügentoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pafümAktualisierentoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.duftEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2HerrnDüfte = new System.Windows.Forms.TabPage();
            this.txtHerrnFilterwert = new System.Windows.Forms.TextBox();
            this.cbHerrnFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHerrnParfuemCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvHerrefDüfte = new System.Windows.Forms.DataGridView();
            this.tabPage3DamenDüfte = new System.Windows.Forms.TabPage();
            this.txtFrauenFilterWert = new System.Windows.Forms.TextBox();
            this.cbFrauenFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDamenParfuemCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvDamenParfüm = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpAlleParfüms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParfüm)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2HerrnDüfte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerrefDüfte)).BeginInit();
            this.tabPage3DamenDüfte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamenParfüm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpAlleParfüms);
            this.tabControl1.Controls.Add(this.tabPage2HerrnDüfte);
            this.tabControl1.Controls.Add(this.tabPage3DamenDüfte);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 789);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpAlleParfüms
            // 
            this.tpAlleParfüms.BackColor = System.Drawing.Color.White;
            this.tpAlleParfüms.Controls.Add(this.btnErstellePdfFueBestellteParfüms);
            this.tpAlleParfüms.Controls.Add(this.lblParfuemCount);
            this.tpAlleParfüms.Controls.Add(this.label2);
            this.tpAlleParfüms.Controls.Add(this.btnErstelleEineParfümListePdf);
            this.tpAlleParfüms.Controls.Add(this.lbVorschläge);
            this.tpAlleParfüms.Controls.Add(this.txtFilterWert);
            this.tpAlleParfüms.Controls.Add(this.cbFilterBei);
            this.tpAlleParfüms.Controls.Add(this.btnDatenAktualisieren);
            this.tpAlleParfüms.Controls.Add(this.btnNeuParfümHinzufügen);
            this.tpAlleParfüms.Controls.Add(this.btnSuchen);
            this.tpAlleParfüms.Controls.Add(this.txtParfümSuchen);
            this.tpAlleParfüms.Controls.Add(this.label12);
            this.tpAlleParfüms.Controls.Add(this.label3);
            this.tpAlleParfüms.Controls.Add(this.dgvParfüm);
            this.tpAlleParfüms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAlleParfüms.ForeColor = System.Drawing.Color.Black;
            this.tpAlleParfüms.Location = new System.Drawing.Point(4, 35);
            this.tpAlleParfüms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpAlleParfüms.Name = "tpAlleParfüms";
            this.tpAlleParfüms.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpAlleParfüms.Size = new System.Drawing.Size(1032, 750);
            this.tpAlleParfüms.TabIndex = 0;
            this.tpAlleParfüms.Text = "Unisexdüfte";
            // 
            // btnErstellePdfFueBestellteParfüms
            // 
            this.btnErstellePdfFueBestellteParfüms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnErstellePdfFueBestellteParfüms.BackColor = System.Drawing.Color.DarkGreen;
            this.btnErstellePdfFueBestellteParfüms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErstellePdfFueBestellteParfüms.ForeColor = System.Drawing.Color.White;
            this.btnErstellePdfFueBestellteParfüms.Location = new System.Drawing.Point(768, 4);
            this.btnErstellePdfFueBestellteParfüms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnErstellePdfFueBestellteParfüms.Name = "btnErstellePdfFueBestellteParfüms";
            this.btnErstellePdfFueBestellteParfüms.Size = new System.Drawing.Size(255, 42);
            this.btnErstellePdfFueBestellteParfüms.TabIndex = 29;
            this.btnErstellePdfFueBestellteParfüms.Text = "Erstelle Pdf Für Bestellungen";
            this.btnErstellePdfFueBestellteParfüms.UseVisualStyleBackColor = false;
            this.btnErstellePdfFueBestellteParfüms.Click += new System.EventHandler(this.btnErstelleFlohmarktPdf_Click);
            // 
            // lblParfuemCount
            // 
            this.lblParfuemCount.AutoSize = true;
            this.lblParfuemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParfuemCount.Location = new System.Drawing.Point(78, 710);
            this.lblParfuemCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParfuemCount.Name = "lblParfuemCount";
            this.lblParfuemCount.Size = new System.Drawing.Size(39, 20);
            this.lblParfuemCount.TabIndex = 28;
            this.lblParfuemCount.Text = "###";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 710);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Count:";
            // 
            // btnErstelleEineParfümListePdf
            // 
            this.btnErstelleEineParfümListePdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnErstelleEineParfümListePdf.BackColor = System.Drawing.Color.DarkGreen;
            this.btnErstelleEineParfümListePdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErstelleEineParfümListePdf.ForeColor = System.Drawing.Color.White;
            this.btnErstelleEineParfümListePdf.Location = new System.Drawing.Point(768, 50);
            this.btnErstelleEineParfümListePdf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnErstelleEineParfümListePdf.Name = "btnErstelleEineParfümListePdf";
            this.btnErstelleEineParfümListePdf.Size = new System.Drawing.Size(255, 42);
            this.btnErstelleEineParfümListePdf.TabIndex = 26;
            this.btnErstelleEineParfümListePdf.Text = "Erstelle Pdf für Parfüms";
            this.btnErstelleEineParfümListePdf.UseVisualStyleBackColor = false;
            this.btnErstelleEineParfümListePdf.Click += new System.EventHandler(this.btnErstelleEineParfümListePdf_Click);
            // 
            // lbVorschläge
            // 
            this.lbVorschläge.FormattingEnabled = true;
            this.lbVorschläge.ItemHeight = 20;
            this.lbVorschläge.Location = new System.Drawing.Point(370, 70);
            this.lbVorschläge.Name = "lbVorschläge";
            this.lbVorschläge.Size = new System.Drawing.Size(263, 164);
            this.lbVorschläge.TabIndex = 24;
            this.lbVorschläge.Visible = false;
            this.lbVorschläge.Click += new System.EventHandler(this.lbVorschläge_Click_1);
            // 
            // txtFilterWert
            // 
            this.txtFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterWert.Location = new System.Drawing.Point(332, 103);
            this.txtFilterWert.Multiline = true;
            this.txtFilterWert.Name = "txtFilterWert";
            this.txtFilterWert.Size = new System.Drawing.Size(383, 33);
            this.txtFilterWert.TabIndex = 23;
            this.txtFilterWert.TextChanged += new System.EventHandler(this.txtFilterWert_TextChanged);
            this.txtFilterWert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterWert_KeyPress);
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "ParfümNummer",
            "Marke",
            "Name",
            "Kategorie",
            "Duftrichtung",
            "Basisnote"});
            this.cbFilterBei.Location = new System.Drawing.Point(108, 103);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(218, 32);
            this.cbFilterBei.TabIndex = 22;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // btnDatenAktualisieren
            // 
            this.btnDatenAktualisieren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatenAktualisieren.BackColor = System.Drawing.Color.White;
            this.btnDatenAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatenAktualisieren.Image = ((System.Drawing.Image)(resources.GetObject("btnDatenAktualisieren.Image")));
            this.btnDatenAktualisieren.Location = new System.Drawing.Point(720, 95);
            this.btnDatenAktualisieren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDatenAktualisieren.Name = "btnDatenAktualisieren";
            this.btnDatenAktualisieren.Size = new System.Drawing.Size(44, 40);
            this.btnDatenAktualisieren.TabIndex = 21;
            this.btnDatenAktualisieren.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatenAktualisieren.UseVisualStyleBackColor = false;
            this.btnDatenAktualisieren.Click += new System.EventHandler(this.btnDatenAktualisieren_Click);
            // 
            // btnNeuParfümHinzufügen
            // 
            this.btnNeuParfümHinzufügen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNeuParfümHinzufügen.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNeuParfümHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeuParfümHinzufügen.ForeColor = System.Drawing.Color.White;
            this.btnNeuParfümHinzufügen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNeuParfümHinzufügen.Location = new System.Drawing.Point(768, 95);
            this.btnNeuParfümHinzufügen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNeuParfümHinzufügen.Name = "btnNeuParfümHinzufügen";
            this.btnNeuParfümHinzufügen.Size = new System.Drawing.Size(255, 41);
            this.btnNeuParfümHinzufügen.TabIndex = 20;
            this.btnNeuParfümHinzufügen.Text = "Addnew Parfümdaten";
            this.btnNeuParfümHinzufügen.UseVisualStyleBackColor = false;
            this.btnNeuParfümHinzufügen.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuchen.ForeColor = System.Drawing.Color.White;
            this.btnSuchen.Location = new System.Drawing.Point(637, 31);
            this.btnSuchen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(127, 42);
            this.btnSuchen.TabIndex = 18;
            this.btnSuchen.Text = "Suche";
            this.btnSuchen.UseVisualStyleBackColor = false;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // txtParfümSuchen
            // 
            this.txtParfümSuchen.BackColor = System.Drawing.Color.White;
            this.txtParfümSuchen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParfümSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParfümSuchen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtParfümSuchen.Location = new System.Drawing.Point(370, 36);
            this.txtParfümSuchen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtParfümSuchen.Multiline = true;
            this.txtParfümSuchen.Name = "txtParfümSuchen";
            this.txtParfümSuchen.Size = new System.Drawing.Size(263, 34);
            this.txtParfümSuchen.TabIndex = 16;
            this.txtParfümSuchen.TextChanged += new System.EventHandler(this.txtParfümSuchen_TextChanged);
            this.txtParfümSuchen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParfümSuchen_KeyDown);
            this.txtParfümSuchen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParfümSuchen_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(14, 40);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(352, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Nach einem bestimmten Parüfm suchen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filter bei:";
            // 
            // dgvParfüm
            // 
            this.dgvParfüm.AllowUserToAddRows = false;
            this.dgvParfüm.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            this.dgvParfüm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvParfüm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParfüm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParfüm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvParfüm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParfüm.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParfüm.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvParfüm.EnableHeadersVisualStyles = false;
            this.dgvParfüm.Location = new System.Drawing.Point(17, 139);
            this.dgvParfüm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvParfüm.MultiSelect = false;
            this.dgvParfüm.Name = "dgvParfüm";
            this.dgvParfüm.ReadOnly = true;
            this.dgvParfüm.RowHeadersWidth = 60;
            this.dgvParfüm.RowTemplate.Height = 40;
            this.dgvParfüm.ShowCellErrors = false;
            this.dgvParfüm.Size = new System.Drawing.Size(1010, 543);
            this.dgvParfüm.TabIndex = 3;
            this.dgvParfüm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParfüm_CellContentClick);
            this.dgvParfüm.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvParfüm_ColumnHeaderMouseClick);
            this.dgvParfüm.DoubleClick += new System.EventHandler(this.dgvParfüm_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mehrDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.parfümHinzufügentoolStripMenuItem1,
            this.pafümAktualisierentoolStripMenuItem2,
            this.duftEntfernenToolStripMenuItem,
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(420, 200);
            // 
            // mehrDetailsToolStripMenuItem
            // 
            this.mehrDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mehrDetailsToolStripMenuItem.Image")));
            this.mehrDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mehrDetailsToolStripMenuItem.Name = "mehrDetailsToolStripMenuItem";
            this.mehrDetailsToolStripMenuItem.Size = new System.Drawing.Size(419, 38);
            this.mehrDetailsToolStripMenuItem.Text = "Sehe Duft details";
            this.mehrDetailsToolStripMenuItem.Click += new System.EventHandler(this.mehrDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(416, 6);
            // 
            // parfümHinzufügentoolStripMenuItem1
            // 
            this.parfümHinzufügentoolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("parfümHinzufügentoolStripMenuItem1.Image")));
            this.parfümHinzufügentoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.parfümHinzufügentoolStripMenuItem1.Name = "parfümHinzufügentoolStripMenuItem1";
            this.parfümHinzufügentoolStripMenuItem1.Size = new System.Drawing.Size(419, 38);
            this.parfümHinzufügentoolStripMenuItem1.Text = "Hinzufüge neuen Duft";
            this.parfümHinzufügentoolStripMenuItem1.Click += new System.EventHandler(this.parfümHinzufügentoolStripMenuItem1_Click);
            // 
            // pafümAktualisierentoolStripMenuItem2
            // 
            this.pafümAktualisierentoolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("pafümAktualisierentoolStripMenuItem2.Image")));
            this.pafümAktualisierentoolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pafümAktualisierentoolStripMenuItem2.Name = "pafümAktualisierentoolStripMenuItem2";
            this.pafümAktualisierentoolStripMenuItem2.Size = new System.Drawing.Size(419, 38);
            this.pafümAktualisierentoolStripMenuItem2.Text = "Aktualisiere bestehenden Duft";
            this.pafümAktualisierentoolStripMenuItem2.Click += new System.EventHandler(this.pafümAktualisierentoolStripMenuItem2_Click);
            // 
            // duftEntfernenToolStripMenuItem
            // 
            this.duftEntfernenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("duftEntfernenToolStripMenuItem.Image")));
            this.duftEntfernenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.duftEntfernenToolStripMenuItem.Name = "duftEntfernenToolStripMenuItem";
            this.duftEntfernenToolStripMenuItem.Size = new System.Drawing.Size(419, 38);
            this.duftEntfernenToolStripMenuItem.Text = "Entferne Duft";
            this.duftEntfernenToolStripMenuItem.Click += new System.EventHandler(this.duftEntfernenToolStripMenuItem_Click);
            // 
            // erstelleEineParfümlisteAlsPDFToolStripMenuItem
            // 
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("erstelleEineParfümlisteAlsPDFToolStripMenuItem.Image")));
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem.Name = "erstelleEineParfümlisteAlsPDFToolStripMenuItem";
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem.Size = new System.Drawing.Size(419, 38);
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem.Text = "Erstelle eine Pdf-Datei aus Parfümliste";
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem.Click += new System.EventHandler(this.erstelleEineParfümlisteAlsPDFToolStripMenuItem_Click);
            // 
            // tabPage2HerrnDüfte
            // 
            this.tabPage2HerrnDüfte.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2HerrnDüfte.Controls.Add(this.txtHerrnFilterwert);
            this.tabPage2HerrnDüfte.Controls.Add(this.cbHerrnFilter);
            this.tabPage2HerrnDüfte.Controls.Add(this.label4);
            this.tabPage2HerrnDüfte.Controls.Add(this.lblHerrnParfuemCount);
            this.tabPage2HerrnDüfte.Controls.Add(this.label11);
            this.tabPage2HerrnDüfte.Controls.Add(this.dgvHerrefDüfte);
            this.tabPage2HerrnDüfte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2HerrnDüfte.Location = new System.Drawing.Point(4, 35);
            this.tabPage2HerrnDüfte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2HerrnDüfte.Name = "tabPage2HerrnDüfte";
            this.tabPage2HerrnDüfte.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2HerrnDüfte.Size = new System.Drawing.Size(1032, 750);
            this.tabPage2HerrnDüfte.TabIndex = 1;
            this.tabPage2HerrnDüfte.Text = "Herrndüfte";
            // 
            // txtHerrnFilterwert
            // 
            this.txtHerrnFilterwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerrnFilterwert.Location = new System.Drawing.Point(322, 28);
            this.txtHerrnFilterwert.Multiline = true;
            this.txtHerrnFilterwert.Name = "txtHerrnFilterwert";
            this.txtHerrnFilterwert.Size = new System.Drawing.Size(413, 33);
            this.txtHerrnFilterwert.TabIndex = 33;
            this.txtHerrnFilterwert.TextChanged += new System.EventHandler(this.txtHerrnFilterwert_TextChanged);
            this.txtHerrnFilterwert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHerrnFilterwert_KeyPress);
            // 
            // cbHerrnFilter
            // 
            this.cbHerrnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHerrnFilter.FormattingEnabled = true;
            this.cbHerrnFilter.Items.AddRange(new object[] {
            "ParfümNummer",
            "Marke",
            "Name",
            "Kategorie",
            "Duftrichtung",
            "Basisnote",
            "IstVorhanden"});
            this.cbHerrnFilter.Location = new System.Drawing.Point(98, 30);
            this.cbHerrnFilter.Name = "cbHerrnFilter";
            this.cbHerrnFilter.Size = new System.Drawing.Size(218, 32);
            this.cbHerrnFilter.TabIndex = 32;
            this.cbHerrnFilter.SelectedIndexChanged += new System.EventHandler(this.cbHerrnFilter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Filter bei:";
            // 
            // lblHerrnParfuemCount
            // 
            this.lblHerrnParfuemCount.AutoSize = true;
            this.lblHerrnParfuemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerrnParfuemCount.Location = new System.Drawing.Point(68, 720);
            this.lblHerrnParfuemCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHerrnParfuemCount.Name = "lblHerrnParfuemCount";
            this.lblHerrnParfuemCount.Size = new System.Drawing.Size(39, 20);
            this.lblHerrnParfuemCount.TabIndex = 30;
            this.lblHerrnParfuemCount.Text = "###";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 720);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Count:";
            // 
            // dgvHerrefDüfte
            // 
            this.dgvHerrefDüfte.AllowUserToAddRows = false;
            this.dgvHerrefDüfte.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHerrefDüfte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHerrefDüfte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHerrefDüfte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHerrefDüfte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHerrefDüfte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHerrefDüfte.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvHerrefDüfte.Location = new System.Drawing.Point(6, 68);
            this.dgvHerrefDüfte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHerrefDüfte.MultiSelect = false;
            this.dgvHerrefDüfte.Name = "dgvHerrefDüfte";
            this.dgvHerrefDüfte.ReadOnly = true;
            this.dgvHerrefDüfte.RowHeadersWidth = 60;
            this.dgvHerrefDüfte.RowTemplate.Height = 40;
            this.dgvHerrefDüfte.Size = new System.Drawing.Size(1020, 609);
            this.dgvHerrefDüfte.TabIndex = 10;
            this.dgvHerrefDüfte.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHerrefDüfte_ColumnHeaderMouseClick);
            this.dgvHerrefDüfte.DoubleClick += new System.EventHandler(this.dgvHerrefDüfte_DoubleClick);
            // 
            // tabPage3DamenDüfte
            // 
            this.tabPage3DamenDüfte.Controls.Add(this.txtFrauenFilterWert);
            this.tabPage3DamenDüfte.Controls.Add(this.cbFrauenFilter);
            this.tabPage3DamenDüfte.Controls.Add(this.label5);
            this.tabPage3DamenDüfte.Controls.Add(this.lblDamenParfuemCount);
            this.tabPage3DamenDüfte.Controls.Add(this.label13);
            this.tabPage3DamenDüfte.Controls.Add(this.dgvDamenParfüm);
            this.tabPage3DamenDüfte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3DamenDüfte.Location = new System.Drawing.Point(4, 35);
            this.tabPage3DamenDüfte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3DamenDüfte.Name = "tabPage3DamenDüfte";
            this.tabPage3DamenDüfte.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3DamenDüfte.Size = new System.Drawing.Size(1032, 750);
            this.tabPage3DamenDüfte.TabIndex = 2;
            this.tabPage3DamenDüfte.Text = "Damendüfte";
            this.tabPage3DamenDüfte.UseVisualStyleBackColor = true;
            // 
            // txtFrauenFilterWert
            // 
            this.txtFrauenFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrauenFilterWert.Location = new System.Drawing.Point(322, 41);
            this.txtFrauenFilterWert.Multiline = true;
            this.txtFrauenFilterWert.Name = "txtFrauenFilterWert";
            this.txtFrauenFilterWert.Size = new System.Drawing.Size(413, 33);
            this.txtFrauenFilterWert.TabIndex = 36;
            this.txtFrauenFilterWert.TextChanged += new System.EventHandler(this.txtFrauenFilterWert_TextChanged);
            // 
            // cbFrauenFilter
            // 
            this.cbFrauenFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrauenFilter.FormattingEnabled = true;
            this.cbFrauenFilter.Items.AddRange(new object[] {
            "ParfümNummer",
            "Marke",
            "Name",
            "Kategorie",
            "Duftrichtung",
            "Basisnote",
            "IstVorhanden"});
            this.cbFrauenFilter.Location = new System.Drawing.Point(98, 42);
            this.cbFrauenFilter.Name = "cbFrauenFilter";
            this.cbFrauenFilter.Size = new System.Drawing.Size(218, 32);
            this.cbFrauenFilter.TabIndex = 35;
            this.cbFrauenFilter.SelectedIndexChanged += new System.EventHandler(this.cbFrauenFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Filter bei:";
            // 
            // lblDamenParfuemCount
            // 
            this.lblDamenParfuemCount.AutoSize = true;
            this.lblDamenParfuemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamenParfuemCount.Location = new System.Drawing.Point(68, 720);
            this.lblDamenParfuemCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDamenParfuemCount.Name = "lblDamenParfuemCount";
            this.lblDamenParfuemCount.Size = new System.Drawing.Size(39, 20);
            this.lblDamenParfuemCount.TabIndex = 30;
            this.lblDamenParfuemCount.Text = "###";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 720);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Count:";
            // 
            // dgvDamenParfüm
            // 
            this.dgvDamenParfüm.AllowUserToAddRows = false;
            this.dgvDamenParfüm.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDamenParfüm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDamenParfüm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDamenParfüm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDamenParfüm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamenParfüm.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDamenParfüm.Location = new System.Drawing.Point(4, 80);
            this.dgvDamenParfüm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDamenParfüm.Name = "dgvDamenParfüm";
            this.dgvDamenParfüm.ReadOnly = true;
            this.dgvDamenParfüm.RowHeadersWidth = 51;
            this.dgvDamenParfüm.RowTemplate.Height = 40;
            this.dgvDamenParfüm.Size = new System.Drawing.Size(1023, 610);
            this.dgvDamenParfüm.TabIndex = 17;
            this.dgvDamenParfüm.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDamenParfüm_ColumnHeaderMouseClick);
            this.dgvDamenParfüm.DoubleClick += new System.EventHandler(this.dgvDamenParfüm_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 68);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parfüm Verwaltung";
            // 
            // frmpafümAnsicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 862);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmpafümAnsicht";
            this.Text = "Pafrümansicht";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAlleParfüms.ResumeLayout(false);
            this.tpAlleParfüms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParfüm)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2HerrnDüfte.ResumeLayout(false);
            this.tabPage2HerrnDüfte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerrefDüfte)).EndInit();
            this.tabPage3DamenDüfte.ResumeLayout(false);
            this.tabPage3DamenDüfte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamenParfüm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAlleParfüms;
        private System.Windows.Forms.TabPage tabPage2HerrnDüfte;
        private System.Windows.Forms.TabPage tabPage3DamenDüfte;
        private System.Windows.Forms.DataGridView dgvParfüm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mehrDetailsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDamenParfüm;
        private System.Windows.Forms.TextBox txtParfümSuchen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Button btnNeuParfümHinzufügen;
        private System.Windows.Forms.ToolStripMenuItem duftEntfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parfümHinzufügentoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pafümAktualisierentoolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgvHerrefDüfte;
        private System.Windows.Forms.Button btnDatenAktualisieren;
        private System.Windows.Forms.TextBox txtFilterWert;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.ListBox lbVorschläge;
        private System.Windows.Forms.ToolStripMenuItem erstelleEineParfümlisteAlsPDFToolStripMenuItem;
        private System.Windows.Forms.Button btnErstelleEineParfümListePdf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblParfuemCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHerrnParfuemCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDamenParfuemCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHerrnFilterwert;
        private System.Windows.Forms.ComboBox cbHerrnFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnErstellePdfFueBestellteParfüms;
        private System.Windows.Forms.TextBox txtFrauenFilterWert;
        private System.Windows.Forms.ComboBox cbFrauenFilter;
        private System.Windows.Forms.Label label5;
    }
}

