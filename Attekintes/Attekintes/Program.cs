using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attekintes
{
    class Program
    {
        static void Main(string[] args)
        {
            Hazikedvenc hk = new Hazikedvenc(); // Példány
            hk.Neme = "Lány";
            Console.WriteLine($"A házikedvenc neme: {hk.Neme}");

            Hazikedvenc hk2 = new Hazikedvenc();
            hk2.Megvaltoztat("Fiú");
            Console.WriteLine($"A házikedvenc neme: {hk2.Neme}");

            Console.ReadKey(true);
        }

    }

    class Hazikedvenc
    {
        // Mező adattag (tulajdonság)
        private string neme; // Private-nál mindenképp kell a get-set
        
        // Mező property-je
        public string Neme
        {
            get { return this.neme; } // Mindig ezt használjuk amikor a "neme"-re akarunk hivatkozni.
            set { this.neme = value; }
        }
        

       // public string Neme { get; set; }

        public void Megvaltoztat(string ertek)
        {
            this.neme = ertek;
            Console.WriteLine($"A házikedvenc neme: {this.neme}"); // Ha privátnak meg akarom változtatni a tulajdonságát public propertyvel, akkor csak a propertyn keresztül lehet.
        }


    }
}
