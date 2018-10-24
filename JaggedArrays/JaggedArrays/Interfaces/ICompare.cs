namespace JaggedArrays.Interfaces
{
    /// <summary>
    /// Contains method for comparing.
    /// </summary>
    public interface ICompare
    {
        /// <summary>
        /// Method compares two arrays.
        /// </summary>
        /// <param name="array1">First array for comparing.</param>
        /// <param name="array2">Second array for comparing.</param>
        /// <param name="IsMaxRange">Ascending or descending sort.</param>
        /// <returns>Result of comparing two arrays.</returns>
        bool ToCompare(int[] array1, int[] array2, bool isMaxRange);
    }
}
