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
        string _folder;
        string _fileType = Settings.Default.FileType;
        string _formats = Settings.Default.Formaty;
        IRepozytoriumStron _strony = new RepozytoriumStron();

        public Program(string folder)
        {
            _folder = folder;
        }

        void PokażLogo()
        {
            Console.WriteLine("StronyA4 v1.4-beta - Policz strony A4 w plikach pdf lub jpg");
            Console.WriteLine("Data publikacji: 21 listopada 2016");
            Console.WriteLine("Roboczy katalog: {0}", _folder == null ? "nie określono katalogu, obliczanie z pliku tab" : _folder);
        }

        static void Main(string[] args)
        {
            var program = new Program(folder: args[0]);
            program.PokażLogo();
            if (args.Length == 0) program.PoliczStronyCached();
            else program.PoliczStronyFolderu(fileType: args[1]);
            program.PokażPodsumowanie();
            Console.Read();
        }

        void PoliczStronyFolderu(string fileType)
        {
            _fileType = fileType;
            ICzytnikPlików czytnik = null;
            if (fileType.Equals("*.pdf")) czytnik = new CzytnikPlikówPdf(_strony);
            else if (fileType.Equals("*.jpg")) czytnik = new CzytnikPlikówJpg(_strony);
            else throw new NotImplementedException("Brak implementacji importera plików typu: " + fileType);
            czytnik.Wczytaj(_folder);
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
            Console.WriteLine("Liczba plików ({0}): {1}", _fileType, _strony.Pliki.Count());
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
