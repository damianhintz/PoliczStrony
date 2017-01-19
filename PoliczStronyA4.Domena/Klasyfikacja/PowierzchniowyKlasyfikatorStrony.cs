using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4Domena.Abstrakcje;
using StronyA4Domena.Encje;
using StronyA4Domena.Encje.Rozszerzenia;
using System.Diagnostics;

namespace StronyA4Domena.Klasyfikacja
{
    /// <summary>
    /// Klasyfikator formatu strony na podstawie stosunku jej powierzchni do powierzchni formatu A4.
    /// </summary>
    public class PowierzchniowyKlasyfikatorStrony : IKlasyfikatorStrony
    {
        public IEnumerable<FormatStrony> Formaty => _formaty;
        List<FormatStrony> _formaty = new List<FormatStrony> {
            StandardoweFormaty.FormatA0,
            StandardoweFormaty.FormatA1,
            StandardoweFormaty.FormatA2,
            StandardoweFormaty.FormatA3,
            StandardoweFormaty.FormatA4
        };

        public FormatStrony UstalFormatStrony(IWymiarowalny strona)
        {
            var szerokość = strona.Szerokość.Mm;
            var wysokość = strona.Wysokość.Mm;
            var formatA4 = StandardoweFormaty.Szukaj("A4");
            var powierzchniaA4 = formatA4.Szerokość.Pixels * formatA4.Wysokość.Pixels;
            var powierzchniaStrony = strona.Szerokość.Pixels * strona.Wysokość.Pixels;
            var stronyA4 = (double)powierzchniaStrony / (double)powierzchniaA4;
            var formatyRosnąco = _formaty.OrderBy(f => f.StronyA4);
            FormatStrony wybranyFormat = null;
            foreach (var format in formatyRosnąco)
            {
                if (stronyA4 > format.StronyA4) continue;
                wybranyFormat = format;
                break; //wybieramy ten format
            }
            if (wybranyFormat == null) wybranyFormat = formatyRosnąco.Last();
            return new FormatStrony
            {
                Nazwa = wybranyFormat.Nazwa,
                StronyA4 = stronyA4
            };
        }

        public void DodajFormat(FormatStrony format)
        {
            Debug.Assert(format != null, "format != null");
            if (_formaty.Contains(format)) return;
            _formaty.Add(format);
        }

        public void DodajFormat(string nazwa)
        {
            Debug.Assert(nazwa != null, "nazwa != null");
            var format = StandardoweFormaty.Szukaj(nazwa);
            DodajFormat(format);
        }
    }
}
