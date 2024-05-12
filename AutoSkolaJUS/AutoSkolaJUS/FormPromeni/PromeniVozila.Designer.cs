namespace AutoSkolaJUS
{
    partial class PromeniVozila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromeniVozila));
            this.odustani = new System.Windows.Forms.Button();
            this.promeni = new System.Windows.Forms.Button();
            this.kategorija = new System.Windows.Forms.ComboBox();
            this.kategorijalbl = new System.Windows.Forms.Label();
            this.sifra_vozila = new System.Windows.Forms.TextBox();
            this.sifra_vozilalbl = new System.Windows.Forms.Label();
            this.pozicija = new System.Windows.Forms.TextBox();
            this.modellbl = new System.Windows.Forms.Label();
            this.brend = new System.Windows.Forms.TextBox();
            this.brendlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odustani
            // 
            this.odustani.BackColor = System.Drawing.Color.LightSlateGray;
            this.odustani.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.odustani.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odustani.Location = new System.Drawing.Point(317, 450);
            this.odustani.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.odustani.Name = "odustani";
            this.odustani.Size = new System.Drawing.Size(163, 53);
            this.odustani.TabIndex = 119;
            this.odustani.Text = "ODUSTANI";
            this.odustani.UseVisualStyleBackColor = false;
            this.odustani.Click += new System.EventHandler(this.odustani_Click);
            // 
            // promeni
            // 
            this.promeni.BackColor = System.Drawing.Color.SandyBrown;
            this.promeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.promeni.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promeni.Location = new System.Drawing.Point(39, 450);
            this.promeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.promeni.Name = "promeni";
            this.promeni.Size = new System.Drawing.Size(163, 53);
            this.promeni.TabIndex = 118;
            this.promeni.Text = "PROMENI";
            this.promeni.UseVisualStyleBackColor = false;
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
            this.kategorija.Location = new System.Drawing.Point(254, 150);
            this.kategorija.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kategorija.Name = "kategorija";
            this.kategorija.Size = new System.Drawing.Size(226, 28);
            this.kategorija.TabIndex = 135;
            // 
            // kategorijalbl
            // 
            this.kategorijalbl.AutoSize = true;
            this.kategorijalbl.BackColor = System.Drawing.Color.Transparent;
            this.kategorijalbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategorijalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kategorijalbl.Location = new System.Drawing.Point(33, 150);
            this.kategorijalbl.Name = "kategorijalbl";
            this.kategorijalbl.Size = new System.Drawing.Size(139, 28);
            this.kategorijalbl.TabIndex = 134;
            this.kategorijalbl.Text = "KATEGORIJA";
            // 
            // sifra_vozila
            // 
            this.sifra_vozila.BackColor = System.Drawing.Color.PeachPuff;
            this.sifra_vozila.Location = new System.Drawing.Point(254, 76);
            this.sifra_vozila.Name = "sifra_vozila";
            this.sifra_vozila.Size = new System.Drawing.Size(226, 26);
            this.sifra_vozila.TabIndex = 133;
            // 
            // sifra_vozilalbl
            // 
            this.sifra_vozilalbl.AutoSize = true;
            this.sifra_vozilalbl.BackColor = System.Drawing.Color.Transparent;
            this.sifra_vozilalbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifra_vozilalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sifra_vozilalbl.Location = new System.Drawing.Point(33, 74);
            this.sifra_vozilalbl.Name = "sifra_vozilalbl";
            this.sifra_vozilalbl.Size = new System.Drawing.Size(65, 28);
            this.sifra_vozilalbl.TabIndex = 132;
            this.sifra_vozilalbl.Text = "ŠIFRA";
            // 
            // pozicija
            // 
            this.pozicija.BackColor = System.Drawing.Color.PeachPuff;
            this.pozicija.Location = new System.Drawing.Point(254, 297);
            this.pozicija.Name = "pozicija";
            this.pozicija.Size = new System.Drawing.Size(226, 26);
            this.pozicija.TabIndex = 139;
            // 
            // modellbl
            // 
            this.modellbl.AutoSize = true;
            this.modellbl.BackColor = System.Drawing.Color.Transparent;
            this.modellbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modellbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modellbl.Location = new System.Drawing.Point(34, 297);
            this.modellbl.Name = "modellbl";
            this.modellbl.Size = new System.Drawing.Size(82, 28);
            this.modellbl.TabIndex = 138;
            this.modellbl.Text = "MODEL";
            // 
            // brend
            // 
            this.brend.BackColor = System.Drawing.Color.PeachPuff;
            this.brend.Location = new System.Drawing.Point(254, 225);
            this.brend.Name = "brend";
            this.brend.Size = new System.Drawing.Size(226, 26);
            this.brend.TabIndex = 137;
            // 
            // brendlbl
            // 
            this.brendlbl.AutoSize = true;
            this.brendlbl.BackColor = System.Drawing.Color.Transparent;
            this.brendlbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brendlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brendlbl.Location = new System.Drawing.Point(34, 228);
            this.brendlbl.Name = "brendlbl";
            this.brendlbl.Size = new System.Drawing.Size(77, 28);
            this.brendlbl.TabIndex = 136;
            this.brendlbl.Text = "BREND";
            // 
            // PromeniVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 548);
            this.Controls.Add(this.pozicija);
            this.Controls.Add(this.modellbl);
            this.Controls.Add(this.brend);
            this.Controls.Add(this.brendlbl);
            this.Controls.Add(this.kategorija);
            this.Controls.Add(this.kategorijalbl);
            this.Controls.Add(this.sifra_vozila);
            this.Controls.Add(this.sifra_vozilalbl);
            this.Controls.Add(this.odustani);
            this.Controls.Add(this.promeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PromeniVozila";
            this.Text = "Promeni vozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button odustani;
        private System.Windows.Forms.Button promeni;
        private System.Windows.Forms.ComboBox kategorija;
        private System.Windows.Forms.Label kategorijalbl;
        private System.Windows.Forms.TextBox sifra_vozila;
        private System.Windows.Forms.Label sifra_vozilalbl;
        private System.Windows.Forms.TextBox pozicija;
        private System.Windows.Forms.Label modellbl;
        private System.Windows.Forms.TextBox brend;
        private System.Windows.Forms.Label brendlbl;
    }
}