using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Asserts.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const double girilenDeger = 16;
            const double beklenenDeger = 4;
            double gerceklesenDeger = Math.Sqrt(girilenDeger);

            Assert.AreEqual(beklenenDeger, gerceklesenDeger, "{0} sayısının karekökü {1} olmalıdır.", girilenDeger, beklenenDeger);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double beklenen = 3.1622;
            //Formül : | Beklenen-gerceklesen| <=delta
            double delta = 0.0001; //virgülden sonraki basamak sayısı için
            double gercek = Math.Sqrt(10);
            Assert.AreEqual(beklenen, gercek, delta);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string beklenen = "MERHABA";
            string gerceklesen = "Merhaba";
            Assert.AreEqual(beklenen, gerceklesen,true);
            //true küçük büyük harf duyarlılığını kaldırmak için kullandık. (Ignore case)
        }
        [TestMethod]
        public void TestMethod4()
        {
           const double beklenmeyen = 0;
            var gerceklesen = Math.Pow(5, 0);
            Assert.AreNotEqual(beklenmeyen, gerceklesen);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var sayilar = new byte[] { 1, 2, 3, 4, 5 };
            //var digerSayilar = new byte[] { 1, 2, 3, 4, 5 };  //bu şekilde tanımlasaydık adresleri farklı olduğu için sonuç yanlış çıkacaktı.
            var digerSayilar = sayilar;
            sayilar[0] = 4;

            Assert.AreSame(sayilar, digerSayilar);

            //true döner , adresleri aynı olduğu için (new leyerek ram de bir adres atadık, değer atamada da aynı adresi kullanacağı için sonuç doğru çıkar.
        }
        [TestMethod]
        public void TestMethod6()
        {
            //int değişkenleri değer tipli olduğundan dolayı bu ikisi farklıdır.(Referansları farklıdır)
            int a = 10;
            int b = a;

            Assert.AreEqual(a, b,"Are Equal Fail Oldu");
            Assert.AreSame(a, b,"Are Same Fail Oldu");

        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(1, 1);
            Assert.Inconclusive("Bu test yeterli değildir.");
        }

        [TestMethod]
        public void TestMethod8()
        {
            var sayi = 5m;
            //verinin belirtilen tipte olup olmadığını kontrol eder.
            Assert.IsInstanceOfType(sayi, typeof(decimal));
            Assert.IsNotInstanceOfType(sayi, typeof(int));
        }
        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsTrue(10 % 2 == 0);
            Assert.IsFalse(10 % 2 == 1);
        }
        [TestMethod]
        public void TestMethod10()
        {
            List<string> sayilar = new List<string> { "Salih", "Mustafa", "Ahmet" };
            var cIleBaslayanIlkIsim = sayilar.FirstOrDefault(m => m.StartsWith("C"));
            var aIleBaslayanIlkIsim = sayilar.FirstOrDefault(m => m.StartsWith("A"));

            //Null mı değil mi kontrolü
            Assert.IsNull(cIleBaslayanIlkIsim, "IsNull Başarısız Oldu");
            Assert.IsNotNull(aIleBaslayanIlkIsim, "IsNotNull Başarısız Oldu");
        }

        [TestMethod]
        public void TestMethod11()
        {
            try
            {
                var sayi = 5;
                int sonuc = sayi / 0;
            }
            catch (DivideByZeroException)
            {
                //testin geçersiz olduğu durumlar için kullanılır
                Assert.Fail("Test Başarısız Oldu");
            }
        }
    }
}
