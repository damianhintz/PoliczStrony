using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StronyA4.Domena.Encje.Rozszerzenia
{
    public static class RozmiarRozszerzenia
    {
        public static long PointsToMm(this long points)
        {
            var mm = points * 0.3528;
            return (long)mm;
        }

        public static long PixelsToMm(this long pixels, long dpi)
        {
            //cm = pixels * 2.54cm / 96dpi
            return pixels.PixelsToCm(dpi) / 100;
        }

        public static long PixelsToCm(this long pixels, long dpi)
        {
            //mm = pixels * 254mm / 96dpi
            return pixels * 254 / dpi;
        }

    }
}
