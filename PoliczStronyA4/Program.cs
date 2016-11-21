using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using StronyA4.Properties;
using StronyA4.Domena.Abstrakcje;
using StronyA4.Domena.Repozytoria;
using StronyA4.Domena.Repozytoria.Rozszerzenia;

namespace StronyA4
{
    /// <summary>
    /// StronyA4.exe folder:"" fileType:*.jpg lub *.pdf formats:A0,A1,A2,A3,A4
    /// </summary>
    class Program
    {
        public string Folder;
        public string FileType = Settings.Default.FileType;
        public string Formats = Settings.Default.Formaty;
        IRepozytoriumStron _strony = new RepozytoriumStron();
        
        void PokażLogo()
        {
            Console.WriteLine("StronyA4 v1.4-beta - Policz strony A4 w plikach pdf lub jpg");
            Console.WriteLine("Data publikacji: 21 listopada 2016");
        }

        static void Main(string[] args)
        {
            var program = new Program();
            program.PokażLogo();
            if (args.Length > 2) program.Formats = args[2];
            if (args.Length > 1) program.FileType = args[1];
            if (args.Length > 0) program.Folder = args[0];
            if (args.Length == 0) program.PoliczStronyCached();
            else program.PoliczStronyFolderu();
            program.PokażPodsumowanie();
            Console.Read();
        }

        void PoliczStronyFolderu()
        {
            Console.WriteLine("Roboczy katalog: {0}", Folder == null ? "nie określono katalogu, obliczanie z pliku tab" : Folder);
            ICzytnikPlików czytnik = null;
            if (FileType.Equals("*.pdf")) czytnik = new CzytnikPlikówPdf(_strony);
            else if (FileType.Equals("*.jpg")) czytnik = new CzytnikPlikówJpg(_strony);
            else throw new NotImplementedException("Brak implementacji importera plików typu: " + FileType);
            czytnik.Wczytaj(Folder);
            //strony.ZapiszZmiany();
        }

        void PoliczStronyCached()
        {
            var czytnik = new CzytnikRepozytorium(_strony);
            var fileName = "StronyA4.tab";
            czytnik.Wczytaj(fileName);
        }

        void PokażPodsumowanie()
        {
            Console.WriteLine("Liczba plików ({0}): {1}", FileType, _strony.Pliki.Count());
            Console.WriteLine("Suma stron: {0}", _strony.Strony.Count());
            PokażZestawienieMetryczne();
            PokażZestawieniePowierzchniowe();
            Console.WriteLine("Koniec.");
        }

        void PokażZestawienieMetryczne()
        {
            Console.WriteLine("Suma stron A4 (metrycznie): {0}", _strony.SumaStronA4Metrycznie());
            var formaty = _strony.ZestawienieStronA4Metrycznie();
            PokażZestawienieFormatów(formaty);
        }

        void PokażZestawieniePowierzchniowe()
        {
            Console.WriteLine("Suma stron A4 (powierzchniowo): {0}", _strony.SumaStronA4Powierzchniowo());
            //var formaty = _strony.ZestawienieStronA4Powierzchniowo();
            //PokażZestawienieFormatów(formaty);
        }

        void PokażZestawienieFormatów(Dictionary<string, List<IStrona>> formaty)
        {
            Console.WriteLine("Stron[y] formatu A0: {0}", formaty["A0"].Count);
            Console.WriteLine("Stron[y] formatu A1: {0}", formaty["A1"].Count);
            Console.WriteLine("Stron[y] formatu A2: {0}", formaty["A2"].Count);
            Console.WriteLine("Stron[y] formatu A3: {0}", formaty["A3"].Count);
            Console.WriteLine("Stron[y] formatu A4: {0}", formaty["A4"].Count);
        }
    }
}
