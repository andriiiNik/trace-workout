using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;


namespace CassandraWinFormsSample
{
    public partial class FizickaAktivnost : MetroFramework.Forms.MetroForm
    {
        public FizickaAktivnost()
        {
            InitializeComponent();
        }

        private void Fizicka_aktivnost_Load(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DataProvider.ObrisiFA("1407997735060");
            MessageBox.Show("Fizicka aktivnost je uspesno obrisana!");
        }
        private void PrikaziSakrij()
        {
            if (trcanjerb.Checked)
            {
                brzohrb.Checked = false;
                setanjerb.Checked = false;
            }
            else if (brzohrb.Checked)
            {
                setanjerb.Checked = false;
                trcanjerb.Checked = false;
            }
            else if (setanjerb.Checked)
            {
                brzohrb.Checked = false;
                trcanjerb.Checked = false;
            }
        }

        private void dodajbtn_Click(object sender, EventArgs e)
        {
            if (setanjerb.Checked)
            {
                Fizicka_aktivnost fa = new Fizicka_aktivnost();
                fa.jmbg = jmbgtxtbox.Text;
                fa.predjeni_km = kmtb.Text;

                fa.vreme = vremetrajanjatb.Text;
                fa.datum = datum.Text;
                fa.tip_aktivnosti = "setanje";

                DataProvider.DodajFA(fa);
            }
            else if (brzohrb.Checked)
            {
                Fizicka_aktivnost fa = new Fizicka_aktivnost();
                fa.jmbg = jmbgtxtbox.Text;
                fa.predjeni_km = kmtb.Text;

                fa.vreme = vremetrajanjatb.Text;
                fa.datum = datum.Text;
                fa.tip_aktivnosti = "brzo hodanje";
                DataProvider.DodajFA(fa);
            }
            else if (trcanjerb.Checked)
            {
                Fizicka_aktivnost fa = new Fizicka_aktivnost();
                fa.jmbg = jmbgtxtbox.Text;
                fa.predjeni_km = kmtb.Text;

                fa.vreme = vremetrajanjatb.Text;
                fa.datum = datum.Text;
                fa.tip_aktivnosti = "trcanje";
                DataProvider.DodajFA(fa);
            }
            MessageBox.Show("Fizicka aktivnost uspesno dodata u bazu!");
            this.DialogResult = DialogResult.OK;
        }

        private void setanjerb_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }

        private void brzohrb_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }

        private void trcanjerb_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }
    }
}
