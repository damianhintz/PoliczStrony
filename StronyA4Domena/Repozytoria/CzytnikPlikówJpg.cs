using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using StronyA4Domena.Abstrakcje;
using StronyA4Domena.Klasyfikacja;
using StronyA4Domena.Encje.Rozszerzenia;

namespace StronyA4Domena.Repozytoria
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

        public IEnumerable<string> Wczytaj(string folder)
        {
            _pliki = Directory.GetFiles(folder, "*.jpg", SearchOption.AllDirectories);
            foreach (var plik in _pliki)
            {
                var error = plik;
                try { OdczytajStronę(plik); }
                catch (Exception ex) { error = plik + "\tERROR: " + ex.Message; }
                yield return error;
            }
        }

        void OdczytajStronę(string fileName)
        {
            var strona = fileName.ReadStronaFromBitmap();
            _strony.Dodaj(strona);
        }

    }
}
