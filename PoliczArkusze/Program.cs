using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace PoliczArkusze
{
    static class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.Error.WriteLine(@"Podaj katalog do przeszukania np. c:\jpg");
                return;
            }

            if (!Directory.Exists(args[0]))
            {
                Console.Error.WriteLine("Taki katalog nie istnieje -> " + args[0]);
                return;
            }

            Console.Error.WriteLine("Katalog roboczy: {0}", args[0]);
            Console.Error.WriteLine("Szukanie plików w formacie *.jpg ...");
            string[] files = Directory.GetFiles(args[0], "*.jpg", SearchOption.AllDirectories);
            Console.Error.WriteLine("Szukanie zakończone.");
            Console.Error.WriteLine("Znaleziono {0} plików *.jpg", files.Length);

            long a1 = 0;
            long a2 = 0;
            long a3 = 0;
            long a4 = 0;

            Console.Error.WriteLine("Zapisywanie atrybutów plików...");
            DateTime startTime = DateTime.Now;

            for (int i = 0; i < files.Length; i++)
            {
                try
                {
                    DateTime beginTime = DateTime.Now;
                    Console.Error.Write("{0,4}/{1} -> (loading...) ", i, files.Length);
                    Image image = Image.FromFile(files[i]);
                    Console.Error.WriteLine("{0}x{1}", image.Width, image.Height);
                    Console.WriteLine("{0};{1};{2};{3};{4}", image.Width, image.Height, Math.Min(image.Width, image.Height), Math.Max(image.Width, image.Height), files[i]);
                    image.Dispose();
                    image = null;
                    DateTime endTime = DateTime.Now;
                    Console.Error.WriteLine("Przewidywany czas zakończenia -> {0:F1} minut (rozpoczęto {1})", (endTime - startTime).TotalSeconds * (files.Length - i) / (i * 60), startTime);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
                finally
                {
                    GC.Collect();
                }
            }
            Console.Error.WriteLine("A1={0} A2={1} A3={2} A4={3}", a1, a2, a3, a4);

        }
    }
}
