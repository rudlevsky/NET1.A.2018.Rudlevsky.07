using JaggedArrays.Interfaces;

namespace JaggedArrays.Tests.Models
{
    public class MaxElemDescendingComparer: IComparer
    {
        public int ToCompare(int[] array1, int[] array2)
        {
            if (array1 == null)
            {
                return 1;
            }

            if (array2 == null)
            {
                return -1;
            }

            if (FindMax(array1) < FindMax(array2))
            {
                return 1;
            }

            return -1;
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

