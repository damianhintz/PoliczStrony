using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Media.Imaging;
using StronyA4Domena.Abstrakcje;
using StronyA4Domena.Encje.Rozszerzenia;

namespace StronyA4Domena.Encje.Rozszerzenia
{
    /// <summary>
    /// Rozszerzenia strony.
    /// </summary>
    public static class StronaRozszerzenia
    {
        /// <summary>
        /// Wczytaj stronę z pliku jpg.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static IStrona ReadStronaFromBitmap(this string fileName)
        {
            var strona = new StronaObrazu { Plik = fileName, Numer = 1 };
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var bitmap = BitmapFrame.Create(fs);
                //var md = (BitmapMetadata)bitmap.Metadata;
                strona.Szerokość = bitmap.PixelWidth.WymiarFromPixels((int)bitmap.DpiX);
                strona.Wysokość = bitmap.PixelHeight.WymiarFromPixels((int)bitmap.DpiY);
            }
            return strona;
        }

        public static IStrona ParseFromExifTags(string fileName)
        {
            var strona = new StronaObrazu { Plik = fileName };
            //using (ExifReader reader = new ExifReader(fileName))
            {
                //long width;
                //reader.GetTagValue(ExifTags.ImageWidth, out width);
                //meta.Szerokość = width;
                //long height;
                //reader.GetTagValue(ExifTags.ImageLength, out height);
                //meta.Wysokość = height;
                //int resolution;
                //reader.GetTagValue(ExifTags.XResolution, out resolution);
                //meta.Rozdzielczość = resolution;
            }
            return strona;
        }
    }
}
