using System;
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
    public partial class PromeniVozila : Form
    {
        public PromeniVozila()
        {
            InitializeComponent();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
