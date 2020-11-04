using NUnit.Framework;

namespace NUnitTestHomework
{
    public class OrderOperationsTests
    {
        [SetUp]
        public void Setup()
        {
        }
        //h = number of homework (1,2,3,4,5)
        //t == number of a tested task in a homework
        //q = number of a test 
 
        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, new int[] { 10, 7, 5, 1, 2, 0 })]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, new int[] { 10, 7, 5, 1, 2, 50 })]
        [TestCase(new int[] { 50, 2, 34, 5, 7, 10 }, new int[] { 10, 7, 5, 34, 2, 50 })]
        [TestCase(new int[] { 50, 75, 23, 5, 7, 10 }, new int[] { 10, 7, 5, 23, 75, 50 })]
        public void h4t6q1(int[] a, int[] expected)
        {
            int[] actual = Homework.OrderOperations.ReverseTheArray(a);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, new int[] { 5, 7, 10, 0, 2, 1 })]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, new int[] { 5, 7, 10, 50, 2, 1 })]
        [TestCase(new int[] { 50, 2, 1, 2, 5, 7, 10 }, new int[] { 5, 7, 10, 2, 50, 2, 1 })]
        [TestCase(new int[] { 50, 75, 1, 3, 5, 7, 10 }, new int[] { 5, 7, 10, 3, 50, 75, 1 })]
        public void h4t8q1(int[] a, int[] expected)
        {
            int[] actual = Homework.OrderOperations.InterchangeTheArrayByTheCentre(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, new int[] { 0, 1, 2, 5, 7, 10 })]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, new int[] { 1, 2, 5, 7, 10, 50 })]
        [TestCase(new int[] { 50, 2, 1, 2, 5, 7, 10 }, new int[] { 1, 2, 2, 5, 7, 10, 50 })]
        [TestCase(new int[] { 50, 75, 1, 3, 5, 7, 10 }, new int[] { 1, 3, 5, 7, 10, 50, 75 })]
        public void h4t9q1(int[] a, int[] expected)
        {
            int[] actual = Homework.OrderOperations.InsertSortTheArrayAsc(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, new int[] { 10, 7, 5, 2, 1, 0 })]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, new int[] { 50, 10, 7, 5, 2, 1 })]
        [TestCase(new int[] { 50, 2, 1, 2, 5, 7, 10 }, new int[] { 50, 10, 7, 5, 2, 2, 1 })]
        [TestCase(new int[] { 50, 75, 1, 3, 5, 7, 10 }, new int[] { 75, 50, 10, 7, 5, 3, 1 })]
        public void h4t10q1(int[] a, int[] expected)
        {
            int[] actual = Homework.OrderOperations.BubbleSortTheArrayDesc(a);

            Assert.AreEqual(expected, actual);
        }

    }
}