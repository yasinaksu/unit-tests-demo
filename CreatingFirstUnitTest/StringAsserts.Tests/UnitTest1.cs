using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAsserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringContainTest()
        {
            StringAssert.Contains("Hello from string assert", "str");
        }

        [TestMethod]
        public void StringMatchesTest()
        {
            StringAssert.Matches("Hello from string assert", new Regex(@"[a-zA-z]"));
            StringAssert.DoesNotMatch("Hello from string assert", new Regex(@"[0-9]"));
        }

        [TestMethod]
        public void StartsWithTest()
        {
            StringAssert.StartsWith("Hello from string assert", "Hello");
        }

        [TestMethod]
        public void EndsWithTest()
        {
            StringAssert.EndsWith("Hello from string assert", "ert");
        }
    }
}
