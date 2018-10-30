namespace JaggedArrays.Interfaces
{
    /// <summary>
    /// Contains method for comparing.
    /// </summary>
    public interface IComparer
    {
        /// <summary>
        /// Method compares two arrays.
        /// </summary>
        /// <param name="array1">First array for comparing.</param>
        /// <param name="array2">Second array for comparing.</param>
        /// <returns>Result of comparing two arrays.</returns>
        int ToCompare(int[] array1, int[] array2);
    }
}
