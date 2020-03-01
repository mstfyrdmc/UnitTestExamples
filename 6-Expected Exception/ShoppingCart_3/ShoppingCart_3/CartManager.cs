using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_3
{
    //Gereksinimler:
    //1.Sepete ürün eklenebilmelidir
    //2.Sepette olan ürün çıkarılabilmelidir.
    //3.Sepet temizlenebilmelidir.

    //4.Sepette olan üründen 1 adet eklendiğinde sepetteki toplam ürün adedi bir artmalı eleman sayısı aynı kalmalıdır.
    //5.Sepette farklı üründen 1 adet eklendiğinde sepetteki toplam ürün adedi ve eleman sayısı birer artmalıdır.

    //Aynı ürün ikinci kez eklenemez.
    public class CartManager
    {
        private readonly List<CartItem> _cartItems;
        public CartManager()
        {
            _cartItems = new List<CartItem>();
        }
        public void Add(CartItem cartItem)
        {
            var addedCartItem = _cartItems.SingleOrDefault(m => m.Product.ProductID == cartItem.Product.ProductID);
            if (addedCartItem == null)
            {
                _cartItems.Add(cartItem);

            }
            else
            {
                throw new ArgumentException("This product has been added");
            }
        }
        public void Remove(int productId)
        {
            var product = _cartItems.FirstOrDefault(m => m.Product.ProductID == productId);
            _cartItems.Remove(product);
        }
        public List<CartItem> cartItems
        {
            get
            {
                return _cartItems;
            }

        }

        public void Clear()
        {
            _cartItems.Clear();
        }
        public decimal TotalPrice
        {
            get
            {
                return _cartItems.Sum(m => m.Quantity * m.Product.UnitPrice);
            }
        }
        public int TotalQuantity
        {
            get
            {
                return _cartItems.Sum(m => m.Quantity);
            }
        }
        public int TotalItems
        {
            get
            {
                return _cartItems.Count;
            }
        }
    }
}
