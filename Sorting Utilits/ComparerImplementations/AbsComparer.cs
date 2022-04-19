using System;
using SortingUtilits;

namespace ComparerImplementations
{
    public class AbsComparer : IComparer
    {
        public int Compare(int left, int right)
            => Math.Abs(left) - Math.Abs(right);
    }
}
