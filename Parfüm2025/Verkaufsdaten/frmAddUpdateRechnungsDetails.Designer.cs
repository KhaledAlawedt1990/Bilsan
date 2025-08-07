namespace Parfüm2025
{
    partial class frmAddUpdateRechnungsDetails
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
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtLagerBestandSekundär = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPreisKategorie = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chMitSteuer = new System.Windows.Forms.CheckBox();
            this.txtGesamtPreis = new System.Windows.Forms.TextBox();
            this.txtNormalPreis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBelegID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVerkaufsMenge = new System.Windows.Forms.TextBox();
            this.txtGrammText = new System.Windows.Forms.TextBox();
            this.txtLagerbestandHaupt = new System.Windows.Forms.TextBox();
            this.txtKundeName = new System.Windows.Forms.TextBox();
            this.txtParfümNummer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(350, 406);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(137, 31);
            this.btnAbbrechen.TabIndex = 5;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.txtLagerBestandSekundär);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPreisKategorie);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chMitSteuer);
            this.groupBox1.Controls.Add(this.txtGesamtPreis);
            this.groupBox1.Controls.Add(this.txtNormalPreis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBelegID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtVerkaufsMenge);
            this.groupBox1.Controls.Add(this.txtGrammText);
            this.groupBox1.Controls.Add(this.txtLagerbestandHaupt);
            this.groupBox1.Controls.Add(this.txtKundeName);
            this.groupBox1.Controls.Add(this.txtParfümNummer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 375);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verkauf-daten";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Location = new System.Drawing.Point(400, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(36, 26);
            this.textBox3.TabIndex = 28;
            this.textBox3.Text = "Gr";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLagerBestandSekundär
            // 
            this.txtLagerBestandSekundär.Location = new System.Drawing.Point(226, 248);
            this.txtLagerBestandSekundär.Name = "txtLagerBestandSekundär";
            this.txtLagerBestandSekundär.ReadOnly = true;
            this.txtLagerBestandSekundär.Size = new System.Drawing.Size(168, 26);
            this.txtLagerBestandSekundär.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "LagerBestandSekundär:";
            // 
            // btnPreisKategorie
            // 
            this.btnPreisKategorie.Location = new System.Drawing.Point(404, 293);
            this.btnPreisKategorie.Name = "btnPreisKategorie";
            this.btnPreisKategorie.Size = new System.Drawing.Size(36, 24);
            this.btnPreisKategorie.TabIndex = 25;
            this.btnPreisKategorie.Text = "...";
            this.btnPreisKategorie.UseVisualStyleBackColor = true;
            this.btnPreisKategorie.Click += new System.EventHandler(this.btnPreisKategorie_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "LagerBestandHaupt:";
            // 
            // chMitSteuer
            // 
            this.chMitSteuer.AutoSize = true;
            this.chMitSteuer.Location = new System.Drawing.Point(107, 332);
            this.chMitSteuer.Name = "chMitSteuer";
            this.chMitSteuer.Size = new System.Drawing.Size(101, 24);
            this.chMitSteuer.TabIndex = 3;
            this.chMitSteuer.Text = "MitSteuer:";
            this.chMitSteuer.UseVisualStyleBackColor = true;
            this.chMitSteuer.CheckedChanged += new System.EventHandler(this.chMitSteuer_CheckedChanged);
            // 
            // txtGesamtPreis
            // 
            this.txtGesamtPreis.Location = new System.Drawing.Point(228, 330);
            this.txtGesamtPreis.Name = "txtGesamtPreis";
            this.txtGesamtPreis.ReadOnly = true;
            this.txtGesamtPreis.Size = new System.Drawing.Size(170, 26);
            this.txtGesamtPreis.TabIndex = 21;
            // 
            // txtNormalPreis
            // 
            this.txtNormalPreis.Location = new System.Drawing.Point(228, 291);
            this.txtNormalPreis.Name = "txtNormalPreis";
            this.txtNormalPreis.Size = new System.Drawing.Size(170, 26);
            this.txtNormalPreis.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "NormalPreis:*";
            // 
            // txtBelegID
            // 
            this.txtBelegID.Location = new System.Drawing.Point(228, 39);
            this.txtBelegID.Name = "txtBelegID";
            this.txtBelegID.ReadOnly = true;
            this.txtBelegID.Size = new System.Drawing.Size(246, 26);
            this.txtBelegID.TabIndex = 17;
            this.txtBelegID.Text = "-1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "BelegID:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(402, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(36, 26);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Gr";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(76, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "VerkaufsMenge:*";
            // 
            // txtVerkaufsMenge
            // 
            this.txtVerkaufsMenge.Location = new System.Drawing.Point(228, 159);
            this.txtVerkaufsMenge.Name = "txtVerkaufsMenge";
            this.txtVerkaufsMenge.Size = new System.Drawing.Size(168, 26);
            this.txtVerkaufsMenge.TabIndex = 1;
            this.txtVerkaufsMenge.TextChanged += new System.EventHandler(this.txtVerkaufsMenge_TextChanged);
            // 
            // txtGrammText
            // 
            this.txtGrammText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGrammText.Location = new System.Drawing.Point(402, 201);
            this.txtGrammText.Name = "txtGrammText";
            this.txtGrammText.Size = new System.Drawing.Size(36, 26);
            this.txtGrammText.TabIndex = 12;
            this.txtGrammText.Text = "Gr";
            this.txtGrammText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLagerbestandHaupt
            // 
            this.txtLagerbestandHaupt.Location = new System.Drawing.Point(228, 201);
            this.txtLagerbestandHaupt.Name = "txtLagerbestandHaupt";
            this.txtLagerbestandHaupt.ReadOnly = true;
            this.txtLagerbestandHaupt.Size = new System.Drawing.Size(168, 26);
            this.txtLagerbestandHaupt.TabIndex = 10;
            // 
            // txtKundeName
            // 
            this.txtKundeName.Location = new System.Drawing.Point(226, 119);
            this.txtKundeName.Name = "txtKundeName";
            this.txtKundeName.Size = new System.Drawing.Size(246, 26);
            this.txtKundeName.TabIndex = 20;
            // 
            // txtParfümNummer
            // 
            this.txtParfümNummer.Location = new System.Drawing.Point(228, 80);
            this.txtParfümNummer.Name = "txtParfümNummer";
            this.txtParfümNummer.Size = new System.Drawing.Size(246, 26);
            this.txtParfümNummer.TabIndex = 0;
            this.txtParfümNummer.TextChanged += new System.EventHandler(this.txtParfümNummer_TextChanged);
            this.txtParfümNummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParfümNummer_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "KundeName:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ParfümNummer:*";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(199, 406);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(137, 31);
            this.btnSpeichern.TabIndex = 4;
            this.btnSpeichern.Text = "Add Details";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // frmAddUpdateRechnungsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 468);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateRechnungsDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdate-VerkaufDaten";
            this.Load += new System.EventHandler(this.frmAddUpdateVerkaufDaten_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVerkaufsMenge;
        private System.Windows.Forms.TextBox txtGrammText;
        private System.Windows.Forms.TextBox txtLagerbestandHaupt;
        private System.Windows.Forms.TextBox txtKundeName;
        private System.Windows.Forms.TextBox txtParfümNummer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBelegID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGesamtPreis;
        private System.Windows.Forms.TextBox txtNormalPreis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.CheckBox chMitSteuer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPreisKategorie;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtLagerBestandSekundär;
        private System.Windows.Forms.Label label5;
    }
}