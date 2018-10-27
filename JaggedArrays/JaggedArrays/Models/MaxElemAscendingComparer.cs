using JaggedArrays.Interfaces;

namespace JaggedArrays.Models
{
    public class MaxElemAscendingComparer : ICompare
    {
        public bool ToCompare(int[] array1, int[] array2)
        {
            if (array1 == null)
            {
                return false;
            }

            if (array2 == null)
            {
                return true;
            }

            if (FindMax(array1) > FindMax(array2))
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
