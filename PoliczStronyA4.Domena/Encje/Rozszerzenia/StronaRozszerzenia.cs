using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Media.Imaging;
using StronyA4.Domena.Abstrakcje;

namespace StronyA4.Domena.Encje.Rozszerzenia
{
    public static class StronaRozszerzenia
    {
        public static IStrona ParseStronaFromBitmap(this string fileName)
        {
            var strona = new StronaObrazu { Plik = fileName };
            using (FileStream fs = new FileStream(fileName,
                FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var bitmap = BitmapFrame.Create(fs);
                //var md = (BitmapMetadata)bitmap.Metadata;
                var rozmiar = new RozmiarStrony
                {
                    Szerokość = bitmap.PixelWidth,
                    Wysokość = bitmap.PixelHeight
                };
                strona.Rozmiar = rozmiar;
                var dpi = new RozdzielczośćStrony
                {
                    X = (int)bitmap.DpiX,
                    Y = (int)bitmap.DpiY
                };
            }
            return strona;
        }
    }
}
