using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoliczStronyA4.Domena
{
    public class FormatStrony
    {
        /// <summary>
        /// Standardowa nazwa formatu (A0, A1, A2, ...).
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Liczba stron w przeliczeniu na format A4.
        /// </summary>
        public int StronyA4 { get; set; }
        /// <summary>
        /// Liczba strona A4, które można wydrukować na formacie o podanym rozmiarze.
        /// </summary>
        public int EfektywneStronyA4 { get; set; }

        public FormatStrony() : this("Nieokreślony format") { }
        public FormatStrony(string nazwa) { Nazwa = nazwa; }
        public override string ToString() { return Nazwa; }
    }
}
