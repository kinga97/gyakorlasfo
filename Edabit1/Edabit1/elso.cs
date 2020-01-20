using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit1
{
    class elso
    {
        public int ElsoSzam { get; set; }

        public elso(int a)
        {
            this.ElsoSzam = a;
            
        }

        public int Sum(elso ertek)
        {
            return this.ElsoSzam + ertek.ElsoSzam;
        }
    }
}
