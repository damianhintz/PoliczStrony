using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4.Domena;
using Shouldly;

namespace PoliczStrony.Testy
{
    [TestClass]
    public class KlasyfikatorStronyTest
    {
        [TestMethod]
        public void test_czy_suma_stron_A4_w_pliku_wynosi_66016()
        {
            var analizator = new MetrycznyKlasyfikatorStrony();
            var fileName = Path.Combine(@"..\..\Samples", "KlasyfikatorStronyTest.tab");
            var linie = File.ReadAllLines(fileName, Encoding.GetEncoding(1250));
            var sumaStron = linie.Length - 1;
            var sumaStronA4 = 0.0;
            var formaty = new Dictionary<string, int>();
            formaty.Add("A0", 0);
            formaty.Add("A1", 0);
            formaty.Add("A2", 0);
            formaty.Add("A3", 0);
            formaty.Add("A4", 0);
            foreach (var linia in linie.Skip(1))
            {
                var pola = linia.Split('\t');
                var szerokość = int.Parse(pola[4]);
                var wysokość = int.Parse(pola[5]);
                var rozmiarStrony = new RozmiarStrony
                {
                    Szerokość = szerokość,
                    Wysokość = wysokość
                };
                var formatStrony = analizator.UstalFormatStrony(rozmiarStrony);
                sumaStronA4 += formatStrony.StronyA4;
                formaty[formatStrony.Nazwa]++;
            }
            Assert.AreEqual(63553, sumaStron);
            Assert.AreEqual(66016, sumaStronA4);
            Assert.AreEqual(0, formaty["A0"]);
            Assert.AreEqual(20, formaty["A1"]);
            Assert.AreEqual(5, formaty["A2"]);
            Assert.AreEqual(2308, formaty["A3"]);
            Assert.AreEqual(61220, formaty["A4"]);
        }

        [TestMethod]
        public void test_czy_strona_297x210_jest_formatu_A4()
        {
            var rozmiar = new RozmiarStrony
            {
                Szerokość = 297,
                Wysokość = 210
            };
            var analizator = new MetrycznyKlasyfikatorStrony();
            var format = analizator.UstalFormatStrony(rozmiar);
            Assert.AreEqual("A4", format.Nazwa);
            Assert.AreEqual(1, format.StronyA4);
            Assert.AreEqual(1, format.EfektywneStronyA4);
        }

        [TestMethod]
        public void test_czy_strona_210x297_jest_formatu_A4()
        {
            var rozmiar = new RozmiarStrony
            {
                Szerokość = 210,
                Wysokość = 297
            };
            var analizator = new MetrycznyKlasyfikatorStrony();
            var format = analizator.UstalFormatStrony(rozmiar);
            Assert.AreEqual("A4", format.Nazwa);
            Assert.AreEqual(1, format.StronyA4);
            Assert.AreEqual(1, format.EfektywneStronyA4);
        }

        [TestMethod]
        public void test_czy_strona_420x297_jest_formatu_A3()
        {
            var rozmiar = new RozmiarStrony
            {
                Szerokość = 420,
                Wysokość = 297
            };
            var analizator = new MetrycznyKlasyfikatorStrony();
            var format = analizator.UstalFormatStrony(rozmiar);
            Assert.AreEqual("A3", format.Nazwa);
            Assert.AreEqual(2, format.StronyA4);
            Assert.AreEqual(2, format.EfektywneStronyA4);
        }

        [TestMethod]
        public void test_czy_strona_297x420_jest_formatu_A3()
        {
            var rozmiar = new RozmiarStrony
            {
                Szerokość = 297,
                Wysokość = 420
            };
            var analizator = new MetrycznyKlasyfikatorStrony();
            var format = analizator.UstalFormatStrony(rozmiar);
            Assert.AreEqual("A3", format.Nazwa);
            Assert.AreEqual(2, format.StronyA4);
            Assert.AreEqual(2, format.EfektywneStronyA4);
        }

        [TestMethod]
        public void test_czy_strona_594x420_jest_formatu_A2()
        {
            var rozmiar = new RozmiarStrony
            {
                Szerokość = 594,
                Wysokość = 420
            };
            var analizator = new MetrycznyKlasyfikatorStrony();
            var format = analizator.UstalFormatStrony(rozmiar);
            Assert.AreEqual("A2", format.Nazwa);
            Assert.AreEqual(4, format.StronyA4);
            Assert.AreEqual(4, format.EfektywneStronyA4);
        }

        [TestMethod]
        public void test_czy_strona_840x594_jest_formatu_A1()
        {
            var rozmiar = new RozmiarStrony
            {
                Szerokość = 840,
                Wysokość = 594
            };
            var analizator = new MetrycznyKlasyfikatorStrony();
            var format = analizator.UstalFormatStrony(rozmiar);
            Assert.AreEqual("A1", format.Nazwa);
            Assert.AreEqual(8, format.StronyA4);
            Assert.AreEqual(8, format.EfektywneStronyA4);
        }
    }
}
