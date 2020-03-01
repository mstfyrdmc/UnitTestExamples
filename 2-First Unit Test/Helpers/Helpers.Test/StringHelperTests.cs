using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Test
{
    [TestClass]
  public  class StringHelperTests
    {
        [TestMethod]
        public void Girilen_ifadenin_basindaki_ve_sonundaki_fazla_bosluklar_silinmelidir()
        {
            //Arrange
            var ifade = "   Mustafa Yardimci   ";
            var beklenen = "Mustafa Yardimci";

            //Act
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            //Assert;
            Assert.AreEqual(beklenen, gerceklesen);
        }

        public void Girilen_ifadenin_icindeki_fazla_bosluklar_silinmelidir()
        {
            //Arrange
            var ifade = "Mustafa Yardimci   Ahmet   Mehmetoglu      Sait   Faik    Abasiyanik ";
            var beklenen = "Mustafa Yardimci Ahmet Mehmetoglu Sait Faik Abasiyanik";

            //Act
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            //Assert;
            Assert.AreEqual(beklenen, gerceklesen);
        }
    }
}
