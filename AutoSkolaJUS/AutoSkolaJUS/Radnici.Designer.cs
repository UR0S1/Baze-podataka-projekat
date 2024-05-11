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
            this.izlaz = new System.Windows.Forms.Button();
            this.pozicija = new System.Windows.Forms.ComboBox();
            this.vozilolbl = new System.Windows.Forms.Label();
            this.pozicijalbl = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.TextBox();
            this.adresalbl = new System.Windows.Forms.Label();
            this.jmbglbl = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.TextBox();
            this.prezimelbl = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.TextBox();
            this.imelbl = new System.Windows.Forms.Label();
            this.dataRadnika = new System.Windows.Forms.DataGridView();
            this.jmbg = new System.Windows.Forms.TextBox();
            this.cmbVozilo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataRadnika)).BeginInit();
            this.SuspendLayout();
            // 
            // izbrisi
            // 
            this.izbrisi.BackColor = System.Drawing.Color.SandyBrown;
            this.izbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izbrisi.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izbrisi.Location = new System.Drawing.Point(659, 149);
            this.izbrisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.izbrisi.Name = "izbrisi";
            this.izbrisi.Size = new System.Drawing.Size(145, 42);
            this.izbrisi.TabIndex = 104;
            this.izbrisi.Text = "IZBRIŠI";
            this.izbrisi.UseVisualStyleBackColor = false;
            this.izbrisi.Click += new System.EventHandler(this.izbrisi_Click);
            // 
            // promeni
            // 
            this.promeni.BackColor = System.Drawing.Color.SandyBrown;
            this.promeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.promeni.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promeni.Location = new System.Drawing.Point(659, 89);
            this.promeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.promeni.Name = "promeni";
            this.promeni.Size = new System.Drawing.Size(145, 42);
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
            this.dodaj.Location = new System.Drawing.Point(659, 25);
            this.dodaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(145, 42);
            this.dodaj.TabIndex = 102;
            this.dodaj.Text = "DODAJ";
            this.dodaj.UseVisualStyleBackColor = false;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // izlaz
            // 
            this.izlaz.BackColor = System.Drawing.Color.LightSlateGray;
            this.izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izlaz.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izlaz.Location = new System.Drawing.Point(707, 372);
            this.izlaz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(97, 42);
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
            this.pozicija.Location = new System.Drawing.Point(447, 76);
            this.pozicija.Margin = new System.Windows.Forms.Padding(4);
            this.pozicija.Name = "pozicija";
            this.pozicija.Size = new System.Drawing.Size(165, 24);
            this.pozicija.TabIndex = 99;
            // 
            // vozilolbl
            // 
            this.vozilolbl.AutoSize = true;
            this.vozilolbl.BackColor = System.Drawing.Color.Transparent;
            this.vozilolbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vozilolbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vozilolbl.Location = new System.Drawing.Point(345, 117);
            this.vozilolbl.Name = "vozilolbl";
            this.vozilolbl.Size = new System.Drawing.Size(66, 20);
            this.vozilolbl.TabIndex = 97;
            this.vozilolbl.Text = "VOZILO";
            // 
            // pozicijalbl
            // 
            this.pozicijalbl.AutoSize = true;
            this.pozicijalbl.BackColor = System.Drawing.Color.Transparent;
            this.pozicijalbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pozicijalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pozicijalbl.Location = new System.Drawing.Point(345, 79);
            this.pozicijalbl.Name = "pozicijalbl";
            this.pozicijalbl.Size = new System.Drawing.Size(75, 20);
            this.pozicijalbl.TabIndex = 96;
            this.pozicijalbl.Text = "POZICIJA";
            // 
            // adresa
            // 
            this.adresa.BackColor = System.Drawing.Color.PeachPuff;
            this.adresa.Location = new System.Drawing.Point(447, 37);
            this.adresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(165, 22);
            this.adresa.TabIndex = 95;
            // 
            // adresalbl
            // 
            this.adresalbl.AutoSize = true;
            this.adresalbl.BackColor = System.Drawing.Color.Transparent;
            this.adresalbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adresalbl.Location = new System.Drawing.Point(345, 39);
            this.adresalbl.Name = "adresalbl";
            this.adresalbl.Size = new System.Drawing.Size(64, 20);
            this.adresalbl.TabIndex = 94;
            this.adresalbl.Text = "ADRESA";
            // 
            // jmbglbl
            // 
            this.jmbglbl.AutoSize = true;
            this.jmbglbl.BackColor = System.Drawing.Color.Transparent;
            this.jmbglbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmbglbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jmbglbl.Location = new System.Drawing.Point(23, 117);
            this.jmbglbl.Name = "jmbglbl";
            this.jmbglbl.Size = new System.Drawing.Size(50, 20);
            this.jmbglbl.TabIndex = 92;
            this.jmbglbl.Text = "JMBG";
            // 
            // prezime
            // 
            this.prezime.BackColor = System.Drawing.Color.PeachPuff;
            this.prezime.Location = new System.Drawing.Point(113, 75);
            this.prezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(165, 22);
            this.prezime.TabIndex = 91;
            // 
            // prezimelbl
            // 
            this.prezimelbl.AutoSize = true;
            this.prezimelbl.BackColor = System.Drawing.Color.Transparent;
            this.prezimelbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezimelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prezimelbl.Location = new System.Drawing.Point(23, 76);
            this.prezimelbl.Name = "prezimelbl";
            this.prezimelbl.Size = new System.Drawing.Size(66, 20);
            this.prezimelbl.TabIndex = 90;
            this.prezimelbl.Text = "PREZIME";
            // 
            // ime
            // 
            this.ime.BackColor = System.Drawing.Color.PeachPuff;
            this.ime.Location = new System.Drawing.Point(113, 36);
            this.ime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(165, 22);
            this.ime.TabIndex = 89;
            // 
            // imelbl
            // 
            this.imelbl.AutoSize = true;
            this.imelbl.BackColor = System.Drawing.Color.Transparent;
            this.imelbl.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imelbl.Location = new System.Drawing.Point(23, 39);
            this.imelbl.Name = "imelbl";
            this.imelbl.Size = new System.Drawing.Size(33, 20);
            this.imelbl.TabIndex = 88;
            this.imelbl.Text = "IME";
            // 
            // dataRadnika
            // 
            this.dataRadnika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRadnika.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dataRadnika.Location = new System.Drawing.Point(27, 161);
            this.dataRadnika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRadnika.MultiSelect = false;
            this.dataRadnika.Name = "dataRadnika";
            this.dataRadnika.ReadOnly = true;
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
            this.dataRadnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRadnika.Size = new System.Drawing.Size(585, 252);
            this.dataRadnika.TabIndex = 87;
            this.dataRadnika.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRadnika_CellContentClick);
            this.dataRadnika.SelectionChanged += new System.EventHandler(this.dataRadnika_SelectionChanged);
            // 
            // jmbg
            // 
            this.jmbg.BackColor = System.Drawing.Color.PeachPuff;
            this.jmbg.Location = new System.Drawing.Point(113, 114);
            this.jmbg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jmbg.MaxLength = 13;
            this.jmbg.Name = "jmbg";
            this.jmbg.Size = new System.Drawing.Size(165, 22);
            this.jmbg.TabIndex = 93;
            // 
            // cmbVozilo
            // 
            this.cmbVozilo.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbVozilo.FormattingEnabled = true;
            this.cmbVozilo.Items.AddRange(new object[] {
            "instruktor",
            "glavni instruktor",
            "predavač",
            "sekretar"});
            this.cmbVozilo.Location = new System.Drawing.Point(447, 117);
            this.cmbVozilo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVozilo.Name = "cmbVozilo";
            this.cmbVozilo.Size = new System.Drawing.Size(165, 24);
            this.cmbVozilo.TabIndex = 105;
            // 
            // Radnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 438);
            this.Controls.Add(this.cmbVozilo);
            this.Controls.Add(this.izbrisi);
            this.Controls.Add(this.promeni);
            this.Controls.Add(this.dodaj);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Radnici";
            this.Text = "Radnici";
            this.Load += new System.EventHandler(this.Radnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRadnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izbrisi;
        private System.Windows.Forms.Button promeni;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.ComboBox pozicija;
        private System.Windows.Forms.Label vozilolbl;
        private System.Windows.Forms.Label pozicijalbl;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.Label adresalbl;
        private System.Windows.Forms.Label jmbglbl;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.Label prezimelbl;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.Label imelbl;
        private System.Windows.Forms.DataGridView dataRadnika;
        private System.Windows.Forms.TextBox jmbg;
        private System.Windows.Forms.ComboBox cmbVozilo;
    }
}