using System;

namespace OOP_Rational
{
    public class Range
    {
        private int start;
        public int Start
        {
            get { return this.start; }
            set
            {
                if (value > this.finish)
                {
                    throw new ArgumentException("Start should not be > Finish");
                }
                this.start = value;
            }
        }

        private int finish;
        public int Finish
        {
            get { return this.finish; }
            set
            {
                if (value < this.start)
                {
                    throw new ArgumentException("Finish should not be < Start");
                }
                this.finish = value;
            }
        }

        public Range(int start, int finish)
        {
            if (start > finish)
            {
                throw new ArgumentException("Start should not be > Finish");
            }

            this.start = start;
            this.finish = finish;
        }

        private bool IsIntersect(Range r1, Range r2)
        {
            return !(r1.Finish < r2.Start || r2.Finish < r1.Start);
        }

        public static Range operator +(Range r1, Range r2)
        {
            if (!r1.IsIntersect(r1, r2))
            {
                throw new InvalidOperationException("Ranges do not intersect");
            }

            int newStart = Math.Min(r1.Start, r2.Start);
            int newFinish = Math.Max(r1.Finish, r2.Finish);

            return new Range(newStart, newFinish);
        }

        public static Range operator -(Range r1, Range r2)
        {
            if (!r1.IsIntersect(r1, r2))
            {
                throw new InvalidOperationException("Ranges do not intersect");
            }

            int newStart = Math.Max(r1.Start, r2.Start);
            int newFinish = Math.Min(r1.Finish, r2.Finish);

            return new Range(newStart, newFinish);
        }

        public override string ToString()
        {
            string numbers = "";

            for (int i = Start; i <= Finish; i++)
            {
                numbers += i;

                if (i < Finish)
                {
                    numbers += ", ";
                }
            }

            return $"Range ({Start}, {Finish}), [{numbers}]";
        }

        public override bool Equals(object obj)
        {
            if (obj is Range other)
            {
                int thisLength = this.Finish - this.Start;
                int otherLength = other.Finish - other.Start;

                return thisLength == otherLength;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int length = Finish - Start;
            return HashCode.Combine(length);
        }
    }
}