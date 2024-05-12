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
    public partial class Radnici : Form
    {
        public Radnici()
        {
            InitializeComponent();
        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void promeni_Click(object sender, EventArgs e)
        {
            PromeniRadnici form = new PromeniRadnici();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
