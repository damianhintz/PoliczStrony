﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StronyA4.Domena.Abstrakcje
{
    public interface IRepozytoriumStron
    {
        IEnumerable<string> Pliki { get; }
        IQueryable<IStrona> Strony { get; }
        void ZapiszZmiany();
        void Dodaj(IStrona strona);
    }
}
