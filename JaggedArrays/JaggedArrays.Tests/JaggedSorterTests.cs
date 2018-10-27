using System;
using JaggedArrays.Models;
using NUnit.Framework;

namespace JaggedArrays.Tests
{
    [TestFixture]
    public class JaggedSorterTests
    {
        [Test]
        public void MethodSort_SumComparerAscending_ReturnSortedArray()
        {
            int[][] array =
            {
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 4, 0, 2, 6 },
                new int[] { 22, 33, 11 }
            };

            int[][] expected =
            {
                new int[] { 4, 0, 2, 6 },
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 22, 33, 11 }
            };

            JaggedSorter.Sort(array, new SumComparer(), true);

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_SumComparerDescending_ReturnSortedArray()
        {
            int[][] array =
            {
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 4, 0, 2, 6 },
                new int[] { 22, 33, 11 }
            };

            int[][] expected =
            {
               new int[] { 22, 33, 11 },
               new int[] { 5, 3, 1, 7, 9 },
               new int[] { 4, 0, 2, 6 }
            };

            JaggedSorter.Sort(array, new SumComparer(), false);

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_MaxElemComparerAscending_ReturnSortedArray()
        {
            int[][] array =
            {
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 4, 0, 2, 6 },
                new int[] { 22, 33, 11 }
            };

            int[][] expected =
            {
               new int[] { 4, 0, 2, 6 },
               new int[] { 5, 3, 1, 7, 9 },
               new int[] { 22, 33, 11 }
            };

            JaggedSorter.Sort(array, new MaxElemComparer(), true);

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_MaxElemComparerDescending_ReturnSortedArray()
        {
            int[][] array =
            {
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 4, 0, 2, 6 },
                new int[] { 22, 33, 11 }
            };

            int[][] expected =
            {
               new int[] { 22, 33, 11 },
               new int[] { 5, 3, 1, 7, 9 },
               new int[] { 4, 0, 2, 6 }
            };

            JaggedSorter.Sort(array, new MaxElemComparer(), false);

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_MinElemComparerAscending_ReturnSortedArray()
        {
            int[][] array =
            {
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 4, 0, 2, 6 },
                new int[] { 22, 33, 11 }
            };

            int[][] expected =
            {
               new int[] { 4, 0, 2, 6 },
               new int[] { 5, 3, 1, 7, 9 },
               new int[] { 22, 33, 11 }
            };

            JaggedSorter.Sort(array, new MinElemComparer(), true);

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_MinElemComparerDescending_ReturnSortedArray()
        {
            int[][] array =
            {
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 4, 0, 2, 6 },
                new int[] { 22, 33, 11 }
            };

            int[][] expected =
            {
               new int[] { 22, 33, 11 },
               new int[] { 5, 3, 1, 7, 9 },
               new int[] { 4, 0, 2, 6 }
            };

            JaggedSorter.Sort(array, new MinElemComparer(), false);

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_NullComparer_ArgumentNullExcepton()
        {
            Assert.Throws<ArgumentNullException>(() => JaggedSorter.Sort(new int[][] { new int[] { 1, 3, 5, 7, 9 } }, null, true));
        }

        [Test]
        public void MethodSort_NullArray_ArgumentNullExcepton()
        {
            Assert.Throws<ArgumentNullException>(() => JaggedSorter.Sort(null, new SumComparer(), true));
        }

        [Test]
        public void MethodSort_ArrayLengthZero_ArgumentExcepton()
        {
            Assert.Throws<ArgumentException>(() => JaggedSorter.Sort(new int[][] { new int[] {  } }, new SumComparer(), true));
        }

        [Test]
        public void MethodSort_OneOfArrayLengthZero_ArgumentExcepton()
        {
            Assert.Throws<ArgumentException>(() => JaggedSorter.Sort(new int[][] { new int[] { } }, new SumComparer(), true));
        }

        [Test]
        public void MethodSort_OneOfArrayNull_ArgumentNullExcepton()
        {
            Assert.Throws<ArgumentNullException>(() => JaggedSorter.Sort(new int[][] { null }, new SumComparer(), true));
        }
    }
}
