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
            this.nazadbtn = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.lblpk = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.tiplbl = new System.Windows.Forms.Label();
            this.vrsta_polaganja = new System.Windows.Forms.ComboBox();
            this.osvezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nazadbtn
            // 
            this.nazadbtn.Location = new System.Drawing.Point(1062, 563);
            this.nazadbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nazadbtn.Name = "nazadbtn";
            this.nazadbtn.Size = new System.Drawing.Size(100, 94);
            this.nazadbtn.TabIndex = 7;
            this.nazadbtn.Text = "NAZAD";
            this.nazadbtn.UseVisualStyleBackColor = true;
            // 
            // nazad
            // 
            this.nazad.BackColor = System.Drawing.Color.LightSlateGray;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nazad.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazad.Location = new System.Drawing.Point(825, 468);
            this.nazad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(94, 66);
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
            this.lblpk.Location = new System.Drawing.Point(11, 32);
            this.lblpk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpk.Name = "lblpk";
            this.lblpk.Size = new System.Drawing.Size(573, 61);
            this.lblpk.TabIndex = 51;
            this.lblpk.Text = "Kandidati koji nisu položili:";
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(13, 182);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 62;
            this.dataGrid.Size = new System.Drawing.Size(805, 352);
            this.dataGrid.TabIndex = 50;
            // 
            // tiplbl
            // 
            this.tiplbl.AutoSize = true;
            this.tiplbl.BackColor = System.Drawing.Color.Transparent;
            this.tiplbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiplbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tiplbl.Location = new System.Drawing.Point(17, 126);
            this.tiplbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tiplbl.Name = "tiplbl";
            this.tiplbl.Size = new System.Drawing.Size(99, 28);
            this.tiplbl.TabIndex = 46;
            this.tiplbl.Text = "Tip ispita:";
            // 
            // vrsta_polaganja
            // 
            this.vrsta_polaganja.BackColor = System.Drawing.Color.PeachPuff;
            this.vrsta_polaganja.FormattingEnabled = true;
            this.vrsta_polaganja.Items.AddRange(new object[] {
            "teorija",
            "prva pomoć",
            "vožnja"});
            this.vrsta_polaganja.Location = new System.Drawing.Point(154, 126);
            this.vrsta_polaganja.Name = "vrsta_polaganja";
            this.vrsta_polaganja.Size = new System.Drawing.Size(160, 28);
            this.vrsta_polaganja.TabIndex = 53;
            // 
            // osvezi
            // 
            this.osvezi.BackColor = System.Drawing.Color.LightSlateGray;
            this.osvezi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.osvezi.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osvezi.Location = new System.Drawing.Point(825, 394);
            this.osvezi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.osvezi.Name = "osvezi";
            this.osvezi.Size = new System.Drawing.Size(94, 66);
            this.osvezi.TabIndex = 76;
            this.osvezi.Text = "OSVEŽI";
            this.osvezi.UseVisualStyleBackColor = false;
            // 
            // KandidatiKojiNisuPolozili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 548);
            this.Controls.Add(this.osvezi);
            this.Controls.Add(this.vrsta_polaganja);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.lblpk);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.tiplbl);
            this.Controls.Add(this.nazadbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KandidatiKojiNisuPolozili";
            this.Text = "Kandidati koji nisu položili";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nazadbtn;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Label lblpk;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label tiplbl;
        private System.Windows.Forms.ComboBox vrsta_polaganja;
        private System.Windows.Forms.Button osvezi;
    }
}