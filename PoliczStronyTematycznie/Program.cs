using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using PoliczStronyTematycznie.Domena;

namespace PoliczStronyTematycznie
{
    static class Program
    {
        static StreamWriter _writer = new StreamWriter("PoliczStrony.log", false, Encoding.GetEncoding(1250));
        static StreamWriter _writerRozmiar = new StreamWriter("PoliczStronyA.txt", false, Encoding.GetEncoding(1250));
        static Dictionary<string, int> _stronyTematycznie = new Dictionary<string, int>();
        static int _brakStron = 0;
        static int _sumaStron = 0;

        /// <summary>
        /// PoliczStrony.exe --directory {name} --type *.pdf -recursive --count --bySubject
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("PoliczStronyTematycznie v1.0.1 - Policz strony tematycznie w plikach pdf");
            Console.WriteLine("Data publikacji: 6 lipca 2014");
            string roboczyKatalog = Directory.GetCurrentDirectory();
            if (args.Length > 0) roboczyKatalog = args[0];
            string typPliku = "*.pdf";
            if (args.Length > 1) typPliku = args[1];
            Console.WriteLine("Wyszukiwanie plików typu: {0}", typPliku);
            string[] pliki = Directory.GetFiles(roboczyKatalog, typPliku, SearchOption.AllDirectories);
            Console.WriteLine("Roboczy katalog: {0}", roboczyKatalog);
            Console.WriteLine("Liczba plików ({0}): {1}", typPliku, pliki.Length);
            try
            {
                for (int i = 0; i < pliki.Length; i++)
                {
                    OdświeżWidok(i + 1, pliki.Length);
                    pliki[i].DodajPlik();
                }
            }
            finally
            {
                _writer.Close();
                _writerRozmiar.Close();
            }
            PokażPodsumowanie();
        }

        static void DodajPlik(this string fileName)
        {
            StronyInfo info = fileName.WczytajStrony();
            if (info.LiczbaStron < 1)
            {
                _brakStron++;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("uwaga: brak stron w pliku {0}", fileName);
                Console.ResetColor();
            }
            foreach(var rozmiar in info.RozmiaryStron) _writerRozmiar.WriteLine(rozmiar);
            _writer.WriteLine("{1}Plik: {0}", fileName, info.LiczbaStron < 1 ? "*" : "");
            _writer.WriteLine("Strony: {0}", info.LiczbaStron);
            _writer.WriteLine(info.OutputString);
            string temat = info.Temat;
            if (!_stronyTematycznie.ContainsKey(temat)) _stronyTematycznie.Add(temat, 0);
            _stronyTematycznie[temat] += info.LiczbaStron;
            _sumaStron += info.LiczbaStron;
        }

        static void OdświeżWidok(int index, int length)
        {
            string tematyString = "";
            foreach (var kv in _stronyTematycznie)
            {
                if (tematyString.Length > 0) tematyString += ",";
                tematyString += string.Format("{0}={1}", kv.Key, kv.Value);
            }
            Console.Write("\r{0}/{1} ({2} strony) [{3}]", index, length, _sumaStron, tematyString);
        }

        static void PokażPodsumowanie()
        {
            Console.WriteLine("\nsuma: {0} stron(y)", _sumaStron);
            foreach (var kv in _stronyTematycznie) Console.WriteLine("{0}: {1} stron(y)", kv.Key, kv.Value);
            if (_brakStron > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("<brak strony>: {0} plik(i)", _brakStron);
                Console.ResetColor();
            }
            Console.WriteLine("Koniec.");
            Console.Read();
        }
    }
}
