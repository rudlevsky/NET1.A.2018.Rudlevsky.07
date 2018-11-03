using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaggedArrays.Interfaces;

namespace JaggedArrays
{
    /// <summary>
    /// Contains method for sorting arrays.
    /// </summary>
    /// <param name="array1">First array for sorting.</param>
    /// <param name="array2">First array for sorting.</param>
    /// <returns>Sorted array.</returns>
    public delegate int TransformerSecond(int[] array1, int[] array2);

    /// <summary>
    /// Class contains method for sorting jagged arrays.
    /// </summary>
    public static class JaggedSorterSecond
    {
        /// <summary>
        /// Checks exception cases and sorts array.
        /// </summary>
        /// <param name="array">Array for sorting.</param>
        /// <param name="comparer">Sort comparer.</param>
        public static void Sort(int[][] array, IComparer comparer) =>
            Sort(array, comparer, comparer.ToCompare);

        /// <summary>
        /// Checks exception cases and sorts array.
        /// </summary>
        /// <param name="array">Array for sorting.</param>
        /// <param name="comparer">Sort comparer.</param>
        /// <param name="transformer">Method which implements comparing.</param>
        public static void Sort(int[][] array, IComparer comparer, TransformerSecond transformer)
        {
            CheckExceptCases(array, comparer);

            Sorter(array, transformer);
        }

        /// <summary>
        /// Sorts user's array.
        /// </summary>
        /// <param name="array">Array for sorting.</param>
        /// <param name="transformer">Method which implements comparing.</param>
        private static void Sorter(int[][] array, TransformerSecond transformer)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (transformer(array[i], array[j]) > 0)
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
