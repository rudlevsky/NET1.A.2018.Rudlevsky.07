using JaggedArrays.Interfaces;

namespace JaggedArrays.Tests.Models
{
    public class MinElemDescendingComparer: IComparer
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

            if (FindMin(array1) < FindMin(array2))
            {
                return 1;
            }

            return -1;
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
