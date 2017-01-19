using System;
using System.Collections.Generic;
using System.Linq;
using StronyA4Cmd.Properties;
using StronyA4Domena.Abstrakcje;
using StronyA4Domena.Repozytoria;
using StronyA4Domena.Repozytoria.Rozszerzenia;

namespace StronyA4Cmd
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
            Console.WriteLine("StronyA4 v1.6 - Policz strony A4 w plikach pdf lub jpg");
            Console.WriteLine("Data publikacji: 22 grudnia 2016");
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
            var writer = new EksporterRepozytorium(_strony);
            writer.ZapiszZmiany("StronyA4.log");
            Console.WriteLine("Koniec.");
        }

        void PokażZestawienieMetryczne()
        {
            var formats = Formats.Split(',');
            Console.WriteLine("Suma stron A4 (liczba stron standardowego formatu): {0}", _strony.SumaStronA4Metrycznie(formats));
            var formaty = _strony.ZestawienieStronA4Metrycznie(formats);
            PokażZestawienieFormatów(formaty);
        }

        void PokażZestawieniePowierzchniowe()
        {
            var formats = Formats.Split(',');
            Console.WriteLine("Suma stron A4 (całkowita powierzchnia/powierzchnia A4): {0}", _strony.SumaStronA4Powierzchniowo());
            Console.WriteLine("Suma stron A4 (powierzchnia strony/powierzchnia A4): {0}", _strony.SumaStronA4Powierzchniowo(formats));
            var formaty = _strony.ZestawienieStronA4Powierzchniowo(formats);
            PokażZestawienieFormatów(formaty);
        }

        void PokażZestawienieFormatów(Dictionary<string, List<IStrona>> formaty)
        {
            foreach (var format in formaty)
            {
                var nazwa = format.Key;
                var lista = format.Value;
                Console.WriteLine("Stron[y] formatu {0}: {1}", nazwa, lista.Count);
            }
        }
    }
}
