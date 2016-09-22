using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoliczStronyA4.Domena
{
    public interface IAnalizatorFormatuStrony
    {
        FormatStrony ObliczFormatStrony(RozmiarStrony rozmiar);
    }
}
