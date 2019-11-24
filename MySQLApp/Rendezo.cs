using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLApp {
    class Rendezo {
        int id;
        string nev;
        DateTime szuletes;
        string szarmazas;

        public Rendezo(int id, string nev, DateTime szuletes, string szarmazas) {
            this.id = id;
            this.Nev = nev;
            this.Szuletes = szuletes;
            this.Szarmazas = szarmazas;
        }

        public int Id { get => id; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletes { get => szuletes; set => szuletes = value; }
        public string Szarmazas { get => szarmazas; set => szarmazas = value; }

        public override string ToString() {
            return this.nev;
        }
    }
}
