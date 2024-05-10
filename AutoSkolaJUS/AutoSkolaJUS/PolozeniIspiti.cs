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
    public partial class PolozeniIspiti : Form
    {
        public PolozeniIspiti()
        {
            InitializeComponent();
        }

        private void nazadbtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                                                   "SELECT SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) AS 'Polozenih', SUM(CASE WHEN p.polozen = 0 THEN 1 ELSE 0 END) AS 'Palih'," +
                                                   "CAST (ROUND(100.0 * SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) / NULLIF(SUM(CASE WHEN p.polozen IN (0, 1) THEN 1 ELSE 0 END), 0),2) AS DECIMAL(5,2)) " +
                                                   "AS 'Procenat polozenih' FROM Kandidati k" +
                                                   "LEFT JOIN Polaganje p ON k.JMBG = p.kandidat" +
                                                   "WHERE datum BETWEEN "+dateTimePicker1.Text+" AND "+dateTimePicker2.Text+";"
                                                   );
            
            veza.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();

            SqlCommand sqlCommand = new SqlCommand("USE AUTOSKOLA" +
                                                   "SELECT SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) AS 'Polozenih', SUM(CASE WHEN p.polozen = 0 THEN 1 ELSE 0 END) AS 'Palih'," +
                                                   "CAST (ROUND(100.0 * SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) / NULLIF(SUM(CASE WHEN p.polozen IN (0, 1) THEN 1 ELSE 0 END), 0),2) AS DECIMAL(5,2)) " +
                                                   "AS 'Procenat polozenih' FROM Kandidati k" +
                                                   "LEFT JOIN Polaganje p ON k.JMBG = p.kandidat" +
                                                   "WHERE datum BETWEEN " + dateTimePicker1.Text + " AND " + dateTimePicker2.Text + ";"
                                                   );
            
            veza.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
