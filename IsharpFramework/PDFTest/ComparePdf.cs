using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsharpFramework.PDFTest
{
    public class ComparePdf
    {
        public static bool CompareTwoFile(string file1,string file2)
        {
            if (!File.Exists(file2))
                return false;

            int i;
            string f1=File.ReadAllText(file1);
            string f2=File.ReadAllText(file2); 

            if (f1.Length!=f2.Length) 
                return false;

            return f1 == f2;
        }
    }
}
