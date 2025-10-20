using System;
using System.Security.Authentication.ExtendedProtection;

namespace Book
{
    public class ClassForBooks
    {
        public string name;
        public string author;
        public int printed;
        public int pages;

        public ClassForBooks(string name, string author, int printed, int pages)
        {
            this.name = name;
            this.author = author;

            if (printed <= 0 || pages <= 0)
            {
                Console.WriteLine("Значения года издания и количества страниц введены неверно, проверьте данные еще раз.");
            }
            else
            {
                this.printed = printed;

                this.pages = pages;
            }
        }
        public void PrintBookInfo()
        {
            Console.WriteLine($"КНИГА: ");
            Console.WriteLine($"НАЗВАНИЕ: {name} ");
            Console.WriteLine($"АВТОР: {author}");
            Console.WriteLine($"ГОД ИЗДАНИЯ: {printed}");
            Console.WriteLine($"КОЛИЧЕСТВО СТРАНИЦ: {pages}");
        }
        public void IsAntique()
        {
            if (2025- printed > 50)
            {
                Console.WriteLine("Данная книга - антикварная");
            }
        }

    }

}