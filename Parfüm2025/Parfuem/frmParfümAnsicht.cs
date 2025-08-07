
using Busnisse_Layer;
using clsHilfsMethoden;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text;
using ParfümDb_BusinessLayer;
using iTextSharp.text.pdf;
namespace Parfüm2025
{
    public partial class frmpafümAnsicht : Form
    {
        DataTable _dtParfüms;
        DataTable _dtHerrenParfüms;
        DataTable _dtDamenPafüms;

        BindingSource _bindingSourceParfüm;
        BindingSource _bindingSourceHerrenParfüm;
        BindingSource _bindingSourceDamenParfüm;

        // wir haben die lock-Blöcke verwendet um die tabellen sowie die Aktualisierung 
        // der Datenquellen zu Synchronisieren..
        private readonly object _dataloadLock = new object();
        private readonly object _filterLock = new object();
        private readonly object _autoComplateLock = new object();
        public frmpafümAnsicht()
        {
            InitializeComponent();
            // Setze den DrawMode des TabControls
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;

            _bindingSourceParfüm = new BindingSource();
            _bindingSourceHerrenParfüm = new BindingSource();
            _bindingSourceDamenParfüm = new BindingSource();
        }

        //Lade Daten für Unisexdüfte
        private void _LadeParfümDaten()
        {
            lock (_dataloadLock)
            {
                _dtParfüms = clsParfüm.GetAllParfüms();
                if (_dtParfüms != null && _dtParfüms.Rows.Count > 0)
                {
                    _bindingSourceParfüm.DataSource = _dtParfüms;
                    dgvParfüm.DataSource = _bindingSourceParfüm;
                    lblParfuemCount.Text = dgvParfüm.Rows.Count.ToString();

                    _MarkiereParfümZeilen();
                }
            }
        }

        //Lade Daten für Herrendüfte
        private void _LadeHerrenParfümDaten()
        {
            _dtHerrenParfüms = clsParfüm.GetAllHerrenParfüms();
            if (_dtHerrenParfüms != null && _dtHerrenParfüms.Rows.Count > 0)
            {
                _bindingSourceHerrenParfüm.DataSource = _dtHerrenParfüms;
                dgvHerrefDüfte.DataSource = _bindingSourceHerrenParfüm;
                lblHerrnParfuemCount.Text = _dtHerrenParfüms.Rows.Count.ToString();

                _MarkiereHerrenParfümZeilen();
            }
        }

