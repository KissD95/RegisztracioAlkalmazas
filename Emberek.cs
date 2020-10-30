using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisztracioAlkalmazas
{
    class Emberek
    {
        string nev;
        string nem;
        string szuldatum;
        string hobbi;

        public Emberek(string nev, string nem, string szuldatum, string hobbi)
        {
            this.Nev = nev;
            this.Nem = nem;
            this.Szuldatum = szuldatum;
            this.Hobbi = hobbi;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Nem { get => nem; set => nem = value; }
        public string Szuldatum { get => szuldatum; set => szuldatum = value; }
        public string Hobbi { get => hobbi; set => hobbi = value; }
    }
}
