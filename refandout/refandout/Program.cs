using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refandout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az első számot: ");
            int elso = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            int masodik = Int32.Parse(Console.ReadLine());
            Console.Write("Kérek egy nevet: ");
            string nev = Console.ReadLine();

            // Console.WriteLine($"A két szám összege: {Osszead(ref elso, ref masodik, ref nev)}");
            Console.WriteLine($"A két szám összege: {Osszead(out elso, out masodik, out nev)}");
            Console.WriteLine($"A két szám: {elso}, {masodik}");
            Console.WriteLine($"A név: {nev}");


            Console.ReadKey(true);
        }

        /*
         static int Osszead(int a, int b)
         {
             //Létrehozom a visszatérő értéket és inicializálom.
             int osszeg = 0;

             //Kiszámolom a visszatérő értéket.
             osszeg = a + b;

             //Visszaadom a visszatérő értéket.
             return osszeg;

             int osszeg = a + b;
             a = 128;
             b = -49;
             return osszeg;

         }
         */

        //static int Osszead(ref int a, ref int b, ref string nev)
        static int Osszead(out int a, out int b, out string nev)
        {
            a = 0;
            b = 0;
            int osszeg = a + b;

            //a = 128;
            //b = -49;
            nev = "Gábor";
            return osszeg;

            /*Console.WriteLine("1-től 100-ig azok a számok, melyek valódi osztóinak összege osztható héttel.");
            for (int i = 1; i < 101; i++)
            {
                if (osszegHettel(i))
                {
                    Console.WriteLine($"{i} valódi osztóinak összege osztható 7-tel.");
                }
            }*/

            
        }
    }
}
