using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSolution
{
 class Syntax
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");
           // Console.ReadLine();
            //type of variables a 

            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = false;
            string myText = "hello";
            //const meaning fixy
            const int mySalary = 1000;
            string name = "John";
            Console.WriteLine("hello " + name);
            //convert Type
            int myInt = 10;
            double myDouble = 12.56;
            bool mybol = true;
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(mybol));
            //Math Function
            Math.Min(3, 2);
            Math.Max(3, 2);
            Math.Sqrt(3);
            Math.Abs(-3.2);
            Math.Round(2.3);

            //to upper to lower
            string txt = "hello world";
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToUpper());


            //concat functons

            string firstName = "John";
            string lastName = "Doe";
            string names=string.Concat(firstName, lastName);
            Console.WriteLine(names);

            //interpolation
            string redName = "jOhn";
            string blueName = "Doe";
            string fullyNmae = $"My full name is : {redName} {blueName}";
            Console.WriteLine(fullyNmae);
            //Access string 
            string myString = "hulla";
            Console.WriteLine(myString[3]);
            Console.WriteLine(myString.IndexOf("e"));

            //short hand If else

            int time = 20;
            string res = (time < 18) ? "good dat." : "good evenening ";
            Console.WriteLine(res);

            //switch statement
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2: Console.WriteLine("Tuesday");
                    break;
                case 3: Console.WriteLine("Wednesday");
                    break;
                case 4: Console.WriteLine("Thursday");
                    break;

            }
            string[] cars = { "Volvo", "BMw", "Ford", "Maxda" };
            foreach (string cara in cars)
            {
                Console.WriteLine(cara);
            }
        }


        
       
    }
}
