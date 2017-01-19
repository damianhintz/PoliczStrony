using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StronyA4Domena.Encje
{
    public class Profil
    {
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public FolderStron[] Foldery { get; set; }
    }
}
