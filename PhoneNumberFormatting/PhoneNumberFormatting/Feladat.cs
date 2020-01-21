using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberFormatting
{
    class Feladat
    {
        public int[] tomb { get; set; }

        public Feladat(int[] a)
        {
            this.tomb = a;
        }

        public string TelefonSzam()
        {
            string valt = "";
           

            valt = $"({this.tomb[0]}{this.tomb[1]}{this.tomb[2]}) {this.tomb[3]}{this.tomb[4]}{this.tomb[5]}-{this.tomb[6]}{this.tomb[7]}{this.tomb[8]}{this.tomb[9]}";


            return valt;
        }
    }
}
