using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLApp {
    class Film {
        int id;
        string cim;
        DateTime kiadas;
        int hossz;
        int rendezo_id;

        public Film(int id, string cim, DateTime kiadas, int hossz, int rendezo_id) {
            this.id = id;
            this.Cim = cim;
            this.Kiadas = kiadas;
            this.Hossz = hossz;
            this.Rendezo_id = rendezo_id;
        }

        public int Id { get => id; }
        public string Cim { get => cim; set => cim = value; }
        public DateTime Kiadas { get => kiadas; set => kiadas = value; }
        public int Hossz { get => hossz; set => hossz = value; }
        public int Rendezo_id { get => rendezo_id; set => rendezo_id = value; }

        public override string ToString() {
            return this.Cim;
        }
    }
}
