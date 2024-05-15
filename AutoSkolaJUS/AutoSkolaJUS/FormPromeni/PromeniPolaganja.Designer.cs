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
            this.kandidatlbl = new System.Windows.Forms.Label();
            this.vrsta_polaganjalbl = new System.Windows.Forms.Label();
            this.polozione = new System.Windows.Forms.RadioButton();
            this.polozioda = new System.Windows.Forms.RadioButton();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.datumlbl = new System.Windows.Forms.Label();
            this.kandidat = new System.Windows.Forms.ComboBox();
            this.polozenlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odustani
            // 
            this.odustani.BackColor = System.Drawing.Color.LightSlateGray;
            this.odustani.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.odustani.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odustani.Location = new System.Drawing.Point(281, 361);
            this.odustani.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.odustani.Name = "odustani";
            this.odustani.Size = new System.Drawing.Size(145, 42);
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
            this.promeni.Location = new System.Drawing.Point(35, 361);
            this.promeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.promeni.Name = "promeni";
            this.promeni.Size = new System.Drawing.Size(145, 42);
            this.promeni.TabIndex = 140;
            this.promeni.Text = "PROMENI";
            this.promeni.UseVisualStyleBackColor = false;
            this.promeni.Click += new System.EventHandler(this.promeni_Click);
            // 
            // vrsta_polaganja
            // 
            this.vrsta_polaganja.BackColor = System.Drawing.Color.PeachPuff;
            this.vrsta_polaganja.FormattingEnabled = true;
            this.vrsta_polaganja.Location = new System.Drawing.Point(225, 44);
            this.vrsta_polaganja.Margin = new System.Windows.Forms.Padding(4);
            this.vrsta_polaganja.Name = "vrsta_polaganja";
            this.vrsta_polaganja.Size = new System.Drawing.Size(201, 24);
            this.vrsta_polaganja.TabIndex = 149;
            this.vrsta_polaganja.SelectedIndexChanged += new System.EventHandler(this.vrsta_polaganja_SelectedIndexChanged);
            // 
            // kandidatlbl
            // 
            this.kandidatlbl.AutoSize = true;
            this.kandidatlbl.BackColor = System.Drawing.Color.Transparent;
            this.kandidatlbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kandidatlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kandidatlbl.Location = new System.Drawing.Point(31, 91);
            this.kandidatlbl.Name = "kandidatlbl";
            this.kandidatlbl.Size = new System.Drawing.Size(98, 23);
            this.kandidatlbl.TabIndex = 145;
            this.kandidatlbl.Text = "KANDIDAT";
            // 
            // vrsta_polaganjalbl
            // 
            this.vrsta_polaganjalbl.AutoSize = true;
            this.vrsta_polaganjalbl.BackColor = System.Drawing.Color.Transparent;
            this.vrsta_polaganjalbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrsta_polaganjalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vrsta_polaganjalbl.Location = new System.Drawing.Point(31, 47);
            this.vrsta_polaganjalbl.Name = "vrsta_polaganjalbl";
            this.vrsta_polaganjalbl.Size = new System.Drawing.Size(33, 23);
            this.vrsta_polaganjalbl.TabIndex = 144;
            this.vrsta_polaganjalbl.Text = "TIP";
            // 
            // polozione
            // 
            this.polozione.AutoSize = true;
            this.polozione.BackColor = System.Drawing.Color.Transparent;
            this.polozione.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polozione.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polozione.Location = new System.Drawing.Point(348, 194);
            this.polozione.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.polozione.Name = "polozione";
            this.polozione.Size = new System.Drawing.Size(53, 27);
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
            this.polozioda.Location = new System.Drawing.Point(251, 192);
            this.polozioda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.polozioda.Name = "polozioda";
            this.polozioda.Size = new System.Drawing.Size(56, 27);
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
            this.datum.Location = new System.Drawing.Point(225, 143);
            this.datum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(201, 22);
            this.datum.TabIndex = 152;
            // 
            // datumlbl
            // 
            this.datumlbl.AutoSize = true;
            this.datumlbl.BackColor = System.Drawing.Color.Transparent;
            this.datumlbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datumlbl.Location = new System.Drawing.Point(31, 140);
            this.datumlbl.Name = "datumlbl";
            this.datumlbl.Size = new System.Drawing.Size(71, 23);
            this.datumlbl.TabIndex = 150;
            this.datumlbl.Text = "DATUM";
            // 
            // kandidat
            // 
            this.kandidat.BackColor = System.Drawing.Color.PeachPuff;
            this.kandidat.FormattingEnabled = true;
            this.kandidat.Location = new System.Drawing.Point(227, 91);
            this.kandidat.Margin = new System.Windows.Forms.Padding(4);
            this.kandidat.Name = "kandidat";
            this.kandidat.Size = new System.Drawing.Size(201, 24);
            this.kandidat.TabIndex = 157;
            // 
            // polozenlbl
            // 
            this.polozenlbl.AutoSize = true;
            this.polozenlbl.BackColor = System.Drawing.Color.Transparent;
            this.polozenlbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polozenlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polozenlbl.Location = new System.Drawing.Point(31, 194);
            this.polozenlbl.Name = "polozenlbl";
            this.polozenlbl.Size = new System.Drawing.Size(89, 23);
            this.polozenlbl.TabIndex = 151;
            this.polozenlbl.Text = "POLOŽIO";
            // 
            // PromeniPolaganja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 438);
            this.Controls.Add(this.kandidat);
            this.Controls.Add(this.polozione);
            this.Controls.Add(this.polozioda);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.polozenlbl);
            this.Controls.Add(this.datumlbl);
            this.Controls.Add(this.vrsta_polaganja);
            this.Controls.Add(this.kandidatlbl);
            this.Controls.Add(this.vrsta_polaganjalbl);
            this.Controls.Add(this.odustani);
            this.Controls.Add(this.promeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PromeniPolaganja";
            this.Text = "Promeni polaganje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button odustani;
        private System.Windows.Forms.Button promeni;
        private System.Windows.Forms.ComboBox vrsta_polaganja;
        private System.Windows.Forms.Label kandidatlbl;
        private System.Windows.Forms.Label vrsta_polaganjalbl;
        private System.Windows.Forms.RadioButton polozione;
        private System.Windows.Forms.RadioButton polozioda;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Label datumlbl;
        private System.Windows.Forms.ComboBox kandidat;
        private System.Windows.Forms.Label polozenlbl;
    }
}