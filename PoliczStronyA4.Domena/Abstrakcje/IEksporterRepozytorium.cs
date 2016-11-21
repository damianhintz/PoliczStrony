using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StronyA4.Domena.Abstrakcje
{
    public interface IEksporterRepozytorium
    {
        void ZapiszZmiany(string connectionString);
    }
}
