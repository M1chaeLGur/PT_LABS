using System;
using Book;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassForBooks b1 = new ClassForBooks("Яма", "Куприн", 1957, 422);
            /* b1.name = "Яма";
             b1.author = "Куприн";
             b1.printed = 1957;
             b1.pages = 422;*/
            b1.PrintBookInfo();
            b1.IsAntique();

            ClassForBooks b2 = new ClassForBooks("Фаворит","Пикуль", 1979, 965);
            /*b2.name = "Фаворит";
            b2.author = "Пикуль";
            b2.printed = 1979;
            b2.pages = 965;*/
            b2.PrintBookInfo();
            b2.IsAntique();

            ClassForBooks b3 = new ClassForBooks("451 градус по Фаренгейту", "Бредбери",2012, 451);
            /*b3.name = "451 градус по Фаренгейту";
            b3.author = "Бредбери";
            b3.printed = 2012;
            b3.pages = 451;*/
            b3.PrintBookInfo();
            b3.IsAntique();
        }
    }
}
