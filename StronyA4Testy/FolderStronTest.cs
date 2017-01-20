using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4Domena.Encje;
using Shouldly;

namespace StronyA4Testy
{
    [TestClass]
    public class FolderStronTest
    {
        [TestMethod]
        public void FolderStron_ShouldHaveDefaultValues()
        {
            var folder = new FolderStron();
            folder.Folder.ShouldBeNull();
            folder.Typ.ShouldBe("pdf");
            folder.Metoda.ShouldBe("stosunekPowierzchni"); //metrykaEuklidesowa,klasyfikacja
            folder.Pliki.ShouldBe(0);
            folder.Strony.ShouldBe(0);
            folder.StronyA4.ShouldBe(0);
            folder.Data.ShouldBeNull();
        }
    }
}
