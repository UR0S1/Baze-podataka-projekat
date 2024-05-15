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
    public partial class PromeniPolaganja : Form
    {
        public int sifra { get; set; }
        public PromeniPolaganja()
        {
            InitializeComponent();
            dodajVrstu();
            dodajKandidate();
        }

        public void primiPodatke(int ssifra, int svrsta, string skandidat, DateTime sdatum, bool spolozio)
        {
            sifra = ssifra;
            vrsta_polaganja.SelectedItem = svrsta;
            kandidat.Items.Add(skandidat);
            kandidat.SelectedItem = skandidat;
            datum.Value = sdatum;
            polozioda.Checked = spolozio;

        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private bool poljePrazno()
        {
            return vrsta_polaganja.SelectedItem == null || kandidat.SelectedItem == null || kandidat.SelectedItem == null || datum.Checked == false;
        }

        private void promeni_Click(object sender, EventArgs e)
        {
            if (poljePrazno())
            {
                MessageBox.Show("Molim vas popunite prazna polja");
                return;
            }

            PolaganjeClass polaganje = new PolaganjeClass();
            polaganje.Vrsta = Convert.ToInt32(vrsta_polaganja.SelectedItem);
            polaganje.Kandidat = kandidat.SelectedItem.ToString();
            polaganje.Datum = datum.Value;

            if (polozioda.Checked)
            {
                polaganje.Polozio = true;
            }
            else
            {
                polaganje.Polozio = false;
            }

            polaganje.Update();
            this.Close();
        }

        private void vrsta_polaganja_SelectedIndexChanged(object sender, EventArgs e)
        {
            kandidat.Items.Clear();
            dodajKandidate();
        }
    }
}
