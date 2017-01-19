using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4Domena.Abstrakcje;

namespace StronyA4Domena.Encje.Rozszerzenia
{
    public static class WymiarRozszerzenia
    {
        public static int OdległośćPixelowa(this IWymiarowalny w1, IWymiarowalny w2)
        {
            return Odległość(
                w1.Szerokość.Pixels, w1.Wysokość.Pixels, 
                w2.Szerokość.Pixels, w2.Wysokość.Pixels);
        }

        static int Odległość(int szerokość, int wysokość, int szerokośćA, int wysokośćA)
        {
            //Połóż na dłuższym boku
            var dłuższy = Math.Max(szerokość, wysokość);
            var krótszy = Math.Min(szerokość, wysokość);
            //Połóż na dłuższym boku
            var dłuższyA = Math.Max(szerokośćA, wysokośćA);
            var krótszyA = Math.Min(szerokośćA, wysokośćA);
            //Oblicz odległość
            var dłuższyRóżnica = dłuższy - dłuższyA;
            var krótszyRóżnica = krótszy - krótszyA;
            return dłuższyRóżnica * dłuższyRóżnica + krótszyRóżnica * krótszyRóżnica;
        }

        public static WymiarStrony WymiarFromPixels(this int pixels, int dpi)
        {
            return new WymiarStrony { Pixels = pixels, Rozdzielczość = dpi };
        }

        public static WymiarStrony MmToWymiar(this int mm)
        {
            return mm.WymiarFromMm();
        }

        public static WymiarStrony WymiarFromMm(this int mm)
        {
            var dpi = 300; //standardowa rozdzielczość
            return new WymiarStrony {
                Pixels = (int)Math.Round(mm * dpi / WymiarStrony.CalNaMm),
                Rozdzielczość = dpi };
        }

        public static WymiarStrony WymiarFromPoints(this float points)
        {
            var pt = WymiarStrony.CalNaMm / 72; //0.3528 = 25.4 / 72
            var mm = (int)Math.Round(points * pt);
            return mm.WymiarFromMm();
        }

    }
}
