using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class CartManager
    {
        /*
        Gereksinimler;
        1-sepete ürün eklenebilmelidir.
        2-sepette olan ürün çıkarılabilmelidir.
        3-sepet temizlenebilmelidir.

        4-sepette olan üründen 1 adet eklendiğinde sepetteki toplam ürün adeti 1 artmalı eleman sayısı aynı kalmalıdır
        5-sepete farklı üründen 1 adet eklendiğinde sepetteki toplam ürün adeti ve eleman sayısı 1 er artmalıdır.
        */
        private readonly List<CartItem> _cartItems;
        public CartManager()
        {
            _cartItems = new List<CartItem>();
        }
        public List<CartItem> CartItems => _cartItems;
        public int TotalQuantity => _cartItems.Sum(x => x.Quantity);
        public decimal TotalPrice => _cartItems.Sum(x => x.Quantity * x.Product.UnitPrice);
        public int TotalItems => _cartItems.Count;

        public void Add(CartItem cartItem)
        {
            var addedCartItem = _cartItems.SingleOrDefault(x => x.Product.ProductId == cartItem.Product.ProductId);
            if (addedCartItem == null)
            {
                _cartItems.Add(cartItem);
            }
            else
            {
                addedCartItem.Quantity += cartItem.Quantity;
            }
        }

        public void Remove(int productId)
        {
            var cartItem = _cartItems.FirstOrDefault(x => x.Product.ProductId == productId);
            _cartItems.Remove(cartItem);
        }

        public void Clear()
        {
            _cartItems.Clear();
        }
    }
}
