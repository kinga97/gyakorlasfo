using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismetles
{
    enum Napok { Hétfő = 12, Kedd, Szerda = 123, Csütörtök, Péntek, Szombat, Vasárnap }
    class Program
    {
        enum Honap { Január, Február, Március, Április, Május }
        static void Main(string[] args)
        {
            /*int szam = 2;
            bool kiertekel = true;

            while (kiertekel && szam >= 0)
            {
                Console.Write("Kérek egy pozitív egész számot: ");
                kiertekel = !Int32.TryParse(Console.ReadLine(), out szam);
                if (szam <= 0)
                {
                    kiertekel = true;
                    szam = 1;
                }
                
            }

            Console.WriteLine($"A bekért szám: {szam}");*/

            /*
            // Két egész szám max. 10 összegű lehet.
            int a = 1;
            int b = 2;
            bool kiertekel = true;
            bool masikKiertekel = true;

            while ((kiertekel || masikKiertekel) && (a + b <= 10))
            {
                Console.Write("Kérek egy egész számot: ");
                kiertekel = !Int32.TryParse(Console.ReadLine(), out a);
                Console.Write("Kérek egy másik egész számot: ");
                masikKiertekel = !Int32.TryParse(Console.ReadLine(), out b);

                if (a + b > 10)
                {
                    kiertekel = true;
                    masikKiertekel = true;
                    a = 1;
                    b = 2;
                }

            }
            Console.WriteLine($"A bekért számok: {a} és {b}");
            Console.WriteLine($"A bekért számok összege: {a + b}");
            */

            /*
            //Addig pozitív egész számok, amíg összegük kisebb, mint 100.
            int osszeg = 0;
            int darabSzam = 0;
            int szam = 0;

            while (osszeg <= 100)
            {
                Console.Write("Kérek egy pozitív egész számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
                osszeg += szam;
                darabSzam++;
            }

            Console.WriteLine($"A számok darabszáma: {--darabSzam}, összegük: {osszeg-szam}");
            */

            /*
            //Addig stringek, amíg rövidebb, mint 10.
            string kimenet = "";
            int stringOsszHossz = 0;
            int darabSzam = 0;


            while ( stringOsszHossz <= 10)
            {
                Console.Write("Kérek egy stringet: ");
                string beker = Console.ReadLine();
                int hossz = beker.Length;
                if (stringOsszHossz + hossz <= 10)
                {
                    stringOsszHossz += hossz;
                    kimenet += beker;
                    darabSzam++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"A bekért stringek száma: {darabSzam}. ");
            Console.WriteLine($"A végső szó: {kimenet}. ");
            */

            /*
            //Faktoriális
            Console.Write("Kérek egy pozitív egész számot 20-ig: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            int faktorialis = 1;
            int index = 1;

            do
            {
                faktorialis *= index++;
  
            } while (index <= szam);

            Console.WriteLine($"{szam}! = {faktorialis}");
            */

            /*
            // Binomiális együtthatók: n = 5 esetén 
            for (int k = 1; k < 7; k++)
            {
                Console.SetCursorPosition(k * 7, 0);
                Console.Write($"k={k - 1}");
            }

            for (int n = 1; n < 7; n++)
            {
                Console.SetCursorPosition(0, n);
                Console.Write($"n={n - 1}");
            }

            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.SetCursorPosition(j * 7, i);
                    int fakt = FaktorialisSzamitas(i - 1) / (FaktorialisSzamitas(j - 1) * FaktorialisSzamitas(i - j));
                    Console.Write(fakt);
                }
            }
            */

            /*
            //Break vagy continue
            for (int i = 1; i < 21; i++)
            {
                if (i % 5 == 0)
                {
                    break;
                    // goto ide;
                    
                }
                Console.WriteLine(i);
            }
            //ide:
            //Console.WriteLine("Itt ér véget a mese.");
            */

            /*
            //Hét napjai switch-csel

            Console.WriteLine("Kérek egy napot: ");
            string nap = Console.ReadLine();

            switch (nap)
            {
                case "Hétfő":
                    Console.WriteLine("Szeretem a hétfőt.");
                    break;
                case "Kedd":
                    Console.WriteLine("Szeretem a keddet.");
                    break;
                case "Szerda":
                    Console.WriteLine("Szeretem a szerdát.");
                    break;
                case "Csütörtök":
                    Console.WriteLine("Szeretem a csütörtököt.");
                    break;
                case "Péntek":
                    Console.WriteLine("Szeretem a pénteket.");
                    break;
                case "Szombat":
                    Console.WriteLine("Szeretem a szombatot.");
                    break;
                case "Vasárnap":
                    Console.WriteLine("Szeretem a vasárnapot.");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen nap.");
                    break;
            }
            */

            Console.WriteLine("Kérek egy számot 10-ig: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            switch (szam)
            {
                case 1:
                    
                case 3:
                    
                case 5:
                    
                case 7:
                    
                case 9:
                    Console.WriteLine("Páratlan szám");
                    break;
                case 2:
                   
                case 4:
                    
                case 6:
                    
                case 8:
                    
                case 10:
                    Console.WriteLine("Páros szám");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen szám ebben a feladatban.");
                    break;
            }

            Console.ReadKey(true);
        }

        static int FaktorialisSzamitas(int szam)
        {
            int faktorialis = 1;
            int index = 1;

            do
            {
                faktorialis *= index++;

            } while (index <= szam);

            return faktorialis;

        }
    }
}
