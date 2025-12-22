using System;
using OOP_Rational;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            OOP_Rational.Range range1 = new OOP_Rational.Range(1, 5);
            OOP_Rational.Range range2 = new OOP_Rational.Range(3, 10);

            Console.WriteLine(range1);
            Console.WriteLine(range2);

           OOP_Rational.Range sum = range1 + range2;
            OOP_Rational.Range common = range1 - range2;


            Console.WriteLine(sum);
            Console.WriteLine(common);

            Console.WriteLine(range1.Equals(range2));
        }
    }
}
