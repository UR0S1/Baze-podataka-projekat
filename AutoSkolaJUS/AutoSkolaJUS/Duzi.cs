using AutoSkolaJUS.FormPromeni;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AutoSkolaJUS
{
    public partial class Duzi : Form
    {
        DataTable dt = new DataTable();
        int selectedInstrutkor { get; set; }
        int selectedVozilo { get; set; }
        DateTime datumZ { get; set; }
        DateTime datumR { get; set; }
    public Duzi()
        {
            InitializeComponent();
            osveziTable();
            dodajInstruktore();
            dodajVozila();
            izbrisi.Enabled = false;
            promeni.Enabled = false;
        }
        private void osveziTable()
        {
            dt.Clear();
            string kom = "SELECT radnik, vozilo, datum_zaduzenja, datum_razduzenja FROM Duzi ORDER BY datum_zaduzenja DESC;";
            KonekcijaSBazom.UcitajTabelu(kom, ref dt);
            dataDuzi.DataSource = dt;
        }
        private bool poljePrazno()
        {
            return instruktor.Text == string.Empty || vozilo.Text == string.Empty;
        }
        private void dodajInstruktore()
        {
            
            string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT id_radnika FROM Radnici WHERE pozicija = 1 OR pozicija=3", conn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            instruktor.Items.Add(dr.GetInt32(0));
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
            vozilo.Items.Clear();
            string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT id_vozila\r\nFROM Duzi RIGHT JOIN Vozila ON Duzi.vozilo = Vozila.id_vozila\r\nWHERE id_vozila  NOT IN (SELECT DISTINCT id_vozila FROM Duzi d RIGHT JOIN Vozila v ON v.id_vozila = d.vozilo WHERE (datum_zaduzenja BETWEEN @DatumZ AND @DatumR) OR (datum_razduzenja BETWEEN @DatumZ AND @DatumR));", conn))
                    {
                        cmd.Parameters.AddWithValue("@DatumZ", datum_zaduzenja.Value);
                        cmd.Parameters.AddWithValue("@DatumR", datum_razduzenja.Value);
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

        private void datum_zaduzenja_ValueChanged(object sender, EventArgs e)
        {
            dodajVozila();
        }

        private void datum_razduzenja_ValueChanged(object sender, EventArgs e)
        {
            dodajVozila();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (poljePrazno())
            {
                MessageBox.Show("Molimo Vas popunite prazna polja");
                return;
            }
            try
            {
                string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Duzi (radnik, vozilo, datum_zaduzenja, datum_razduzenja) " +
                        "VALUES (@Instruktor, @Vozilo, @DatumZ, @DatumR)", connection))
                    {//moze iz bez ovog using samo nova SqlCommand i umesto @Ime stavite ispred navodnika $ i umesto @Ime {Ime} ostalo analogno
                        cmd.Parameters.AddWithValue("@Instruktor", instruktor.SelectedItem);//using garantuje da se Dispose()-uje sve nakon zavrsetka i ukoliko dodje do greske opet disposeuje
                        cmd.Parameters.AddWithValue("@Vozilo", vozilo.SelectedItem);//ali realno zamenite samo imena polja i tjt
                        cmd.Parameters.AddWithValue("@DatumZ", datum_zaduzenja.Value);
                        cmd.Parameters.AddWithValue("@DatumR", datum_razduzenja.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage(ex);
            }
            osveziTable();
        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataDuzi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            promeni.Enabled = true;
            izbrisi.Enabled = true;
            pokupiPodatkeIzReda();
        }
        private void pokupiPodatkeIzReda()
        {
            DataGridViewRow selectedRow = dataDuzi.SelectedRows[0];
            selectedInstrutkor = Convert.ToInt32(selectedRow.Cells[0].Value);
            selectedVozilo = Convert.ToInt32(selectedRow.Cells[1].Value);
            datumZ = Convert.ToDateTime(selectedRow.Cells[2].Value);
            datumR =  Convert.ToDateTime(selectedRow.Cells[3].Value);
        }

        private void izbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Duzi WHERE radnik = @Instruktor AND vozilo = @Vozilo AND datum_zaduzenja = @DatumZ ", connection))
                    {
                        cmd.Parameters.AddWithValue("@Instruktor", selectedInstrutkor);
                        cmd.Parameters.AddWithValue("@Vozilo", selectedVozilo);
                        cmd.Parameters.AddWithValue("@DatumZ", datumZ);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage(ex);
            }
            osveziTable();
        }

        private void promeni_Click(object sender, EventArgs e)
        {
            PromeniDuzi form = new PromeniDuzi();
            form.primiPodatke(selectedInstrutkor, selectedVozilo, datumZ, datumR);
            form.ShowDialog();
            form.Dispose();
            osveziTable();
        }

        private void izlaz_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
