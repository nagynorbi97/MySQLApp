using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQLApp {
    public partial class Form1 : Form {
        MySqlConnection conn;
        public Form1() {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Port=3307; Database=filmdb; Uid=root; Pwd=;");
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SET CHARACTER SET 'utf8';";
            cmd.ExecuteNonQuery();
            RendezoLista();
        }
        void RendezoLista() {
            rendezoList.Items.Clear();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM rendezok ORDER BY nev;";
            using(var reader = cmd.ExecuteReader()) {
                while (reader.Read()) {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var szuletes = reader.GetDateTime("szuletes");
                    var szarmazas = reader.GetString("szarmazas");
                    var rendezo = new Rendezo(id, nev, szuletes, szarmazas);
                    rendezoList.Items.Add(rendezo);
                }
            }
        }

        private void hozzaad_Click(object sender, EventArgs e) {
            if (nev.Text.Length > 5 && szuletes.Text.Length > 5 && szarmazas.Text.Length > 5) {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO rendezok (nev, szuletes, szarmazas) VALUES (@nev, @szuletes, @szarmazas)";
                cmd.Parameters.AddWithValue("@nev", nev.Text);
                cmd.Parameters.AddWithValue("@szuletes", szuletes.Text);
                cmd.Parameters.AddWithValue("@szarmazas", szarmazas.Text);
                cmd.ExecuteNonQuery();
                nev.Text = "";
                szuletes.Text = "";
                szarmazas.Text = "";
                RendezoLista();
            }
        }

        private void rendezoList_SelectedIndexChanged(object sender, EventArgs e) {
            if (rendezoList.SelectedIndex>-1) {
                var rendezo = (Rendezo)rendezoList.SelectedItem;
                rendezo_nev.Text = rendezo.Nev;
                csoport_filmek.Enabled = true;
                cim.Text = "";
                kiadas.Text = "";
                hossz.Text = "";
                FilmLista();
            } else {
                csoport_filmek.Enabled = false;
                cim.Text = "";
                kiadas.Text = "";
                hossz.Text = "";
                filmList.Items.Clear();
            }
        }

        private void torol_Click(object sender, EventArgs e) {
            if (rendezoList.SelectedIndex > -1) {
                var rendezo = (Rendezo)rendezoList.SelectedItem;
                var chck = conn.CreateCommand();
                chck.CommandText = @"SELECT COUNT(id) FROM filmek WHERE rendezo_id=@rendezo_id";
                chck.Parameters.AddWithValue("@rendezo_id", rendezo.Id);
                long film_db = (long)chck.ExecuteScalar();
                if (film_db < 1) {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"DELETE FROM rendezok WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", rendezo.Id);
                    cmd.ExecuteNonQuery();
                    rendezo_nev.Text = "Válassz ki rendezőt";
                    RendezoLista();
                } else {
                    MessageBox.Show("A kiválasztott rendezőt nem lehet törölni, mert van még filmje.", "Sikertelen törlés");
                }
            }
        }

        void FilmLista() {
            filmList.Items.Clear();
            var rendezo = (Rendezo)rendezoList.SelectedItem;
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM filmek WHERE rendezo_id=@rendezo_id ORDER BY cim;";
            cmd.Parameters.AddWithValue("@rendezo_id", rendezo.Id);
            using (var reader = cmd.ExecuteReader()) {
                while (reader.Read()) {
                    var id = reader.GetInt32("id");
                    var cim = reader.GetString("cim");
                    var kiadas = reader.GetDateTime("kiadasi_nap");
                    var hossz = reader.GetInt32("hossz");
                    var rendezo_id = reader.GetInt32("rendezo_id");
                    var film = new Film(id, cim, kiadas, hossz, rendezo_id);
                    filmList.Items.Add(film);
                }
            }
        }

        private void hozzaad2_Click(object sender, EventArgs e) {
            if (cim.Text.Length > 5 && kiadas.Text.Length > 5 && hossz.Text.Length > 0) {
                var rendezo = (Rendezo)rendezoList.SelectedItem;
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO filmek (cim, kiadasi_nap, hossz, rendezo_id) VALUES (@cim, @kiadas, @hossz, @rendezo_id)";
                cmd.Parameters.AddWithValue("@cim", cim.Text);
                cmd.Parameters.AddWithValue("@kiadas", kiadas.Text);
                cmd.Parameters.AddWithValue("@hossz", hossz.Text);
                cmd.Parameters.AddWithValue("@rendezo_id", rendezo.Id);
                cmd.ExecuteNonQuery();
                cim.Text = "";
                kiadas.Text = "";
                hossz.Text = "";
                FilmLista();
            }
        }

        private void filmList_SelectedIndexChanged(object sender, EventArgs e) {
            if (filmList.SelectedIndex > -1) {
                var film = (Film)filmList.SelectedItem;
                film_nev.Text = film.Cim;
            }
        }

        private void torol2_Click(object sender, EventArgs e) {
            if (filmList.SelectedIndex > -1) {
                var film = (Film)filmList.SelectedItem;
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM filmek WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", film.Id);
                cmd.ExecuteNonQuery();
                film_nev.Text = "Válassz ki filmet";
                FilmLista();
            }
        }
    }
}
