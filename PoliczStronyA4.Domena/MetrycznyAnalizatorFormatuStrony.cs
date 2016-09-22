using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoliczStronyA4.Domena
{
    public class MetrycznyAnalizatorFormatuStrony : IAnalizatorFormatuStrony
    {
        public FormatStrony ObliczFormatStrony(RozmiarStrony rozmiar)
        {
            var szerokość = rozmiar.Szerokość;
            var wysokość = rozmiar.Wysokość;
            var najdłuższaKrawędź = Math.Max(szerokość, wysokość);
            var doA4 = OdległośćDoA4(szerokość, wysokość);
            var doA3 = OdległośćDoA3(szerokość, wysokość);
            var doA2 = OdległośćDoA2(szerokość, wysokość);
            var doA1 = OdległośćDoA1(szerokość, wysokość);
            var doA0 = OdległośćDoA0(szerokość, wysokość);
            var najmniejszaOdległość = doA0;
            var nazwaFormatu = "A0";
            var liczbaStronA4 = 16;
            if (najmniejszaOdległość > doA1) { nazwaFormatu = "A1"; liczbaStronA4 = 8; najmniejszaOdległość = doA1; }
            if (najmniejszaOdległość > doA2) { nazwaFormatu = "A2"; liczbaStronA4 = 4; najmniejszaOdległość = doA2; }
            if (najmniejszaOdległość > doA3) { nazwaFormatu = "A3"; liczbaStronA4 = 2; najmniejszaOdległość = doA3; }
            if (najmniejszaOdległość > doA4) { nazwaFormatu = "A4"; liczbaStronA4 = 1; najmniejszaOdległość = doA4; }
            var format = new FormatStrony(nazwaFormatu) { StronyA4 = liczbaStronA4, EfektywneStronyA4 = liczbaStronA4 };
            return format;
        }

        int OdległośćDoA0(int szerokość, int wysokość) { return Odległość(szerokość, wysokość, 840, 1192); }
        int OdległośćDoA1(int szerokość, int wysokość) { return Odległość(szerokość, wysokość, 594, 840); }
        int OdległośćDoA2(int szerokość, int wysokość) { return Odległość(szerokość, wysokość, 420, 594); }
        int OdległośćDoA3(int szerokość, int wysokość) { return Odległość(szerokość, wysokość, 297, 420); }
        int OdległośćDoA4(int szerokość, int wysokość) { return Odległość(szerokość, wysokość, 210, 297); }
        int Odległość(int szerokość, int wysokość, int szerokośćA, int wysokośćA)
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
