using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4.Domena.Abstrakcje;
using StronyA4.Domena.Encje;

namespace StronyA4.Domena.Klasyfikacja
{
    /// <summary>
    /// Klasyfikator formatu strony na podstawie stosunku jej powierzchni do powierzchni formatu A4.
    /// </summary>
    class PowierzchniowyKlasyfikatorStrony : IKlasyfikatorStrony
    {
        public FormatStrony UstalFormatStrony(IWymiarowalny strona)
        {
            var szerokość = strona.Szerokość.Mm;
            var wysokość = strona.Wysokość.Mm;
            var stronyA4 = Math.Min(A4(szerokość, wysokość), A4(wysokość, szerokość));
            var nazwa = "A4";
            if (stronyA4 > 8) nazwa = "A0";
            if (stronyA4 > 4) nazwa = "A1";
            if (stronyA4 > 2) nazwa = "A2";
            if (stronyA4 > 1) nazwa = "A3";
            else nazwa = "A4";
            return new FormatStrony
            {
                Nazwa = nazwa,
                StronyA4 = stronyA4
            };
        }

        static int A4(double szerokość, double wysokość)
        {
            var a4 = 0;
            var szerokośćA4 = 210.0 + 42.0; //+42 (20%)
            var wysokośćA4 = 297.0 + 60.0; //+60 (20%)
            //A4 210×297 (w x h)
            //A3 297x420 (h x 2*w)
            //A2 420x594 (2*w x 2*h)
            var s = (int)Math.Ceiling(szerokość / szerokośćA4);
            var w = (int)Math.Ceiling(wysokość / wysokośćA4);
            a4 = s * w;
            return a4;
        }

    }
}
