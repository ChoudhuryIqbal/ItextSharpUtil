using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Pdfa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfReader = iText.Kernel.Pdf.PdfReader;

namespace IsharpFramework.PDFUtil
{
    public class PDFExtractor
    {

      //  [Test]
        public void printText()
        {
       string test=     ExtractTextFromPdf("D:\\july.pdf", 2);
       Console.WriteLine(test);
        }
        public static string ExtractTextFromPdf(string pdfPath, int pageNumber)
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
