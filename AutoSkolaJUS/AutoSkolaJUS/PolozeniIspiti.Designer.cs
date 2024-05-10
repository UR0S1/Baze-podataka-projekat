namespace AutoSkolaJUS
{
    partial class PolozeniIspiti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolozeniIspiti));
            this.nazadbtn = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.lblpk = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dolbl = new System.Windows.Forms.Label();
            this.odlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // nazadbtn
            // 
            this.nazadbtn.Location = new System.Drawing.Point(708, 366);
            this.nazadbtn.Name = "nazadbtn";
            this.nazadbtn.Size = new System.Drawing.Size(67, 61);
            this.nazadbtn.TabIndex = 7;
            this.nazadbtn.Text = "NAZAD";
            this.nazadbtn.UseVisualStyleBackColor = true;
            this.nazadbtn.Click += new System.EventHandler(this.nazadbtn_Click);
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
            this.nazad.TabIndex = 52;
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
            this.lblpk.Location = new System.Drawing.Point(11, 16);
            this.lblpk.Name = "lblpk";
            this.lblpk.Size = new System.Drawing.Size(216, 41);
            this.lblpk.TabIndex = 51;
            this.lblpk.Text = "Položeni ispiti:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 133);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(531, 214);
            this.dataGridView2.TabIndex = 50;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(376, 81);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker2.TabIndex = 49;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Chocolate;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 48;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dolbl
            // 
            this.dolbl.AutoSize = true;
            this.dolbl.BackColor = System.Drawing.Color.Transparent;
            this.dolbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dolbl.Location = new System.Drawing.Point(303, 80);
            this.dolbl.Name = "dolbl";
            this.dolbl.Size = new System.Drawing.Size(33, 19);
            this.dolbl.TabIndex = 47;
            this.dolbl.Text = "DO:";
            // 
            // odlbl
            // 
            this.odlbl.AutoSize = true;
            this.odlbl.BackColor = System.Drawing.Color.Transparent;
            this.odlbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.odlbl.Location = new System.Drawing.Point(8, 80);
            this.odlbl.Name = "odlbl";
            this.odlbl.Size = new System.Drawing.Size(33, 19);
            this.odlbl.TabIndex = 46;
            this.odlbl.Text = "OD:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(550, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 43);
            this.button1.TabIndex = 68;
            this.button1.Text = "URADI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PolozeniIspiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.lblpk);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dolbl);
            this.Controls.Add(this.odlbl);
            this.Controls.Add(this.nazadbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PolozeniIspiti";
            this.Text = "Polozeni Ispiti";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nazadbtn;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Label lblpk;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dolbl;
        private System.Windows.Forms.Label odlbl;
        private System.Windows.Forms.Button button1;
    }
}