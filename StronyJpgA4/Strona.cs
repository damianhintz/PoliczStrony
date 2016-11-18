using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExifLib;
using System.IO;
using System.Windows.Media.Imaging;

namespace StronyJpg
{
    class Strona
    {
        public string Plik { get; set; }
        public long Szerokość { get; set; }
        public long Wysokość { get; set; }
        public int Resolution { get; set; }

        public static Strona ParseFromExifTags(string fileName)
        {
            var meta = new Strona { Plik = fileName };
            using (ExifReader reader = new ExifReader(fileName))
            {
                long width;
                reader.GetTagValue(ExifTags.ImageWidth, out width);
                meta.Szerokość = width;
                long height;
                reader.GetTagValue(ExifTags.ImageLength, out height);
                meta.Wysokość = height;
                int resolution;
                reader.GetTagValue(ExifTags.XResolution, out resolution);
                meta.Resolution = resolution;
            }
            return meta;
        }

        public static Strona ParseFromBitmap(FileInfo f)
        {
            var meta = new Strona { Plik = f.FullName };
            using (FileStream fs = new FileStream(f.FullName,
                FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var img = BitmapFrame.Create(fs);
                var md = (BitmapMetadata)img.Metadata;
                //string date = md.DateTaken;
                meta.Szerokość = img.PixelWidth;
                meta.Wysokość = img.PixelHeight;
                meta.Resolution = (int)img.DpiX;
            }
            return meta;
        }
    }
}
