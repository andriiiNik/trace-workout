using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CassandraWinFormsSample
{
    public partial class KorisnikForma : MetroFramework.Forms.MetroForm
    {

        public KorisnikForma()
        {
            InitializeComponent();
        }

        private void Korisnik_Load(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }
        private void PrikaziSakrij()
        {
            if (muskirb.Checked)
            {
                zenskirb.Checked = false;
            }
            else if (zenskirb.Checked)
            {
                muskirb.Checked = false;
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void jmbgtb_Click(object sender, EventArgs e)
        {

        }

        private void muskirb_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }

        private void zenskirb_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }

        private void dodajkbtn_Click(object sender, EventArgs e)
        {
            if (muskirb.Checked)
            {
                Korisnik kor = new Korisnik();
                kor.jmbg = jmbgtb.Text;
                kor.ime = imetb.Text;
                kor.prezime = prezimetb.Text;
                kor.tezina = tezinatb.Text;
                kor.visina = visinatb.Text;
                kor.godine_starosti = godinetb.Text;
                kor.pol = "muski";
                DataProvider.DodajKorisnika(kor);
            }
            else if (zenskirb.Checked)
            {
                Korisnik kor = new Korisnik();
                kor.jmbg = jmbgtb.Text;
                kor.ime = imetb.Text;
                kor.prezime = prezimetb.Text;
                kor.tezina = tezinatb.Text;
                kor.visina = visinatb.Text;
                kor.pol = "zenski";
                DataProvider.DodajKorisnika(kor);
            }
            MessageBox.Show("Korisnik uspesno dodat u bazu!");
            this.DialogResult = DialogResult.OK;

        }

        private void ucitajpbtn_Click(object sender, EventArgs e)
        {
            Korisnik k = DataProvider.UcitajKorisnika("1407997735060");

            MessageBox.Show(k.ime);
            MessageBox.Show(k.prezime);
            MessageBox.Show(k.jmbg);
        }

        private void obrisibtn_Click(object sender, EventArgs e)
        {
            DataProvider.ObrisiKorisnika("3001998756011");
            MessageBox.Show("Korisnik je obrisan!");
        }

        private void izracunajBMI_Click(object sender, EventArgs e)
        {
            double vis = double.Parse(visinatb.Text);
            double tez = double.Parse(tezinatb.Text);
            double BMI = tez / (0.01*vis * 0.01*vis);


            if (BMI < 18.5)
            {
                MessageBox.Show("Vas BMI je ispod normale!");
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                MessageBox.Show("Vas BMI je normalan!");
            }
            else if (BMI >= 25 && BMI <= 29.9) 
            {
                MessageBox.Show("Vas BMI je iznad normale");
            }
            else if (BMI >= 30) 
            {
                MessageBox.Show("Gojazni ste!");
            }

        }
    }
}
