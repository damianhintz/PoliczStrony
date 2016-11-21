using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using StronyA4.Domena.Abstrakcje;
using StronyA4.Domena.Encje;
using StronyA4.Domena.Encje.Rozszerzenia;
using StronyA4.Domena.Repozytoria;
using StronyA4.Domena.Repozytoria.Rozszerzenia;

namespace StronyJpg
{
    class Program
    {
        static void Main(string[] args)
        {
            var strony = new RepozytoriumStron();
            var czytnik = new CzytnikPlikówJpg(strony);
            czytnik.Wczytaj(@"s:\2903_skanowanie Bartoszyce\skanowanie\");
            Console.WriteLine("Pliki (*.jpg): {0}", czytnik.Pliki.Count());
            Console.WriteLine("Suma stron A4 (metrycznie): {0}", strony.SumaStronA4Metrycznie());
            Console.WriteLine("Suma stron A4 (powierzchniowo): {0}", strony.SumaStronA4Powierzchniowo());
            //Console.WriteLine("Odczytane pliki: {0}/{1}", _strony.Count, files.Length);
            //Console.WriteLine("Pominięte pliki: {0}", errors.Count);
            //File.WriteAllLines("StronyA4.tab", _strony.Select(m => m.Plik + "\t" + m.Szerokość + "\t" + m.Wysokość));
            Console.WriteLine("Koniec.");
            Console.Read();
        }

    }
}
