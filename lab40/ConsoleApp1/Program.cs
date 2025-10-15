using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation eq1 = new QuadraticEquation(1, -4, 4);
            eq1.PrintInfo();
            Console.WriteLine(eq1.GetRootsCount());


            QuadraticEquation eq2 = new QuadraticEquation(2, 4, -5);
            eq2.PrintInfo();
            Console.WriteLine(eq2.GetRootsCount());

            QuadraticEquation eq3 = new QuadraticEquation(1, 2, 3);
            eq3.PrintInfo();
            Console.WriteLine(eq3.GetRootsCount());

            Console.WriteLine("get Roots of equation 1: ");
            foreach (double root in eq1.GetRoots())
            {
                Console.WriteLine($"Root = {root} ");
            }

            foreach (double root in eq2.GetRoots())
            {
                Console.WriteLine($"Root = {root} ");
            }

            Console.WriteLine("get Roots of equation 3: ");
            foreach (double root in eq3.GetRoots())
            {
                Console.WriteLine($"Root = {root} ");
            }

        }
    }
}
