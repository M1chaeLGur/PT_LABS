using System;

namespace ConsoleApp2
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите блок задач для выполнения:");
            Console.WriteLine("1 - Применение и операторы ");
            Console.WriteLine("2 - Условные операторы (switch, if-else)");
            Console.WriteLine("3 - Циклы while, for, do while");
            Console.WriteLine("4 - Массивы");
            Console.WriteLine("5 - Функции и методы");
            Console.WriteLine("0 - Выход из программы");
            Console.WriteLine(" ");
            Console.WriteLine("Введите номер блока: ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            switch (number)
            {
                case 1:
                    Console.WriteLine("Блок 1: Переменные и операторы: ");
                    Console.WriteLine("Выберите номер задачи: ");
                    string task = Console.ReadLine();
                    int nt = int.Parse(task);

                    switch (nt)
                    {
                        case 1:
                            Console.WriteLine("Конвертация температуры: пользователь вводит температуру в градусах Цельсия, программа переводит в Фаренгейты ");
                            Console.WriteLine("Введите температуру в градусах Цельсия: ");
                            string t = Console.ReadLine();
                            float temp = float.Parse(t);
                            float f = temp * 9 / 5 + 32;
                            Console.WriteLine($"Температура в градусах по Фаренгейту: {f}");
                            break;

                        case 3:
                            Console.WriteLine("Введите сумму в рублях: ");
                            string sum = Console.ReadLine();
                            double tranc = double.Parse(sum);
                            double doll = tranc / 3.38;
                            Console.WriteLine($"Сумма в долларах: {doll}");
                            break;
                        case 5:
                            Console.WriteLine("Введите три числа: ");
                            string num1 = Console.ReadLine();
                            double n1 = double.Parse(num1);
                            string num2 = Console.ReadLine();
                            double n2 = double.Parse(num1);
                            string num3 = Console.ReadLine();
                            double n3 = double.Parse(num1);
                            double average = (n1 + n2 + n3) / 3;
                            Console.WriteLine($"Среднее арифметическое: {average}");
                            break;

                    }
                    break;

                case 2:
                    Console.WriteLine("Блок 2: Условные операторы if-else, switch: ");
                    Console.WriteLine("Выберите номер задачи: ");
                    string tasks = Console.ReadLine();
                    int numt = int.Parse(tasks);

                    switch (numt)
                    {
                        case 1:
                            Console.WriteLine("Введите номер месяца: ");
                            int month = int.Parse(Console.ReadLine());

                            string season;


                            if (month == 12 || month == 1 || month == 2)
                            {
                                season = "Зима";
                            }
                            else if (month == 3 || month == 4 || month == 5)
                            {
                                season = "Весна";
                            }
                            else if (month == 6 || month == 7 || month == 8)
                            {
                                season = "Лето";
                            }
                            else if (month == 9 || month == 10 || month == 11)
                            {
                                season = "Осень";
                            }
                            else
                            {
                                season = "Неверный номер месяца!";
                            }

                            Console.WriteLine($"Месяц {month} - это {season}");
                            break;

                        case 3:

                            Console.WriteLine("Введите координаты (х,у): ");
                            float y = float.Parse(Console.ReadLine());
                            float x = float.Parse(Console.ReadLine());


                            if (x > 0 && y > 0)
                            {
                                Console.WriteLine("это первая четверть ");

                            }

                            else if (x < 0 && y > 0)
                            {
                                Console.WriteLine("это вторая четверть ");

                            }
                            else if (x < 0 && y < 0)
                            {
                                Console.WriteLine("это третья четверть ");

                            }
                            else if (x > 0 && y < 0)
                            {
                                Console.WriteLine("это четвертая четверть ");

                            }
                            else if (x == 0)
                            {
                                Console.WriteLine("точка лежит на границе ");

                            }

                            else if (y == 0)
                            {
                                Console.WriteLine("точка лежит на границе ");

                            }

                            break;

                        case 5:
                            Console.WriteLine("Введите координаты время: ");
                            float time = float.Parse(Console.ReadLine());


                            if (time > 0 && time < 4)
                            {
                                Console.WriteLine("это ночь ");

                            }

                            else if (time < 12 && time > 3)
                            {
                                Console.WriteLine("это утро ");

                            }
                            else if (time < 17 && time > 11)
                            {
                                Console.WriteLine("это день ");

                            }
                            else if (time > 16 && time < 23)
                            {
                                Console.WriteLine("это вечер ");

                            }
                            else if (time == 23)
                            {
                                Console.WriteLine("это ночь ");

                            }

                            else if (time > 23)
                            {
                                Console.WriteLine("Неверно введено время ");

                            }

                            break;






                    }



                    break;

                case 3:
                    Console.WriteLine("Блок 3: Циклы while do-while: ");
                    Console.WriteLine("Выберите номер задачи: ");
                    string tasks3 = Console.ReadLine();
                    int numt3 = int.Parse(tasks3);

                    switch (numt3)
                    {
                        case 1:
                            Console.WriteLine("Введите число: ");
                            int min = 9;
                            int max = 0;
                            int chis = int.Parse(Console.ReadLine());

                            while (chis > 0)
                            {
                                int cur = chis % 10;

                                if (cur > max)
                                {
                                    max = cur;
                                }
                                if (cur < min)
                                {
                                    min = cur;
                                }


                                chis = chis / 10;
                            }

                            Console.WriteLine($"Max digit = {max}, Min digit = {min}");


                            break;

                        case 3:
                            Console.WriteLine("введите какое количество чисел Фибоначчи вывести");
                            int count = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Первые {count} чисел Фибоначчи:");

                            int a = 0;
                            int b = 1;

                            for (int i = 0; i < count; i++)
                            {
                                Console.Write(a + " ");
                                int next = a + b;
                                a = b;
                                b = next;
                            }


                            break;

                        case 5:
                            Console.WriteLine("введите  количество чисел для рассчета среднего арифметического ");
                            int n = int.Parse(Console.ReadLine());
                            double summa = 0;

                            for (int i = 1; i <= n; i++)
                            {
                                Console.WriteLine($"введите число {i}: ");
                                double nomer = double.Parse(Console.ReadLine());
                                summa += nomer;

                            }
                            double av = summa / n;

                            Console.WriteLine($" Среднее арифметическое: {av}");
                            break;
                    }
                    break;

                case 4:
                    Console.WriteLine("Блок 4: массивы: ");
                    Console.WriteLine("Выберите номер задачи: ");
                    string tasks4 = Console.ReadLine();
                    int numt4 = int.Parse(tasks4);

                    switch (numt4)
                    {
                        case 1:
                            Random random = new Random();

                            Console.WriteLine("Введите параметры массива n,m");
                            int n = int.Parse(Console.ReadLine());
                            int m = int.Parse(Console.ReadLine());


                            int[,] matrix = new int[n, m];

                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < m; j++)
                                {
                                    matrix[i, j] = random.Next(1, 101);
                                }

                            }

                            Console.WriteLine("Массив n на m со случайными числами: ");

                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < m; j++)
                                {
                                    Console.Write($"{matrix[i, j],3}");
                                }
                                Console.WriteLine();

                            }

                            Console.WriteLine("/nСуммы по строкам:");
                            for (int i = 0; i < n; i++)
                            {
                                int OneMoreSum = 0;
                                for (int j = 0; j < m; j++)
                                {
                                    OneMoreSum += matrix[i, j];
                                }

                                Console.WriteLine($"строка {i}: {OneMoreSum}");

                            }
                            Console.WriteLine("/nСуммы по столбикам:");
                            for (int j = 0; j < m; j++)
                            {
                                int OneMoreSum = 0;
                                for (int i = 0; i < n; i++)
                                {
                                    OneMoreSum += matrix[i, j];
                                }

                                Console.WriteLine($"Столбик {j}: {OneMoreSum}");

                            }


                            break;

                        case 3:
                            Random random1 = new Random();
                            Console.WriteLine(" Введите количество элементов в массиве: ");

                            int amount = int.Parse(Console.ReadLine());

                            int[] array = new int[amount];

                            for (int i = 0; i < amount; i++)
                            {


                                array[i] = random1.Next(1, 101);


                            }

                            for (int i = 0; i < amount; i++)
                            {

                                Console.Write($"{array[i],3}");

                                Console.WriteLine();

                            }

                            for (int i = array.Length - 1; i >= 0; i--)
                            {
                                Console.Write(array[i] + " ");
                            }
                            break;

                        case 5:
                            Random random5 = new Random();
                            Console.WriteLine(" Введите количество элементов в массиве: ");

                            int amount5 = int.Parse(Console.ReadLine());

                            double[] array5 = new double[amount5];

                            for (int i = 0; i < amount5; i++)
                            {


                                array5[i] = random5.Next(-101, 101);


                            }


                            for (int i = 0; i < amount5; i++)
                            {


                                Console.Write($" {array5[i],3} ");



                            }

                            Console.WriteLine(" ");

                            int pros = 0;
                            int corns = 0;

                            foreach (double el in array5)
                            {

                                if (el < 0)
                                {
                                    corns++;
                                }
                                if (el > 0)
                                    pros++;
                                if (el == 0)
                                    Console.WriteLine(" элемент равен 0");
                            }

                            int[] prosNumbers = new int[pros];
                            int[] cornsNumbers = new int[corns];

                            // Заполняем массивы
                            int prosIndex = 0;
                            int cornsIndex = 0;

                            foreach (int el in array5)
                            {
                                if (el < 0)
                                {
                                    cornsNumbers[cornsIndex] = el;
                                    cornsIndex++;
                                }
                                if (el > 0)
                                {
                                    prosNumbers[prosIndex] = el;
                                    prosIndex++;
                                }
                                if (el == 0)
                                    Console.WriteLine(" элемент равен 0");
                            }


                            Console.WriteLine("Положительные числа: ");
                            foreach (int order in prosNumbers)
                                Console.WriteLine(order + " ");

                            Console.WriteLine("отридцательные числа: ");
                            foreach (int order in cornsNumbers)
                                Console.WriteLine(order + " ");
                            break;
                    }



                    break;

                case 5:
                Console.WriteLine("Блок 5: Функции: ");
                    Console.WriteLine("Выберите номер задачи: ");
                    string tasks5 = Console.ReadLine();
                    int numt5 = int.Parse(tasks5);

                    switch (numt5)
                    {
                        case 1:
                        static long Factorial (int  numb)
                            {
                                if (numb == 0 || numb == 1)
                                    return 1;

                            return numb * Factorial(numb - 1);

                         }

                         Console.Write(" Введите число: ");
                         int f = int.Parse(Console.ReadLine());

                         long factorial = Factorial(f);
                        Console.WriteLine($"{f}! = {factorial}");

                            break;

                        case 3:
                        static long Sum()
                            {
                                Random random53 = new Random();
                                

                                int numb3 = int.Parse(Console.ReadLine());

                                int[] array = new int[numb3];

                                for (int i = 0; i < numb3; i++)
                                {


                                    array[i] = random53.Next(1, 101);


                                }
                                for (int i = 0; i < numb3; i++)
                                {

                                    Console.Write($"{array[i],3}");

                                    Console.WriteLine();

                                }

                                int summaryofarr = 0;

                                for (int i = 0; i < numb3; i++)
                                {
                                    summaryofarr = summaryofarr + array[i];
                                }

                                return summaryofarr;
                        }
                       
                                Console.WriteLine(" Введите количество элементов в массиве: ");
                            long sui = Sum();
                            Console.WriteLine($"Сумма элементов массива: {sui}");
                            break;

                        case 5:
                        

                            static void Divide(int dividend, int divisor, out int quotient, out int remainder)
                            {
                                 // Вычисляем частное (целая часть от деления)
                                quotient = dividend / divisor;
        
                                // Вычисляем остаток от деления
                            remainder = dividend % divisor;
                            }

                            Console.Write("Введите делимое: ");
                            int dividend = int.Parse(Console.ReadLine());
                            Console.Write("Введите делитель: ");
                            int divisor = int.Parse(Console.ReadLine());

                            int quotient;
                            int remainder;

                            Divide(dividend, divisor, out quotient, out remainder);
        
        
                            Console.WriteLine($"\nРезультат деления:");
                            Console.WriteLine($"{dividend} / {divisor} = {quotient}");
                            Console.WriteLine($"{dividend} % {divisor} = {remainder}");
                            Console.WriteLine($"Проверка: {divisor} × {quotient} + {remainder} = {divisor * quotient + remainder}");

                            break;

                        case 7:
                         Random random1 = new Random();
                            Console.WriteLine(" Введите количество элементов в массиве: ");

                            int amount = int.Parse(Console.ReadLine());

                            int[] array = new int[amount];

                            for (int i = 0; i < amount; i++)
                            {


                                array[i] = random1.Next(1, 101);


                            }

                            for (int i = 0; i < amount; i++)
                            {

                                Console.Write($"{array[i],3}");

                                Console.WriteLine();

                            }

                            int evenCount = 0, oddCount = 0;
        
                            foreach (int numb4 in array)
                            {
                                if (numb4 % 2 == 0)
                                    evenCount++;
                                else oddCount++;
                                }
        
                            int[] evenNumbers = new int[evenCount];


                            int evenIndex = 0;
        
                            foreach (int numb4 in array)
                            {
                            if (numb4 % 2 == 0)
                             {
                                evenNumbers[evenIndex] = number;
                                evenIndex++;
                            }
                            }



                            break;       



                    }

                    break;



            }



        }
    }
}