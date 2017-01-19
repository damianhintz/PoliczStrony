using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace StronyA4Domena.Encje.Rozszerzenia
{
    public static class FolderRozszerzenia
    {
        /// <summary>
        /// Wczytaj profil z pliku json.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Profil WczytajProfil(this string fileName)
        {
            var json = File.ReadAllText(fileName, Encoding.GetEncoding(1250));
            return JsonConvert.DeserializeObject<Profil>(json);
        }

    }
}
