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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AutoSkolaJUS
{
    public partial class Vozila : Form
    {

        DataTable dt = new DataTable();

        public Vozila()
        {
            InitializeComponent();
        }

        private void izlaz_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();
            SqlCommand komanda = new SqlCommand("INSERT INTO Vozila (sifra,kategorija,brend,model) " +
                                                "VALUES (" +sifra_vozila.Text + ", " + kategorija.Text + ", " + brend.Text + ", " + model.Text + ");", veza);
            komanda.ExecuteNonQuery();
            veza.Close();
        }

        private void promeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();


            SqlCommand komanda = new SqlCommand("UPDATE Vozila " +
                                                "SET kategorija=" + kategorija.Text + ", brend=" + brend.Text + ", model=" + model.Text + "" +
                                                "WHERE sifra=" + sifra_vozila.Text + ";", veza);
            komanda.ExecuteNonQuery();
            veza.Close();
        }

        private void izbrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();

            SqlCommand komanda = new SqlCommand("DELETE FROM Vozila" +
                                                "WHERE sifra=" + sifra_vozila.Text + ";", veza);
            komanda.ExecuteNonQuery();
            veza.Close();
        }

        private void osvezi_Click(object sender, EventArgs e)
        {
            dt.Clear();
            string kom = "SELECT * FROM Vozila";
            KonekcijaSBazom.UcitajTabelu(kom, ref dt);
            dataVozila.DataSource = dt;
        }
    }
}
