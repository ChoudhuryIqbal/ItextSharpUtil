using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSolution
{
    public abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("zzz");
        }

    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says : wee wee ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
        }
    }


    interface IBird
    {
        void animalSound();
        void run();
    }
    class Crow : IBird
    {
        public void animalSound()
        {
            Console.WriteLine("Test ");
        }

        public void run()
        {
            Console.WriteLine("Test None ");
        }
    }

    public enum Level
    {
        Low,
        Medium,
        High
    }


   class EnumTest
    {
        public void RunTest()
        {
            Console.WriteLine(Level.Medium); Console.WriteLine(Level.Low);
        }
    }

    // some exception to throw it 
    //ArithmeticException, FileNotFoundException, IndexOutOfRangeException, TimeOutException, etc:
}
