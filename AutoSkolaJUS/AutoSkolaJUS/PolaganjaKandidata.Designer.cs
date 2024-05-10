namespace AutoSkolaJUS
{
    partial class PolaganjaKandidata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolaganjaKandidata));
            this.odlbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nazadbtn = new System.Windows.Forms.Button();
            this.lblpk = new System.Windows.Forms.Label();
            this.nazad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // odlbl
            // 
            this.odlbl.AutoSize = true;
            this.odlbl.BackColor = System.Drawing.Color.Transparent;
            this.odlbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.odlbl.Location = new System.Drawing.Point(18, 91);
            this.odlbl.Name = "odlbl";
            this.odlbl.Size = new System.Drawing.Size(53, 19);
            this.odlbl.TabIndex = 0;
            this.odlbl.Text = "Datum:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Chocolate;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(531, 214);
            this.dataGridView1.TabIndex = 4;
            // 
            // nazadbtn
            // 
            this.nazadbtn.Location = new System.Drawing.Point(708, 366);
            this.nazadbtn.Name = "nazadbtn";
            this.nazadbtn.Size = new System.Drawing.Size(67, 61);
            this.nazadbtn.TabIndex = 5;
            this.nazadbtn.Text = "NAZAD";
            this.nazadbtn.UseVisualStyleBackColor = true;
            // 
            // lblpk
            // 
            this.lblpk.AutoSize = true;
            this.lblpk.BackColor = System.Drawing.Color.Transparent;
            this.lblpk.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpk.Location = new System.Drawing.Point(12, 22);
            this.lblpk.Name = "lblpk";
            this.lblpk.Size = new System.Drawing.Size(458, 41);
            this.lblpk.TabIndex = 6;
            this.lblpk.Text = "Polaganje kandidata po datumu:";
            // 
            // nazad
            // 
            this.nazad.BackColor = System.Drawing.Color.LightSlateGray;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nazad.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazad.Location = new System.Drawing.Point(550, 304);
            this.nazad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(63, 43);
            this.nazad.TabIndex = 45;
            this.nazad.Text = "NAZAD";
            this.nazad.UseVisualStyleBackColor = false;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(550, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 43);
            this.button1.TabIndex = 68;
            this.button1.Text = "URADI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PolaganjaKandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.lblpk);
            this.Controls.Add(this.nazadbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.odlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PolaganjaKandidata";
            this.Text = "Polaganja Kandidata";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label odlbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button nazadbtn;
        private System.Windows.Forms.Label lblpk;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Button button1;
    }
}