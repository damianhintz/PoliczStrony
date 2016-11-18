using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4.Domena;
using Shouldly;

namespace PoliczStrony.Testy.PoliczStronyA4
{
    [TestClass]
    public class FormatStronyTest
    {
        [TestMethod]
        public void FormatStrony_ShouldBeUndefined()
        {
            var format = new FormatStrony();
            format.Nazwa.ShouldBeNull();
            format.Rozmiar.ShouldBeNull();
            format.StronyA4.ShouldBe(0);
            format.EfektywneStronyA4.ShouldBe(0);
        }

        [TestMethod]
        public void FormatStrony_ShouldEfektywneStronyA4()
        {
            var format = new FormatStrony { StronyA4 = 1 };
            format.Nazwa.ShouldBeNull();
            format.Rozmiar.ShouldBeNull();
            format.StronyA4.ShouldBe(1);
            format.EfektywneStronyA4.ShouldBe(1);
        }
    }
}
