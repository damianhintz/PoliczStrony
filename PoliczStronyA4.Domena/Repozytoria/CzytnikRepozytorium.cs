using StronyA4.Domena.Encje;
using StronyA4.Domena.Encje.Rozszerzenia;
using StronyA4.Domena.Abstrakcje;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StronyA4.Domena.Repozytoria
{
    public class CzytnikRepozytorium
    {
        IRepozytoriumStron _strony;

        public CzytnikRepozytorium(IRepozytoriumStron strony)
        {
            _strony = strony;
        }

        public void Wczytaj(string fileName)
        {
            var records = File.ReadAllLines(fileName, Encoding.GetEncoding(1250));
            foreach (var linia in records.Skip(1))
            {
                var pola = linia.Split('\t');
                var strona = new StronaObrazu();
                strona.Plik = pola[0];
                strona.Numer = int.Parse(pola[1]);
                var szerokość = int.Parse(pola[4]);
                var wysokość = int.Parse(pola[5]);
                strona.Szerokość = szerokość.WymiarFromMm();
                strona.Wysokość = wysokość.WymiarFromMm();
                _strony.Dodaj(strona);
            }
        }
    }
}
