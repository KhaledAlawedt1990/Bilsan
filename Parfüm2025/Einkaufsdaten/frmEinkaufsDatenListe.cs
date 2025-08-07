using Busnisse_Layer;
using iText.Layout.Element;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;



namespace Parfüm2025
{
    public partial class frmEinkaufsDatenListe : Form
    {
        DataTable _dtEinkaufsdaten;
        BindingSource _bindingSource;
        private readonly object _lockObject = new object();
        public frmEinkaufsDatenListe()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
        }

        private void btnHinzufügeNeueMenge_Click(object sender, EventArgs e)
        {
            frmAddUpdateNeueParfümMenge frm = new frmAddUpdateNeueParfümMenge(-1, frmAddUpdateNeueParfümMenge.enMode.addnew);
            frm.ShowDialog();

            _LoadEinkaufDateFromDataBase();
        }
        private void _LoadEinkaufDateFromDataBase()
        {
            _dtEinkaufsdaten = clsEinkauf.GetAllEinkaufDaten();
            if (_dtEinkaufsdaten != null && _dtEinkaufsdaten.Rows.Count > 0)
            {
                _bindingSource.DataSource = _dtEinkaufsdaten;
                dgvLager.DataSource = _bindingSource;
            }

            _SetzeFarben();
            _MachDataGridViewColumnNotSortable(); //Column Notsortable.
        }

