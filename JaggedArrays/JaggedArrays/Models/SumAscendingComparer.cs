using JaggedArrays.Interfaces;

namespace JaggedArrays.Models
{
    public class SumAscendingComparer : ICompare
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

            if (FindSum(array1) > FindSum(array2))
            {
                return true;
            }

            return false;
        }

        private int FindSum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
