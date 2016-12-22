using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using StronyA4.Domena.Abstrakcje;

namespace StronyA4.Domena.Repozytoria
{
    public class EksporterRepozytorium : IEksporterRepozytorium
    {
        IRepozytoriumStron _repozytorium;

        public EksporterRepozytorium(IRepozytoriumStron repozytorium)
        {
            _repozytorium = repozytorium;
        }

        public IEnumerable<string> ZapiszZmiany(string fileName)
        {
            var records = new List<string>();
            foreach (var strona in _repozytorium.Strony)
            {
                var record = string.Format("{0}\t{1}\t{2}\t{3}",
                    strona.Plik, strona.Numer,
                    strona.Szerokość.Rozdzielczość, strona.Wysokość.Rozdzielczość);
                records.Add(record);
            }
            File.WriteAllLines(fileName, records, Encoding.GetEncoding(1250));
            return records;
        }
    }
}
