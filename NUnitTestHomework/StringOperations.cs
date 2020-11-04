using NUnit.Framework;

namespace NUnitTestHomework
{
    public class StringOperationsTests
    {
        [SetUp]
        public void Setup()
        {
        }
        //h = number of homework (1,2,3,4,5)
        //t == number of a tested task in a homework
        //q = number of a test 
        //Homework1
  

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



        [TestCase("123", "321")]
        [TestCase("12345", "54321")]
        [TestCase("111", "111")]

        public void h3t10q1(string a, string expected)
        {
            string a1 = a.ToString();
            string actual = Homework.StringOperations.ReverseAStringNumber(a1);

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


    }
}