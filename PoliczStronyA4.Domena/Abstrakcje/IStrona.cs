using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StronyA4.Domena.Abstrakcje
{
    public interface IStrona
    {
        string Plik { get; set; }
        int Numer { get; set; }
        //RozmiarStrony Rozmiar {get;set;}
        //Rozdzielczość Rozdzielczość { get; set; }
        //DateTime Data { get; set; }
    }
}
