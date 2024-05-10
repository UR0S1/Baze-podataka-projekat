namespace AutoSkolaJUS
{
    partial class Polaganja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Polaganja));
            this.polozenlbl = new System.Windows.Forms.Label();
            this.datumlbl = new System.Windows.Forms.Label();
            this.kandidatlbl = new System.Windows.Forms.Label();
            this.vrsta_polaganjalbl = new System.Windows.Forms.Label();
            this.dataPolaganja = new System.Windows.Forms.DataGridView();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.sifra_polaganjalbl = new System.Windows.Forms.Label();
            this.vrsta_polaganja = new System.Windows.Forms.ComboBox();
            this.izbrisi = new System.Windows.Forms.Button();
            this.promeni = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.osvezi = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Button();
            this.polozioda = new System.Windows.Forms.RadioButton();
            this.polozione = new System.Windows.Forms.RadioButton();
            this.sifra_polaganja = new System.Windows.Forms.TextBox();
            this.kandidat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataPolaganja)).BeginInit();
            this.SuspendLayout();
            // 
            // polozenlbl
            // 
            this.polozenlbl.AutoSize = true;
            this.polozenlbl.BackColor = System.Drawing.Color.Transparent;
            this.polozenlbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polozenlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polozenlbl.Location = new System.Drawing.Point(275, 79);
            this.polozenlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polozenlbl.Name = "polozenlbl";
            this.polozenlbl.Size = new System.Drawing.Size(60, 16);
            this.polozenlbl.TabIndex = 45;
            this.polozenlbl.Text = "POLOŽIO";
            // 
            // datumlbl
            // 
            this.datumlbl.AutoSize = true;
            this.datumlbl.BackColor = System.Drawing.Color.Transparent;
            this.datumlbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datumlbl.Location = new System.Drawing.Point(275, 38);
            this.datumlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datumlbl.Name = "datumlbl";
            this.datumlbl.Size = new System.Drawing.Size(48, 16);
            this.datumlbl.TabIndex = 43;
            this.datumlbl.Text = "DATUM";
            // 
            // kandidatlbl
            // 
            this.kandidatlbl.AutoSize = true;
            this.kandidatlbl.BackColor = System.Drawing.Color.Transparent;
            this.kandidatlbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kandidatlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kandidatlbl.Location = new System.Drawing.Point(17, 100);
            this.kandidatlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kandidatlbl.Name = "kandidatlbl";
            this.kandidatlbl.Size = new System.Drawing.Size(67, 16);
            this.kandidatlbl.TabIndex = 41;
            this.kandidatlbl.Text = "KANDIDAT";
            // 
            // vrsta_polaganjalbl
            // 
            this.vrsta_polaganjalbl.AutoSize = true;
            this.vrsta_polaganjalbl.BackColor = System.Drawing.Color.Transparent;
            this.vrsta_polaganjalbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrsta_polaganjalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vrsta_polaganjalbl.Location = new System.Drawing.Point(17, 64);
            this.vrsta_polaganjalbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vrsta_polaganjalbl.Name = "vrsta_polaganjalbl";
            this.vrsta_polaganjalbl.Size = new System.Drawing.Size(23, 16);
            this.vrsta_polaganjalbl.TabIndex = 39;
            this.vrsta_polaganjalbl.Text = "TIP";
            // 
            // dataPolaganja
            // 
            this.dataPolaganja.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataPolaganja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPolaganja.Location = new System.Drawing.Point(20, 134);
            this.dataPolaganja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataPolaganja.Name = "dataPolaganja";
            this.dataPolaganja.RowHeadersWidth = 62;
            this.dataPolaganja.RowTemplate.Height = 28;
            this.dataPolaganja.Size = new System.Drawing.Size(444, 200);
            this.dataPolaganja.TabIndex = 38;
            // 
            // datum
            // 
            this.datum.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.datum.CalendarTitleBackColor = System.Drawing.Color.Chocolate;
            this.datum.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.datum.Location = new System.Drawing.Point(340, 36);
            this.datum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(125, 20);
            this.datum.TabIndex = 53;
            // 
            // sifra_polaganjalbl
            // 
            this.sifra_polaganjalbl.AutoSize = true;
            this.sifra_polaganjalbl.BackColor = System.Drawing.Color.Transparent;
            this.sifra_polaganjalbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifra_polaganjalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sifra_polaganjalbl.Location = new System.Drawing.Point(17, 29);
            this.sifra_polaganjalbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sifra_polaganjalbl.Name = "sifra_polaganjalbl";
            this.sifra_polaganjalbl.Size = new System.Drawing.Size(38, 16);
            this.sifra_polaganjalbl.TabIndex = 56;
            this.sifra_polaganjalbl.Text = "ŠIFRA";
            // 
            // vrsta_polaganja
            // 
            this.vrsta_polaganja.BackColor = System.Drawing.Color.PeachPuff;
            this.vrsta_polaganja.FormattingEnabled = true;
            this.vrsta_polaganja.Items.AddRange(new object[] {
            "teorija",
            "prva pomoć",
            "vožnja"});
            this.vrsta_polaganja.Location = new System.Drawing.Point(94, 62);
            this.vrsta_polaganja.Name = "vrsta_polaganja";
            this.vrsta_polaganja.Size = new System.Drawing.Size(125, 21);
            this.vrsta_polaganja.TabIndex = 58;
            // 
            // izbrisi
            // 
            this.izbrisi.BackColor = System.Drawing.Color.SandyBrown;
            this.izbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izbrisi.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izbrisi.Location = new System.Drawing.Point(496, 119);
            this.izbrisi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.izbrisi.Name = "izbrisi";
            this.izbrisi.Size = new System.Drawing.Size(109, 34);
            this.izbrisi.TabIndex = 63;
            this.izbrisi.Text = "IZBRIŠI";
            this.izbrisi.UseVisualStyleBackColor = false;
            this.izbrisi.Click += new System.EventHandler(this.izbrisi_Click);
            // 
            // promeni
            // 
            this.promeni.BackColor = System.Drawing.Color.SandyBrown;
            this.promeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.promeni.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promeni.Location = new System.Drawing.Point(496, 70);
            this.promeni.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.promeni.Name = "promeni";
            this.promeni.Size = new System.Drawing.Size(109, 34);
            this.promeni.TabIndex = 62;
            this.promeni.Text = "PROMENI";
            this.promeni.UseVisualStyleBackColor = false;
            this.promeni.Click += new System.EventHandler(this.promeni_Click);
            // 
            // dodaj
            // 
            this.dodaj.BackColor = System.Drawing.Color.SandyBrown;
            this.dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodaj.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj.Location = new System.Drawing.Point(496, 18);
            this.dodaj.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(109, 34);
            this.dodaj.TabIndex = 61;
            this.dodaj.Text = "DODAJ";
            this.dodaj.UseVisualStyleBackColor = false;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // osvezi
            // 
            this.osvezi.BackColor = System.Drawing.Color.LightSlateGray;
            this.osvezi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.osvezi.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osvezi.Location = new System.Drawing.Point(532, 247);
            this.osvezi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.osvezi.Name = "osvezi";
            this.osvezi.Size = new System.Drawing.Size(73, 34);
            this.osvezi.TabIndex = 60;
            this.osvezi.Text = "OSVEŽI";
            this.osvezi.UseVisualStyleBackColor = false;
            this.osvezi.Click += new System.EventHandler(this.osvezi_Click);
            // 
            // izlaz
            // 
            this.izlaz.BackColor = System.Drawing.Color.LightSlateGray;
            this.izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izlaz.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izlaz.Location = new System.Drawing.Point(532, 300);
            this.izlaz.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(73, 34);
            this.izlaz.TabIndex = 59;
            this.izlaz.Text = "IZLAZ";
            this.izlaz.UseVisualStyleBackColor = false;
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click_1);
            // 
            // polozioda
            // 
            this.polozioda.AutoSize = true;
            this.polozioda.BackColor = System.Drawing.Color.Transparent;
            this.polozioda.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polozioda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polozioda.Location = new System.Drawing.Point(355, 77);
            this.polozioda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.polozioda.Name = "polozioda";
            this.polozioda.Size = new System.Drawing.Size(42, 20);
            this.polozioda.TabIndex = 64;
            this.polozioda.TabStop = true;
            this.polozioda.Text = "DA";
            this.polozioda.UseVisualStyleBackColor = false;
            // 
            // polozione
            // 
            this.polozione.AutoSize = true;
            this.polozione.BackColor = System.Drawing.Color.Transparent;
            this.polozione.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polozione.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polozione.Location = new System.Drawing.Point(411, 77);
            this.polozione.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.polozione.Name = "polozione";
            this.polozione.Size = new System.Drawing.Size(40, 20);
            this.polozione.TabIndex = 65;
            this.polozione.TabStop = true;
            this.polozione.Text = "NE";
            this.polozione.UseVisualStyleBackColor = false;
            // 
            // sifra_polaganja
            // 
            this.sifra_polaganja.BackColor = System.Drawing.Color.PeachPuff;
            this.sifra_polaganja.Location = new System.Drawing.Point(94, 29);
            this.sifra_polaganja.Margin = new System.Windows.Forms.Padding(2);
            this.sifra_polaganja.Name = "sifra_polaganja";
            this.sifra_polaganja.Size = new System.Drawing.Size(125, 20);
            this.sifra_polaganja.TabIndex = 57;
            // 
            // kandidat
            // 
            this.kandidat.BackColor = System.Drawing.Color.PeachPuff;
            this.kandidat.FormattingEnabled = true;
            this.kandidat.Items.AddRange(new object[] {
            "teorija",
            "prva pomoć",
            "vožnja"});
            this.kandidat.Location = new System.Drawing.Point(94, 98);
            this.kandidat.Name = "kandidat";
            this.kandidat.Size = new System.Drawing.Size(125, 21);
            this.kandidat.TabIndex = 66;
            // 
            // Polaganja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 356);
            this.Controls.Add(this.kandidat);
            this.Controls.Add(this.polozione);
            this.Controls.Add(this.polozioda);
            this.Controls.Add(this.izbrisi);
            this.Controls.Add(this.promeni);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.osvezi);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.vrsta_polaganja);
            this.Controls.Add(this.sifra_polaganja);
            this.Controls.Add(this.sifra_polaganjalbl);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.polozenlbl);
            this.Controls.Add(this.datumlbl);
            this.Controls.Add(this.kandidatlbl);
            this.Controls.Add(this.vrsta_polaganjalbl);
            this.Controls.Add(this.dataPolaganja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Polaganja";
            this.Text = "Polaganja";
            this.Load += new System.EventHandler(this.Polaganja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPolaganja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label polozenlbl;
        private System.Windows.Forms.Label datumlbl;
        private System.Windows.Forms.Label kandidatlbl;
        private System.Windows.Forms.Label vrsta_polaganjalbl;
        private System.Windows.Forms.DataGridView dataPolaganja;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Label sifra_polaganjalbl;
        private System.Windows.Forms.ComboBox vrsta_polaganja;
        private System.Windows.Forms.Button izbrisi;
        private System.Windows.Forms.Button promeni;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button osvezi;
        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.RadioButton polozioda;
        private System.Windows.Forms.RadioButton polozione;
        private System.Windows.Forms.TextBox sifra_polaganja;
        private System.Windows.Forms.ComboBox kandidat;
    }
}