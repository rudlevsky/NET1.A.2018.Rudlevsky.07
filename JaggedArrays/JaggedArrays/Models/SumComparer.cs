using System.Linq;
using JaggedArrays.Interfaces;

namespace JaggedArrays.Models
{
    public class SumComparer : ICompare
    {
        public bool ToCompare(int[] array1, int[] array2, bool isMaxRange)
        {
            if (isMaxRange && (array1.Sum() > array2.Sum()))
            {
                return true;
            }

            if (!isMaxRange && (array1.Sum() < array2.Sum()))
            {
                return true;
            }

            return false;
        }
    }
}
