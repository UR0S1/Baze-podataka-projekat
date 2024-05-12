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
    public partial class PromeniKandidati : Form
    {
        public PromeniKandidati()
        {
            InitializeComponent();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
