using JaggedArrays.Interfaces;

namespace JaggedArrays.Tests.Models
{
    public class SumDescendingComparer: IComparer
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

            if (FindSum(array1) < FindSum(array2))
            {
                return 1;
            }

            return -1;
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
