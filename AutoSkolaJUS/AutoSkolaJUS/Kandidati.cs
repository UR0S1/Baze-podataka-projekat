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
    public partial class Kandidati : Form
    {
        public Kandidati()
        {
            InitializeComponent();
        }

        private void izlaz_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void promeni_Click(object sender, EventArgs e)
        {
            PromeniKandidati form = new PromeniKandidati();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
