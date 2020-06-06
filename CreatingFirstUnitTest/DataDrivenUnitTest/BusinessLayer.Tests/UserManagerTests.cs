using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class UserManagerTests
    {
        public TestContext TestContext { get; set; }
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Users.xml",
            "User",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTest()
        {
            var manager = new UserManager();
            var name = TestContext.DataRow["name"].ToString();
            var phone = TestContext.DataRow["phone"].ToString();
            var email = TestContext.DataRow["email"].ToString();
            var result = manager.UserAdd(name, phone, email);

            Assert.IsTrue(result);
        }
    }
}
