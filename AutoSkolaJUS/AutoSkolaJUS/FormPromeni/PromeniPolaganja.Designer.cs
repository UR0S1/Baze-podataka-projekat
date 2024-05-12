namespace AutoSkolaJUS
{
    partial class PromeniPolaganja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromeniPolaganja));
            this.odustani = new System.Windows.Forms.Button();
            this.promeni = new System.Windows.Forms.Button();
            this.vrsta_polaganja = new System.Windows.Forms.ComboBox();
            this.kategorija = new System.Windows.Forms.TextBox();
            this.kandidatlbl = new System.Windows.Forms.Label();
            this.vrsta_polaganjalbl = new System.Windows.Forms.Label();
            this.polozione = new System.Windows.Forms.RadioButton();
            this.polozioda = new System.Windows.Forms.RadioButton();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.polozenlbl = new System.Windows.Forms.Label();
            this.datumlbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kategorijalbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odustani
            // 
            this.odustani.BackColor = System.Drawing.Color.LightSlateGray;
            this.odustani.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.odustani.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odustani.Location = new System.Drawing.Point(317, 451);
            this.odustani.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.odustani.Name = "odustani";
            this.odustani.Size = new System.Drawing.Size(163, 53);
            this.odustani.TabIndex = 141;
            this.odustani.Text = "ODUSTANI";
            this.odustani.UseVisualStyleBackColor = false;
            this.odustani.Click += new System.EventHandler(this.odustani_Click);
            // 
            // promeni
            // 
            this.promeni.BackColor = System.Drawing.Color.SandyBrown;
            this.promeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.promeni.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promeni.Location = new System.Drawing.Point(39, 451);
            this.promeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.promeni.Name = "promeni";
            this.promeni.Size = new System.Drawing.Size(163, 53);
            this.promeni.TabIndex = 140;
            this.promeni.Text = "PROMENI";
            this.promeni.UseVisualStyleBackColor = false;
            // 
            // vrsta_polaganja
            // 
            this.vrsta_polaganja.BackColor = System.Drawing.Color.PeachPuff;
            this.vrsta_polaganja.FormattingEnabled = true;
            this.vrsta_polaganja.Items.AddRange(new object[] {
            "teorija",
            "prva pomoć",
            "vožnja"});
            this.vrsta_polaganja.Location = new System.Drawing.Point(254, 56);
            this.vrsta_polaganja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vrsta_polaganja.Name = "vrsta_polaganja";
            this.vrsta_polaganja.Size = new System.Drawing.Size(226, 28);
            this.vrsta_polaganja.TabIndex = 149;
            // 
            // kategorija
            // 
            this.kategorija.BackColor = System.Drawing.Color.PeachPuff;
            this.kategorija.Location = new System.Drawing.Point(254, 114);
            this.kategorija.Name = "kategorija";
            this.kategorija.Size = new System.Drawing.Size(226, 26);
            this.kategorija.TabIndex = 146;
            // 
            // kandidatlbl
            // 
            this.kandidatlbl.AutoSize = true;
            this.kandidatlbl.BackColor = System.Drawing.Color.Transparent;
            this.kandidatlbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kandidatlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kandidatlbl.Location = new System.Drawing.Point(34, 114);
            this.kandidatlbl.Name = "kandidatlbl";
            this.kandidatlbl.Size = new System.Drawing.Size(114, 28);
            this.kandidatlbl.TabIndex = 145;
            this.kandidatlbl.Text = "KANDIDAT";
            // 
            // vrsta_polaganjalbl
            // 
            this.vrsta_polaganjalbl.AutoSize = true;
            this.vrsta_polaganjalbl.BackColor = System.Drawing.Color.Transparent;
            this.vrsta_polaganjalbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrsta_polaganjalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vrsta_polaganjalbl.Location = new System.Drawing.Point(34, 58);
            this.vrsta_polaganjalbl.Name = "vrsta_polaganjalbl";
            this.vrsta_polaganjalbl.Size = new System.Drawing.Size(39, 28);
            this.vrsta_polaganjalbl.TabIndex = 144;
            this.vrsta_polaganjalbl.Text = "TIP";
            // 
            // polozione
            // 
            this.polozione.AutoSize = true;
            this.polozione.BackColor = System.Drawing.Color.Transparent;
            this.polozione.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polozione.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polozione.Location = new System.Drawing.Point(391, 325);
            this.polozione.Name = "polozione";
            this.polozione.Size = new System.Drawing.Size(62, 32);
            this.polozione.TabIndex = 154;
            this.polozione.TabStop = true;
            this.polozione.Text = "NE";
            this.polozione.UseVisualStyleBackColor = false;
            // 
            // polozioda
            // 
            this.polozioda.AutoSize = true;
            this.polozioda.BackColor = System.Drawing.Color.Transparent;
            this.polozioda.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polozioda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polozioda.Location = new System.Drawing.Point(282, 323);
            this.polozioda.Name = "polozioda";
            this.polozioda.Size = new System.Drawing.Size(66, 32);
            this.polozioda.TabIndex = 153;
            this.polozioda.TabStop = true;
            this.polozioda.Text = "DA";
            this.polozioda.UseVisualStyleBackColor = false;
            // 
            // datum
            // 
            this.datum.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.datum.CalendarTitleBackColor = System.Drawing.Color.Chocolate;
            this.datum.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.datum.Location = new System.Drawing.Point(254, 238);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(226, 26);
            this.datum.TabIndex = 152;
            // 
            // polozenlbl
            // 
            this.polozenlbl.AutoSize = true;
            this.polozenlbl.BackColor = System.Drawing.Color.Transparent;
            this.polozenlbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polozenlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polozenlbl.Location = new System.Drawing.Point(34, 325);
            this.polozenlbl.Name = "polozenlbl";
            this.polozenlbl.Size = new System.Drawing.Size(106, 28);
            this.polozenlbl.TabIndex = 151;
            this.polozenlbl.Text = "POLOŽIO";
            // 
            // datumlbl
            // 
            this.datumlbl.AutoSize = true;
            this.datumlbl.BackColor = System.Drawing.Color.Transparent;
            this.datumlbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datumlbl.Location = new System.Drawing.Point(34, 236);
            this.datumlbl.Name = "datumlbl";
            this.datumlbl.Size = new System.Drawing.Size(83, 28);
            this.datumlbl.TabIndex = 150;
            this.datumlbl.Text = "DATUM";
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
            this.comboBox1.Location = new System.Drawing.Point(255, 174);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 28);
            this.comboBox1.TabIndex = 156;
            // 
            // kategorijalbl
            // 
            this.kategorijalbl.AutoSize = true;
            this.kategorijalbl.BackColor = System.Drawing.Color.Transparent;
            this.kategorijalbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategorijalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kategorijalbl.Location = new System.Drawing.Point(34, 174);
            this.kategorijalbl.Name = "kategorijalbl";
            this.kategorijalbl.Size = new System.Drawing.Size(139, 28);
            this.kategorijalbl.TabIndex = 155;
            this.kategorijalbl.Text = "KATEGORIJA";
            // 
            // PromeniPolaganja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 548);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.kategorijalbl);
            this.Controls.Add(this.polozione);
            this.Controls.Add(this.polozioda);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.polozenlbl);
            this.Controls.Add(this.datumlbl);
            this.Controls.Add(this.vrsta_polaganja);
            this.Controls.Add(this.kategorija);
            this.Controls.Add(this.kandidatlbl);
            this.Controls.Add(this.vrsta_polaganjalbl);
            this.Controls.Add(this.odustani);
            this.Controls.Add(this.promeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PromeniPolaganja";
            this.Text = "Promeni polaganje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button odustani;
        private System.Windows.Forms.Button promeni;
        private System.Windows.Forms.ComboBox vrsta_polaganja;
        private System.Windows.Forms.TextBox kategorija;
        private System.Windows.Forms.Label kandidatlbl;
        private System.Windows.Forms.Label vrsta_polaganjalbl;
        private System.Windows.Forms.RadioButton polozione;
        private System.Windows.Forms.RadioButton polozioda;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Label polozenlbl;
        private System.Windows.Forms.Label datumlbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label kategorijalbl;
    }
}