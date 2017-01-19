using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StronyA4Domena.Abstrakcje;
using System.IO;

namespace StronyA4Domena.Repozytoria
{
    /// <summary>
    /// Repozytorium stron.
    /// </summary>
    public class RepozytoriumStron : IRepozytoriumStron
    {
        /// <summary>
        /// Lista plików.
        /// </summary>
        public IEnumerable<string> Pliki => Strony.Select(s => s.Plik).Distinct();

        /// <summary>
        /// Lista stron w plikach.
        /// </summary>
        public IQueryable<IStrona> Strony => _strony.AsQueryable();
        List<IStrona> _strony = new List<IStrona>();
        
        /// <summary>
        /// Dodaj stronę do repozytorium.
        /// </summary>
        /// <param name="strona"></param>
        public void Dodaj(IStrona strona)
        {
            _strony.Add(strona);
        }
        
    }
}
