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
    public partial class Polaganja : Form
    {
        public Polaganja()
        {
            InitializeComponent();
        }

        private void izlaz_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Polaganja_Load(object sender, EventArgs e)
        {

        }

        private void promeni_Click(object sender, EventArgs e)
        {
            PromeniPolaganja form = new PromeniPolaganja();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
