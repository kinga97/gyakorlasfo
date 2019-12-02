using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. feladat:
            Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{szam} kettes osztóinak száma: {kettoOszto(szam)}");

            Console.ReadKey(true);
        }
        static int kettoOszto(int szam)
        {
            int osztokSzama = 0;

            while (szam % 2 == 0)
            {
                osztokSzama++;
                szam /= 2; // szam = szam / 2;
            }

            return osztokSzama;
        }

    }
}
