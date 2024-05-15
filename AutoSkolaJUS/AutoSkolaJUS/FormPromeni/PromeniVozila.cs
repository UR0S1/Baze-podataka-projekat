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

        public void primiPodatke(int ssifra, string skategorija, string sbrend, string smodel)
        {
            sifra_vozila.Text = ssifra.ToString(); //ssifra je int a ovo je text pa sam ga roknula u string
            kategorija.SelectedItem = skategorija;
            brend.Text = sbrend;
            model.Text = smodel;
        }

        private bool poljePrazno()
        {
            return sifra_vozila.Text == string.Empty || brend.Text == string.Empty || model.Text == string.Empty; ;
        }

        private void promeni_Click(object sender, EventArgs e)
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

            vozilo.Update();
            this.Close();
        }
    }
}
