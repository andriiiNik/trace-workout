namespace CassandraWinFormsSample
{
    partial class FizickaAktivnost
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.setanjerb = new MetroFramework.Controls.MetroRadioButton();
            this.brzohrb = new MetroFramework.Controls.MetroRadioButton();
            this.trcanjerb = new MetroFramework.Controls.MetroRadioButton();
            this.kmtb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.vremetrajanjatb = new MetroFramework.Controls.MetroTextBox();
            this.dodajbtn = new MetroFramework.Controls.MetroButton();
            this.izbrsibtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.jmbgtxtbox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 117);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Aktivnost:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 213);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Predjeni kilometri:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(302, 121);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Datum:";
            // 
            // setanjerb
            // 
            this.setanjerb.AutoSize = true;
            this.setanjerb.Location = new System.Drawing.Point(106, 121);
            this.setanjerb.Name = "setanjerb";
            this.setanjerb.Size = new System.Drawing.Size(61, 15);
            this.setanjerb.TabIndex = 4;
            this.setanjerb.TabStop = true;
            this.setanjerb.Text = "Setanje";
            this.setanjerb.UseVisualStyleBackColor = true;
            this.setanjerb.CheckedChanged += new System.EventHandler(this.setanjerb_CheckedChanged);
            // 
            // brzohrb
            // 
            this.brzohrb.AutoSize = true;
            this.brzohrb.Location = new System.Drawing.Point(106, 150);
            this.brzohrb.Name = "brzohrb";
            this.brzohrb.Size = new System.Drawing.Size(92, 15);
            this.brzohrb.TabIndex = 5;
            this.brzohrb.TabStop = true;
            this.brzohrb.Text = "Brzo hodanje";
            this.brzohrb.UseVisualStyleBackColor = true;
            this.brzohrb.CheckedChanged += new System.EventHandler(this.brzohrb_CheckedChanged);
            // 
            // trcanjerb
            // 
            this.trcanjerb.AutoSize = true;
            this.trcanjerb.Location = new System.Drawing.Point(106, 179);
            this.trcanjerb.Name = "trcanjerb";
            this.trcanjerb.Size = new System.Drawing.Size(60, 15);
            this.trcanjerb.TabIndex = 6;
            this.trcanjerb.TabStop = true;
            this.trcanjerb.Text = "Trcanje";
            this.trcanjerb.UseVisualStyleBackColor = true;
            this.trcanjerb.CheckedChanged += new System.EventHandler(this.trcanjerb_CheckedChanged);
            // 
            // kmtb
            // 
            this.kmtb.Location = new System.Drawing.Point(155, 213);
            this.kmtb.Name = "kmtb";
            this.kmtb.Size = new System.Drawing.Size(75, 23);
            this.kmtb.TabIndex = 7;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(285, 77);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(154, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Vreme trajanja aktivnosti:";
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(302, 150);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(200, 20);
            this.datum.TabIndex = 10;
            // 
            // vremetrajanjatb
            // 
            this.vremetrajanjatb.Location = new System.Drawing.Point(457, 77);
            this.vremetrajanjatb.Name = "vremetrajanjatb";
            this.vremetrajanjatb.Size = new System.Drawing.Size(75, 23);
            this.vremetrajanjatb.TabIndex = 11;
            // 
            // dodajbtn
            // 
            this.dodajbtn.Location = new System.Drawing.Point(361, 213);
            this.dodajbtn.Name = "dodajbtn";
            this.dodajbtn.Size = new System.Drawing.Size(134, 23);
            this.dodajbtn.TabIndex = 12;
            this.dodajbtn.Text = "Dodaj u bazu";
            this.dodajbtn.Click += new System.EventHandler(this.dodajbtn_Click);
            // 
            // izbrsibtn
            // 
            this.izbrsibtn.Location = new System.Drawing.Point(361, 257);
            this.izbrsibtn.Name = "izbrsibtn";
            this.izbrsibtn.Size = new System.Drawing.Size(134, 23);
            this.izbrsibtn.TabIndex = 13;
            this.izbrsibtn.Text = "Izbrisi iz baze";
            this.izbrsibtn.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 77);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Jmbg:";
            // 
            // jmbgtxtbox
            // 
            this.jmbgtxtbox.Location = new System.Drawing.Point(88, 77);
            this.jmbgtxtbox.Name = "jmbgtxtbox";
            this.jmbgtxtbox.Size = new System.Drawing.Size(131, 23);
            this.jmbgtxtbox.TabIndex = 15;
            // 
            // FizickaAktivnost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 347);
            this.Controls.Add(this.jmbgtxtbox);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.izbrsibtn);
            this.Controls.Add(this.dodajbtn);
            this.Controls.Add(this.vremetrajanjatb);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.kmtb);
            this.Controls.Add(this.trcanjerb);
            this.Controls.Add(this.brzohrb);
            this.Controls.Add(this.setanjerb);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FizickaAktivnost";
            this.Text = "FizickaAktivnost";
            this.Load += new System.EventHandler(this.Fizicka_aktivnost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroRadioButton setanjerb;
        private MetroFramework.Controls.MetroRadioButton brzohrb;
        private MetroFramework.Controls.MetroRadioButton trcanjerb;
        private MetroFramework.Controls.MetroTextBox kmtb;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DateTimePicker datum;
        private MetroFramework.Controls.MetroTextBox vremetrajanjatb;
        private MetroFramework.Controls.MetroButton dodajbtn;
        private MetroFramework.Controls.MetroButton izbrsibtn;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox jmbgtxtbox;
    }
}