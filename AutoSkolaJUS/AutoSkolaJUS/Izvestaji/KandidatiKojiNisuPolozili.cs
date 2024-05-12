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
    public partial class KandidatiKojiNisuPolozili : Form
    {
        public KandidatiKojiNisuPolozili()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
