using iText.StyledXmlParser.Node;
using iText.Svg.Utils;
using iTextSharp.text.xml;
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
using Windows.ApplicationModel.VoiceCommands;

namespace Parfüm2025
{
    public partial class frmProdukts: Form
    {
        enum enMode { Addnew = 1, Update = 2}
        enMode _Mode;
        clsProduktes _produkts;
        BindingSource _bindingSource;
        public frmProdukts()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
        }
        private void _ResetDefaultValues()
        {
            txtProduktName.Clear();
            txtGekaufteMenge.Clear();
            txtGelieferteMenge.Clear();
            txtTotoMenge.Clear();
            rbHauptGeschäft.Checked = false;
            rbDezGeschäft.Checked = false;
        }

        private void _LoadProduktDataFromDatabase()
        {
            DataTable dt = clsProduktes.GetAllProduktes();
            if (dt != null && dt.Rows.Count > 0)
            {
                _bindingSource.DataSource = dt;
                dgvProdukts.DataSource = _bindingSource;
            }
            else
                dgvProdukts.DataSource = null;
        }
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            _ResetDefaultValues();
        }
        private void btnKaufen_Click(object sender, EventArgs e)
        {
            frmAddUpdateProdukts frm = new frmAddUpdateProdukts(null);
            frm.ShowDialog();

            _LoadProduktDataFromDatabase();
        }

        private void btnAktualisieren_Click(object sender, EventArgs e)
        {
            int produktID = (int)dgvProdukts.CurrentRow.Cells[0].Value;
            clsProduktes produkts = clsProduktes.FindByProduktID(produktID);
            if (produkts == null)
            {
                MessageBox.Show("Keiner Produkt wurde gefunden", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmAddUpdateProdukts frm = new frmAddUpdateProdukts(produkts);
            frm.ShowDialog();

            _LoadProduktDataFromDatabase();
        }

        private void frmProdukts_Load(object sender, EventArgs e)
        {
            _LoadProduktDataFromDatabase();
        }

        private void btnVerkaufen_Click(object sender, EventArgs e)
        {
            int produktID = (int)dgvProdukts.CurrentRow.Cells[0].Value;
            clsProduktes produkts = clsProduktes.FindByProduktID(produktID);
            if (produkts == null)
            {
                MessageBox.Show("Keiner Produkt wurde gefunden", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmLiefereProdukt frm = new frmLiefereProdukt(produkts);
            frm.ShowDialog();

            _LoadProduktDataFromDatabase();
        }

        private void dgvProdukts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            int produkID = (int)dgvProdukts.CurrentRow.Cells[0].Value;
            clsProduktes produktes = clsProduktes.FindByProduktID(produkID);
            if(produktes == null)
            {
                MessageBox.Show("Keine Produkt wurde gefunden", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _Anzeigen(produktes);
        }
        private void _Anzeigen(clsProduktes produktes)
        {
            txtProduktName.Text = produktes.ProduktName;
            txtGekaufteMenge.Text = produktes.GekaufteMenge.ToString();
            txtGelieferteMenge.Text = produktes.GelieferteMenge.ToString();
            txtTotoMenge.Text = produktes.Total.ToString();

            if (produktes.HauptGeschäft == true)
                rbHauptGeschäft.Checked = true;
            else if(produktes.DezGeschäft == true)
                rbDezGeschäft.Checked = true;
        }

        private void btLoeschen_Click(object sender, EventArgs e)
        {
            int produkID = (int)dgvProdukts.CurrentRow.Cells[0].Value;
            bool warnung = MessageBox.Show("Sind Sie sicher, Sie möchten diesen Vorgang durchführen", "Warnung", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes;

            if (!warnung)
                return;

            if(clsProduktes.DeleteProduktes(produkID))
            {
                MessageBox.Show($"Produkt mit der ID [ {produkID} ] wurde erfolgreich entfernt", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadProduktDataFromDatabase();
                _ResetDefaultValues();
            }
            else
                MessageBox.Show($"Fehler bei der Entfernung des Produktes mit der ID {produkID} ist aufgetreten", "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbFilterbei_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterbei.SelectedIndex != -1)
            {
                txtFilerwert.Clear();
                txtFilerwert.Focus();
            }
        }

        private void _FilterAnwenden()
        {
            string filterWert = txtFilerwert.Text.Trim();
            string filterSpalte = cbFilterbei.Text;

            if (string.IsNullOrEmpty(filterWert))
            {
                _bindingSource.Filter = null;
                return;
            }

            if (filterSpalte == "ProduktID")
                _bindingSource.Filter = $"{filterSpalte} = {filterWert}";
            else if (filterSpalte == "ProduktName")
                _bindingSource.Filter = $"{filterSpalte} Like '{filterWert}%'";
            else
                _bindingSource.Filter = null;
        }
        private void txtFilerwert_TextChanged(object sender, EventArgs e)
        {
            string filterSpalte = cbFilterbei.Text;
            string filterWert = txtFilerwert.Text.Trim();
            if (!string.IsNullOrEmpty(filterWert) && filterSpalte == "ProduktID" && !_IsNummer(filterWert))
            {
                MessageBox.Show("Bitte geben Sie eine gültige Nummer ein", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                _FilterAnwenden();
        }
        private bool _IsNummer(string eingabe)
        {
            return int.TryParse(eingabe, out int _);
        }
    }
}
