using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4Domena.Abstrakcje;

namespace StronyA4Domena.Encje
{
    public class FormatStrony : IWymiarowalny
    {
        /// <summary>
        /// Standardowa nazwa formatu (A0, A1, A2, A3, A4, A5, A6,...).
        /// </summary>
        public string Nazwa { get; set; }
        
        /// <summary>
        /// Szerokość.
        /// </summary>
        public WymiarStrony Szerokość { get; set; }

        /// <summary>
        /// Wysokość.
        /// </summary>
        public WymiarStrony Wysokość { get; set; }

        /// <summary>
        /// Liczba stron w przeliczeniu na format A4.
        /// </summary>
        public double StronyA4 { get; set; }

        /// <summary>
        /// Liczba strona A4, które można wydrukować na formacie o podanym rozmiarze.
        /// </summary>
        public int EfektywneStronyA4 => (int)Math.Round(StronyA4);
        
    }
}
