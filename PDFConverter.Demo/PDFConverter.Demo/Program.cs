using Aspose.Pdf;
using System;

namespace PDFConverter.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Beim Aufruf der Klasse muss der Pfad entsprechend angepasst werden.
             * Im Ordner "Files" ist ein Bild (A45), ein Docx Dokument (TestDOC).
             * Die in PDF konvertieren Dokumente werden ebenfalls unter Files abgespeichert und heißen dann hier "DOCxTest" und "JPGTest", jeweils mit und ohne Wasserzeichen.
             * 
             * Ich hatte das Programm, nachdem es die gewünschten Ergebnisse geliefert hat, versucht zu ordnen, indem das Konvertieren in die beiden
             * Methoden "ConvertFromDocx()" und "ConvertFromJpg()" geschieht, welche dann im Konstruktor aufgerufen werden.
             * 
             * 
             */

            
            PDFConverter PdfBildWatermark = new PDFConverter(@"...\PDFConverterFinal\Files\A45.jpg", @"...\PDFConverterFinal\Files\JPGTestWatermark", true);

            PDFConverter PdfDocWatermark = new PDFConverter(@"...\PDFConverterFinal\Files\TestDOC.docx", @"...\PDFConverterFinal\Files\DOCxTestWatermark", true);

            PDFConverter PdfBildNoWatermark = new PDFConverter(@"...\PDFConverterFinal\Files\A45.jpg", @"...\PDFConverterFinal\Files\JPGTestNoWatermark", false);

            PDFConverter PdfDocNoWatermark = new PDFConverter(@"...\PDFConverterFinal\Files\TestDOC.docx", @"...\PDFConverterFinal\Files\DOCxTestNoWatermark", false);





            /*
             * 
             * Problemstellung:
             * Unser Kunde hat ein Webportal wo sämtliche seiner Kunden
             * Dokumente hochladen. Die Dokumente werden immer in eine PDF konvertiert
             * und wenn die Dokumente genehmigt werden auch noch mit einem Stempel versehen
             * 
             * 
             * Um Die Aufgabe klein zuhalten fokussieren wir uns nur auf
             * folgende Formate .docx und .jpg. 
             * 
             * Wir benötigen also eine Klasse die als Parameter folgendes empfängt
             *      Quellpfad ( .docx oder .jpg )
             *      Zielpfad ( -> wohin soll die Datei geschrieben werden ? )
             *      Ein Parameter ob entsprechende Datei ein Stempel/Wasserzeichen auf das
             *      Dokument drucken soll. 
             *      
             *      
             *      Die Bibliothek die wir in diesem Beispiel nutzen ist
             *      https://blog.aspose.com/2020/07/26/images-to-pdf-csharp/
             *
             */


        }
    }
}
