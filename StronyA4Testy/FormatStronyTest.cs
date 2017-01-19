using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4.Domena;
using StronyA4.Domena.Encje;
using StronyA4.Domena.Encje.Rozszerzenia;
using Shouldly;

namespace StronyA4Testy
{
    [TestClass]
    public class FormatStronyTest
    {
        [TestMethod]
        public void FormatStrony_ShouldBeA4()
        {
            var format = StandardoweFormaty.FormatA4;
            format.Nazwa.ShouldBe("A4");
            format.StronyA4.ShouldBe(1);
            format.EfektywneStronyA4.ShouldBe(1);
            format.Szerokość.Mm.ShouldBe(210);
            format.Wysokość.Mm.ShouldBe(297);
            format.Szerokość.Pixels.ShouldBe(2480);
            format.Wysokość.Pixels.ShouldBe(3508);
        }

        [TestMethod]
        public void FormatStrony_ShouldBe2A0()
        {
            var format = StandardoweFormaty.Format2A0;
            format.Nazwa.ShouldBe("2A0");
            format.Szerokość.ShouldNotBeNull();
            format.Wysokość.ShouldNotBeNull();
            format.StronyA4.ShouldBe(32);
            format.EfektywneStronyA4.ShouldBe(32);
            format.Szerokość.Mm.ShouldBe(1189);
            format.Wysokość.Mm.ShouldBe(1682);
            format.Szerokość.Pixels.ShouldBe(14043);
            format.Wysokość.Pixels.ShouldBe(19866);
        }

        [TestMethod]
        public void FormatStrony_ShouldBeUndefined()
        {
            var format = new FormatStrony();
            format.Nazwa.ShouldBeNull();
            format.Szerokość.ShouldBeNull();
            format.Wysokość.ShouldBeNull();
            format.StronyA4.ShouldBe(0);
            format.EfektywneStronyA4.ShouldBe(0);
        }

        [TestMethod]
        public void FormatStrony_ShouldEfektywneStronyA4()
        {
            var format = new FormatStrony { StronyA4 = 1 };
            format.Nazwa.ShouldBeNull();
            format.StronyA4.ShouldBe(1);
            format.EfektywneStronyA4.ShouldBe(1);
        }
    }
}
