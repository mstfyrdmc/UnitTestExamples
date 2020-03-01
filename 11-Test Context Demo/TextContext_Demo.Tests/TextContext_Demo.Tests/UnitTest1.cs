using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestContext_Demo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        //yapılacak ilk işlem textContext nesnesine erişmek olacaktır.
        //TestContext türünde ismi TestContext olan bir propertyi oluşturduk. İsmi TestContext olmalı. Biz set etmeyeceğiz run time da kendisi set olacaktır. O nedenle isminin TestContext olması gerekiyor.
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("--TestInitialize--\n"); //Bilgiyi output ekranına yazdırır. Run yaptığımızda output linki gelir ve orada istenilen veriyi yazdırır.
            TestContext.WriteLine("Test Adı: {0}", TestContext.TestName);  //testin adını gösterir.
            TestContext.WriteLine("Test Durumu: {0}", TestContext.CurrentTestOutcome); //Testin o an ki durumunu gösterir. 
            TestContext.Properties["bilgi"] = "extra bilgi" ; //bir key yardımıyla bilgi saklayabiliriz.
        }
        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("--TestCleanup--\n"); 
            TestContext.WriteLine("Test Adı: {0}", TestContext.TestName); 
            TestContext.WriteLine("Test Durumu: {0}", TestContext.CurrentTestOutcome); 
            TestContext.WriteLine("Test Bilgi: {0}", TestContext.Properties["bilgi"]); //key ile bilgiyi çekme
            
        }
       
        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("--TestMethod1--\n"); 
            TestContext.WriteLine("Test Adı: {0}", TestContext.TestName); 
            TestContext.WriteLine("Test Durumu: {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Sınıfı: {0}", TestContext.FullyQualifiedTestClassName); //Testin sınıf bilgisini gösterir.Full Name'i verir.
            TestContext.WriteLine("Test Bilgi: {0}", TestContext.Properties["bilgi"]); 
            Assert.AreEqual(1, 1);
        }
    }
}
