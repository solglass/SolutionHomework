using NUnit.Framework;

namespace NUnitTestHomework
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //h = number of homework (1,2,3,4,5)
        //t == number of a tested task in a homework
        //q = number of a test 
        //Homework1
        [TestCase(2, 1, 9.0)]
        public void h1t1q1(int a, int b, double expected)
        {
            double actual = Homework.OperationsWithVariables.Solve5AplBSqDivByBMinusA(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, new int[] { 1, 1 })]
        [TestCase(1, 2, new int[] { 2, 1 })]
        [TestCase(10, 5, new int[] { 5, 10 })]
        public void h1t2q1(int a, int b, int[] expected)
        {
            int[] actual = Homework.OperationsWithVariables.SwapAAndB(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 3, new int[] { 3, 0 })]
        [TestCase(9, 4, new int[] { 2, 1 })]
        [TestCase(9, 9, new int[] { 1, 0 })]
        public void h1t3q1(int a, int b, int[] expected)
        {
            int[] actual = Homework.OperationsWithVariables.CalculateDivAndMod(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, -5, 7, 2.4)]
        [TestCase(1, -3, 1, 4)]
        [TestCase(2, 10, 0, -5)]
        [TestCase(1, 1, 0, -1)]
        public void h1t4q1(double a, double b, double c, double expected)
        {
            double actual = Homework.OperationsWithVariables.SolveLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestCase(0, 1, 0, 1, new double[] { 1, 0 })]
        [TestCase(3, 7, 4, 8, new double[] { 1, 1 })]
        [TestCase(-2, 2, 1, 3, new double[] { 0.5, 2 })]
        [TestCase(0, 2, 7, 5, new double[] { -1, 7 })]
        public void h1t5q1(double x1, double x2, double y1, double y2, double[] expected)
        {
            double[] actual = Homework.OperationsWithVariables.CalclutateLinearEquationFromTwoPoints(x1, x2, y1, y2);
            Assert.AreEqual(expected[0], actual[0], 0.01);
            Assert.AreEqual(expected[1], actual[1], 0.01);
        }

        //Homework2
        [TestCase(9, 3, 12)]
        [TestCase(9, 12, -3)]
        [TestCase(9, 9, 81)]
        [TestCase(0, 0, 0)]

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

        [TestCase(25, "двадцать пять")]
        [TestCase(15, "пятнадцать")]
        [TestCase(42, "сорок два")]
        [TestCase(72, "семьдесят два")]
        [TestCase(99, "девяносто девять")]
        public void h2t5q1(int a, string expected)
        {
            string actual = Homework.StringOperations.GetStringRepresantationOfTwoDigitInteger(a);

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual);
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

        [TestCase("123", "321")]
        [TestCase("12345", "54321")]
        [TestCase("111", "111")]

        public void h3t10q1(string a, string expected)
        {
            string a1 = a.ToString();
            string actual = Homework.StringOperations.ReverseAStringNumber(a1);

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

        [TestCase("123", "456789", false)]
        [TestCase("555", "666", false)]
        [TestCase("1555", "1666", true)]
        [TestCase("5155", "6616", true)]
        [TestCase("5551", "6661", true)]
        public void h3t12q1(string a, string b, bool expected)
        {
            bool actual = Homework.StringOperations.DetermineIfTwoNumbersHaveEqualDigits(a, b);

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
        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, new int[] { 10, 7, 5, 1, 2, 0 })]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, new int[] { 10, 7, 5, 1, 2, 50 })]
        [TestCase(new int[] { 50, 2, 34, 5, 7, 10 }, new int[] { 10, 7, 5, 34, 2, 50 })]
        [TestCase(new int[] { 50, 75, 23, 5, 7, 10 }, new int[] { 10, 7, 5, 23, 75, 50 })]
        public void h4t6q1(int[] a, int[] expected)
        {
            int[] actual = Homework.OrderOperations.ReverseTheArray(a);

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