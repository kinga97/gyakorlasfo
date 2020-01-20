using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit1
{
    class Hatodik
    {
        public bool logikaiErtek { get; set; }

        public Hatodik(bool a)
        {
            this.logikaiErtek = a;
        }

        public bool Megforditas()
        {
            return !this.logikaiErtek;
        }
    }
}
