using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkolaJUS
{
    internal class KandidatCLass
    {
        public int KandidatID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string Adresa { get; set; }
        public int InstruktorID { get; set; } // Ima neka anotacija da kaze da je ovo foreign key ali mislim da nam ne znaci ovde
        public bool Teorija { get; set; }
        public bool Voznja { get; set; }
        public bool PrvaPomoc { get; set; }

        private readonly string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;

        public void Insert()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Kandidati (ime, prezime, JMBG, instruktor, adresa, teorija, voznja, prva_pomoc) " +//pazite ovde mora razmak pre + inace ce biti errorcina
                        "VALUES (@Ime, @Prezime, @JMBG, @Adresa, @InstruktorID, @Teorija, @Voznja, @PrvaPomoc)", connection))
                    {//moze iz bez ovog using samo nova SqlCommand i umesto @Ime stavite ispred navodnika $ i umesto @Ime {Ime} ostalo analogno
                        cmd.Parameters.AddWithValue("@Ime", Ime);//using garantuje da se Dispose()-uje sve nakon zavrsetka i ukoliko dodje do greske opet disposeuje
                        cmd.Parameters.AddWithValue("@Prezime", Prezime);//ali realno zamenite samo imena polja i tjt
                        cmd.Parameters.AddWithValue("@JMBG", JMBG);
                        cmd.Parameters.AddWithValue("@Adresa", Adresa);
                        cmd.Parameters.AddWithValue("@InstruktorID", InstruktorID);
                        cmd.Parameters.AddWithValue("@Teorija", Teorija);
                        cmd.Parameters.AddWithValue("@Voznja", Voznja);
                        cmd.Parameters.AddWithValue("@PrvaPomoc", PrvaPomoc);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eror pri izvrsavanju upisa: {ex.Message}");
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
                        "UPDATE Kandidati " +
                        "SET ime = @Ime, prezime = @Prezime, JMBG = @JMBG, adresa = @Adresa, instruktor = @InsturktorID, teorija = @Teorija, voznja = @Voznja, prva_pomoc = @PrvaPomoc " + //this shit long
                        "WHERE KandidatID = @KandidatID", connection))
                    {
                        cmd.Parameters.AddWithValue("@KandidatID", KandidatID);
                        cmd.Parameters.AddWithValue("@Ime", Ime);
                        cmd.Parameters.AddWithValue("@Prezime", Prezime);
                        cmd.Parameters.AddWithValue("@JMBG", JMBG);
                        cmd.Parameters.AddWithValue("@Adresa", Adresa);
                        cmd.Parameters.AddWithValue("@InstruktorID", InstruktorID);
                        cmd.Parameters.AddWithValue("@Teorija", Teorija);
                        cmd.Parameters.AddWithValue("@Voznja", Voznja);
                        cmd.Parameters.AddWithValue("@PrvaPomoc", PrvaPomoc);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Eror pri izvrsavanju promene: {ex.Message}");
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
                        "DELETE FROM Kandidati WHERE KandidatID = @KandidatID", connection))
                    {
                        cmd.Parameters.AddWithValue("@KandidatID", KandidatID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Eror pri brisanju: {ex.Message}");
            }
        }
    }

}

