using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4.Domena.Encje;

namespace StronyA4.Domena.Abstrakcje
{
    public interface IWymiarowalny
    {
        WymiarStrony Szerokość { get; }
        WymiarStrony Wysokość { get; }
    }
}
