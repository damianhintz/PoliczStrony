using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4.Domena;
using StronyA4.Domena.Encje;
using StronyA4.Domena.Encje.Rozszerzenia;
using Shouldly;

namespace StronyA4Testy
{
    [TestClass]
    public class StronaTest
    {
        [TestMethod]
        public void StronaA0_ShouldBeLoadedFromJpg()
        {
            var fileName = "A0.jpg".GetSamplePath();
            var strona = fileName.ReadStronaFromBitmap();
            strona.Plik.ShouldBe(fileName);
            strona.Numer.ShouldBe(1);
            strona.Szerokość.Pixels.ShouldBe(13071);
            strona.Wysokość.Pixels.ShouldBe(5084);
            strona.Szerokość.Mm.ShouldBe(830);
            strona.Wysokość.Mm.ShouldBe(323);
            strona.Szerokość.Cm.ShouldBe(83);
            strona.Wysokość.Cm.ShouldBe(32);
            strona.Szerokość.Rozdzielczość.ShouldBe(400);
            strona.Wysokość.Rozdzielczość.ShouldBe(400);
        }

        [TestMethod]
        public void StronaA4_ShouldBeLoadedFromJpg()
        {
            var fileName = "A4.jpg".GetSamplePath();
            var strona = fileName.ReadStronaFromBitmap();
            strona.Plik.ShouldBe(fileName);
            strona.Numer.ShouldBe(1);
            strona.Szerokość.Mm.ShouldBe(210);
            strona.Wysokość.Mm.ShouldBe(297);
            strona.Szerokość.Rozdzielczość.ShouldBe(300);
            strona.Wysokość.Rozdzielczość.ShouldBe(300);
        }

        [TestMethod]
        public void Strona_ShouldBeEmpty()
        {
            var strona = new StronaObrazu { };
            strona.Plik.ShouldBeNull();
            strona.Numer.ShouldBe(0);
            strona.Szerokość.ShouldBeNull();
            strona.Wysokość.ShouldBeNull();
        }
    }
}
