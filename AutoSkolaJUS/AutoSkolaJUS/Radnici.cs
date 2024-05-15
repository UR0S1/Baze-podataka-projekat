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
    public partial class Radnici : Form
    {
        DataTable dt = new DataTable();

        int selectedId = 0;
        string selectedIme = string.Empty;
        string selectedPrezime = string.Empty;
        string selectedJMGB = string.Empty;
        string selectedAdresa = string.Empty;
        int selectedPozicija = 0;
        int selectedVozilo = 0;

        public Radnici()
        {
            InitializeComponent();
            promeni.Enabled = false;
            izbrisi.Enabled = false;
            osveziTable();
            dodajPozicije();
            dodajVozila();
        }

        private void dodajPozicije()
        {
            string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT id_pozicije FROM Tip_radnika", conn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            pozicija.Items.Add(dr.GetInt32(0));
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

        private void dodajVozila()
        {
            string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT id_vozila\r\nFROM Duzi INNER JOIN Vozila ON Duzi.vozilo = Vozila.id_vozila\r\nWHERE CAST(GETDATE() AS DATE) NOT BETWEEN datum_zaduzenja AND ISNULL(datum_razduzenja, DATEADD(DAY, 1, GETDATE()));", conn))   //popraviti query i kod za vozilo
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            vozilo.Items.Add(dr.GetInt32(0));
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

        private void osveziTable()
        {
            dt.Clear();
            string kom = "SELECT id_radnika, ime, prezime, JMBG, adresa, pozicija FROM Radnici";
            KonekcijaSBazom.UcitajTabelu(kom, ref dt);
            dataRadnika.DataSource = dt;
        }

        private bool poljePrazno()
        {
            return ime.Text == string.Empty || prezime.Text == string.Empty || jmbg.Text.Length != 13 || adresa.Text == string.Empty;
        }

        private void ocistiPolja()
        {
            ime.Text = string.Empty;
            prezime.Text = string.Empty;
            adresa.Text = string.Empty;
            jmbg.Text = string.Empty;
            pozicija.SelectedItem = null;
            vozilo.SelectedItem = null;

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (poljePrazno())
            {
                MessageBox.Show("Molimo Vas popunite prazna polja");
                return;
            }


            RadnikClass radnik = new RadnikClass();
            radnik.Ime = ime.Text;
            radnik.Prezime = prezime.Text;
            radnik.JMBG = jmbg.Text;
            radnik.Adresa = adresa.Text;
            radnik.Pozicija = Convert.ToInt32(pozicija.SelectedItem);

            radnik.Insert();
            osveziTable();
            ocistiPolja();
            ime.Focus();


            int novi_id = 0;
            if(vozilo.SelectedItem != null)
            {
                string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT MAX(id_radnika) FROM Radnici", conn))
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            dr.Read();
                            novi_id = dr.GetInt32(0);

                        }
                        conn.Close();
                    }
                }
                catch(Exception ex)
                {
                    errorMessage(ex);
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Duzi (vozilo, radnik, datum_zaduzenja) VALUES (@Vozilo, @Radnik, @Datum)", conn))   //popraviti query i kod za vozilo
                        {
                            cmd.Parameters.AddWithValue("@Vozilo", vozilo.SelectedItem);
                            cmd.Parameters.AddWithValue("@Radnik", novi_id);
                            cmd.Parameters.AddWithValue("@Datum", DateTime.Now);

                        }
                        conn.Close();
                    }

                }
                catch (Exception ex)
                {
                    errorMessage(ex);
                }
            }
        }

        private void pokupiPodatkeIzReda()
        {
            DataGridViewRow selectedRow = dataRadnika.SelectedRows[0];
            selectedId = Convert.ToInt32(selectedRow.Cells[0].Value);
            selectedIme = selectedRow.Cells[1].Value.ToString();
            selectedPrezime = selectedRow.Cells[2].Value.ToString();
            selectedJMGB = selectedRow.Cells[3].Value.ToString();
            selectedAdresa = selectedRow.Cells[4].Value.ToString();
            selectedPozicija = Convert.ToInt32(selectedRow.Cells[5].Value);

        }

        private void promeni_Click(object sender, EventArgs e)
        {
            pokupiPodatkeIzReda();
            PromeniRadnici promeni = new PromeniRadnici();
            promeni.primiPodatke(selectedId ,selectedIme, selectedPrezime, selectedJMGB, selectedAdresa, selectedPozicija);
            promeni.ShowDialog();
            promeni.Dispose();
            osveziTable();
        }

        private void izbrisi_Click(object sender, EventArgs e)
        {
            pokupiPodatkeIzReda();
            RadnikClass radnik = new RadnikClass();
            radnik.JMBG = selectedJMGB;
            radnik.Delete();
            osveziTable();
        }

        private void jmbg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void dataRadnika_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            promeni.Enabled = true;
            izbrisi.Enabled = true;
            pokupiPodatkeIzReda();
        }

    }
}
