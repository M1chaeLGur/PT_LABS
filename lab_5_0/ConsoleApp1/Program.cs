using System;
using OOP_Rational;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(4, 8);

            Rational r2 = new Rational(2, -5);

            Rational r3 = new Rational(-3, -4);

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);

               Rational r4 =r1 + r2 * r3;

            Rational r5 = new Rational(0, 5);

            Rational r6 = r3 / r1;

            Console.WriteLine(r5);
          

            Rational r7 = new Rational(0, 5);
           

            Console.WriteLine(r1 > r2);
            Console.WriteLine(r1 < r3);
            Console.WriteLine(r1 == r2);
            Console.WriteLine(r5 != r6);
            Console.WriteLine(r1 >= r2);
            Console.WriteLine(r3 <= r4);

            
        }
    }
}
