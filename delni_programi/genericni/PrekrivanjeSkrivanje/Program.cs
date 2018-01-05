using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrekrivanjeSkrivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Sin sin1 = new Sin();
            Oce sin2 = new Sin();

            Console.WriteLine(sin1.PrekrijMe());
            Console.WriteLine(sin1.SkrijMe());

            Console.WriteLine(sin2.PrekrijMe());
            Console.WriteLine(sin2.SkrijMe());
            

        }
    }

    class Oce
    {
        public virtual string PrekrijMe()
        {
            return "To je osnovna funkcija za prekrivanje.";
        }

        public string SkrijMe()
        {
            return "To je osnovna funkcija za skrivanje.";
        }
    }

    class Sin : Oce
    {
        public override string PrekrijMe()
        {
            return "Uspešno prekrili.";
        }

        public new string SkrijMe() // Za prekrivanje uporabljamo new
        {
            return "Uspešno skrili"; // Lahko bi celo spremenili tip v int
        }
    }
}
