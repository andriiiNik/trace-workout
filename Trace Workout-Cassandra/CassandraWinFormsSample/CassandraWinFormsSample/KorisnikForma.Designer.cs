namespace CassandraWinFormsSample
{
    partial class KorisnikForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.muskirb = new MetroFramework.Controls.MetroRadioButton();
            this.zenskirb = new MetroFramework.Controls.MetroRadioButton();
            this.imetb = new MetroFramework.Controls.MetroTextBox();
            this.prezimetb = new MetroFramework.Controls.MetroTextBox();
            this.jmbgtb = new MetroFramework.Controls.MetroTextBox();
            this.tezinatb = new MetroFramework.Controls.MetroTextBox();
            this.visinatb = new MetroFramework.Controls.MetroTextBox();
            this.godinetb = new MetroFramework.Controls.MetroTextBox();
            this.dodajkbtn = new MetroFramework.Controls.MetroButton();
            this.ucitajpbtn = new MetroFramework.Controls.MetroButton();
            this.obrisibtn = new MetroFramework.Controls.MetroButton();
            this.izracunajBMI = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(34, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ime:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Prezime:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(33, 172);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "JMBG:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(33, 220);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Tezina:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(33, 270);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Visina:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(33, 331);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(99, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Godine starosti:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.ForeColor = System.Drawing.Color.Coral;
            this.metroLabel7.Location = new System.Drawing.Point(370, 122);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(30, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Pol:";
            // 
            // muskirb
            // 
            this.muskirb.AutoSize = true;
            this.muskirb.Location = new System.Drawing.Point(425, 126);
            this.muskirb.Name = "muskirb";
            this.muskirb.Size = new System.Drawing.Size(55, 15);
            this.muskirb.TabIndex = 7;
            this.muskirb.TabStop = true;
            this.muskirb.Text = "Muski";
            this.muskirb.UseVisualStyleBackColor = true;
            this.muskirb.CheckedChanged += new System.EventHandler(this.muskirb_CheckedChanged);
            // 
            // zenskirb
            // 
            this.zenskirb.AutoSize = true;
            this.zenskirb.Location = new System.Drawing.Point(423, 158);
            this.zenskirb.Name = "zenskirb";
            this.zenskirb.Size = new System.Drawing.Size(57, 15);
            this.zenskirb.TabIndex = 8;
            this.zenskirb.TabStop = true;
            this.zenskirb.Text = "Zenski";
            this.zenskirb.UseVisualStyleBackColor = true;
            this.zenskirb.CheckedChanged += new System.EventHandler(this.zenskirb_CheckedChanged);
            // 
            // imetb
            // 
            this.imetb.Location = new System.Drawing.Point(103, 77);
            this.imetb.Name = "imetb";
            this.imetb.Size = new System.Drawing.Size(142, 23);
            this.imetb.TabIndex = 9;
            // 
            // prezimetb
            // 
            this.prezimetb.Location = new System.Drawing.Point(103, 117);
            this.prezimetb.Name = "prezimetb";
            this.prezimetb.Size = new System.Drawing.Size(142, 23);
            this.prezimetb.TabIndex = 10;
            // 
            // jmbgtb
            // 
            this.jmbgtb.Location = new System.Drawing.Point(103, 172);
            this.jmbgtb.Name = "jmbgtb";
            this.jmbgtb.Size = new System.Drawing.Size(142, 23);
            this.jmbgtb.TabIndex = 11;
            this.jmbgtb.Click += new System.EventHandler(this.jmbgtb_Click);
            // 
            // tezinatb
            // 
            this.tezinatb.Location = new System.Drawing.Point(103, 215);
            this.tezinatb.Name = "tezinatb";
            this.tezinatb.Size = new System.Drawing.Size(142, 23);
            this.tezinatb.TabIndex = 12;
            // 
            // visinatb
            // 
            this.visinatb.Location = new System.Drawing.Point(103, 265);
            this.visinatb.Name = "visinatb";
            this.visinatb.Size = new System.Drawing.Size(142, 23);
            this.visinatb.TabIndex = 13;
            // 
            // godinetb
            // 
            this.godinetb.Location = new System.Drawing.Point(141, 326);
            this.godinetb.Name = "godinetb";
            this.godinetb.Size = new System.Drawing.Size(104, 23);
            this.godinetb.TabIndex = 14;
            // 
            // dodajkbtn
            // 
            this.dodajkbtn.Location = new System.Drawing.Point(339, 215);
            this.dodajkbtn.Name = "dodajkbtn";
            this.dodajkbtn.Size = new System.Drawing.Size(162, 23);
            this.dodajkbtn.TabIndex = 15;
            this.dodajkbtn.Text = "Dodaj korisnika";
            this.dodajkbtn.Click += new System.EventHandler(this.dodajkbtn_Click);
            // 
            // ucitajpbtn
            // 
            this.ucitajpbtn.Location = new System.Drawing.Point(339, 265);
            this.ucitajpbtn.Name = "ucitajpbtn";
            this.ucitajpbtn.Size = new System.Drawing.Size(162, 24);
            this.ucitajpbtn.TabIndex = 16;
            this.ucitajpbtn.Text = "Ucitaj podatke o korisniku";
            this.ucitajpbtn.Click += new System.EventHandler(this.ucitajpbtn_Click);
            // 
            // obrisibtn
            // 
            this.obrisibtn.Location = new System.Drawing.Point(339, 315);
            this.obrisibtn.Name = "obrisibtn";
            this.obrisibtn.Size = new System.Drawing.Size(162, 23);
            this.obrisibtn.TabIndex = 17;
            this.obrisibtn.Text = "Obrisi korisnika";
            this.obrisibtn.Click += new System.EventHandler(this.obrisibtn_Click);
            // 
            // izracunajBMI
            // 
            this.izracunajBMI.Location = new System.Drawing.Point(339, 77);
            this.izracunajBMI.Name = "izracunajBMI";
            this.izracunajBMI.Size = new System.Drawing.Size(162, 23);
            this.izracunajBMI.TabIndex = 18;
            this.izracunajBMI.Text = "Izracunaj BMI";
            this.izracunajBMI.Click += new System.EventHandler(this.izracunajBMI_Click);
            // 
            // KorisnikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 380);
            this.Controls.Add(this.izracunajBMI);
            this.Controls.Add(this.obrisibtn);
            this.Controls.Add(this.ucitajpbtn);
            this.Controls.Add(this.dodajkbtn);
            this.Controls.Add(this.godinetb);
            this.Controls.Add(this.visinatb);
            this.Controls.Add(this.tezinatb);
            this.Controls.Add(this.jmbgtb);
            this.Controls.Add(this.prezimetb);
            this.Controls.Add(this.imetb);
            this.Controls.Add(this.zenskirb);
            this.Controls.Add(this.muskirb);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "KorisnikForma";
            this.Text = "Korisnik";
            this.Load += new System.EventHandler(this.Korisnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroRadioButton muskirb;
        private MetroFramework.Controls.MetroRadioButton zenskirb;
        private MetroFramework.Controls.MetroTextBox imetb;
        private MetroFramework.Controls.MetroTextBox prezimetb;
        private MetroFramework.Controls.MetroTextBox jmbgtb;
        private MetroFramework.Controls.MetroTextBox tezinatb;
        private MetroFramework.Controls.MetroTextBox visinatb;
        private MetroFramework.Controls.MetroTextBox godinetb;
        private MetroFramework.Controls.MetroButton dodajkbtn;
        private MetroFramework.Controls.MetroButton ucitajpbtn;
        private MetroFramework.Controls.MetroButton obrisibtn;
        private MetroFramework.Controls.MetroButton izracunajBMI;
    }
}