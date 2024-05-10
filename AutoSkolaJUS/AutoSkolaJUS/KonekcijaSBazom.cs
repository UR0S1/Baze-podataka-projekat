using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkolaJUS
{
    //internal class KonekcijaSBazom

    static public class KonekcijaSBazom
    {
        static public bool UcitajTabelu(string komanda, ref DataTable tabela)
        {
            tabela.Clear(); //čisti 

            string stringVeze = global::AutoSkolaJUS.Properties.Settings.Default.strVeze;
            SqlConnection l_veza = new SqlConnection(stringVeze);     //deklariše vezu ka BP

            try
            {
                l_veza.Open();      //uspostavlja vezu za BP
                SqlDataAdapter l_adapter = new SqlDataAdapter(komanda, l_veza);     //kreira DataAdapter instancu
                DataSet l_ds = new DataSet();                                       //kreira DataSet
                try
                {
                    l_adapter.Fill(l_ds);               //popunjava podacima DataSet preko adaptera
                    tabela = l_ds.Tables[0];            //uzima prvu (i jedinu) tabelu iz DataSeta
                    l_veza.Close();                     //zatvara vezu sa BP
                    return true;                        //vraća indikator da je naredba uspešno izvršena
                }
                catch (Exception ex1)           //desila se greška 
                {
                    MessageBox.Show("Došlo je do greške pri preuzimanju podataka! \r\n" + ex1.Message, "PODACI NISU PREUZETI!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);        // javlja o greški
                }
            }
            catch (Exception ex2)               //desila se greška 
            {
                MessageBox.Show("Došlo je do greške u povezivanju sa bazom podataka! \r\n" + ex2.Message, "BAZA NIJE DOSTUPNA!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);            // javlja o greški
            }
            l_veza.Close();                        //zatvara konekciju sa BP
            return false;                           //vraća indikator da upit nije uspešno izvršen                      
        }

        static bool PromeniPodatke(string _komanda)
        {

            SqlConnection l_veza = new SqlConnection(global::AutoSkolaJUS.Properties.Settings.Default.strVeze);
            //deklariše vezu ka BP
            try
            {
                l_veza.Open();           //uspostavlja vezu sa BP
                SqlCommand l_kmd = new SqlCommand(_komanda, l_veza); //deklariše SQL komandu koja se izvršava preko veze
                try
                {
                    l_kmd.ExecuteNonQuery();        //izvršava se SQL komanda na BP
                    l_veza.Close();                 //zatvara vezu sa BP
                    return true;                    //vraća indikator da je naredba uspešno izvršena
                }
                catch (Exception ex1)           //desila se greška 
                {
                    MessageBox.Show("Došlo je do greške pri promeni baze! Promene nisu unete. \r\n" + ex1.Message, "GREŠKA U IZVRŠAVANJU",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex2)               //desila se greška 
            {
                MessageBox.Show("Došlo je do greške u povezivanju sa bazom podataka! \r\n" + ex2.Message, "BAZA NIJE DOSTUPNA",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            l_veza.Close();                        //zatvara konekciju sa BP
            return false;                          //vraća indikator da naredba nije uspešno izvršena
        }


    }
}
