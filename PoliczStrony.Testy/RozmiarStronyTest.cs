using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4.Domena;
using Shouldly;

namespace PoliczStrony.Testy
{
    [TestClass]
    public class RozmiarStronyTest
    {
        [TestMethod]
        public void RozmiarStrony_ShouldBeUndefined()
        {
            var rozmiar = new RozmiarStrony();
            rozmiar.Szerokość.ShouldBe(0);
            rozmiar.Wysokość.ShouldBe(0);
        }

        [TestMethod]
        public void RozmiarStrony_ShouldBeSet()
        {
            var rozmiar = new RozmiarStrony
            {
                Szerokość = 1,
                Wysokość = 2
            };
            Assert.AreEqual(1, rozmiar.Szerokość);
            Assert.AreEqual(2, rozmiar.Wysokość);
        }
    }
}
