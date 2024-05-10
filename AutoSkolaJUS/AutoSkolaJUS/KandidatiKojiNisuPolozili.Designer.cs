namespace AutoSkolaJUS
{
    partial class KandidatiKojiNisuPolozili
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KandidatiKojiNisuPolozili));
            this.nazad = new System.Windows.Forms.Button();
            this.lblpk = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dolbl = new System.Windows.Forms.Label();
            this.odlbl = new System.Windows.Forms.Label();
            this.instruktor = new System.Windows.Forms.ComboBox();
            this.instlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // nazad
            // 
            this.nazad.BackColor = System.Drawing.Color.LightSlateGray;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nazad.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazad.Location = new System.Drawing.Point(825, 463);
            this.nazad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(94, 66);
            this.nazad.TabIndex = 70;
            this.nazad.Text = "NAZAD";
            this.nazad.UseVisualStyleBackColor = false;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // lblpk
            // 
            this.lblpk.AutoSize = true;
            this.lblpk.BackColor = System.Drawing.Color.Transparent;
            this.lblpk.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpk.Location = new System.Drawing.Point(17, 19);
            this.lblpk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpk.Name = "lblpk";
            this.lblpk.Size = new System.Drawing.Size(676, 61);
            this.lblpk.TabIndex = 69;
            this.lblpk.Text = "Kandidati koji su pali polaganje:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 200);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(796, 329);
            this.dataGridView2.TabIndex = 68;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(564, 154);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(244, 26);
            this.dateTimePicker2.TabIndex = 67;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Chocolate;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 152);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 26);
            this.dateTimePicker1.TabIndex = 66;
            // 
            // dolbl
            // 
            this.dolbl.AutoSize = true;
            this.dolbl.BackColor = System.Drawing.Color.Transparent;
            this.dolbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dolbl.Location = new System.Drawing.Point(457, 152);
            this.dolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dolbl.Name = "dolbl";
            this.dolbl.Size = new System.Drawing.Size(49, 28);
            this.dolbl.TabIndex = 65;
            this.dolbl.Text = "DO:";
            // 
            // odlbl
            // 
            this.odlbl.AutoSize = true;
            this.odlbl.BackColor = System.Drawing.Color.Transparent;
            this.odlbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.odlbl.Location = new System.Drawing.Point(14, 152);
            this.odlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.odlbl.Name = "odlbl";
            this.odlbl.Size = new System.Drawing.Size(49, 28);
            this.odlbl.TabIndex = 64;
            this.odlbl.Text = "OD:";
            // 
            // instruktor
            // 
            this.instruktor.BackColor = System.Drawing.Color.PeachPuff;
            this.instruktor.FormattingEnabled = true;
            this.instruktor.Location = new System.Drawing.Point(189, 105);
            this.instruktor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.instruktor.Name = "instruktor";
            this.instruktor.Size = new System.Drawing.Size(214, 28);
            this.instruktor.TabIndex = 72;
            // 
            // instlbl
            // 
            this.instlbl.AutoSize = true;
            this.instlbl.BackColor = System.Drawing.Color.Transparent;
            this.instlbl.Font = new System.Drawing.Font("Tw Cen MT", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.instlbl.Location = new System.Drawing.Point(13, 105);
            this.instlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instlbl.Name = "instlbl";
            this.instlbl.Size = new System.Drawing.Size(120, 33);
            this.instlbl.TabIndex = 71;
            this.instlbl.Text = "Instruktor:";
            // 
            // KandidatiKojiNisuPolozili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 548);
            this.Controls.Add(this.instruktor);
            this.Controls.Add(this.instlbl);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.lblpk);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dolbl);
            this.Controls.Add(this.odlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KandidatiKojiNisuPolozili";
            this.Text = "Kandidati koji nisu položili";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Label lblpk;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dolbl;
        private System.Windows.Forms.Label odlbl;
        private System.Windows.Forms.ComboBox instruktor;
        private System.Windows.Forms.Label instlbl;
    }
}