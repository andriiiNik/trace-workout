namespace CassandraWinFormsSample
{
    partial class Dnevni_unos_hrane
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.namirnicatb = new MetroFramework.Controls.MetroTextBox();
            this.kcalnamirnicetb = new MetroFramework.Controls.MetroTextBox();
            this.dorucakchb = new MetroFramework.Controls.MetroCheckBox();
            this.rucakchb = new MetroFramework.Controls.MetroCheckBox();
            this.vecerachb = new MetroFramework.Controls.MetroCheckBox();
            this.uzinachb = new MetroFramework.Controls.MetroCheckBox();
            this.dodajduhbtn = new MetroFramework.Controls.MetroButton();
            this.obrisiduhbtn = new MetroFramework.Controls.MetroButton();
            this.procitajSVEbtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.jmbgtxtb = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 143);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Datum:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 186);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Namirnica:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 234);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(181, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Kalorijska vrednost namirnice:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 276);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Obrok:";
            // 
            // namirnicatb
            // 
            this.namirnicatb.Location = new System.Drawing.Point(101, 186);
            this.namirnicatb.Name = "namirnicatb";
            this.namirnicatb.Size = new System.Drawing.Size(75, 23);
            this.namirnicatb.TabIndex = 7;
            // 
            // kcalnamirnicetb
            // 
            this.kcalnamirnicetb.Location = new System.Drawing.Point(210, 234);
            this.kcalnamirnicetb.Name = "kcalnamirnicetb";
            this.kcalnamirnicetb.Size = new System.Drawing.Size(75, 23);
            this.kcalnamirnicetb.TabIndex = 8;
            // 
            // dorucakchb
            // 
            this.dorucakchb.AutoSize = true;
            this.dorucakchb.Location = new System.Drawing.Point(101, 279);
            this.dorucakchb.Name = "dorucakchb";
            this.dorucakchb.Size = new System.Drawing.Size(67, 15);
            this.dorucakchb.TabIndex = 9;
            this.dorucakchb.Text = "Dorucak";
            this.dorucakchb.UseVisualStyleBackColor = true;
            this.dorucakchb.CheckedChanged += new System.EventHandler(this.dorucakchb_CheckedChanged);
            // 
            // rucakchb
            // 
            this.rucakchb.AutoSize = true;
            this.rucakchb.Location = new System.Drawing.Point(101, 310);
            this.rucakchb.Name = "rucakchb";
            this.rucakchb.Size = new System.Drawing.Size(55, 15);
            this.rucakchb.TabIndex = 10;
            this.rucakchb.Text = "Rucak";
            this.rucakchb.UseVisualStyleBackColor = true;
            this.rucakchb.CheckedChanged += new System.EventHandler(this.rucakchb_CheckedChanged);
            // 
            // vecerachb
            // 
            this.vecerachb.AutoSize = true;
            this.vecerachb.Location = new System.Drawing.Point(101, 340);
            this.vecerachb.Name = "vecerachb";
            this.vecerachb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.vecerachb.Size = new System.Drawing.Size(57, 15);
            this.vecerachb.TabIndex = 11;
            this.vecerachb.Text = "Vecera";
            this.vecerachb.UseVisualStyleBackColor = true;
            this.vecerachb.CheckedChanged += new System.EventHandler(this.vecerachb_CheckedChanged);
            // 
            // uzinachb
            // 
            this.uzinachb.AutoSize = true;
            this.uzinachb.Location = new System.Drawing.Point(101, 371);
            this.uzinachb.Name = "uzinachb";
            this.uzinachb.Size = new System.Drawing.Size(52, 15);
            this.uzinachb.TabIndex = 12;
            this.uzinachb.Text = "Uzina";
            this.uzinachb.UseVisualStyleBackColor = true;
            this.uzinachb.CheckedChanged += new System.EventHandler(this.uzinachb_CheckedChanged);
            // 
            // dodajduhbtn
            // 
            this.dodajduhbtn.Location = new System.Drawing.Point(358, 172);
            this.dodajduhbtn.Name = "dodajduhbtn";
            this.dodajduhbtn.Size = new System.Drawing.Size(124, 33);
            this.dodajduhbtn.TabIndex = 13;
            this.dodajduhbtn.Text = "Dodaj u bazu";
            this.dodajduhbtn.Click += new System.EventHandler(this.dodajduhbtn_Click);
            // 
            // obrisiduhbtn
            // 
            this.obrisiduhbtn.Location = new System.Drawing.Point(358, 211);
            this.obrisiduhbtn.Name = "obrisiduhbtn";
            this.obrisiduhbtn.Size = new System.Drawing.Size(124, 31);
            this.obrisiduhbtn.TabIndex = 14;
            this.obrisiduhbtn.Text = "Obrisi iz baze";
            this.obrisiduhbtn.Click += new System.EventHandler(this.obrisiduhbtn_Click);
            // 
            // procitajSVEbtn
            // 
            this.procitajSVEbtn.Location = new System.Drawing.Point(323, 346);
            this.procitajSVEbtn.Name = "procitajSVEbtn";
            this.procitajSVEbtn.Size = new System.Drawing.Size(159, 28);
            this.procitajSVEbtn.TabIndex = 17;
            this.procitajSVEbtn.Text = "Prikazi sve";
            this.procitajSVEbtn.Click += new System.EventHandler(this.procitajSVEbtn_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(323, 279);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "Prikaz:";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(85, 143);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 19;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Jmbg:";
            // 
            // jmbgtxtb
            // 
            this.jmbgtxtb.Location = new System.Drawing.Point(101, 97);
            this.jmbgtxtb.Name = "jmbgtxtb";
            this.jmbgtxtb.Size = new System.Drawing.Size(119, 23);
            this.jmbgtxtb.TabIndex = 21;
            // 
            // Dnevni_unos_hrane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.jmbgtxtb);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.procitajSVEbtn);
            this.Controls.Add(this.obrisiduhbtn);
            this.Controls.Add(this.dodajduhbtn);
            this.Controls.Add(this.uzinachb);
            this.Controls.Add(this.vecerachb);
            this.Controls.Add(this.rucakchb);
            this.Controls.Add(this.dorucakchb);
            this.Controls.Add(this.kcalnamirnicetb);
            this.Controls.Add(this.namirnicatb);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Name = "Dnevni_unos_hrane";
            this.Text = "Dnevni_unos_hrane";
            this.Load += new System.EventHandler(this.Dnevni_unos_hrane_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox namirnicatb;
        private MetroFramework.Controls.MetroTextBox kcalnamirnicetb;
        private MetroFramework.Controls.MetroCheckBox dorucakchb;
        private MetroFramework.Controls.MetroCheckBox rucakchb;
        private MetroFramework.Controls.MetroCheckBox vecerachb;
        private MetroFramework.Controls.MetroCheckBox uzinachb;
        private MetroFramework.Controls.MetroButton dodajduhbtn;
        private MetroFramework.Controls.MetroButton obrisiduhbtn;
        private MetroFramework.Controls.MetroButton procitajSVEbtn;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DateTimePicker date;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox jmbgtxtb;
    }
}