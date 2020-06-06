using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAttributes1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod,Owner("Yasin"),TestCategory("Tester"),Priority(1)]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Kerim")]
        [TestCategory("Tester")]
        [Priority(2)]
        [TestProperty("Updater","Yasin Aksu")]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Yasin")]
        [TestCategory("Developer")]
        [Priority(1)]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Yasin")]
        [TestCategory("Tester")]
        [TestCategory("Developer")]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Kerim")]
        [TestCategory("Developer")]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
