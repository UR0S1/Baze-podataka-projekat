﻿namespace AutoSkolaJUS
{
    partial class Vozila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vozila));
            this.model = new System.Windows.Forms.TextBox();
            this.modellbl = new System.Windows.Forms.Label();
            this.brend = new System.Windows.Forms.TextBox();
            this.brendlbl = new System.Windows.Forms.Label();
            this.kategorijalbl = new System.Windows.Forms.Label();
            this.sifra_vozila = new System.Windows.Forms.TextBox();
            this.sifra_vozilalbl = new System.Windows.Forms.Label();
            this.dataVozila = new System.Windows.Forms.DataGridView();
            this.kategorija = new System.Windows.Forms.ComboBox();
            this.izbrisi = new System.Windows.Forms.Button();
            this.promeni = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.osvezi = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // model
            // 
            this.model.BackColor = System.Drawing.Color.PeachPuff;
            this.model.Location = new System.Drawing.Point(453, 80);
            this.model.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(165, 22);
            this.model.TabIndex = 29;
            // 
            // modellbl
            // 
            this.modellbl.AutoSize = true;
            this.modellbl.BackColor = System.Drawing.Color.Transparent;
            this.modellbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modellbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modellbl.Location = new System.Drawing.Point(367, 80);
            this.modellbl.Name = "modellbl";
            this.modellbl.Size = new System.Drawing.Size(59, 20);
            this.modellbl.TabIndex = 28;
            this.modellbl.Text = "MODEL";
            // 
            // brend
            // 
            this.brend.BackColor = System.Drawing.Color.PeachPuff;
            this.brend.Location = new System.Drawing.Point(453, 46);
            this.brend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brend.Name = "brend";
            this.brend.Size = new System.Drawing.Size(165, 22);
            this.brend.TabIndex = 27;
            // 
            // brendlbl
            // 
            this.brendlbl.AutoSize = true;
            this.brendlbl.BackColor = System.Drawing.Color.Transparent;
            this.brendlbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brendlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brendlbl.Location = new System.Drawing.Point(367, 48);
            this.brendlbl.Name = "brendlbl";
            this.brendlbl.Size = new System.Drawing.Size(55, 20);
            this.brendlbl.TabIndex = 26;
            this.brendlbl.Text = "BREND";
            // 
            // kategorijalbl
            // 
            this.kategorijalbl.AutoSize = true;
            this.kategorijalbl.BackColor = System.Drawing.Color.Transparent;
            this.kategorijalbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategorijalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kategorijalbl.Location = new System.Drawing.Point(23, 81);
            this.kategorijalbl.Name = "kategorijalbl";
            this.kategorijalbl.Size = new System.Drawing.Size(100, 20);
            this.kategorijalbl.TabIndex = 22;
            this.kategorijalbl.Text = "KATEGORIJA";
            // 
            // sifra_vozila
            // 
            this.sifra_vozila.BackColor = System.Drawing.Color.PeachPuff;
            this.sifra_vozila.Location = new System.Drawing.Point(145, 46);
            this.sifra_vozila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifra_vozila.Name = "sifra_vozila";
            this.sifra_vozila.Size = new System.Drawing.Size(165, 22);
            this.sifra_vozila.TabIndex = 21;
            // 
            // sifra_vozilalbl
            // 
            this.sifra_vozilalbl.AutoSize = true;
            this.sifra_vozilalbl.BackColor = System.Drawing.Color.Transparent;
            this.sifra_vozilalbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifra_vozilalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sifra_vozilalbl.Location = new System.Drawing.Point(23, 47);
            this.sifra_vozilalbl.Name = "sifra_vozilalbl";
            this.sifra_vozilalbl.Size = new System.Drawing.Size(47, 20);
            this.sifra_vozilalbl.TabIndex = 20;
            this.sifra_vozilalbl.Text = "ŠIFRA";
            // 
            // dataVozila
            // 
            this.dataVozila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVozila.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataVozila.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVozila.Location = new System.Drawing.Point(27, 129);
            this.dataVozila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataVozila.Name = "dataVozila";
            this.dataVozila.ReadOnly = true;
            this.dataVozila.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataVozila.RowHeadersVisible = false;
            this.dataVozila.RowHeadersWidth = 62;
            this.dataVozila.RowTemplate.Height = 28;
            this.dataVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVozila.Size = new System.Drawing.Size(592, 282);
            this.dataVozila.TabIndex = 19;
            this.dataVozila.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataVozila_CellClick);
            // 
            // kategorija
            // 
            this.kategorija.BackColor = System.Drawing.Color.PeachPuff;
            this.kategorija.FormattingEnabled = true;
            this.kategorija.Items.AddRange(new object[] {
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
            this.kategorija.Location = new System.Drawing.Point(145, 79);
            this.kategorija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kategorija.Name = "kategorija";
            this.kategorija.Size = new System.Drawing.Size(165, 24);
            this.kategorija.TabIndex = 39;
            // 
            // izbrisi
            // 
            this.izbrisi.BackColor = System.Drawing.Color.SandyBrown;
            this.izbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izbrisi.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izbrisi.Location = new System.Drawing.Point(661, 146);
            this.izbrisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.izbrisi.Name = "izbrisi";
            this.izbrisi.Size = new System.Drawing.Size(145, 42);
            this.izbrisi.TabIndex = 68;
            this.izbrisi.Text = "IZBRIŠI";
            this.izbrisi.UseVisualStyleBackColor = false;
            this.izbrisi.Click += new System.EventHandler(this.izbrisi_Click);
            // 
            // promeni
            // 
            this.promeni.BackColor = System.Drawing.Color.SandyBrown;
            this.promeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.promeni.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promeni.Location = new System.Drawing.Point(661, 86);
            this.promeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.promeni.Name = "promeni";
            this.promeni.Size = new System.Drawing.Size(145, 42);
            this.promeni.TabIndex = 67;
            this.promeni.Text = "PROMENI";
            this.promeni.UseVisualStyleBackColor = false;
            this.promeni.Click += new System.EventHandler(this.promeni_Click);
            // 
            // dodaj
            // 
            this.dodaj.BackColor = System.Drawing.Color.SandyBrown;
            this.dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodaj.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj.Location = new System.Drawing.Point(661, 22);
            this.dodaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(145, 42);
            this.dodaj.TabIndex = 66;
            this.dodaj.Text = "DODAJ";
            this.dodaj.UseVisualStyleBackColor = false;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // osvezi
            // 
            this.osvezi.BackColor = System.Drawing.Color.LightSlateGray;
            this.osvezi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.osvezi.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osvezi.Location = new System.Drawing.Point(709, 304);
            this.osvezi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.osvezi.Name = "osvezi";
            this.osvezi.Size = new System.Drawing.Size(97, 42);
            this.osvezi.TabIndex = 65;
            this.osvezi.Text = "OSVEŽI";
            this.osvezi.UseVisualStyleBackColor = false;
            // 
            // izlaz
            // 
            this.izlaz.BackColor = System.Drawing.Color.LightSlateGray;
            this.izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izlaz.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izlaz.Location = new System.Drawing.Point(709, 369);
            this.izlaz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(97, 42);
            this.izlaz.TabIndex = 64;
            this.izlaz.Text = "IZLAZ";
            this.izlaz.UseVisualStyleBackColor = false;
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click_1);
            // 
            // Vozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 438);
            this.Controls.Add(this.izbrisi);
            this.Controls.Add(this.promeni);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.osvezi);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.kategorija);
            this.Controls.Add(this.model);
            this.Controls.Add(this.modellbl);
            this.Controls.Add(this.brend);
            this.Controls.Add(this.brendlbl);
            this.Controls.Add(this.kategorijalbl);
            this.Controls.Add(this.sifra_vozila);
            this.Controls.Add(this.sifra_vozilalbl);
            this.Controls.Add(this.dataVozila);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Vozila";
            this.Text = "Vozila";
            ((System.ComponentModel.ISupportInitialize)(this.dataVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label modellbl;
        private System.Windows.Forms.TextBox brend;
        private System.Windows.Forms.Label brendlbl;
        private System.Windows.Forms.Label kategorijalbl;
        private System.Windows.Forms.TextBox sifra_vozila;
        private System.Windows.Forms.Label sifra_vozilalbl;
        private System.Windows.Forms.DataGridView dataVozila;
        private System.Windows.Forms.ComboBox kategorija;
        private System.Windows.Forms.Button izbrisi;
        private System.Windows.Forms.Button promeni;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button osvezi;
        private System.Windows.Forms.Button izlaz;
    }
}