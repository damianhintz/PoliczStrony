using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StronyA4Domena.Encje;

namespace StronyA4.Model
{
    class FolderViewItem : ListViewItem
    {
        public string Folder => _folder.Folder;
        public string Typ => _folder.Typ;
        public string Metoda => _folder.Metoda;
        public string Pliki => _folder.Pliki.ToString();
        public string Strony => _folder.Strony.ToString();
        public string Data => _folder.Data.HasValue ? _folder.Data.ToString() : "Brak";
        public FolderStron FolderStron => _folder;
        FolderStron _folder;

        public FolderViewItem(FolderStron folder) : base(folder.Folder)
        {
            _folder = folder;
            Odśwież();
            Tag = folder;
        }

        public void Odśwież()
        {
            SubItems.Clear();
            SubItems[0].Text = Folder;
            SubItems.Add(Typ);
            SubItems.Add(Metoda);
            SubItems.Add(Pliki);
            SubItems.Add(Strony);
            SubItems.Add(Data);
        }
    }
}
