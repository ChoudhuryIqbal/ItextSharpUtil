using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System;
using System.IO;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;


using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsharpFramework.PDFUtil
{
   public  class Program
    {
   
        public void writePDF()
        {
            string output = "C:\\Users\\iqbal\\Documents\\GitHub\\ItextSharpUtil\\IsharpFramework\\output.pdf";

            using (FileStream fs=new FileStream(output,FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                using (var writer = new PdfWriter(output))
                {
                    using (var pdf = new PdfDocument(writer))
                    {
                        using (var document = new Document(pdf))
                        {
                            //Add content to pdf
                            document.Add(new Paragraph("My first Pdf with iText").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                            document.Add(new Paragraph("Heading 1").SetFontSize(18).SetBold());
                            //add a list
                            iText.Layout.Element.List list = new iText.Layout.Element.List();
                            list.Add(new ListItem("Item 1"));
                            list.Add(new ListItem("Item 2"));
                            list.Add(new ListItem("Item 3 "));
                            document.Add(list);
                            Console.WriteLine("PDF created successfully");
                            Console.WriteLine("PDF created successfully");
                            document.Close();
                            fs.Close();
                        }
                    }
                }
            }
        }
        /*
        public void Main()
        {
            string dest = "simple.pdf";

            using (var writer=new PdfWriter(dest))
            {
                using (var pdf=new PdfDocument(writer))
                {
                    using (var document=new Document(pdf))
                    {
                        //Add content to pdf
                        document.Add(new Paragraph("My first Pdf with iText").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                        document.Add(new Paragraph("Heading 1").SetFontSize(18).SetBold());
                        //add a list
                        iText.Layout.Element.List list = new iText.Layout.Element.List();
                        list.Add(new ListItem("Item 1"));
                        list.Add(new ListItem("Item 2"));
                        list.Add(new ListItem("Item 3 "));
                        document.Add(list);
                        Console.WriteLine("PDF created successfully");

                    }
                }
            }
          
        }*/
    }
}
