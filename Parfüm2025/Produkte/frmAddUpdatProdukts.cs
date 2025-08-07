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
    public partial class frmAddUpdateProdukts: Form
    {
        enum enMode { Addnew = 1, Update = 2 }
        enMode _Mode;
        clsProduktes _produkts;

        public frmAddUpdateProdukts(clsProduktes produkts)
        {
            InitializeComponent();
            this._produkts = produkts;
        }

        private void _ResetDefaultValues()
        {
            _Mode = enMode.Addnew;

            txtProduktName.Clear();
            txtGekaufteMenge.Clear();
        }

        private bool _IsValidInput(TextBox textbox, string message)
        {
            if (string.IsNullOrEmpty(textbox.Text))
            {
                errorProvider1.SetError(textbox, message);
                textbox.BackColor = Color.LightPink;
                return false;
            }
            else
            {
                errorProvider1.SetError(textbox, null);
                textbox.BackColor = Color.White;
                return true;
            }
        }
        private bool _CheckInputs()
        {
            bool isvalid = true;
            isvalid &= _IsValidInput(txtProduktName, "ProduktName darf nicht leer sein.");
            isvalid &= _IsValidInput(txtGekaufteMenge, "Gekaufte Menge darf nicht leer sein.");
            return isvalid;
        }
        private void _FillProduktData()
        {
            if (_Mode == enMode.Addnew)
                _produkts = new clsProduktes();

            _produkts.ProduktName = txtProduktName.Text;
             int gekaufteMenge = Convert.ToInt32(txtGekaufteMenge.Text);
            _produkts.GekaufteMenge = gekaufteMenge;
            _produkts.Total = _produkts.Total + gekaufteMenge;
        }
        private void _LoadData()
        {
            txtProduktName.Text = _produkts.ProduktName;
            // txtGekaufteMenge.Text = _produkts.GekaufteMenge.ToString();  
        }
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (!_CheckInputs())
            {
                MessageBox.Show("Bitte füllen Sie alle erforderlichen Felder aus.",
                    "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _FillProduktData();

            string status = _Mode == enMode.Addnew ? "hinzugefügt" : "aktualisiert";
            if (_produkts.Save())
            {
                MessageBox.Show($"Das Produkt wurde erfolgreich {status}.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update; //aktualisiere den Mode
                this.Close();
            }
            else
            {
                MessageBox.Show("Fehler beim Speichern des Produkts. Bitte versuchen Sie es erneut.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddUpdateProdukts_Load(object sender, EventArgs e)
        {
            if (_produkts != null)
            {
                _Mode = enMode.Update;
                _LoadData();
            }
            else
                _ResetDefaultValues();
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
