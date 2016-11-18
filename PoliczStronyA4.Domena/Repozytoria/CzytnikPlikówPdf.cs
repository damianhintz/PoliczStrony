using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using StronyA4.Domena.Abstrakcje;

namespace StronyA4.Domena.Repozytoria
{
    /// <summary>
    /// Czytnik stron plików pdf do repozytorium.
    /// </summary>
    public class CzytnikPlikówPdf
    {
        IRepozytoriumStron _strony;
        int _sumaStron;
        double _sumaStronA4;

        public CzytnikPlikówPdf(IRepozytoriumStron strony)
        {
            _strony = strony;
        }

        public void Wczytaj(string folder)
        {
            var pliki = Directory.GetFiles(folder, "*.pdf", SearchOption.AllDirectories);
            foreach (var plik in pliki)
            {
                try { OdczytajStronyPlikuPdf(plik); }
                catch { }
            }
        }

        void OdczytajStronyPlikuPdf(string fileName)
        {
            var czytnik = new CzytnikStronPdf(fileName);
            var klasyfikator = new MetrycznyKlasyfikatorStrony();
            foreach (var strona in czytnik.Strony)
            {
                var format = klasyfikator.UstalFormatStrony(strona.Rozmiar);
                _sumaStronA4 += format.StronyA4;
                _strony.Dodaj(strona);
            }
            _sumaStron += czytnik.LiczbaStron;
        }

    }
}
