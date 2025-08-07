using ParfümDb_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Parfüm2025
{
    public partial class frmLiefereProdukt: Form
    {
        clsProduktes _produkts;
        public frmLiefereProdukt(clsProduktes produktes)
        {
            InitializeComponent();
            this._produkts = produktes;
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ResetDefaultValues()
        {
            txtProduktName.Clear();
            txtTotoMenge.Clear();
            txtGelieferteMenge.Clear();
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
            isvalid &= _IsValidInput(txtGelieferteMenge, "Gelieferte Menge darf nicht leer sein.");
            return isvalid;
        }
        private bool _FillProduktData()
        {
            if (rbHauptGeschäft.Checked)
            {
                _produkts.DezGeschäft = false;
                _produkts.HauptGeschäft = true;
            }
            else
            {
                _produkts.HauptGeschäft = false;
                _produkts.DezGeschäft = true;
            }
            _produkts.ProduktName = txtProduktName.Text;
            int gelieferteMenge = Convert.ToInt32(txtGelieferteMenge.Text);
            if(gelieferteMenge > _produkts.Total)
            {
                MessageBox.Show("Die lieferende Menge überschreitet die TotalMenge, Bitte überprüfen Sie das lager der Produkte", "Warnung",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            _produkts.GelieferteMenge = gelieferteMenge;
            _produkts.Total = _produkts.Total - gelieferteMenge;

            return true;
        }
        private void _LoadData()
        {
            txtProduktName.Text = _produkts.ProduktName;
            txtTotoMenge.Text = _produkts.Total.ToString();
            // txtGekaufteMenge.Text = _produkts.GekaufteMenge.ToString();  
        }
        private void btnLiefern_Click(object sender, EventArgs e)
        {
            if (!_CheckInputs())
            {
                MessageBox.Show("Bitte füllen Sie alle erforderlichen Felder aus.",
                    "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_FillProduktData())
                return;
                 

            if (_produkts.Save())
            {
                MessageBox.Show("Die Lieferung wurde erfolgreich gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Fehler beim Speichern der Lieferung. Bitte prüfen Sie die Eingaben und versuchen Sie es erneut.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLiefereProdukt_Load(object sender, EventArgs e)
        {
            _LoadData();
            txtGelieferteMenge.Select();
        }
    }
}
