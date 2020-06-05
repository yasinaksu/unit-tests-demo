using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssemblyLevel
{
    [TestClass]
    public class UnitTest2
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Debug.WriteLine("Runnig ClassInitialize");
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            Debug.WriteLine("Runnig ClassCleanup");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Runnig TestInitialize");
        }
        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("Runnig TestCleanup");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Debug.WriteLine("Runnig TestMethod3");
        }
        [TestMethod]
        public void TestMethod4()
        {
            Debug.WriteLine("Runnig TestMethod4");
        }
    }
}
