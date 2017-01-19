using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4Domena;
using StronyA4Domena.Encje;
using StronyA4Domena.Encje.Rozszerzenia;
using StronyA4Domena.Klasyfikacja;
using StronyA4Domena.Repozytoria;
using StronyA4Domena.Repozytoria.Rozszerzenia;
using Shouldly;

namespace StronyA4Testy
{
    [TestClass]
    public class MetrycznyKlasyfikatorTest
    {
        [TestMethod]
        public void MetrycznyKlasyfikator_ShouldContainAddedFormat()
        {
            var klasyfikator = new MetrycznyKlasyfikatorStrony();
            klasyfikator.Formaty.Count().ShouldBe(5);
            klasyfikator.DodajFormat(StandardoweFormaty.Format2A0);
            klasyfikator.Formaty.Count().ShouldBe(6);
            klasyfikator.Formaty.ShouldContain(StandardoweFormaty.Format2A0);
            klasyfikator.UstalFormatStrony(StandardoweFormaty.Format2A0)
                .ShouldBe(StandardoweFormaty.Format2A0);
        }

        [TestMethod]
        public void MetrycznyKlasyfikator_ShouldContain5DefaultFormats()
        {
            var klasyfikator = new MetrycznyKlasyfikatorStrony();
            //klasyfikator.Formaty.ShouldBeEmpty();
            klasyfikator.Formaty.Count().ShouldBe(5);
            klasyfikator.Formaty.ShouldContain(StandardoweFormaty.FormatA0);
            klasyfikator.Formaty.ShouldContain(StandardoweFormaty.FormatA1);
            klasyfikator.Formaty.ShouldContain(StandardoweFormaty.FormatA2);
            klasyfikator.Formaty.ShouldContain(StandardoweFormaty.FormatA3);
            klasyfikator.Formaty.ShouldContain(StandardoweFormaty.FormatA4);
        }

        [TestMethod]
        public void MetrycznyKlasyfikator_ShouldClassify297x210AsA4()
        {
            var rozmiar = RozmiarStrony.RozmiarFromMm(210, 297);
            var analizator = new MetrycznyKlasyfikatorStrony();
            var format = analizator.UstalFormatStrony(rozmiar);
            format.Nazwa.ShouldBe("A4");
            format.StronyA4.ShouldBe(1);
        }

        [TestMethod]
        public void MetrycznyKlasyfikator_ShouldClassify210x297AsA4()
        {
            var rozmiar = RozmiarStrony.RozmiarFromMm(297, 210);
            var analizator = new MetrycznyKlasyfikatorStrony();
            var format = analizator.UstalFormatStrony(rozmiar);
            format.Nazwa.ShouldBe("A4");
            format.StronyA4.ShouldBe(1);
        }

        [TestMethod]
        public void test_czy_strona_420x297_jest_formatu_A3()
        {
            var rozmiar = RozmiarStrony.RozmiarFromMm(297, 420);
            var analizator = new MetrycznyKlasyfikatorStrony();
            var format = analizator.UstalFormatStrony(rozmiar);
            Assert.AreEqual("A3", format.Nazwa);
            Assert.AreEqual(2, format.StronyA4);
            Assert.AreEqual(2, format.EfektywneStronyA4);
        }

        [TestMethod]
        public void test_czy_strona_297x420_jest_formatu_A3()
        {
            var rozmiar = RozmiarStrony.RozmiarFromMm(420, 297);
            var analizator = new MetrycznyKlasyfikatorStrony();
            var format = analizator.UstalFormatStrony(rozmiar);
            Assert.AreEqual("A3", format.Nazwa);
            Assert.AreEqual(2, format.StronyA4);
            Assert.AreEqual(2, format.EfektywneStronyA4);
        }

        [TestMethod]
        public void test_czy_strona_594x420_jest_formatu_A2()
        {
            var rozmiar = RozmiarStrony.RozmiarFromMm(420, 594);
            var analizator = new MetrycznyKlasyfikatorStrony();
            var format = analizator.UstalFormatStrony(rozmiar);
            Assert.AreEqual("A2", format.Nazwa);
            Assert.AreEqual(4, format.StronyA4);
            Assert.AreEqual(4, format.EfektywneStronyA4);
        }

        [TestMethod]
        public void test_czy_strona_840x594_jest_formatu_A1()
        {
            var rozmiar = RozmiarStrony.RozmiarFromMm(594, 840);
            var analizator = new MetrycznyKlasyfikatorStrony();
            var format = analizator.UstalFormatStrony(rozmiar);
            Assert.AreEqual("A1", format.Nazwa);
            Assert.AreEqual(8, format.StronyA4);
            Assert.AreEqual(8, format.EfektywneStronyA4);
        }
    }
}
