using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using StronyA4.Domena.Abstrakcje;
using StronyA4.Domena.Klasyfikacja;
using StronyA4.Domena.Encje.Rozszerzenia;

namespace StronyA4.Domena.Repozytoria
{
    /// <summary>
    /// Importer stron plików jpg do repozytorium.
    /// </summary>
    public class CzytnikPlikówJpg : ICzytnikPlików
    {
        IRepozytoriumStron _strony;
        public IEnumerable<string> Pliki => _pliki;
        string[] _pliki;

        public CzytnikPlikówJpg(IRepozytoriumStron strony)
        {
            _strony = strony;
        }

        public void Wczytaj(string folder)
        {
            _pliki = Directory.GetFiles(folder, "*.jpg", SearchOption.AllDirectories);
            foreach (var plik in _pliki)
            {
                try { OdczytajStronę(plik); }
                catch { }
            }
        }

        void OdczytajStronę(string fileName)
        {
            var strona = fileName.ReadStronaFromBitmap();
            _strony.Dodaj(strona);
        }

    }
}
