using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit1
{
    class Program
    {
        static void Main(string[] args)
        {
            //edabit.com/challenges/csharp

            /* //Első feladat : Return the sum of two numbers
            Console.Write("Kérem az első számot: ");
            int elsoSzam = Convert.ToInt32(Console.ReadLine());
            elso elso = new elso(elsoSzam);
            Console.Write("Kérem az második számot: ");
            int masodikSzam = Convert.ToInt32(Console.ReadLine());
            elso masodik = new elso(masodikSzam);

            Console.WriteLine($"A két szám összege: {Sum(elsoSzam, masodikSzam)}");
            Console.WriteLine($"A két szám összege: {elso.Sum(masodik)}");
            Console.WriteLine($"A két szám összege: {masodik.Sum(elso)}");
            */


            /* //Második feladat: Return the next number from the integer passed
            Console.Write("Kérek egy számot: ");
            int Szam = Convert.ToInt32(Console.ReadLine());
            Masodik szam = new Masodik(Szam);

            Console.WriteLine($"A rákövetkező szám: {Noveles(Szam)}");
            Console.WriteLine($"A rákövetkező szám: {szam.Noveles()}");*/


            /* //Harmadik feladat: Area of a triangle
            Console.Write("Kérem az alapot: ");
            int alap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem a magasságot: ");
            int magassag = Convert.ToInt32(Console.ReadLine());
            Haromszog haromSzog = new Haromszog(alap, magassag);

            Console.WriteLine($"A háromszög területe: {Terulet(alap, magassag)}");
            Console.WriteLine($"A háromszög területe: {haromSzog.TeruletSzamol()}");*/


            /* //Negyedik feladat: Return the remainder from two numbers
            Console.Write("Kérem az első számot: ");
            int elsoSzam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem az második számot: ");
            int masodikSzam = Convert.ToInt32(Console.ReadLine());
            Negyedik osztas = new Negyedik(elsoSzam, masodikSzam);

            Console.WriteLine($"A maradékos osztás eredménye: {Maradek(elsoSzam, masodikSzam)}");
            Console.WriteLine($"A maradékos osztás eredménye: {osztas.MaradekosOsztas()}");*/


            /* //Ötödik feladat: Is the number less than or equal to zero?
            Console.Write("Kérek egy nem pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Otodik elojel = new Otodik(szam);

            Console.WriteLine($"A szám negatív vagy nulla-e: {Elojel(szam)}");
            Console.WriteLine($"A szám negatív vagy nulla-e: {elojel.Elojel()}");*/


            /* //Hatodik feladat: Flip the boolean
            Console.Write("Kérem a logikai értéket: ");
            bool elsoSzam = Convert.ToBoolean(Console.ReadLine());
            Hatodik logikai = new Hatodik(elsoSzam);

            Console.WriteLine($"A logikai érték megáltja: {Megfordit(elsoSzam)}");
            Console.WriteLine($"A logikai érték megáltja: {logikai.Megforditas()}");*/


            /* //Hetedik feladat: Check if an integer is divisible by 5
            Console.Write("Kérek egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Hetedik osztas = new Hetedik(szam);
            Hetedik masodikOsztas = new Hetedik(5);

            Console.WriteLine($"A szám osztható-e öttel: {OttelOszthato(szam)}");
            Console.WriteLine($"A szám osztható-e öttel: {osztas.OttelOsztas()}");
            Console.WriteLine($"A szám osztható-e öttel: {osztas.OttelOsztas(masodikOsztas)}");*/


            /* //Nyolcadik feladat: Compare strings by count of characters
            Console.Write("Kérek egy szót: ");
            string elso = Console.ReadLine();
            Console.Write("Kérek egy másik szót: ");
            string masodik = Console.ReadLine();
            Sztringek sztringek = new Sztringek(elso, masodik);

            Console.WriteLine($"A karakterek száma egyenlő-e: {sztringek.Egyforma()}");*/


            /* //Kilencedik feladat: Concetenate first and last name into one string
            Console.Write("Kérek egy szót: ");
            string elso = Console.ReadLine();
            Console.Write("Kérek egy másik szót: ");
            string masodik = Console.ReadLine();
            Kilencedik sztringek = new Kilencedik(elso, masodik);

            Console.WriteLine($"A két string fordítva összefűzve: {sztringek.Osszefuz()}");*/


            //Tizedik feladat: Check string for spaces
            Console.Write("Kérek egy stringet: ");
            string elso = Console.ReadLine();
            Tizedik szo = new Tizedik(elso);

            Console.WriteLine($"Van-e a stringben szóköz: {szo.VanEszokozElso()}");
            Console.WriteLine($"Van-e a stringben szóköz: {szo.VanEszokozMasodik()}");


            Console.ReadKey(true);
        }

        static int Sum(int a, int b) //Első
        {
            return a + b;
        }

        static int Noveles(int a) //Második
        {
            return a + 1;
        }

        static double Terulet(double alap, double magassag) //Háromszög - harmadik
        {
            return (alap * magassag) / 2;
        }

        static int Maradek(int a, int b) //Negyedik
        {
            return a % b;
        }

        static bool Elojel(int a) //Ötödik
        {
            if (a <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool Megfordit(bool logikaiErtek) //Hatodik
        {
            return !logikaiErtek; // Operátor - megfordítja az ellenkező értékre
        }

        static bool OttelOszthato(int a) //Hetedik
        {
            if (a % 5 == 0)
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
