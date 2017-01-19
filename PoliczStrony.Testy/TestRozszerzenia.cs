using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StronyA4Testy
{
    static class TestRozszerzenia
    {
        public static string SamplesFolder = @"..\..\Samples";

        public static string GetSamplePath(this string name)
        {
            return Path.Combine(SamplesFolder, name);
        }
    }
}
