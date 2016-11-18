using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4.Domena;
using StronyA4.Domena.Repozytoria;
using iTextSharp.text.exceptions;

namespace PoliczStrony.Testy.PoliczStronyA4
{
    [TestClass]
    public class CzytnikStronPdfTest
    {
        [TestMethod]
        public void test_czy_plik_pdf_zawiera_14_stron_A4()
        {
            var fileName = Path.Combine(@"..\..\Samples", "CzytnikStronPdfTest_14.pdf");
            var czytnik = new CzytnikStronPdf(fileName);
            Assert.AreEqual(14, czytnik.LiczbaStron);
            var nr = 0;
            foreach (var strona in czytnik.Strony)
            {
                Assert.AreEqual(@"..\..\Samples\CzytnikStronPdfTest_14.pdf", strona.Plik);
                Assert.AreEqual(++nr, strona.Numer);
                //Assert.AreEqual(595, strona.Punkty.Szerokość);
                //Assert.AreEqual(842, strona.Punkty.Wysokość);
                Assert.AreEqual(210, strona.Rozmiar.Szerokość);
                Assert.AreEqual(297, strona.Rozmiar.Wysokość);

            }
        }

        [TestMethod]
        public void test_czy_plik_pdf_zawiera_1_stronę_A4()
        {
            var fileName = Path.Combine(@"..\..\Samples", "CzytnikStronPdfTest_1.pdf");
            var czytnik = new CzytnikStronPdf(fileName);
            Assert.AreEqual(1, czytnik.LiczbaStron);
            var nr = 0;
            foreach (var strona in czytnik.Strony)
            {
                Assert.AreEqual(@"..\..\Samples\CzytnikStronPdfTest_1.pdf", strona.Plik);
                Assert.AreEqual(++nr, strona.Numer);
                //Assert.AreEqual(595, strona.Punkty.Szerokość);
                //Assert.AreEqual(842, strona.Punkty.Wysokość);
                Assert.AreEqual(210, strona.Rozmiar.Szerokość);
                Assert.AreEqual(297, strona.Rozmiar.Wysokość);

            }
        }

        [TestMethod, ExpectedException(typeof(InvalidPdfException))]
        public void test_czy_niepoprawny_plik_pdf_rzuci_wyjątek()
        {
            var fileName = Path.Combine(@"..\..\Samples", "CzytnikStronPdfTest_0.pdf");
            var czytnik = new CzytnikStronPdf(fileName);
            Assert.Fail();
        }
    }
}
