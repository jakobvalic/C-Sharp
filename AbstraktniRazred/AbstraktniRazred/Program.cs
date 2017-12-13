using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraktniRazred
{
    class Program  {
        static void Main(string[] args)
        {
            Trikotnik trikotnik = new Trikotnik();
            trikotnik.koordinate(12, 4);
            trikotnik.opisi();

            Umetnik joze = new Umetnik("Jože");
            Console.WriteLine(joze.ToString());
            joze.opisi();

            Slikar rihard = new Slikar("Janez Rihard Jakopič");
            rihard.opisi();
    }  }

    abstract class Lik
    {
        public abstract void premakni(int x, int y);

        public virtual void opisi()
        {
            Console.Write("Katerikoli lik. ");
        }

        public void koordinate(int x, int y)
        {
            Console.WriteLine("Lik se nahaja na koordinatah x = " + x + " in y = " + y);
        }  }

    class Trikotnik : Lik
    {

        public override void opisi()
        {
            base.opisi();
            Console.WriteLine("Bolj natančno trikotnik.");
        }

        public override void premakni(int x, int y)
        {
            Console.WriteLine();
        }
    }

    class Umetnik
    {
        string ime;

        public Umetnik (string ime)
        {
            this.ime = ime;
        }

        public void opisi()
        {
            Console.WriteLine(ime);
        }

        public override string  ToString ()
        {
            return String.Format("To je razred umetnik z imenom {0}.", ime);
        }
    }

    class Slikar : Umetnik
    {
        public Slikar(string ime) : base(ime)
        {
            // To do
        }
        
        public void opisi()
        {
            base.opisi();
            Console.WriteLine("Jaz sem umetnik");
        }
    }
    

}
