using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit1
{
    class Kilencedik
    {
        public string Elso { get; set; }

        public string Masodik { get; set; }

        public Kilencedik(string a, string b)
        {
            this.Elso = a;
            this.Masodik = b;
        }


        public string Osszefuz()
        {
            return this.Masodik + ", " + this.Elso;


        }
    }
}
