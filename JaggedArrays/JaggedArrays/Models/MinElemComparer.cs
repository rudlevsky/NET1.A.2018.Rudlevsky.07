using JaggedArrays.Interfaces;

namespace JaggedArrays.Models
{
    public class MinElemComparer : ICompare
    {
        public bool ToCompare(int[] array1, int[] array2, bool isMaxRange)
        {
            if (isMaxRange && array1 == null)
            {
                return false;
            }

            if (isMaxRange && array2 == null)
            {
                return true;
            }

            if (!isMaxRange && array1 == null)
            {
                return true;
            }

            if (!isMaxRange && array2 == null)
            {
                return false;
            }

            if (isMaxRange && (FindMin(array1) > FindMin(array2)))
            {
                return true;
            }

            if (!isMaxRange && (FindMin(array1) < FindMin(array2)))
            {
                return true;
            }

            return false;
        }

        private int FindMin(int[] array)
        {
            int minElem = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minElem)
                {
                    minElem = array[i];
                }
            }

            return minElem;
        }
    }
}
