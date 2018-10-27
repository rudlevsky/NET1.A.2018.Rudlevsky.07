using JaggedArrays.Interfaces;

namespace JaggedArrays.Models
{
    public class MinElemComparer : ICompare
    {
        public bool ToCompare(int[] array1, int[] array2, bool isMaxRange)
        {
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
