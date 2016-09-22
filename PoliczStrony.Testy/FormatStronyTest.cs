using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoliczStronyA4.Domena;

namespace PoliczStrony.Testy.PoliczStronyA4
{
    [TestClass]
    public class FormatStronyTest
    {
        [TestMethod]
        public void test_czy_jest_nieokreślonny_format_strony()
        {
            var format = new FormatStrony();
            Assert.AreEqual("Nieokreślony format", format.Nazwa);
            Assert.AreEqual(0, format.StronyA4);
            Assert.AreEqual(0, format.EfektywneStronyA4);
            Assert.AreEqual("Nieokreślony format", format.ToString());
        }

        [TestMethod]
        public void test_czy_jest_określonny_format_strony()
        {
            var format = new FormatStrony("A4");
            Assert.AreEqual("A4", format.Nazwa);
            Assert.AreEqual(0, format.StronyA4);
            Assert.AreEqual(0, format.EfektywneStronyA4);
            Assert.AreEqual("A4", format.ToString());
        }
    }
}
