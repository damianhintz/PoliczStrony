using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StronyA4.Domena.Encje
{
    /// <summary>
    /// Rozmiar strony.
    /// </summary>
    public class RozmiarStrony
    {
        public long Szerokość { get; set; }
        public long Wysokość { get; set; }
        
        public RozmiarStrony FromPixels(long width, long height, int dpiX, int dpiY)
        {
            return new RozmiarStrony
            {
                Szerokość = FromPixels(width, dpiX),
                Wysokość = FromPixels(height, dpiY)
            };
        }

        long FromPixels(long pixels, long dpi)
        {
            //cm = pixels * 2.54cm / 96dpi
            //mm = pixels * 254mm / 96dpi
            return pixels * 254 / dpi;
        }
    }
}
