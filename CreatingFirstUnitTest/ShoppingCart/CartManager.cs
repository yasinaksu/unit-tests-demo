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
            _cartItems.Add(cartItem);
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
