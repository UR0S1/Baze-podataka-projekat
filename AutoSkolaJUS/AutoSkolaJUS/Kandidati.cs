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
    public partial class Kandidati : Form
    {

        DataTable dt = new DataTable();

        public Kandidati()
        {
            InitializeComponent();
            instruktor.Enabled = false;
            dodajInstruktore();
            osveziTable();
        }
        private void dodajInstruktore()
        {
            string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand("SELECT id_radnika FROM Radnici WHERE pozicija = 2", conn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            instruktor.Items.Add(dr.GetInt32(0));
                        }
                        
                    }
                    conn.Close();
                }

            }catch (Exception ex)
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
            return ime.Text == string.Empty || prezime.Text == string.Empty || jmbg.Text.Length != 13 || adresa.Text == string.Empty;
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (poljePrazno())
            {
                MessageBox.Show("Molim vas popunite prazna polja");
                return;
            }


            KandidatClass kandidat = new KandidatClass();
            kandidat.Ime = ime.Text;
            kandidat.Prezime = prezime.Text;
            kandidat.JMBG = jmbg.Text;
            kandidat.Adresa = adresa.Text;
            kandidat.InstruktorID = Convert.ToInt32(instruktor.SelectedValue);
            kandidat.Teorija = teorija.Checked;
            kandidat.PrvaPomoc = prvapomoc.Checked;
            kandidat.Voznja = voznja.Checked;

            kandidat.Insert();
            osveziTable();
        }

        private void promeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();


            SqlCommand komanda = new SqlCommand("UPDATE Kandidati " +
                                                "SET ime=" + ime.Text + ", prezime=" + prezime.Text + ", adresa=" + adresa.Text +
                                                "WHERE jmbg=" + jmbg.Text + ";", veza);
            komanda.ExecuteNonQuery();

            if (teorija.Checked)
            {
                SqlCommand komanda1 = new SqlCommand("UPDATE Kandidati SET teorija=1 WHERE jmbg=" + jmbg.Text + ";", veza);
                komanda1.ExecuteNonQuery();
            }
            if (prvapomoc.Checked)
            {
                SqlCommand komanda2 = new SqlCommand("UPDATE Kandidati SET prva_pomoc=1 WHERE jmbg=" + jmbg.Text + ";", veza);
                komanda2.ExecuteNonQuery();
            }
            if (voznja.Checked)
            {
                SqlCommand komanda3 = new SqlCommand("UPDATE Kandidati SET voznja=1 WHERE jmbg=" + jmbg.Text + ";", veza);
                komanda3.ExecuteNonQuery();
            }

            veza.Close();
            osveziTable();
        }

        private void izbrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();

            SqlCommand komanda = new SqlCommand("DELETE FROM Kandidati" +
                                                "WHERE JMBG=" + jmbg.Text + ";", veza);
            komanda.ExecuteNonQuery();
            veza.Close();

            osveziTable();
        }

        private void osveziTable()
        {
            dt.Clear();
            string kom = "SELECT * FROM Kandidati";
            KonekcijaSBazom.UcitajTabelu(kom, ref dt);
            dataKandidata.DataSource = dt;
        }

        private void teorija_CheckStateChanged(object sender, EventArgs e)
        {
            if(teorija.Checked && prvapomoc.Checked)
            {
                instruktor.Enabled = true;
            }
            else
            {
                instruktor.Enabled = false;
            }
        }

        private void prvapomoc_CheckStateChanged(object sender, EventArgs e)
        {
            if (teorija.Checked && prvapomoc.Checked)
            {
                instruktor.Enabled = true;
            }
            else
            {
                instruktor.Enabled = false;
            }
        }

        private void jmbg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
