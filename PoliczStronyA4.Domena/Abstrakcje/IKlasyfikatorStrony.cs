﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4.Domena.Encje;

namespace StronyA4.Domena.Abstrakcje
{
    public interface IKlasyfikatorStrony
    {
        FormatStrony UstalFormatStrony(IWymiarowalny strona);
    }
}