        //Lade Daten für Damendüfte
        private void _LadeDamenParfümDaten()
        {
            _dtDamenPafüms = clsParfüm.GetAllDamenParfüms();
            if (_dtDamenPafüms != null && _dtDamenPafüms.Rows.Count > 0)
            {
                _bindingSourceDamenParfüm.DataSource = _dtDamenPafüms;
                dgvDamenParfüm.DataSource = _bindingSourceDamenParfüm;
                lblDamenParfuemCount.Text = dgvDamenParfüm.Rows.Count.ToString();

                _MarkiereDamenParfümZeilen();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbFilterBei.SelectedIndex = 0;
            cbHerrnFilter.SelectedIndex = 0;
            cbFrauenFilter.SelectedIndex = 0;

            // Verhindert, dass der Benutzer den Text ändert
            cbFilterBei.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHerrnFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFrauenFilter.DropDownStyle = ComboBoxStyle.DropDownList;

            _LadeParfümDaten();
            _LadeHerrenParfümDaten();
            _LadeDamenParfümDaten();
        }
        private void _MarkiereParfümZeilen()
        {
            foreach (DataGridViewRow row in dgvParfüm.Rows)
            {
                if (row.Cells["IstVorhanden"].Value != null && Convert.ToBoolean(row.Cells["IstVorhanden"].Value) == true)
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void _MarkiereHerrenParfümZeilen()
        {
            foreach (DataGridViewRow row in dgvHerrefDüfte.Rows)
            {
                if (row.Cells["IstVorhanden"].Value != null && Convert.ToBoolean(row.Cells["IstVorhanden"].Value) == true)
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
        private void _MarkiereDamenParfümZeilen()
        {
            foreach (DataGridViewRow row in dgvDamenParfüm.Rows)
            {
                if (row.Cells["IstVorhanden"].Value != null && Convert.ToBoolean(row.Cells["IstVorhanden"].Value) == true)
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
        private void mehrDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentName = dgvParfüm.CurrentRow.Cells[2].Value.ToString();
            // URL, die im Browser geöffnet werden soll
            string url = $"https://www.parfumo.de/s_perfumes_x.php?in=1&filter={currentName}";
            try
            {
                Process.Start("msedge", $"--new-tab \"{url}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Öffnen des Browsers: " + ex.Message);
            }
        }
        private void txtParfümFilterbeiNummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDamenPafrümFilterBeiNummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Bestimme die Farbe, die für das ausgewählte und das nicht ausgewählte Tab verwendet wird
            Color selectedColor = Color.DarkGray;  // Farbe für den ausgewählten Tab
            Color unselectedColor = Color.LightGray; // Farbe für nicht ausgewählte Tabs

            // Prüfe, ob der Tab ausgewählt ist
            bool isSelected = e.Index == tabControl1.SelectedIndex;

            // Setze die Hintergrundfarbe entsprechend der Auswahl
            e.Graphics.FillRectangle(new SolidBrush(isSelected ? selectedColor : unselectedColor), e.Bounds);

            // Zeichne den Tab-Text in Schwarz oder einer anderen Farbe deiner Wahl
            string tabText = tabControl1.TabPages[e.Index].Text;
            TextRenderer.DrawText(e.Graphics, tabText, tabControl1.Font, e.Bounds, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void txtParfümSuchen_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.Handled = true;
            //    btnSuchen.PerformClick();
           
            //}
        }

        private void txtParfümSuchen_TextChanged(object sender, EventArgs e)
        {
            _AvlBaumImplementierung();

        }
        private void _AvlBaumImplementierung()
        {
            AutoComplete.AVLTree tree = new AutoComplete.AVLTree();

            foreach (DataRow row in _dtParfüms.Rows)
            {
                tree.Insert(row["Name"].ToString());
            }

            string perfix = txtParfümSuchen.Text.Trim();
            var completions = tree.AutoComplete(perfix);

            //wir aktualisieren die listbox, um vorschläge anzuzeigen.
            UpdateAutoCompleteListeBox(completions);

        }

        private void UpdateAutoCompleteListeBox(IEnumerable<string> completions)
        {
            lock (_autoComplateLock)
            {
                lbVorschläge.Items.Clear();

                //wir füllen dann die listebox mit vorschlägen
                foreach (var suggestion in completions)
                {
                    lbVorschläge.Items.Add(suggestion.ToString());
                }

                if (!string.IsNullOrEmpty(txtParfümSuchen.Text.Trim()))
                {
                    //die liste wird angezeigt, wenn da Vorschläge gibt.
                    lbVorschläge.Visible = lbVorschläge.Items.Count > 0;
                }
                else
                {
                    lbVorschläge.Items.Clear();
                    lbVorschläge.Visible = false;
                }
            }
        }

        private void lbVorschläge_Click_1(object sender, EventArgs e)
        {
           
            //wir setzen den ausgewählten Vorschlag in das "txtFilterBeiName" Textfeld und verbergen wir  die listboxw
            if (lbVorschläge.SelectedItem != null)
            {
                txtParfümSuchen.Text = lbVorschläge.SelectedItem.ToString();
                lbVorschläge.Visible = false;
            }
            else
                MessageBox.Show("Kein gültiger Eintrag ausgewählt,\n" +
                    "Bitte wählen Sie einen gültigen Eintrag aus","Hinweis",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnSuchen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtParfümSuchen.Text))
            {
                string gesuchteDaten = txtParfümSuchen.Text.Trim();
                string url = $"https://www.parfumo.de/s_perfumes_x.php?in=1&filter={gesuchteDaten}";

                try
                {
                    Process.Start("msedge", $"--new-tab \"{url}\"");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Öffnen des Browsers: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Suchbegriff ein.");
            }
        }

        private void txtParfümSuchen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Verhindern, dass die Enter-Taste in das Textfeld eingegeben wird (kein Signalton)
                e.Handled = true;

                // Klick den Such-Button auslösen
                btnSuchen.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (frmAddUpdateNewPerfum frm = new frmAddUpdateNewPerfum(-1))
            {
                frm.ShowDialog();
            }
            _LadeParfümDaten();
        }

        private void duftEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            bool result = (MessageBox.Show("Sind Sie sicher, Sie möchten " +
              "diesen Vorgang durchführen","Hinweis",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,
              MessageBoxDefaultButton.Button2) == DialogResult.OK);

            if (!result)
                return;

            int parfümNummer = (int)dgvParfüm.CurrentRow.Cells[0].Value;
            clsParfüm parfuemDaten = clsParfüm.FindByParfümNummer(parfümNummer);

         
            if (parfuemDaten != null && parfuemDaten.Delete())
            {
                AutoComplete.AVLTree tree = new AutoComplete.AVLTree();
                tree.Delete(parfuemDaten.Name);

                MessageBox.Show("Parfümdaten wurden erfolgreich entfernt","Entfernung",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _LadeParfümDaten();
            }
            else
                MessageBox.Show("Parfümdaten wurden nicht gefunden, \nbitte versuchen Sie es erneut.", "Entfernung",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void parfümHinzufügentoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmAddUpdateNewPerfum frm = new frmAddUpdateNewPerfum(-1))
            {
                frm.ShowDialog();
            }
            _LadeParfümDaten();
        }

        private void pafümAktualisierentoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int parfümNummer = (int)dgvParfüm.CurrentRow.Cells[0].Value;

            using(frmAddUpdateNewPerfum frm = new frmAddUpdateNewPerfum(parfümNummer))
            {
                frm.ShowDialog();
            }
            _LadeParfümDaten();
        }

        private void btnDatenAktualisieren_Click(object sender, EventArgs e)
        {
            _LadeParfümDaten();
        }

        private void _FilterAnwendenFürParfüms()
        {
            string spalteName = cbFilterBei.SelectedItem.ToString();
            string filterwert = txtFilterWert.Text;

            lock (_filterLock)
            {
                if (cbFilterBei.SelectedIndex != -1)
                {
                    if (!string.IsNullOrEmpty(filterwert))
                    {
                        if (spalteName == "ParfümNummer")
                        {
                            _bindingSourceParfüm.Filter = $"{spalteName} = {filterwert}";
                        }
                        else if (spalteName == "Name")
                        {
                            _FilterByName(filterwert, spalteName);
                        }
                        else if (spalteName == "Marke")
                        {
                            _FilterByMarke(filterwert, spalteName);
                        }
                        else if (spalteName == "Kategorie" || spalteName == "Basisnote" || spalteName == "Duftrichtung")
                        {
                            _bindingSourceParfüm.Filter = $"{spalteName} Like '%{filterwert}%'";
                        }
                        else
                            _bindingSourceParfüm.Filter = null;
                    }
                    else
                        _bindingSourceParfüm.Filter = null;
                }
            }
            _MarkiereParfümZeilen();
        }

        private void _FilterByName(string filterwert, string spalteName)
        {
            DataTable dt = clsParfüm.GetAllParfuemByName(filterwert);
            if (dt == null || dt.Rows.Count == 0)
            {
                _bindingSourceParfüm.Filter = string.Empty;
            }
            else
            {
                List<string> filterdValue = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    string name = row["Name"].ToString();
                    filterdValue.Add($"'{name.Replace("'", "''")}'"); //if the word has a single quote, it will be replaced with two single quotes
                }
                string filterString = string.Join(",", filterdValue);
                _bindingSourceParfüm.Filter = $"{spalteName} IN ({filterString})";
            }
        }
        private void _FilterByMarke(string filterwert, string spalteName)
        {
            DataTable dt = clsParfüm.GetAllParfuemByMarke(filterwert);
            if (dt == null || dt.Rows.Count == 0)
            {
                _bindingSourceParfüm.Filter = string.Empty;
            }
            else
            {
                List<string> filterdValue = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    string marke = row["Marke"].ToString();
                    filterdValue.Add($"'{marke.Replace("'", "''")}'"); //if the word has a single quote, it will be replaced with two single quotes
                }
                string filterString = string.Join(",", filterdValue);
                _bindingSourceParfüm.Filter = $"{spalteName} IN ({filterString})";
            }
        }
        private void txtFilterWert_TextChanged(object sender, EventArgs e)
        {
            _FilterAnwendenFürParfüms();
        }

        private void cbFilterBei_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBei.SelectedIndex != -1)
            {
                txtFilterWert.Clear();
                txtFilterWert.Focus();
            }
        }

        private void txtFilterWert_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selectedItem = cbFilterBei.SelectedItem.ToString();

            if (selectedItem == "ParfümNummer")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void erstelleEineParfümlisteAlsPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ErstellePdfVonParfuem1();
        }

        private void btnErstelleEineParfümListePdf_Click(object sender, EventArgs e)
        {
            _ErstellePdfVonParfuem1();
        }


        private void _FilterAnwendenFürHerrnParfüms()
        {
            string spalteName = cbHerrnFilter.SelectedItem.ToString();
            string filterwert = txtHerrnFilterwert.Text;

            lock (_filterLock)
            {
                if (cbHerrnFilter.SelectedIndex != -1)
                {
                    if (!string.IsNullOrEmpty(filterwert))
                    {
                        if (spalteName == "ParfümNummer" || spalteName == "IstVorhanden")
                        {
                            _bindingSourceHerrenParfüm.Filter = $"{spalteName} = {filterwert}";
                        }
                        else if (spalteName == "Name")
                        {
                            _HerrnFilterByName(filterwert, spalteName);
                        }
                        else if (spalteName == "Marke")
                        {
                            _HerrnFilterByMarke(filterwert, spalteName);
                        }
                        else if (spalteName == "Kategorie" || spalteName == "Basisnote" || spalteName == "Duftrichtung")
                        {
                            _bindingSourceHerrenParfüm.Filter = $"{spalteName} Like '%{filterwert}%'";
                        }
                        else
                            _bindingSourceHerrenParfüm.Filter = null;
                    }
                    else
                        _bindingSourceHerrenParfüm.Filter = null;
                }
            }
             _MarkiereHerrenParfümZeilen();
        }
        private void _HerrnFilterByMarke(string filterwert, string spalteName)
        {
            DataTable dt = clsParfüm.GetAllParfuemByMarke(filterwert);
            if (dt == null || dt.Rows.Count == 0)
            {
                _bindingSourceHerrenParfüm.Filter = string.Empty;
            }
            else
            {
                List<string> filterdValue = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    string marke = row["Marke"].ToString();
                    filterdValue.Add($"'{marke.Replace("'", "''")}'"); //if the word has a single quote, it will be replaced with two single quotes
                }
                string filterString = string.Join(",", filterdValue);
                _bindingSourceHerrenParfüm.Filter = $"{spalteName} IN ({filterString})";
            }
        }

        private void _HerrnFilterByName(string filterwert, string spalteName)
        {
            DataTable dt = clsParfüm.GetAllParfuemByName(filterwert);
            if (dt == null || dt.Rows.Count == 0)
            {
                _bindingSourceHerrenParfüm.Filter = string.Empty;
            }
            else
            {
                List<string> filterdValue = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    string name = row["Name"].ToString();
                    filterdValue.Add($"'{name.Replace("'", "''")}'"); //if the word has a single quote, it will be replaced with two single quotes
                }
                string filterString = string.Join(",", filterdValue);
                _bindingSourceHerrenParfüm.Filter = $"{spalteName} IN ({filterString})";
            }
        }

        private void txtHerrnFilterwert_TextChanged(object sender, EventArgs e)
        {
            _FilterAnwendenFürHerrnParfüms();
        }

        private void cbHerrnFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHerrnFilter.SelectedIndex != -1)
            {
                txtHerrnFilterwert.Clear();
                txtHerrnFilterwert.Focus();
            }
        }

