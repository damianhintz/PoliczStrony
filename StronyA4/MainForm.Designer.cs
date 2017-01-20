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
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczNoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczNieaktualneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.odwróćZaznaczenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czytajToMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.odświeżMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pokażFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażPlikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.analizujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńMetodęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.usuńFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.folderView = new System.Windows.Forms.ListView();
            this.folderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metodaHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plikiHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stronyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stronyA4Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.menu.Size = new System.Drawing.Size(1069, 28);
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
            this.plikMenuItem.Size = new System.Drawing.Size(39, 24);
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
            this.zaznaczWszystkoToolStripMenuItem,
            this.zaznaczNoweToolStripMenuItem,
            this.zaznaczNieaktualneToolStripMenuItem,
            this.toolStripSeparator3,
            this.odwróćZaznaczenieToolStripMenuItem});
            this.widokMenuItem.Name = "widokMenuItem";
            this.widokMenuItem.Size = new System.Drawing.Size(59, 24);
            this.widokMenuItem.Text = "Widok";
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // zaznaczNoweToolStripMenuItem
            // 
            this.zaznaczNoweToolStripMenuItem.Name = "zaznaczNoweToolStripMenuItem";
            this.zaznaczNoweToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.zaznaczNoweToolStripMenuItem.Text = "Zaznacz nowe";
            this.zaznaczNoweToolStripMenuItem.ToolTipText = "Zaznacz foldery, dla których nie zliczano jeszcze stron";
            // 
            // zaznaczNieaktualneToolStripMenuItem
            // 
            this.zaznaczNieaktualneToolStripMenuItem.Name = "zaznaczNieaktualneToolStripMenuItem";
            this.zaznaczNieaktualneToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.zaznaczNieaktualneToolStripMenuItem.Text = "Zaznacz nieaktualne";
            this.zaznaczNieaktualneToolStripMenuItem.ToolTipText = "Zaznacz fodlery, dla których zliczano strony, ale dawno temu";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(245, 6);
            // 
            // odwróćZaznaczenieToolStripMenuItem
            // 
            this.odwróćZaznaczenieToolStripMenuItem.Name = "odwróćZaznaczenieToolStripMenuItem";
            this.odwróćZaznaczenieToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.odwróćZaznaczenieToolStripMenuItem.Text = "Odwróć zaznaczenie";
            // 
            // pomocMenuItem
            // 
            this.pomocMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czytajToMenuItem});
            this.pomocMenuItem.Name = "pomocMenuItem";
            this.pomocMenuItem.Size = new System.Drawing.Size(64, 24);
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
            this.pokażFolderToolStripMenuItem,
            this.pokażPlikiToolStripMenuItem,
            this.toolStripSeparator4,
            this.analizujToolStripMenuItem,
            this.zmieńMetodęToolStripMenuItem,
            this.toolStripSeparator5,
            this.usuńFolderMenuItem});
            this.folderMenu.Name = "folderMenu";
            this.folderMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.folderMenu.Size = new System.Drawing.Size(177, 178);
            // 
            // odświeżMenuItem
            // 
            this.odświeżMenuItem.Name = "odświeżMenuItem";
            this.odświeżMenuItem.Size = new System.Drawing.Size(176, 26);
            this.odświeżMenuItem.Text = "Policz strony";
            this.odświeżMenuItem.ToolTipText = "Policz strony A4 w podanym folderze";
            this.odświeżMenuItem.Click += new System.EventHandler(this.odświeżMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // pokażFolderToolStripMenuItem
            // 
            this.pokażFolderToolStripMenuItem.Name = "pokażFolderToolStripMenuItem";
            this.pokażFolderToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.pokażFolderToolStripMenuItem.Text = "Pokaż folder";
            this.pokażFolderToolStripMenuItem.ToolTipText = "Otwórz folder w ekploratorze plików";
            this.pokażFolderToolStripMenuItem.Click += new System.EventHandler(this.pokażFolderToolStripMenuItem_Click);
            // 
            // pokażPlikiToolStripMenuItem
            // 
            this.pokażPlikiToolStripMenuItem.Name = "pokażPlikiToolStripMenuItem";
            this.pokażPlikiToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.pokażPlikiToolStripMenuItem.Text = "Pokaż pliki";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(173, 6);
            // 
            // analizujToolStripMenuItem
            // 
            this.analizujToolStripMenuItem.Name = "analizujToolStripMenuItem";
            this.analizujToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.analizujToolStripMenuItem.Text = "Analizuj";
            // 
            // zmieńMetodęToolStripMenuItem
            // 
            this.zmieńMetodęToolStripMenuItem.Name = "zmieńMetodęToolStripMenuItem";
            this.zmieńMetodęToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.zmieńMetodęToolStripMenuItem.Text = "Zmień metodę";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(173, 6);
            // 
            // usuńFolderMenuItem
            // 
            this.usuńFolderMenuItem.Name = "usuńFolderMenuItem";
            this.usuńFolderMenuItem.Size = new System.Drawing.Size(176, 26);
            this.usuńFolderMenuItem.Text = "Usuń";
            this.usuńFolderMenuItem.ToolTipText = "Usuń folder z profilu";
            this.usuńFolderMenuItem.Click += new System.EventHandler(this.usuńFolderMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.folderView);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1069, 488);
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
            this.folderView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.folderView.Name = "folderView";
            this.folderView.Size = new System.Drawing.Size(1069, 488);
            this.folderView.TabIndex = 0;
            this.folderView.UseCompatibleStateImageBehavior = false;
            this.folderView.View = System.Windows.Forms.View.Details;
            this.folderView.VirtualMode = true;
            // 
            // folderHeader
            // 
            this.folderHeader.Text = "Folder";
            this.folderHeader.Width = 350;
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
            // dataHeader
            // 
            this.dataHeader.Text = "Data zliczania";
            this.dataHeader.Width = 150;
            // 
            // stronyA4Header
            // 
            this.stronyA4Header.Text = "Strony A4";
            this.stronyA4Header.Width = 100;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "StronyA4 v1.7-beta - Zliczaj strony A4 (19 stycznia 2017)";
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
        private System.Windows.Forms.ToolStripMenuItem pokażFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażPlikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odświeżMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńMetodęToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczNoweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczNieaktualneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem odwróćZaznaczenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ColumnHeader stronyA4Header;
    }
}

