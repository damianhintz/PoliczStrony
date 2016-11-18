using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4.Domena.Abstrakcje;

namespace StronyA4.Domena
{
    /// <summary>
    /// Klasyfikator formatu strony na podstawie podobieństwa do standardowych formatów.
    /// </summary>
    public class MetrycznyKlasyfikatorStrony : IKlasyfikatorStrony
    {
        FormatStrony _formatA6 = new FormatStrony
        {
            Nazwa = "A6",
            Rozmiar = new RozmiarStrony { Szerokość = 105, Wysokość = 148 }, //105×148
            StronyA4 = 0.25
        };
        FormatStrony _formatA5 = new FormatStrony
        {
            Nazwa = "A5",
            Rozmiar = new RozmiarStrony { Szerokość = 148, Wysokość = 210 }, //148, 210
            StronyA4 = 0.5
        };
        FormatStrony _formatA4 = new FormatStrony
        {
            Nazwa = "A4",
            Rozmiar = new RozmiarStrony { Szerokość = 210, Wysokość = 297 }, //210, 297
            StronyA4 = 1
        };
        FormatStrony _formatA3 = new FormatStrony
        {
            Nazwa = "A3",
            Rozmiar = new RozmiarStrony { Szerokość = 297, Wysokość = 420 }, //297, 420
            StronyA4 = 2
        };
        FormatStrony _formatA2 = new FormatStrony
        {
            Nazwa = "A2",
            Rozmiar = new RozmiarStrony { Szerokość = 420, Wysokość = 594 }, //420, 594
            StronyA4 = 4
        };
        FormatStrony _formatA1 = new FormatStrony
        {
            Nazwa = "A1",
            Rozmiar = new RozmiarStrony { Szerokość = 594, Wysokość = 840 }, //594, 840
            StronyA4 = 8
        };
        FormatStrony _formatA0 = new FormatStrony
        {
            Nazwa = "A0",
            Rozmiar = new RozmiarStrony { Szerokość = 840, Wysokość = 1189 }, //840, 1189
            StronyA4 = 16
        };

        FormatStrony _format2A0 = new FormatStrony
        {
            Nazwa = "2A0",
            Rozmiar = new RozmiarStrony { Szerokość = 1189, Wysokość = 1682 }, //1189×1682
            StronyA4 = 32
        };

        public FormatStrony UstalFormatStrony(RozmiarStrony rozmiar)
        {
            var formaty = new[] { _formatA0, _formatA1, _formatA2, _formatA3, _formatA4 };
            var najbliższyFormat = formaty.First();
            var najmniejszaOdległość = Odległość(rozmiar, najbliższyFormat.Rozmiar);
            foreach (var format in formaty.Skip(1))
            {
                var odległość = Odległość(format.Rozmiar, rozmiar);
                if (odległość < najmniejszaOdległość)
                {
                    najmniejszaOdległość = odległość;
                    najbliższyFormat = format;
                }
            }
            return najbliższyFormat;
        }

        long Odległość(RozmiarStrony r1, RozmiarStrony r2)
        {
            return Odległość(
                r1.Szerokość, r1.Wysokość,
                r2.Szerokość, r2.Wysokość);
        }

        long Odległość(long szerokość, long wysokość, long szerokośćA, long wysokośćA)
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
    }
}
