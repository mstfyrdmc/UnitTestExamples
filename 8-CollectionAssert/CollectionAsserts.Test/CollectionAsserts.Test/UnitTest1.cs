using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionAsserts.Test
{
    [TestClass]
    public class UnitTest1
    {
        private List<string> _kullanicilar;
        [TestInitialize]
        public void DataOlustur()
        {
            _kullanicilar = new List<string>();
            _kullanicilar.Add("Mustafa");
            _kullanicilar.Add("Engin");
            _kullanicilar.Add("Ahmet");

        }
        [TestMethod]
        public void Elemanlar_ve_sirasi_ayni_olmalidir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Mustafa");
            yeniKullanicilar.Add("Engin");
            yeniKullanicilar.Add("Ahmet");

            CollectionAssert.AreEqual(_kullanicilar, yeniKullanicilar); //hem elemanlar hem sırası aynı olmalıdır.
        }

        [TestMethod]
        public void Elemanlar_ayni_fakat_sirasi_farkli_olabilir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Engin");
            yeniKullanicilar.Add("Mustafa");
            yeniKullanicilar.Add("Ahmet");

            CollectionAssert.AreEquivalent(_kullanicilar, yeniKullanicilar); //elemanlar aynı olmalı fakat sırasının önemi yoktur. Eleman sayısı ve elemanın aynı olmasına bakar.
        }
        [TestMethod]
        public void Elemanlar_ve_sirasi_ayni_olmamalidir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Engin");
            yeniKullanicilar.Add("Mustafa");
            yeniKullanicilar.Add("Ahmet");

            CollectionAssert.AreNotEqual(_kullanicilar, yeniKullanicilar); //Elemanlar ve sırası aynı olmamalıdır.(Yerini,sırasını,elemanı değiştirdiğimizde testten geçecektir.Tek şart karşılaştıracağımız verilerde elemanlar ve sırası aynı olmamalı.
        }
        [TestMethod]
        public void Elemanlar_farkli_olmalidir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Engin");
            yeniKullanicilar.Add("Mustafa");
            yeniKullanicilar.Add("Ahmet");
            yeniKullanicilar.Add("Murat");

            CollectionAssert.AreNotEquivalent(_kullanicilar, yeniKullanicilar); //Elemanlar farklı olmalıdır. Sırasının farklı olması yeterli olmayacaktır.
        }
        [TestMethod]
        public void Kullanicilar_null_deger_almamalidir()
        {

            CollectionAssert.AllItemsAreNotNull(_kullanicilar); //Null almamasını sağlar
        }
        [TestMethod]
        public void Tum_Kullanicilar_benzersiz_olmalidir()
        {

            CollectionAssert.AllItemsAreUnique(_kullanicilar); //Aynı elemandan 2.si varsa test başarısız olur.
        }
        [TestMethod]
        public void Tum_Elemanlar_ayni_tipte_olmalidir()
        {
            ArrayList liste = new ArrayList
            {
                "Engin","Mustafa", "Ahmet"
            };
            CollectionAssert.AllItemsAreInstancesOfType(liste, typeof(string)); //eleman tipleri farklı ise test başarısız olur
        }
        [TestMethod]
        public void IsSubsetOf_test()
        {
            List<string> yeniKullanicilar = new List<string> { "Mustafa", "Engin" };
            List<string> eskiKullanicilar = new List<string> { "Mustafa", "Salih" };


            CollectionAssert.IsSubsetOf(yeniKullanicilar, _kullanicilar); //bir listenin başka bir listenin alt kümesi olup olmadığını kontrol eder (yeni kullanıcılar,kullanıcıların alt kümesi olduğu için testten geçer)
            CollectionAssert.IsNotSubsetOf(eskiKullanicilar, _kullanicilar); //bir listenin başka bir listenin alt kümesi  olmadığını kontrol eder (eskikullanıcılar, kullanıcıların alt kümesi olmadığından testten geçer)
        }
        [TestMethod]
        public void Contains_test()
        {
            CollectionAssert.Contains(_kullanicilar, "Mustafa"); //listede eleman var mı diye kontrol eder
            CollectionAssert.DoesNotContain(_kullanicilar, "Cevdet"); //listede eleman olmadığını kontrol eder.
        }
    }
}
