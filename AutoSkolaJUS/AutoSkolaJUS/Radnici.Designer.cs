namespace AutoSkolaJUS
{
    partial class Radnici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Radnici));
            this.izbrisi = new System.Windows.Forms.Button();
            this.promeni = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.osvezi = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Button();
            this.pozicija = new System.Windows.Forms.ComboBox();
            this.vozilolbl = new System.Windows.Forms.Label();
            this.pozicijalbl = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.TextBox();
            this.adresalbl = new System.Windows.Forms.Label();
            this.jmbg = new System.Windows.Forms.TextBox();
            this.jmbglbl = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.TextBox();
            this.prezimelbl = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.TextBox();
            this.imelbl = new System.Windows.Forms.Label();
            this.dataRadnika = new System.Windows.Forms.DataGridView();
            this.vozilo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataRadnika)).BeginInit();
            this.SuspendLayout();
            // 
            // izbrisi
            // 
            this.izbrisi.BackColor = System.Drawing.Color.SandyBrown;
            this.izbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izbrisi.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izbrisi.Location = new System.Drawing.Point(741, 186);
            this.izbrisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.izbrisi.Name = "izbrisi";
            this.izbrisi.Size = new System.Drawing.Size(163, 53);
            this.izbrisi.TabIndex = 104;
            this.izbrisi.Text = "IZBRIŠI";
            this.izbrisi.UseVisualStyleBackColor = false;
            // 
            // promeni
            // 
            this.promeni.BackColor = System.Drawing.Color.SandyBrown;
            this.promeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.promeni.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promeni.Location = new System.Drawing.Point(741, 111);
            this.promeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.promeni.Name = "promeni";
            this.promeni.Size = new System.Drawing.Size(163, 53);
            this.promeni.TabIndex = 103;
            this.promeni.Text = "PROMENI";
            this.promeni.UseVisualStyleBackColor = false;
            this.promeni.Click += new System.EventHandler(this.promeni_Click);
            // 
            // dodaj
            // 
            this.dodaj.BackColor = System.Drawing.Color.SandyBrown;
            this.dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodaj.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj.Location = new System.Drawing.Point(741, 31);
            this.dodaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(163, 53);
            this.dodaj.TabIndex = 102;
            this.dodaj.Text = "DODAJ";
            this.dodaj.UseVisualStyleBackColor = false;
            // 
            // osvezi
            // 
            this.osvezi.BackColor = System.Drawing.Color.LightSlateGray;
            this.osvezi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.osvezi.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osvezi.Location = new System.Drawing.Point(795, 383);
            this.osvezi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.osvezi.Name = "osvezi";
            this.osvezi.Size = new System.Drawing.Size(110, 53);
            this.osvezi.TabIndex = 101;
            this.osvezi.Text = "OSVEŽI";
            this.osvezi.UseVisualStyleBackColor = false;
            // 
            // izlaz
            // 
            this.izlaz.BackColor = System.Drawing.Color.LightSlateGray;
            this.izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izlaz.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izlaz.Location = new System.Drawing.Point(795, 464);
            this.izlaz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(110, 53);
            this.izlaz.TabIndex = 100;
            this.izlaz.Text = "IZLAZ";
            this.izlaz.UseVisualStyleBackColor = false;
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            // 
            // pozicija
            // 
            this.pozicija.BackColor = System.Drawing.Color.PeachPuff;
            this.pozicija.FormattingEnabled = true;
            this.pozicija.Items.AddRange(new object[] {
            "instruktor",
            "glavni instruktor",
            "predavač",
            "sekretar"});
            this.pozicija.Location = new System.Drawing.Point(502, 96);
            this.pozicija.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pozicija.Name = "pozicija";
            this.pozicija.Size = new System.Drawing.Size(186, 28);
            this.pozicija.TabIndex = 99;
            // 
            // vozilolbl
            // 
            this.vozilolbl.AutoSize = true;
            this.vozilolbl.BackColor = System.Drawing.Color.Transparent;
            this.vozilolbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vozilolbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vozilolbl.Location = new System.Drawing.Point(388, 146);
            this.vozilolbl.Name = "vozilolbl";
            this.vozilolbl.Size = new System.Drawing.Size(77, 23);
            this.vozilolbl.TabIndex = 97;
            this.vozilolbl.Text = "VOZILO";
            // 
            // pozicijalbl
            // 
            this.pozicijalbl.AutoSize = true;
            this.pozicijalbl.BackColor = System.Drawing.Color.Transparent;
            this.pozicijalbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pozicijalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pozicijalbl.Location = new System.Drawing.Point(388, 98);
            this.pozicijalbl.Name = "pozicijalbl";
            this.pozicijalbl.Size = new System.Drawing.Size(88, 23);
            this.pozicijalbl.TabIndex = 96;
            this.pozicijalbl.Text = "POZICIJA";
            // 
            // adresa
            // 
            this.adresa.BackColor = System.Drawing.Color.PeachPuff;
            this.adresa.Location = new System.Drawing.Point(502, 46);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(186, 26);
            this.adresa.TabIndex = 95;
            // 
            // adresalbl
            // 
            this.adresalbl.AutoSize = true;
            this.adresalbl.BackColor = System.Drawing.Color.Transparent;
            this.adresalbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adresalbl.Location = new System.Drawing.Point(388, 50);
            this.adresalbl.Name = "adresalbl";
            this.adresalbl.Size = new System.Drawing.Size(77, 23);
            this.adresalbl.TabIndex = 94;
            this.adresalbl.Text = "ADRESA";
            // 
            // jmbg
            // 
            this.jmbg.BackColor = System.Drawing.Color.PeachPuff;
            this.jmbg.Location = new System.Drawing.Point(127, 143);
            this.jmbg.Name = "jmbg";
            this.jmbg.Size = new System.Drawing.Size(186, 26);
            this.jmbg.TabIndex = 93;
            // 
            // jmbglbl
            // 
            this.jmbglbl.AutoSize = true;
            this.jmbglbl.BackColor = System.Drawing.Color.Transparent;
            this.jmbglbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmbglbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jmbglbl.Location = new System.Drawing.Point(26, 146);
            this.jmbglbl.Name = "jmbglbl";
            this.jmbglbl.Size = new System.Drawing.Size(59, 23);
            this.jmbglbl.TabIndex = 92;
            this.jmbglbl.Text = "JMBG";
            // 
            // prezime
            // 
            this.prezime.BackColor = System.Drawing.Color.PeachPuff;
            this.prezime.Location = new System.Drawing.Point(127, 94);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(186, 26);
            this.prezime.TabIndex = 91;
            // 
            // prezimelbl
            // 
            this.prezimelbl.AutoSize = true;
            this.prezimelbl.BackColor = System.Drawing.Color.Transparent;
            this.prezimelbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezimelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prezimelbl.Location = new System.Drawing.Point(26, 95);
            this.prezimelbl.Name = "prezimelbl";
            this.prezimelbl.Size = new System.Drawing.Size(79, 23);
            this.prezimelbl.TabIndex = 90;
            this.prezimelbl.Text = "PREZIME";
            // 
            // ime
            // 
            this.ime.BackColor = System.Drawing.Color.PeachPuff;
            this.ime.Location = new System.Drawing.Point(127, 45);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(186, 26);
            this.ime.TabIndex = 89;
            // 
            // imelbl
            // 
            this.imelbl.AutoSize = true;
            this.imelbl.BackColor = System.Drawing.Color.Transparent;
            this.imelbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imelbl.Location = new System.Drawing.Point(26, 49);
            this.imelbl.Name = "imelbl";
            this.imelbl.Size = new System.Drawing.Size(38, 23);
            this.imelbl.TabIndex = 88;
            this.imelbl.Text = "IME";
            // 
            // dataRadnika
            // 
            this.dataRadnika.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRadnika.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataRadnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRadnika.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataRadnika.Location = new System.Drawing.Point(30, 201);
            this.dataRadnika.Name = "dataRadnika";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRadnika.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataRadnika.RowHeadersWidth = 62;
            this.dataRadnika.RowTemplate.Height = 28;
            this.dataRadnika.Size = new System.Drawing.Size(658, 316);
            this.dataRadnika.TabIndex = 87;
            // 
            // vozilo
            // 
            this.vozilo.BackColor = System.Drawing.Color.PeachPuff;
            this.vozilo.FormattingEnabled = true;
            this.vozilo.Location = new System.Drawing.Point(502, 145);
            this.vozilo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vozilo.Name = "vozilo";
            this.vozilo.Size = new System.Drawing.Size(186, 28);
            this.vozilo.TabIndex = 105;
            // 
            // Radnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 548);
            this.Controls.Add(this.vozilo);
            this.Controls.Add(this.izbrisi);
            this.Controls.Add(this.promeni);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.osvezi);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.pozicija);
            this.Controls.Add(this.vozilolbl);
            this.Controls.Add(this.pozicijalbl);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.adresalbl);
            this.Controls.Add(this.jmbg);
            this.Controls.Add(this.jmbglbl);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.prezimelbl);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.imelbl);
            this.Controls.Add(this.dataRadnika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Radnici";
            this.Text = "Radnici";
            ((System.ComponentModel.ISupportInitialize)(this.dataRadnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izbrisi;
        private System.Windows.Forms.Button promeni;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button osvezi;
        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.ComboBox pozicija;
        private System.Windows.Forms.Label vozilolbl;
        private System.Windows.Forms.Label pozicijalbl;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.Label adresalbl;
        private System.Windows.Forms.TextBox jmbg;
        private System.Windows.Forms.Label jmbglbl;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.Label prezimelbl;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.Label imelbl;
        private System.Windows.Forms.DataGridView dataRadnika;
        private System.Windows.Forms.ComboBox vozilo;
    }
}