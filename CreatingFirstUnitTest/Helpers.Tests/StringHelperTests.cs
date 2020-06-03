using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Given_text_should_be_cleanned_start_and_end_space()
        {
            //Arrange
            var text = "  Yasin Aksu  ";
            var expected = "Yasin Aksu";

            //Act
            var result = StringHelper.DeleteUnNecessarySpace(text);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
