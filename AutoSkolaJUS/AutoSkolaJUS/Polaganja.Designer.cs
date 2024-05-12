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
            this.kategorija = new System.Windows.Forms.TextBox();
            this.kandidatlbl = new System.Windows.Forms.Label();
            this.vrsta_polaganjalbl = new System.Windows.Forms.Label();
            this.dataVozila = new System.Windows.Forms.DataGridView();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.vrsta_polaganja = new System.Windows.Forms.ComboBox();
            this.izbrisi = new System.Windows.Forms.Button();
            this.promeni = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.osvezi = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Button();
            this.polozioda = new System.Windows.Forms.RadioButton();
            this.polozione = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kategorijalbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // polozenlbl
            // 
            this.polozenlbl.AutoSize = true;
            this.polozenlbl.BackColor = System.Drawing.Color.Transparent;
            this.polozenlbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polozenlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polozenlbl.Location = new System.Drawing.Point(412, 122);
            this.polozenlbl.Name = "polozenlbl";
            this.polozenlbl.Size = new System.Drawing.Size(89, 23);
            this.polozenlbl.TabIndex = 45;
            this.polozenlbl.Text = "POLOŽIO";
            // 
            // datumlbl
            // 
            this.datumlbl.AutoSize = true;
            this.datumlbl.BackColor = System.Drawing.Color.Transparent;
            this.datumlbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datumlbl.Location = new System.Drawing.Point(412, 58);
            this.datumlbl.Name = "datumlbl";
            this.datumlbl.Size = new System.Drawing.Size(71, 23);
            this.datumlbl.TabIndex = 43;
            this.datumlbl.Text = "DATUM";
            // 
            // kategorija
            // 
            this.kategorija.BackColor = System.Drawing.Color.PeachPuff;
            this.kategorija.Location = new System.Drawing.Point(170, 108);
            this.kategorija.Name = "kategorija";
            this.kategorija.Size = new System.Drawing.Size(186, 26);
            this.kategorija.TabIndex = 42;
            // 
            // kandidatlbl
            // 
            this.kandidatlbl.AutoSize = true;
            this.kandidatlbl.BackColor = System.Drawing.Color.Transparent;
            this.kandidatlbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kandidatlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kandidatlbl.Location = new System.Drawing.Point(28, 108);
            this.kandidatlbl.Name = "kandidatlbl";
            this.kandidatlbl.Size = new System.Drawing.Size(98, 23);
            this.kandidatlbl.TabIndex = 41;
            this.kandidatlbl.Text = "KANDIDAT";
            // 
            // vrsta_polaganjalbl
            // 
            this.vrsta_polaganjalbl.AutoSize = true;
            this.vrsta_polaganjalbl.BackColor = System.Drawing.Color.Transparent;
            this.vrsta_polaganjalbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrsta_polaganjalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vrsta_polaganjalbl.Location = new System.Drawing.Point(28, 55);
            this.vrsta_polaganjalbl.Name = "vrsta_polaganjalbl";
            this.vrsta_polaganjalbl.Size = new System.Drawing.Size(33, 23);
            this.vrsta_polaganjalbl.TabIndex = 39;
            this.vrsta_polaganjalbl.Text = "TIP";
            // 
            // dataVozila
            // 
            this.dataVozila.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVozila.Location = new System.Drawing.Point(30, 206);
            this.dataVozila.Name = "dataVozila";
            this.dataVozila.RowHeadersWidth = 62;
            this.dataVozila.RowTemplate.Height = 28;
            this.dataVozila.Size = new System.Drawing.Size(666, 308);
            this.dataVozila.TabIndex = 38;
            // 
            // datum
            // 
            this.datum.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.datum.CalendarTitleBackColor = System.Drawing.Color.Chocolate;
            this.datum.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.datum.Location = new System.Drawing.Point(510, 55);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(186, 26);
            this.datum.TabIndex = 53;
            // 
            // vrsta_polaganja
            // 
            this.vrsta_polaganja.BackColor = System.Drawing.Color.PeachPuff;
            this.vrsta_polaganja.FormattingEnabled = true;
            this.vrsta_polaganja.Items.AddRange(new object[] {
            "teorija",
            "prva pomoć",
            "vožnja"});
            this.vrsta_polaganja.Location = new System.Drawing.Point(170, 53);
            this.vrsta_polaganja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vrsta_polaganja.Name = "vrsta_polaganja";
            this.vrsta_polaganja.Size = new System.Drawing.Size(186, 28);
            this.vrsta_polaganja.TabIndex = 58;
            // 
            // izbrisi
            // 
            this.izbrisi.BackColor = System.Drawing.Color.SandyBrown;
            this.izbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izbrisi.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izbrisi.Location = new System.Drawing.Point(744, 183);
            this.izbrisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.izbrisi.Name = "izbrisi";
            this.izbrisi.Size = new System.Drawing.Size(163, 53);
            this.izbrisi.TabIndex = 63;
            this.izbrisi.Text = "IZBRIŠI";
            this.izbrisi.UseVisualStyleBackColor = false;
            // 
            // promeni
            // 
            this.promeni.BackColor = System.Drawing.Color.SandyBrown;
            this.promeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.promeni.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promeni.Location = new System.Drawing.Point(744, 108);
            this.promeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.promeni.Name = "promeni";
            this.promeni.Size = new System.Drawing.Size(163, 53);
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
            this.dodaj.Location = new System.Drawing.Point(744, 28);
            this.dodaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(163, 53);
            this.dodaj.TabIndex = 61;
            this.dodaj.Text = "DODAJ";
            this.dodaj.UseVisualStyleBackColor = false;
            // 
            // osvezi
            // 
            this.osvezi.BackColor = System.Drawing.Color.LightSlateGray;
            this.osvezi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.osvezi.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osvezi.Location = new System.Drawing.Point(798, 380);
            this.osvezi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.osvezi.Name = "osvezi";
            this.osvezi.Size = new System.Drawing.Size(110, 53);
            this.osvezi.TabIndex = 60;
            this.osvezi.Text = "OSVEŽI";
            this.osvezi.UseVisualStyleBackColor = false;
            // 
            // izlaz
            // 
            this.izlaz.BackColor = System.Drawing.Color.LightSlateGray;
            this.izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izlaz.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izlaz.Location = new System.Drawing.Point(798, 461);
            this.izlaz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(110, 53);
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
            this.polozioda.Location = new System.Drawing.Point(533, 118);
            this.polozioda.Name = "polozioda";
            this.polozioda.Size = new System.Drawing.Size(60, 27);
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
            this.polozione.Location = new System.Drawing.Point(616, 118);
            this.polozione.Name = "polozione";
            this.polozione.Size = new System.Drawing.Size(57, 27);
            this.polozione.TabIndex = 65;
            this.polozione.TabStop = true;
            this.polozione.Text = "NE";
            this.polozione.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AM",
            "A1",
            "A2",
            "A",
            "B1",
            "B",
            "BE",
            "C1",
            "C1E",
            "C",
            "CE",
            "D1",
            "D1E",
            "D",
            "DE",
            "F",
            "M"});
            this.comboBox1.Location = new System.Drawing.Point(170, 159);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 28);
            this.comboBox1.TabIndex = 67;
            // 
            // kategorijalbl
            // 
            this.kategorijalbl.AutoSize = true;
            this.kategorijalbl.BackColor = System.Drawing.Color.Transparent;
            this.kategorijalbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategorijalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kategorijalbl.Location = new System.Drawing.Point(26, 164);
            this.kategorijalbl.Name = "kategorijalbl";
            this.kategorijalbl.Size = new System.Drawing.Size(119, 23);
            this.kategorijalbl.TabIndex = 66;
            this.kategorijalbl.Text = "KATEGORIJA";
            // 
            // Polaganja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 548);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.kategorijalbl);
            this.Controls.Add(this.polozione);
            this.Controls.Add(this.polozioda);
            this.Controls.Add(this.izbrisi);
            this.Controls.Add(this.promeni);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.osvezi);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.vrsta_polaganja);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.polozenlbl);
            this.Controls.Add(this.datumlbl);
            this.Controls.Add(this.kategorija);
            this.Controls.Add(this.kandidatlbl);
            this.Controls.Add(this.vrsta_polaganjalbl);
            this.Controls.Add(this.dataVozila);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Polaganja";
            this.Text = "Polaganja";
            this.Load += new System.EventHandler(this.Polaganja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label polozenlbl;
        private System.Windows.Forms.Label datumlbl;
        private System.Windows.Forms.TextBox kategorija;
        private System.Windows.Forms.Label kandidatlbl;
        private System.Windows.Forms.Label vrsta_polaganjalbl;
        private System.Windows.Forms.DataGridView dataVozila;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.ComboBox vrsta_polaganja;
        private System.Windows.Forms.Button izbrisi;
        private System.Windows.Forms.Button promeni;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button osvezi;
        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.RadioButton polozioda;
        private System.Windows.Forms.RadioButton polozione;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label kategorijalbl;
    }
}