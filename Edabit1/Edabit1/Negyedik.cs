using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit1
{
    class Negyedik
    {
        public int ElsoSzam { get; set; }

        public int MasodikSzam { get; set; }

        public Negyedik(int a, int b)
        {
            this.ElsoSzam = a;
            this.MasodikSzam = b;
        }

        public int MaradekosOsztas()
        {
            return this.ElsoSzam % this.MasodikSzam;
        }
    }
}
