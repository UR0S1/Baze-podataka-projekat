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
    public partial class Vozila : Form
    {
        DataTable dt = new DataTable();

        int selectedSifra = 0;
        string selectedKategorija = string.Empty;
        string selectedBrend = string.Empty;
        string selectedModel = string.Empty;

        public Vozila()
        {
            InitializeComponent();
            promeni.Enabled = false;
            izbrisi.Enabled = false;
            osveziTable();
        }

        private void izlaz_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool poljePrazno()
        {
            return sifra_vozila.Text == string.Empty || kategorija.SelectedItem == null || brend.Text == string.Empty || model.Text == string.Empty;
        }

        private void ocistiPolja()
        {
            sifra_vozila.Text = string.Empty;
            brend.Text = string.Empty;
            model.Text = string.Empty;
            kategorija.SelectedItem = null;

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (poljePrazno())
            {
                MessageBox.Show("Molimo Vas popunite prazna polja");
                return;
            }

            VoziloClass vozilo = new VoziloClass();
            vozilo.Sifra = Convert.ToInt32(sifra_vozila.Text);
            vozilo.Brend = brend.Text;
            vozilo.Model = model.Text;
            vozilo.Kategorija = kategorija.Text;

            vozilo.Insert();
            osveziTable();
            ocistiPolja();
            sifra_vozila.Focus();
        }

        private void pokupiPodatkeIzReda()
        {
            DataGridViewRow selectedRow = dataVozila.SelectedRows[0];

            selectedSifra = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            selectedKategorija = selectedRow.Cells[1].Value.ToString();
            selectedBrend = selectedRow.Cells[2].Value.ToString();
            selectedModel = selectedRow.Cells[3].Value.ToString();
        }

        private void promeni_Click(object sender, EventArgs e)
        {
            pokupiPodatkeIzReda();
            PromeniVozila promeni = new PromeniVozila();
            promeni.primiPodatke(selectedSifra, selectedKategorija, selectedBrend, selectedModel);
            promeni.ShowDialog();
            promeni.Dispose();
            osveziTable();
        }

        private void izbrisi_Click(object sender, EventArgs e)
        {
            pokupiPodatkeIzReda();
            VoziloClass vozilo = new VoziloClass();
            vozilo.Sifra = selectedSifra;
            vozilo.Delete();
            osveziTable();
        }

        private void osveziTable()
        {
            dt.Clear();
            string kom = "SELECT id_vozila, kategorija, brend, model FROM Vozila";
            KonekcijaSBazom.UcitajTabelu(kom, ref dt);
            dataVozila.DataSource = dt;
        }

        private void dataVozila_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            promeni.Enabled = true;
            izbrisi.Enabled = true;
            pokupiPodatkeIzReda();
        }
    }
}
