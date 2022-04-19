using System;
using SortingUtilits;

namespace ComparerImplementations
{
    public class CountEntriesComparer : IComparer
    {
        private string alphabet = "0123456789ABCDEF";

        private readonly int p;

        private readonly char symbol;

        public CountEntriesComparer(int p, char symbol)
        {
            if (p < 2 || p > 16)
            {
                throw new ArgumentException($"{nameof(p)} is not a valid base of number system.");
            }

            if (p < alphabet.IndexOf(symbol))
            {
                throw new ArgumentException($"{nameof(symbol)} is not a valid symbol in this number system.");
            }
        }

        public int Compare(int left, int right)
            => CountEntries(Math.Abs(left)) - CountEntries(Math.Abs(right));

        private int CountEntries(int number)
        {
            int count = 0;
            int element = alphabet.IndexOf(symbol);

            while (number != 0)
            {
                if (number % p == element)
                {
                    count++;
                }

                number /= p;
            }

            return count;
        }
    }
}
