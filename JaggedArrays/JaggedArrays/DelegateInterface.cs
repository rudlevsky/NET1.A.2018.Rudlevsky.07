using JaggedArrays.Interfaces;

namespace JaggedArrays
{
    /// <summary>
    /// Contains method for calling method with interface parameter.
    /// </summary>
    public static class DelegateInterface
    {
        /// <summary>
        /// Sorts array.
        /// </summary>
        /// <param name="array">Array for sorting.</param>
        /// <param name="comparer">Sort comparer.</param>
        /// <param name="transformer">Method which implements comparing.</param>
        public static void Sort(int[][] array, IComparer comparer, TransformerInterface transformer) => 
            transformer(array, comparer);
    }
}
