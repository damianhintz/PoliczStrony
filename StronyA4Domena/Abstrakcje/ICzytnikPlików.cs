using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StronyA4Domena.Abstrakcje
{
    public interface ICzytnikPlików
    {
        IEnumerable<string> Pliki { get; }
        IEnumerable<string> Wczytaj(string folder);
    }
}
