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
    public partial class PolaganjaKandidata : Form
    {
        public PolaganjaKandidata()
        {
            InitializeComponent();
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
