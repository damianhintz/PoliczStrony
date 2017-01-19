using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using StronyA4.Model;
using StronyA4.Properties;
using StronyA4Domena.Encje;
using StronyA4Domena.Encje.Rozszerzenia;
using StronyA4Domena.Abstrakcje;
using StronyA4Domena.Repozytoria;

namespace StronyA4
{
    /// <summary>
    /// Główny formularz aplikacji.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Zaznaczone foldery w widoku.
        /// </summary>
        IEnumerable<FolderViewItem> Zaznaczone
        {
            get
            {
                var items = new List<FolderViewItem>();
                for (int i = 0; i < folderView.VirtualListSize; i++)
                {
                    var item = folderView.Items[i] as FolderViewItem;
                    items.Add(item);
                }
                return items;
            }
        }
        List<FolderStron> _foldery = new List<FolderStron>();

        public MainForm()
        {
            InitializeComponent();
            folderView.RetrieveVirtualItem += FolderView_RetrieveVirtualItem;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var profile = Settings.Default.Profile.WczytajProfil();
            _foldery.AddRange(profile.Foldery);
            folderView.VirtualListSize = _foldery.Count;
        }

        private void FolderView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            var folder = _foldery[e.ItemIndex];
            var item = new FolderViewItem(folder);
            e.Item = item;
        }

        private void zakończMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dodajFolderMenuItem_Click(object sender, EventArgs e)
        {
            var browser = new FolderBrowserDialog();
            var result = browser.ShowDialog(this);
            if (result != DialogResult.OK) return; //Anulowano dodawanie folderu
            var folder = new FolderStron { Folder = browser.SelectedPath };
            _foldery.Add(folder);
            folderView.VirtualListSize = _foldery.Count;
            //Settings.Default.Profile.ZapiszProfil
        }

        private void odświeżMenuItem_Click(object sender, EventArgs e)
        {
            var items = Zaznaczone;
            foreach (var item in items)
            {
                PoliczStronyA4(item.FolderStron);
                item.Odśwież();
            }
            MessageBox.Show(owner: this, 
                text: "Koniec.", caption: (sender as ToolStripItem).Text);
        }

        void PoliczStronyA4(FolderStron folder)
        {
            IRepozytoriumStron strony = new RepozytoriumStron();
            ICzytnikPlików czytnik;
            var typ = folder.Typ;
            if (typ.Equals("pdf")) czytnik = new CzytnikPlikówPdf(strony);
            else if (typ.Equals("jpg")) czytnik = new CzytnikPlikówJpg(strony);
            else throw new NotImplementedException("Brak implementacji importera plików typu: " + typ);
            czytnik.Wczytaj(folder.Folder);
            folder.Pliki = strony.Pliki.Count();
            folder.Strony = strony.Strony.Count();
            folder.Data = DateTime.Now;
        }

    }
}
