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
    public partial class Polaganja : Form
    {
        DataTable dt = new DataTable();

        int selectedSifra = 0;
        int selectedVrsta = 0;
        string selectedKandidat = string.Empty;
        string selectedKategorija = string.Empty;
        DateTime selectedDatum = new DateTime(1900,1,1); //probala sam da ga stavim da radimo sa DateTime, ako ne pije vodu menjajte
        bool selectedPolozio = false; //nisam sigurna da li je ovo skroz dobro implementirano, testirajte pa probate

        public Polaganja()
        {
            InitializeComponent();
            promeni.Enabled = false;
            izbrisi.Enabled = false;
            dodajVrstu();
            dodajKandidate();
            osveziTable();
        }

        private void dodajVrstu()
        {
            string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT id FROM Vrste_polaganja", conn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            vrsta_polaganja.Items.Add(dr.GetInt32(0));
                        }

                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                errorMessage(ex);
            }
        }

        private void dodajKandidate()
        {
            if (vrsta_polaganja.SelectedIndex == -1) { return; }
            string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if ((int)vrsta_polaganja.SelectedIndex == 1)
                    {
                        using (SqlCommand cmd = new SqlCommand($"SELECT JMBG FROM Kandidati WHERE teorija = 1 AND prva_pomoc = 1", conn)) //OPET ISTO ZA QUERY, PROVERITI I PROMENITI AKO TREBA
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                kandidat.Items.Add(dr.GetString(0));
                            }

                        }
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand($"SELECT JMBG FROM Kandidati WHERE teorija = 0", conn)) //OPET ISTO ZA QUERY, PROVERITI I PROMENITI AKO TREBA
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                kandidat.Items.Add(dr.GetString(0));
                            }

                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                errorMessage(ex);
            }
        }
        private void errorMessage(Exception ex)
        {
            string message = "Došlo je do greške. ";
            string title = "Error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBox.Show(message + ex, title, buttons, icon);

        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool poljePrazno()
        {
            return vrsta_polaganja.SelectedItem == null || kandidat.SelectedItem == null || datum.Checked == false;
        }



        private void promeni_Click(object sender, EventArgs e)
        {
            pokupiPodatkeIzReda();
            PromeniPolaganja promeni = new PromeniPolaganja();
            promeni.primiPodatke(selectedSifra, selectedVrsta, selectedKandidat, selectedDatum, selectedPolozio);
            promeni.ShowDialog();
            promeni.Dispose();
            osveziTable();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (poljePrazno())
            {
                MessageBox.Show("Molimo Vas popunite prazna polja");
                return;
            }

            PolaganjeClass polaganje = new PolaganjeClass();
            polaganje.Vrsta = Convert.ToInt32(vrsta_polaganja.SelectedItem);
            polaganje.Kandidat = kandidat.SelectedItem.ToString();
            polaganje.Datum = datum.Value; //NE ZNAM DA LI OVO RADI, TESTIRAJTE!


            //PROVERITI DA LI JE OVO DOBRA IMPLEMENTACIJA od bool Polozio
            if(polozioda.Checked)
            {
                polaganje.Polozio = true;
            }
            else
            {
                polaganje.Polozio = false;
            }


            polaganje.Insert();
            osveziTable();
            ocistiPolja();
            vrsta_polaganja.Focus();
        }

        private void ocistiPolja()
        {
            vrsta_polaganja.SelectedItem = null;
            kandidat.SelectedItem = null;
            datum.Checked = false;
            polozioda.Checked = false;
            polozione.Checked = false;
        }

        private void pokupiPodatkeIzReda()
        {
            DataGridViewRow selectedRow = dataPolaganja.SelectedRows[0];

            selectedSifra = Convert.ToInt32(selectedRow.Cells[0].Value);
            selectedVrsta = Convert.ToInt32(selectedRow.Cells[1].Value);
            selectedKandidat = selectedRow.Cells[2].Value.ToString();
            selectedDatum = DateTime.Parse(selectedRow.Cells[3].Value.ToString()); //POKUSAJ CONVERTOVANJA U DATETIME FORMAT(capila kod sa StackOverFlow, TESTIRATI!)
            //nmp dal ovo za bitValue treba ovako, ako ne radi, menjajte:
            int bitValue = Convert.ToInt32(selectedRow.Cells[4].Value);
            selectedPolozio = bitValue == 1;
        }

        private void izbrisi_Click(object sender, EventArgs e)
        {
            pokupiPodatkeIzReda();
            PolaganjeClass polaganje = new PolaganjeClass();
            polaganje.Sifra = selectedSifra; //ne znam da li ovo radi ˙◠˙
            polaganje.Delete();
            osveziTable();
        }

        private void osveziTable()
        {
            dt.Clear();
            string kom = "SELECT id_polaganja, vrsta_polaganja, kandidat, datum, polozen FROM Polaganje";
            KonekcijaSBazom.UcitajTabelu(kom, ref dt);
            dataPolaganja.DataSource = dt;
        }

        private void dataPolaganja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            promeni.Enabled = true;
            izbrisi.Enabled = true;
            pokupiPodatkeIzReda();
        }

        private void vrsta_polaganja_SelectedIndexChanged(object sender, EventArgs e)
        {
            kandidat.Items.Clear();
            dodajKandidate();
        }
    }
}
