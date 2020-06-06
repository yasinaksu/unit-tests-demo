using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestContextIntro.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; } //this property is set automaticaly in rumtime.

        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("TestInitialize");
            TestContext.WriteLine("Test name : {0}", TestContext.TestName);
            TestContext.WriteLine("Test state : {0}", TestContext.CurrentTestOutcome);
            TestContext.Properties["name"] = "Yasin Aksu";
            TestContext.WriteLine("");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("TestCleanup");
            TestContext.WriteLine("Test name : {0}", TestContext.TestName);
            TestContext.WriteLine("Test state : {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Tester Name : {0}", TestContext.Properties["name"]);
            TestContext.WriteLine("");
        }

        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("TestMethod1");
            TestContext.WriteLine("Test name : {0}",TestContext.TestName);
            TestContext.WriteLine("Test state : {0}",TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test class info : {0}",TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine("Tester Name : {0}", TestContext.Properties["name"]);
            TestContext.WriteLine("");

            Assert.AreEqual(1, 1);
        }
    }
}
