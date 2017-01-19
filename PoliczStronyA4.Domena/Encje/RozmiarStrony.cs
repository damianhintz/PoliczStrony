using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4Domena.Abstrakcje;
using StronyA4Domena.Encje.Rozszerzenia;

namespace StronyA4Domena.Encje
{
    /// <summary>
    /// Rozmiar strony.
    /// </summary>
    public class RozmiarStrony : IWymiarowalny
    {
        public WymiarStrony Szerokość { get; set; }
        public WymiarStrony Wysokość { get; set; }
        
        public static RozmiarStrony RozmiarFromPixels(int width, int height, int dpiX, int dpiY)
        {
            return new RozmiarStrony
            {
                Szerokość = width.WymiarFromPixels(dpiX),
                Wysokość = height.WymiarFromPixels(dpiY)
            };
        }

        public static RozmiarStrony RozmiarFromMm(int width, int height)
        {
            return new RozmiarStrony
            {
                Szerokość = width.WymiarFromMm(),
                Wysokość = height.WymiarFromMm()
            };
        }
    }
}
