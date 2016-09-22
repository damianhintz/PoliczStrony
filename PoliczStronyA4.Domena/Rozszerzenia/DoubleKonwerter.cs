using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoliczStronyA4.Domena.Rozszerzenia
{
    public static class DoubleKonwerter
    {
        public static int ToInt(this double value)
        {
            return int.Parse(string.Format("{0:F0}", value));
        }

        public static int ToInt(this float value)
        {
            return int.Parse(string.Format("{0:F0}", value));
        }
    }
}
