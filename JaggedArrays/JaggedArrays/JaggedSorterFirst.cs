using System;
using JaggedArrays.Interfaces;

namespace JaggedArrays
{
    /// <summary>
    /// Contains method for sorting arrays.
    /// </summary>
    /// <param name="array">Array for sorting.</param>
    /// <param name="comparer">Sort comparer.</param>
    public delegate void TransformerFirst(int[][] array, IComparer comparer);

    /// <summary>
    /// Class contains method for sorting jagged arrays.
    /// </summary>
    public static class JaggedSorterFirst
    {
        /// <summary>
        /// Checks exception cases and sorts array.
        /// </summary>
        /// <param name="array">Array for sorting.</param>
        /// <param name="comparer">Sort comparer.</param>
        public static void Sort(int[][] array, IComparer comparer)
        {
            CheckExceptCases(array, comparer);

            Sorter(array, comparer);
        }

        /// <summary>
        /// Checks exception cases and sorts array.
        /// </summary>
        /// <param name="array">Array for sorting.</param>
        /// <param name="comparer">Sort comparer.</param>
        /// <param name="transformer">Method which implements comparing.</param>
        public static void Sort(int[][] array, IComparer comparer, TransformerFirst transformer)
        {
            CheckExceptCases(array, comparer);

            transformer(array, comparer);
        }

        /// <summary>
        /// Sorts user's array.
        /// </summary>
        /// <param name="array">Array for sorting.</param>
        /// <param name="comparer">Sort comparer.</param>
        private static void Sorter(int[][] array, IComparer comparer)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer.ToCompare(array[i], array[j]) > 0)
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        private static void Swap(ref int[] array1, ref int[] array2)
        {
            int[] temp = array1;
            array1 = array2;
            array2 = temp;
        }

        private static void CheckExceptCases(int[][] array, IComparer comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer) + " can't be equal to null.");
            }

            if (array == null)
            {
                throw new ArgumentNullException(nameof(array) + " can't be equal to null.");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException(nameof(array) + " length can't be equal to 0.");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null && array[i].Length == 0)
                {
                    throw new ArgumentException(nameof(array) + " member length can't be equal to 0.");
                }
            }
        }
    }  
}
