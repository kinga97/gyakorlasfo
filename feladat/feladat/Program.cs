using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mivel számoljak? (kör, négyzet, téglalap, derékszögű háromszög): ");
            string bemeno = Console.ReadLine();
           
           
            if (bemeno == "kör")
            {
                Console.Clear();
                Console.Write("Adj meg egy sugarat: ");
            
                double sugar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A kör kerülete: {2 * sugar * Math.PI}");
                Console.WriteLine($"A kör területe: {sugar * sugar * Math.PI}");
            }
            else if (bemeno == "négyzet")
                {
                Console.Clear();
                Console.Write("Adj meg egy oldalt: ");
                double oldal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A négyzet kerülete: {4 * oldal}");
                Console.WriteLine($"A négyzet területe: {oldal * oldal}");
            }
            else if (bemeno == "téglalap")
            {
                Console.Clear();
                Console.WriteLine("Adj meg egy oldalt: ");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Adj meg egy másik oldalt: ");
                double b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A téglalap kerülete: {2 * (a + b)}");
                Console.WriteLine($"A téglalap területe: {a * b}");
            }
            else if (bemeno == "derékszögű háromszög")
            {
                Console.Clear();
                Console.Write("Adj meg egy oldalt: ");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adj meg egy másik oldalt: ");
                double b = Convert.ToInt32(Console.ReadLine());
                double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                Console.WriteLine($"A derékszögű háromszög kerülete: {a + b + c}");
                Console.WriteLine($"A derékszögű háromszög területe: {(a * b) / 2}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("A feladatnak nincs megoldása.");
            }
            Console.ReadKey(true);
        }
    }
}
