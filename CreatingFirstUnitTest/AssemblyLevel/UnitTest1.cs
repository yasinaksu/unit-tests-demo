using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssemblyLevel
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            Debug.WriteLine("Runnig AssemblyInitialize");
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("Runnig AssemblyCleanup");
        }
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
        public void TestMethod1()
        {
            Debug.WriteLine("Runnig TestMethod1");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Debug.WriteLine("Runnig TestMethod2");
        }
    }
}
