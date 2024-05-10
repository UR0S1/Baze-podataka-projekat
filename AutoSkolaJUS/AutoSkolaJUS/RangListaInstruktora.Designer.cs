namespace AutoSkolaJUS
{
    partial class RangListaInstruktora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangListaInstruktora));
            this.nazad = new System.Windows.Forms.Button();
            this.lblpk = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.odlbl = new System.Windows.Forms.Label();
            this.tipPolaganja = new System.Windows.Forms.Label();
            this.cbtipPolaganja = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.nazad.TabIndex = 62;
            this.nazad.Text = "NAZAD";
            this.nazad.UseVisualStyleBackColor = false;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // lblpk
            // 
            this.lblpk.AutoSize = true;
            this.lblpk.BackColor = System.Drawing.Color.Transparent;
            this.lblpk.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpk.Location = new System.Drawing.Point(19, 12);
            this.lblpk.Name = "lblpk";
            this.lblpk.Size = new System.Drawing.Size(339, 38);
            this.lblpk.TabIndex = 61;
            this.lblpk.Text = "Kandidati koji nisu položili:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(537, 239);
            this.dataGridView1.TabIndex = 58;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "Mart",
            "April",
            "Maj",
            "Jun",
            "Jul",
            "Avgust",
            "Septembar",
            "Oktobar",
            "Novembar",
            "Decembar"});
            this.comboBox1.Location = new System.Drawing.Point(97, 75);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 64;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // odlbl
            // 
            this.odlbl.AutoSize = true;
            this.odlbl.BackColor = System.Drawing.Color.Transparent;
            this.odlbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.odlbl.Location = new System.Drawing.Point(23, 75);
            this.odlbl.Name = "odlbl";
            this.odlbl.Size = new System.Drawing.Size(52, 19);
            this.odlbl.TabIndex = 63;
            this.odlbl.Text = "Mesec:";
            // 
            // tipPolaganja
            // 
            this.tipPolaganja.AutoSize = true;
            this.tipPolaganja.BackColor = System.Drawing.Color.Transparent;
            this.tipPolaganja.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipPolaganja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tipPolaganja.Location = new System.Drawing.Point(286, 75);
            this.tipPolaganja.Name = "tipPolaganja";
            this.tipPolaganja.Size = new System.Drawing.Size(95, 19);
            this.tipPolaganja.TabIndex = 65;
            this.tipPolaganja.Text = "Tip polaganja:";
            // 
            // cbtipPolaganja
            // 
            this.cbtipPolaganja.BackColor = System.Drawing.Color.PeachPuff;
            this.cbtipPolaganja.FormattingEnabled = true;
            this.cbtipPolaganja.Location = new System.Drawing.Point(400, 75);
            this.cbtipPolaganja.Margin = new System.Windows.Forms.Padding(2);
            this.cbtipPolaganja.Name = "cbtipPolaganja";
            this.cbtipPolaganja.Size = new System.Drawing.Size(108, 21);
            this.cbtipPolaganja.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(551, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 43);
            this.button1.TabIndex = 67;
            this.button1.Text = "URADI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RangListaInstruktora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbtipPolaganja);
            this.Controls.Add(this.tipPolaganja);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.odlbl);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.lblpk);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RangListaInstruktora";
            this.Text = "RangListaInstruktora";
            this.Load += new System.EventHandler(this.RangListaInstruktora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Label lblpk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label odlbl;
        private System.Windows.Forms.Label tipPolaganja;
        private System.Windows.Forms.ComboBox cbtipPolaganja;
        private System.Windows.Forms.Button button1;
    }
}