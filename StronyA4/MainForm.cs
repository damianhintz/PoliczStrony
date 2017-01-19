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
                    if (item.Selected) items.Add(item);
                }
                return items;
            }
        }
        List<FolderStron> Foldery => _profile.Foldery;
        Profile _profile;

        public MainForm()
        {
            InitializeComponent();
            folderView.RetrieveVirtualItem += FolderView_RetrieveVirtualItem;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "Wczytywanie profilu " + Settings.Default.Profile;
            _profile = Settings.Default.Profile.WczytajProfil();
            //Foldery.AddRange(_profile.Foldery);
            folderView.VirtualListSize = Foldery.Count;
        }

        private void FolderView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            var folder = Foldery[e.ItemIndex];
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
            Foldery.Add(folder);
            folderView.VirtualListSize = Foldery.Count;
            statusLabel.Text = "Autozapis profilu " + Settings.Default.Profile;
            Settings.Default.Profile.ZapiszProfil(_profile);
        }

        private void odświeżMenuItem_Click(object sender, EventArgs e)
        {
            var items = Zaznaczone;
            var pliki = 0;
            foreach (var item in items)
            {
                pliki += PoliczStronyA4(item.FolderStron);
                item.Odśwież();
            }
            statusLabel.Text = "Autozapis profilu " + Settings.Default.Profile;
            Settings.Default.Profile.ZapiszProfil(_profile);
            MessageBox.Show(owner: this,
                text: "Wczytane foldery: " + items.Count() +
                "\nWczytane pliki: " + pliki +
                "\nKoniec.",
                caption: (sender as ToolStripItem).Text);
        }

        int PoliczStronyA4(FolderStron folder)
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
            return folder.Pliki;
        }

    }
}
