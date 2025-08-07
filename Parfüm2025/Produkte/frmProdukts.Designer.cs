namespace Parfüm2025
{
    partial class frmProdukts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilerwert = new System.Windows.Forms.TextBox();
            this.cbFilterbei = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProdukts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnKaufen = new System.Windows.Forms.Button();
            this.btnAnzeigen = new System.Windows.Forms.Button();
            this.btLoeschen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDezGeschäft = new System.Windows.Forms.RadioButton();
            this.rbHauptGeschäft = new System.Windows.Forms.RadioButton();
            this.txtGekaufteMenge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProduktName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGelieferteMenge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotoMenge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerkaufen = new System.Windows.Forms.Button();
            this.btnAktualisieren = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 54);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(424, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produkts";
            // 
            // txtFilerwert
            // 
            this.txtFilerwert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilerwert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFilerwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilerwert.Location = new System.Drawing.Point(285, 440);
            this.txtFilerwert.Multiline = true;
            this.txtFilerwert.Name = "txtFilerwert";
            this.txtFilerwert.Size = new System.Drawing.Size(317, 32);
            this.txtFilerwert.TabIndex = 10;
            this.txtFilerwert.TextChanged += new System.EventHandler(this.txtFilerwert_TextChanged);
            // 
            // cbFilterbei
            // 
            this.cbFilterbei.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilterbei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterbei.FormattingEnabled = true;
            this.cbFilterbei.Items.AddRange(new object[] {
            "ProduktID",
            "ProduktName"});
            this.cbFilterbei.Location = new System.Drawing.Point(102, 442);
            this.cbFilterbei.Name = "cbFilterbei";
            this.cbFilterbei.Size = new System.Drawing.Size(177, 28);
            this.cbFilterbei.TabIndex = 9;
            this.cbFilterbei.SelectedIndexChanged += new System.EventHandler(this.cbFilterbei_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filter bei:";
            // 
            // dgvProdukts
            // 
            this.dgvProdukts.AllowUserToAddRows = false;
            this.dgvProdukts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvProdukts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdukts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdukts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdukts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdukts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdukts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdukts.EnableHeadersVisualStyles = false;
            this.dgvProdukts.Location = new System.Drawing.Point(12, 476);
            this.dgvProdukts.Name = "dgvProdukts";
            this.dgvProdukts.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdukts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdukts.RowTemplate.Height = 30;
            this.dgvProdukts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdukts.Size = new System.Drawing.Size(961, 317);
            this.dgvProdukts.TabIndex = 7;
            this.dgvProdukts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukts_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(16, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 17);
            this.panel2.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbbrechen.BackColor = System.Drawing.Color.IndianRed;
            this.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.ForeColor = System.Drawing.Color.White;
            this.btnAbbrechen.Location = new System.Drawing.Point(402, 286);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(106, 40);
            this.btnAbbrechen.TabIndex = 38;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = false;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btnKaufen
            // 
            this.btnKaufen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaufen.BackColor = System.Drawing.Color.IndianRed;
            this.btnKaufen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaufen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaufen.ForeColor = System.Drawing.Color.White;
            this.btnKaufen.Location = new System.Drawing.Point(730, 438);
            this.btnKaufen.Name = "btnKaufen";
            this.btnKaufen.Size = new System.Drawing.Size(115, 34);
            this.btnKaufen.TabIndex = 39;
            this.btnKaufen.Text = "Kaufen";
            this.btnKaufen.UseVisualStyleBackColor = false;
            this.btnKaufen.Click += new System.EventHandler(this.btnKaufen_Click);
            // 
            // btnAnzeigen
            // 
            this.btnAnzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnzeigen.BackColor = System.Drawing.Color.IndianRed;
            this.btnAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnzeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnzeigen.ForeColor = System.Drawing.Color.White;
            this.btnAnzeigen.Location = new System.Drawing.Point(146, 287);
            this.btnAnzeigen.Name = "btnAnzeigen";
            this.btnAnzeigen.Size = new System.Drawing.Size(106, 40);
            this.btnAnzeigen.TabIndex = 42;
            this.btnAnzeigen.Text = "Anzeigen";
            this.btnAnzeigen.UseVisualStyleBackColor = false;
            this.btnAnzeigen.Click += new System.EventHandler(this.btnAnzeigen_Click);
            // 
            // btLoeschen
            // 
            this.btLoeschen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoeschen.BackColor = System.Drawing.Color.IndianRed;
            this.btLoeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoeschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoeschen.ForeColor = System.Drawing.Color.White;
            this.btLoeschen.Location = new System.Drawing.Point(273, 286);
            this.btLoeschen.Name = "btLoeschen";
            this.btLoeschen.Size = new System.Drawing.Size(106, 40);
            this.btLoeschen.TabIndex = 43;
            this.btLoeschen.Text = "Löschen";
            this.btLoeschen.UseVisualStyleBackColor = false;
            this.btLoeschen.Click += new System.EventHandler(this.btLoeschen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDezGeschäft);
            this.groupBox1.Controls.Add(this.rbHauptGeschäft);
            this.groupBox1.Controls.Add(this.btLoeschen);
            this.groupBox1.Controls.Add(this.btnAnzeigen);
            this.groupBox1.Controls.Add(this.btnAbbrechen);
            this.groupBox1.Controls.Add(this.txtGekaufteMenge);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtProduktName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGelieferteMenge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotoMenge);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 333);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produkt Information";
            // 
            // rbDezGeschäft
            // 
            this.rbDezGeschäft.AutoSize = true;
            this.rbDezGeschäft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDezGeschäft.Location = new System.Drawing.Point(342, 227);
            this.rbDezGeschäft.Name = "rbDezGeschäft";
            this.rbDezGeschäft.Size = new System.Drawing.Size(117, 22);
            this.rbDezGeschäft.TabIndex = 45;
            this.rbDezGeschäft.Text = "Dez Geschäft";
            this.rbDezGeschäft.UseVisualStyleBackColor = true;
            // 
            // rbHauptGeschäft
            // 
            this.rbHauptGeschäft.AutoSize = true;
            this.rbHauptGeschäft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHauptGeschäft.Location = new System.Drawing.Point(201, 227);
            this.rbHauptGeschäft.Name = "rbHauptGeschäft";
            this.rbHauptGeschäft.Size = new System.Drawing.Size(129, 22);
            this.rbHauptGeschäft.TabIndex = 44;
            this.rbHauptGeschäft.Text = "Haupt Geschäft";
            this.rbHauptGeschäft.UseVisualStyleBackColor = true;
            // 
            // txtGekaufteMenge
            // 
            this.txtGekaufteMenge.BackColor = System.Drawing.Color.White;
            this.txtGekaufteMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGekaufteMenge.Location = new System.Drawing.Point(201, 86);
            this.txtGekaufteMenge.Multiline = true;
            this.txtGekaufteMenge.Name = "txtGekaufteMenge";
            this.txtGekaufteMenge.ReadOnly = true;
            this.txtGekaufteMenge.Size = new System.Drawing.Size(258, 33);
            this.txtGekaufteMenge.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(87, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "TotalMenge:";
            // 
            // txtProduktName
            // 
            this.txtProduktName.BackColor = System.Drawing.Color.White;
            this.txtProduktName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduktName.Location = new System.Drawing.Point(201, 37);
            this.txtProduktName.Multiline = true;
            this.txtProduktName.Name = "txtProduktName";
            this.txtProduktName.ReadOnly = true;
            this.txtProduktName.Size = new System.Drawing.Size(258, 33);
            this.txtProduktName.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(52, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "GelieferteMenge:";
            // 
            // txtGelieferteMenge
            // 
            this.txtGelieferteMenge.BackColor = System.Drawing.Color.White;
            this.txtGelieferteMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGelieferteMenge.Location = new System.Drawing.Point(201, 129);
            this.txtGelieferteMenge.Multiline = true;
            this.txtGelieferteMenge.Name = "txtGelieferteMenge";
            this.txtGelieferteMenge.ReadOnly = true;
            this.txtGelieferteMenge.Size = new System.Drawing.Size(258, 33);
            this.txtGelieferteMenge.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(55, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "GekaufteMenge:";
            // 
            // txtTotoMenge
            // 
            this.txtTotoMenge.BackColor = System.Drawing.Color.White;
            this.txtTotoMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotoMenge.Location = new System.Drawing.Point(201, 174);
            this.txtTotoMenge.Multiline = true;
            this.txtTotoMenge.Name = "txtTotoMenge";
            this.txtTotoMenge.ReadOnly = true;
            this.txtTotoMenge.Size = new System.Drawing.Size(258, 33);
            this.txtTotoMenge.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(70, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Produkt Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parfüm2025.Properties.Resources.Produkts;
            this.pictureBox1.Location = new System.Drawing.Point(558, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerkaufen
            // 
            this.btnVerkaufen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerkaufen.BackColor = System.Drawing.Color.IndianRed;
            this.btnVerkaufen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerkaufen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerkaufen.ForeColor = System.Drawing.Color.White;
            this.btnVerkaufen.Location = new System.Drawing.Point(852, 438);
            this.btnVerkaufen.Name = "btnVerkaufen";
            this.btnVerkaufen.Size = new System.Drawing.Size(115, 34);
            this.btnVerkaufen.TabIndex = 40;
            this.btnVerkaufen.Text = "Verkaufen";
            this.btnVerkaufen.UseVisualStyleBackColor = false;
            this.btnVerkaufen.Click += new System.EventHandler(this.btnVerkaufen_Click);
            // 
            // btnAktualisieren
            // 
            this.btnAktualisieren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAktualisieren.BackColor = System.Drawing.Color.IndianRed;
            this.btnAktualisieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktualisieren.ForeColor = System.Drawing.Color.White;
            this.btnAktualisieren.Location = new System.Drawing.Point(608, 438);
            this.btnAktualisieren.Name = "btnAktualisieren";
            this.btnAktualisieren.Size = new System.Drawing.Size(115, 34);
            this.btnAktualisieren.TabIndex = 41;
            this.btnAktualisieren.Text = "Aktualisieren";
            this.btnAktualisieren.UseVisualStyleBackColor = false;
            this.btnAktualisieren.Click += new System.EventHandler(this.btnAktualisieren_Click);
            // 
            // frmProdukts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 805);
            this.Controls.Add(this.btnAktualisieren);
            this.Controls.Add(this.btnVerkaufen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtFilerwert);
            this.Controls.Add(this.cbFilterbei);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKaufen);
            this.Controls.Add(this.dgvProdukts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmProdukts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdukts";
            this.Load += new System.EventHandler(this.frmProdukts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilerwert;
        private System.Windows.Forms.ComboBox cbFilterbei;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProdukts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDezGeschäft;
        private System.Windows.Forms.RadioButton rbHauptGeschäft;
        private System.Windows.Forms.Button btLoeschen;
        private System.Windows.Forms.Button btnAnzeigen;
        private System.Windows.Forms.Button btnKaufen;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.TextBox txtGekaufteMenge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProduktName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGelieferteMenge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotoMenge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVerkaufen;
        private System.Windows.Forms.Button btnAktualisieren;
    }
}