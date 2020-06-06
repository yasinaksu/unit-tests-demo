using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32.SafeHandles;

namespace TestFirstDevelopment.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var measurements = new List<Measurement>()
            {
                new Measurement
                {
                    Max=20,
                    Min=1
                }
            };

            var groupMaker = new GroupMaker(1);
            var groups = groupMaker.MakeGroup(measurements);

            Assert.AreEqual(1, groups.Count);

        }
    }
}
