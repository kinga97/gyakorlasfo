using System;
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

            /* Plusz feladat: Pozitív szám prím-e? 26. és 18. feladat:
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
            /*int szam = 0;

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

            }*/

            /*Console.WriteLine("2-től 100-ig a prímszámok: ");

            for (int i = 2; i < 101; i++)
            {
                if (primszamE(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey(true);

        }*/



            /* Különálló feladat
                        //Int32.TryParse használata
                        int szam = -89;
                        bool egeszSzam = true;

                        do
                        {
                            Console.Write("Kérek egy számot: ");
                            egeszSzam = Int32.TryParse(Console.ReadLine(), out szam);
                        } while (!egeszSzam);


                        Console.WriteLine($"A bekért szám: {szam}");
                        */

            /*//23. feladat:
            string kimenet = "";

            Console.WriteLine("Kérek egy pozitív egész számot: ");
            int szam = Int32.Parse(Console.ReadLine());

            kimenet += szam + " = ";

            while (szam % 2 == 0)
            {
                kimenet += 2 + " * ";
                szam = szam / 2;
            }

            kimenet += szam;

            Console.WriteLine(kimenet);*/

            /* //24. feladat:
             string alma = "";

             while (alma != "alma")
             {
                 Console.Write("Kérek egy gyümölcsöt: ");
                 alma = Console.ReadLine();
             }

             Console.WriteLine("Az alma gyümölcs.");
             */


            //25. feladat:
            /*string kimenet = "";

            Console.WriteLine("Kérek egy pozitív egész számot: ");
            int szam = Int32.Parse(Console.ReadLine());

            kimenet += szam + " = ";
            int egesz = 0;
            int tort = -1;


            while ( szam - 3 >= 0)
            {
                szam = szam - 3;
                egesz++;
                tort = szam;
            }

            kimenet += egesz + " * 3 +" + tort;

            Console.WriteLine(kimenet);
            */

            /*
            //28. és 29. feladat:
            string kimenet = "";

            Console.WriteLine("Kérek egy pozitív egész számot: ");
            int szam = Int32.Parse(Console.ReadLine());

            kimenet += szam + " = ";
            int meddig = (int)(Math.Floor(Math.Sqrt(szam))) + 1;

            for (int i = 2; i < meddig; i++)
            {
                if (szam % i == 0)
                {
                    if (szam == i)
                    {
                        kimenet += i;
                    }
                    else
                    {
                        kimenet += i + " * ";
                        szam = szam / i;
                        i--;
                    }
                }
            }

            

            Console.WriteLine(kimenet);
            */

            /*
            //32. feladat:
            Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{szam} * {i} = {szam * i}");
            }
            */

            /*
            // 33. feladat
            Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < szam + 1; i++)
            {
                for (int j = 1; j < szam + 1; j++)
                {
                    Console.SetCursorPosition(3 * (j - 1) +1, i);
                    Console.Write($"{i * j} ");
                    
                }
                Console.WriteLine();
            }
            */

            /*
            //34. feladat:
            Console.WriteLine("A párosan speciális számok: ");
            for (int i = 10; i < 100; i++)
            {
                int kulsoTizes = i / 10;
                int kulsoEgyes = i % 10;
                for (int j = 10; j < 100; j++)
                {
                    int belsoTizes = j / 10;
                    int belsoEgyes = j % 10;
                    int belsoSzorzat = i * j;
                    int kulso = 10 * kulsoEgyes + kulsoTizes;
                    int belso = 10 * belsoEgyes + belsoTizes;
                    int kulsoSzorzat = kulso * belso;
                    if (belsoSzorzat == kulsoSzorzat)
                    {
                        Console.WriteLine($"Az {i} és {j} párosan speciális számok.");
                    }
                }
            }
            */

            /*
            // 35. feladat:
            int sorok = 5;
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < sorok + 1; j++)
                {
                    if (97 + i + j * sorok < 123)
                    {
                        Console.SetCursorPosition(j * 10, i);
                        Console.WriteLine($"{(char)(97 + i + j * sorok)} {97 + i + j * sorok}");
                    }
                    
                }
                
            }
            */

            /*
            //36. feladat:
            Console.Write("Kérem a sorok számát: ");
            int sorok = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem az oszlopok számát: ");
            int oszlopok = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                }
                Console.WriteLine();
            }
            */

            /*
            //37. feladat:
            Console.Write("Kérek egy természetes számot: ");
            int a = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */

            /*
            //38. feladat:
            1. megoldás:
            Console.Write("Kérek egy természetes számot: ");
            int a = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.SetCursorPosition(a - i, i + 1);
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            2. megoldás:
            Console.Write("Kérek egy természetes számot: ");
            int a = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            { 
                for (int k = 0; k < a - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            */

            /*
            // 39. feladat:
            Console.Write("Kérem a sorok számát: ");
            int sorok = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem az oszlopok számát: ");
            int oszlopok = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if ((i == 0) || (i == (sorok - 1)))
                    {
                        Console.Write('*');
                    }
                    else if ((j == 0) || (j == oszlopok -1)) {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            

            //Kerettel vízszintesen és függőlegesen is a közepén:
            Console.Write("Kérem a sorok számát: ");
            int sorok = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem az oszlopok számát: ");
            int oszlopok = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if ((i == 0) || (i == (sorok - 1)) || (i == (sorok - 1) / 2))
                    {
                        Console.Write('*');
                    }
                    else if ((j == 0) || (j == oszlopok - 1) || (j == (oszlopok - 1) / 2))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            */

            /*
            //41. feladat:
            for (int i = 65; i < 91; i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();
            for (int j = 66; j < 91; j++)
            {
                Console.Write((char)j);
            }
            for (int k = 65; k < 66; k++)
            {
                Console.Write((char)k);
            }
            for (int n = 66; n < 67; n++)
            {
                Console.Write((char)n);
            }
            
        
            Másik:
            for (int i = 0; i < 26; i++)
            {
                for (int j = 65 + i; j < 91; j++)
                {
                    Console.Write((char)j);
                }
                Console.WriteLine();
            }
            */
            for (int i = 0; i < 26; i++)
            {
                for (int j = 65 + i; j < 91; j++)
                {
                    Console.Write((char)j);
                }
                for (int k = 65; k < 65 + i; k++)
                {
                    Console.Write((char)k);
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);

        }

        /*static bool primszamE(int szam)
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

     static bool osszegHettel(int szam)
        {
            int osszeg = 0;
            bool hettel = true;

            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    osszeg += i;
                }
            }

            if (osszeg % 7 != 0)
            {
                hettel = false;
            }

            return hettel;
        }

        static bool primszamE(int szam)
        {
            bool primE = true;
            int hatar = (int)Math.Floor(Math.Sqrt(szam)) + 1;

            for (int i = 2; i < hatar; i++)
            {
                if (szam % i == 0)
                {
                    primE = false;
                    break;
                }
            }

            return primE;


        }*/
    }
}
