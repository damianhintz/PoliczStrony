using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoliczStronyA4.Domena
{
    class PowierzchniowyAnalizatorStrony : IAnalizatorFormatuStrony
    {
        public FormatStrony ObliczFormatStrony(RozmiarStrony rozmiar)
        {
            var szerokość = rozmiar.Szerokość;
            var wysokość = rozmiar.Wysokość;
            var stronyA4 = Math.Min(A4(szerokość, wysokość), A4(wysokość, szerokość));
            var format = "A4";
            if (stronyA4 > 8) format = "A0";
            if (stronyA4 > 4) format = "A1";
            if (stronyA4 > 2) format = "A2";
            if (stronyA4 > 1) format = "A3";
            else format = "A4";
            return new FormatStrony(format) { StronyA4 = stronyA4, EfektywneStronyA4 = stronyA4 };
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
