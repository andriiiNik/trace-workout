namespace CassandraWinFormsSample
{
    partial class Glavna
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
            this.dodajkorisnikabtn = new MetroFramework.Controls.MetroButton();
            this.dodajdupbtn = new MetroFramework.Controls.MetroButton();
            this.dodajduhbtn = new MetroFramework.Controls.MetroButton();
            this.dodajfabtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // dodajkorisnikabtn
            // 
            this.dodajkorisnikabtn.Location = new System.Drawing.Point(109, 80);
            this.dodajkorisnikabtn.Name = "dodajkorisnikabtn";
            this.dodajkorisnikabtn.Size = new System.Drawing.Size(197, 63);
            this.dodajkorisnikabtn.TabIndex = 0;
            this.dodajkorisnikabtn.Text = "Dodaj korisnika";
            this.dodajkorisnikabtn.Click += new System.EventHandler(this.dodajkorisnikabtn_Click);
            // 
            // dodajdupbtn
            // 
            this.dodajdupbtn.Location = new System.Drawing.Point(391, 80);
            this.dodajdupbtn.Name = "dodajdupbtn";
            this.dodajdupbtn.Size = new System.Drawing.Size(205, 63);
            this.dodajdupbtn.TabIndex = 1;
            this.dodajdupbtn.Text = "Dodaj dnevni unos pica";
            this.dodajdupbtn.Click += new System.EventHandler(this.dodajdupbtn_Click);
            // 
            // dodajduhbtn
            // 
            this.dodajduhbtn.Location = new System.Drawing.Point(109, 234);
            this.dodajduhbtn.Name = "dodajduhbtn";
            this.dodajduhbtn.Size = new System.Drawing.Size(197, 58);
            this.dodajduhbtn.TabIndex = 2;
            this.dodajduhbtn.Text = "Dodaj dnevni unos hrane";
            this.dodajduhbtn.Click += new System.EventHandler(this.dodajduhbtn_Click);
            // 
            // dodajfabtn
            // 
            this.dodajfabtn.Location = new System.Drawing.Point(391, 234);
            this.dodajfabtn.Name = "dodajfabtn";
            this.dodajfabtn.Size = new System.Drawing.Size(214, 58);
            this.dodajfabtn.TabIndex = 3;
            this.dodajfabtn.Text = "Dodaj fizicku aktivnost";
            this.dodajfabtn.Click += new System.EventHandler(this.dodajfabtn_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dodajfabtn);
            this.Controls.Add(this.dodajduhbtn);
            this.Controls.Add(this.dodajdupbtn);
            this.Controls.Add(this.dodajkorisnikabtn);
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton dodajkorisnikabtn;
        private MetroFramework.Controls.MetroButton dodajdupbtn;
        private MetroFramework.Controls.MetroButton dodajduhbtn;
        private MetroFramework.Controls.MetroButton dodajfabtn;
    }
}