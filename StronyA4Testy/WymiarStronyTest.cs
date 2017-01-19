using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4Domena;
using StronyA4Domena.Encje;
using StronyA4Domena.Encje.Rozszerzenia;
using Shouldly;

namespace StronyA4Testy
{
    [TestClass]
    public class WymiarStronyTest
    {
        [TestMethod]
        public void Odległość_ShouldBeA4CloserToA1ThanToA0()
        {
            var a4 = StandardoweFormaty.FormatA4;
            var a1 = StandardoweFormaty.FormatA1;
            var a0 = StandardoweFormaty.FormatA0;
            var odległość1 = a4.OdległośćPixelowa(a1);
            var odległość0 = a4.OdległośćPixelowa(a0);
            odległość1.ShouldBeLessThan(odległość0);
        }

        [TestMethod]
        public void Odległość_ShouldBeA4CloserToA2ThanToA1()
        {
            var a4 = StandardoweFormaty.FormatA4;
            var a1 = StandardoweFormaty.FormatA1;
            var a2 = StandardoweFormaty.FormatA2;
            var odległość1 = a4.OdległośćPixelowa(a1);
            var odległość2 = a4.OdległośćPixelowa(a2);
            odległość2.ShouldBeLessThan(odległość1);
        }

        [TestMethod]
        public void Odległość_ShouldBeA4CloserToA3ThanToA2()
        {
            var a4 = StandardoweFormaty.FormatA4;
            var a3 = StandardoweFormaty.FormatA3;
            var a2 = StandardoweFormaty.FormatA2;
            var odległość3 = a4.OdległośćPixelowa(a3);
            var odległość2 = a4.OdległośćPixelowa(a2);
            odległość3.ShouldBeLessThan(odległość2);
        }

        [TestMethod]
        public void Odległość_ShouldBeA4CloserToA5ThanToA6()
        {
            var a4 = StandardoweFormaty.FormatA4;
            var a5 = StandardoweFormaty.FormatA5;
            var a6 = StandardoweFormaty.FormatA6;
            var odległość5 = a4.OdległośćPixelowa(a5);
            var odległość6 = a4.OdległośćPixelowa(a6);
            odległość5.ShouldBeLessThan(odległość6);
        }

        [TestMethod]
        public void OdległośćPixelowa_ShouldBeGreaterThan0()
        {
            var r1 = new RozmiarStrony
            {
                Szerokość = 210.WymiarFromMm(),
                Wysokość = 297.WymiarFromMm()
            };
            var r2 = new RozmiarStrony
            {
                Szerokość = 211.WymiarFromMm(),
                Wysokość = 298.WymiarFromMm()
            };
            var odległość = r1.OdległośćPixelowa(r2);
            odległość.ShouldBeGreaterThan(0);
        }

        [TestMethod]
        public void OdległośćPixelowa_ShouldBe0()
        {
            var r1 = new RozmiarStrony
            {
                Szerokość = 210.WymiarFromMm(),
                Wysokość = 297.WymiarFromMm()
            };
            var r2 = new RozmiarStrony
            {
                Szerokość = 210.WymiarFromMm(),
                Wysokość = 297.WymiarFromMm()
            };
            var odległość = r1.OdległośćPixelowa(r2);
            odległość.ShouldBe(0);
        }

        [TestMethod]
        public void WymiarStrony_ShouldBe210()
        {
            var wymiar = 210.WymiarFromMm();
            wymiar.Rozdzielczość.ShouldBe(300);
            wymiar.Pixels.ShouldBe(2480);
            wymiar.Mm.ShouldBe(210);
            wymiar.Cm.ShouldBe(21);
        }

        [TestMethod]
        public void RozmiarStrony_ShouldBe210x297()
        {
            var rozmiar = new RozmiarStrony
            {
                Szerokość = 210.WymiarFromMm(),
                Wysokość = 297.WymiarFromMm()
            };
            rozmiar.Szerokość.Mm.ShouldBe(210);
            rozmiar.Szerokość.Rozdzielczość.ShouldBe(300);
            rozmiar.Wysokość.Mm.ShouldBe(297);
            rozmiar.Wysokość.Rozdzielczość.ShouldBe(300);
        }
    }
}
