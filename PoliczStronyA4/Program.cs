using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using PoliczStronyA4.Domena;

namespace PoliczStronyA4
{
    class Program
    {
        static string _roboczyKatalog;
        static string[] _pliki;
        readonly Encoding _kodowanie;
        static IAnalizatorFormatuStrony analizator = new MetrycznyAnalizatorFormatuStrony();
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
            var zliczacz = new ZliczaczStronPdf(_roboczyKatalog);
            zliczacz.Zapisz("PoliczStronyA4.tab");
            Console.WriteLine("Podsumowanie:");
            Console.WriteLine("Liczba plików: {0}", zliczacz.LiczbaPlików);
            Console.WriteLine("Suma stron: {0}", zliczacz.SumaStron);
            Console.WriteLine("Suma stron A4: {0}", zliczacz.SumaStronA4);
            if (_błędy.Count > 0)
            {
                Console.WriteLine("Błędy: {0} (error.log)", _błędy.Count);
                File.WriteAllLines("error.log", _błędy);
            }
            /*using (StreamWriter writer = new StreamWriter("PoliczStronyA4.tab", false, Encoding.GetEncoding(1250)))
            {
                //Nazwa pliku| Numer strony | Wysokość | Szerokość | Wysokość[cm] | Szerokość[cm] | Format arkusza | Liczba stron A4
                writer.WriteLine("Nazwa pliku\tNumer strony\tSzerokość[punkty]\tWysokość[punkty]\tSzerokość[mm]\tWysokość[mm]\tFormat arkusza\tLiczba stron A4");
                int nr = 1;
                foreach (var plik in _pliki)
                {
                    PdfReader pdf = null;
                    try { pdf = new PdfReader(plik); }
                    catch (Exception ex) { _błędy.Add(plik + " (" + ex.Message + ")"); continue; } //Błędny plik
                    var liczbaStron = pdf.NumberOfPages;
                    var teraz = DateTime.Now;
                    var różnica = teraz - początek;
                    var sekundy = różnica.TotalSeconds;
                    var liczbaPlikówNaSekundę = nr / sekundy;
                    var przewidywanyCzas = (_pliki.Length - nr) / liczbaPlikówNaSekundę;
                    Console.WriteLine("{0}, {1} stron[y] #{2}/{3} {4:F0}s {5:F0}pliki/s {6:F0}min. ({7})", plik, liczbaStron,
                        nr++, _pliki.Length, sekundy, liczbaPlikówNaSekundę, przewidywanyCzas / 60, _błędy.Count);
                    for (int strona = 1; strona <= liczbaStron; strona++)
                    {
                        Rectangle size = pdf.GetPageSize(strona);
                        var rozmiarPunkty = new RozmiarStrony(size.Width.ToInt(), size.Height.ToInt());
                        var szerokośćMilimetry = rozmiarPunkty.Szerokość * 0.3528;
                        var wysokośćMilimetry = rozmiarPunkty.Wysokość * 0.3528;
                        var rozmiar = new RozmiarStrony(wysokośćMilimetry.ToInt(), szerokośćMilimetry.ToInt());
                        var format = analizator.ObliczFormatStrony(rozmiar);
                        var stronyA4 = format.StronyA4;
                        writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}",
                            plik, strona,
                            rozmiarPunkty.Szerokość, rozmiarPunkty.Wysokość,
                            rozmiar.Szerokość, rozmiar.Wysokość,
                            format, stronyA4);
                        sumaStronA4 += stronyA4;
                    }
                    sumaStron += liczbaStron;
                    liczbaPlików++;
                }
            }*/
        }

        static void PoliczStronyZPliku()
        {
            var linie = File.ReadAllLines("PoliczStronyA4.tab", Encoding.GetEncoding(1250));
            var sumaStronA4 = 0;
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
                var rozmiarStrony = new RozmiarStrony(szerokośćMilimetry, wysokośćMilimetry);
                var formatStrony = analizator.ObliczFormatStrony(rozmiarStrony);
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
