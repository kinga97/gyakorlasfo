using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szovegkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Plusz feladat: Adott szóban minden második betű kisbetű:
            Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();
            string kiir = "";

            for (int i = 0; i < szo.Length; i++)
            {
                if (i % 2 == 0)
                {
                    char ch = (char)((int)szo[i] - 32);
                    kiir += ch;
                }
                else
                {
                    kiir += szo[i];
                }
            }
            Console.WriteLine(kiir);

            Console.ReadKey(true);
        }
    }
}
