using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[10];
            Random rnd = new Random();
            for (int i = 0; i <= 9; i++)
            {
                tomb[i] = rnd.Next(10);
            }

            Feladat szamok = new Feladat(tomb);

            //Console.WriteLine(Telefonszam(tomb));
            Console.WriteLine(szamok.TelefonSzam());

            Console.ReadKey(true);
        }

        static string Telefonszam(int[] tomb)
        {
            string valt = "";

            valt = $"({tomb[0]}{tomb[1]}{tomb[2]}) {tomb[3]}{tomb[4]}{tomb[5]}-{tomb[6]}{tomb[7]}{tomb[8]}{tomb[9]}";


            return valt;
        }
    }
}
