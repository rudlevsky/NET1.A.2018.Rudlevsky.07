using System.Linq;
using JaggedArrays.Interfaces;

namespace JaggedArrays.Models
{
    public class MaxElemComparer : ICompare
    {
        public bool ToCompare(int[] array1, int[] array2, bool isMaxRange)
        {
            if (isMaxRange && (array1.Max() > array2.Max()))
            {
                return true;
            }

            if (!isMaxRange && (array1.Max() < array2.Max()))
            {
                return true;
            }

            return false;
        }
    }
}
