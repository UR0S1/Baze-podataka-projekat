using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkolaJUS
{
    internal class VoziloClass
    {
        public int Sifra { get; set; }
        public string Kategorija { get; set; }
        public string Brend { get; set; }
        public string Model { get; set; }

        private readonly string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;

        public void Insert()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Vozila (id_vozila, kategorija, brend, model) " +
                        "VALUES (@Sifra, @Kategorija, @Brend, @Model)", connection))
                    {
                        cmd.Parameters.AddWithValue("@Sifra", Sifra);
                        cmd.Parameters.AddWithValue("@Kategorija", Kategorija);
                        cmd.Parameters.AddWithValue("@Brend", Brend);
                        cmd.Parameters.AddWithValue("@Model", Model);
                       
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
                        "UPDATE Vozila " +
                        "SET kategorija = @Kategorija, brend = @Brend, model = @Model " + 
                        "WHERE id_vozila = @Sifra", connection))
                    {
                        cmd.Parameters.AddWithValue("@Sifra", Sifra);
                        cmd.Parameters.AddWithValue("@Kategorija", Kategorija);
                        cmd.Parameters.AddWithValue("@Brend", Brend);
                        cmd.Parameters.AddWithValue("@Model", Model);

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
                        "DELETE FROM Vozila WHERE id_vozila = @Sifra", connection))
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
