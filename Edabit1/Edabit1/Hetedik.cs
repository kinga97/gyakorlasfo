using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit1
{
    class Hetedik
    {
        public int Szam { get; set; }

        public Hetedik(int a)
        {
            this.Szam = a;
        }

        public bool OttelOsztas()
        {
            if (this.Szam % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool OttelOsztas(Hetedik masik) //Túlterhelés
        {
            if (this.Szam % masik.Szam == 0)
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
