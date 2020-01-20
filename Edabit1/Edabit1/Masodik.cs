using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit1
{
    class Masodik
    {
        public int Szam { get; set; }

        public Masodik(int a) //Konstruktor
        {
            this.Szam = a;

        }

        public int Noveles()
        {
            return this.Szam + 1;
        }
    }
}
