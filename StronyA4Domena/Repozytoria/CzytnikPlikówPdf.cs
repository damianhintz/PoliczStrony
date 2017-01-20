using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using StronyA4Domena.Abstrakcje;

namespace StronyA4Domena.Repozytoria
{
    /// <summary>
    /// Importer stron plików pdf do repozytorium.
    /// </summary>
    public class CzytnikPlikówPdf : ICzytnikPlików
    {
        IRepozytoriumStron _strony;
        public IEnumerable<string> Pliki => _pliki;
        string[] _pliki;

        public CzytnikPlikówPdf(IRepozytoriumStron strony)
        {
            _strony = strony;
        }

        public IEnumerable<string> Wczytaj(string folder)
        {
            _pliki = Directory.GetFiles(folder, "*.pdf", SearchOption.AllDirectories);
            foreach (var plik in _pliki)
            {
                var error = plik;
                try { OdczytajStronyPlikuPdf(plik); }
                catch (Exception ex) { error = plik + "\tERROR: " + ex.Message; }
                yield return error;
            }
        }

        void OdczytajStronyPlikuPdf(string fileName)
        {
            var czytnik = new CzytnikStronPdf(fileName);
            foreach (var strona in czytnik.Strony) _strony.Dodaj(strona);
        }

    }
}
