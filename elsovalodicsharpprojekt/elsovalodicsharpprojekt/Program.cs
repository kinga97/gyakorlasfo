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
        }
    }
}
