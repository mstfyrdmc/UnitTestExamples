    using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Test
{
[TestClass]    
    public class CartTests
    {
        private CartItem _cartItem;
        private CartManager _cartManager;
        [TestInitialize]
        public void TestInitialze()
        {
            //Arrange

            _cartManager = new CartManager();
            _cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductID = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500
                },
                Quantity = 1
            };
            _cartManager.Add(_cartItem);
        }

        [TestCleanup]
        public void ClassCleanup()
        {
            _cartManager.Clear();
        }

        [TestMethod]
        public void Sepete_urun_eklenebilir()
        {
            //Arrange
            const int beklenen = 1;
            //var cartManager = new CartManager();
            //var cartItem = new CartItem();
            //{
            //    Product product = new Product();
            //    {
            //        product.ProductID = 1;
            //    product.ProductName = "Laptop";
            //    product.UnitPrice = 2500;
            //    }

            //    cartItem.Quantity = 1;
            //};

            //Act

            _cartManager.Add(_cartItem);
            var toplamElemanSayisi = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(beklenen, toplamElemanSayisi);
        }

        [TestMethod]
        public void Sepette_olan_urunler_cikarilabilir()
        {
            //Arrange
            //var cartManager = new CartManager();
            //var cartItem = new CartItem();
            //{
            //    Product product = new Product();
            //    {
            //        product.ProductID = 1;
            //        product.ProductName = "Laptop";
            //        product.UnitPrice = 2500;
            //    }
            //    cartItem.Quantity = 1;
            //}
            //cartManager.Add(cartItem);
            var sepetteOlanElemanSayisi = _cartManager.TotalItems;

            //Act
            _cartManager.Cikar(1);
            var sepetteKalanElemanSayisi = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(sepetteOlanElemanSayisi - 1, sepetteKalanElemanSayisi);
        }

        [TestMethod]
        public void Sepet_Temizlenebilmeli()
        {
            //Arrange
            //var cartManager = new CartManager();
            //var cartItem = new CartItem();
            //{
            //    Product product = new Product();
            //    {
            //        product.ProductID = 1;
            //        product.ProductName = "Laptop";
            //        product.UnitPrice = 2500;
            //    }
            //    cartItem.Quantity = 1;
            //};
            //cartManager.Add(cartItem);

            //Act
            _cartManager.Clear();

            //Assert
            Assert.AreEqual(0, _cartManager.TotalQuantity);
            Assert.AreEqual(0, _cartManager.TotalItems);
        }
    }
}
