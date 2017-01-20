namespace StronyA4
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.plikMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczNoweMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczNieaktualneMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.odwróćZaznaczenieMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.pokażZaznaczenieMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czytajToMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.odświeżMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pokażFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.zmieńTypMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plikiPdfMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plikiJpgMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńMetodęMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stosunekPowierzchniMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metrykaEuklidesowaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.usuńFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.folderView = new System.Windows.Forms.ListView();
            this.folderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metodaHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plikiHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stronyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stronyA4Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.folderMenu.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Menu;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikMenuItem,
            this.widokMenuItem,
            this.pomocMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(1069, 26);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // plikMenuItem
            // 
            this.plikMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajFolderMenuItem,
            this.toolStripSeparator1,
            this.zakończMenuItem});
            this.plikMenuItem.Name = "plikMenuItem";
            this.plikMenuItem.Size = new System.Drawing.Size(39, 22);
            this.plikMenuItem.Text = "Plik";
            // 
            // dodajFolderMenuItem
            // 
            this.dodajFolderMenuItem.Name = "dodajFolderMenuItem";
            this.dodajFolderMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.dodajFolderMenuItem.Size = new System.Drawing.Size(226, 26);
            this.dodajFolderMenuItem.Text = "Dodaj folder...";
            this.dodajFolderMenuItem.ToolTipText = "Wybierz folder z plikami do zliczenia stron A4";
            this.dodajFolderMenuItem.Click += new System.EventHandler(this.dodajFolderMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // zakończMenuItem
            // 
            this.zakończMenuItem.Name = "zakończMenuItem";
            this.zakończMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zakończMenuItem.Size = new System.Drawing.Size(226, 26);
            this.zakończMenuItem.Text = "Zakończ";
            this.zakończMenuItem.Click += new System.EventHandler(this.zakończMenuItem_Click);
            // 
            // widokMenuItem
            // 
            this.widokMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaznaczWszystkoMenuItem,
            this.zaznaczNoweMenuItem,
            this.zaznaczNieaktualneMenuItem,
            this.toolStripSeparator3,
            this.odwróćZaznaczenieMenuItem,
            this.toolStripSeparator6,
            this.pokażZaznaczenieMenuItem});
            this.widokMenuItem.Name = "widokMenuItem";
            this.widokMenuItem.Size = new System.Drawing.Size(59, 22);
            this.widokMenuItem.Text = "Widok";
            // 
            // zaznaczWszystkoMenuItem
            // 
            this.zaznaczWszystkoMenuItem.Name = "zaznaczWszystkoMenuItem";
            this.zaznaczWszystkoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.zaznaczWszystkoMenuItem.Size = new System.Drawing.Size(263, 26);
            this.zaznaczWszystkoMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoMenuItem_Click);
            // 
            // zaznaczNoweMenuItem
            // 
            this.zaznaczNoweMenuItem.Name = "zaznaczNoweMenuItem";
            this.zaznaczNoweMenuItem.Size = new System.Drawing.Size(263, 26);
            this.zaznaczNoweMenuItem.Text = "Zaznacz nowe";
            this.zaznaczNoweMenuItem.ToolTipText = "Zaznacz foldery, dla których nie zliczano jeszcze stron";
            this.zaznaczNoweMenuItem.Click += new System.EventHandler(this.zaznaczNoweMenuItem_Click);
            // 
            // zaznaczNieaktualneMenuItem
            // 
            this.zaznaczNieaktualneMenuItem.Name = "zaznaczNieaktualneMenuItem";
            this.zaznaczNieaktualneMenuItem.Size = new System.Drawing.Size(263, 26);
            this.zaznaczNieaktualneMenuItem.Text = "Zaznacz nieaktualne";
            this.zaznaczNieaktualneMenuItem.ToolTipText = "Zaznacz fodlery, dla których zliczano strony, ale dawno temu";
            this.zaznaczNieaktualneMenuItem.Click += new System.EventHandler(this.zaznaczNieaktualneMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(260, 6);
            // 
            // odwróćZaznaczenieMenuItem
            // 
            this.odwróćZaznaczenieMenuItem.Name = "odwróćZaznaczenieMenuItem";
            this.odwróćZaznaczenieMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.odwróćZaznaczenieMenuItem.Size = new System.Drawing.Size(263, 26);
            this.odwróćZaznaczenieMenuItem.Text = "Odwróć zaznaczenie";
            this.odwróćZaznaczenieMenuItem.Click += new System.EventHandler(this.odwróćZaznaczenieMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(260, 6);
            // 
            // pokażZaznaczenieMenuItem
            // 
            this.pokażZaznaczenieMenuItem.Name = "pokażZaznaczenieMenuItem";
            this.pokażZaznaczenieMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pokażZaznaczenieMenuItem.Size = new System.Drawing.Size(263, 26);
            this.pokażZaznaczenieMenuItem.Text = "Pokaż zaznaczenie";
            this.pokażZaznaczenieMenuItem.Click += new System.EventHandler(this.pokażZaznaczenieMenuItem_Click);
            // 
            // pomocMenuItem
            // 
            this.pomocMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czytajToMenuItem});
            this.pomocMenuItem.Name = "pomocMenuItem";
            this.pomocMenuItem.Size = new System.Drawing.Size(64, 22);
            this.pomocMenuItem.Text = "Pomoc";
            // 
            // czytajToMenuItem
            // 
            this.czytajToMenuItem.Name = "czytajToMenuItem";
            this.czytajToMenuItem.Size = new System.Drawing.Size(141, 26);
            this.czytajToMenuItem.Tag = "README.md";
            this.czytajToMenuItem.Text = "Czytaj to";
            this.czytajToMenuItem.ToolTipText = "README.md";
            this.czytajToMenuItem.Click += new System.EventHandler(this.czytajToMenuItem_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.Menu;
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 516);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.status.Size = new System.Drawing.Size(1069, 23);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(57, 18);
            this.statusLabel.Text = "Gotowe";
            // 
            // folderMenu
            // 
            this.folderMenu.BackColor = System.Drawing.SystemColors.Menu;
            this.folderMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.folderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odświeżMenuItem,
            this.toolStripSeparator2,
            this.pokażFolderMenuItem,
            this.toolStripSeparator4,
            this.zmieńTypMenuItem,
            this.zmieńMetodęMenuItem,
            this.toolStripSeparator5,
            this.usuńFolderMenuItem});
            this.folderMenu.Name = "folderMenu";
            this.folderMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.folderMenu.Size = new System.Drawing.Size(250, 152);
            // 
            // odświeżMenuItem
            // 
            this.odświeżMenuItem.Name = "odświeżMenuItem";
            this.odświeżMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.odświeżMenuItem.Size = new System.Drawing.Size(249, 26);
            this.odświeżMenuItem.Text = "Policz strony";
            this.odświeżMenuItem.ToolTipText = "Policz strony A4 w podanym folderze";
            this.odświeżMenuItem.Click += new System.EventHandler(this.odświeżMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(246, 6);
            // 
            // pokażFolderMenuItem
            // 
            this.pokażFolderMenuItem.Name = "pokażFolderMenuItem";
            this.pokażFolderMenuItem.Size = new System.Drawing.Size(249, 26);
            this.pokażFolderMenuItem.Text = "Pokaż folder";
            this.pokażFolderMenuItem.ToolTipText = "Otwórz folder w ekploratorze plików";
            this.pokażFolderMenuItem.Click += new System.EventHandler(this.pokażFolderMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(246, 6);
            // 
            // zmieńTypMenuItem
            // 
            this.zmieńTypMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikiPdfMenuItem,
            this.plikiJpgMenuItem});
            this.zmieńTypMenuItem.Name = "zmieńTypMenuItem";
            this.zmieńTypMenuItem.Size = new System.Drawing.Size(249, 26);
            this.zmieńTypMenuItem.Text = "Zmień typ";
            // 
            // plikiPdfMenuItem
            // 
            this.plikiPdfMenuItem.Name = "plikiPdfMenuItem";
            this.plikiPdfMenuItem.Size = new System.Drawing.Size(134, 26);
            this.plikiPdfMenuItem.Tag = "pdf";
            this.plikiPdfMenuItem.Text = "Pliki PDF";
            this.plikiPdfMenuItem.ToolTipText = "Zmień rodzaj pliku na pdf";
            this.plikiPdfMenuItem.Click += new System.EventHandler(this.zmieńTypMenuItem_Click);
            // 
            // plikiJpgMenuItem
            // 
            this.plikiJpgMenuItem.Name = "plikiJpgMenuItem";
            this.plikiJpgMenuItem.Size = new System.Drawing.Size(134, 26);
            this.plikiJpgMenuItem.Tag = "jpg";
            this.plikiJpgMenuItem.Text = "Pliki JPG";
            this.plikiJpgMenuItem.ToolTipText = "Zmień rodzaj pliku na jpg";
            this.plikiJpgMenuItem.Click += new System.EventHandler(this.zmieńTypMenuItem_Click);
            // 
            // zmieńMetodęMenuItem
            // 
            this.zmieńMetodęMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stosunekPowierzchniMenuItem,
            this.metrykaEuklidesowaMenuItem});
            this.zmieńMetodęMenuItem.Name = "zmieńMetodęMenuItem";
            this.zmieńMetodęMenuItem.Size = new System.Drawing.Size(249, 26);
            this.zmieńMetodęMenuItem.Text = "Zmień metodę";
            // 
            // stosunekPowierzchniMenuItem
            // 
            this.stosunekPowierzchniMenuItem.Name = "stosunekPowierzchniMenuItem";
            this.stosunekPowierzchniMenuItem.Size = new System.Drawing.Size(219, 26);
            this.stosunekPowierzchniMenuItem.Tag = "stosunekPowierzchni";
            this.stosunekPowierzchniMenuItem.Text = "Stosunek powierzchni";
            this.stosunekPowierzchniMenuItem.ToolTipText = "Zmień metodę klasyfikacji na stosunekPowierzchni";
            this.stosunekPowierzchniMenuItem.Click += new System.EventHandler(this.zmieńMetodęMenuItem_Click);
            // 
            // metrykaEuklidesowaMenuItem
            // 
            this.metrykaEuklidesowaMenuItem.Name = "metrykaEuklidesowaMenuItem";
            this.metrykaEuklidesowaMenuItem.Size = new System.Drawing.Size(219, 26);
            this.metrykaEuklidesowaMenuItem.Tag = "metrykaEuklidesowa";
            this.metrykaEuklidesowaMenuItem.Text = "Metryka euklidesowa";
            this.metrykaEuklidesowaMenuItem.ToolTipText = "Zmień metodę klasyfikacji na metrykaEuklidesowa";
            this.metrykaEuklidesowaMenuItem.Click += new System.EventHandler(this.zmieńMetodęMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(246, 6);
            // 
            // usuńFolderMenuItem
            // 
            this.usuńFolderMenuItem.Name = "usuńFolderMenuItem";
            this.usuńFolderMenuItem.Size = new System.Drawing.Size(249, 26);
            this.usuńFolderMenuItem.Text = "Usuń";
            this.usuńFolderMenuItem.ToolTipText = "Usuń folder z profilu";
            this.usuńFolderMenuItem.Click += new System.EventHandler(this.usuńFolderMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.folderView);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 26);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1069, 490);
            this.panel.TabIndex = 3;
            // 
            // folderView
            // 
            this.folderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.folderHeader,
            this.typHeader,
            this.metodaHeader,
            this.plikiHeader,
            this.stronyHeader,
            this.stronyA4Header,
            this.dataHeader});
            this.folderView.ContextMenuStrip = this.folderMenu;
            this.folderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderView.FullRowSelect = true;
            this.folderView.HideSelection = false;
            this.folderView.Location = new System.Drawing.Point(0, 0);
            this.folderView.Margin = new System.Windows.Forms.Padding(4);
            this.folderView.Name = "folderView";
            this.folderView.Size = new System.Drawing.Size(1069, 490);
            this.folderView.TabIndex = 0;
            this.folderView.UseCompatibleStateImageBehavior = false;
            this.folderView.View = System.Windows.Forms.View.Details;
            this.folderView.VirtualMode = true;
            // 
            // folderHeader
            // 
            this.folderHeader.Text = "Folder";
            this.folderHeader.Width = 400;
            // 
            // typHeader
            // 
            this.typHeader.Text = "Rodzaj plików";
            this.typHeader.Width = 100;
            // 
            // metodaHeader
            // 
            this.metodaHeader.Text = "Metoda klasyfikacji";
            this.metodaHeader.Width = 150;
            // 
            // plikiHeader
            // 
            this.plikiHeader.Text = "Pliki";
            this.plikiHeader.Width = 100;
            // 
            // stronyHeader
            // 
            this.stronyHeader.Text = "Strony w pliku";
            this.stronyHeader.Width = 100;
            // 
            // stronyA4Header
            // 
            this.stronyA4Header.Text = "Strony A4";
            this.stronyA4Header.Width = 100;
            // 
            // dataHeader
            // 
            this.dataHeader.Text = "Data zliczania";
            this.dataHeader.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 539);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "StronyA4 v1.7-beta - Zliczaj strony A4 (20 stycznia 2017)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.folderMenu.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem plikMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ContextMenuStrip folderMenu;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListView folderView;
        private System.Windows.Forms.ColumnHeader folderHeader;
        private System.Windows.Forms.ToolStripMenuItem czytajToMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odświeżMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńMetodęMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńFolderMenuItem;
        private System.Windows.Forms.ColumnHeader typHeader;
        private System.Windows.Forms.ColumnHeader metodaHeader;
        private System.Windows.Forms.ColumnHeader plikiHeader;
        private System.Windows.Forms.ColumnHeader stronyHeader;
        private System.Windows.Forms.ColumnHeader dataHeader;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem widokMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zakończMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczNoweMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczNieaktualneMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem odwróćZaznaczenieMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ColumnHeader stronyA4Header;
        private System.Windows.Forms.ToolStripMenuItem zmieńTypMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plikiPdfMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plikiJpgMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stosunekPowierzchniMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metrykaEuklidesowaMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem pokażZaznaczenieMenuItem;
    }
}

