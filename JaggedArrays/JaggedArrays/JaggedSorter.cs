using System;
using JaggedArrays.Interfaces;

namespace JaggedArrays
{
    /// <summary>
    /// Contains method for comparing arrays.
    /// </summary>
    /// <param name="array1">First array for comparing.</param>
    /// <param name="array2">Second array for comparing.</param>
    /// <returns>Compare result.</returns>
    public delegate int TransformerArrays(int[] array1, int[] array2);

    /// <summary>
    /// Class contains method for sorting jagged arrays.
    /// </summary>
    public static class JaggedSorter
    {
        /// <summary>
        /// Sorts user's array.
        /// </summary>
        /// <param name="array">Array for sorting.</param>
        /// <param name="comparer">Sort comparer.</param>
        public static void Sorter(int[][] array, IComparer comparer)
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

        /// <summary>
        /// Sorts user's array.
        /// </summary>
        /// <param name="array">User's array.</param>
        /// <param name="transformer">Sorting method.</param>
        public static void Sorter(int[][] array, TransformerArrays transformer)
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

        public static void CheckExceptCases(int[][] array)
        {
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
