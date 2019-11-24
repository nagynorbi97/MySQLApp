namespace MySQLApp
{
    partial class Form1
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
            this.rendezoList = new System.Windows.Forms.ListBox();
            this.felirat_nev = new System.Windows.Forms.Label();
            this.felirat_szuletes = new System.Windows.Forms.Label();
            this.felirat_szarmazas = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.TextBox();
            this.szarmazas = new System.Windows.Forms.TextBox();
            this.szuletes = new System.Windows.Forms.DateTimePicker();
            this.hozzaad = new System.Windows.Forms.Button();
            this.csoport_felvetel = new System.Windows.Forms.GroupBox();
            this.csoport_torles = new System.Windows.Forms.GroupBox();
            this.torol = new System.Windows.Forms.Button();
            this.rendezo_nev = new System.Windows.Forms.Label();
            this.csoport_rendezo = new System.Windows.Forms.GroupBox();
            this.csoport_filmek = new System.Windows.Forms.GroupBox();
            this.filmList = new System.Windows.Forms.ListBox();
            this.csoport_torles2 = new System.Windows.Forms.GroupBox();
            this.torol2 = new System.Windows.Forms.Button();
            this.film_nev = new System.Windows.Forms.Label();
            this.csoport_felvetel2 = new System.Windows.Forms.GroupBox();
            this.cim = new System.Windows.Forms.TextBox();
            this.hozzaad2 = new System.Windows.Forms.Button();
            this.felirat_cim = new System.Windows.Forms.Label();
            this.kiadas = new System.Windows.Forms.DateTimePicker();
            this.felirat_kiadas = new System.Windows.Forms.Label();
            this.felirat_hossz = new System.Windows.Forms.Label();
            this.hossz = new System.Windows.Forms.NumericUpDown();
            this.csoport_felvetel.SuspendLayout();
            this.csoport_torles.SuspendLayout();
            this.csoport_rendezo.SuspendLayout();
            this.csoport_filmek.SuspendLayout();
            this.csoport_torles2.SuspendLayout();
            this.csoport_felvetel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hossz)).BeginInit();
            this.SuspendLayout();
            // 
            // rendezoList
            // 
            this.rendezoList.FormattingEnabled = true;
            this.rendezoList.Location = new System.Drawing.Point(10, 19);
            this.rendezoList.Name = "rendezoList";
            this.rendezoList.Size = new System.Drawing.Size(153, 238);
            this.rendezoList.TabIndex = 0;
            this.rendezoList.SelectedIndexChanged += new System.EventHandler(this.rendezoList_SelectedIndexChanged);
            // 
            // felirat_nev
            // 
            this.felirat_nev.AutoSize = true;
            this.felirat_nev.Location = new System.Drawing.Point(40, 22);
            this.felirat_nev.Name = "felirat_nev";
            this.felirat_nev.Size = new System.Drawing.Size(30, 13);
            this.felirat_nev.TabIndex = 1;
            this.felirat_nev.Text = "Név:";
            // 
            // felirat_szuletes
            // 
            this.felirat_szuletes.AutoSize = true;
            this.felirat_szuletes.Location = new System.Drawing.Point(20, 56);
            this.felirat_szuletes.Name = "felirat_szuletes";
            this.felirat_szuletes.Size = new System.Drawing.Size(50, 13);
            this.felirat_szuletes.TabIndex = 2;
            this.felirat_szuletes.Text = "Születés:";
            // 
            // felirat_szarmazas
            // 
            this.felirat_szarmazas.AutoSize = true;
            this.felirat_szarmazas.Location = new System.Drawing.Point(9, 88);
            this.felirat_szarmazas.Name = "felirat_szarmazas";
            this.felirat_szarmazas.Size = new System.Drawing.Size(61, 13);
            this.felirat_szarmazas.TabIndex = 3;
            this.felirat_szarmazas.Text = "Származás:";
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(76, 19);
            this.nev.MaxLength = 1000;
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(100, 20);
            this.nev.TabIndex = 4;
            // 
            // szarmazas
            // 
            this.szarmazas.Location = new System.Drawing.Point(76, 85);
            this.szarmazas.MaxLength = 1000;
            this.szarmazas.Name = "szarmazas";
            this.szarmazas.Size = new System.Drawing.Size(100, 20);
            this.szarmazas.TabIndex = 5;
            // 
            // szuletes
            // 
            this.szuletes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.szuletes.Location = new System.Drawing.Point(76, 50);
            this.szuletes.Name = "szuletes";
            this.szuletes.Size = new System.Drawing.Size(100, 20);
            this.szuletes.TabIndex = 6;
            // 
            // hozzaad
            // 
            this.hozzaad.Location = new System.Drawing.Point(76, 121);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(75, 23);
            this.hozzaad.TabIndex = 7;
            this.hozzaad.Text = "Felvétel";
            this.hozzaad.UseVisualStyleBackColor = true;
            this.hozzaad.Click += new System.EventHandler(this.hozzaad_Click);
            // 
            // csoport_felvetel
            // 
            this.csoport_felvetel.Controls.Add(this.nev);
            this.csoport_felvetel.Controls.Add(this.hozzaad);
            this.csoport_felvetel.Controls.Add(this.felirat_nev);
            this.csoport_felvetel.Controls.Add(this.szuletes);
            this.csoport_felvetel.Controls.Add(this.felirat_szuletes);
            this.csoport_felvetel.Controls.Add(this.szarmazas);
            this.csoport_felvetel.Controls.Add(this.felirat_szarmazas);
            this.csoport_felvetel.Location = new System.Drawing.Point(170, 13);
            this.csoport_felvetel.Name = "csoport_felvetel";
            this.csoport_felvetel.Size = new System.Drawing.Size(189, 153);
            this.csoport_felvetel.TabIndex = 8;
            this.csoport_felvetel.TabStop = false;
            this.csoport_felvetel.Text = "Adatfelvétel";
            // 
            // csoport_torles
            // 
            this.csoport_torles.Controls.Add(this.torol);
            this.csoport_torles.Controls.Add(this.rendezo_nev);
            this.csoport_torles.Location = new System.Drawing.Point(170, 173);
            this.csoport_torles.Name = "csoport_torles";
            this.csoport_torles.Size = new System.Drawing.Size(189, 84);
            this.csoport_torles.TabIndex = 9;
            this.csoport_torles.TabStop = false;
            this.csoport_torles.Text = "Törlés";
            // 
            // torol
            // 
            this.torol.Location = new System.Drawing.Point(11, 45);
            this.torol.Name = "torol";
            this.torol.Size = new System.Drawing.Size(75, 23);
            this.torol.TabIndex = 1;
            this.torol.Text = "Törlés";
            this.torol.UseVisualStyleBackColor = true;
            this.torol.Click += new System.EventHandler(this.torol_Click);
            // 
            // rendezo_nev
            // 
            this.rendezo_nev.AutoSize = true;
            this.rendezo_nev.Location = new System.Drawing.Point(11, 20);
            this.rendezo_nev.Name = "rendezo_nev";
            this.rendezo_nev.Size = new System.Drawing.Size(98, 13);
            this.rendezo_nev.TabIndex = 0;
            this.rendezo_nev.Text = "Válassz ki rendezőt";
            // 
            // csoport_rendezo
            // 
            this.csoport_rendezo.Controls.Add(this.rendezoList);
            this.csoport_rendezo.Controls.Add(this.csoport_torles);
            this.csoport_rendezo.Controls.Add(this.csoport_felvetel);
            this.csoport_rendezo.Location = new System.Drawing.Point(7, 2);
            this.csoport_rendezo.Name = "csoport_rendezo";
            this.csoport_rendezo.Size = new System.Drawing.Size(368, 268);
            this.csoport_rendezo.TabIndex = 10;
            this.csoport_rendezo.TabStop = false;
            this.csoport_rendezo.Text = "Rendezők";
            // 
            // csoport_filmek
            // 
            this.csoport_filmek.Controls.Add(this.csoport_torles2);
            this.csoport_filmek.Controls.Add(this.csoport_felvetel2);
            this.csoport_filmek.Controls.Add(this.filmList);
            this.csoport_filmek.Enabled = false;
            this.csoport_filmek.Location = new System.Drawing.Point(381, 2);
            this.csoport_filmek.Name = "csoport_filmek";
            this.csoport_filmek.Size = new System.Drawing.Size(369, 268);
            this.csoport_filmek.TabIndex = 11;
            this.csoport_filmek.TabStop = false;
            this.csoport_filmek.Text = "Filmek";
            // 
            // filmList
            // 
            this.filmList.FormattingEnabled = true;
            this.filmList.Location = new System.Drawing.Point(10, 19);
            this.filmList.Name = "filmList";
            this.filmList.Size = new System.Drawing.Size(153, 238);
            this.filmList.TabIndex = 12;
            this.filmList.SelectedIndexChanged += new System.EventHandler(this.filmList_SelectedIndexChanged);
            // 
            // csoport_torles2
            // 
            this.csoport_torles2.Controls.Add(this.torol2);
            this.csoport_torles2.Controls.Add(this.film_nev);
            this.csoport_torles2.Location = new System.Drawing.Point(170, 173);
            this.csoport_torles2.Name = "csoport_torles2";
            this.csoport_torles2.Size = new System.Drawing.Size(189, 84);
            this.csoport_torles2.TabIndex = 14;
            this.csoport_torles2.TabStop = false;
            this.csoport_torles2.Text = "Törlés";
            // 
            // torol2
            // 
            this.torol2.Location = new System.Drawing.Point(11, 45);
            this.torol2.Name = "torol2";
            this.torol2.Size = new System.Drawing.Size(75, 23);
            this.torol2.TabIndex = 1;
            this.torol2.Text = "Törlés";
            this.torol2.UseVisualStyleBackColor = true;
            this.torol2.Click += new System.EventHandler(this.torol2_Click);
            // 
            // film_nev
            // 
            this.film_nev.AutoSize = true;
            this.film_nev.Location = new System.Drawing.Point(11, 20);
            this.film_nev.Name = "film_nev";
            this.film_nev.Size = new System.Drawing.Size(81, 13);
            this.film_nev.TabIndex = 0;
            this.film_nev.Text = "Válassz ki filmet";
            // 
            // csoport_felvetel2
            // 
            this.csoport_felvetel2.Controls.Add(this.hossz);
            this.csoport_felvetel2.Controls.Add(this.cim);
            this.csoport_felvetel2.Controls.Add(this.hozzaad2);
            this.csoport_felvetel2.Controls.Add(this.felirat_cim);
            this.csoport_felvetel2.Controls.Add(this.kiadas);
            this.csoport_felvetel2.Controls.Add(this.felirat_kiadas);
            this.csoport_felvetel2.Controls.Add(this.felirat_hossz);
            this.csoport_felvetel2.Location = new System.Drawing.Point(170, 13);
            this.csoport_felvetel2.Name = "csoport_felvetel2";
            this.csoport_felvetel2.Size = new System.Drawing.Size(189, 153);
            this.csoport_felvetel2.TabIndex = 13;
            this.csoport_felvetel2.TabStop = false;
            this.csoport_felvetel2.Text = "Adatfelvétel";
            // 
            // cim
            // 
            this.cim.Location = new System.Drawing.Point(76, 19);
            this.cim.MaxLength = 1000;
            this.cim.Name = "cim";
            this.cim.Size = new System.Drawing.Size(100, 20);
            this.cim.TabIndex = 4;
            // 
            // hozzaad2
            // 
            this.hozzaad2.Location = new System.Drawing.Point(76, 121);
            this.hozzaad2.Name = "hozzaad2";
            this.hozzaad2.Size = new System.Drawing.Size(75, 23);
            this.hozzaad2.TabIndex = 7;
            this.hozzaad2.Text = "Felvétel";
            this.hozzaad2.UseVisualStyleBackColor = true;
            this.hozzaad2.Click += new System.EventHandler(this.hozzaad2_Click);
            // 
            // felirat_cim
            // 
            this.felirat_cim.AutoSize = true;
            this.felirat_cim.Location = new System.Drawing.Point(41, 22);
            this.felirat_cim.Name = "felirat_cim";
            this.felirat_cim.Size = new System.Drawing.Size(29, 13);
            this.felirat_cim.TabIndex = 1;
            this.felirat_cim.Text = "Cím:";
            // 
            // kiadas
            // 
            this.kiadas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kiadas.Location = new System.Drawing.Point(76, 50);
            this.kiadas.Name = "kiadas";
            this.kiadas.Size = new System.Drawing.Size(100, 20);
            this.kiadas.TabIndex = 6;
            // 
            // felirat_kiadas
            // 
            this.felirat_kiadas.AutoSize = true;
            this.felirat_kiadas.Location = new System.Drawing.Point(28, 56);
            this.felirat_kiadas.Name = "felirat_kiadas";
            this.felirat_kiadas.Size = new System.Drawing.Size(42, 13);
            this.felirat_kiadas.TabIndex = 2;
            this.felirat_kiadas.Text = "Kiadás:";
            // 
            // felirat_hossz
            // 
            this.felirat_hossz.AutoSize = true;
            this.felirat_hossz.Location = new System.Drawing.Point(31, 88);
            this.felirat_hossz.Name = "felirat_hossz";
            this.felirat_hossz.Size = new System.Drawing.Size(39, 13);
            this.felirat_hossz.TabIndex = 3;
            this.felirat_hossz.Text = "Hossz:";
            // 
            // hossz
            // 
            this.hossz.Location = new System.Drawing.Point(76, 86);
            this.hossz.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.hossz.Name = "hossz";
            this.hossz.Size = new System.Drawing.Size(100, 20);
            this.hossz.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 278);
            this.Controls.Add(this.csoport_filmek);
            this.Controls.Add(this.csoport_rendezo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Rendezőkezelő";
            this.csoport_felvetel.ResumeLayout(false);
            this.csoport_felvetel.PerformLayout();
            this.csoport_torles.ResumeLayout(false);
            this.csoport_torles.PerformLayout();
            this.csoport_rendezo.ResumeLayout(false);
            this.csoport_filmek.ResumeLayout(false);
            this.csoport_torles2.ResumeLayout(false);
            this.csoport_torles2.PerformLayout();
            this.csoport_felvetel2.ResumeLayout(false);
            this.csoport_felvetel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hossz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox rendezoList;
        private System.Windows.Forms.Label felirat_nev;
        private System.Windows.Forms.Label felirat_szuletes;
        private System.Windows.Forms.Label felirat_szarmazas;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.TextBox szarmazas;
        private System.Windows.Forms.DateTimePicker szuletes;
        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.GroupBox csoport_felvetel;
        private System.Windows.Forms.GroupBox csoport_torles;
        private System.Windows.Forms.Label rendezo_nev;
        private System.Windows.Forms.Button torol;
        private System.Windows.Forms.GroupBox csoport_rendezo;
        private System.Windows.Forms.GroupBox csoport_filmek;
        private System.Windows.Forms.ListBox filmList;
        private System.Windows.Forms.GroupBox csoport_torles2;
        private System.Windows.Forms.Button torol2;
        private System.Windows.Forms.Label film_nev;
        private System.Windows.Forms.GroupBox csoport_felvetel2;
        private System.Windows.Forms.TextBox cim;
        private System.Windows.Forms.Button hozzaad2;
        private System.Windows.Forms.Label felirat_cim;
        private System.Windows.Forms.DateTimePicker kiadas;
        private System.Windows.Forms.Label felirat_kiadas;
        private System.Windows.Forms.Label felirat_hossz;
        private System.Windows.Forms.NumericUpDown hossz;
    }
}

