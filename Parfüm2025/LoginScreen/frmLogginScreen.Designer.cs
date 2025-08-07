namespace Parfüm2025
{
    partial class frmLogginScreen
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
            this.gbAnmeldeDaten = new System.Windows.Forms.GroupBox();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.btnEinloggen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbAnmeldeDaten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAnmeldeDaten
            // 
            this.gbAnmeldeDaten.BackColor = System.Drawing.Color.Gray;
            this.gbAnmeldeDaten.Controls.Add(this.btnSchliessen);
            this.gbAnmeldeDaten.Controls.Add(this.btnEinloggen);
            this.gbAnmeldeDaten.Controls.Add(this.label2);
            this.gbAnmeldeDaten.Controls.Add(this.label1);
            this.gbAnmeldeDaten.Controls.Add(this.txtPasswort);
            this.gbAnmeldeDaten.Controls.Add(this.txtUsername);
            this.gbAnmeldeDaten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAnmeldeDaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnmeldeDaten.ForeColor = System.Drawing.Color.Black;
            this.gbAnmeldeDaten.Location = new System.Drawing.Point(904, 0);
            this.gbAnmeldeDaten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAnmeldeDaten.Name = "gbAnmeldeDaten";
            this.gbAnmeldeDaten.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAnmeldeDaten.Size = new System.Drawing.Size(492, 886);
            this.gbAnmeldeDaten.TabIndex = 3;
            this.gbAnmeldeDaten.TabStop = false;
            this.gbAnmeldeDaten.Text = "Anmeldedaten";
            this.gbAnmeldeDaten.Enter += new System.EventHandler(this.gbAnmeldeDaten_Enter);
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.BackColor = System.Drawing.Color.White;
            this.btnSchliessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchliessen.Location = new System.Drawing.Point(27, 542);
            this.btnSchliessen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(416, 49);
            this.btnSchliessen.TabIndex = 5;
            this.btnSchliessen.Text = "Schließen";
            this.btnSchliessen.UseVisualStyleBackColor = false;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // btnEinloggen
            // 
            this.btnEinloggen.BackColor = System.Drawing.Color.White;
            this.btnEinloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinloggen.Location = new System.Drawing.Point(27, 472);
            this.btnEinloggen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEinloggen.Name = "btnEinloggen";
            this.btnEinloggen.Size = new System.Drawing.Size(416, 49);
            this.btnEinloggen.TabIndex = 4;
            this.btnEinloggen.Text = "Einloggen";
            this.btnEinloggen.UseVisualStyleBackColor = false;
            this.btnEinloggen.Click += new System.EventHandler(this.btnEinloggen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passwort:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "User name:";
            // 
            // txtPasswort
            // 
            this.txtPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswort.Location = new System.Drawing.Point(27, 284);
            this.txtPasswort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswort.Multiline = true;
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.PasswordChar = '*';
            this.txtPasswort.Size = new System.Drawing.Size(415, 48);
            this.txtPasswort.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(26, 193);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(415, 48);
            this.txtUsername.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Parfüm2025.Properties.Resources._555;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(904, 886);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogginScreen
            // 
            this.AcceptButton = this.btnEinloggen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 886);
            this.Controls.Add(this.gbAnmeldeDaten);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogginScreen";
            this.Text = "LogginScreen";
            this.gbAnmeldeDaten.ResumeLayout(false);
            this.gbAnmeldeDaten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAnmeldeDaten;
        private System.Windows.Forms.Button btnEinloggen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSchliessen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}