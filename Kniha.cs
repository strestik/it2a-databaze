using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it2a_databaze
{
    class Kniha
    {
        public string Nazev { get; set; }
        public string Autor { get; set; }
        public int RokVydani { get; set; }
        public string Zanr { get; set; }
        public string Podzanr { get; set; }
        public int Ks { get; set; }
        public int Id { get; set; }
        public string ISBN { get; set; }
        public Kniha(string nazev, string autor, int rokVydani, string zanr, string podzanr, int ks, int id, string isbn)
        {
            Nazev = nazev;
            Autor = autor;
            RokVydani = rokVydani;
            Zanr = zanr;
            Podzanr = podzanr;
            Ks = ks;
            Id = id;
            ISBN = isbn;
        }
    }
}
