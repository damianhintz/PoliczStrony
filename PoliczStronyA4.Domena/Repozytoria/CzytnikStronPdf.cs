using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using StronyA4.Domena.Rozszerzenia;
using StronyA4.Domena.Encje;

namespace StronyA4.Domena.Repozytoria
{
    public class CzytnikStronPdf
    {
        string _fileName;
        PdfReader _pdf;
        public IEnumerable<StronaObrazu> Strony { get { return _strony; } }
        public int LiczbaStron { get { return _strony.Count; } }
        List<StronaObrazu> _strony;

        public CzytnikStronPdf(string fileName)
        {
            _fileName = fileName;
            _pdf = new PdfReader(fileName);
            _strony = new List<StronaObrazu>(_pdf.NumberOfPages);
            OdczytajWszystkieStronyPlikuPdf();
        }

        void OdczytajWszystkieStronyPlikuPdf()
        {
            for (int numerStrony = 1; numerStrony <= _pdf.NumberOfPages; numerStrony++)
            {
                var strona = OdczytajStronę(numerStrony);
                _strony.Add(strona);
            }
        }

        StronaObrazu OdczytajStronę(int numerStrony)
        {
            Rectangle size = _pdf.GetPageSize(numerStrony);
            var rozmiarPunkty = new RozmiarStrony
            {
                Szerokość = size.Width.ToInt(),
                Wysokość = size.Height.ToInt()
            };
            var szerokośćMilimetry = rozmiarPunkty.Szerokość * 0.3528;
            var wysokośćMilimetry = rozmiarPunkty.Wysokość * 0.3528;
            var rozmiarMilimetry = new RozmiarStrony
            {
                Szerokość = szerokośćMilimetry.ToInt(),
                Wysokość = wysokośćMilimetry.ToInt()
            };
            var strona = new StronaObrazu
            {
                Plik = _fileName,
                Numer = numerStrony,
                Rozmiar = rozmiarMilimetry
            };
            return strona;
        }
    }
}
