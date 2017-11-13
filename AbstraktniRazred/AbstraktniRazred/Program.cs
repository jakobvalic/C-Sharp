using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraktniRazred
{
    class Program
    {
        static void Main(string[] args)
        {
            Trikotnik trikotnik = new Trikotnik();
            trikotnik.opisi();
            Lik lik = new Lik();
        }
    }

    abstract class Lik
    {
        public virtual void opisi()
        {
            Console.Write("Katerikoli lik. ");
        }
    }

    class Trikotnik : Lik
    {

        public override void opisi()
        {
            base.opisi();
            Console.WriteLine("Bolj natančno trikotnik.");
        }
    }
}
