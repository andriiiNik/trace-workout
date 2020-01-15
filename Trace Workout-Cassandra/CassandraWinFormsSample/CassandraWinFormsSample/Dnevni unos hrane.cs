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
    public partial class Dnevni_unos_hrane : MetroFramework.Forms.MetroForm
    {
    
        public Dnevni_unos_hrane()
        {
            InitializeComponent();
        }

        private void Dnevni_unos_hrane_Load(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }
        public void PrikaziSakrij()
        {
            if (dorucakchb.Checked)
            {
                rucakchb.Checked = false;
                vecerachb.Checked = false;
                uzinachb.Checked = false;
            }
            else if (rucakchb.Checked)
            {
                dorucakchb.Checked = false;
                vecerachb.Checked = false;
                uzinachb.Checked = false;
            }
            else if (vecerachb.Checked)
            {
                dorucakchb.Checked = false;
                rucakchb.Checked = false;
                uzinachb.Checked = false;
            }
            else if (uzinachb.Checked)
            {
                dorucakchb.Checked = false;
                rucakchb.Checked = false;
                vecerachb.Checked = false;
            }
        }

        private void dorucakchb_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }

        private void rucakchb_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }

        private void vecerachb_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }

        private void uzinachb_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }

        private void dodajduhbtn_Click(object sender, EventArgs e)
        {
            if (dorucakchb.Checked)
            {
                DUH d = new DUH();
                d.jmbg = jmbgtxtb.Text;
                d.datum = date.Text;
                d.namirnica = namirnicatb.Text;
                d.kalorijska_vrednost_namirnice = kcalnamirnicetb.Text;
                d.obrok = "dorucak";
                DataProvider.DodajDUH(d);
            }
            else if (rucakchb.Checked)
            {
                DUH d = new DUH();
                d.jmbg = jmbgtxtb.Text;
                d.datum = date.Text;
                d.namirnica = namirnicatb.Text;
                d.kalorijska_vrednost_namirnice = kcalnamirnicetb.Text;
                d.obrok = "rucak";
                DataProvider.DodajDUH(d);
            }
            else if(vecerachb.Checked)
            {
                DUH d = new DUH();
                d.jmbg = jmbgtxtb.Text;
                d.datum = date.Text;
                d.namirnica = namirnicatb.Text;
                d.kalorijska_vrednost_namirnice = kcalnamirnicetb.Text;
                d.obrok = "vecera";
                DataProvider.DodajDUH(d);
            }
            else if (uzinachb.Checked)
            {
                DUH d = new DUH();
                d.jmbg = jmbgtxtb.Text;
                d.datum = date.Text;
                d.namirnica = namirnicatb.Text;
                d.kalorijska_vrednost_namirnice = kcalnamirnicetb.Text;
                d.obrok = "uzina";
                DataProvider.DodajDUH(d);
            }
            MessageBox.Show("Dnevni unos hrane je uspesno dodat u bazu!");
            this.DialogResult = DialogResult.OK;
        }

        private void obrisiduhbtn_Click(object sender, EventArgs e)
        {
            DataProvider.IzbrisiDUH("1407997735060");
            MessageBox.Show("Uspesno izbrisano iz baze");
        }

        private void procitajDNbtn_Click(object sender, EventArgs e)
        {
            DUH d = DataProvider.UcitajDuh("Friday, April 17,2018", "1407997706010");

            MessageBox.Show("Podaci o dnevnom unosu:"+" "+d.namirnica+" "+d.kalorijska_vrednost_namirnice+" "+d.obrok);
           
        }

        private void procitajSVEbtn_Click(object sender, EventArgs e)
        {
            List<DUH> duhs = DataProvider.UzmiSveDuh();

            foreach (DUH d in duhs)
                MessageBox.Show(d.datum+" " + d.namirnica+" "+ d.kalorijska_vrednost_namirnice+" "+d.obrok);
        }
    }
}
