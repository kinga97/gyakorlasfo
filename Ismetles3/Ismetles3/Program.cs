using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismetles3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Külső feladat
            int bekertSzam = 0;
            Random rnd = new Random(); //Nagyon fontos! -- rnd.Next(); pozitív egész szám 0<..>2, rnd.Next(stop); 0<..>stop, rnd.Next(min, max) min <=..>=max

            while (bekertSzam <= 0)
            {
                try
                {
                    Console.Write("Adj meg egy pozitív egész számot: ");
                    bekertSzam = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.Write(e.Message);
                }
            }
           

            //Console.WriteLine($"A bekért szám: {bekertSzam}");
            

            int[] veletlenSzamok = new int[bekertSzam];

            Console.Write($"\nA generált számok: ");

            int osszeg = 0;
            int szorzat = 1;
            int egymasbolKivon = rnd.Next(-100, 100);
            veletlenSzamok[0] = egymasbolKivon;
            osszeg += egymasbolKivon;
            szorzat *= egymasbolKivon;
            Console.Write($"{egymasbolKivon};");

            for (int i = 1; i < bekertSzam; i++)
            {
                int generaltSzam = rnd.Next(-100, 100);
                veletlenSzamok[i] = generaltSzam;
                osszeg += generaltSzam;
                szorzat *= generaltSzam;
                egymasbolKivon -= generaltSzam;
                if (i != bekertSzam - 1)
                {
                    Console.Write($"{generaltSzam};");
                }
                else
                {
                    Console.Write(generaltSzam);
                }
                
            }

            Console.WriteLine($"\n\nA generált számok összege: {osszeg}");
            Console.WriteLine($"A generált számok szorzata: {szorzat}");
            Console.WriteLine($"A generált értékek egymásból kivonva: {egymasbolKivon}");
            Console.ReadKey(true);

        }
    }
}
