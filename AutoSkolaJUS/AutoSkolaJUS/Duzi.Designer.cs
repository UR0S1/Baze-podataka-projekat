namespace AutoSkolaJUS
{
    partial class Duzi
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
            this.dataDuzi = new System.Windows.Forms.DataGridView();
            this.izbrisi = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.vozilo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.instruktor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datum_zaduzenja = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.datum_razduzenja = new System.Windows.Forms.DateTimePicker();
            this.promeni = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDuzi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDuzi
            // 
            this.dataDuzi.AllowUserToAddRows = false;
            this.dataDuzi.AllowUserToDeleteRows = false;
            this.dataDuzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDuzi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataDuzi.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataDuzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDuzi.Location = new System.Drawing.Point(31, 201);
            this.dataDuzi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataDuzi.Name = "dataDuzi";
            this.dataDuzi.ReadOnly = true;
            this.dataDuzi.RowHeadersVisible = false;
            this.dataDuzi.RowHeadersWidth = 62;
            this.dataDuzi.RowTemplate.Height = 28;
            this.dataDuzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDuzi.Size = new System.Drawing.Size(585, 215);
            this.dataDuzi.TabIndex = 56;
            this.dataDuzi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDuzi_CellClick);
            // 
            // izbrisi
            // 
            this.izbrisi.BackColor = System.Drawing.Color.SandyBrown;
            this.izbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izbrisi.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izbrisi.Location = new System.Drawing.Point(630, 142);
            this.izbrisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.izbrisi.Name = "izbrisi";
            this.izbrisi.Size = new System.Drawing.Size(145, 42);
            this.izbrisi.TabIndex = 68;
            this.izbrisi.Text = "IZBRIŠI";
            this.izbrisi.UseVisualStyleBackColor = false;
            this.izbrisi.Click += new System.EventHandler(this.izbrisi_Click);
            // 
            // dodaj
            // 
            this.dodaj.BackColor = System.Drawing.Color.SandyBrown;
            this.dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodaj.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj.Location = new System.Drawing.Point(630, 18);
            this.dodaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(145, 42);
            this.dodaj.TabIndex = 66;
            this.dodaj.Text = "DODAJ";
            this.dodaj.UseVisualStyleBackColor = false;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // vozilo
            // 
            this.vozilo.BackColor = System.Drawing.Color.PeachPuff;
            this.vozilo.FormattingEnabled = true;
            this.vozilo.Items.AddRange(new object[] {
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
            this.vozilo.Location = new System.Drawing.Point(217, 63);
            this.vozilo.Margin = new System.Windows.Forms.Padding(4);
            this.vozilo.Name = "vozilo";
            this.vozilo.Size = new System.Drawing.Size(165, 24);
            this.vozilo.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "INSTRUKTOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(46, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "VOZILO";
            // 
            // instruktor
            // 
            this.instruktor.BackColor = System.Drawing.Color.PeachPuff;
            this.instruktor.FormattingEnabled = true;
            this.instruktor.Location = new System.Drawing.Point(217, 18);
            this.instruktor.Margin = new System.Windows.Forms.Padding(4);
            this.instruktor.Name = "instruktor";
            this.instruktor.Size = new System.Drawing.Size(165, 24);
            this.instruktor.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(46, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "DATUM ZADUŽENJA";
            // 
            // datum_zaduzenja
            // 
            this.datum_zaduzenja.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.datum_zaduzenja.CalendarTitleBackColor = System.Drawing.Color.Chocolate;
            this.datum_zaduzenja.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.datum_zaduzenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datum_zaduzenja.Location = new System.Drawing.Point(217, 110);
            this.datum_zaduzenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datum_zaduzenja.Name = "datum_zaduzenja";
            this.datum_zaduzenja.Size = new System.Drawing.Size(165, 22);
            this.datum_zaduzenja.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(46, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "DATUM RAZDUŽENJA";
            // 
            // datum_razduzenja
            // 
            this.datum_razduzenja.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.datum_razduzenja.CalendarTitleBackColor = System.Drawing.Color.Chocolate;
            this.datum_razduzenja.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.datum_razduzenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datum_razduzenja.Location = new System.Drawing.Point(217, 155);
            this.datum_razduzenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datum_razduzenja.Name = "datum_razduzenja";
            this.datum_razduzenja.Size = new System.Drawing.Size(165, 22);
            this.datum_razduzenja.TabIndex = 76;
            // 
            // promeni
            // 
            this.promeni.BackColor = System.Drawing.Color.SandyBrown;
            this.promeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.promeni.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promeni.Location = new System.Drawing.Point(630, 79);
            this.promeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.promeni.Name = "promeni";
            this.promeni.Size = new System.Drawing.Size(145, 42);
            this.promeni.TabIndex = 79;
            this.promeni.Text = "PROMENI";
            this.promeni.UseVisualStyleBackColor = false;
            this.promeni.Click += new System.EventHandler(this.promeni_Click);
            // 
            // izlaz
            // 
            this.izlaz.BackColor = System.Drawing.Color.LightSlateGray;
            this.izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izlaz.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izlaz.Location = new System.Drawing.Point(678, 358);
            this.izlaz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(97, 42);
            this.izlaz.TabIndex = 80;
            this.izlaz.Text = "IZLAZ";
            this.izlaz.UseVisualStyleBackColor = false;
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click_1);
            // 
            // Duzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.promeni);
            this.Controls.Add(this.vozilo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.instruktor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datum_zaduzenja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datum_razduzenja);
            this.Controls.Add(this.izbrisi);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.dataDuzi);
            this.Name = "Duzi";
            this.Text = "Duzi";
            ((System.ComponentModel.ISupportInitialize)(this.dataDuzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataDuzi;
        private System.Windows.Forms.Button izbrisi;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.ComboBox vozilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox instruktor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datum_zaduzenja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datum_razduzenja;
        private System.Windows.Forms.Button promeni;
        private System.Windows.Forms.Button izlaz;
    }
}