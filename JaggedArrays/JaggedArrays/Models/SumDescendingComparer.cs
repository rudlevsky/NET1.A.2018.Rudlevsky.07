using JaggedArrays.Interfaces;

namespace JaggedArrays.Models
{
    public class SumDescendingComparer: ICompare
    {
        public bool ToCompare(int[] array1, int[] array2)
        {
            if (array1 == null)
            {
                return true;
            }

            if (array2 == null)
            {
                return false;
            }

            if (FindSum(array1) < FindSum(array2))
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
