using NUnit.Framework;

namespace NUnitTestHomework
{
    public class OperationsWithVariablesTests
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

    }
}