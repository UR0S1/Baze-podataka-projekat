namespace AutoSkolaJUS
{
    partial class AutoSkola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoSkola));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.radnaBazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kandidatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polaganjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stanjeKandidata = new System.Windows.Forms.ToolStripMenuItem();
            this.polozeniIspitiPoMesecu = new System.Windows.Forms.ToolStripMenuItem();
            this.polozeniIspitiPoInstruktoru = new System.Windows.Forms.ToolStripMenuItem();
            this.kandidatiKojiNisuPolozili = new System.Windows.Forms.ToolStripMenuItem();
            this.rangListaInstruktora = new System.Windows.Forms.ToolStripMenuItem();
            this.name2lbl = new System.Windows.Forms.Label();
            this.name1lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Duzi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radnaBazaToolStripMenuItem,
            this.izvestajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(759, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // radnaBazaToolStripMenuItem
            // 
            this.radnaBazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radniciToolStripMenuItem,
            this.kandidatiToolStripMenuItem,
            this.vozilaToolStripMenuItem,
            this.Duzi,
            this.polaganjaToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.radnaBazaToolStripMenuItem.Name = "radnaBazaToolStripMenuItem";
            this.radnaBazaToolStripMenuItem.Size = new System.Drawing.Size(101, 26);
            this.radnaBazaToolStripMenuItem.Text = "Radna baza";
            // 
            // radniciToolStripMenuItem
            // 
            this.radniciToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.radniciToolStripMenuItem.Name = "radniciToolStripMenuItem";
            this.radniciToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.radniciToolStripMenuItem.Text = "Radnici";
            this.radniciToolStripMenuItem.Click += new System.EventHandler(this.radniciToolStripMenuItem_Click);
            // 
            // kandidatiToolStripMenuItem
            // 
            this.kandidatiToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.kandidatiToolStripMenuItem.Name = "kandidatiToolStripMenuItem";
            this.kandidatiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kandidatiToolStripMenuItem.Text = "Kandidati";
            this.kandidatiToolStripMenuItem.Click += new System.EventHandler(this.kandidatiToolStripMenuItem_Click);
            // 
            // vozilaToolStripMenuItem
            // 
            this.vozilaToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.vozilaToolStripMenuItem.Name = "vozilaToolStripMenuItem";
            this.vozilaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vozilaToolStripMenuItem.Text = "Vozila";
            this.vozilaToolStripMenuItem.Click += new System.EventHandler(this.vozilaToolStripMenuItem_Click);
            // 
            // polaganjaToolStripMenuItem
            // 
            this.polaganjaToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.polaganjaToolStripMenuItem.Name = "polaganjaToolStripMenuItem";
            this.polaganjaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.polaganjaToolStripMenuItem.Text = "Polaganja";
            this.polaganjaToolStripMenuItem.Click += new System.EventHandler(this.polaganjaToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stanjeKandidata,
            this.polozeniIspitiPoMesecu,
            this.polozeniIspitiPoInstruktoru,
            this.kandidatiKojiNisuPolozili,
            this.rangListaInstruktora});
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.izvestajiToolStripMenuItem.Text = "Izveštaji";
            // 
            // stanjeKandidata
            // 
            this.stanjeKandidata.BackColor = System.Drawing.Color.LightSteelBlue;
            this.stanjeKandidata.Name = "stanjeKandidata";
            this.stanjeKandidata.Size = new System.Drawing.Size(280, 26);
            this.stanjeKandidata.Text = "Stanje kandidata";
            this.stanjeKandidata.Click += new System.EventHandler(this.stanjeKandidata_Click);
            // 
            // polozeniIspitiPoMesecu
            // 
            this.polozeniIspitiPoMesecu.BackColor = System.Drawing.Color.LightSlateGray;
            this.polozeniIspitiPoMesecu.Name = "polozeniIspitiPoMesecu";
            this.polozeniIspitiPoMesecu.Size = new System.Drawing.Size(280, 26);
            this.polozeniIspitiPoMesecu.Text = "Položeni ispiti po mesecu";
            this.polozeniIspitiPoMesecu.Click += new System.EventHandler(this.polozeniIspitiPoMesecu_Click);
            // 
            // polozeniIspitiPoInstruktoru
            // 
            this.polozeniIspitiPoInstruktoru.BackColor = System.Drawing.Color.LightSteelBlue;
            this.polozeniIspitiPoInstruktoru.Name = "polozeniIspitiPoInstruktoru";
            this.polozeniIspitiPoInstruktoru.Size = new System.Drawing.Size(280, 26);
            this.polozeniIspitiPoInstruktoru.Text = "Položeni ispiti po instruktoru";
            this.polozeniIspitiPoInstruktoru.Click += new System.EventHandler(this.polozeniIspitiPoInstruktoru_Click);
            // 
            // kandidatiKojiNisuPolozili
            // 
            this.kandidatiKojiNisuPolozili.BackColor = System.Drawing.Color.LightSlateGray;
            this.kandidatiKojiNisuPolozili.Name = "kandidatiKojiNisuPolozili";
            this.kandidatiKojiNisuPolozili.Size = new System.Drawing.Size(280, 26);
            this.kandidatiKojiNisuPolozili.Text = "Kandidati koji nisu položili";
            this.kandidatiKojiNisuPolozili.Click += new System.EventHandler(this.kandidatiKojiNisuPolozili_Click);
            // 
            // rangListaInstruktora
            // 
            this.rangListaInstruktora.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rangListaInstruktora.Name = "rangListaInstruktora";
            this.rangListaInstruktora.Size = new System.Drawing.Size(280, 26);
            this.rangListaInstruktora.Text = "Rang lista instruktora";
            this.rangListaInstruktora.Click += new System.EventHandler(this.rangListaInstruktora_Click);
            // 
            // name2lbl
            // 
            this.name2lbl.AutoSize = true;
            this.name2lbl.BackColor = System.Drawing.Color.Transparent;
            this.name2lbl.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name2lbl.Location = new System.Drawing.Point(188, 61);
            this.name2lbl.Margin = new System.Windows.Forms.Padding(0);
            this.name2lbl.Name = "name2lbl";
            this.name2lbl.Size = new System.Drawing.Size(148, 94);
            this.name2lbl.TabIndex = 2;
            this.name2lbl.Text = "JUS";
            // 
            // name1lbl
            // 
            this.name1lbl.AutoSize = true;
            this.name1lbl.BackColor = System.Drawing.Color.Transparent;
            this.name1lbl.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name1lbl.Location = new System.Drawing.Point(11, 61);
            this.name1lbl.Name = "name1lbl";
            this.name1lbl.Size = new System.Drawing.Size(200, 51);
            this.name1lbl.TabIndex = 3;
            this.name1lbl.Text = "Auto škola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(104, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valjevo";
            // 
            // Duzi
            // 
            this.Duzi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Duzi.Name = "Duzi";
            this.Duzi.Size = new System.Drawing.Size(224, 26);
            this.Duzi.Text = "Duži";
            this.Duzi.Click += new System.EventHandler(this.Duzi_Click);
            // 
            // AutoSkola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 426);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name1lbl);
            this.Controls.Add(this.name2lbl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AutoSkola";
            this.Text = "JUS Auto škola";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem radnaBazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kandidatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polaganjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stanjeKandidata;
        private System.Windows.Forms.ToolStripMenuItem polozeniIspitiPoMesecu;
        private System.Windows.Forms.ToolStripMenuItem polozeniIspitiPoInstruktoru;
        private System.Windows.Forms.ToolStripMenuItem kandidatiKojiNisuPolozili;
        private System.Windows.Forms.ToolStripMenuItem rangListaInstruktora;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.Label name2lbl;
        private System.Windows.Forms.Label name1lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem Duzi;
    }
}

