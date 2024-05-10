namespace AutoSkolaJUS
{
    partial class ProcentniPrikazPoInstruktoru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcentniPrikazPoInstruktoru));
            this.nazadbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.instlbl = new System.Windows.Forms.Label();
            this.lblpk = new System.Windows.Forms.Label();
            this.nazad = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dolbl = new System.Windows.Forms.Label();
            this.odlbl = new System.Windows.Forms.Label();
            this.instruktor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(537, 201);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // instlbl
            // 
            this.instlbl.AutoSize = true;
            this.instlbl.BackColor = System.Drawing.Color.Transparent;
            this.instlbl.Font = new System.Drawing.Font("Tw Cen MT", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.instlbl.Location = new System.Drawing.Point(12, 68);
            this.instlbl.Name = "instlbl";
            this.instlbl.Size = new System.Drawing.Size(80, 22);
            this.instlbl.TabIndex = 8;
            this.instlbl.Text = "Instruktor:";
            // 
            // lblpk
            // 
            this.lblpk.AutoSize = true;
            this.lblpk.BackColor = System.Drawing.Color.Transparent;
            this.lblpk.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpk.Location = new System.Drawing.Point(1, 12);
            this.lblpk.Name = "lblpk";
            this.lblpk.Size = new System.Drawing.Size(563, 35);
            this.lblpk.TabIndex = 52;
            this.lblpk.Text = "Procentni prikaz položenih ispita po instruktoru:";
            // 
            // nazad
            // 
            this.nazad.BackColor = System.Drawing.Color.LightSlateGray;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nazad.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazad.Location = new System.Drawing.Point(550, 302);
            this.nazad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(63, 43);
            this.nazad.TabIndex = 53;
            this.nazad.Text = "NAZAD";
            this.nazad.UseVisualStyleBackColor = false;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(383, 109);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker2.TabIndex = 57;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Chocolate;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 56;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dolbl
            // 
            this.dolbl.AutoSize = true;
            this.dolbl.BackColor = System.Drawing.Color.Transparent;
            this.dolbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dolbl.Location = new System.Drawing.Point(310, 108);
            this.dolbl.Name = "dolbl";
            this.dolbl.Size = new System.Drawing.Size(33, 19);
            this.dolbl.TabIndex = 55;
            this.dolbl.Text = "DO:";
            // 
            // odlbl
            // 
            this.odlbl.AutoSize = true;
            this.odlbl.BackColor = System.Drawing.Color.Transparent;
            this.odlbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.odlbl.Location = new System.Drawing.Point(15, 108);
            this.odlbl.Name = "odlbl";
            this.odlbl.Size = new System.Drawing.Size(33, 19);
            this.odlbl.TabIndex = 54;
            this.odlbl.Text = "OD:";
            // 
            // instruktor
            // 
            this.instruktor.BackColor = System.Drawing.Color.PeachPuff;
            this.instruktor.FormattingEnabled = true;
            this.instruktor.Location = new System.Drawing.Point(134, 69);
            this.instruktor.Name = "instruktor";
            this.instruktor.Size = new System.Drawing.Size(144, 21);
            this.instruktor.TabIndex = 58;
            this.instruktor.SelectedIndexChanged += new System.EventHandler(this.instruktor_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(551, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 43);
            this.button1.TabIndex = 68;
            this.button1.Text = "URADI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProcentniPrikazPoInstruktoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.instruktor);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dolbl);
            this.Controls.Add(this.odlbl);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.lblpk);
            this.Controls.Add(this.instlbl);
            this.Controls.Add(this.nazadbtn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcentniPrikazPoInstruktoru";
            this.Text = "Procentni Prikaz Po Instruktoru";
            this.Load += new System.EventHandler(this.ProcentniPrikazPoInstruktoru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nazadbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label instlbl;
        private System.Windows.Forms.Label lblpk;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dolbl;
        private System.Windows.Forms.Label odlbl;
        private System.Windows.Forms.ComboBox instruktor;
        private System.Windows.Forms.Button button1;
    }
}