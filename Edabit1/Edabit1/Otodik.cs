using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit1
{
    class Otodik
    {
        public int Szam { get; set; }

        public Otodik(int a)
        {
            this.Szam = a;
        }

        public bool Elojel()
        {
            if (this.Szam <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
