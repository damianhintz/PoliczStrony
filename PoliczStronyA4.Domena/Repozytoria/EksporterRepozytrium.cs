using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using StronyA4.Domena.Abstrakcje;

namespace StronyA4.Domena.Repozytoria
{
    public class EksporterRepozytrium : IEksporterRepozytorium
    {
        public void ZapiszZmiany(string fileName)
        {
            Encoding kodowanie = Encoding.GetEncoding(1250);
            //StreamWriter _writer;
            using (var writer = new StreamWriter(fileName, false, kodowanie))
            {
                writer.WriteLine("Nazwa pliku\tNumer strony\tSzerokość[punkty]\tWysokość[punkty]\tSzerokość[mm]\tWysokość[mm]\tFormat arkusza\tLiczba stron A4");
                //_writer.WriteLine("{0}\t{1}\t{2:F0}\t{3:F0}\t{4:F0}\t{5:F0}\t{6}\t{7}", strona.Plik, strona.Numer,
                //    strona.RozmiarPunkty.Szerokość, strona.RozmiarPunkty.Wysokość,
                //    strona.RozmiarMilimetry.Szerokość, strona.RozmiarMilimetry.Wysokość,
                //    format, format.StronyA4);
            }
        }
    }
}
