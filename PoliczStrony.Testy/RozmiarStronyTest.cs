using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoliczStronyA4.Domena;

namespace PoliczStrony.Testy.PoliczStronyA4
{
    [TestClass]
    public class RozmiarStronyTest
    {
        [TestMethod]
        public void test_czy_rozmiar_strony_jest_ok()
        {
            var rozmiar = new RozmiarStrony(szerokość: 1, wysokość: 2);
            Assert.AreEqual(1, rozmiar.Szerokość);
            Assert.AreEqual(2, rozmiar.Wysokość);
        }
    }
}
