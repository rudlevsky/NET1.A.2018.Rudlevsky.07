using System;
using NUnit.Framework;
using JaggedArrays.Tests.Models;

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

            JaggedSorter.Sort(array, new SumAscendingComparer());

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

            JaggedSorter.Sort(array, new SumDescendingComparer());

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

            JaggedSorter.Sort(array, new MaxElemAscendingComparer());

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

            JaggedSorter.Sort(array, new MaxElemDescendingComparer());

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

            JaggedSorter.Sort(array, new MinElemAscendingComparer());

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

            JaggedSorter.Sort(array, new MinElemDescendingComparer());

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_SumComparerAscendingNull_ReturnSortedArray()
        {
            int[][] array =
            {
                null,
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 4, 0, 2, 6 },
                null,
                new int[] { 22, 33, 11 }
            };

            int[][] expected =
            {
                null,
                null,
                new int[] { 4, 0, 2, 6 },
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 22, 33, 11 }
            };

            JaggedSorter.Sort(array, new SumAscendingComparer());

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_SumComparerDescendingNull_ReturnSortedArray()
        {
            int[][] array =
            {
                null,
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 4, 0, 2, 6 },
                null,
                new int[] { 22, 33, 11 }
            };

            int[][] expected =
            {
               new int[] { 22, 33, 11 },
               new int[] { 5, 3, 1, 7, 9 },
               new int[] { 4, 0, 2, 6 },
               null,
               null
            };

            JaggedSorter.Sort(array, new SumDescendingComparer());

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_MaxElemComparerAscendingNull_ReturnSortedArray()
        {
            int[][] array =
            {
                null,
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 4, 0, 2, 6 },
                null,
                new int[] { 22, 33, 11 }
            };

            int[][] expected =
            {
                null,
                null,
                new int[] { 4, 0, 2, 6 },
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 22, 33, 11 }
            };

            JaggedSorter.Sort(array, new MaxElemAscendingComparer());

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_MaxElemComparerDescendingNull_ReturnSortedArray()
        {
            int[][] array =
            {
                null,
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 4, 0, 2, 6 },
                null,
                new int[] { 22, 33, 11 }
            };

            int[][] expected =
            {
               new int[] { 22, 33, 11 },
               new int[] { 5, 3, 1, 7, 9 },
               new int[] { 4, 0, 2, 6 },
               null,
               null
            };

            JaggedSorter.Sort(array, new MaxElemDescendingComparer());

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_MinElemComparerAscendingNull_ReturnSortedArray()
        {
            int[][] array =
            {
                null,
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 4, 0, 2, 6 },
                null,
                new int[] { 22, 33, 11 }
            };

            int[][] expected =
            {
               null,
               null,
               new int[] { 4, 0, 2, 6 },
               new int[] { 5, 3, 1, 7, 9 },
               new int[] { 22, 33, 11 },
            };

            JaggedSorter.Sort(array, new MinElemAscendingComparer());

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_MinElemComparerDescendingNull_ReturnSortedArray()
        {
            int[][] array =
            {
                null,
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 4, 0, 2, 6 },
                null,
                new int[] { 22, 33, 11 }
            };

            int[][] expected =
            {

                new int[] { 22, 33, 11 },
                new int[] { 5, 3, 1, 7, 9 },
                new int[] { 4, 0, 2, 6 },
                null,
                null
            };

            JaggedSorter.Sort(array, new MinElemDescendingComparer());

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_NullComparer_ArgumentNullExcepton()
        {
            Assert.Throws<ArgumentNullException>(() => JaggedSorter.Sort(new int[][] { new int[] { 1, 3, 5, 7, 9 } }, null));
        }

        [Test]
        public void MethodSort_NullArray_ArgumentNullExcepton()
        {
            Assert.Throws<ArgumentNullException>(() => JaggedSorter.Sort(null, new SumAscendingComparer()));
        }

        [Test]
        public void MethodSort_ArrayLengthZero_ArgumentExcepton()
        {
            Assert.Throws<ArgumentException>(() => JaggedSorter.Sort(new int[][] { new int[] {  } }, new SumAscendingComparer()));
        }

        [Test]
        public void MethodSort_OneOfArrayLengthZero_ArgumentExcepton()
        {
            Assert.Throws<ArgumentException>(() => JaggedSorter.Sort(new int[][] { new int[] { } }, new SumAscendingComparer()));
        }
    }
}
