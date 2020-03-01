using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAsserts.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringContainsTest()
        {
            StringAssert.Contains("Test dünyasından merhabalar", "yas"); //içinde geçen ifadeyi arar.
        }
        public void StringMatchesTest()
        {
            StringAssert.Matches("Test dünyasından merhabalar",new System.Text.RegularExpressions.Regex(@"[a-zA-z]")); //bu patern geçerli ise test başarılı
            StringAssert.DoesNotMatch("Test dünyasından merhabalar", new System.Text.RegularExpressions.Regex(@"[0-9]")); //bu patern geçerli değilse test başarılıdır
        }
        public void StartsWithTest()
        {
            StringAssert.StartsWith("Test dünyasından merhabalar", "Test"); //Test ile başlıyosa başarılır.(Büyük küçük harf duyarlı)
        }
        public void EndsWithTest()
        {
            StringAssert.EndsWith("Test dünyasından merhabalar", "merhabalar");//Merhaba ile bitiyorsa başarılır.(Büyük küçük harf duyarlı)
        }
    }
}
