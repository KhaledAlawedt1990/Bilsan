using Org.BouncyCastle.Tls.Crypto;
using ParfümDb_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parfüm2025
{
    public partial class frmDetails : Form
    {
        clsDetails _details;
        int _parfümNummer;
        string _parfümName;
        public frmDetails(clsDetails details,int parfümNummer, string parfümName)
        {
            InitializeComponent();
            _details = details;
            this._parfümNummer = parfümNummer;
            this._parfümName = parfümName;
        }

        private void _LadeParfümDetails()
        {

            lblParfümName.Text = _parfümNummer.ToString();
            lblParfümName.Text = _parfümName;
            txtDetails.Text = _details.Beschreibung;
        }
        private void _FillParfümDetails()
        {
            if(_details == null)
               _details = new clsDetails();


            lblParfümNummer.Text = _parfümNummer.ToString();
            lblParfümName.Text = _parfümName;
            _details.ParfümNummer = _parfümNummer;
            _details.Beschreibung = txtDetails.Text;
        }
        private void frmDetails_Load(object sender, EventArgs e)
        {
            if (_details != null)
                _LadeParfümDetails();
            else
                _FillParfümDetails();
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            _FillParfümDetails();
            if(!_details.Save())
            {
                MessageBox.Show("error while saving details","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }
    }
}
