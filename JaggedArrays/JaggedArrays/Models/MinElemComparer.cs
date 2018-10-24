using System.Linq;
using JaggedArrays.Interfaces;

namespace JaggedArrays.Models
{
    public class MinElemComparer : ICompare
    {
        public bool ToCompare(int[] array1, int[] array2, bool isMaxRange)
        {
            if (isMaxRange && (array1.Min() > array2.Min()))
            {
                return true;
            }

            if (!isMaxRange && (array1.Min() < array2.Min()))
            {
                return true;
            }

            return false;
        }
    }
}
