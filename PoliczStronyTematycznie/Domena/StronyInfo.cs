using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoliczStronyTematycznie.Domena
{
    public class StronyInfo
    {
        public readonly int LiczbaStron;
        public readonly string Temat;
        public readonly List<int> RozmiaryStron = new List<int>();
        public string OutputString;

        public StronyInfo(int liczbaStron, string temat)
        {
            this.LiczbaStron = liczbaStron;
            this.Temat = temat;
        }

        public void DodajZakres(IEnumerable<int> rozmiary)
        {
            foreach (var r in rozmiary) DodajRozmiar(r);
        }

        public void DodajRozmiar(int rozmiar)
        {
            RozmiaryStron.Add(rozmiar);
        }
    }
}
