using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4Domena.Encje.Rozszerzenia;
using StronyA4Domena.Abstrakcje;
using StronyA4Domena.Klasyfikacja;

namespace StronyA4Domena.Repozytoria.Rozszerzenia
{
    /// <summary>
    /// Rozszerzenia repozytorium stron.
    /// </summary>
    public static class RepozytoriumRozszerzenia
    {
        /// <summary>
        /// Oblicza sumę stron w przeliczeniu na A4, wykorzystując podobieństwo do standardowych formatów.
        /// </summary>
        /// <param name="strony"></param>
        /// <returns></returns>
        public static int SumaStronA4Metrycznie(this IRepozytoriumStron strony, params string[] formaty)
        {
            var klasyfikator = new MetrycznyKlasyfikatorStrony();
            foreach (var format in formaty) klasyfikator.DodajFormat(format);
            var sumaStron = strony.Strony.Sum(s => klasyfikator.UstalFormatStrony(s).StronyA4);
            return (int)sumaStron;
        }

        public static Dictionary<string, List<IStrona>> ZestawienieStronA4Metrycznie(this IRepozytoriumStron strony, params string[] formaty)
        {
            var klasyfikator = new MetrycznyKlasyfikatorStrony();
            foreach (var format in formaty) klasyfikator.DodajFormat(format);
            var zestawienie = new Dictionary<string, List<IStrona>>();
            foreach (var f in klasyfikator.Formaty) zestawienie.Add(f.Nazwa, new List<IStrona>());
            foreach (var s in strony.Strony)
            {
                var f = klasyfikator.UstalFormatStrony(s);
                zestawienie[f.Nazwa].Add(s);
            }
            return zestawienie;
        }

        /// <summary>
        /// Oblicza sumę stron w przeliczeniu na A4, na podstawie stosunku całkowitej powierzchni stron do powierzchni standardowej strony A4.
        /// </summary>
        /// <param name="strony"></param>
        /// <returns></returns>
        public static int SumaStronA4Powierzchniowo(this IRepozytoriumStron strony)
        {
            var klasyfikator = new MetrycznyKlasyfikatorStrony();
            var sumaPowierzchni = strony.Strony.Sum(s => (long)s.Szerokość.Pixels * (long)s.Wysokość.Pixels);
            var formatA4 = StandardoweFormaty.FormatA4;
            var powierzchniaA4 = formatA4.Szerokość.Pixels * formatA4.Wysokość.Pixels;
            return (int)(sumaPowierzchni / powierzchniaA4);
        }

        public static int SumaStronA4Powierzchniowo(this IRepozytoriumStron strony, params string[] formaty)
        {
            var klasyfikator = new PowierzchniowyKlasyfikatorStrony();
            foreach (var format in formaty) klasyfikator.DodajFormat(format);
            var sumaStron = strony.Strony.Sum(s => klasyfikator.UstalFormatStrony(s).StronyA4);
            return (int)sumaStron;
        }

        public static Dictionary<string, List<IStrona>> ZestawienieStronA4Powierzchniowo(this IRepozytoriumStron strony, params string[] formaty)
        {
            var klasyfikator = new PowierzchniowyKlasyfikatorStrony();
            foreach (var format in formaty) klasyfikator.DodajFormat(format);
            var zestawienie = new Dictionary<string, List<IStrona>>();
            foreach (var f in klasyfikator.Formaty) zestawienie.Add(f.Nazwa, new List<IStrona>());
            foreach (var s in strony.Strony)
            {
                var f = klasyfikator.UstalFormatStrony(s);
                zestawienie[f.Nazwa].Add(s);
            }
            return zestawienie;
        }
    }
}
