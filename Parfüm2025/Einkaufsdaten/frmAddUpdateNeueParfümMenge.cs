using Busnisse_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parfüm2025
{
    public partial class frmAddUpdateNeueParfümMenge : Form
    {
        public enum enMode { addnew = 0, update =1, sehedetails = 2}
        public enMode _mode = enMode.addnew;

        private readonly object _lackObject = new object();
        clsEinkauf _einkaufsDaten;
        private int _parfümNummer;
        public frmAddUpdateNeueParfümMenge(int parfümNummer, enMode mode)
        {
            InitializeComponent();

            this._mode = mode;
            this._parfümNummer = parfümNummer;
        }

        private void _DatumEinrichten()
        {
            dtpErstellungsDatum.Format = DateTimePickerFormat.Custom;
            dtpErstellungsDatum.CustomFormat = "dd.MM.yyyy          HH:mm";
        }

        private void _setzeEinkaufsDatenAufStandardWerte()
        {
            _DatumEinrichten();

            txtParfümNummer.Clear();
            txtParfümName.Clear();
            txtHauptBatchNummer.Clear();
            txtSekundärBachNummer.Clear();
            txtMengeOfHauptBachNummer.Clear();
            txtMengeOfSekundärBatchNummer.Clear();
            txtParfümCode.Clear();
            txtPreiskategorie.Clear();
            dtpErstellungsDatum.Value = DateTime.Now;
        }

        private void _ladeEinkaufsDaten()
        {
            lock(_lackObject)
            {
                try
                {
                    _einkaufsDaten = clsEinkauf.FindEinkaufDatenByParfümNummer(_parfümNummer);
                     
                    if(_einkaufsDaten == null)
                    {
                        MessageBox.Show("Der gesuchte EinkaufsDaten wurde nicht gefunden.", "Fehlermeldung",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                   
                    txtParfümNummer.Text = _einkaufsDaten.parfümNummer.ToString();
                    txtParfümNummer.ReadOnly = true;

                    //die namen in der Klasse clsEinkaufdaten wurden geändert.  wird von HauptBatchNummer zu HauptLotNr und so weiter.
                    txtParfümName.Text = _einkaufsDaten.parfümName;
                    txtHauptBatchNummer.Text = _einkaufsDaten.HauptLotNr; 
                    txtSekundärBachNummer.Text = _einkaufsDaten.SekundärLotNr; //zweite batchnummer falls vorhanden
                    txtParfümCode.Text = _einkaufsDaten.parfümCode;
                    txtLagerbestandHaupt.Text = _einkaufsDaten.HauptLagerbestand.ToString();
                    //txtMengeOfHauptBachNummer.Text = _einkaufsDaten.HauptLagerbestand.ToString();
                    //txtMengeOfSekundärBatchNummer.Text = _einkaufsDaten.SekundärLagerbestand.ToString();
                    txtLagebestandSekundär.Text = _einkaufsDaten.SekundärLagerbestand.ToString();
                    txtPreiskategorie.Text = _einkaufsDaten.preisKategorie.ToString();
                    dtpErstellungsDatum.Value = _einkaufsDaten.erstellungsDatum;
                    
                  
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten: {ex.Message}", "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Ein Formatierungsfehler ist aufgetreten: {ex.Message}", "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ein allgemeiner Fehler ist aufgetreten: {ex.Message}", "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateNeueParfümMenge_Load(object sender, EventArgs e)
        {
            _setzeEinkaufsDatenAufStandardWerte();

            if (_mode == enMode.addnew)
            {
                _einkaufsDaten = new clsEinkauf();
            }
            else if (_mode == enMode.update)
            {
                _ladeEinkaufsDaten();
            }
            else
            {
                _ladeEinkaufsDaten();
                btnSpeichern.Enabled = false;
            }
        }


        private bool _ValidiereEinFeld(TextBox txtboxName, string name)
        {
            if (string.IsNullOrEmpty(txtboxName.Text))
            {
                errorProvider1.SetError(txtboxName, $"{name} darf nicht leer sein!");
                txtboxName.BackColor = Color.LightPink;  // Hintergrundfarbe ändern
                txtboxName.BorderStyle = BorderStyle.FixedSingle;

                return false;
            }
            else
            {
                errorProvider1.SetError(txtboxName, null);
                txtboxName.BackColor = Color.White;  // Standardfarbe wiederherstellen
                txtboxName.BorderStyle = BorderStyle.FixedSingle;
            }

            return true;
        }

        private bool _ValiedereEinkaufsdatenMenge()
        {
            bool isValid = true;

            isValid = _ValidiereEinFeld(txtParfümName, "ParfümName");
            isValid &= _ValidiereEinFeld(txtParfümCode, "ParfümCode");
            isValid &= _ValidiereEinFeld(txtPreiskategorie, "PreisKategorie");
            return isValid; // Gibt zurück, ob alle Felder gültig sind
        }

        private bool _fülleEinkaufsdaten()
        {
            _einkaufsDaten.parfümNummer = Convert.ToInt32(txtParfümNummer.Text);
            _einkaufsDaten.parfümCode = txtParfümCode.Text;
            _einkaufsDaten.parfümName = txtParfümName.Text;
            _einkaufsDaten.HauptLotNr = txtHauptBatchNummer.Text;
            _einkaufsDaten.SekundärLotNr = txtSekundärBachNummer.Text;

            float? hauptMenge = string.IsNullOrWhiteSpace(txtMengeOfHauptBachNummer.Text) ? 0
            : Convert.ToSingle(txtMengeOfHauptBachNummer.Text);

            float? sekundärMenge = string.IsNullOrWhiteSpace(txtMengeOfSekundärBatchNummer.Text) ? 0
                : Convert.ToSingle(txtMengeOfSekundärBatchNummer.Text);

            /*
              ?? 0 Bedeutung >>> Wenn _einkaufsDaten.HauptLagerbestand bereits einen Wert hat (z. B. 5.0), dann bleibt dieser Wert erhalten.
                  Falls _einkaufsDaten.HauptLagerbestand null ist, wird 0 verwendet.
             */
            // Falls HauptLagerbestand null ist, setze es auf 0, dann addiere die Menge
            if(hauptMenge != 0f)
                _einkaufsDaten.HauptLagerbestand = (_einkaufsDaten.HauptLagerbestand ?? 0) + hauptMenge;
            if(sekundärMenge != 0f)
                 _einkaufsDaten.SekundärLagerbestand = (_einkaufsDaten.SekundärLagerbestand ?? 0) + sekundärMenge;


            int preisKategorie = Convert.ToInt32(txtPreiskategorie.Text);
            if(!clsPreise.IstkategorieVorhanden(preisKategorie))
            {
                MessageBox.Show("Diese Kategorie existiert nicht, bitte geben Sie eine Andere ein","Fehlermeldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _einkaufsDaten.preisKategorie = preisKategorie;
            _einkaufsDaten.erstellungsDatum = dtpErstellungsDatum.Value;

            return true;
        }
        private float _HatDieEingabeGültigeNummer(string neueMenge)
        {
            float MengeNummer;

            if (float.TryParse(neueMenge, out MengeNummer))
            {
                return MengeNummer;
            }
            else
                return -1;
        }
        private void _speicherEinkaufsdaten()
        {
           
            if (!_ValiedereEinkaufsdatenMenge())
                return;

            if (!string.IsNullOrEmpty(txtMengeOfHauptBachNummer.Text) && _HatDieEingabeGültigeNummer(txtMengeOfHauptBachNummer.Text.Trim()) == -1)
            {
                errorProvider1.SetError(txtMengeOfHauptBachNummer, "Der Feld nimmt nur Nummer auf");
                return;
            }

            if(!string.IsNullOrEmpty(txtMengeOfSekundärBatchNummer.Text) && _HatDieEingabeGültigeNummer(txtMengeOfSekundärBatchNummer.Text.Trim()) == -1)
            {
                errorProvider1.SetError(txtMengeOfSekundärBatchNummer, "Der Feld nimmt nur Nummer auf");
                return;
            }

            if (!_fülleEinkaufsdaten())
                return;

            try
            {
                if (_einkaufsDaten.Save())
                {
                    MessageBox.Show($"Einkauf Daten erfolgreich {(_mode == enMode.addnew ? "hinzugefügt" : "aktualisiert")}", "Erfolg",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _mode = enMode.update; // wir aktualisieren den Object.

                    this.Close();
                    
                }
                else
                    MessageBox.Show("Fehler beim Speichern der Einkaufsdaten ist aufgetreten", "Fehlermeldung",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Überprüfen, ob der Fehler durch eine doppelte Primärnummer verursacht wurde
                if (ex.Message.Contains("PRIMARY KEY-Einschränkung") || ex.Message.Contains("Violation of PRIMARY KEY"))
                {
                    MessageBox.Show("Die eingegebene Parfümnummer existiert bereits. Bitte geben Sie eine eindeutige Nummer ein.",
                        "Doppelte Parfümnummer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Allgemeiner Fehler
                    MessageBox.Show($"Ein Fehler ist aufgetreten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            _speicherEinkaufsdaten();
        }

        private void txtParfümNummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnKategorieDetails_Click(object sender, EventArgs e)
        {
            frmPreisKategorieListe frm = new frmPreisKategorieListe();
            frm.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
