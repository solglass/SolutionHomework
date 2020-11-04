using NUnit.Framework;

namespace NUnitTestHomework
{
    public class MathOperationsTests
    {
        [SetUp]
        public void Setup()
        {
        }
        //h = number of homework (1,2,3,4,5)
        //t == number of a tested task in a homework
        //q = number of a test 
        //Homework1
 
        public void h2t1q1(int a, int b, int expected)
        {
            int actual = 0;
            if (a > b)
            {
                actual = Homework.MathOperations.CalculateSum(a, b);
            }
            else if (a == b)
            {
                actual = Homework.MathOperations.CalculateMultiplication(a, b);
            }
            else if (a < b)
            {
                actual = Homework.MathOperations.CalculateDifference(a, b);
            }
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 0)]
        [TestCase(10, 10, 1)]
        [TestCase(10, -10, 4)]
        [TestCase(-10, -10, 3)]
        [TestCase(-10, 10, 2)]
        public void h2t2q1(int a, int b, int expected)
        {
            int actual = Homework.MathOperations.DetermineTheQudrantOfACoordinate(a, b);


            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 0, new int[] { 0, 0, 0 })]
        [TestCase(10, 10, 1, new int[] { 1, 10, 10 })]
        [TestCase(10, -10, 4, new int[] { -10, 4, 10 })]
        [TestCase(-10, 10, 2, new int[] { -10, 2, 10 })]
        public void h2t3q1(int a, int b, int c, int[] expected)
        {
            int[] actual = Homework.MathOperations.SortThreeIntegers(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 17, -18, new double[] { 1.0, -18.0 })]
        [TestCase(5, 7, 2, new double[] { -0.4, -1 })]
        [TestCase(1, -11, 18, new double[] { 9, 2 })]
        [TestCase(2, -9, 7, new double[] { 3.5, 1 })]
        public void h2t4q1(double a, double b, double c, double[] expected)
        {
            double[] actual = Homework.MathOperations.SolveQudraticEquation(a, b, c);

            Assert.AreEqual(expected[0], actual[0], 0.01);
            Assert.AreEqual(expected[1], actual[1], 0.01);
        }



        //Homework3
        [TestCase(0, 0, 1)]
        [TestCase(10, 2, 100)]
        [TestCase(2, 3, 8)]
        [TestCase(3, 3, 27)]
        [TestCase(1, 10, 1)]
        public void h3t1q1(int a, int b, int expected)
        {
            int actual = Homework.MathOperations.PowerAToB(a, b);

            Assert.AreEqual(expected, actual);
        }



        [TestCase(78, new int[] { 78, 156, 234, 312, 390, 468, 546, 624, 702, 780, 858, 936 })]
        [TestCase(247, new int[] { 247, 494, 741, 988 })]
        [TestCase(322, new int[] { 322, 644, 966 })]
        public void h3t2q1(int a, int[] expected)
        {
            int[] actual = Homework.MathOperations.CalculateTheArrayOfIntegersDivisibleByA(a);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }


        [TestCase(10, 3)]
        [TestCase(15, 3)]
        [TestCase(17, 4)]
        [TestCase(26, 5)]
        public void h3t3q1(int a, int expected)
        {
            int actual = Homework.MathOperations.CalculateTheNumberOfIntegersSquareOfEachIsLessThanA(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5)]
        [TestCase(12, 6)]
        [TestCase(20, 10)]
        [TestCase(25, 5)]
        public void h3t4q1(int a, int expected)
        {
            int actual = Homework.MathOperations.CalculateTheMaxCommonDivisorOfA(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 7, 7)]
        [TestCase(0, 15, 21)]
        [TestCase(22, 0, 42)]

        public void h3t5q1(int a, int b, int expected)
        {
            int actual = Homework.MathOperations.CalculateTheSumOfAtoBDivisibleBySeven(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 144)]
        [TestCase(18, 2584)]
        [TestCase(28, 317811)]
        public void h3t6q1(int a, int expected)
        {
            int actual = Homework.MathOperations.CalculateTheNthFibbonacciNumber(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(30, 40, 10)]
        [TestCase(75, 85, 5)]
        [TestCase(1232, 4242, 14)]
        [TestCase(1, 1, 1)]
        [TestCase(10, 10, 10)]
        public void h3t7q1(int a, int b, int expected)
        {
            int actual = Homework.MathOperations.CalculateMaxCommonDivisorByEuclidiusAlgorithm(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 3)]
        [TestCase(8, 2)]
        [TestCase(125, 5)]
        [TestCase(1000, 10)]
        [TestCase(1, 1)]
        public void h3t8q1(int a, int expected)
        {
            int actual = Homework.MathOperations.CalculateTheNFromCubeByHalfDivisionAlgorithm(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("123", 2)]
        [TestCase("111", 3)]
        [TestCase("0", 0)]
        [TestCase("4785", 2)]
        [TestCase("242", 0)]
        public void h3t9q1(string a, int expected)
        {
            int actual = Homework.MathOperations.CalculateTheNumberOfOddsOfANumber(a);

            Assert.AreEqual(expected, actual);
        }



        [TestCase(10, 5)]
        [TestCase(1, 1)]
        [TestCase(20, 9)]
        public void h3t11q1(int a, int expected)
        {
            int actual = Homework.MathOperations.CalculateNumberOfSumOfEvensMoreThanSumOfOddsFromOneToN(a);

            Assert.AreEqual(expected, actual);
        }


        //Homework4
        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, 0)]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, 1)]
        [TestCase(new int[] { 50, 2, 34, 5, 7, 10 }, 2)]
        [TestCase(new int[] { 50, 75, 23, 5, 7, 10 }, 5)]
        public void h4t1q1(int[] a, int expected)
        {
            int actual = Homework.MathOperations.FindMinElementOfTheArray(a);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, 10)]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, 50)]
        [TestCase(new int[] { 50, 2, 34, 5, 7, 10 }, 50)]
        [TestCase(new int[] { 50, 75, 23, 5, 7, 10 }, 75)]
        public void h4t2q1(int[] a, int expected)
        {
            int actual = Homework.MathOperations.FindMaxElementOfTheArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, 0)]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, 2)]
        [TestCase(new int[] { 50, 2, 34, 5, 7, 10 }, 1)]
        [TestCase(new int[] { 50, 75, 23, 5, 7, 10 }, 3)]
        public void h4t3q1(int[] a, int expected)
        {
            int actual = Homework.MathOperations.FindIndexOfMinElementOfTheArray(a);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, 5)]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, 0)]
        [TestCase(new int[] { 50, 2, 34, 5, 7, 10 }, 0)]
        [TestCase(new int[] { 50, 75, 23, 5, 7, 10 }, 1)]
        public void h4t4q1(int[] a, int expected)
        {
            int actual = Homework.MathOperations.FindIndexOfMaxElementOfTheArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, 17)]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, 17)]
        [TestCase(new int[] { 50, 2, 34, 5, 7, 10 }, 17)]
        [TestCase(new int[] { 50, 75, 23, 5, 7, 10 }, 90)]
        public void h4t5q1(int[] a, long expected)
        {
            long actual = Homework.MathOperations.FindSumOfElementsWithOddIndexesOfTheArray(a);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, 3)]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, 3)]
        [TestCase(new int[] { 50, 2, 34, 5, 7, 10 }, 2)]
        [TestCase(new int[] { 50, 75, 23, 5, 7, 10 }, 4)]
        public void h4t7q1(int[] a, long expected)
        {
            long actual = Homework.MathOperations.FindNumberOfOddElementsOfTheArray(a);

            Assert.AreEqual(expected, actual);
        }



    }
}