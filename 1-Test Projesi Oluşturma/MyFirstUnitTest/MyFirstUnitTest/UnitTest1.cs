using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyFirstUnitTest
{
    //New Project => Test => Unit Test . Net Framework
    //Üst bar => Test => Windows=> Test Explorer => Build et
    //Çalıştırmak için => sağ tık => run
    //Çalıştırmak için => üst bar test => Run
    //Çalıştırmak için => buildden sonra solda çıkan ekranda sağ tık => run
    //Yeşil check=> başarılı
    //Kırmızı check =>başarısız

    //3 kısımdan oluşur. Arrange, Act , Assert
    //Arrange=> değişkenlerimizi tanımladığımız kısım
    //Act=> Eyleme geçilen kısım, test etmek istediğimiz fonksiyonu çağırdığımız ve gerçekleşen sonucu aldığımız kısımdır.
    //Assert=>Testin geçerli olup olmadığını belirleyen kısım.

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
