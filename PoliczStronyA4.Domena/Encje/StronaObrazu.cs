using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4.Domena.Abstrakcje;

namespace StronyA4.Domena.Encje
{
    /// <summary>
    /// Reprezentuje stronę obrazu w pliku.
    /// </summary>
    public class StronaObrazu : IStrona
    {
        /// <summary>
        /// Nazwa pliku.
        /// </summary>
        public string Plik { get; set; }

        /// <summary>
        /// Numer strony w pliku.
        /// </summary>
        public int Numer { get; set; }
        
        public WymiarStrony Szerokość { get; set; }
        public WymiarStrony Wysokość { get; set; }
    }
}
