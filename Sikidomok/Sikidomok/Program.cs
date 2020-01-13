using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Program
    {
        static void Kiiras(Negyzet negy)
        {
            if (negy is Negyzet)
            {
                Console.WriteLine($"A négyzet kerülete: {((Negyzet)negy).KeruletSzamol()}");
            }
            else if (negy is Teglalap)
            {
                Console.WriteLine($"A négyzet kerülete: {((Teglalap)negy).KeruletSzamol()}");
            }
            
        } 

        static void Main(string[] args)
        {
            /*Negyzet negyzet = new Negyzet(12);
            Console.WriteLine($"A négyzet kerülete: {negyzet.KeruletSzamol()}");
            Console.WriteLine($"A négyzet területe: {negyzet.TeruletSzamol()}");

            Teglalap teglalap = new Teglalap(12, 10);
            Console.WriteLine($"A téglalap kerülete: {teglalap.KeruletSzamol()}");
            Console.WriteLine($"A téglalap területe: {teglalap.TeruletSzamol()}");*/

            Negyzet negyzet = new Negyzet(10);
            Teglalap teglalap = new Teglalap(20, 30);

            Kiiras(negyzet);
            Kiiras(teglalap);
           

            /*Console.WriteLine($"A négyzet kerülete: {negyzet.KeruletSzamol()}");
            Console.WriteLine($"A négyzet területe: {negyzet.TeruletSzamol()}");*/

            Console.ReadKey(true);
        }

        class Negyzet
        {
            public int AOldal { get; set; }

            public Negyzet(int aOldal)
            {
                this.AOldal = aOldal;
            }
            
            public int TeruletSzamol()
            {
                return this.AOldal * this.AOldal;
            } 

            public int KeruletSzamol()
            {
                return this.AOldal * 4;
            }

            public void Kiir(Negyzet negy)
            {
                Console.WriteLine($"A négyzet kerülete: {negy.KeruletSzamol()}");
            }

            public Negyzet()
            {

            }
        }

        class Teglalap : Negyzet
        {
            public int BOldal { get; set; }

            public Teglalap(int aOldal, int bOldal) : base(aOldal)
            {
                this.BOldal = bOldal;
            }

            new public int TeruletSzamol()
            {
                return this.AOldal * this.BOldal;
            }

            new public int KeruletSzamol()
            {
                return (this.AOldal + this.BOldal) * 2;
            }

            new public void Kiir(Negyzet negy)
            {
                Console.WriteLine($"A négyzet kerülete:{negy.KeruletSzamol()}");
            }

            public Teglalap()
            {

            }
        }

    }
}
