using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit1
{
    class Tizedik
    {
        public string Elso { get; set; }

        public Tizedik(string a)
        {
            this.Elso = a;
        }

        public bool VanEszokozElso()
        {
            if (this.Elso.Contains(" "))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool VanEszokozMasodik()
        {
            bool vanE = false;

            for (int i = 0; i < this.Elso.Length; i++)
            {
                if (this.Elso[i] == ' ')
                {
                    vanE = true;
                }
            }

            return vanE;
        }
    }
}