        private void _SetzeFarben()
        {
            foreach (DataGridViewRow row in dgvLager.Rows)
            {
                if (row.Cells["HauptLagerbestand"].Value != DBNull.Value)
                {
                    float lagerBestandHaupt = Convert.ToSingle(row.Cells["HauptLagerbestand"].Value);

                    if (lagerBestandHaupt < 3000)
                    {
                        if (lagerBestandHaupt < 1000)
                        {
                            row.Cells["HauptLagerbestand"].Style.BackColor = Color.Red;
                            row.Cells["HauptLagerbestand"].Style.ForeColor = Color.White;
                        }
                        else
                        {
                            row.Cells["HauptLagerbestand"].Style.BackColor = Color.Yellow;
                            row.Cells["HauptLagerbestand"].Style.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        row.Cells["HauptLagerbestand"].Style.BackColor = Color.White;
                        row.Cells["HauptLagerbestand"].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void frmLagerListe_Load(object sender, EventArgs e)
        {
            cbFilterbei.SelectedIndex = 0;
            cbFilterbei.DropDownStyle = ComboBoxStyle.DropDownList; // verhindert die ComboBox Einträge zu ändern.

            _LoadEinkaufDateFromDataBase();
        }

        private void btnAktualisereParfümMenge_Click(object sender, EventArgs e)
        {
            _LoadEinkaufDateFromDataBase();  // Nur zum Aktualisieren....
        }

        private void aktualisiereParfümMengeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int parfümNummer = (int)dgvLager.CurrentRow.Cells[0].Value;
            frmAddUpdateNeueParfümMenge frm = new frmAddUpdateNeueParfümMenge(parfümNummer, frmAddUpdateNeueParfümMenge.enMode.update);
            frm.ShowDialog();

            _LoadEinkaufDateFromDataBase();
        }

        private void entferneParfümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int parfümNummer = (int)dgvLager.CurrentRow.Cells[0].Value;

            clsEinkauf einkaufdaten = clsEinkauf.FindEinkaufDatenByParfümNummer(parfümNummer);

            bool result = (MessageBox.Show("Sind Sie sicher, Sie möchten diesen Vorgang durchführen?", "Hinweis",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);

            if (!result)
                return;

            if(result && einkaufdaten != null && einkaufdaten.Delete())
            {
                MessageBox.Show("Einkaufsdaten erfolgreich entfernt", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _LoadEinkaufDateFromDataBase();
            }
            else
                MessageBox.Show("Fehler beim Entfernen der Einkaufsdaten ist aufgetreten.", "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbFilterbei_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterbei.SelectedIndex != -1)
            {
                txtFilerwert.Clear();
                txtFilerwert.Focus();
            }
        }

        private void _Filteranwenden()
        {
            string filterspalte = cbFilterbei.SelectedItem.ToString();
            string filterwert = txtFilerwert.Text.Trim();

            lock (_lockObject)
            {
                if (!string.IsNullOrEmpty(filterwert))
                {
                    if (filterspalte == "ParfümName")
                    {
                        _bindingSource.Filter = $"{filterspalte} Like '{filterwert}%'";
                    }
                    else if (filterspalte == "ParfümNummer")
                        _bindingSource.Filter = $"{filterspalte} = {filterwert}";
                }
                else
                {
                    _bindingSource.Filter = string.Empty;
                }
            }
        }

        private void _MachDataGridViewColumnNotSortable()
        {
            foreach (DataGridViewColumn column in dgvLager.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void txtFilerwert_TextChanged(object sender, EventArgs e)
        {
            _Filteranwenden();
            _MachDataGridViewColumnNotSortable();  //change mode to Column notsortable 
            _SetzeFarben();
        }

        private void txtFilerwert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterbei.SelectedItem.ToString() == "ParfümNummer")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void seheVerkaufsDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int parfümNummer = (int)dgvLager.CurrentRow.Cells[0].Value;
            frmAddUpdateNeueParfümMenge frm = new frmAddUpdateNeueParfümMenge(parfümNummer,frmAddUpdateNeueParfümMenge.enMode.sehedetails);
            frm.ShowDialog();
        }

        private void btnErstellePdf_Click(object sender, EventArgs e)
        {
            _ErstellePdfVonParfuem();
        }
        private void _ErstellePdfVonParfuem()
        {
            // Pfad zum Desktop des aktuellen Benutzers
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "EinkaufsDaten.pdf";
            string filePath = Path.Combine(desktopPath, fileName);

            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (Document pdfDoc = new Document(PageSize.A4.Rotate())) // Querformat für bessere Übersicht
                    {
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // **Titel hinzufügen**
                       iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                       iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("Einkaufsdaten - Parfüm Lagerbestand\n\n", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(title);

                        // **Erstelle eine Tabelle mit 9 Spalten**
                        PdfPTable table = new PdfPTable(9);
                        table.WidthPercentage = 100;
                        table.SetWidths(new float[] { 12f, 15f, 15f, 15f, 22f, 18f, 25f, 17f, 15f });

                        // **Header-Zeilen stylen**
                        iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.WHITE);
                        BaseColor headerBackgroundColor = new BaseColor(50, 50, 50); // Dunkelgrau

                        string[] headers = { "ParfümNr", "ParfümName", "ParfümCode", "HauptLotNr", "HauptLagerbestand",
                                     "SekundärLotNr", "SekundärLagerbestand", "PreisKategorie", "Erstellung" };

                        foreach (string header in headers)
                        {
                            PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                            headerCell.BackgroundColor = headerBackgroundColor;
                            headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            headerCell.Padding = 5;
                            table.AddCell(headerCell);
                        }

                        // **Daten aus dem DataGridView hinzufügen**
                        iTextSharp.text.Font dataFont = FontFactory.GetFont(FontFactory.HELVETICA, 9);

                        foreach (DataGridViewRow row in dgvLager.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string[] cellValues = {
                            row.Cells["parfümnummer"]?.Value?.ToString() ?? "",
                            row.Cells["parfümName"]?.Value?.ToString() ?? "",
                            row.Cells["parfümCode"]?.Value?.ToString() ?? "",
                            row.Cells["HauptLotNr"]?.Value?.ToString() ?? "",
                            row.Cells["HauptLagerbestand"]?.Value?.ToString() ?? "",
                            row.Cells["SekundärLotNr"]?.Value?.ToString() ?? "",
                            row.Cells["SekundärLagerbestand"]?.Value?.ToString() ?? "",
                            row.Cells["preisKategorie"]?.Value?.ToString() ?? "",
                            row.Cells["erstellungsDatum"]?.Value is DateTime datum
                                        ? datum.ToString("dd.MM.yyyy")
                                            : row.Cells["erstellungsDatum"]?.Value?.ToString() ?? ""
                        };

                                foreach (string value in cellValues)
                                {
                                    PdfPCell dataCell = new PdfPCell(new Phrase(value, dataFont));
                                    dataCell.Padding = 5;
                                    dataCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    table.AddCell(dataCell);
                                }
                            }
                        }

                        // **Tabelle hinzufügen**
                        pdfDoc.Add(table);

                        pdfDoc.Close();
                    }
                }

                // Erfolgreiche Speicherung anzeigen
                MessageBox.Show($"Die Datei wurde erfolgreich auf dem Desktop gespeichert:\n{filePath}",
                                "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Fehlerbehandlung
                MessageBox.Show($"Fehler beim Speichern der Datei: {ex.Message}",
                                "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void _ErstellePdfVonParfuem()
        //{
        //    // Pfad zum Desktop des aktuellen Benutzers
        //    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        //    // Name und Pfad der PDF-Datei
        //    string fileName = "EinkaufsDaten.pdf";
        //    string filePath = Path.Combine(desktopPath, fileName);

        //    try
        //    {
        //        // PDF speichern
        //        using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
        //        {
        //            using (Document pdfDoc = new Document())
        //            {
        //                PdfWriter.GetInstance(pdfDoc, stream);
        //                pdfDoc.Open();

        //                // Erstelle eine Tabelle mit 9 Spalten (Einkaufsdaten)
        //                PdfPTable table = new PdfPTable(9);
        //                table.WidthPercentage = 150;

        //                // Füge Header zur Tabelle hinzu
        //                table.AddCell("Parfümnummer");
        //                table.AddCell("ParfümName");
        //                table.AddCell("ParfümCode");
        //                table.AddCell("HauptLotNr");
        //                table.AddCell("HauptLagerbestand");
        //                table.AddCell("SekundärLotNr");
        //                table.AddCell("SekundärLagerbestand");
        //                table.AddCell("PreisKategorie");
        //                table.AddCell("ErstellungsDatum");

        //                // Füge die Daten aus dem DataGridView hinzu (Parfümnummer und Name)
        //                foreach (DataGridViewRow row in dgvLager.Rows)
        //                {
        //                    if (!row.IsNewRow) // Leere Zeilen überspringen
        //                    {
        //                        // Überprüfen, ob die Werte in der jeweiligen Spalte vorhanden sind
        //                        var parfuemNummer = row.Cells["parfümnummer"]?.Value?.ToString();
        //                        var parfümName = row.Cells["parfümName"]?.Value.ToString();
        //                        var parfümCode = row.Cells["parfümCode"]?.Value?.ToString();
        //                        var HauptLotNr = row.Cells["HauptLotNr"]?.Value?.ToString();
        //                        var HauptLagerbestand = row.Cells["HauptLagerbestand"]?.Value?.ToString();
        //                        var SekundärLotNr = row.Cells["SekundärLotNr"]?.Value?.ToString();
        //                        var SekundärLagerbestand = row.Cells["SekundärLagerbestand"]?.Value?.ToString();
        //                        var preisKategorie = row.Cells["preisKategorie"]?.Value?.ToString();
        //                        var erstellungsDatum = row.Cells["erstellungsDatum"]?.Value?.ToString();

        //                       // Füge Parfümnummer und Parfümname zur Tabelle hinzu
        //                        table.AddCell(parfuemNummer);
        //                        table.AddCell(parfümName);
        //                        table.AddCell(parfümCode);
        //                        table.AddCell(HauptLotNr);
        //                        table.AddCell(HauptLagerbestand);
        //                        table.AddCell(SekundärLotNr);
        //                        table.AddCell(SekundärLagerbestand);
        //                        table.AddCell(preisKategorie);
        //                        table.AddCell(erstellungsDatum);

        //                    }
        //                }

        //                // Füge die Tabelle zur PDF hinzu
        //                pdfDoc.Add(table);

        //                pdfDoc.Close();
        //            }
        //        }

        //        // Erfolgreiche Speicherung anzeigen
        //        MessageBox.Show($"Die Datei wurde erfolgreich auf dem Desktop gespeichert:\n{filePath}", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Fehlerbehandlung
        //        MessageBox.Show($"Fehler beim Speichern der Datei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
