using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4Domena.Encje;

namespace StronyA4Domena.Abstrakcje
{
    public interface IStrona : IWymiarowalny
    {
        string Plik { get; set; }
        int Numer { get; set; }
        //DateTime Data { get; set; }
    }
}
