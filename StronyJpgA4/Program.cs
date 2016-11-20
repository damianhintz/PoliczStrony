using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media.Imaging;

namespace StronyJpg
{
    /// <summary>
    /// Klasyfikacja, postęp
    /// </summary>
    class Program
    {
        static List<Strona> _strony = new List<Strona>();

        static void Main(string[] args)
        {
            var files = Directory.GetFiles(
                @"s:\2903_skanowanie Bartoszyce\skanowanie\",
                "*.jpg", SearchOption.AllDirectories);
            Console.WriteLine("Pliki (*.jpg): {0}", files.Length);
            var errors = new List<string>();
            int count = 0;
            foreach (var file in files)
            {
                try
                {
                    var strona = Strona.ParseFromBitmap(new FileInfo(file));
                    _strony.Add(strona);
                    if (count % 5000 == 0) Console.WriteLine("{0}...", count++);
                }
                catch
                {
                    Console.WriteLine("Nie można odczytać pliku:");
                    Console.WriteLine(file);
                    errors.Add(file);
                }
            }
            Console.WriteLine("Odczytane pliki: {0}/{1}", _strony.Count, files.Length);
            Console.WriteLine("Pominięte pliki: {0}", errors.Count);
            var sumaPowierzchni = _strony.Sum(s => s.Szerokość * s.Wysokość);
            long powierzchniaA4 = 3507 * 2478;
            var liczbaStronA4 = sumaPowierzchni / powierzchniaA4;
            Console.WriteLine("Strony A4 (powierzchniowo): {0}", liczbaStronA4);
            File.WriteAllLines("StronyA4.tab", 
                _strony.Select(m => m.Plik + "\t" + m.Szerokość + "\t" + m.Wysokość + "\t" + m.Rozdzielczość));
            Console.WriteLine("Koniec.");
            Console.Read();
        }

    }
}
