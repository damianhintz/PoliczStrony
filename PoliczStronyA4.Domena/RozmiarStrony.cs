using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoliczStronyA4.Domena
{
    public class RozmiarStrony
    {
        public int Szerokość { get; set; }
        public int Wysokość { get; set; }

        public RozmiarStrony(int szerokość, int wysokość)
        {
            Szerokość = szerokość;
            Wysokość = wysokość;
        }
    }
}
