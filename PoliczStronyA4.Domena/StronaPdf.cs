using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StronyA4.Domena
{
    public class StronaPdf
    {
        public string FileName { get; set; }
        public int NumerStrony { get; set; }
        public RozmiarStrony RozmiarPunkty { get; set; }
        public RozmiarStrony RozmiarMilimetry { get; set; }

        public StronaPdf(string fileName)
        {
            FileName = fileName;
        }
    }
}
