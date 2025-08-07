namespace Parfüm2025
{
    partial class frmVerkaufsDatenListe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFilerwert = new System.Windows.Forms.TextBox();
            this.cbFilterbei = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAktualisereVerkaufsDaten = new System.Windows.Forms.Button();
            this.btnHinzufügeVerkaufsDaten = new System.Windows.Forms.Button();
            this.dgvVerkaufsDaten = new System.Windows.Forms.DataGridView();
            this.cmsVerkaufdaten = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.GeheZurRechnungsdetailstoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aktualisiereVerkaufdatentoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.entferneVerkaufsdatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erstelleEineRechnungsvorlageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seheBestandsaufnahmeVomKundenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dtpErstellungsdatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtJahr = new System.Windows.Forms.TextBox();
            this.txtVollname = new System.Windows.Forms.TextBox();
            this.txtGesamtSumme = new System.Windows.Forms.TextBox();
            this.txtAnzahlRechnung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKundeBestandAnzeigen = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerkaufsDaten)).BeginInit();
            this.cmsVerkaufdaten.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilerwert
            // 
            this.txtFilerwert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilerwert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFilerwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilerwert.Location = new System.Drawing.Point(297, 380);
            this.txtFilerwert.Multiline = true;
            this.txtFilerwert.Name = "txtFilerwert";
            this.txtFilerwert.Size = new System.Drawing.Size(349, 33);
            this.txtFilerwert.TabIndex = 13;
            this.txtFilerwert.TextChanged += new System.EventHandler(this.txtFilerwert_TextChanged);
            this.txtFilerwert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilerwert_KeyPress);
            // 
            // cbFilterbei
            // 
            this.cbFilterbei.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilterbei.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterbei.FormattingEnabled = true;
            this.cbFilterbei.Items.AddRange(new object[] {
            "KundenName",
            "ParfümNummer",
            "BelegID",
            "erstellungsDatum"});
            this.cbFilterbei.Location = new System.Drawing.Point(92, 383);
            this.cbFilterbei.Name = "cbFilterbei";
            this.cbFilterbei.Size = new System.Drawing.Size(199, 32);
            this.cbFilterbei.TabIndex = 12;
            this.cbFilterbei.SelectedIndexChanged += new System.EventHandler(this.cbFilterbei_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filer bei:";
            // 
            // btnAktualisereVerkaufsDaten
            // 
            this.btnAktualisereVerkaufsDaten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAktualisereVerkaufsDaten.BackColor = System.Drawing.Color.White;
            this.btnAktualisereVerkaufsDaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktualisereVerkaufsDaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktualisereVerkaufsDaten.ForeColor = System.Drawing.Color.White;
            this.btnAktualisereVerkaufsDaten.Image = global::Parfüm2025.Properties.Resources.update1;
            this.btnAktualisereVerkaufsDaten.Location = new System.Drawing.Point(877, 376);
            this.btnAktualisereVerkaufsDaten.Name = "btnAktualisereVerkaufsDaten";
            this.btnAktualisereVerkaufsDaten.Size = new System.Drawing.Size(40, 40);
            this.btnAktualisereVerkaufsDaten.TabIndex = 10;
            this.btnAktualisereVerkaufsDaten.UseVisualStyleBackColor = false;
            this.btnAktualisereVerkaufsDaten.Click += new System.EventHandler(this.btnAktualisereVerkaufsDaten_Click);
            // 
            // btnHinzufügeVerkaufsDaten
            // 
            this.btnHinzufügeVerkaufsDaten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHinzufügeVerkaufsDaten.BackColor = System.Drawing.Color.DimGray;
            this.btnHinzufügeVerkaufsDaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHinzufügeVerkaufsDaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHinzufügeVerkaufsDaten.ForeColor = System.Drawing.Color.White;
            this.btnHinzufügeVerkaufsDaten.Location = new System.Drawing.Point(923, 376);
            this.btnHinzufügeVerkaufsDaten.Name = "btnHinzufügeVerkaufsDaten";
            this.btnHinzufügeVerkaufsDaten.Size = new System.Drawing.Size(242, 40);
            this.btnHinzufügeVerkaufsDaten.TabIndex = 9;
            this.btnHinzufügeVerkaufsDaten.Text = "Hinzufüge Verkaufsdaten";
            this.btnHinzufügeVerkaufsDaten.UseVisualStyleBackColor = false;
            this.btnHinzufügeVerkaufsDaten.Click += new System.EventHandler(this.btnHinzufügeVerkaufsDaten_Click);
            // 
            // dgvVerkaufsDaten
            // 
            this.dgvVerkaufsDaten.AllowUserToAddRows = false;
            this.dgvVerkaufsDaten.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.dgvVerkaufsDaten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVerkaufsDaten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerkaufsDaten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerkaufsDaten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVerkaufsDaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerkaufsDaten.ContextMenuStrip = this.cmsVerkaufdaten;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerkaufsDaten.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVerkaufsDaten.EnableHeadersVisualStyles = false;
            this.dgvVerkaufsDaten.Location = new System.Drawing.Point(1, 422);
            this.dgvVerkaufsDaten.MultiSelect = false;
            this.dgvVerkaufsDaten.Name = "dgvVerkaufsDaten";
            this.dgvVerkaufsDaten.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerkaufsDaten.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVerkaufsDaten.RowTemplate.Height = 25;
            this.dgvVerkaufsDaten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerkaufsDaten.Size = new System.Drawing.Size(1158, 369);
            this.dgvVerkaufsDaten.TabIndex = 8;
            this.dgvVerkaufsDaten.DoubleClick += new System.EventHandler(this.dgvVerkaufsDaten_DoubleClick);
            // 
            // cmsVerkaufdaten
            // 
            this.cmsVerkaufdaten.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmsVerkaufdaten.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.GeheZurRechnungsdetailstoolStripMenuItem1,
            this.toolStripSeparator2,
            this.aktualisiereVerkaufdatentoolStripMenuItem2,
            this.entferneVerkaufsdatenToolStripMenuItem,
            this.erstelleEineRechnungsvorlageToolStripMenuItem,
            this.seheBestandsaufnahmeVomKundenToolStripMenuItem});
            this.cmsVerkaufdaten.Name = "cmsVerkaufdaten";
            this.cmsVerkaufdaten.Size = new System.Drawing.Size(357, 206);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(353, 6);
            // 
            // GeheZurRechnungsdetailstoolStripMenuItem1
            // 
            this.GeheZurRechnungsdetailstoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeheZurRechnungsdetailstoolStripMenuItem1.Image = global::Parfüm2025.Properties.Resources.details_32;
            this.GeheZurRechnungsdetailstoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GeheZurRechnungsdetailstoolStripMenuItem1.Name = "GeheZurRechnungsdetailstoolStripMenuItem1";
            this.GeheZurRechnungsdetailstoolStripMenuItem1.Size = new System.Drawing.Size(356, 38);
            this.GeheZurRechnungsdetailstoolStripMenuItem1.Text = "Gehe zur Rechnungsdetails";
            this.GeheZurRechnungsdetailstoolStripMenuItem1.Click += new System.EventHandler(this.GeheZurRechnungsdetailstoolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(353, 6);
            // 
            // aktualisiereVerkaufdatentoolStripMenuItem2
            // 
            this.aktualisiereVerkaufdatentoolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktualisiereVerkaufdatentoolStripMenuItem2.Image = global::Parfüm2025.Properties.Resources.refresh_57912761;
            this.aktualisiereVerkaufdatentoolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aktualisiereVerkaufdatentoolStripMenuItem2.Name = "aktualisiereVerkaufdatentoolStripMenuItem2";
            this.aktualisiereVerkaufdatentoolStripMenuItem2.Size = new System.Drawing.Size(356, 38);
            this.aktualisiereVerkaufdatentoolStripMenuItem2.Text = "Aktualisiere Rechnung";
            this.aktualisiereVerkaufdatentoolStripMenuItem2.Click += new System.EventHandler(this.aktualisiereVerkaufdatentoolStripMenuItem2_Click);
            // 
            // entferneVerkaufsdatenToolStripMenuItem
            // 
            this.entferneVerkaufsdatenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entferneVerkaufsdatenToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.delete_5953478__1_1;
            this.entferneVerkaufsdatenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entferneVerkaufsdatenToolStripMenuItem.Name = "entferneVerkaufsdatenToolStripMenuItem";
            this.entferneVerkaufsdatenToolStripMenuItem.Size = new System.Drawing.Size(356, 38);
            this.entferneVerkaufsdatenToolStripMenuItem.Text = "Entferne Rechnung";
            this.entferneVerkaufsdatenToolStripMenuItem.Click += new System.EventHandler(this.entferneVerkaufsdatenToolStripMenuItem_Click);
            // 
            // erstelleEineRechnungsvorlageToolStripMenuItem
            // 
            this.erstelleEineRechnungsvorlageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erstelleEineRechnungsvorlageToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.bill_1052856;
            this.erstelleEineRechnungsvorlageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.erstelleEineRechnungsvorlageToolStripMenuItem.Name = "erstelleEineRechnungsvorlageToolStripMenuItem";
            this.erstelleEineRechnungsvorlageToolStripMenuItem.Size = new System.Drawing.Size(356, 38);
            this.erstelleEineRechnungsvorlageToolStripMenuItem.Text = "Erstelle eine Rechnungsvorlage";
            this.erstelleEineRechnungsvorlageToolStripMenuItem.Click += new System.EventHandler(this.erstelleEineRechnungsvorlageToolStripMenuItem_Click);
            // 
            // seheBestandsaufnahmeVomKundenToolStripMenuItem
            // 
            this.seheBestandsaufnahmeVomKundenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seheBestandsaufnahmeVomKundenToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.ApplicationType;
            this.seheBestandsaufnahmeVomKundenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.seheBestandsaufnahmeVomKundenToolStripMenuItem.Name = "seheBestandsaufnahmeVomKundenToolStripMenuItem";
            this.seheBestandsaufnahmeVomKundenToolStripMenuItem.Size = new System.Drawing.Size(356, 38);
            this.seheBestandsaufnahmeVomKundenToolStripMenuItem.Text = "Sehe Bestandsaufnahme Vom Kunden";
            this.seheBestandsaufnahmeVomKundenToolStripMenuItem.Click += new System.EventHandler(this.seheBestandsaufnahmeVomKundenToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 801);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(88, 801);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 20);
            this.lblRecord.TabIndex = 15;
            this.lblRecord.Text = "###";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // dtpErstellungsdatum
            // 
            this.dtpErstellungsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpErstellungsdatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpErstellungsdatum.Location = new System.Drawing.Point(297, 384);
            this.dtpErstellungsdatum.Name = "dtpErstellungsdatum";
            this.dtpErstellungsdatum.Size = new System.Drawing.Size(360, 29);
            this.dtpErstellungsdatum.TabIndex = 16;
            this.dtpErstellungsdatum.Visible = false;
            this.dtpErstellungsdatum.ValueChanged += new System.EventHandler(this.dtpErstellungsdatum_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(500, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Verkaufsdaten";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 54);
            this.panel1.TabIndex = 19;
            // 
            // txtJahr
            // 
            this.txtJahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJahr.Location = new System.Drawing.Point(203, 42);
            this.txtJahr.Multiline = true;
            this.txtJahr.Name = "txtJahr";
            this.txtJahr.ReadOnly = true;
            this.txtJahr.Size = new System.Drawing.Size(193, 33);
            this.txtJahr.TabIndex = 20;
            // 
            // txtVollname
            // 
            this.txtVollname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVollname.Location = new System.Drawing.Point(203, 89);
            this.txtVollname.Multiline = true;
            this.txtVollname.Name = "txtVollname";
            this.txtVollname.ReadOnly = true;
            this.txtVollname.Size = new System.Drawing.Size(193, 33);
            this.txtVollname.TabIndex = 21;
            // 
            // txtGesamtSumme
            // 
            this.txtGesamtSumme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGesamtSumme.Location = new System.Drawing.Point(203, 133);
            this.txtGesamtSumme.Multiline = true;
            this.txtGesamtSumme.Name = "txtGesamtSumme";
            this.txtGesamtSumme.ReadOnly = true;
            this.txtGesamtSumme.Size = new System.Drawing.Size(193, 33);
            this.txtGesamtSumme.TabIndex = 22;
            // 
            // txtAnzahlRechnung
            // 
            this.txtAnzahlRechnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnzahlRechnung.Location = new System.Drawing.Point(203, 178);
            this.txtAnzahlRechnung.Multiline = true;
            this.txtAnzahlRechnung.Name = "txtAnzahlRechnung";
            this.txtAnzahlRechnung.ReadOnly = true;
            this.txtAnzahlRechnung.Size = new System.Drawing.Size(193, 33);
            this.txtAnzahlRechnung.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(139, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Jahr:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(104, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Vollname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(61, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Gesamtsumme:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "AnzahlRechnungen:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btnKundeBestandAnzeigen);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtVollname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtJahr);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGesamtSumme);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAnzahlRechnung);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 277);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bestandsaufnahme Information";
            // 
            // btnKundeBestandAnzeigen
            // 
            this.btnKundeBestandAnzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKundeBestandAnzeigen.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnKundeBestandAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKundeBestandAnzeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKundeBestandAnzeigen.ForeColor = System.Drawing.Color.White;
            this.btnKundeBestandAnzeigen.Location = new System.Drawing.Point(50, 233);
            this.btnKundeBestandAnzeigen.Name = "btnKundeBestandAnzeigen";
            this.btnKundeBestandAnzeigen.Size = new System.Drawing.Size(213, 40);
            this.btnKundeBestandAnzeigen.TabIndex = 29;
            this.btnKundeBestandAnzeigen.Text = "Kundebestand anzeigen";
            this.btnKundeBestandAnzeigen.UseVisualStyleBackColor = false;
            this.btnKundeBestandAnzeigen.Click += new System.EventHandler(this.btnKundeBestandAnzeigen_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(288, 233);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 40);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Remove";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Parfüm2025.Properties.Resources.Verkaufsdaten2;
            this.pictureBox1.Location = new System.Drawing.Point(418, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmVerkaufsDatenListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1190, 830);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpErstellungsdatum);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilerwert);
            this.Controls.Add(this.cbFilterbei);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAktualisereVerkaufsDaten);
            this.Controls.Add(this.btnHinzufügeVerkaufsDaten);
            this.Controls.Add(this.dgvVerkaufsDaten);
            this.Name = "frmVerkaufsDatenListe";
            this.Text = "Verkaufsdaten";
            this.Load += new System.EventHandler(this.frmVerkaufsDatenListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerkaufsDaten)).EndInit();
            this.cmsVerkaufdaten.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilerwert;
        private System.Windows.Forms.ComboBox cbFilterbei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAktualisereVerkaufsDaten;
        private System.Windows.Forms.Button btnHinzufügeVerkaufsDaten;
        private System.Windows.Forms.DataGridView dgvVerkaufsDaten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ContextMenuStrip cmsVerkaufdaten;
        private System.Windows.Forms.ToolStripMenuItem aktualisiereVerkaufdatentoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem entferneVerkaufsdatenToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DateTimePicker dtpErstellungsdatum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem GeheZurRechnungsdetailstoolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem erstelleEineRechnungsvorlageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem seheBestandsaufnahmeVomKundenToolStripMenuItem;
        private System.Windows.Forms.TextBox txtJahr;
        private System.Windows.Forms.TextBox txtVollname;
        private System.Windows.Forms.TextBox txtGesamtSumme;
        private System.Windows.Forms.TextBox txtAnzahlRechnung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnKundeBestandAnzeigen;
    }
}