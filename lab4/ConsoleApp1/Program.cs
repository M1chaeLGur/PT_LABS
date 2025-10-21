using System;
using Book;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassForBooks b1 = new ClassForBooks("Яма", "Куприн", 1957, 422);
            b1.Pages = 4;
           
            b1.PrintBookInfo();
            Console.WriteLine(b1.IsAntique());

            ClassForBooks b2 = new ClassForBooks("Фаворит","Пикуль", 1979, 965);
           
            b2.PrintBookInfo();
            Console.WriteLine(b2.IsAntique());

            ClassForBooks b3 = new ClassForBooks("451 градус по Фаренгейту", "Бредбери",2012, 451);
          
            b3.PrintBookInfo();
            Console.WriteLine(b3.IsAntique());

            ClassForBooks b4 = new ClassForBooks("451 градус по Фаренгейту", "Бредбери", 1849, 451);
            Console.WriteLine(b4.IsAntique());
        }
    }
}
