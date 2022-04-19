namespace SortingUtilits
{
    /// <summary>
    /// Provide comparer for compare number in Array.
    /// </summary>
    public interface IComparer
    {
        /// <summary>
        /// Compare elements.
        /// </summary>
        /// <param name="left">first element.</param>
        /// <param name="right">second element.</param>
        /// <returns>Number 0 or 1 or -1.</returns>
        int Compare(int left, int right);
    }
}
