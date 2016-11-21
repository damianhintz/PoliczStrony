﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using StronyA4.Domena.Abstrakcje;
using StronyA4.Domena.Klasyfikacja;

namespace StronyA4.Domena.Repozytoria
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

        public void Wczytaj(string folder)
        {
            _pliki = Directory.GetFiles(folder, "*.pdf", SearchOption.AllDirectories);
            foreach (var plik in _pliki)
            {
                try { OdczytajStronyPlikuPdf(plik); }
                catch { }
            }
        }

        void OdczytajStronyPlikuPdf(string fileName)
        {
            var czytnik = new CzytnikStronPdf(fileName);
            foreach (var strona in czytnik.Strony) _strony.Dodaj(strona);
        }

    }
}
