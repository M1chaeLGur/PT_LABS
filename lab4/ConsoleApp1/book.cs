using System;
using System.Security.Authentication.ExtendedProtection;

namespace Book
{
    public class ClassForBooks
    {
        public string name;
        public string author;
        private int printed;
        private int pages;

        public ClassForBooks(string name, string author, int printed, int pages)
        {
            this.name = name;
            this.author = author;
            this.Printed = printed;
            this.Pages = pages;

        }
        public int Printed
        {
            get { return this.printed; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Год издания не может быть равен 0!");
                }
                else
                {
                    this.printed = value;
                }
            }
        }
         public int Pages
        {
            get { return this.pages; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Количество страниц не может быть равно 0!");
                }
                else
                {
                    this.pages = value;
                }
            }
        }
        
        public void PrintBookInfo()
        {
            Console.WriteLine($"КНИГА: ");
            Console.WriteLine($"НАЗВАНИЕ: {name} ");
            Console.WriteLine($"АВТОР: {author}");
            Console.WriteLine($"ГОД ИЗДАНИЯ: {printed}");
            Console.WriteLine($"КОЛИЧЕСТВО СТРАНИЦ: {pages}");
            Console.WriteLine(" ");
        }
        public bool IsAntique()
        {
            return 2025 - printed > 50;
        }

    }

}