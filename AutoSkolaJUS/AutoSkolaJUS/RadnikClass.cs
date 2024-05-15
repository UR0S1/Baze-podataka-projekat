using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkolaJUS
{
    internal class RadnikClass
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string Adresa { get; set; }
        public int Pozicija { get; set; }

        //vozilo ? mozda ne ??? vrv NE

        private readonly string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;

        public void Insert()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Radnici (ime, prezime, JMBG, adresa, pozicija) " +
                        "VALUES (@Ime, @Prezime, @JMBG, @Adresa, @Pozicija)", connection))
                    {
                        cmd.Parameters.AddWithValue("@Ime", Ime);
                        cmd.Parameters.AddWithValue("@Prezime", Prezime);
                        cmd.Parameters.AddWithValue("@JMBG", JMBG);
                        cmd.Parameters.AddWithValue("@Adresa", Adresa);
                        cmd.Parameters.Add("@Pozicija", System.Data.SqlDbType.Int).Value = Pozicija;
                        Console.WriteLine("Pozicija:" + Pozicija);
                        cmd.ExecuteNonQuery(); //jos jednom li prikaze gresku ovde, obesicu se (╥﹏╥)
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
                        "UPDATE Radnici " +
                        "SET ime = @Ime, prezime = @Prezime, JMBG = @JMBG, adresa = @Adresa, pozicija = @Pozicija " +
                        "WHERE JMBG = @JMBG", connection))
                    {
                        cmd.Parameters.AddWithValue("@Ime", Ime);
                        cmd.Parameters.AddWithValue("@Prezime", Prezime);
                        cmd.Parameters.AddWithValue("@JMBG", JMBG);
                        cmd.Parameters.AddWithValue("@Adresa", Adresa);
                        cmd.Parameters.AddWithValue("@Pozicija", Pozicija);
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
                        "DELETE FROM Radnici WHERE JMBG = @JMBG", connection))
                    {
                        cmd.Parameters.AddWithValue("@JMBG", JMBG);
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
