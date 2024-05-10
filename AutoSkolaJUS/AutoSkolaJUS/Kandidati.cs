using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutoSkolaJUS
{
    public partial class Kandidati : Form
    {

        DataTable dt = new DataTable();

        public Kandidati()
        {
            InitializeComponent();
        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unetoSve()
        {

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            KandidatCLass kandidat = new KandidatCLass();
            kandidat.Ime = ime.Text;
            kandidat.Prezime = prezime.Text;
            kandidat.JMBG = jmbg.Text;
            kandidat.Adresa = adresa.Text;
            //kandidat.InstruktorID =

        }

        private void promeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();


            SqlCommand komanda = new SqlCommand("UPDATE Kandidati " +
                                                "SET ime=" + ime.Text + ", prezime=" + prezime.Text + ", adresa=" + adresa.Text +
                                                "WHERE jmbg=" + jmbg.Text + ";", veza);
            komanda.ExecuteNonQuery();

            if (teorija.Checked)
            {
                SqlCommand komanda1 = new SqlCommand("UPDATE Kandidati SET teorija=1 WHERE jmbg=" + jmbg.Text + ";", veza);
                komanda1.ExecuteNonQuery();
            }
            if (prvapomoc.Checked)
            {
                SqlCommand komanda2 = new SqlCommand("UPDATE Kandidati SET prva_pomoc=1 WHERE jmbg=" + jmbg.Text + ";", veza);
                komanda2.ExecuteNonQuery();
            }
            if (voznja.Checked)
            {
                SqlCommand komanda3 = new SqlCommand("UPDATE Kandidati SET voznja=1 WHERE jmbg=" + jmbg.Text + ";", veza);
                komanda3.ExecuteNonQuery();
            }

            veza.Close();
        }

        private void izbrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();

            SqlCommand komanda = new SqlCommand("DELETE FROM Kandidati" +
                                                "WHERE JMBG=" + jmbg.Text + ";", veza);
            komanda.ExecuteNonQuery();
            veza.Close();

            osveziTable();
        }

        private void osveziTable()
        {
            dt.Clear();
            string kom = "SELECT * FROM Kandidati";
            KonekcijaSBazom.UcitajTabelu(kom, ref dt);
            dataKandidata.DataSource = dt;
        }
    }
}
