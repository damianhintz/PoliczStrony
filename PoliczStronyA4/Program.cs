using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using StronyA4.Domena;
using StronyA4.Domena.Abstrakcje;
using StronyA4.Domena.Repozytoria;

namespace StronyA4
{
    class Program
    {
        static string _roboczyKatalog;
        static string[] _pliki;
        readonly Encoding _kodowanie;
        static IKlasyfikatorStrony analizator = new MetrycznyKlasyfikatorStrony();
        static List<string> _błędy = new List<string>();

        public Program(string roboczyKatalog, int stronaKodowa)
        {
            _roboczyKatalog = roboczyKatalog;
            _pliki = Directory.GetFiles(_roboczyKatalog, "*.pdf", SearchOption.AllDirectories);
            _kodowanie = Encoding.GetEncoding(stronaKodowa);
        }

        static void PokażLogo()
        {
            Console.WriteLine("PoliczStronyA4 v1.3.2 - Policz strony A4 w plikach pdf");
            Console.WriteLine("Data publikacji: 21 września 2015");
            Console.WriteLine("Roboczy katalog: {0}", _roboczyKatalog == null ? "nie określono katalogu, obliczanie z pliku tab" : _roboczyKatalog);
        }

        static void Main(string[] args)
        {
            PokażLogo();
            if (args.Length == 0)
            {
                PoliczStronyZPliku();
            }
            else
            {
                var program = new Program(args[0], 1250);
                PoliczStronyWKatalogu();
            }
            Console.WriteLine("Koniec.");
            Console.Read();
        }

        static void PoliczStronyWKatalogu()
        {
            var strony = new PlikoweRepozytoriumStron("PoliczStronyA4.tab");
            var czytnik = new CzytnikPlikówPdf(strony);
            czytnik.Wczytaj(_roboczyKatalog);
            strony.ZapiszZmiany();
            Console.WriteLine("Podsumowanie:");
            Console.WriteLine("Liczba plików: {0}", strony.Pliki.Count());
            Console.WriteLine("Suma stron: {0}", strony.Strony.Count());
            //Console.WriteLine("Suma stron A4: {0}", zliczacz.SumaStronA4);
            if (_błędy.Count > 0)
            {
                Console.WriteLine("Błędy: {0} (error.log)", _błędy.Count);
                File.WriteAllLines("error.log", _błędy);
            }
        }

        static void PoliczStronyZPliku()
        {
            var linie = File.ReadAllLines("PoliczStronyA4.tab", Encoding.GetEncoding(1250));
            var sumaStronA4 = 0.0;
            var formaty = new Dictionary<string, int>();
            formaty.Add("A0", 0);
            formaty.Add("A1", 0);
            formaty.Add("A2", 0);
            formaty.Add("A3", 0);
            formaty.Add("A4", 0);
            var lines = new List<string>();
            foreach (var linia in linie.Skip(1))
            {
                var pola = linia.Split('\t');
                var szerokośćMilimetry = int.Parse(pola[4]);
                var wysokośćMilimetry = int.Parse(pola[5]);
                var rozmiarStrony = new RozmiarStrony
                {
                    Szerokość = szerokośćMilimetry,
                    Wysokość = wysokośćMilimetry
                };
                var formatStrony = analizator.UstalFormatStrony(rozmiarStrony);
                sumaStronA4 += formatStrony.StronyA4;
                formaty[formatStrony.Nazwa]++;
                lines.Add(string.Format("{0:F0}\t{1:F0}",
                    Math.Max(szerokośćMilimetry, wysokośćMilimetry),
                    Math.Min(szerokośćMilimetry, wysokośćMilimetry)));
            }
            File.WriteAllLines("PoliczStronyA4.log", lines, Encoding.GetEncoding(1250));
            Console.WriteLine("Suma stron: {0}", linie.Length - 1);
            Console.WriteLine("Suma stron A4: {0}", sumaStronA4);
            Console.WriteLine("Stron[y] formatu A0: {0}", formaty["A0"]);
            Console.WriteLine("Stron[y] formatu A1: {0}", formaty["A1"]);
            Console.WriteLine("Stron[y] formatu A2: {0}", formaty["A2"]);
            Console.WriteLine("Stron[y] formatu A3: {0}", formaty["A3"]);
            Console.WriteLine("Stron[y] formatu A4: {0}", formaty["A4"]);
            Console.WriteLine("Koniec.");
            Console.Read();
        }
    }
}
