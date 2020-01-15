using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CassandraWinFormsSample
{
    public partial class Glavna : MetroFramework.Forms.MetroForm
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {

        }

        private void dodajkorisnikabtn_Click(object sender, EventArgs e)
        {
            var Forma = new KorisnikForma();
            Forma.ShowDialog();
        }

        private void dodajdupbtn_Click(object sender, EventArgs e)
        {
            var Forma1 = new Dnevni_unos_pica();
            Forma1.ShowDialog();
        }

        private void dodajduhbtn_Click(object sender, EventArgs e)
        {
            var Forma = new Dnevni_unos_hrane();
            Forma.ShowDialog();
        }

        private void dodajfabtn_Click(object sender, EventArgs e)
        {
            var Forma = new FizickaAktivnost();
            Forma.ShowDialog();
        }

      
    }
}
