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
    public partial class ProcentniPrikazPoInstruktoru : Form
    {

        SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public ProcentniPrikazPoInstruktoru()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();

            SqlCommand sqlCommand = new SqlCommand("USE AUTOSKOLA" +
                                                   "SELECT r.id_radnika AS 'ID', r.ime AS 'Ime', r.prezime AS 'Prezime'," +
                                                   "SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) AS 'Polozenih', SUM(CASE WHEN p.polozen = 0 THEN 1 ELSE 0 END) AS 'Palih'," +
                                                   "CAST (ROUND(100.0 * SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) / NULLIF(SUM(CASE WHEN p.polozen IN (0, 1) THEN 1 ELSE 0 END), 0),2) AS DECIMAL(5,2)) " +
                                                   "AS 'Procenat polozenih' FROM Kandidati k INNER JOIN Polaganje p ON k.JMBG = p.kandidat INNER JOIN Radnici r ON r.id_radnika = k.instruktor" +
                                                   "WHERE vrsta_polaganja = 2 AND r.tip_radnika='instruktor' AND datum BETWEEN " + dateTimePicker1.Text + " AND " + dateTimePicker2.Text +
                                                   "GROUP BY r.id_radnika");
            
            veza.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();

            SqlCommand sqlCommand = new SqlCommand("USE AUTOSKOLA" +
                                                   "SELECT r.id_radnika AS 'ID', tr.ime AS 'Ime', tr.prezime AS 'Prezime'," +
                                                   "SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) AS 'Polozenih', SUM(CASE WHEN p.polozen = 0 THEN 1 ELSE 0 END) AS 'Palih'," +
                                                   "CAST (ROUND(100.0 * SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) / NULLIF(SUM(CASE WHEN p.polozen IN (0, 1) THEN 1 ELSE 0 END), 0),2) AS DECIMAL(5,2)) " +
                                                   "AS 'Procenat polozenih' FROM Kandidati k INNER JOIN Polaganje p ON k.JMBG = p.kandidat INNER JOIN Radnici r ON r.id_radnika = k.instruktor" +
                                                   "WHERE instruktor = '3' AND vrsta_polaganja = '2' " + instruktor.Text + "  AND datum BETWEEN " + dateTimePicker1.Text + " AND " + dateTimePicker2.Text + "" +
                                                   "GROUP BY instruktor,r.id_radnika,r.ime,r.prezime;");
            
            veza.Close();
        }

        private void instruktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();

            SqlCommand sqlCommand = new SqlCommand("USE AUTOSKOLA" +
                                                   "SELECT r.id_radnika AS 'ID', tr.ime AS 'Ime', tr.prezime AS 'Prezime'," +
                                                   "SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) AS 'Polozenih', SUM(CASE WHEN p.polozen = 0 THEN 1 ELSE 0 END) AS 'Palih'," +
                                                   "CAST (ROUND(100.0 * SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) / NULLIF(SUM(CASE WHEN p.polozen IN (0, 1) THEN 1 ELSE 0 END), 0),2) AS DECIMAL(5,2)) " +
                                                   "AS 'Procenat polozenih' FROM Kandidati k INNER JOIN Polaganje p ON k.JMBG = p.kandidat INNER JOIN Radnici r ON r.id_radnika = k.instruktor" +
                                                   "WHERE instruktor = '3' AND vrsta_polaganja = '2' " + instruktor.Text + "  AND datum BETWEEN " + dateTimePicker1.Text + " AND " + dateTimePicker2.Text + "" +
                                                   "GROUP BY instruktor,r.id_radnika,r.ime,r.prezime;");
            
            veza.Close();
        }

        private void fill_instruktor(string sql, ComboBox cb)
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
                cb.DisplayMember = "pozicija";
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

        private void ProcentniPrikazPoInstruktoru_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Radnici WHERE pozicija='instruktor'";
            fill_instruktor(sql, instruktor);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
