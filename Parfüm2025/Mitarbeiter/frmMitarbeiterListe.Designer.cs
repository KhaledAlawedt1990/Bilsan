namespace Parfüm2025
{
    partial class frmMitarbeiterListe
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
            this.dgvMitarbeiter = new System.Windows.Forms.DataGridView();
            this.cmsMitarbeiter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HinzufügeBenutzerrechtetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AktualisiereBenutzerrechtetoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.seheMitarbeiterDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aktualisiereMitarbeiterdatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entferneMitarbeiterdatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deaktiviereMitarbeiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktiviereMitarbeiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterwert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnAddnewMitarbeiter = new System.Windows.Forms.Button();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.btnAktualisieren = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMitarbeiter)).BeginInit();
            this.cmsMitarbeiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMitarbeiter
            // 
            this.dgvMitarbeiter.AllowUserToAddRows = false;
            this.dgvMitarbeiter.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvMitarbeiter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMitarbeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMitarbeiter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMitarbeiter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMitarbeiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMitarbeiter.ContextMenuStrip = this.cmsMitarbeiter;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMitarbeiter.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMitarbeiter.EnableHeadersVisualStyles = false;
            this.dgvMitarbeiter.Location = new System.Drawing.Point(12, 414);
            this.dgvMitarbeiter.MultiSelect = false;
            this.dgvMitarbeiter.Name = "dgvMitarbeiter";
            this.dgvMitarbeiter.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMitarbeiter.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMitarbeiter.RowHeadersWidth = 60;
            this.dgvMitarbeiter.RowTemplate.Height = 30;
            this.dgvMitarbeiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMitarbeiter.Size = new System.Drawing.Size(1548, 377);
            this.dgvMitarbeiter.TabIndex = 1;
            // 
            // cmsMitarbeiter
            // 
            this.cmsMitarbeiter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HinzufügeBenutzerrechtetoolStripMenuItem1,
            this.AktualisiereBenutzerrechtetoolStripMenuItem2,
            this.seheMitarbeiterDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.aktualisiereMitarbeiterdatenToolStripMenuItem,
            this.entferneMitarbeiterdatenToolStripMenuItem,
            this.toolStripSeparator2,
            this.deaktiviereMitarbeiterToolStripMenuItem,
            this.aktiviereMitarbeiterToolStripMenuItem});
            this.cmsMitarbeiter.Name = "cmsMitarbeiter";
            this.cmsMitarbeiter.Size = new System.Drawing.Size(295, 282);
            this.cmsMitarbeiter.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMitarbeiter_Opening);
            // 
            // HinzufügeBenutzerrechtetoolStripMenuItem1
            // 
            this.HinzufügeBenutzerrechtetoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HinzufügeBenutzerrechtetoolStripMenuItem1.Image = global::Parfüm2025.Properties.Resources.add_user_492527;
            this.HinzufügeBenutzerrechtetoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HinzufügeBenutzerrechtetoolStripMenuItem1.Name = "HinzufügeBenutzerrechtetoolStripMenuItem1";
            this.HinzufügeBenutzerrechtetoolStripMenuItem1.Size = new System.Drawing.Size(294, 38);
            this.HinzufügeBenutzerrechtetoolStripMenuItem1.Text = "Hinzufüge Benutzerrechte";
            this.HinzufügeBenutzerrechtetoolStripMenuItem1.Click += new System.EventHandler(this.HinzufügeBenutzerrechtetoolStripMenuItem1_Click);
            // 
            // AktualisiereBenutzerrechtetoolStripMenuItem2
            // 
            this.AktualisiereBenutzerrechtetoolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AktualisiereBenutzerrechtetoolStripMenuItem2.Image = global::Parfüm2025.Properties.Resources.recycle_17163818;
            this.AktualisiereBenutzerrechtetoolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AktualisiereBenutzerrechtetoolStripMenuItem2.Name = "AktualisiereBenutzerrechtetoolStripMenuItem2";
            this.AktualisiereBenutzerrechtetoolStripMenuItem2.Size = new System.Drawing.Size(294, 38);
            this.AktualisiereBenutzerrechtetoolStripMenuItem2.Text = "Aktualisiere Benutzerrechte";
            this.AktualisiereBenutzerrechtetoolStripMenuItem2.Click += new System.EventHandler(this.AktualisiereBenutzerrechtetoolStripMenuItem2_Click);
            // 
            // seheMitarbeiterDetailsToolStripMenuItem
            // 
            this.seheMitarbeiterDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seheMitarbeiterDetailsToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.details_32;
            this.seheMitarbeiterDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.seheMitarbeiterDetailsToolStripMenuItem.Name = "seheMitarbeiterDetailsToolStripMenuItem";
            this.seheMitarbeiterDetailsToolStripMenuItem.Size = new System.Drawing.Size(294, 38);
            this.seheMitarbeiterDetailsToolStripMenuItem.Text = "Sehe Mitarbeiter Details ";
            this.seheMitarbeiterDetailsToolStripMenuItem.Click += new System.EventHandler(this.seheMitarbeiterDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(291, 6);
            // 
            // aktualisiereMitarbeiterdatenToolStripMenuItem
            // 
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.refresh_5791276;
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.Name = "aktualisiereMitarbeiterdatenToolStripMenuItem";
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.Size = new System.Drawing.Size(294, 38);
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.Text = "Aktualisiere Mitarbeiterdaten";
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.Click += new System.EventHandler(this.aktualisiereMitarbeiterdatenToolStripMenuItem_Click);
            // 
            // entferneMitarbeiterdatenToolStripMenuItem
            // 
            this.entferneMitarbeiterdatenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entferneMitarbeiterdatenToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.delete_5953478__1_;
            this.entferneMitarbeiterdatenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entferneMitarbeiterdatenToolStripMenuItem.Name = "entferneMitarbeiterdatenToolStripMenuItem";
            this.entferneMitarbeiterdatenToolStripMenuItem.Size = new System.Drawing.Size(294, 38);
            this.entferneMitarbeiterdatenToolStripMenuItem.Text = "Entferne Mitarbeiterdaten";
            this.entferneMitarbeiterdatenToolStripMenuItem.Click += new System.EventHandler(this.entferneMitarbeiterdatenToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(291, 6);
            // 
            // deaktiviereMitarbeiterToolStripMenuItem
            // 
            this.deaktiviereMitarbeiterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deaktiviereMitarbeiterToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.unemployed_9772949;
            this.deaktiviereMitarbeiterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deaktiviereMitarbeiterToolStripMenuItem.Name = "deaktiviereMitarbeiterToolStripMenuItem";
            this.deaktiviereMitarbeiterToolStripMenuItem.Size = new System.Drawing.Size(294, 38);
            this.deaktiviereMitarbeiterToolStripMenuItem.Text = "Deaktiviere Mitarbeiter";
            this.deaktiviereMitarbeiterToolStripMenuItem.Click += new System.EventHandler(this.deaktiviereMitarbeiterToolStripMenuItem_Click);
            // 
            // aktiviereMitarbeiterToolStripMenuItem
            // 
            this.aktiviereMitarbeiterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktiviereMitarbeiterToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.tester_4157277;
            this.aktiviereMitarbeiterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aktiviereMitarbeiterToolStripMenuItem.Name = "aktiviereMitarbeiterToolStripMenuItem";
            this.aktiviereMitarbeiterToolStripMenuItem.Size = new System.Drawing.Size(294, 38);
            this.aktiviereMitarbeiterToolStripMenuItem.Text = "Aktiviere Mitarbeiter";
            this.aktiviereMitarbeiterToolStripMenuItem.Click += new System.EventHandler(this.aktiviereMitarbeiterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter bei:";
            // 
            // txtFilterwert
            // 
            this.txtFilterwert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFilterwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterwert.Location = new System.Drawing.Point(295, 374);
            this.txtFilterwert.Multiline = true;
            this.txtFilterwert.Name = "txtFilterwert";
            this.txtFilterwert.Size = new System.Drawing.Size(392, 35);
            this.txtFilterwert.TabIndex = 4;
            this.txtFilterwert.TextChanged += new System.EventHandler(this.txtFilterwert_TextChanged);
            this.txtFilterwert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterwert_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 794);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(90, 794);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 20);
            this.lblRecord.TabIndex = 6;
            this.lblRecord.Text = "###";
            // 
            // btnAddnewMitarbeiter
            // 
            this.btnAddnewMitarbeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddnewMitarbeiter.BackColor = System.Drawing.Color.Gray;
            this.btnAddnewMitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewMitarbeiter.ForeColor = System.Drawing.Color.White;
            this.btnAddnewMitarbeiter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddnewMitarbeiter.Location = new System.Drawing.Point(1269, 361);
            this.btnAddnewMitarbeiter.Name = "btnAddnewMitarbeiter";
            this.btnAddnewMitarbeiter.Size = new System.Drawing.Size(291, 49);
            this.btnAddnewMitarbeiter.TabIndex = 7;
            this.btnAddnewMitarbeiter.Text = "Hinzufüge einen neun Mitarbeiter";
            this.btnAddnewMitarbeiter.UseVisualStyleBackColor = false;
            this.btnAddnewMitarbeiter.Click += new System.EventHandler(this.btnAddnewMitarbeiter_Click);
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "Vollname",
            "MitarbeiterID"});
            this.cbFilterBei.Location = new System.Drawing.Point(104, 376);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(185, 32);
            this.cbFilterBei.TabIndex = 8;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // btnAktualisieren
            // 
            this.btnAktualisieren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAktualisieren.BackColor = System.Drawing.Color.White;
            this.btnAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktualisieren.ForeColor = System.Drawing.Color.White;
            this.btnAktualisieren.Image = global::Parfüm2025.Properties.Resources.update1;
            this.btnAktualisieren.Location = new System.Drawing.Point(1219, 362);
            this.btnAktualisieren.Name = "btnAktualisieren";
            this.btnAktualisieren.Size = new System.Drawing.Size(44, 46);
            this.btnAktualisieren.TabIndex = 10;
            this.btnAktualisieren.UseVisualStyleBackColor = false;
            this.btnAktualisieren.Click += new System.EventHandler(this.btnAktualisieren_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Parfüm2025.Properties.Resources.emplyees;
            this.pictureBox1.Location = new System.Drawing.Point(567, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1572, 45);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(665, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mitarbeiterverwaltung";
            // 
            // frmMitarbeiterListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 823);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAktualisieren);
            this.Controls.Add(this.cbFilterBei);
            this.Controls.Add(this.btnAddnewMitarbeiter);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilterwert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMitarbeiter);
            this.Name = "frmMitarbeiterListe";
            this.Text = "frmMitarbeiterListe";
            this.Load += new System.EventHandler(this.frmMitarbeiterListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMitarbeiter)).EndInit();
            this.cmsMitarbeiter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMitarbeiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterwert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnAddnewMitarbeiter;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.ContextMenuStrip cmsMitarbeiter;
        private System.Windows.Forms.ToolStripMenuItem seheMitarbeiterDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aktualisiereMitarbeiterdatenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entferneMitarbeiterdatenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deaktiviereMitarbeiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktiviereMitarbeiterToolStripMenuItem;
        private System.Windows.Forms.Button btnAktualisieren;
        private System.Windows.Forms.ToolStripMenuItem HinzufügeBenutzerrechtetoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AktualisiereBenutzerrechtetoolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}