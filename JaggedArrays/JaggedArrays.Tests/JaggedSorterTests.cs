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

            DelegateInterface.Sort(array, new SumAscendingComparer().ToCompare);

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

            DelegateInterface.Sort(array, new SumDescendingComparer().ToCompare);

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

            DelegateInterface.Sort(array, new MaxElemAscendingComparer().ToCompare);

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

            DelegateInterface.Sort(array, new MaxElemDescendingComparer().ToCompare);

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

            InterfaceDelegate.Sort(array, new MinElemAscendingComparer());

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

            InterfaceDelegate.Sort(array, new MinElemDescendingComparer());

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

            InterfaceDelegate.Sort(array, new SumAscendingComparer());

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

            InterfaceDelegate.Sort(array, new SumDescendingComparer());

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

            InterfaceDelegate.Sort(array, new MaxElemAscendingComparer());

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

            DelegateInterface.Sort(array, new MaxElemDescendingComparer().ToCompare);

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

            DelegateInterface.Sort(array, new MinElemAscendingComparer().ToCompare);

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

            DelegateInterface.Sort(array, new MinElemDescendingComparer().ToCompare);

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void MethodSort_NullArray_ArgumentNullExcepton()
        {
            Assert.Throws<ArgumentNullException>(() => InterfaceDelegate.Sort(null, new SumAscendingComparer()));
        }

        [Test]
        public void MethodSort_ArrayLengthZero_ArgumentExcepton()
        {
            Assert.Throws<ArgumentException>(() => InterfaceDelegate.Sort(new int[][] { new int[] {  } }, new SumAscendingComparer()));
        }

        [Test]
        public void MethodSort_OneOfArrayLengthZero_ArgumentExcepton()
        {
            Assert.Throws<ArgumentException>(() => InterfaceDelegate.Sort(new int[][] { new int[] { } }, new SumAscendingComparer()));
        }
    }
}
