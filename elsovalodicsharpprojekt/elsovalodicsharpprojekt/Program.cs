﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsovalodicsharpprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.feladat:
            string kiir = "Hello World!";
            Console.WriteLine(kiir);*/

            /*2.feladat:
            Console.WriteLine("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Üdvözöllek {nev}!"); */

            /*3. feladat:
            Console.Write("Adj meg egy számot: ");
            //int szam = Int32.Parse(Console.ReadLine());
            //int szam = Convert.ToInt32(Console.ReadLine());
            //double szam = Double.Parse(Console.ReadLine());
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A szám: {szam} kétszerese: {2 * szam}" );*/

            /*4. feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            int osszeg = szamA + szamB;
            int kulonbseg = szamA - szamB;
            int szorzat = szamA * szamB;
            double hanyados = (double)szamA / szamB;

            Console.WriteLine($"A két szám: {szamA} és {szamB}: ");
            Console.WriteLine($"Összege: {osszeg}");
            Console.WriteLine($"Különbsége: {kulonbseg}");
            Console.WriteLine($"Szorzata: {szorzat}");
            Console.WriteLine($"Hányadosa: {hanyados}");*/

            /*5. feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA > szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}.");
            }
            else if (szamB > szamA)
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}.");
            }
            else
            {
                Console.WriteLine($"A két szám egyenlő.");
                }

            Egyszerűbb:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA >= szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}.");
            }
            else
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}.");
            }
            */

            /*6. feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg még egy számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());

            if (szamA <= szamB)
            {
                if (szamA <= szamC)
                {
                    Console.WriteLine($"A kisebbik szám: {szamA}");
                }
                else
                {
                    Console.WriteLine($"A kisebbik szám: {szamC}");
                }               
            }
            else
            {
                if (szamB <= szamC)
                {
                    Console.WriteLine($"A kisebbik szám: {szamB}");
                }
                else
                {
                    Console.WriteLine($"A kisebbik szám: {szamC}");
                }
            }*/

            /*7. feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg még egy számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());


            if (szamA + szamB > szamC && szamA + szamC > szamB && szamB + szamC > szamA)
            {
                Console.WriteLine($"A három számból {szamA}, {szamB} és {szamC} háromszög szerkeszthető.");
            }
            else
            {
                Console.WriteLine($"A három számból {szamA}, {szamB} és {szamC} háromszög nem szerkeszthető.");
            }*/

            //8. feladat
            /*Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA >= 0 && szamB >= 0)
            {
                double szamtani = ((double)szamA + szamB) / 2;
                double mertani = Math.Sqrt(szamA * szamB);
                Console.WriteLine($"A két szám: {szamA} és {szamB} számtani összege: {szamtani} ");
                Console.WriteLine($"A két szám: {szamA} és {szamB} mértani összege: {mertani} ");
            }
            else
            {
                Console.WriteLine("A feladat nem megoldható.");
            }
            Console.ReadKey(true);*/

            /*string szoveg = "Ez itt egy szöveg";
            for (int i = 0; i < szoveg.Length; i++)
            {
                Console.SetCursorPosition(i, i);
                Console.ForegroundColor = ConsoleColor
                Console.Write(szoveg.Substring(1, 1));
            }
            
           
            
            Összeadok két számot:
            float a = 15;
            float b = 300;
            1. megoldás:
            int osszeg = a + b;
            Console.WriteLine($"{a} és {b} összege: {osszeg}");
             2. megoldás:
            float osszeg = a + b;
            Console.WriteLine($"{a} és {b} összege: {osszeg}");
            Console.ReadKey(true);
            To Lower és Upper:
            Console.WriteLine(szoveg.ToLower());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(szoveg.ToUpper());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(szoveg.Substring(3, 9));*/

            /* 15. feladat:
            Console.WriteLine("Kérem a pozitív egész számot: ");
            int bemenoszam = Convert.ToInt32(Console.ReadLine());
            1. megoldás:
            string kiiratas = "";

            for (int i = 1; i < bemenoszam; i++)
            {
                kiiratas += i + " ";
            }

            Console.WriteLine(kiiratas);
            2. megoldás: 
            for (int i = 1; i < bemenoszam; i++)
            {
                Console.Write(i + " ");
            }*/

            /*int i = 1;

           Előltesztelő ciklus
             while (i < bemenoszam)
            {
                Console.Write(i++ + " ");
                //i = i + 1;
                //i += 1;
                //i++;

            }
            */
            /*Hátultesztelő ciklus
            do
            {
                Console.Write(i++ + " ");
            } while (i < bemenoszam);
            */


            /* 16. feladat:
            Console.WriteLine("Kérem a pozitív egész számot: ");
            int bemenoszam = Convert.ToInt32(Console.ReadLine());

             1. megoldás:
              string kiiratas = "";

             for (int i = 1; i < bemenoszam; i++)
             {
                 kiiratas += i + "\n"; //\n jelöli a sortörést
             }

             Console.WriteLine(kiiratas);*/
            /* 2. megoldás
           for (int i = 1; i < bemenoszam; i++)
           {
               Console.WriteLine(i + "");
           }
           */
            /*int i = 1;

            Előltesztelő ciklus
             while (i < bemenoszam)
            {
                Console.WriteLine(i++ + "");
                //i = i + 1;
                //i += 1;
                //i++;

            }*/

            /*Hátultesztelő ciklus
            do
            {
                Console.WriteLine(i++ + "");
            } while (i < bemenoszam);*/

            /* 17. feladat:

            Console.WriteLine("Kérem a pozitív egész számot: ");
            int bemenoszam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{bemenoszam} egész osztói: ");

            1. megoldás:
             for (int i = 1; i < bemenoszam; i++)
            {
                if (bemenoszam % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            2. megoldás: 
            int i = 1;

            while (i <= bemenoszam)
            {
                if (bemenoszam % i == 0) {
                    Console.WriteLine(i);
                }
                i++;
            }*/

            /* Plusz feladat: Pozitív szám prím-e? és 18. feladat:
            Console.WriteLine("Kérem a pozitív egész számot: ");
            int bemenoszam = Convert.ToInt32(Console.ReadLine());

            int szamlalo = 0;
            int osztokosszege = 0;

            for (int i = 1; i < bemenoszam + 1; i++)
            {
                if (bemenoszam % i == 0) {
                    szamlalo++;
                    osztokosszege += i;
                }
            }

            if (szamlalo == 2)
            {
                Console.WriteLine($"A bemenő szám {bemenoszam} prím.");
                Console.WriteLine($"A bemenő szám {bemenoszam} osztóinak összege: {osztokosszege}.");
            }
            else
            {
                Console.WriteLine($"A bemenő szám {bemenoszam} nem prím.");
                Console.WriteLine($"A bemenő szám {bemenoszam} osztóinak összege: {osztokosszege}.");
            }*/

            /*19. feladat:
            Console.WriteLine("Kérem a pozitív egész számot: ");
            int bemenoszam = Convert.ToInt32(Console.ReadLine());

            int osztokosszege = 0;

            int i = 0;

            while (i < bemenoszam)
            {
                if (bemenoszam % i == 0) // itt valami rossz
                {
                    osztokosszege += 0;
                }
                i++;
            }

            if (osztokosszege == bemenoszam) {
                Console.WriteLine($"A szám {bemenoszam} tökéletes szám.");
            }
            else
            {
                Console.WriteLine($"A szám {bemenoszam} nem tökéletes szám.");
            }
            */

            /* 20. feladat:
            int alap = -1;
            while (alap <= 0 || alap >= 10)
            {
                Console.WriteLine("Kérem az alapot: ");
                alap = Convert.ToInt32(Console.ReadLine());
            }

            int kitevo = -1;
            while (kitevo <= 0 || kitevo >= 10)
            {
                Console.WriteLine("Kérem a kitevőt: ");
                kitevo = Convert.ToInt32(Console.ReadLine());
            }
            
            int hatvany = 1;

            for (int i = 0; i < kitevo; i++)
            {
                hatvany *= alap;
            }
            Console.Write($"A hatvány: {hatvany}");*/

            /* 21. feladat:
            int szam = 0;
            while (szam <= 0)
            {
                Console.Write("Kérek egy pozitív egész számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            }*/
            /* Plusz feladat:
            int szam = 1;
            while (szam % 2 == 1 || szam % 2 == -1)
            {
                Console.Write("Kérek egy pozitív egész számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            }*/




            /* Plusz feladat: Prímszámra lépjen ki a ciklusból.

            int szam = 3;

            while (primszamE(szam))
            {
                Console.Write("Kérek egy nem prím számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            }*/

            //22. feladat:
            int szam = 0;

            int osszeg = 0;
            while (szam <= 10)
            {
                
                Console.WriteLine("Kérek egy 10-nél kisebb egész számot: ");
                szam = Int32.Parse(Console.ReadLine());
                if (szam <= 10)
                {
                    osszeg += szam;
                    Console.WriteLine($"Az eddig beolvasott megfelelő számok összege: {osszeg}. ");
                }
                else
                {
                    Console.WriteLine("Nem megfelelő szám.");
                    break;
                }
                Console.WriteLine($"A beolvasott számok összege: {osszeg}.");

            }

            
            Console.ReadKey(true);

        }
        static bool primszamE(int szam)
        {
            bool teljesul = true;
            int osztokSzama = 0;
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0) {
                    osztokSzama++;
                }
            }
            if (osztokSzama == 2)
            {
                return teljesul;
            }
            else
            {
                return !teljesul;
            }
        }
    }
}
