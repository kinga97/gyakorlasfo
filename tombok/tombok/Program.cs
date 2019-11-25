using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //42-43. feladat:
            Console.WriteLine("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());
            
            //Létrehozzuk a tömböt:
            int[] tomb = new int[darabszam];

            //Feltöltjük a tömböt egész számokkal:
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem az ({i + 1}). számot :");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            //Megszámoljuk a páratlan tömbelemeket:
            int paratlanokSzama = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 1)
                {
                    paratlanokSzama++;
                }
               
            }

            Console.WriteLine($"A tömbben található páratlan számok száma: {paratlanokSzama}");

            //Páros számok összege:
            int parosokOsszege = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    parosokOsszege += tomb[i];
                }
            }
            Console.WriteLine($"A páros számok összege: {parosokOsszege}");
            

            //44. feladat
            int parosokOsszege = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    parosokOsszege += tomb[i];
                    Console.WriteLine($"{i + 1}. szám páros: {tomb[i]}");
                }
            }
            Console.WriteLine($"A páros számok összege: {parosokOsszege}");
            */

            /*
            //45. feladat:
            Console.WriteLine("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[darabszam];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem az ({i + 1}). számot :");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            Console.Write("Kérem a próbaszámot: ");
            int probaSzam = Convert.ToInt32(Console.ReadLine());
            int tombIndex = -1;
            bool vanE = false;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == probaSzam)
                {
                    tombIndex = i + 1;
                    vanE = true;
                    break;
                }
            }

            if (vanE)
            {
                Console.WriteLine($"Találtam ilyen számot a(z) {tombIndex}. pozícióban.");
            }
            else
            {
                Console.WriteLine("Nincs ilyen szám a tömbben.");
            }
            */

            /*
            //46. feladat:
            Console.WriteLine("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[darabszam];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem az ({i + 1}). számot :");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            Console.Write("Kérem a próbaszámot: ");
            int probaSzam = Convert.ToInt32(Console.ReadLine());
            int szamlalo = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == probaSzam)
                {
                    szamlalo++;
                }
            }
            if (szamlalo !=0)
            {
                Console.WriteLine($"A(z) {probaSzam} ennyiszer szerepel: {szamlalo}");
            }
            else
            {
                Console.WriteLine("Ilyen szám nincs a tömbben.");
            }
            */

            /*
            //47. feladat:
            Console.WriteLine("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());

            string[] tomb = new string[darabszam];

            //Feltöltjük a tömböt keresztnevekkel.
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem az ({i + 1}). számot :");
                string keresztnev = Console.ReadLine();
                tomb[i] = keresztnev;
            }

            Console.Write("Kérem a próbanevet: ");
            string probaNev = Console.ReadLine();
            int szamlalo = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == probaNev)
                {
                    szamlalo++;
                }
            }
            if (szamlalo != 0)
            {
                Console.WriteLine($"A(z) {probaNev} ennyiszer szerepel: {szamlalo}");
            }
            else
            {
                Console.WriteLine("Ilyen név nincs a tömbben.");
            }
            */

            /*
            //48. feladat:
              //1. megoldás:
            Console.WriteLine("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[darabszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem az ({i + 1}). számot :");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            tombKiir(tomb);
            Array.Sort(tomb);
            tombKiir(tomb);

            Console.WriteLine($"A különbség: {tomb[tomb.Length - 1] - tomb[0]}");
            
            //2. megoldás:
            Console.WriteLine("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[darabszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem az ({i + 1}). számot :");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            int maxKulonbseg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = i; j < tomb.Length; j++)
                {
                    int kulonbseg = Math.Abs(tomb[i] - tomb[j]);
                    if (maxKulonbseg <= kulonbseg)
                    {
                        maxKulonbseg = kulonbseg;
                    }
                }
            }
            Console.WriteLine("Különbség: " + maxKulonbseg);
            
            Array.Sort(tomb);
            

            Console.WriteLine($"A különbség: {tomb[tomb.Length - 1] - tomb[0]}");

            Console.WriteLine($"A különbség: {tomb.Max() - tomb.Min()}");
            */


            Console.ReadKey(true);
        }


        static void tombKiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
        }
    }
}
