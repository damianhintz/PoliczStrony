using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4.Domena;
using StronyA4.Domena.Encje;
using Shouldly;

namespace PoliczStrony.Testy
{
    [TestClass]
    public class StronaTest
    {
        [TestMethod]
        public void Strona_ShouldBeEmpty()
        {
            var strona = new StronaObrazu { };
            strona.Plik.ShouldBeNull();
            strona.Numer.ShouldBe(0);
            strona.Rozmiar.ShouldBeNull();
            //Assert.IsNull(strona.Punkty);
        }
    }
}
