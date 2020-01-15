namespace CassandraWinFormsSample
{
    partial class Dnevni_unos_pica
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.vrstapcb = new MetroFramework.Controls.MetroComboBox();
            this.dodajbtn = new MetroFramework.Controls.MetroButton();
            this.obrisibtn = new MetroFramework.Controls.MetroButton();
            this.prikazisvebtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.kalorijepicatb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.jmbgtb = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Datum:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 193);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Vrsta pica:";
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(31, 142);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(200, 20);
            this.datum.TabIndex = 5;
            this.datum.ValueChanged += new System.EventHandler(this.datum_ValueChanged);
            // 
            // vrstapcb
            // 
            this.vrstapcb.FormattingEnabled = true;
            this.vrstapcb.ItemHeight = 23;
            this.vrstapcb.Items.AddRange(new object[] {
            "negazirani sok",
            "voda",
            "gazirani sok",
            "pivo",
            "belo vino",
            "crno vino",
            "cedevita",
            "cedjeno voce",
            "bezalkoholni koktel",
            "koktel sa alkoholom",
            "rum",
            "vinjak",
            "vodka",
            "tekila"});
            this.vrstapcb.Location = new System.Drawing.Point(110, 193);
            this.vrstapcb.Name = "vrstapcb";
            this.vrstapcb.Size = new System.Drawing.Size(121, 29);
            this.vrstapcb.TabIndex = 7;
            this.vrstapcb.SelectedIndexChanged += new System.EventHandler(this.vrstapcb_SelectedIndexChanged);
            // 
            // dodajbtn
            // 
            this.dodajbtn.Location = new System.Drawing.Point(334, 63);
            this.dodajbtn.Name = "dodajbtn";
            this.dodajbtn.Size = new System.Drawing.Size(158, 23);
            this.dodajbtn.TabIndex = 8;
            this.dodajbtn.Text = "Dodaj u bazu";
            this.dodajbtn.Click += new System.EventHandler(this.dodajbtn_Click);
            // 
            // obrisibtn
            // 
            this.obrisibtn.Location = new System.Drawing.Point(334, 106);
            this.obrisibtn.Name = "obrisibtn";
            this.obrisibtn.Size = new System.Drawing.Size(158, 23);
            this.obrisibtn.TabIndex = 9;
            this.obrisibtn.Text = "Obrsi iz baze";
            this.obrisibtn.Click += new System.EventHandler(this.obrisibtn_Click);
            // 
            // prikazisvebtn
            // 
            this.prikazisvebtn.Location = new System.Drawing.Point(334, 189);
            this.prikazisvebtn.Name = "prikazisvebtn";
            this.prikazisvebtn.Size = new System.Drawing.Size(158, 23);
            this.prikazisvebtn.TabIndex = 11;
            this.prikazisvebtn.Text = "Prikazi sve";
            this.prikazisvebtn.Click += new System.EventHandler(this.prikazisvebtn_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 249);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(148, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Kalorijska vrednost pica:";
            // 
            // kalorijepicatb
            // 
            this.kalorijepicatb.Location = new System.Drawing.Point(177, 251);
            this.kalorijepicatb.Name = "kalorijepicatb";
            this.kalorijepicatb.Size = new System.Drawing.Size(99, 23);
            this.kalorijepicatb.TabIndex = 13;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Jmbg:";
            // 
            // jmbgtb
            // 
            this.jmbgtb.Location = new System.Drawing.Point(98, 72);
            this.jmbgtb.Name = "jmbgtb";
            this.jmbgtb.Size = new System.Drawing.Size(133, 23);
            this.jmbgtb.TabIndex = 15;
            // 
            // Dnevni_unos_pica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 297);
            this.Controls.Add(this.jmbgtb);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.kalorijepicatb);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.prikazisvebtn);
            this.Controls.Add(this.obrisibtn);
            this.Controls.Add(this.dodajbtn);
            this.Controls.Add(this.vrstapcb);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Name = "Dnevni_unos_pica";
            this.Text = "Dnevni_unos_pica";
            this.Load += new System.EventHandler(this.Dnevni_unos_pica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker datum;
        private MetroFramework.Controls.MetroComboBox vrstapcb;
        private MetroFramework.Controls.MetroButton dodajbtn;
        private MetroFramework.Controls.MetroButton obrisibtn;
        private MetroFramework.Controls.MetroButton prikazisvebtn;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox kalorijepicatb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox jmbgtb;
    }
}