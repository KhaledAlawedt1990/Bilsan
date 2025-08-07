using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.Activation;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Busnisse_Layer;
using Windows.ApplicationModel.VoiceCommands;
using clsHilfsMethoden;
using System.Reflection;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using Windows.UI.Xaml.Media;

namespace Parfüm2025
{
    public partial class frmDruckvorschau : Form
    {
        int ZeileHinzugefügt = 0;
        List<clsRechnungsdetails> _verkaufsdatenListe;
        clsKunde _kudedaten;
        int _belegID;
        public frmDruckvorschau(int belegID,List<clsRechnungsdetails> verkaufsdatenListe, clsKunde kudedaten)
        {
            InitializeComponent();

            _verkaufsdatenListe = verkaufsdatenListe;

            lblDatum.Text = DateTime.Now.ToString();
            _kudedaten = kudedaten;
            _belegID = belegID;
        }
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
         
        }

        private void _SaveToPdf()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string kundenname = _kudedaten.Vollname;
            string rechnungsDatum = clsDatumFormat.DateToShort(DateTime.Now.Date);
            string fileName = kundenname + rechnungsDatum + ".pdf";
            string filePath = Path.Combine(desktopPath, fileName);

            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document pdfDoc = new Document(PageSize.A4, 50, 50, 50, 50);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // **Firmendaten oben rechts**
                    _AddCompanyInfo(pdfDoc);

                    _AddLargeTextWithBeautifulFont(pdfDoc, writer);
                    // Kundendaten
                    _AddCustomerInfo(pdfDoc, writer);

