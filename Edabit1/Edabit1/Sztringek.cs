using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit1
{
    class Sztringek
    {
        public string Elso { get; set; }

        public string Masodik { get; set; }

        public Sztringek(string a, string b)
        {
            this.Elso = a;
            this.Masodik = b;
        }

        public bool Egyforma()
        {
            if (this.Elso.Length == this.Masodik.Length)
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
