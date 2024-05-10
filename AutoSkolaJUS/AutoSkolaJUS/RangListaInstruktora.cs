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
    public partial class RangListaInstruktora : Form
    {

        SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public RangListaInstruktora()
        {
            InitializeComponent();
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Kandidati k LEFT JOIN Polaganje p ON k.JMBG = p.kandidat" +
                                                   "WHERE polozen IS NULL OR polozen = 0; AND tip_polaganja = "+tipPolaganja.Text+";");

            
            veza.Close();
        }

        private void fill_tipPolaganja(string sql, ComboBox cb)
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
                cb.DisplayMember = "vrsta_polaganja";
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

        private void RangListaInstruktora_Load(object sender, EventArgs e)
        {
            string sql = "SELECT vrsta FROM Vrste_polaganja";
            fill_tipPolaganja(sql, cbtipPolaganja);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
