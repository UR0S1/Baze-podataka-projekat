namespace AutoSkolaJUS
{
    partial class PolozeniIspitiPoInstruktoru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolozeniIspitiPoInstruktoru));
            this.nazadbtn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.imeinstlbl = new System.Windows.Forms.Label();
            this.lblpk = new System.Windows.Forms.Label();
            this.nazad = new System.Windows.Forms.Button();
            this.dateDO = new System.Windows.Forms.DateTimePicker();
            this.dateOD = new System.Windows.Forms.DateTimePicker();
            this.dolbl = new System.Windows.Forms.Label();
            this.odlbl = new System.Windows.Forms.Label();
            this.osvezi = new System.Windows.Forms.Button();
            this.instruktor = new System.Windows.Forms.ComboBox();
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
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(13, 222);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 62;
            this.dataGrid.Size = new System.Drawing.Size(805, 309);
            this.dataGrid.TabIndex = 6;
            // 
            // imeinstlbl
            // 
            this.imeinstlbl.AutoSize = true;
            this.imeinstlbl.BackColor = System.Drawing.Color.Transparent;
            this.imeinstlbl.Font = new System.Drawing.Font("Tw Cen MT", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeinstlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imeinstlbl.Location = new System.Drawing.Point(18, 98);
            this.imeinstlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imeinstlbl.Name = "imeinstlbl";
            this.imeinstlbl.Size = new System.Drawing.Size(178, 33);
            this.imeinstlbl.TabIndex = 8;
            this.imeinstlbl.Text = "Ime instruktora:";
            // 
            // lblpk
            // 
            this.lblpk.AutoSize = true;
            this.lblpk.BackColor = System.Drawing.Color.Transparent;
            this.lblpk.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpk.Location = new System.Drawing.Point(15, 27);
            this.lblpk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpk.Name = "lblpk";
            this.lblpk.Size = new System.Drawing.Size(669, 51);
            this.lblpk.TabIndex = 52;
            this.lblpk.Text = "Prikaz položenih ispita po instruktoru:";
            // 
            // nazad
            // 
            this.nazad.BackColor = System.Drawing.Color.LightSlateGray;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nazad.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazad.Location = new System.Drawing.Point(825, 465);
            this.nazad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(94, 66);
            this.nazad.TabIndex = 53;
            this.nazad.Text = "NAZAD";
            this.nazad.UseVisualStyleBackColor = false;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // dateDO
            // 
            this.dateDO.Location = new System.Drawing.Point(574, 168);
            this.dateDO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateDO.Name = "dateDO";
            this.dateDO.Size = new System.Drawing.Size(244, 26);
            this.dateDO.TabIndex = 57;
            // 
            // dateOD
            // 
            this.dateOD.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.dateOD.CalendarTitleBackColor = System.Drawing.Color.Chocolate;
            this.dateOD.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.dateOD.Location = new System.Drawing.Point(131, 166);
            this.dateOD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateOD.Name = "dateOD";
            this.dateOD.Size = new System.Drawing.Size(244, 26);
            this.dateOD.TabIndex = 56;
            // 
            // dolbl
            // 
            this.dolbl.AutoSize = true;
            this.dolbl.BackColor = System.Drawing.Color.Transparent;
            this.dolbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dolbl.Location = new System.Drawing.Point(465, 166);
            this.dolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dolbl.Name = "dolbl";
            this.dolbl.Size = new System.Drawing.Size(49, 28);
            this.dolbl.TabIndex = 55;
            this.dolbl.Text = "DO:";
            // 
            // odlbl
            // 
            this.odlbl.AutoSize = true;
            this.odlbl.BackColor = System.Drawing.Color.Transparent;
            this.odlbl.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.odlbl.Location = new System.Drawing.Point(22, 166);
            this.odlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.odlbl.Name = "odlbl";
            this.odlbl.Size = new System.Drawing.Size(49, 28);
            this.odlbl.TabIndex = 54;
            this.odlbl.Text = "OD:";
            // 
            // osvezi
            // 
            this.osvezi.BackColor = System.Drawing.Color.LightSlateGray;
            this.osvezi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.osvezi.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osvezi.Location = new System.Drawing.Point(825, 391);
            this.osvezi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.osvezi.Name = "osvezi";
            this.osvezi.Size = new System.Drawing.Size(94, 66);
            this.osvezi.TabIndex = 66;
            this.osvezi.Text = "OSVEŽI";
            this.osvezi.UseVisualStyleBackColor = false;
            // 
            // instruktor
            // 
            this.instruktor.BackColor = System.Drawing.Color.PeachPuff;
            this.instruktor.FormattingEnabled = true;
            this.instruktor.Location = new System.Drawing.Point(241, 103);
            this.instruktor.Name = "instruktor";
            this.instruktor.Size = new System.Drawing.Size(214, 28);
            this.instruktor.TabIndex = 78;
            // 
            // PolozeniIspitiPoInstruktoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSkolaJUS.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 548);
            this.Controls.Add(this.instruktor);
            this.Controls.Add(this.osvezi);
            this.Controls.Add(this.dateDO);
            this.Controls.Add(this.dateOD);
            this.Controls.Add(this.dolbl);
            this.Controls.Add(this.odlbl);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.lblpk);
            this.Controls.Add(this.imeinstlbl);
            this.Controls.Add(this.nazadbtn);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PolozeniIspitiPoInstruktoru";
            this.Text = "Položeni ispiti po instruktoru";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nazadbtn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label imeinstlbl;
        private System.Windows.Forms.Label lblpk;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.DateTimePicker dateDO;
        private System.Windows.Forms.DateTimePicker dateOD;
        private System.Windows.Forms.Label dolbl;
        private System.Windows.Forms.Label odlbl;
        private System.Windows.Forms.Button osvezi;
        private System.Windows.Forms.ComboBox instruktor;
    }
}