namespace Parfüm2025
{
    partial class frmDetails
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
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblParfümNummer = new System.Windows.Forms.Label();
            this.lblParfümName = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(29, 126);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(595, 324);
            this.txtDetails.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parfüm Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parfüm Nummer:";
            // 
            // lblParfümNummer
            // 
            this.lblParfümNummer.AutoSize = true;
            this.lblParfümNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParfümNummer.Location = new System.Drawing.Point(212, 29);
            this.lblParfümNummer.Name = "lblParfümNummer";
            this.lblParfümNummer.Size = new System.Drawing.Size(48, 25);
            this.lblParfümNummer.TabIndex = 3;
            this.lblParfümNummer.Text = "???";
            // 
            // lblParfümName
            // 
            this.lblParfümName.AutoSize = true;
            this.lblParfümName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParfümName.Location = new System.Drawing.Point(212, 83);
            this.lblParfümName.Name = "lblParfümName";
            this.lblParfümName.Size = new System.Drawing.Size(48, 25);
            this.lblParfümName.TabIndex = 4;
            this.lblParfümName.Text = "???";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.ForeColor = System.Drawing.Color.White;
            this.btnSpeichern.Location = new System.Drawing.Point(41, 466);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(156, 52);
            this.btnSpeichern.TabIndex = 5;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = false;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.ForeColor = System.Drawing.Color.White;
            this.btnAbbrechen.Location = new System.Drawing.Point(242, 466);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(156, 52);
            this.btnAbbrechen.TabIndex = 6;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = false;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 530);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.lblParfümName);
            this.Controls.Add(this.lblParfümNummer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetails);
            this.MaximizeBox = false;
            this.Name = "frmDetails";
            this.Text = "frmDetails";
            this.Load += new System.EventHandler(this.frmDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblParfümNummer;
        private System.Windows.Forms.Label lblParfümName;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnAbbrechen;
    }
}