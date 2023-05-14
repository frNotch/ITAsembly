namespace JohnCode_1._0
{
    partial class JohnCode
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JohnCode));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nuovo = new System.Windows.Forms.ToolStripMenuItem();
            this.Apri = new System.Windows.Forms.ToolStripMenuItem();
            this.Salva = new System.Windows.Forms.ToolStripMenuItem();
            this.Salvaconnome = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Esci = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Debug = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip = new System.Windows.Forms.StatusStrip();
            this.lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.nrighe = new System.Windows.Forms.ToolStripStatusLabel();
            this.StackView = new System.Windows.Forms.ListView();
            this.Indirizzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ESB = new System.Windows.Forms.TextBox();
            this.DSB = new System.Windows.Forms.TextBox();
            this.DIB = new System.Windows.Forms.TextBox();
            this.SIB = new System.Windows.Forms.TextBox();
            this.BPB = new System.Windows.Forms.TextBox();
            this.SPB = new System.Windows.Forms.TextBox();
            this.SSB = new System.Windows.Forms.TextBox();
            this.IPB = new System.Windows.Forms.TextBox();
            this.CSB = new System.Windows.Forms.TextBox();
            this.ESL = new System.Windows.Forms.Label();
            this.DSL = new System.Windows.Forms.Label();
            this.DIL = new System.Windows.Forms.Label();
            this.SIL = new System.Windows.Forms.Label();
            this.BPL = new System.Windows.Forms.Label();
            this.SPL = new System.Windows.Forms.Label();
            this.SSL = new System.Windows.Forms.Label();
            this.IPL = new System.Windows.Forms.Label();
            this.CSL = new System.Windows.Forms.Label();
            this.DLB = new System.Windows.Forms.TextBox();
            this.DHB = new System.Windows.Forms.TextBox();
            this.DLL = new System.Windows.Forms.Label();
            this.DHL = new System.Windows.Forms.Label();
            this.CLB = new System.Windows.Forms.TextBox();
            this.CHB = new System.Windows.Forms.TextBox();
            this.CLL = new System.Windows.Forms.Label();
            this.CHL = new System.Windows.Forms.Label();
            this.BLB = new System.Windows.Forms.TextBox();
            this.BHB = new System.Windows.Forms.TextBox();
            this.BLL = new System.Windows.Forms.Label();
            this.BHL = new System.Windows.Forms.Label();
            this.AreaTesto = new System.Windows.Forms.RichTextBox();
            this.ALB = new System.Windows.Forms.TextBox();
            this.AHB = new System.Windows.Forms.TextBox();
            this.ALL = new System.Windows.Forms.Label();
            this.AHL = new System.Windows.Forms.Label();
            this.SalvaFile = new System.Windows.Forms.SaveFileDialog();
            this.ApriFile = new System.Windows.Forms.OpenFileDialog();
            this.Menu.SuspendLayout();
            this.Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(718, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuovo,
            this.Apri,
            this.Salva,
            this.Salvaconnome,
            this.toolStripSeparator1,
            this.Esci});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Nuovo
            // 
            this.Nuovo.Name = "Nuovo";
            this.Nuovo.Size = new System.Drawing.Size(167, 22);
            this.Nuovo.Text = "Nuovo";
            this.Nuovo.Click += new System.EventHandler(this.Nuovo_Click);
            // 
            // Apri
            // 
            this.Apri.Name = "Apri";
            this.Apri.Size = new System.Drawing.Size(167, 22);
            this.Apri.Text = "Apri";
            this.Apri.Click += new System.EventHandler(this.Apri_Click);
            // 
            // Salva
            // 
            this.Salva.Name = "Salva";
            this.Salva.Size = new System.Drawing.Size(167, 22);
            this.Salva.Text = "Salva";
            this.Salva.Click += new System.EventHandler(this.Salva_Click);
            // 
            // Salvaconnome
            // 
            this.Salvaconnome.Name = "Salvaconnome";
            this.Salvaconnome.Size = new System.Drawing.Size(167, 22);
            this.Salvaconnome.Text = "Salva con nome...";
            this.Salvaconnome.Click += new System.EventHandler(this.Salvaconnome_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // Esci
            // 
            this.Esci.Name = "Esci";
            this.Esci.Size = new System.Drawing.Size(167, 22);
            this.Esci.Text = "Esci";
            this.Esci.Click += new System.EventHandler(this.Esci_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Debug});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // Debug
            // 
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(109, 22);
            this.Debug.Text = "Debug";
            this.Debug.Click += new System.EventHandler(this.Debug_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // Strip
            // 
            this.Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl,
            this.nrighe});
            this.Strip.Location = new System.Drawing.Point(0, 541);
            this.Strip.Name = "Strip";
            this.Strip.Size = new System.Drawing.Size(718, 22);
            this.Strip.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(97, 17);
            this.lbl.Text = "Numero di righe:";
            // 
            // nrighe
            // 
            this.nrighe.Name = "nrighe";
            this.nrighe.Size = new System.Drawing.Size(0, 17);
            // 
            // StackView
            // 
            this.StackView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Indirizzo,
            this.Valore});
            this.StackView.HideSelection = false;
            this.StackView.Location = new System.Drawing.Point(585, 27);
            this.StackView.MultiSelect = false;
            this.StackView.Name = "StackView";
            this.StackView.Size = new System.Drawing.Size(121, 511);
            this.StackView.TabIndex = 70;
            this.StackView.UseCompatibleStateImageBehavior = false;
            this.StackView.View = System.Windows.Forms.View.Tile;
            // 
            // Indirizzo
            // 
            this.Indirizzo.Text = "Indirizzo";
            // 
            // Valore
            // 
            this.Valore.Text = "Valore";
            this.Valore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ESB
            // 
            this.ESB.Enabled = false;
            this.ESB.Location = new System.Drawing.Point(392, 376);
            this.ESB.Name = "ESB";
            this.ESB.Size = new System.Drawing.Size(134, 20);
            this.ESB.TabIndex = 69;
            this.ESB.TabStop = false;
            this.ESB.Text = "0";
            // 
            // DSB
            // 
            this.DSB.Enabled = false;
            this.DSB.Location = new System.Drawing.Point(392, 350);
            this.DSB.Name = "DSB";
            this.DSB.Size = new System.Drawing.Size(134, 20);
            this.DSB.TabIndex = 68;
            this.DSB.Text = "0";
            // 
            // DIB
            // 
            this.DIB.Enabled = false;
            this.DIB.Location = new System.Drawing.Point(392, 324);
            this.DIB.Name = "DIB";
            this.DIB.Size = new System.Drawing.Size(134, 20);
            this.DIB.TabIndex = 67;
            this.DIB.Text = "0";
            // 
            // SIB
            // 
            this.SIB.Enabled = false;
            this.SIB.Location = new System.Drawing.Point(392, 299);
            this.SIB.Name = "SIB";
            this.SIB.Size = new System.Drawing.Size(134, 20);
            this.SIB.TabIndex = 66;
            this.SIB.Text = "0";
            // 
            // BPB
            // 
            this.BPB.Enabled = false;
            this.BPB.Location = new System.Drawing.Point(392, 272);
            this.BPB.Name = "BPB";
            this.BPB.Size = new System.Drawing.Size(134, 20);
            this.BPB.TabIndex = 65;
            this.BPB.Text = "0";
            // 
            // SPB
            // 
            this.SPB.Enabled = false;
            this.SPB.Location = new System.Drawing.Point(392, 246);
            this.SPB.Name = "SPB";
            this.SPB.Size = new System.Drawing.Size(134, 20);
            this.SPB.TabIndex = 64;
            this.SPB.Text = "0";
            // 
            // SSB
            // 
            this.SSB.Enabled = false;
            this.SSB.Location = new System.Drawing.Point(392, 220);
            this.SSB.Name = "SSB";
            this.SSB.Size = new System.Drawing.Size(134, 20);
            this.SSB.TabIndex = 63;
            this.SSB.Text = "0";
            // 
            // IPB
            // 
            this.IPB.Enabled = false;
            this.IPB.Location = new System.Drawing.Point(392, 194);
            this.IPB.Name = "IPB";
            this.IPB.Size = new System.Drawing.Size(134, 20);
            this.IPB.TabIndex = 62;
            this.IPB.Text = "0";
            // 
            // CSB
            // 
            this.CSB.Enabled = false;
            this.CSB.Location = new System.Drawing.Point(392, 168);
            this.CSB.Name = "CSB";
            this.CSB.Size = new System.Drawing.Size(134, 20);
            this.CSB.TabIndex = 61;
            this.CSB.Text = "0";
            // 
            // ESL
            // 
            this.ESL.Location = new System.Drawing.Point(334, 376);
            this.ESL.Name = "ESL";
            this.ESL.Size = new System.Drawing.Size(47, 20);
            this.ESL.TabIndex = 60;
            this.ESL.Text = "ES";
            this.ESL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DSL
            // 
            this.DSL.Location = new System.Drawing.Point(334, 350);
            this.DSL.Name = "DSL";
            this.DSL.Size = new System.Drawing.Size(47, 20);
            this.DSL.TabIndex = 59;
            this.DSL.Text = "DS";
            this.DSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DIL
            // 
            this.DIL.Location = new System.Drawing.Point(333, 324);
            this.DIL.Name = "DIL";
            this.DIL.Size = new System.Drawing.Size(47, 20);
            this.DIL.TabIndex = 58;
            this.DIL.Text = "DI";
            this.DIL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SIL
            // 
            this.SIL.Location = new System.Drawing.Point(333, 298);
            this.SIL.Name = "SIL";
            this.SIL.Size = new System.Drawing.Size(47, 20);
            this.SIL.TabIndex = 57;
            this.SIL.Text = "SI";
            this.SIL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BPL
            // 
            this.BPL.Location = new System.Drawing.Point(333, 272);
            this.BPL.Name = "BPL";
            this.BPL.Size = new System.Drawing.Size(47, 20);
            this.BPL.TabIndex = 56;
            this.BPL.Text = "BP";
            this.BPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SPL
            // 
            this.SPL.Location = new System.Drawing.Point(333, 246);
            this.SPL.Name = "SPL";
            this.SPL.Size = new System.Drawing.Size(47, 20);
            this.SPL.TabIndex = 55;
            this.SPL.Text = "SP";
            this.SPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SSL
            // 
            this.SSL.Location = new System.Drawing.Point(334, 219);
            this.SSL.Name = "SSL";
            this.SSL.Size = new System.Drawing.Size(47, 20);
            this.SSL.TabIndex = 54;
            this.SSL.Text = "SS";
            this.SSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IPL
            // 
            this.IPL.Location = new System.Drawing.Point(334, 193);
            this.IPL.Name = "IPL";
            this.IPL.Size = new System.Drawing.Size(47, 20);
            this.IPL.TabIndex = 53;
            this.IPL.Text = "IP";
            this.IPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CSL
            // 
            this.CSL.Location = new System.Drawing.Point(334, 166);
            this.CSL.Name = "CSL";
            this.CSL.Size = new System.Drawing.Size(47, 20);
            this.CSL.TabIndex = 52;
            this.CSL.Text = "CS";
            this.CSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DLB
            // 
            this.DLB.Enabled = false;
            this.DLB.Location = new System.Drawing.Point(465, 134);
            this.DLB.Name = "DLB";
            this.DLB.Size = new System.Drawing.Size(61, 20);
            this.DLB.TabIndex = 51;
            this.DLB.Text = "0";
            // 
            // DHB
            // 
            this.DHB.Enabled = false;
            this.DHB.Location = new System.Drawing.Point(392, 134);
            this.DHB.Name = "DHB";
            this.DHB.Size = new System.Drawing.Size(61, 20);
            this.DHB.TabIndex = 50;
            this.DHB.Text = "0";
            // 
            // DLL
            // 
            this.DLL.Location = new System.Drawing.Point(532, 134);
            this.DLL.Name = "DLL";
            this.DLL.Size = new System.Drawing.Size(47, 20);
            this.DLL.TabIndex = 49;
            this.DLL.Text = "DL";
            this.DLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DHL
            // 
            this.DHL.Location = new System.Drawing.Point(337, 134);
            this.DHL.Name = "DHL";
            this.DHL.Size = new System.Drawing.Size(44, 20);
            this.DHL.TabIndex = 48;
            this.DHL.Text = "DH";
            this.DHL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CLB
            // 
            this.CLB.Enabled = false;
            this.CLB.Location = new System.Drawing.Point(465, 108);
            this.CLB.Name = "CLB";
            this.CLB.Size = new System.Drawing.Size(61, 20);
            this.CLB.TabIndex = 47;
            this.CLB.Text = "0";
            // 
            // CHB
            // 
            this.CHB.Enabled = false;
            this.CHB.Location = new System.Drawing.Point(392, 108);
            this.CHB.Name = "CHB";
            this.CHB.Size = new System.Drawing.Size(61, 20);
            this.CHB.TabIndex = 46;
            this.CHB.Text = "0";
            // 
            // CLL
            // 
            this.CLL.Location = new System.Drawing.Point(532, 108);
            this.CLL.Name = "CLL";
            this.CLL.Size = new System.Drawing.Size(47, 20);
            this.CLL.TabIndex = 45;
            this.CLL.Text = "CL";
            this.CLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CHL
            // 
            this.CHL.Location = new System.Drawing.Point(337, 108);
            this.CHL.Name = "CHL";
            this.CHL.Size = new System.Drawing.Size(44, 20);
            this.CHL.TabIndex = 44;
            this.CHL.Text = "CH";
            this.CHL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BLB
            // 
            this.BLB.Enabled = false;
            this.BLB.Location = new System.Drawing.Point(465, 82);
            this.BLB.Name = "BLB";
            this.BLB.Size = new System.Drawing.Size(61, 20);
            this.BLB.TabIndex = 43;
            this.BLB.Text = "0";
            // 
            // BHB
            // 
            this.BHB.Enabled = false;
            this.BHB.Location = new System.Drawing.Point(392, 82);
            this.BHB.Name = "BHB";
            this.BHB.Size = new System.Drawing.Size(61, 20);
            this.BHB.TabIndex = 42;
            this.BHB.Text = "0";
            // 
            // BLL
            // 
            this.BLL.Location = new System.Drawing.Point(532, 82);
            this.BLL.Name = "BLL";
            this.BLL.Size = new System.Drawing.Size(47, 20);
            this.BLL.TabIndex = 41;
            this.BLL.Text = "BL";
            this.BLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BHL
            // 
            this.BHL.Location = new System.Drawing.Point(337, 82);
            this.BHL.Name = "BHL";
            this.BHL.Size = new System.Drawing.Size(44, 20);
            this.BHL.TabIndex = 40;
            this.BHL.Text = "BH";
            this.BHL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AreaTesto
            // 
            this.AreaTesto.Location = new System.Drawing.Point(12, 27);
            this.AreaTesto.Name = "AreaTesto";
            this.AreaTesto.Size = new System.Drawing.Size(315, 511);
            this.AreaTesto.TabIndex = 71;
            this.AreaTesto.Text = "";
            this.AreaTesto.TextChanged += new System.EventHandler(this.AreaTesto_TextChanged);
            // 
            // ALB
            // 
            this.ALB.Enabled = false;
            this.ALB.Location = new System.Drawing.Point(465, 56);
            this.ALB.Name = "ALB";
            this.ALB.Size = new System.Drawing.Size(61, 20);
            this.ALB.TabIndex = 75;
            this.ALB.Text = "0";
            // 
            // AHB
            // 
            this.AHB.Enabled = false;
            this.AHB.Location = new System.Drawing.Point(392, 56);
            this.AHB.Name = "AHB";
            this.AHB.Size = new System.Drawing.Size(61, 20);
            this.AHB.TabIndex = 74;
            this.AHB.Text = "0";
            // 
            // ALL
            // 
            this.ALL.Location = new System.Drawing.Point(532, 56);
            this.ALL.Name = "ALL";
            this.ALL.Size = new System.Drawing.Size(47, 20);
            this.ALL.TabIndex = 73;
            this.ALL.Text = "AL";
            this.ALL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AHL
            // 
            this.AHL.Location = new System.Drawing.Point(337, 55);
            this.AHL.Name = "AHL";
            this.AHL.Size = new System.Drawing.Size(44, 20);
            this.AHL.TabIndex = 72;
            this.AHL.Text = "AH";
            this.AHL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalvaFile
            // 
            this.SalvaFile.DefaultExt = "File John|*.john";
            this.SalvaFile.Filter = "File John|*.john";
            // 
            // ApriFile
            // 
            this.ApriFile.DefaultExt = "File John|*.john";
            this.ApriFile.Filter = "File John|*.john";
            // 
            // JohnCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 563);
            this.Controls.Add(this.ALB);
            this.Controls.Add(this.AHB);
            this.Controls.Add(this.ALL);
            this.Controls.Add(this.AHL);
            this.Controls.Add(this.AreaTesto);
            this.Controls.Add(this.StackView);
            this.Controls.Add(this.ESB);
            this.Controls.Add(this.DSB);
            this.Controls.Add(this.DIB);
            this.Controls.Add(this.SIB);
            this.Controls.Add(this.BPB);
            this.Controls.Add(this.SPB);
            this.Controls.Add(this.SSB);
            this.Controls.Add(this.IPB);
            this.Controls.Add(this.CSB);
            this.Controls.Add(this.ESL);
            this.Controls.Add(this.DSL);
            this.Controls.Add(this.DIL);
            this.Controls.Add(this.SIL);
            this.Controls.Add(this.BPL);
            this.Controls.Add(this.SPL);
            this.Controls.Add(this.SSL);
            this.Controls.Add(this.IPL);
            this.Controls.Add(this.CSL);
            this.Controls.Add(this.DLB);
            this.Controls.Add(this.DHB);
            this.Controls.Add(this.DLL);
            this.Controls.Add(this.DHL);
            this.Controls.Add(this.CLB);
            this.Controls.Add(this.CHB);
            this.Controls.Add(this.CLL);
            this.Controls.Add(this.CHL);
            this.Controls.Add(this.BLB);
            this.Controls.Add(this.BHB);
            this.Controls.Add(this.BLL);
            this.Controls.Add(this.BHL);
            this.Controls.Add(this.Strip);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "JohnCode";
            this.Text = "JohnCode 1.0";
            this.Load += new System.EventHandler(this.JohnCode_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Strip.ResumeLayout(false);
            this.Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Nuovo;
        private System.Windows.Forms.ToolStripMenuItem Apri;
        private System.Windows.Forms.ToolStripMenuItem Salva;
        private System.Windows.Forms.ToolStripMenuItem Salvaconnome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Esci;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Debug;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip Strip;
        private System.Windows.Forms.ToolStripStatusLabel lbl;
        private System.Windows.Forms.ToolStripStatusLabel nrighe;
        private System.Windows.Forms.ListView StackView;
        private System.Windows.Forms.ColumnHeader Indirizzo;
        private System.Windows.Forms.ColumnHeader Valore;
        private System.Windows.Forms.TextBox ESB;
        private System.Windows.Forms.TextBox DSB;
        private System.Windows.Forms.TextBox DIB;
        private System.Windows.Forms.TextBox SIB;
        private System.Windows.Forms.TextBox BPB;
        private System.Windows.Forms.TextBox SPB;
        private System.Windows.Forms.TextBox SSB;
        private System.Windows.Forms.TextBox IPB;
        private System.Windows.Forms.TextBox CSB;
        private System.Windows.Forms.Label ESL;
        private System.Windows.Forms.Label DSL;
        private System.Windows.Forms.Label DIL;
        private System.Windows.Forms.Label SIL;
        private System.Windows.Forms.Label BPL;
        private System.Windows.Forms.Label SPL;
        private System.Windows.Forms.Label SSL;
        private System.Windows.Forms.Label IPL;
        private System.Windows.Forms.Label CSL;
        private System.Windows.Forms.TextBox DLB;
        private System.Windows.Forms.TextBox DHB;
        private System.Windows.Forms.Label DLL;
        private System.Windows.Forms.Label DHL;
        private System.Windows.Forms.TextBox CLB;
        private System.Windows.Forms.TextBox CHB;
        private System.Windows.Forms.Label CLL;
        private System.Windows.Forms.Label CHL;
        private System.Windows.Forms.TextBox BLB;
        private System.Windows.Forms.TextBox BHB;
        private System.Windows.Forms.Label BLL;
        private System.Windows.Forms.Label BHL;
        private System.Windows.Forms.RichTextBox AreaTesto;
        private System.Windows.Forms.TextBox ALB;
        private System.Windows.Forms.TextBox AHB;
        private System.Windows.Forms.Label ALL;
        private System.Windows.Forms.Label AHL;
        private System.Windows.Forms.SaveFileDialog SalvaFile;
        private System.Windows.Forms.OpenFileDialog ApriFile;
    }
}

