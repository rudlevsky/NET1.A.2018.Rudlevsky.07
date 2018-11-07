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
        /// <param name="transformer">Method which implements comparing.</param>
        public static void Sort(int[][] array, TransformerArrays transformer)
        {
            JaggedSorter.CheckExceptCases(array);

            JaggedSorter.Sorter(array, new Adapter(transformer));
        }

        private class Adapter : IComparer
        {
            private TransformerArrays transformer;

            public Adapter(TransformerArrays transformer)
            {
                this.transformer = transformer;
            }

            public int ToCompare(int[] array1, int[] array2) => transformer(array1, array2);
        }

    }
}
