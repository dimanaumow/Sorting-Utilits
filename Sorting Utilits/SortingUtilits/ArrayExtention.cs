using System;

namespace SortingUtilits
{
    /// <summary>
    /// Provide method for sorting array.
    /// </summary>
    public class ArrayExtention
    {
        /// <summary>
        /// Sort array using Bubble Sort O(n^2) time complexity, O(1) memory.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="comparer">Rule for comparation.</param>
        public void BubbleSort(int[] array, IComparer comparer)
        {
            if (array is null)
            {
                throw new ArgumentNullException($"{nameof(array)} cannot be null");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException($"{nameof(array)} length must be more than 0");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (comparer.Compare(array[j], array[j + 1]) > 0)
                    {
                        this.Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
