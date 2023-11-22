using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace IsharpFramework.PDFTest
{
    public class Comp
    {
        [Test]
        public void twoFileComparisionTest()
        {
            string pdf1Path = "C:\\Users\\iqbal\\Documents\\GitHub\\ItextSharpUtil\\IsharpFramework\\Mucho.pdf";
            string pdf2Path = "C:\\Users\\iqbal\\Documents\\GitHub\\ItextSharpUtil\\IsharpFramework\\Bucho.pdf";
            string text1 = ExtractTextFromPdf(pdf1Path,1);
            string text2 = ExtractTextFromPdf(pdf2Path,1);
            Console.WriteLine(text1);
            Console.WriteLine(text2);

        }
         static string ExtractTextFromPdf(string pdfPath, int pageNumber)
        {
            
            using (PdfReader pdfReader = new PdfReader(pdfPath))
            {
                using (iText.Kernel.Pdf.PdfDocument pdfDocument = new iText.Kernel.Pdf.PdfDocument(pdfReader))
                {
                    // Create a strategy for extracting text
                    LocationTextExtractionStrategy strategy = new LocationTextExtractionStrategy();

                    // Get the specified page
                    iText.Kernel.Pdf.PdfPage page = pdfDocument.GetPage(pageNumber);

                    // Process the page content
                    PdfCanvasProcessor parser = new PdfCanvasProcessor(strategy);
                    parser.ProcessPageContent(page);

                    // Extracted text from the specified page
                    return strategy.GetResultantText();
                }
            }
        }
    }
}
