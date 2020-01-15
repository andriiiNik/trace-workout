using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CassandraDataLayer.QueryEntities;
using CassandraDataLayer;

namespace CassandraWinFormsSample
{
    public partial class Dnevni_unos_pica : MetroFramework.Forms.MetroForm
    {
        public Dnevni_unos_pica()
        {
            InitializeComponent();
        }

        private void Dnevni_unos_pica_Load(object sender, EventArgs e)
        {

        }

        private void dodajbtn_Click(object sender, EventArgs e)
        {
            {
                DUP d = new DUP();
                d.jmbg = jmbgtb.Text;
                d.datum = datum .Text;
                d.vrsta_pica = vrstapcb.Text;
                d.kalorijska_vrednost = kalorijepicatb.Text;
                
                DataProvider.DodajDup(d);
            }
            MessageBox.Show("Dnevni unos pica je uspesno dodat u bazu!");
            this.DialogResult = DialogResult.OK;
        }

        private void obrisibtn_Click(object sender, EventArgs e)
        {
            DataProvider.ObrisiDup("3001998756011");
            MessageBox.Show("Uspesno obrisano iz baze");

        }

        private void prikazibtn_Click(object sender, EventArgs e)
        {
            DUP d = DataProvider.UcitajDUP( "3001998756011");

            MessageBox.Show("Podaci o dnevnom unosu:" + " " + d.vrsta_pica + " " + d.kalorijska_vrednost + " " );
        }

        private void prikazisvebtn_Click(object sender, EventArgs e)
        {
            List<DUP> dups = DataProvider.UzmiSveDup();

            foreach (DUP d in dups)
                MessageBox.Show("Svi uneti podaci o picu:" + " " + d.datum + " " + d.vrsta_pica + " " + d.kalorijska_vrednost + " " );
        }

        private void vrstapcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datum_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
