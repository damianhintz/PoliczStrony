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
    /// Klasyfikator formatu strony na podstawie podobieństwa do standardowych formatów.
    /// </summary>
    public class MetrycznyKlasyfikatorStrony : IKlasyfikatorStrony
    {
        /// <summary>
        /// Lista formatów strony, z którymi strony zostaną porównane.
        /// </summary>
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
            if (strona == null) throw new ArgumentNullException("strona != null");
            if (!_formaty.Any()) throw new InvalidOperationException("Brak zdefiniowanych formatów z którymi można dokonać porównania");
            var najbliższyFormat = _formaty.First();
            var najmniejszaOdległość = strona.OdległośćPixelowa(najbliższyFormat);
            foreach (var format in _formaty.Skip(1))
            {
                var odległość = strona.OdległośćPixelowa(format);
                if (odległość < najmniejszaOdległość)
                {
                    najmniejszaOdległość = odległość;
                    najbliższyFormat = format;
                }
            }
            return najbliższyFormat;
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
