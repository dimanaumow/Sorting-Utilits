using NUnit.Framework;
using ComparerImplementations;

namespace ComparerImplemetations_Test
{
    [TestFixture]
    public class AbsComparer_Test
    {
        [TestCase(5, 2, ExpectedResult = 3)]
        [TestCase(6, 1, ExpectedResult = 5)]
        [TestCase(1, 5, ExpectedResult = -4)]
        [TestCase(5, 2, ExpectedResult = 3)]
        [TestCase(5, 5, ExpectedResult = 0)]
        [TestCase(999999999, 999999998, ExpectedResult = 1)]
        public int PositiveNumber_Test(int left, int right)
            => new AbsComparer().Compare(left, right);

        [TestCase(-5, -2, ExpectedResult = 3)]
        [TestCase(-6, -1, ExpectedResult = 5)]
        [TestCase(-1, -5, ExpectedResult = -4)]
        [TestCase(-5, -2, ExpectedResult = 3)]
        [TestCase(-5, -5, ExpectedResult = 0)]
        [TestCase(-999999999, -999999998, ExpectedResult = 1)]
        [TestCase(-100, 1, ExpectedResult = 99)]
        [TestCase(-40, 55, ExpectedResult = -15)]
        public int NegativeNumber_Test(int left, int right)
           => new AbsComparer().Compare(left, right);
    }
}