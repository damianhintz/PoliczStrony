using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StronyA4.Domena.Encje.Rozszerzenia
{
    public static class StandardoweFormaty
    {
        public static readonly FormatStrony FormatA6 = new FormatStrony
        {
            Nazwa = "A6",
            Szerokość = 105.WymiarFromMm(),
            Wysokość = 148.WymiarFromMm(),
            StronyA4 = 0.25
        };

        public static readonly FormatStrony FormatA5 = new FormatStrony
        {
            Nazwa = "A5",
            Szerokość = 148.WymiarFromMm(),
            Wysokość = 210.WymiarFromMm(),
            StronyA4 = 0.5
        };

        public static readonly FormatStrony FormatA4 = new FormatStrony
        {
            Nazwa = "A4",
            Szerokość = 210.WymiarFromMm(),
            Wysokość = 297.WymiarFromMm(),
            StronyA4 = 1
        };

        public static readonly FormatStrony FormatA3 = new FormatStrony
        {
            Nazwa = "A3",
            Szerokość = 297.WymiarFromMm(),
            Wysokość = 420.WymiarFromMm(),
            StronyA4 = 2
        };

        public static readonly FormatStrony FormatA2 = new FormatStrony
        {
            Nazwa = "A2",
            Szerokość = 420.WymiarFromMm(),
            Wysokość = 594.WymiarFromMm(),
            StronyA4 = 4
        };

        public static readonly FormatStrony FormatA1 = new FormatStrony
        {
            Nazwa = "A1",
            Szerokość = 594.WymiarFromMm(),
            Wysokość = 840.WymiarFromMm(),
            StronyA4 = 8
        };

        public static FormatStrony FormatA0 = new FormatStrony
        {
            Nazwa = "A0",
            Szerokość = 840.WymiarFromMm(),
            Wysokość = 1189.WymiarFromMm(),
            StronyA4 = 16
        };

        public static readonly FormatStrony Format2A0 = new FormatStrony
        {
            Nazwa = "2A0",
            Szerokość = 1189.WymiarFromMm(),
            Wysokość = 1682.WymiarFromMm(),
            StronyA4 = 32
        };

    }
}
