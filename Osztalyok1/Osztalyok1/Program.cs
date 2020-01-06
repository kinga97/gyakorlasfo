using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Évfolyam: {Ember.evfolyam}, osztály: {Ember.osztaly}");
            Ember[] emberTomb = new Ember[2];

            for (int i = 0; i < 2; i++)
            {
                bool letezik = false; //hibánál visszaugorjon ugyanarra a személyre
                Console.Write("Kérem a magasságot: ");
                int magassag = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kérem a testsúlyt: ");
                int testsuly = Int32.Parse(Console.ReadLine());
                Console.Write("Kérem a születési időt: ");
                string szuletesiIdo = Console.ReadLine();
                Ember ember = new Ember();
                try
                {
                    ember = new Ember(magassag, testsuly, szuletesiIdo);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    letezik = true; //hibánál visszaugorjon ugyanarra a személyre
                }
                
                emberTomb[i] = ember;
                ember.Kiir(i + 1);
                /*Console.WriteLine($"Az {i + 1}. ember magassága: {ember.GetMagassag()} centiméter.");
                Console.WriteLine($"Az {i + 1}. ember testsúlya: {ember.GetTestsuly()} kilogramm.");
                Console.WriteLine($"Az {i + 1}. ember születési ideje: {ember.GetSzuletesiIdo()}.");*/

                if (letezik) i--; //hibánál visszaugorjon ugyanarra a személyre
            }

            /* for (int i = 0; i < emberTomb.Length; i++)
             {
                 Console.WriteLine($"Az {i + 1}. ember magassága: {emberTomb[i].Magassag} centiméter.");
                 Console.WriteLine($"Az {i + 1}. ember testsúlya: {emberTomb[i].Testsuly} kilogramm.");
                 Console.WriteLine($"Az {i + 1}. ember születési ideje: {emberTomb[i].SzuletesiIdo}.");
             }*/

            Console.Write("A második ember új magassága: ");
            int ujMagassag = Convert.ToInt32(Console.ReadLine());

            try
            {
                emberTomb[1].SetMagassag(ujMagassag);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            

            Console.ReadKey(true);
        }
    }

    class Ember
    {
        private int magassag;
        private int testsuly;
        private string szuletesiIdo;
        static public string osztaly = "Szoftverfejlesztő";
        static public int evfolyam = 13;

        public int Magassag
        {
            get { return this.magassag; }
            set {
                if (value < 0 || value > 273)
                    throw new ArgumentException("Nem elfogadható magasság érték!");
                this.magassag = value; }
        }

        public int Testsuly
        {
            get { return this.testsuly; }
            set {
                if (value < 0)
                    throw new ArgumentException("Nem elfogadható testsúly érték!");
                this.testsuly = value; }
        }

        public string SzuletesiIdo
        {
            get { return this.szuletesiIdo; }
            set { this.szuletesiIdo = value; }
        }



        public Ember(int Magassag, int Testsuly, string SzuletesiIdo)
        {
            if (Magassag < 0 || Magassag > 273)
                throw new ArgumentException("Nem elfogadható magasság érték!");
            if (Testsuly < 0)
                throw new ArgumentException("Nem elfogadható testsúly érték!");

            this.magassag = Magassag;
            this.testsuly = Testsuly;
            this.szuletesiIdo = SzuletesiIdo;
        }

        public Ember()
        {

        }
        

        public int GetMagassag()
        {
            return this.magassag;
        }

        public void SetMagassag(int value)
        {
            if (value < 0 || value > 273)
            {
                throw new ArgumentException("Nem elfogadható magasság érték!");
                this.magassag = value;
            }
            
        }

        public int GetTestsuly()
        {
            return this.testsuly;
        }

        public void SetTestsuly(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Nem elfogadható testsúly érték!");
                this.testsuly = value;
            }
        }

        public string GetSzuletesiIdo()
        {
            return this.szuletesiIdo;
        }

        public void SetSzuletesiIdo(string value)
        {
            this.szuletesiIdo = value;
        }

        public void Kiir(int i)
        {
            Console.WriteLine($"Az {i}. ember magassága: {this.magassag}");
            Console.WriteLine($"Az {i}. ember testsúlya: {this.testsuly}");
            Console.WriteLine($"Az {i}. ember születési ideje: {this.szuletesiIdo}");
            Console.WriteLine($"Az {i}. ember osztálya: {evfolyam}/{osztaly}");
        }

        static public void KiirOsztaly()
        {
            Console.WriteLine($"Évfolyam: {evfolyam}, osztály: {osztaly}");
        }
    }

}
