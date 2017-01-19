using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4Domena.Encje;
using StronyA4Domena.Encje.Rozszerzenia;
using Shouldly;

namespace StronyA4Testy
{
    [TestClass]
    public class ProfileTest
    {
        [TestMethod]
        public void Profil_ShouldHaveDefaultValues()
        {
            var profil = new Profile();
            profil.Nazwa.ShouldBeNull();
            profil.Opis.ShouldBeNull();
            profil.Foldery.ShouldBeNull();
        }

        [TestMethod]
        public void Profil_ShouldReadFromFile()
        {
            var fileName = @"Samples\Profile\default.json";
            var profil = fileName.WczytajProfil();
            profil.Nazwa.ShouldBe("Nazwa profilu");
            profil.Opis.ShouldBe("Opis profilu");
            profil.Foldery.Count.ShouldBe(2);
        }

        [TestMethod]
        public void Profil_ShouldWriteToFile()
        {
            var profil = new Profile
            {
                Nazwa = "Nazwa profilu",
                Opis = "Opis profilu",
                Foldery = null
            };
            var fileName = @"default.json";
            fileName.ZapiszProfil(profil);
            profil = fileName.WczytajProfil();
            profil.Nazwa.ShouldBe("Nazwa profilu");
            profil.Opis.ShouldBe("Opis profilu");
            profil.Foldery.ShouldBeNull();
        }
    }
}
