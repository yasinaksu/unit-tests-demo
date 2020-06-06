using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAttributes2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod,Ignore,Description("this check some data whether useful or not")]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Timeout(1000)]
        public void TestMethod2()
        {
            Thread.Sleep(1500);
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Timeout(TestTimeout.Infinite)]
        public void TestMethod3()
        {
            Assert.IsTrue(true);
        }
    }
}
