using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4.Domena;
using iTextSharp.text.exceptions;

namespace PoliczStrony.Testy.PoliczStronyA4
{
    [TestClass]
    public class CzytnikStronPdfTest
    {
        [TestMethod]
        public void test_czy_plik_pdf_zawiera_14_stron_A4()
        {
            var fileName = Path.Combine(@"..\..", "CzytnikStronPdfTest_14.pdf");
            var czytnik = new CzytnikStronPdf(fileName);
            Assert.AreEqual(14, czytnik.LiczbaStron);
            var nr = 0;
            foreach (var strona in czytnik.Strony)
            {
                Assert.AreEqual(@"..\..\CzytnikStronPdfTest_14.pdf", strona.FileName);
                Assert.AreEqual(++nr, strona.NumerStrony);
                Assert.AreEqual(595, strona.RozmiarPunkty.Szerokość);
                Assert.AreEqual(842, strona.RozmiarPunkty.Wysokość);
                Assert.AreEqual(210, strona.RozmiarMilimetry.Szerokość);
                Assert.AreEqual(297, strona.RozmiarMilimetry.Wysokość);

            }
        }

        [TestMethod]
        public void test_czy_plik_pdf_zawiera_1_stronę_A4()
        {
            var fileName = Path.Combine(@"..\..", "CzytnikStronPdfTest_1.pdf");
            var czytnik = new CzytnikStronPdf(fileName);
            Assert.AreEqual(1, czytnik.LiczbaStron);
            var nr = 0;
            foreach (var strona in czytnik.Strony)
            {
                Assert.AreEqual(@"..\..\CzytnikStronPdfTest_1.pdf", strona.FileName);
                Assert.AreEqual(++nr, strona.NumerStrony);
                Assert.AreEqual(595, strona.RozmiarPunkty.Szerokość);
                Assert.AreEqual(842, strona.RozmiarPunkty.Wysokość);
                Assert.AreEqual(210, strona.RozmiarMilimetry.Szerokość);
                Assert.AreEqual(297, strona.RozmiarMilimetry.Wysokość);

            }
        }

        [TestMethod, ExpectedException(typeof(InvalidPdfException))]
        public void test_czy_niepoprawny_plik_pdf_rzuci_wyjątek()
        {
            var fileName = Path.Combine(@"..\..", "CzytnikStronPdfTest_0.pdf");
            var czytnik = new CzytnikStronPdf(fileName);
            Assert.Fail();
        }
    }
}
