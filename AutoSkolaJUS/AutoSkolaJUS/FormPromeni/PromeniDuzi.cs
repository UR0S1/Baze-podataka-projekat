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

namespace AutoSkolaJUS.FormPromeni
{
    public partial class PromeniDuzi : Form
    {
        public PromeniDuzi()
        {
            InitializeComponent();
            dodajInstruktore();
            dodajVozila();
            
        }
        int pInstr;
        int pVoz;
        DateTime pDatZ;
        DateTime pDatR;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void primiPodatke(int id, int id_v, DateTime datumz, DateTime datumr)
        {
            instruktor.SelectedItem = id;
            pInstr = id;
            vozilo.SelectedItem = id_v;
            pVoz = id_v;
            datum_zaduzenja.Value = datumz;
            pDatZ = datumz;
            datum_razduzenja.Value = datumr;
            pDatR = datumr;
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void promeni_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE Duzi " +
                        "SET radnik=@Instrutkor, vozilo=@Vozilo, datum_zaduzenja=@DatumZ, datum_razduzenja=@DatumR " + 
                        $"WHERE radnik={pInstr} AND vozilo={pVoz} AND datum_zaduzenja = @pDatumZ", connection))
                    {
                        cmd.Parameters.AddWithValue("@Vozilo", vozilo.Text);
                        cmd.Parameters.AddWithValue("@Instrutkor", instruktor.Text);
                        cmd.Parameters.AddWithValue("@DatumZ", datum_zaduzenja.Value);
                        cmd.Parameters.AddWithValue("@DatumR", datum_razduzenja.Value);
                        cmd.Parameters.AddWithValue("@pDatumZ", pDatZ);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage(ex);
            }
            this.Close();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
