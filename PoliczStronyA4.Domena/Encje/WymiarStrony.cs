using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StronyA4.Domena.Encje
{
    public class WymiarStrony
    {
        public const double CalNaCm = 2.54;
        public const double CalNaMm = 25.4;

        public int Pixels { get; set; }
        //public int Points { get; }
        public int Cm { get { return Mm / 10; } }

        public int Mm
        {
            get
            {
                var s = string.Format("{0:F0}", Pixels * CalNaMm / Rozdzielczość);
                return int.Parse(s); //mm = pixels * 254mm / 96dpi
            }
        }

        public int Rozdzielczość { get; set; }

    }
}
