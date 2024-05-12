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

        string selectedIme = string.Empty;
        string selectedPrezime = string.Empty;
        string selectedJMGB = string.Empty;
        string selectedAdresa = string.Empty;
        int selectedInstruktor = 0;
        bool selectedTeorija = false;
        bool selectedPrvaPomoc = false;
        bool selectedVoznja = false;

        public Kandidati()
        {
            InitializeComponent();
            instruktor.Enabled = false;
            promeni.Enabled = false;
            izbrisi.Enabled = false;
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
            ocistiPolja();
            ime.Focus();

        }
        private void ocistiPolja()
        {
            ime.Text = string.Empty;
            prezime.Text = string.Empty;
            adresa.Text = string.Empty;
            jmbg.Text = string.Empty;
            instruktor.Enabled = false;
            instruktor.SelectedItem = null;
            teorija.Checked = false;
            prvapomoc.Checked = false;
            voznja.Checked = false;

        }
        private void pokupiPodatkeIzReda()
        {
            DataGridViewRow selectedRow = dataKandidata.SelectedRows[0];
            
            selectedIme = selectedRow.Cells[0].Value.ToString();
            selectedPrezime = selectedRow.Cells[1].Value.ToString();
            selectedJMGB = selectedRow.Cells[2].Value.ToString();
            selectedAdresa = selectedRow.Cells[3].Value.ToString();
            selectedInstruktor = selectedRow.Cells[4].Value != DBNull.Value? (int)selectedRow.Cells[4].Value : 0;
            int bitValue = Convert.ToInt32(selectedRow.Cells[5].Value);
            selectedTeorija = bitValue == 1;
            bitValue = Convert.ToInt32(selectedRow.Cells[6].Value);
            selectedPrvaPomoc = bitValue == 1;
            bitValue = Convert.ToInt32(selectedRow.Cells[7].Value);
            selectedVoznja = bitValue == 1;
        }

        private void promeni_Click(object sender, EventArgs e)
        {
            pokupiPodatkeIzReda();
            PromeniKandidati promeni = new PromeniKandidati();
            promeni.primiPodatke(selectedIme, selectedPrezime, selectedJMGB, selectedAdresa, selectedInstruktor, selectedTeorija, selectedPrvaPomoc, selectedVoznja);
            promeni.ShowDialog();
            promeni.Dispose();
            osveziTable();
        }

        private void izbrisi_Click(object sender, EventArgs e)
        {
            pokupiPodatkeIzReda();
            KandidatClass kandidat = new KandidatClass();
            kandidat.JMBG = selectedJMGB;
            kandidat.Delete();
            osveziTable();
        }

        private void osveziTable()
        {
            dt.Clear();
            string kom = "SELECT ime,prezime,JMBG,adresa,instruktor,teorija,prva_pomoc,voznja FROM Kandidati";
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

        private void dataKandidata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            promeni.Enabled = true;
            izbrisi.Enabled = true;
            pokupiPodatkeIzReda();
        }
    }
}
