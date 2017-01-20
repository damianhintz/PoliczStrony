using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StronyA4Domena.Encje
{
    /// <summary>
    /// Folder z plikami do zliczenia stron A4.
    /// </summary>
    public class FolderStron
    {
        public string Folder { get; set; }
        public string Typ { get; set; } = "pdf";
        public string Metoda { get; set; } = "stosunekPowierzchni"; //metrykaEuklidesowa,klasyfikator
        public int Pliki { get; set; }
        public int Strony { get; set; }
        public int StronyA4 { get; set; }
        public DateTime? Data { get; set; }
    }
}
