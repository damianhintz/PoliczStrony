using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4Domena.Encje;

namespace StronyA4Domena.Abstrakcje
{
    public interface IKlasyfikatorStrony
    {
        IEnumerable<FormatStrony> Formaty { get; }
        FormatStrony UstalFormatStrony(IWymiarowalny strona);
        void DodajFormat(string nazwa);
        void DodajFormat(FormatStrony format);
    }
}
