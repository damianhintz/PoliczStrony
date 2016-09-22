using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Globalization;

namespace PoliczStronyTematycznie.Domena
{
    public static class StronyReader
    {
        public static StronyInfo WczytajStrony(this string fileName)
        {
            string outputString = fileName.ReadString();
            return outputString.ParseInfo();
        }

        private static string ReadString(this string fileName)
        {
            ProcessStartInfo info = new ProcessStartInfo("pdfinfo.exe", "-l -1 \"" + fileName + "\"");
            info.RedirectStandardOutput = true;
            info.UseShellExecute = false;
            Process proc = Process.Start(info);
            proc.WaitForExit(5000);
            StreamReader reader = proc.StandardOutput;
            return reader.ReadToEnd();
        }

        private static StronyInfo ParseInfo(this string outputString)
        {
            StringReader reader = new StringReader(outputString);
            int liczbaStron = 0;
            string temat = "<brak tematu>";
            string linia = null;
            List<int> rozmiary = new List<int>();
            while ((linia = reader.ReadLine()) != null)
            {
                if (linia.StartsWith("Pages:"))
                {
                    liczbaStron = int.Parse(linia.Replace("Pages:          ", ""));
                }
                else if (linia.StartsWith("Subject:"))
                {
                    temat = linia.Replace("Subject:        ", "");
                }
                else if (linia.StartsWith("Page "))
                {
                    //Page    1 size: 622 x 902 pts
                    string[] pola = linia.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    double w = double.Parse(pola[3], CultureInfo.InvariantCulture);
                    double h = double.Parse(pola[5], CultureInfo.InvariantCulture);
                    double a = w > h ? (w * 0.3528) : (h * 0.3528);
                    rozmiary.Add((int)Math.Round(a));
                }
            }
            reader.Close();
            StronyInfo info = new StronyInfo(liczbaStron, temat);
            info.DodajZakres(rozmiary);
            info.OutputString = outputString;
            return info;
        }
    }
}
