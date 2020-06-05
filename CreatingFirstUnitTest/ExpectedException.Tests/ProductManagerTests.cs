using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpectedException.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        private ProductManager _productManager;
        private string _laptop = "Laptop";

        [TestInitialize]
        public void TestInitialize()
        {
            _productManager = new ProductManager();
            _productManager.Add(_laptop);

        }
        [TestMethod]
        [ExpectedException(typeof(Exception),AllowDerivedTypes =true)]
        public void Ayni_urunden_tekrar_eklenmeye_calisildiginda_ArgumentException_firlatilmali()
        {
            _productManager.Add(_laptop);
        }
    }
}
