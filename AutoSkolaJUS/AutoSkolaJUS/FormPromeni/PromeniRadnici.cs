using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkolaJUS
{
    public partial class PromeniRadnici : Form
    {
        public int prvoVozilo { get; set; }
        public int id { get; set; }
        public PromeniRadnici()
        {
            InitializeComponent();
            dodajVozila();
            dodajPozicije();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void primiPodatke(int sid,string sime, string sprezime, string sjmbg, string sadresa, int spozicija)
        {
            id = sid;
            ime.Text= sime;
            prezime.Text = sprezime;
            jmbg.Text = sjmbg;
            adresa.Text = sadresa;
            pozicija.SelectedItem = spozicija;
            
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
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT id_vozila\r\nFROM Duzi INNER JOIN Vozila ON Duzi.vozilo = Vozila.id_vozila\r\nWHERE CAST(GETDATE() AS DATE) NOT BETWEEN datum_zaduzenja AND ISNULL(datum_razduzenja, DATEADD(DAY, 1, GETDATE()));", conn)) //popraviti query i kod za vozilo
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

        private bool poljePrazno()
        {
            return ime.Text == string.Empty || prezime.Text == string.Empty || jmbg.Text.Length != 13 || adresa.Text == string.Empty;
        }

        private void promeni_Click(object sender, EventArgs e)
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

            radnik.Update();
            int novoVozilo = (int)vozilo.SelectedItem;
            if(novoVozilo != prvoVozilo)
            {
                
                string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(
                            "UPDATE Duzi " +
                            "SET datum_razduzenja = CAST(GETDATE() AS DATE) " +
                            "WHERE id_vozila = @Sifra AND id_radnika = @Id AND datum_razduzenja IS NULL", connection))
                        {
                            cmd.Parameters.AddWithValue("@Sifra", prvoVozilo);
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    errorMessage(ex);
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(
                            "INSERT INTO Duzi (id_vozila, id_radnika, datum_zaduzenja) " +
                            "VALUES (@Sifra, @Radnik, (GETDATE() AS DATE)", connection))
                        {
                            cmd.Parameters.AddWithValue("@Sifra", novoVozilo);
                            cmd.Parameters.AddWithValue("@Radnik", id);
                        

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            
                catch (Exception ex)
                {
                    errorMessage(ex);
                }
            }

            this.Close();
        }

    }
}
