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
    public partial class AutoSkola : Form
    {
        public AutoSkola()
        {
            InitializeComponent();
        }

        private void radniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Radnici form = new Radnici();
            form.ShowDialog();
            form.Dispose();
        }

        private void kandidatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kandidati form = new Kandidati();
            form.ShowDialog();
            form.Dispose();
        }

        private void vozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vozila form = new Vozila();
            form.ShowDialog();
            form.Dispose();
        }

        private void polaganjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Polaganja form = new Polaganja();
            form.ShowDialog();
            form.Dispose();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stanjeKandidata_Click(object sender, EventArgs e)
        {
            StanjeKandidata form = new StanjeKandidata();
            form.ShowDialog();
            form.Dispose();
        }

        private void polozeniIspitiPoMesecu_Click(object sender, EventArgs e)
        {
            PolozeniIspitiPoMesecu form = new PolozeniIspitiPoMesecu();
            form.ShowDialog();
            form.Dispose();
        }

        private void polozeniIspitiPoInstruktoru_Click(object sender, EventArgs e)
        {
            PolozeniIspitiPoInstruktoru form = new PolozeniIspitiPoInstruktoru();
            form.ShowDialog();
            form.Dispose();
        }

        private void kandidatiKojiNisuPolozili_Click(object sender, EventArgs e)
        {
            KandidatiKojiNisuPolozili form = new KandidatiKojiNisuPolozili();
            form.ShowDialog();
            form.Dispose();
        }

        private void rangListaInstruktora_Click(object sender, EventArgs e)
        {
            RangListaInstruktora form = new RangListaInstruktora();
            form.ShowDialog();
            form.Dispose();
        }

        private void Duzi_Click(object sender, EventArgs e)
        {
            Duzi form = new Duzi();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