        private void dgvParfüm_DoubleClick(object sender, EventArgs e)
        {
            string currentName = dgvParfüm.CurrentRow.Cells[2].Value.ToString();
            // URL, die im Browser geöffnet werden soll
            string url = $"https://www.parfumo.de/s_perfumes_x.php?in=1&filter={currentName}";
            try
            {
                Process.Start("msedge", $"--new-tab \"{url}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Öffnen des Browsers: " + ex.Message);
            }
        }

        private void dgvParfüm_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _MarkiereParfümZeilen();
        }

        private void btnErstelleFlohmarktPdf_Click(object sender, EventArgs e)
        {
            _ErstelleFlohmarktPdf();
        }
        private void _ErstelleFlohmarktPdf()
        {
            // Pfad zum Desktop des aktuellen Benutzers
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Name und Pfad der PDF-Datei
            string fileName = "FlohmarktListe.pdf";
            string filePath = Path.Combine(desktopPath, fileName);

            try
            {
                // PDF speichern
                using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (Document pdfDoc = new Document())
                    {
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // Erstelle eine Tabelle mit 3 Spalten
                        PdfPTable table = new PdfPTable(3);
                        table.WidthPercentage = 100;


                        //// Header mit Hintergrundfarbe
                        //table.AddCell(new PdfPCell(new Phrase("Parfümnummer"))
                        //{
                        //    BackgroundColor = BaseColor.LIGHT_GRAY,
                        //    Padding = 10f
                        //});
                        //table.AddCell(new PdfPCell(new Phrase("Parfümmarke"))
                        //{
                        //    BackgroundColor = BaseColor.LIGHT_GRAY,
                        //    Padding = 10f
                        //});
                        //table.AddCell(new PdfPCell(new Phrase("Parfümname"))
                        //{
                        //    BackgroundColor = BaseColor.LIGHT_GRAY,
                        //    Padding = 10f
                        //});

                        // Daten filtern
                        var sortierteParfums = dgvParfüm.Rows
                            .Cast<DataGridViewRow>()
                            .Where(row =>
                                !row.IsNewRow &&
                                row.Cells["ZumFlohmarkt"].Value != null &&
                                bool.TryParse(row.Cells["ZumFlohmarkt"].Value.ToString(), out bool zumFlohmarkt) &&
                                zumFlohmarkt)
                            .OrderBy(row => row.Cells["Kategorie"]?.Value?.ToString())
                            .ToList();

                        string aktuelleKategorie = "";
                        int zeilenIndex = 0; // Für abwechselnde Farben

                        // Füge die Daten sortiert in die Tabelle ein
                        foreach (DataGridViewRow row in sortierteParfums)
                        {
                            var kategorie = row.Cells["Kategorie"]?.Value?.ToString();
                            var parfuemNummer = row.Cells["Parfümnummer"]?.Value?.ToString();
                            var parfuemName = "Richtung " + row.Cells["Name"]?.Value?.ToString();
                            var Duftrichtun = row.Cells["Duftrichtung"]?.Value?.ToString();

                            if (!string.IsNullOrEmpty(parfuemNummer) && !string.IsNullOrEmpty(parfuemName))
                            {
                                // Neue Kategorie? Dann eine farbige Überschrift einfügen
                                if (kategorie != aktuelleKategorie)
                                {
                                    PdfPCell headerCell = new PdfPCell(new Phrase("--- " + kategorie + " ---",
                                      new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLD, BaseColor.BLACK)))
                                    {
                                        Colspan = 3,
                                        HorizontalAlignment = Element.ALIGN_CENTER,
                                        BackgroundColor = BaseColor.GREEN,
                                        Padding = 8f
                                    };
                                    table.AddCell(headerCell);
                                    aktuelleKategorie = kategorie;
                                    zeilenIndex = 0; // Zeilenzähler zurücksetzen bei neuer Kategorie
                                }

                                // Abwechselnde Hintergrundfarben für Zeilen
                                BaseColor rowColor = (zeilenIndex % 2 == 0) ? BaseColor.YELLOW : BaseColor.PINK;

                                PdfPCell cell1 = new PdfPCell(new Phrase(parfuemNummer))
                                {
                                    BackgroundColor = rowColor,
                                    Padding = 5f
                                };
                             
                                PdfPCell cell2 = new PdfPCell(new Phrase(parfuemName))
                                {
                                    BackgroundColor = rowColor,
                                    Padding = 5f
                                };
                                PdfPCell cell3 = new PdfPCell(new Phrase(Duftrichtun))
                                {
                                    BackgroundColor = rowColor,
                                    Padding = 5f
                                };
                                table.AddCell(cell1);

                                table.AddCell(cell2);
                                table.AddCell(cell3);

                                zeilenIndex++;
                            }
                        }

                        // Tabelle zur PDF hinzufügen
                        pdfDoc.Add(table);
                        pdfDoc.Close();
                    }
                }

                // Erfolgsmeldung
                MessageBox.Show($"Die Datei wurde erfolgreich auf dem Desktop gespeichert:\n{filePath}", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Fehlerbehandlung
                MessageBox.Show($"Fehler beim Speichern der Datei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _ErstellePdfVonParfuem1()
        {
            // Pfad zum Desktop des aktuellen Benutzers
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Name und Pfad der PDF-Datei
            string fileName = "Parfuemliste.pdf";
            string filePath = Path.Combine(desktopPath, fileName);

            try
            {
                // PDF speichern
                using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (Document pdfDoc = new Document())
                    {
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // Erstelle eine Tabelle mit 3 Spalten
                        PdfPTable table = new PdfPTable(4);
                        table.WidthPercentage = 100;


                        //// Header mit Hintergrundfarbe
                        //table.AddCell(new PdfPCell(new Phrase("Parfümnummer"))
                        //{
                        //    BackgroundColor = BaseColor.LIGHT_GRAY,
                        //    Padding = 10f
                        //});
                        //table.AddCell(new PdfPCell(new Phrase("Parfümmarke"))
                        //{
                        //    BackgroundColor = BaseColor.LIGHT_GRAY,
                        //    Padding = 10f
                        //});
                        //table.AddCell(new PdfPCell(new Phrase("Parfümname"))
                        //{
                        //    BackgroundColor = BaseColor.LIGHT_GRAY,
                        //    Padding = 10f
                        //});

                        // Daten aus DataGridView abrufen und sortieren
                        var sortierteParfums = dgvParfüm.Rows
                            .Cast<DataGridViewRow>()
                            .Where(row => !row.IsNewRow && (bool)row.Cells["IstVorhanden"].Value == true)
                            .OrderBy(row => row.Cells["Kategorie"].Value?.ToString())
                            .ToList();

                        string aktuelleKategorie = "";
                        int zeilenIndex = 0; // Für abwechselnde Farben

                        // Füge die Daten sortiert in die Tabelle ein
                        foreach (DataGridViewRow row in sortierteParfums)
                        {
                            var kategorie = row.Cells["Kategorie"]?.Value?.ToString();
                            var parfuemNummer = row.Cells["Parfümnummer"]?.Value?.ToString();
                            var parfuemMarke = row.Cells["Marke"]?.Value.ToString();
                            var parfuemName = row.Cells["Name"]?.Value?.ToString();
                            var Duftrichtun = row.Cells["Duftrichtung"]?.Value?.ToString();

                            if (!string.IsNullOrEmpty(parfuemNummer) && !string.IsNullOrEmpty(parfuemMarke) && !string.IsNullOrEmpty(parfuemName))
                            {
                                // Neue Kategorie? Dann eine farbige Überschrift einfügen
                                if (kategorie != aktuelleKategorie)
                                {
                                    PdfPCell headerCell = new PdfPCell(new Phrase("--- " + kategorie + " ---",
                                      new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLD, BaseColor.BLACK)))
                                    {
                                        Colspan = 4,
                                        HorizontalAlignment = Element.ALIGN_CENTER,
                                        BackgroundColor = BaseColor.GREEN,
                                        Padding = 8f
                                    };
                                    table.AddCell(headerCell);
                                    aktuelleKategorie = kategorie;
                                    zeilenIndex = 0; // Zeilenzähler zurücksetzen bei neuer Kategorie
                                }

                                // Abwechselnde Hintergrundfarben für Zeilen
                                BaseColor rowColor = (zeilenIndex % 2 == 0) ? BaseColor.YELLOW : BaseColor.PINK;

                                PdfPCell cell1 = new PdfPCell(new Phrase(parfuemNummer))
                                {
                                    BackgroundColor = rowColor,
                                    Padding = 6f
                                };
                                PdfPCell cell2 = new PdfPCell(new Phrase(parfuemMarke))
                                {
                                    BackgroundColor = rowColor,
                                    Padding = 6f
                                };
                                PdfPCell cell3 = new PdfPCell(new Phrase(parfuemName))
                                {
                                    BackgroundColor = rowColor,
                                    Padding = 6f
                                };
                                PdfPCell cell4 = new PdfPCell(new Phrase(Duftrichtun))
                                {
                                    BackgroundColor = rowColor,
                                    Padding = 6f
                                };

                                table.AddCell(cell1);
                                table.AddCell(cell2);
                                table.AddCell(cell3);
                                table.AddCell(cell4);

                                zeilenIndex++;
                            }
                        }

                        // Tabelle zur PDF hinzufügen
                        pdfDoc.Add(table);
                        pdfDoc.Close();
                    }
                }

                // Erfolgsmeldung
                MessageBox.Show($"Die Datei wurde erfolgreich auf dem Desktop gespeichert:\n{filePath}", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Fehlerbehandlung
                MessageBox.Show($"Fehler beim Speichern der Datei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2HerrnDüfte)
                _MarkiereHerrenParfümZeilen();
            else if (tabControl1.SelectedTab == tabPage3DamenDüfte)
                _MarkiereDamenParfümZeilen();
        }

        private void txtHerrnFilterwert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((cbHerrnFilter.Text == "ParfümNummer" || cbHerrnFilter.Text == "IstVorhanden") && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
                
        }
        private void dgvHerrefDüfte_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _MarkiereHerrenParfümZeilen();
        }

        private void cbFrauenFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFrauenFilter.SelectedIndex != -1)
            {
                txtFrauenFilterWert.Clear();
                txtFrauenFilterWert.Focus();
            }
        }

        private void txtFrauenFilterWert_TextChanged(object sender, EventArgs e)
        {
            _FilterAnwendenFürDamenParfüms();
        }
        private void _FilterAnwendenFürDamenParfüms()
        {
            string spalteName = cbFrauenFilter.SelectedItem.ToString();
            string filterwert =  txtFrauenFilterWert.Text;

            lock (_filterLock)
            {
                if (cbFrauenFilter.SelectedIndex != -1)
                {
                    if (!string.IsNullOrEmpty(filterwert))
                    {
                        if (spalteName == "ParfümNummer" || spalteName == "IstVorhanden")
                        {
                            _bindingSourceDamenParfüm.Filter = $"{spalteName} = {filterwert}";
                        }
                        else if (spalteName == "Name")
                        {
                            _DamenFilterByName(filterwert, spalteName);
                        }
                        else if (spalteName == "Marke")
                        {
                            _DamenFilterByMarke(filterwert, spalteName);
                        }
                        else if (spalteName == "Kategorie" || spalteName == "Basisnote" || spalteName == "Duftrichtung")
                        {
                            _bindingSourceDamenParfüm.Filter = $"{spalteName} Like '%{filterwert}%'";
                        }
                        else
                            _bindingSourceDamenParfüm.Filter = null;
                    }
                    else
                        _bindingSourceDamenParfüm.Filter = null;
                }
            }
            _MarkiereDamenParfümZeilen();
        }
        private void _DamenFilterByMarke(string filterwert, string spalteName)
        {
            DataTable dt = clsParfüm.GetAllParfuemByMarke(filterwert);
            if (dt == null || dt.Rows.Count == 0)
            {
                _bindingSourceDamenParfüm.Filter = string.Empty;
            }
            else
            {
                List<string> filterdValue = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    string marke = row["Marke"].ToString();
                    filterdValue.Add($"'{marke.Replace("'", "''")}'"); //if the word has a single quote, it will be replaced with two single quotes
                }
                string filterString = string.Join(",", filterdValue);
                _bindingSourceDamenParfüm.Filter = $"{spalteName} IN ({filterString})";
            }
        }

        private void _DamenFilterByName(string filterwert, string spalteName)
        {
            DataTable dt = clsParfüm.GetAllParfuemByName(filterwert);
            if (dt == null || dt.Rows.Count == 0)
            {
                _bindingSourceDamenParfüm.Filter = string.Empty;
            }
            else
            {
                List<string> filterdValue = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    string name = row["Name"].ToString();
                    filterdValue.Add($"'{name.Replace("'", "''")}'"); //if the word has a single quote, it will be replaced with two single quotes
                }
                string filterString = string.Join(",", filterdValue);
                _bindingSourceDamenParfüm.Filter = $"{spalteName} IN ({filterString})";
            }
        }

        private void dgvDamenParfüm_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _MarkiereDamenParfümZeilen();
        }

        private void dgvParfüm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHerrefDüfte_DoubleClick(object sender, EventArgs e)
        {
            string currentName = dgvHerrefDüfte.CurrentRow.Cells[2].Value.ToString();
            // URL, die im Browser geöffnet werden soll
            string url = $"https://www.parfumo.de/s_perfumes_x.php?in=1&filter={currentName}";
            try
            {
                Process.Start("msedge", $"--new-tab \"{url}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Öffnen des Browsers: " + ex.Message);
            }
        }

        private void dgvDamenParfüm_DoubleClick(object sender, EventArgs e)
        {
            string currentName = dgvDamenParfüm.CurrentRow.Cells[2].Value.ToString();
            // URL, die im Browser geöffnet werden soll
            string url = $"https://www.parfumo.de/s_perfumes_x.php?in=1&filter={currentName}";
            try
            {
                Process.Start("msedge", $"--new-tab \"{url}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Öffnen des Browsers: " + ex.Message);
            }
        }
    }
}
