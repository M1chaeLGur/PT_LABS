using System;

namespace ConsoleApp1
{
    public class QuadraticEquation
    {
        private int a;


        public QuadraticEquation(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Equation: {A}x2 + {B}x + {C} = 0");
        }

        public int A
        {
            get { return this.a; }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Value of a must be != 0");
                }
                else
                {
                    this.a = value;
                }
            }
        }

        public int B { get; set; }
        public int C { get; set; }

        public int GetRootsCount()
        {
            int D = B * B - 4 * A * C;
            if (D > 0)
            {
                return 2;
            }
            else if (D == 0)
            {
                return 1;
            }
            return 0;

        }

        public double[] GetRoots()
        {
            int D = B * B - 4 * A * C;
            if (D > 0)
            {
                double x1 = (-B + Math.Sqrt(D)) / (2 * A);
                double x2 = (-B - Math.Sqrt(D)) / (2 * A);

                return new[] { x1, x2 };
            }
            else if (D == 0)
            {
                double x1 = (double)-B / (2 * A);
                return new[] { x1 };
            }
            return Array.Empty<double>();
        }

    }
}