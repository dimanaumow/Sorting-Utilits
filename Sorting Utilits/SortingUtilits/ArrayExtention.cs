using System;

namespace SortingUtilits
{
    /// <summary>
    /// Provide method for sorting array.
    /// </summary>
    public static class ArrayExtention
    {
        /// <summary>
        /// Sort array using Bubble Sort O(n^2) time complexity, O(1) memory.
        /// </summary>
        /// <param name="array">Given array.</param>
        /// <param name="comparer">Rule for comparation.</param>
        public static void BubbleSort(int[] array, IComparer comparer)
        {
            if (array is null)
            {
                throw new ArgumentNullException($"{nameof(array)} cannot be null.");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException($"{nameof(array)} length must be more than 0.");
            }

            if (comparer is null)
            {
                throw new ArgumentNullException($"{nameof(comparer)} cannot be null.");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (comparer.Compare(array[j], array[j + 1]) > 0)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Sort array using BubbleSort and defolt comparation elements.
        /// </summary>
        /// <param name="array">Given array.</param>
        public static void BubbleSort(int[] array)
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
                    if (array[j] - array[j + 1] > 0)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Sort array using MergeSort.
        /// </summary>
        /// <param name="array">Given array.</param>
        /// <param name="comparer">Rule for comparation.</param>
        public static void MergeSort(int[] array, IComparer comparer)
        {
            if (array is null)
            {
                throw new ArgumentNullException($"{nameof(array)} can not be null!");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException($"{nameof(array)} length must be more than 0");
            }

            if (comparer is null)
            {
                throw new ArgumentNullException($"{nameof(comparer)} cannot be null.");
            }

            MergeSort(array, 0, array.Length - 1, comparer);
        }

        /// <summary>
        /// Sorting array using MergeSort and defolt comparation.
        /// </summary>
        /// <param name="array">Given array.</param>
        public static void MergeSort(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException($"{nameof(array)} can not be null!");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException($"{nameof(array)} length must be more than 0.");
            }

            MergeSort(array, 0, array.Length - 1);
        }

        private static void MergeSort(int[] array, int low, int high, IComparer comparer)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(array, low, middle, comparer);
                MergeSort(array, middle + 1, high, comparer);
                Merge(array, low, middle, high, comparer);
            }
        }

        private static void Merge(int[] input, int low, int middle, int high, IComparer comparer)
        {
            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }

                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }
        }

        private static void MergeSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(array, low, middle);
                MergeSort(array, middle + 1, high);
                Merge(array, low, middle, high);
            }
        }

        private static void Merge(int[] input, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }

                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
