﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkolaJUS
{
    public partial class PromeniPolaganja : Form
    {
        public PromeniPolaganja()
        {
            InitializeComponent();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
