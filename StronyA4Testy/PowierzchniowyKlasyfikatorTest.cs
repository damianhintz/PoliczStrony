using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4.Domena.Klasyfikacja;
using System.Linq;
using Shouldly;
using StronyA4.Domena.Encje.Rozszerzenia;
using StronyA4.Domena.Encje;

namespace StronyA4Testy
{
    [TestClass]
    public class PowierzchniowyKlasyfikatorTest
    {
        [TestMethod]
        public void PowierzchniowyKlasyfikator_ShouldClassify1748x2480AsA5()
        {
            var rozmiar = RozmiarStrony.RozmiarFromPixels(1748, 2480, 300, 300);
            var analizator = new PowierzchniowyKlasyfikatorStrony();
            analizator.DodajFormat(StandardoweFormaty.FormatA5);
            var format = analizator.UstalFormatStrony(rozmiar);
            format.StronyA4.ShouldBe(0.5, 0.01);
            format.Nazwa.ShouldBe("A5");
            
        }

        [TestMethod]
        public void PowierzchniowyKlasyfikator_ShouldClassify4960x3507AsA3()
        {
            var rozmiar = RozmiarStrony.RozmiarFromPixels(4960, 3507, 300, 300);
            var analizator = new PowierzchniowyKlasyfikatorStrony();
            var format = analizator.UstalFormatStrony(rozmiar);
            format.Nazwa.ShouldBe("A3");
            format.StronyA4.ShouldBe(2, 0.01);
        }

        [TestMethod]
        public void PowierzchniowyKlasyfikator_ShouldContainAddedFormat()
        {
            var klasyfikator = new PowierzchniowyKlasyfikatorStrony();
            klasyfikator.Formaty.Count().ShouldBe(5);
            klasyfikator.DodajFormat(StandardoweFormaty.Format2A0);
            klasyfikator.Formaty.Count().ShouldBe(6);
            klasyfikator.Formaty.ShouldContain(StandardoweFormaty.Format2A0);
            var format = klasyfikator.UstalFormatStrony(StandardoweFormaty.Format2A0);
            format.StronyA4.ShouldBe(32, 0.1);
            format.Nazwa.ShouldBe("2A0");
        }

        [TestMethod]
        public void PowierzchniowyKlasyfikator_ShouldContain5DefaultFormats()
        {
            var klasyfikator = new PowierzchniowyKlasyfikatorStrony();
            //klasyfikator.Formaty.ShouldBeEmpty();
            klasyfikator.Formaty.Count().ShouldBe(5);
            klasyfikator.Formaty.ShouldContain(StandardoweFormaty.FormatA0);
            klasyfikator.Formaty.ShouldContain(StandardoweFormaty.FormatA1);
            klasyfikator.Formaty.ShouldContain(StandardoweFormaty.FormatA2);
            klasyfikator.Formaty.ShouldContain(StandardoweFormaty.FormatA3);
            klasyfikator.Formaty.ShouldContain(StandardoweFormaty.FormatA4);
        }

    }
}
