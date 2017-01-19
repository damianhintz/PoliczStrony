using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using StronyA4Domena.Encje.Rozszerzenia;
using StronyA4Domena.Encje;

namespace StronyA4Domena.Repozytoria
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
            var size = _pdf.GetPageSize(numerStrony);
            var szerokość = size.Width.WymiarFromPoints();
            var wysokość = size.Height.WymiarFromPoints();
            var strona = new StronaObrazu
            {
                Plik = _fileName,
                Numer = numerStrony,
                Szerokość = szerokość,
                Wysokość = wysokość
            };
            return strona;
        }
    }
}
