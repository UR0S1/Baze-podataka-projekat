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

        private void polaganjaKandidataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PolaganjaKandidata form = new PolaganjaKandidata();
            form.ShowDialog();
            form.Dispose();
        }

        private void polozeniIspitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PolozeniIspiti form = new PolozeniIspiti();
            form.ShowDialog();
            form.Dispose();
        }

        private void procentniPrikazIspitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcentniPrikazIspita form = new ProcentniPrikazIspita();
            form.ShowDialog();
            form.Dispose();
        }

        private void procentniPrikazPoRadnikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcentniPrikazPoInstruktoru form = new ProcentniPrikazPoInstruktoru();
            form.ShowDialog();
            form.Dispose();
        }

        private void rangListaInstruktoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RangListaInstruktora form = new RangListaInstruktora();
            form.ShowDialog();
            form.Dispose();
        }

        private void kandidatiKojiSuPaliPolaganjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KandidatiKojiNisuPolozili form = new KandidatiKojiNisuPolozili();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
