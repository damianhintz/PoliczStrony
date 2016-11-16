using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using StronyA4.Domena.Rozszerzenia;

namespace StronyA4.Domena
{
    public class CzytnikStronPdf
    {
        string _fileName;
        PdfReader _pdf;
        public IEnumerable<StronaPdf> Strony { get { return _strony; } }
        public int LiczbaStron { get { return _strony.Count; } }
        List<StronaPdf> _strony;

        public CzytnikStronPdf(string fileName)
        {
            _fileName = fileName;
            _pdf = new PdfReader(fileName);
            _strony = new List<StronaPdf>(_pdf.NumberOfPages);
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

        StronaPdf OdczytajStronę(int numerStrony)
        {
            Rectangle size = _pdf.GetPageSize(numerStrony);
            var rozmiarPunkty = new RozmiarStrony(size.Width.ToInt(), size.Height.ToInt());
            var szerokośćMilimetry = rozmiarPunkty.Szerokość * 0.3528;
            var wysokośćMilimetry = rozmiarPunkty.Wysokość * 0.3528;
            var rozmiarMilimetry = new RozmiarStrony(szerokośćMilimetry.ToInt(), wysokośćMilimetry.ToInt());
            var strona = new StronaPdf(_fileName) { NumerStrony = numerStrony, RozmiarPunkty = rozmiarPunkty, RozmiarMilimetry = rozmiarMilimetry };
            return strona;
        }
    }
}
