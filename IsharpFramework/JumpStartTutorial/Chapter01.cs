using IsharpFramework.PDFUtil;
using iText.Kernel.Pdf;
using iText.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsharpFramework.JumpStartTutorial
{
    public class Chapter01
    {
        public const String Dest = "../../../results/chapter01/hello_world.pdf";
        [Test]
        public void  TestPdf()
        {
            FileInfo file = new FileInfo(Dest);
            file.Directory.Create();
            new Chapter01().CreatePdf(Dest);
        }

        public virtual void CreatePdf(String dest)
        {//initialize pdfwriter
           PdfWriter writer= new PdfWriter(dest);
            //initialize pdfdocument
            PdfDocument pdfDocument=new PdfDocument(writer);
            //initiale document
            Document document = new Document(pdfDocument);
            //Add Paragrapth to the document
            document.Add(new iText.Layout.Element.Paragraph("hello world "));
            document.Close();

        }

    }
}
