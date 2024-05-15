using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;

namespace AutoSkolaJUS
{
    internal class PolaganjeClass
    {
        public int Sifra { get; set; } //SIFRA(NEMA JE U FORMI, A TREBA ZA DELETE)
        public int Vrsta { get; set; }  
        public string Kandidat { get; set; }
        public DateTime Datum { get; set; } 
        public bool Polozio { get; set; }

        private readonly string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;

        public void Insert()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Polaganje (vrsta_polaganja, kandidat, datum, polozen) " +
                        "VALUES (@Vrsta, @Kandidat, @Datum, @Polozio)", connection))
                    {
                        cmd.Parameters.AddWithValue("@Vrsta", Vrsta);
                        cmd.Parameters.AddWithValue("@Kandidat", Kandidat);
                        cmd.Parameters.AddWithValue("@Datum", Datum);
                        cmd.Parameters.AddWithValue("@Polozio", Polozio);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage(ex);
            }
        }



        public void Update()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE Polaganje " +
                        "SET vrsta_polaganja = @Vrsta, kandidat = @Kandidat, datum = @Datum, polozen = @Polozio " + 
                        "WHERE  id_polaganja = @Sifra", connection))
                    {
                        cmd.Parameters.AddWithValue("@Sifra",Sifra);
                        cmd.Parameters.AddWithValue("@Vrsta", Vrsta);
                        cmd.Parameters.AddWithValue("@Kandidat", Kandidat);
                        cmd.Parameters.AddWithValue("@Datum", Datum);
                        cmd.Parameters.AddWithValue("@Polozio", Polozio);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage(ex);
            }


        }


        public void Delete()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Polaganje WHERE id_polaganja = @Sifra", connection))
                    {
                        cmd.Parameters.AddWithValue("@Sifra", Sifra);
                        cmd.ExecuteNonQuery();
                    }
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
    }

}
