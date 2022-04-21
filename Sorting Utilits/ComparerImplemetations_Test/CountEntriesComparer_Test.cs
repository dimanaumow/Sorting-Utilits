using System;
using NUnit.Framework;
using ComparerImplementations;

namespace ComparerImplemetations_Test
{
    [TestFixture]
    public class CountEntriesComparer_Test
    {
        [TestCase(10, '7', 745, 77, ExpectedResult = -1)]
        [TestCase(10, '7', 7070707, 1777, ExpectedResult = 1)]
        [TestCase(10, '7', 74327, 77, ExpectedResult = 0)]
        [TestCase(10, '0', 1010, 100, ExpectedResult = 0)]
        [TestCase(10, '1', 1100, 111, ExpectedResult = -1)]
        [TestCase(2, '1', 10, 256, ExpectedResult = 1)]
        [TestCase(2, '1', 156, 400, ExpectedResult = 1)]
        [TestCase(2, '1', 120, 135, ExpectedResult = 0)]
        [TestCase(2, '0', 120, 135, ExpectedResult = -1)]
        [TestCase(16, '0', 40977, 699050, ExpectedResult = 1)]
        [TestCase(16, 'F', 255, 3871, ExpectedResult = 0)]
        public int PositiveNumber_Test(int p, char symbol, int left, int right)
        => new CountEntriesComparer(p, symbol).Compare(left, right);

        [TestCase(10, '7', -745, 77, ExpectedResult = -1)]
        [TestCase(10, '7', 7070707, -1777, ExpectedResult = 1)]
        [TestCase(10, '7', -74327, -77, ExpectedResult = 0)]
        [TestCase(10, '0', -1010, 100, ExpectedResult = 0)]
        [TestCase(10, '1', 1100, -111, ExpectedResult = -1)]
        [TestCase(2, '1', -10, -256, ExpectedResult = 1)]
        [TestCase(2, '1', 156, -400, ExpectedResult = 1)]
        [TestCase(2, '1', -120, 135, ExpectedResult = 0)]
        [TestCase(2, '0', -120, 135, ExpectedResult = -1)]
        [TestCase(16, '0', 40977, -699050, ExpectedResult = 1)]
        [TestCase(16, 'F', -255, -3871, ExpectedResult = 0)]
        public int NegativeNumber_Test(int p, char symbol, int left, int right)
        => new CountEntriesComparer(p, symbol).Compare(left, right);

        [Test]
        public void CountEntriesComparer_BaseIsNotCorrect_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => new CountEntriesComparer(-1, '1'),
                message: "Base of number system is not correct.");

        [Test]
        public void CountEntriesComparer_SymbolIsNotCorrect_ThrowArgumentExeption() =>
            Assert.Throws<ArgumentException>(() => new CountEntriesComparer(2, 'F'),
                message: "Is not valid symbol in this number system.");

    }
}