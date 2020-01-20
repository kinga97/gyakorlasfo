using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit1
{
    class Haromszog
    {
        public int Alap { get; set; }

        public int Magassag { get; set; }

        public Haromszog(int a, int b) //Konstruktor
        {
            this.Alap = a;
            this.Magassag = b;
        }

        public double TeruletSzamol()
        {
            return (this.Alap * this.Magassag) / 2;
        }
    }
}
