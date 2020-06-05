using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTests
    {
        private static CartItem _cartItem;
        private static CartManager _cartManager;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _cartManager = new CartManager();
            _cartItem = new CartItem
            {
                Product = new Product { ProductId = 1, ProductName = "Laptop", UnitPrice = 2500 },
                Quantity = 1
            };
            _cartManager.Add(_cartItem);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _cartManager.Clear();
        }

        [TestMethod]
        public void Sepete_farkli_urunden_bir_adet_eklendiginde_sepetteki_toplam_urun_adeti_ve_eleman_sayisi_bir_artmalidir()
        {
            //Arrange
            int toplamAdet = _cartManager.TotalQuantity;
            int toplamElemanSayisi = _cartManager.TotalItems;

            //Act
            _cartManager.Add(new CartItem
            {
                Product = new Product { ProductId = 2, ProductName = "Mouse", UnitPrice = 10 },
                Quantity = 1
            });

            //Assert
            Assert.AreEqual(toplamAdet+1, _cartManager.TotalQuantity);
            Assert.AreEqual(toplamElemanSayisi+1, _cartManager.TotalItems);
        }

        [TestMethod]
        public void Sepette_olan_urunden_bir_adet_eklendiginde_sepetteki_toplam_urun_adeti_bir_artmali_ve_eleman_sayisi_ayni_kalmali()
        {
            //Arrange
            int toplamAdet = _cartManager.TotalQuantity;
            int toplamElemanSayisi = _cartManager.TotalItems;

            //Act
            _cartManager.Add(_cartItem);

            //Assert
            Assert.AreEqual(toplamAdet + 1, _cartManager.TotalQuantity);
            Assert.AreEqual(toplamElemanSayisi, _cartManager.TotalItems);
        }
    }
}
