using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4.Domena.Encje;

namespace StronyA4.Domena.Abstrakcje
{
    public interface IStrona : IWymiarowalny
    {
        string Plik { get; set; }
        int Numer { get; set; }
        //DateTime Data { get; set; }
    }
}