                    PdfPTable table = new PdfPTable(5);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 20f, 20f, 15f, 20f, 25f });

                    // Kopfzeile definieren
                    AddTableHeader(table);

                    float pageHeight = pdfDoc.PageSize.Height - pdfDoc.TopMargin - pdfDoc.BottomMargin; // Verfügbare Höhe
                    float currentHeight = 0; // Aktuelle Höhe der Tabelle
                    float rowHeight = 20f; // Durchschnittliche Höhe einer Zeile
                    float footerHeight = 10f; // Höhe für die Fußzeile, falls nötig
                    foreach (var item in _verkaufsdatenListe)
                    {
                        // Berechne, ob eine neue Zeile Platz hat
                        if (currentHeight + rowHeight + footerHeight > pageHeight)
                        {
                            pdfDoc.Add(table); // Bisherige Tabelle hinzufügen
                            pdfDoc.NewPage();  // Neue Seite erstellen

                            // Neue Tabelle mit Kopfzeile auf neuer Seite
                            table = new PdfPTable(5);
                            table.WidthPercentage = 100;
                            table.SetWidths(new float[] { 20f, 20f, 15f, 20f, 25f });
                            AddTableHeader(table);

                            currentHeight = 0; // Höhe zurücksetzen
                        }

                        // Datenzeilen hinzufügen
                        table.AddCell(new PdfPCell(new Phrase(item.parfümNummer.ToString(), FontFactory.GetFont("Arial", 10))));
                        table.AddCell(new PdfPCell(new Phrase(item.verkaufsMenge.ToString() + " Gr", FontFactory.GetFont("Arial", 10))));
                        table.AddCell(new PdfPCell(new Phrase("19%", FontFactory.GetFont("Arial", 10))));
                        table.AddCell(new PdfPCell(new Phrase(item.normalPreis.ToString("C"), FontFactory.GetFont("Arial", 10))));
                        table.AddCell(new PdfPCell(new Phrase(item.gesamtPreis.ToString("C"), FontFactory.GetFont("Arial", 10))));

                        currentHeight += rowHeight; // Aktuelle Höhe aktualisieren
                    }


                    pdfDoc.Add(table);

                    // Summen und Steuerinformationen
                    pdfDoc.Add(new Paragraph("\n"));
                    pdfDoc.Add(new Paragraph($"Netto: {lblNetto.Text}"));
                    pdfDoc.Add(new Paragraph($"Steuer (19%): {lblSteuer.Text}"));
                    pdfDoc.Add(new Paragraph($"Brutto: {lblBrutto.Text}"));

                    pdfDoc.Close();
                }

                MessageBox.Show($"Die Datei wurde erfolgreich gespeichert:\n{filePath}", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern der Datei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void _AddCompanyInfo(Document pdfDoc)
        {
            // Definiere die Farben für die Firma
            BaseColor companyColor = new BaseColor(0, 51, 102);  // Dunkelblau
            // Schriftart definieren
            iTextSharp.text.Font font = FontFactory.GetFont("Arial", 9);
            font.Color = companyColor;
            // Firmendaten hinzufügen
            Paragraph companyInfo = new Paragraph
            {
                Alignment = Element.ALIGN_RIGHT // Rechts ausrichten
            };

            companyInfo.Add(new Chunk("Alowidat Parfümerie\n", font));
            companyInfo.Add(new Chunk("Obere Königsstr 22\n", font));
            companyInfo.Add(new Chunk("34117 Kassel\n", font));
            companyInfo.Add(new Chunk("Deutschland\n", font));
            companyInfo.Add(new Chunk("USt-ID: DE319000676\n", font));
            companyInfo.Add(new Chunk("Telefon: +491777975434\n", font));
            companyInfo.Add(new Chunk("E-Mail: info@alowidat.de\n", font));
            companyInfo.Add(new Chunk("Webseite: Www.alowidat.de\n", font));
            companyInfo.Add(new Chunk("IBAN: DE48520503530002219019\n", font));
            companyInfo.Add(new Chunk("BIC: HELADEF1KAS\n", font));
            companyInfo.Add(new Chunk("\n"));
            pdfDoc.Add(companyInfo); // Firmendaten ins PDF-Dokument einfügen
        }
        //private void AddCustomerInfo(Document pdfDoc)
        //{
        //    BaseColor customColor = new BaseColor(255, 0, 0); // Rot (RGB)
        //    BaseColor customColor2 = new BaseColor(0, 255, 0); // Grün (RGB)
        //    BaseColor customColor3 = new BaseColor(0, 0, 255); // Blau (RGB)
        //    BaseColor customColor4 = new BaseColor(128, 128, 128); // Grau (RGB)
        //                                                           // Verwende eine Standard-Schriftart (z.B. Helvetica)
        //                                                           // Schriftart definieren
        //    iTextSharp.text.Font font = FontFactory.GetFont("Arial", 12);
        //    font.Color = customColor2;
        //    // Firmendaten hinzufügen
        //    Paragraph companyInfo = new Paragraph
        //    { 
        //        Alignment = Element.ALIGN_TOP // Rechts ausrichten
        //    };

        //    companyInfo.Add(new Chunk($"Rechnung für: {_kudedaten.Vollname}\n", font));       
        //    companyInfo.Add(new Chunk($"Straße: {_kudedaten.Straße}\n", font));
        //    companyInfo.Add(new Chunk($"Stadt: {_kudedaten.Stadt}\n", font));
        //    companyInfo.Add(new Chunk($"Datum: {DateTime.Now:dd.MM.yyyy}\n", font));
        //    companyInfo.Add(new Chunk("\n"));
        //    pdfDoc.Add(companyInfo); // Firmendaten ins PDF-Dokument einfügen

        //}
        private void _AddLargeTextWithBeautifulFont(Document pdfDoc, PdfWriter writer)
        {
            try
            {
                // Benutzerspezifische Schriftart (z.B. Arial, wenn du eine andere Schriftart verwenden möchtest, musst du den Pfad zur TTF-Datei angeben)
                string fontPath = @"C:\Windows\Fonts\Arial.ttf"; // Pfad zur Schriftart-Datei (TTF)
                BaseFont customFont = BaseFont.CreateFont(fontPath, BaseFont.CP1252, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(customFont, 40); // Schriftgröße 40 für das Wort "Alowidat"

                // Holen Sie sich den PdfContentByte von PdfWriter
                PdfContentByte cb = writer.DirectContent;

                // Beginne den Text zu schreiben und setze die Schriftart und -größe
                cb.BeginText();
                cb.SetFontAndSize(customFont, 40); // Schriftgröße 40
                cb.SetTextMatrix(50f, pdfDoc.PageSize.Height - 80f); // Position des Textes (oben links)
                cb.ShowText("Alowidat"); // Text anzeigen
                cb.EndText();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Hinzufügen des Textes: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void _AddCustomerInfo(Document pdfDoc, PdfWriter writer)
        {
            BaseColor customColor = new BaseColor(255, 0, 0); // Rot (RGB)
            BaseColor customColor2 = new BaseColor(0, 255, 0); // Grün (RGB)
            BaseColor customColor3 = new BaseColor(0, 0, 255); // Blau (RGB)
            BaseColor customColor4 = new BaseColor(128, 128, 128); // Grau (RGB)
            // Verwende eine Standard-Schriftart (z.B. Helvetica)
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
           // iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12); // Setze die Schriftart und -größe
            

            // Holen Sie sich den PdfContentByte von PdfWriter
            PdfContentByte cb = writer.DirectContent;

            try
            {
                // Beginne mit dem Text, der in einer spezifischen Position auf der Seite erscheinen soll
                cb.BeginText();
                cb.SetFontAndSize(baseFont, 12); // Setze die Schriftart und -größe
                cb.SetTextMatrix(50f, pdfDoc.PageSize.Height - 140f); // Position für die Kundendaten (vom oberen Rand nach unten)
                cb.ShowText($"Rechnung für: {_kudedaten.Vollname}"); // Text: Rechnung für
                cb.EndText();

                // Weitere Kundendaten auf die gleiche Weise hinzufügen
                cb.BeginText();
                cb.SetFontAndSize(baseFont, 12);
                cb.SetTextMatrix(50f, pdfDoc.PageSize.Height - 160f); // Neue Position für die Straße
                cb.ShowText($"Straße: {_kudedaten.Straße}");
                cb.EndText();

                cb.BeginText();
                cb.SetFontAndSize(baseFont, 12);
                cb.SetTextMatrix(50f, pdfDoc.PageSize.Height - 180f); // Neue Position für die Stadt
                cb.ShowText($"Stadt: {_kudedaten.Stadt}");
                cb.EndText();

                cb.BeginText();
                cb.SetFontAndSize(baseFont, 12);
                cb.SetTextMatrix(50f, pdfDoc.PageSize.Height - 200f); // Neue Position für das Datum
                cb.ShowText($"Datum: {DateTime.Now:dd.MM.yyyy}");
                cb.EndText();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Hinzufügen der Kundendaten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void _AddCustomerInfo(Document pdfDoc)
        //{
        //    // Kundendaten nach oben verschieben
        //    iTextSharp.text.Font font = FontFactory.GetFont("Arial", 12);

        //    // Keine Leerzeilen, direkt oben einfügen
        //    pdfDoc.Add(new Paragraph($"Rechnung für: {_kudedaten.Vollname}", font));
        //    pdfDoc.Add(new Paragraph($"Straße: {_kudedaten.Straße}", font));
        //    pdfDoc.Add(new Paragraph($"Stadt: {_kudedaten.Stadt}", font));
        //    pdfDoc.Add(new Paragraph($"Datum: {DateTime.Now:dd.MM.yyyy}", font));
        //    pdfDoc.Add(new Paragraph("\n")); // Optionaler Abstand zwischen Kundendaten und den folgenden Tabellen
        //}

        // 🔹 Methode zur Wiederholung der Kopfzeile auf jeder Seite
        private void AddTableHeader(PdfPTable table)
        {
            PdfPCell headerCell;

            string[] headers = { "ParfümNummer", "Menge (Gr)", "Steuer (%)", "Normalpreis (€)", "Gesamtpreis (€)" };
            foreach (string header in headers)
            {
                headerCell = new PdfPCell(new Phrase(header, FontFactory.GetFont("Arial", 12.ToString(), Font.Bold)));
                headerCell.BackgroundColor = new BaseColor(200, 200, 200);
                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(headerCell);
            }
        }
        //private void SavePanelToPdf()
        //{
        //    // Pfad zum Desktop des aktuellen Benutzers
        //    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        //    string kundenname = _kudedaten.Vollname;
        //    string rechnungsDatum = clsDatumFormat.DateToShort(DateTime.Now.Date);
        //    // Name und Pfad der PDF-Datei
        //    string fileName = kundenname + rechnungsDatum + ".pdf";
        //    string filePath = Path.Combine(desktopPath, fileName);

        //    try
        //    {
        //        // Bitmap aus dem Panel erstellen
        //        using (Bitmap bitmap = new Bitmap(pnlHaupPanel.Width, pnlHaupPanel.Height))
        //        {
        //            pnlHaupPanel.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, pnlHaupPanel.Width, pnlHaupPanel.Height));

        //            // PDF speichern
        //            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
        //            {
        //                using (Document pdfDoc = new Document(new iTextSharp.text.Rectangle(bitmap.Width, bitmap.Height)))
        //                {
        //                    PdfWriter.GetInstance(pdfDoc, stream);
        //                    pdfDoc.Open();

        //                    // Konvertiere Bitmap zu iTextSharp-Image
        //                    iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(bitmap, System.Drawing.Imaging.ImageFormat.Png);

        //                    // Skalierung auf 15 % der Originalgröße
        //                    pdfImage.ScalePercent(90);

        //                    pdfImage.Alignment = iTextSharp.text.Image.ALIGN_CENTER;

        //                    // Füge das Bild zur PDF hinzu
        //                    pdfDoc.Add(pdfImage);

        //                    pdfDoc.Close();
        //                }
        //            }

        //            MessageBox.Show($"Die Datei wurde erfolgreich auf dem Desktop gespeichert:\n{filePath}", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Fehler beim Speichern der Datei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        public void _FülleKundedaten()
        {
            lblVollname.Text = _kudedaten.Vollname;
            lblStrasse.Text = _kudedaten.Straße;
            lblStadt.Text = _kudedaten.Stadt;
        }

        public void _FülleRechnungsdetails()
        {
            lblBelegID.Text = _belegID.ToString();
            foreach (var item in _verkaufsdatenListe)
            {
              
                dgvVerkaufsdaten.Rows.Add(
                    item.parfümNummer,
                    item.verkaufsMenge + " Gr"
                    , 19,
                    item.normalPreis,
                    item.gesamtPreis);
            }
            //AddOrUpdateSummeRow();
            UpdateSummeRow();
        }
        private void UpdateSummeRow()
        {
            float summeEinzelPreis = 0;

            // Summe aller relevanten Zeilen berechnen
            foreach (DataGridViewRow row in dgvVerkaufsdaten.Rows)
            {
                if (row.Cells["Einzelpreis"].Value != null)
                {
                    float einzelpreis= 0;
                    if (float.TryParse(row.Cells["Einzelpreis"].Value.ToString(), out einzelpreis))
                          summeEinzelPreis += einzelpreis;
                }
            }

            _BearbeiteSteuerdaten(summeEinzelPreis);
        }

        private void _BearbeiteSteuerdaten(float summeEinzelpreis)
        {
            // Bruttobetrag anzeigen
            float netto = summeEinzelpreis;
            lblNetto.Text = netto.ToString("C");

            // Steueranteil berechnen und anzeigen
           float steuer = (summeEinzelpreis * 19 / 100);
            lblSteuer.Text = steuer.ToString("C");

            float brutto = netto + steuer;
            lblBrutto.Text = brutto.ToString("C");

           // lblRechnungsbetrag.Text = gesamtEinzelPreis.ToString("C");
        }
        private void UpdateDataGridViewHeight()
        {
            int rowHeight = dgvVerkaufsdaten.RowTemplate.Height;  // Höhe einer Zeile
            int columnHeaderHeight = dgvVerkaufsdaten.ColumnHeadersHeight;  // Höhe des Headers
            int rowCount = dgvVerkaufsdaten.Rows.Count;  // Anzahl der Zeilen

            // Berechne die neue Höhe des DataGridView
            int newHeight = (rowHeight * rowCount) + columnHeaderHeight;

            int maxHeight = 400; // Max Höhe
            // Setze die neue Höhe
            dgvVerkaufsdaten.Height = Math.Min(newHeight, maxHeight);


            pnlNettoBrutto.Top= dgvVerkaufsdaten.Bottom + 1;

            pnlHaupPanel.Invalidate();
        }

 
        private void frmDruckvorschau_Load(object sender, EventArgs e)
        {
            _FülleKundedaten();
            _FülleRechnungsdetails();
            UpdateDataGridViewHeight();
        }

        private void dgvVerkaufsdaten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //UpdateSummeRow();

           // _FülleRechnungsdetails();
            ZeileHinzugefügt = 17 * dgvVerkaufsdaten.Rows.Count;
            UpdateEcke();
            UpdateDataGridViewHeight();

        }

        private void dgvVerkaufsdaten_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
           // UpdateSummeRow();

            ZeileHinzugefügt = 19 * dgvVerkaufsdaten.Rows.Count;
            UpdateEcke();
            UpdateDataGridViewHeight();

        }

        private void UpdateEcke()
        {
            pnlHaupPanel.Invalidate();
        }
        private void pnlHaupPanel_Paint(object sender, PaintEventArgs e)
        {
           // Erstelle ein Panel für die Ecke


                // Grafikobjekt für das Panel
                Graphics g = e.Graphics;

            // Berechne die Position und Größe des Panels
            int width = pnlHaupPanel.Width;  // Breite des Panels
            int height = pnlHaupPanel.Height; // Höhe des Panels      

            // Definiere die Punkte für das Dreieck in der unteren rechten Ecke
            Point[] points = new Point[]
            {
                    new Point(width, height),       // Untere rechte Ecke
                    new Point(width - 800, height),  //  Pixel nach links (unten)             
                     new Point(width, height - (480 - ZeileHinzugefügt))   // Pixel nach oben (rechts)
            };

            // Fülle das Dreieck mit der grünen Farbe
            g.FillPolygon(Brushes.YellowGreen, points);


            ZeileHinzugefügt = 0;
        }

        private void konvertiereZurPdfDateiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SaveToPdf();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _SaveToPdf();
            this.Close();
        }
    }
}
