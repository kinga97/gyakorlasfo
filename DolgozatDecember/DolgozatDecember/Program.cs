using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatDecember
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Hány szavas legyen a mondat?: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            string[] mondat = new string[szam];

            
            for (int i = 0; i < szam; i++)
            {
                Console.Clear();
                int temphossz = rnd.Next(1, 12);
                string tempszo = "";
                while (tempszo.Length != temphossz )
                {
                    Console.Write($"Adj meg egy {temphossz} hosszúságú szót: ");
                    tempszo = Console.ReadLine();
                }
                mondat[i] = tempszo;
                
            }
            Console.WriteLine($"\nA mondat: {mondat.Length}");
            for (int i = 0; i < mondat.Length; i++)
            {
                if (i == mondat.Length - 1)
                {
                    Console.Write(mondat[i] + ".");
                }
                else
                {
                    Console.Write(mondat[i] + " ");
                }
                //Console.WriteLine($"Az {i}. szó {} hosszúságú.");
            }

            Console.ReadKey(true);


        }
    }
}
