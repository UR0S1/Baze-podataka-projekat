namespace AutoSkolaJUS.FormPromeni
{
    partial class PromeniDuzi
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
            this.label1 = new System.Windows.Forms.Label();
            this.instruktor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datum_zaduzenja = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.datum_razduzenja = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.vozilo = new System.Windows.Forms.ComboBox();
            this.promeni = new System.Windows.Forms.Button();
            this.odustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "INSTRUKTOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // instruktor
            // 
            this.instruktor.BackColor = System.Drawing.Color.PeachPuff;
            this.instruktor.FormattingEnabled = true;
            this.instruktor.Location = new System.Drawing.Point(216, 55);
            this.instruktor.Margin = new System.Windows.Forms.Padding(4);
            this.instruktor.Name = "instruktor";
            this.instruktor.Size = new System.Drawing.Size(165, 24);
            this.instruktor.TabIndex = 55;
            this.instruktor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "DATUM ZADUŽENJA";
            // 
            // datum_zaduzenja
            // 
            this.datum_zaduzenja.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.datum_zaduzenja.CalendarTitleBackColor = System.Drawing.Color.Chocolate;
            this.datum_zaduzenja.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.datum_zaduzenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datum_zaduzenja.Location = new System.Drawing.Point(216, 158);
            this.datum_zaduzenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datum_zaduzenja.Name = "datum_zaduzenja";
            this.datum_zaduzenja.Size = new System.Drawing.Size(165, 22);
            this.datum_zaduzenja.TabIndex = 58;
            this.datum_zaduzenja.ValueChanged += new System.EventHandler(this.datum_zaduzenja_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(45, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "DATUM RAZDUŽENJA";
            // 
            // datum_razduzenja
            // 
            this.datum_razduzenja.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.datum_razduzenja.CalendarTitleBackColor = System.Drawing.Color.Chocolate;
            this.datum_razduzenja.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.datum_razduzenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datum_razduzenja.Location = new System.Drawing.Point(216, 206);
            this.datum_razduzenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datum_razduzenja.Name = "datum_razduzenja";
            this.datum_razduzenja.Size = new System.Drawing.Size(165, 22);
            this.datum_razduzenja.TabIndex = 60;
            this.datum_razduzenja.ValueChanged += new System.EventHandler(this.datum_razduzenja_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(45, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "VOZILO";
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
            this.vozilo.Location = new System.Drawing.Point(216, 107);
            this.vozilo.Margin = new System.Windows.Forms.Padding(4);
            this.vozilo.Name = "vozilo";
            this.vozilo.Size = new System.Drawing.Size(165, 24);
            this.vozilo.TabIndex = 70;
            // 
            // promeni
            // 
            this.promeni.BackColor = System.Drawing.Color.SandyBrown;
            this.promeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.promeni.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promeni.Location = new System.Drawing.Point(33, 382);
            this.promeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.promeni.Name = "promeni";
            this.promeni.Size = new System.Drawing.Size(145, 42);
            this.promeni.TabIndex = 67;
            this.promeni.Text = "PROMENI";
            this.promeni.UseVisualStyleBackColor = false;
            this.promeni.Click += new System.EventHandler(this.promeni_Click);
            // 
            // odustani
            // 
            this.odustani.BackColor = System.Drawing.Color.LightSlateGray;
            this.odustani.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.odustani.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odustani.Location = new System.Drawing.Point(226, 382);
            this.odustani.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.odustani.Name = "odustani";
            this.odustani.Size = new System.Drawing.Size(155, 42);
            this.odustani.TabIndex = 64;
            this.odustani.Text = "ODUSTANI";
            this.odustani.UseVisualStyleBackColor = false;
            this.odustani.Click += new System.EventHandler(this.odustani_Click);
            // 
            // PromeniDuzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 454);
            this.Controls.Add(this.vozilo);
            this.Controls.Add(this.promeni);
            this.Controls.Add(this.odustani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.instruktor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datum_zaduzenja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datum_razduzenja);
            this.Name = "PromeniDuzi";
            this.Text = "Promeni Duži";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox instruktor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datum_zaduzenja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datum_razduzenja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox vozilo;
        private System.Windows.Forms.Button promeni;
        private System.Windows.Forms.Button odustani;
    }
}