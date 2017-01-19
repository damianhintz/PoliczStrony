using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4Domena.Encje;
using StronyA4Domena.Encje.Rozszerzenia;
using Shouldly;

namespace StronyA4Testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Profil_ShouldBeReadFromFile()
        {
            var fileName = @"Samples\Profile\default.json";
            var profil = fileName.WczytajProfil();
            profil.Nazwa.ShouldBe("Nazwa profilu");
            profil.Opis.ShouldBe("Opis profilu");
            profil.Foldery.Length.ShouldBe(2);
        }
    }
}
