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
    public partial class PromeniKandidati : Form
    {
        public PromeniKandidati()
        {
            InitializeComponent();
            dodajInstruktore();
            
        }

        public void primiPodatke(string sime, string sprezime, string sjmbg, string sadresa, int sinstruktor, bool steorija, bool sprvapomoc, bool svoznja)
        {
            ime.Text = sime;
            prezime.Text = sprezime;
            jmbg.Text = sjmbg;
            adresa.Text = sadresa;
            instruktor.SelectedValue = sinstruktor;
            teorija.Checked = steorija;
            prvapomoc.Checked = sprvapomoc;
            voznja.Checked = svoznja;
            if(steorija && sprvapomoc)
            {
                instruktor.Enabled = true;
            }
            else
            {
                instruktor.Enabled = false;
            }
        }
        private void teorija_CheckStateChanged(object sender, EventArgs e)
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
        private void dodajInstruktore()
        {
            string connectionString = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT id_radnika FROM Radnici WHERE pozicija = 2", conn))
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

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void promeni_Click(object sender, EventArgs e)
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
                kandidat.InstruktorID = instruktor.Enabled ? Convert.ToInt32(instruktor.SelectedValue) : 0;
                kandidat.Teorija = teorija.Checked;
                kandidat.PrvaPomoc = prvapomoc.Checked;
                kandidat.Voznja = voznja.Checked;

                kandidat.Update();
            this.Close();
        }
    }
}
