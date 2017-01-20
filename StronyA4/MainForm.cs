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
using System.Diagnostics;
using System.IO;
using StronyA4Domena.Repozytoria.Rozszerzenia;

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
            Status("Wczytywanie profilu " + Settings.Default.Profile);
            _profile = Settings.Default.Profile.WczytajProfil();
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
            AutozapisProfilu();
        }

        void AutozapisProfilu()
        {
            Status("Autozapis profilu " + Settings.Default.Profile);
            Settings.Default.Profile.ZapiszProfil(_profile);
        }

        private void odświeżMenuItem_Click(object sender, EventArgs e)
        {
            var items = Zaznaczone;
            var pliki = 0;
            var strony = 0;
            var stronyA4 = 0;
            var errors = new List<string>();
            foreach (var item in items)
            {
                var folderErrors = PoliczStronyA4(item.FolderStron);
                errors.AddRange(folderErrors);
                pliki += item.FolderStron.Pliki;
                strony += item.FolderStron.Strony;
                stronyA4 += item.FolderStron.StronyA4;
                item.Odśwież();
            }
            AutozapisProfilu();
            var icon = MessageBoxIcon.Information;
            if (errors.Count > 0) icon = MessageBoxIcon.Warning;
            MessageBox.Show(owner: this,
                text: "Wczytane foldery: " + items.Count() +
                "\nWczytane pliki: " + pliki + " (" + errors.Count + " błędów)" +
                "\nWczytane strony: " + strony +
                "\nWczytane strony A4: " + stronyA4 +
                "\nKoniec.",
                caption: (sender as ToolStripItem).Text,
                buttons: MessageBoxButtons.OK,
                icon: icon);
            PokażPlik(errors);
        }

        void PokażPlik(IEnumerable<string> records)
        {
            if (!records.Any()) return;
            var fileName = Path.GetTempFileName();
            fileName = Path.ChangeExtension(fileName, "txt");
            File.WriteAllLines(fileName, records);
            Process.Start(fileName);
        }

        IEnumerable<string> PoliczStronyA4(FolderStron folder)
        {
            Status("Wczytywanie folderu " + folder.Folder);
            IRepozytoriumStron strony = new RepozytoriumStron();
            ICzytnikPlików czytnik;
            var typ = folder.Typ;
            if (typ.Equals("pdf")) czytnik = new CzytnikPlikówPdf(strony);
            else if (typ.Equals("jpg")) czytnik = new CzytnikPlikówJpg(strony);
            else throw new NotImplementedException("Brak implementacji importera plików typu: " + typ);
            var pliki = czytnik.Wczytaj(folder.Folder);
            var errors = new List<string>();
            foreach (var plik in pliki)
            {
                Status("Wczytywanie pliku " + plik);
                if (plik.Contains("ERROR:")) errors.Add(plik);
            }
            folder.Pliki = strony.Pliki.Count();
            folder.Strony = strony.Strony.Count();
            Status("Klasyfikowanie stron w folderze " + folder.Folder + ", za pomocą metody " + folder.Metoda);
            var formats = Settings.Default.Formaty.Split(',');
            var stronyA4 = 0;
            if (folder.Metoda.Equals("stosunekPowierzchni")) stronyA4 = strony.SumaStronA4Powierzchniowo(formats);
            else stronyA4 = strony.SumaStronA4Metrycznie(formats);
            folder.StronyA4 = stronyA4;
            folder.Data = DateTime.Now;
            return errors;
        }

        void Status(string msg)
        {
            statusLabel.Text = msg;
            Application.DoEvents();
        }

        private void usuńFolderMenuItem_Click(object sender, EventArgs e)
        {
            var items = Zaznaczone;
            foreach (var item in items)
            {
                var folder = item.FolderStron;
                Foldery.Remove(folder);
            }
            folderView.VirtualListSize = Foldery.Count;
            AutozapisProfilu();
            MessageBox.Show(owner: this,
                text: "Usunięte foldery: " + items.Count() +
                "\nKoniec.",
                caption: (sender as ToolStripItem).Text);
        }

        private void pokażFolderMenuItem_Click(object sender, EventArgs e)
        {
            var items = Zaznaczone;
            if (items.Count() != 1) return;
            var item = items.Single();
            Process.Start(item.Folder);
        }

        private void czytajToMenuItem_Click(object sender, EventArgs e)
        {
            var fileName = (sender as ToolStripItem).Tag as string;
            if (!File.Exists(fileName)) return;
            Process.Start(fileName);
        }

        private void zaznaczWszystkoMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < folderView.VirtualListSize; i++)
            {
                folderView.Items[i].Selected = true;
            }
        }

        private void odwróćZaznaczenieMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < folderView.VirtualListSize; i++)
            {
                folderView.Items[i].Selected = !folderView.Items[i].Selected;
            }
        }

        private void zmieńTypMenuItem_Click(object sender, EventArgs e)
        {
            var items = Zaznaczone;
            foreach (var item in items)
            {
                item.FolderStron.Typ = (sender as ToolStripItem).Tag as string;
                item.Odśwież();
            }
            AutozapisProfilu();
        }

        private void zmieńMetodęMenuItem_Click(object sender, EventArgs e)
        {
            var items = Zaznaczone;
            foreach (var item in items)
            {
                item.FolderStron.Metoda = (sender as ToolStripItem).Tag as string;
                item.Odśwież();
            }
            AutozapisProfilu();
        }

        private void pokażZaznaczenieMenuItem_Click(object sender, EventArgs e)
        {
            var items = Zaznaczone;
            var records = new List<string>();
            records.Add("Folder\tTyp\tMetoda\tPliki\tStrony\tStrony A4\tData");
            foreach (var item in items)
            {
                var folder = item.FolderStron;
                var record = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}",
                    folder.Folder, folder.Typ, folder.Metoda,
                    folder.Pliki, folder.Strony, folder.StronyA4,
                    folder.Data);
                records.Add(record);
            }
            PokażPlik(records);
        }

        private void zaznaczNoweMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < folderView.VirtualListSize; i++)
            {
                var item = folderView.Items[i] as FolderViewItem;
                var folder = item.FolderStron;
                item.Selected = !folder.Data.HasValue;
            }
        }

        private void zaznaczNieaktualneMenuItem_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            for (int i = 0; i < folderView.VirtualListSize; i++)
            {
                var item = folderView.Items[i] as FolderViewItem;
                var folder = item.FolderStron;
                if (!folder.Data.HasValue) continue; //Pomiń nowe foldery
                var dni = now - folder.Data.Value;
                item.Selected = dni.Days > Settings.Default.AktualneDni;
            }
        }
    }
}
