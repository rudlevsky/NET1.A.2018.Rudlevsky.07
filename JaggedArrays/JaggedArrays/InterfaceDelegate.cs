using JaggedArrays.Interfaces;

namespace JaggedArrays
{
    /// <summary>
    /// Contains method for calling method with delegate parameter.
    /// </summary>
    public static class InterfaceDelegate
    {
        /// <summary>
        /// Checks exception cases and sorts array.
        /// </summary>
        /// <param name="array">Array for sorting.</param>
        /// <param name="comparer">Sort comparer.</param>
        public static void Sort(int[][] array, IComparer comparer) =>
            JaggedSorter.Sorter(array, comparer.ToCompare);
    }
}
