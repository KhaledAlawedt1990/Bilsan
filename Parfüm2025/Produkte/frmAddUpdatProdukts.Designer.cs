namespace Parfüm2025
{
    partial class frmAddUpdateProdukts
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
            this.txtProduktName = new System.Windows.Forms.TextBox();
            this.txtGekaufteMenge = new System.Windows.Forms.TextBox();
            this.lblGekaufteMenge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnSchließen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProduktName
            // 
            this.txtProduktName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduktName.Location = new System.Drawing.Point(146, 21);
            this.txtProduktName.Multiline = true;
            this.txtProduktName.Name = "txtProduktName";
            this.txtProduktName.Size = new System.Drawing.Size(193, 33);
            this.txtProduktName.TabIndex = 46;
            // 
            // txtGekaufteMenge
            // 
            this.txtGekaufteMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGekaufteMenge.Location = new System.Drawing.Point(146, 71);
            this.txtGekaufteMenge.Multiline = true;
            this.txtGekaufteMenge.Name = "txtGekaufteMenge";
            this.txtGekaufteMenge.Size = new System.Drawing.Size(193, 33);
            this.txtGekaufteMenge.TabIndex = 48;
            // 
            // lblGekaufteMenge
            // 
            this.lblGekaufteMenge.AutoSize = true;
            this.lblGekaufteMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGekaufteMenge.ForeColor = System.Drawing.Color.Black;
            this.lblGekaufteMenge.Location = new System.Drawing.Point(7, 77);
            this.lblGekaufteMenge.Name = "lblGekaufteMenge";
            this.lblGekaufteMenge.Size = new System.Drawing.Size(133, 20);
            this.lblGekaufteMenge.TabIndex = 51;
            this.lblGekaufteMenge.Text = "Gekaufte Menge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Produkt Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblGekaufteMenge);
            this.groupBox1.Controls.Add(this.txtGekaufteMenge);
            this.groupBox1.Controls.Add(this.txtProduktName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 128);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produkt Information";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpeichern.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.ForeColor = System.Drawing.Color.White;
            this.btnSpeichern.Location = new System.Drawing.Point(97, 206);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(106, 40);
            this.btnSpeichern.TabIndex = 58;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = false;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnSchließen
            // 
            this.btnSchließen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchließen.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSchließen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchließen.ForeColor = System.Drawing.Color.White;
            this.btnSchließen.Location = new System.Drawing.Point(245, 206);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(106, 40);
            this.btnSchließen.TabIndex = 57;
            this.btnSchließen.Text = "Schließen";
            this.btnSchließen.UseVisualStyleBackColor = false;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 43);
            this.panel1.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaufen";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateProdukts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 265);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSchließen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateProdukts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Updat-Produkts";
            this.Load += new System.EventHandler(this.frmAddUpdateProdukts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtProduktName;
        private System.Windows.Forms.TextBox txtGekaufteMenge;
        private System.Windows.Forms.Label lblGekaufteMenge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnSchließen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}