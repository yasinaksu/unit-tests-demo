using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTests
    {
        private CartItem _cartItem;
        private CartManager _cartManager;
        
        [TestInitialize]
        public void TestInitialize()
        {
            _cartManager = new CartManager();
            _cartItem = new CartItem
            {
                Product = new Product { ProductId = 1, ProductName = "Laptop", UnitPrice = 2500 },
                Quantity = 1
            };
            _cartManager.Add(_cartItem);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _cartManager.Clear();
        }

        [TestMethod]
        public void Product_should_be_added_to_cart()
        {
            //Arrange
            const int expedted = 1;           

            //Act
            var totalItemCount = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(expedted, totalItemCount);
        }

        [TestMethod]
        public void Product_in_cart_should_be_removed_from_cart()
        {
            //Arrange           
            var currentItemCount = _cartManager.TotalItems;

            //Act
            _cartManager.Remove(1);
            var afterRemoveItemCount = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(currentItemCount-1, afterRemoveItemCount);
        }

        [TestMethod]
        public void cart_should_be_cleanned()
        {
            //Arrange           

            //Act
            _cartManager.Clear();

            //Assert
            Assert.AreEqual(0, _cartManager.TotalItems);
            Assert.AreEqual(0, _cartManager.TotalQuantity);
        }
    }
}
