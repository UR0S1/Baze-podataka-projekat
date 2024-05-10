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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AutoSkolaJUS
{
    public partial class Polaganja : Form
    {

        SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public Polaganja()
        {
            InitializeComponent();
        }

        private void fill_vrstaPolaganja(string sql, ComboBox cb)
        {
            try
            {
                veza.Open();
                cmd = new SqlCommand();
                da = new SqlDataAdapter();
                dt = new DataTable();

                cmd.Connection = veza;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                cb.DataSource = dt;
                cb.DisplayMember = "vrsta";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške \r\n" + ex.Message, "!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                veza.Close();
                da.Dispose();
            }

        }

        private void fill_Kandidat(string sql, ComboBox cb)
        {
            try
            {
                veza.Open();
                cmd = new SqlCommand();
                da = new SqlDataAdapter();
                dt = new DataTable();

                cmd.Connection = veza;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                cb.DataSource = dt;
                cb.DisplayMember = "vrsta";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške \r\n" + ex.Message, "!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                veza.Close();
                da.Dispose();
            }

        }

        private void izlaz_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();

            if (polozioda.Checked)
            {
                SqlCommand komanda = new SqlCommand("INSERT INTO Polaganje (sifra,vrsta_polaganja,kandidat,datum,polozen) " +
                                                "VALUES (" + sifra_polaganja.Text + ", " + vrsta_polaganja.Text + ", " + kandidat.Text + ", " + datum.Text + ", 1);", veza);
                komanda.ExecuteNonQuery();
            }
            else
            {
                SqlCommand komanda = new SqlCommand("INSERT INTO Polaganje (sifra,vrsta_polaganja,kandidat,datum,polozen) " +
                                                "VALUES (" + sifra_polaganja.Text + ", " + vrsta_polaganja.Text + ", " + kandidat.Text + ", " + datum.Text + ", 0);", veza);
                komanda.ExecuteNonQuery();
            }
            veza.Close();
        }

        private void promeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();
            SqlCommand komanda = new SqlCommand("UPDATE Polaganje " +
                                                "SET vrsta_polaganja=" + vrsta_polaganja.Text + ", kandidat=" + kandidat.Text + ", datum=" + datum.Text + 
                                                "WHERE sifra=" + sifra_polaganja.Text + ";", veza);
            komanda.ExecuteNonQuery();
            veza.Close();
        }

        private void izbrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();

            SqlCommand komanda = new SqlCommand("DELETE FROM Polaganje" +
                                                "WHERE sifra=" + sifra_polaganja.Text + ";", veza);
            komanda.ExecuteNonQuery();
            veza.Close();
        }

        private void osvezi_Click(object sender, EventArgs e)
        {
            dt.Clear();
            string kom = "SELECT * FROM Polaganja";
            KonekcijaSBazom.UcitajTabelu(kom, ref dt);
            dataPolaganja.DataSource = dt;
        }

        private void Polaganja_Load(object sender, EventArgs e)
        {
            string sql1 = "SELECT vrsta FROM Vrste_polaganja;";
            fill_vrstaPolaganja(sql1, vrsta_polaganja);
            string sql2 = "SELECT * FROM Kandidati";
            fill_Kandidat(sql2, kandidat);
        }
    }
}
