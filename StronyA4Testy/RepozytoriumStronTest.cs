using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StronyA4Domena.Repozytoria;
using StronyA4Domena.Repozytoria.Rozszerzenia;
using Shouldly;
using StronyA4Domena.Klasyfikacja;
using System.Text;
using StronyA4Domena.Encje;
using StronyA4Domena.Encje.Rozszerzenia;
using System.IO;

namespace StronyA4Testy
{
    [TestClass]
    public class RepozytoriumStronTest
    {
        [TestMethod]
        public void RepozytoriumStron_ShouldBeEmpty()
        {
            var strony = new RepozytoriumStron();
            strony.Strony.ShouldBeEmpty();
            strony.Pliki.ShouldBeEmpty();
        }

        [TestMethod]
        public void RepozytoriumStron_ShouldClassify66016A4Pages()
        {
            var strony = new RepozytoriumStron();
            var czytnik = new CzytnikRepozytorium(strony);
            var fileName = "KlasyfikatorStronyTest.tab".GetSamplePath();
            czytnik.Wczytaj(fileName);
            var sumaStron = strony.Strony.Count();
            sumaStron.ShouldBe(63553);
            var sumaStronA4 = strony.SumaStronA4Metrycznie();
            sumaStronA4.ShouldBe(66016);
            var zestawienie = strony.ZestawienieStronA4Metrycznie();
            var sumaZestawienia = zestawienie.Sum(entry => entry.Value.Count);
            sumaZestawienia.ShouldBe(sumaStron);
            zestawienie["A0"].Count.ShouldBe(0);
            zestawienie["A1"].Count.ShouldBe(20); //20
            zestawienie["A2"].Count.ShouldBe(5); //5
            zestawienie["A3"].Count.ShouldBe(2308); //2308
            zestawienie["A4"].Count.ShouldBe(61220);
        }

        [TestMethod]
        public void RepozytoriumStron_ShouldEksport63553Pages()
        {
            var strony = new RepozytoriumStron();
            var czytnik = new CzytnikRepozytorium(strony);
            var fileName = "KlasyfikatorStronyTest.tab".GetSamplePath();
            czytnik.Wczytaj(fileName);
            var sumaStron = strony.Strony.Count();
            sumaStron.ShouldBe(63553);
            var sumaStronA4 = strony.SumaStronA4Metrycznie();
            sumaStronA4.ShouldBe(66016);
            var zestawienie = strony.ZestawienieStronA4Metrycznie();
            var sumaZestawienia = zestawienie.Sum(entry => entry.Value.Count);
            sumaZestawienia.ShouldBe(sumaStron);
            zestawienie["A0"].Count.ShouldBe(0);
            zestawienie["A1"].Count.ShouldBe(20); //20
            zestawienie["A2"].Count.ShouldBe(5); //5
            zestawienie["A3"].Count.ShouldBe(2308); //2308
            zestawienie["A4"].Count.ShouldBe(61220);
            var writer = new EksporterRepozytorium(strony);
            var result = writer.ZapiszZmiany("Strony.log");
            result.Count().ShouldBe(63553);
        }
    }
}
