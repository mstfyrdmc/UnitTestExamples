using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_2.Test
{
    [TestClass]
    public class CartTests
    {
        private static CartItem _cartItem;
        private  static CartManager _cartManager;
        [ClassInitialize]
        public static void ClassInitialze(TestContext testContext)
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

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _cartManager.Clear();
        }

        [TestMethod]

        public void Sepette_olan_urunden_1_adet_eklendiginde_sepetteki_toplam_urun_adedi_bir_artmali_eleman_sayisi_ayni_kalmalidir()
        {
            //Arrange
            int toplamAdet = _cartManager.TotalQuantity;
            int toplamElemanSayisi = _cartManager.TotalItems;

            //Act
            _cartManager.Add(new CartItem
            {
                Product = new Product
                {
                    ProductID=2,
                    ProductName="Mouse",
                    UnitPrice=10
                },
                Quantity=1
            });

            //Assert
            Assert.AreEqual(toplamAdet + 1, _cartManager.TotalQuantity);
            Assert.AreEqual(toplamElemanSayisi+1,_cartManager.TotalItems);
        }



        [TestMethod]
        public void Sepette_farkli_urunden_1_adet_eklendiginde_sepetteki_toplam_urun_adedi_ve_eleman_sayisi_birer_artmailidir()
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

