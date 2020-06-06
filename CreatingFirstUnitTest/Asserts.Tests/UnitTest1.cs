using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Asserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AreEqualWithCustomErrorMessage()
        {
            const double givenValue = 16;
            const double expected = 4;

            double actual = Math.Sqrt(givenValue);
            Assert.AreEqual(expected, actual, "{0} sayısının karakökü {1} olmalıdır", givenValue, expected);
        }
        [TestMethod]
        public void AreEqualWithUsingDelta()
        {
            double expected = 3.1622;
            //Formül : |expected-actual|<=delta
            double delta = 0.0001;

            double actual = Math.Sqrt(10);
            Assert.AreEqual(expected, actual, delta);
        }
        [TestMethod]
        public void AreEqualComparingStringsWithIgnoreCaseSensitive()
        {
            string expected = "HELLO";
            string actual = "hello";
            bool ignoreCase = true;
            Assert.AreEqual(expected, actual, ignoreCase);
        }
        [TestMethod]
        public void AreNotEqual()
        {
            const double notExpected = 0;
            var actual = Math.Pow(5, 0);
            Assert.AreNotEqual(notExpected, actual);
        }

        [TestMethod]
        public void AreSame()
        {
            //Assert.AreSame() using for checking referances are same or not.
            var numbers = new byte[] { 1, 2, 3 };
            var numbers2 = numbers;
            numbers[0] = 4;

            Assert.AreSame(numbers, numbers2);
        }

        [TestMethod]
        public void ComparingAreEqualAndAreSame()
        {
            int a = 1;
            int b = a;

            Assert.AreEqual(a, b, "AreEqual failed");
            Assert.AreNotSame(a, b, "AreSame failed");
        }

        [TestMethod]
        public void Using_Inconclusive()
        {
            int a = 1;
            int b = a;

            Assert.AreEqual(a, b);
            Assert.Inconclusive("test is succed but not enough!");
        }

        [TestMethod]
        public void IsInstanceOfType_and_IsNotInstanceOfType()
        {
            var number = 3.5m;
            Assert.IsInstanceOfType(number, typeof(decimal));
            Assert.IsNotInstanceOfType(number, typeof(int));
        }
        [TestMethod]
        public void IsTrue_and_IsFalse()
        {
            Assert.IsTrue(10 % 2 == 0);
            Assert.IsFalse(10 % 2 == 1);
        }
    }
}
