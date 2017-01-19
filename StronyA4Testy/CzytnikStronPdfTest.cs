using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4Domena;
using StronyA4Domena.Repozytoria;
using iTextSharp.text.exceptions;
using Shouldly;

namespace StronyA4Testy
{
    [TestClass]
    public class CzytnikStronPdfTest
    {
        [TestMethod]
        public void CzytnikStron_ShouldRead14PagesA4()
        {
            var fileName = "CzytnikStronPdfTest_14.pdf".GetSamplePath();
            var czytnik = new CzytnikStronPdf(fileName);
            czytnik.Strony.Count().ShouldBe(14);
            var nr = 1;
            foreach (var strona in czytnik.Strony)
            {
                strona.Plik.ShouldBe(fileName);
                strona.Numer.ShouldBe(nr++);
                strona.Szerokość.Mm.ShouldBe(210);
                strona.Wysokość.Mm.ShouldBe(297);
                //Assert.AreEqual(595, strona.Punkty.Szerokość);
                //Assert.AreEqual(842, strona.Punkty.Wysokość);
            }
        }

        [TestMethod]
        public void CzytnikStron_ShouldRead1PageA4()
        {
            var fileName = "CzytnikStronPdfTest_1.pdf".GetSamplePath();
            var czytnik = new CzytnikStronPdf(fileName);
            czytnik.Strony.Count().ShouldBe(1);
            var nr = 0;
            foreach (var strona in czytnik.Strony)
            {
                strona.Plik.ShouldBe(fileName);
                strona.Numer.ShouldBe(++nr);
                strona.Szerokość.Mm.ShouldBe(210);
                strona.Wysokość.Mm.ShouldBe(297);
            }
        }

        [TestMethod]
        public void CzytnikStron_ShouldThrowInvalidPdf()
        {
            var fileName = "CzytnikStronPdfTest_0.pdf".GetSamplePath();
            Should.Throw<InvalidPdfException>(() => new CzytnikStronPdf(fileName));
        }
    }
}
