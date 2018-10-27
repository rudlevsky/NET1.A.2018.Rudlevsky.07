using JaggedArrays.Interfaces;

namespace JaggedArrays.Models
{
    public class MinElemAscendingComparer : ICompare
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

            if (FindMin(array1) > FindMin(array2))
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
