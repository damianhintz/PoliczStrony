using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4.Domena;

namespace PoliczStrony.Testy.PoliczStronyA4
{
    [TestClass]
    public class StronaPdfTest
    {
        [TestMethod]
        public void test_czy_strona_pdf_jest_ok()
        {
            var strona = new StronaPdf(fileName: "test.pdf");
            Assert.AreEqual("test.pdf", strona.FileName);
            Assert.AreEqual(0, strona.NumerStrony);
            Assert.IsNull(strona.RozmiarPunkty);
            Assert.IsNull(strona.RozmiarMilimetry);
        }
    }
}
