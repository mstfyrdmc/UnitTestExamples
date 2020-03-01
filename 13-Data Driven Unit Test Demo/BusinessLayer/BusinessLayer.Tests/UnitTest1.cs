using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Kullanicilar.xml", "Kullanici", DataAccessMethod.Sequential)]

        //xml yolu için kullaniclar.xml=> sağ tık=> propertysi => copy always  (xml dosyasını debug dosyasına atıyoruz.)

        [TestMethod]
        public void DataTest()
        {
            var manager = new KullaniciManager();

            //XML'den ad-telefon-mail bilgilerini çekiyoruz
            var ad = TestContext.DataRow["ad"].ToString();
            var telefon = TestContext.DataRow["telefon"].ToString();
            var mail = TestContext.DataRow["mail"].ToString();
            //
            var sonuc = manager.KullaniciEkle(ad,telefon,mail);

            Assert.IsTrue(sonuc);
        }
    }
}
