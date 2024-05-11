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
    public partial class Radnici : Form
    {
        SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
        SqlCommand cmd;
        SqlDataReader da;
        DataTable dt = new DataTable();


        string selectedIme = string.Empty;
        string selectedPrezime = string.Empty;
        string selectedJMGB = string.Empty;
        string selectedAdresa = string.Empty;
        string selectedPozicija = string.Empty;
        string selectedVozilo = string.Empty;

        public Radnici()
        {
            InitializeComponent();
            promeni.Enabled = false;
            izbrisi.Enabled = false;
            osvezi_Click();
            dodajVozila();
        }

        private void fill_pozicija(string sql, ComboBox cb)
        {
            try
            {
                veza.Open();
                cmd = new SqlCommand();
                
                dt = new DataTable();

                cmd.Connection = veza;
                cmd.CommandText = sql;
              
               

                pozicija.DataSource = dt;
                pozicija.DisplayMember = "pozicija";
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

        private void izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void osvezi_Click()
        {
            dt.Clear();
            string kom = "SELECT * FROM Radnici";
            KonekcijaSBazom.UcitajTabelu(kom, ref dt);
            dataRadnika.DataSource = dt;
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);       
            veza.Open();        
      
            SqlCommand komanda = new SqlCommand("INSERT INTO Radnici (ime,prezime,JMBG,adresa,pozicija) " +
                                                "VALUES ("+ime.Text+", "+prezime.Text+", "+jmbg.Text+", "+adresa.Text+", "+pozicija.Text+");", veza);
            komanda.ExecuteNonQuery();
            veza.Close();
        }

        private void promeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            veza.Open();        

            
            SqlCommand komanda = new SqlCommand("UPDATE Radnici " +
                                                "SET ime="+ime.Text+", prezime="+prezime.Text+", adresa="+adresa.Text+", pozicija="+pozicija.Text+"" +
                                                "WHERE JMBG="+jmbg.Text+";", veza);
            komanda.ExecuteNonQuery();     
            veza.Close();
        }
        private void dodajVozila()
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            SqlCommand komanda = new SqlCommand("SELECT DISTINCT v.id_vozila, v.model, v.brend\r\nFROM Vozila v INNER JOIN Duzi d ON v.id_vozila = d.vozilo \r\nWHERE CAST(GETDATE() AS DATE) NOT BETWEEN d.datum_zaduzenja AND ISNULL(d.datum_razduzenja, DATEADD(DAY,1,CAST(GETDATE() AS DATE)))\r\n", veza);

            try
            {
                veza.Open();
                da = komanda.ExecuteReader();
                dt = new DataTable();

                while(da.Read() )
                {
                    cmbVozilo.Items.Add(da.GetInt32(0).ToString() + "|" + da.GetString(1) + "|" + da.GetString(2));
                }
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
        private void izbrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze); 
            SqlCommand komanda = new SqlCommand($"DELETE FROM Radnici WHERE JMBG ='{selectedJMGB}';", veza);
            try { 
                veza.Open();        
                komanda.ExecuteNonQuery();   
                veza.Close();
            }catch (Exception ex)
            {
                errorMessage(ex);
            }
            osvezi_Click();
        }

        private void errorMessage(Exception ex)
        {
            string message = "Došlo je do greške. ";
            string title = "Error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBox.Show(message + ex, title, buttons, icon);

        }

        private void Radnici_Load(object sender, EventArgs e)
        {
            string sql = "SELECT tip_radnika FROM Tip_radnika;";
            fill_pozicija(sql, pozicija);
        }

        private void dataRadnika_SelectionChanged(object sender, EventArgs e)
        {
            
            
        }

        private void pokupiPodatkeIzReda()
        {
            DataGridViewRow selectedRow = dataRadnika.SelectedRows[0];
            selectedIme = selectedRow.Cells[1].Value.ToString();
            selectedPrezime = selectedRow.Cells[2].Value.ToString();
            selectedJMGB = selectedRow.Cells[3].Value.ToString();
            selectedAdresa = selectedRow.Cells[4].Value.ToString();
            selectedPozicija = selectedRow.Cells[5].Value.ToString();
        }

        private void dataRadnika_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            promeni.Enabled = true;
            izbrisi.Enabled = true;
            pokupiPodatkeIzReda(); 
            
        }
    }
}
