using System;
using System.Collections.Generic;
using System.Text;
using Aspose.Pdf;
using Aspose.Words;

namespace PDFConverter.Demo
{

    public class PDFConverter {
        private string source;
        private string destination;
        private Boolean watermark;

        public PDFConverter(string quelle, string ziel, Boolean stempel)
        {
            source = quelle;
            destination = ziel;
            watermark = stempel;

            /*
             Zuerst wird geprüft, ob es sich um eine docx oder jpg Datei handelt,
             da hierfür entweder Aspose.Words oder Aspose.Pdf benutzt werden muss.
             Das konvertieren geschieht dann in einer der beiden Funktionen.
            */
            if (source.Contains(".jpg"))
            {
                ConvertFromJpg();
            }
            else
            {
                ConvertFromDocx();
            }
        }
            
        
       
    

            private void ConvertFromDocx()
            {
                //Neues Dokument erstellen
                Aspose.Words.Document doc = new Aspose.Words.Document(source);

                //Bei Aspose.Words kann man mit nur einem Befehl automatisch ein ausgerichtetes Wasserzeichen auf das Dokument schreiben.
                if (watermark == true)
                {
                    doc.Watermark.SetText("Genehmigt!");
                }
                doc.Save(destination + ".pdf");
            }

            private void ConvertFromJpg()
            {
                //Neues PDF Dokument erstellen
                Aspose.Pdf.Document doc = new Aspose.Pdf.Document();


                //Leere Seite im leeren Dokument hinzufügen
                Page page = doc.Pages.Add();
                Aspose.Pdf.Image image = new Aspose.Pdf.Image();
                image.File = (source);

                //Image zur Page hinzufügen
                page.Paragraphs.Add(image);

                // Prüfen, ob dem Dokument ein Wasserzeichen hinzugefügt werden soll.

                if (watermark == true)
                {
                    // Es wird ein WatermarkAnnotation namens water erstellt und mittig auf dem Dokument plaziert.
                    
                    Aspose.Pdf.Annotations.WatermarkAnnotation water = new Aspose.Pdf.Annotations.WatermarkAnnotation(page, new Aspose.Pdf.Rectangle(100, 500, 1000, 1000));
                    
                    page.Annotations.Add(water);

                    //Es wird ein TextElement erstellt, schwarze Schrift, Schriftart: Arial, 70 Fontsize.
                    Aspose.Pdf.Text.TextState text = new Aspose.Pdf.Text.TextState();

                    text.ForegroundColor = Aspose.Pdf.Color.Black;
                    text.Font = Aspose.Pdf.Text.FontRepository.FindFont("Arial");
                    text.FontSize = 70;

                    // Das Wasserzeichen bekommt 0.8 Opacity und der Text wird mit dem gewünschten Inhalt hinzugefügt.
                    water.Opacity = 0.8;
                    water.SetTextAndState(new string[] { "Genehmigt!" }, text);

                }

                //PDF mit dem beim Aufruf gewünschten Namen abspeichern.
                doc.Save(destination + ".pdf");
        }

        
    } 

 }         