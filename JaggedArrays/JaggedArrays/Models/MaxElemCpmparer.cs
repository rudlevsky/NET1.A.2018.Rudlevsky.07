using JaggedArrays.Interfaces;

namespace JaggedArrays.Models
{
    public class MaxElemComparer : ICompare
    {
        public bool ToCompare(int[] array1, int[] array2, bool isMaxRange)
        {
            if (array1 == null)
            {
                array1 = new int[] { 0 };
            }

            if (array2 == null)
            {
                array2 = new int[] { 0 };
            }

            if (isMaxRange && (FindMax(array1) > FindMax(array2)))
            {
                return true;
            }

            if (!isMaxRange && (FindMax(array1) < FindMax(array2)))
            {
                return true;
            }

            return false;
        }

        private int FindMax(int[] array)
        {
            int maxElem = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxElem)
                {
                    maxElem = array[i];
                }
            }

            return maxElem;
        }
    }
}
