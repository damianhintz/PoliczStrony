using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StronyA4Domena.Encje
{
    public class Profile
    {
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public List<FolderStron> Foldery { get; set; }
    }
}
