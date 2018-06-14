using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Umetnik Florencij = new Slikar();
            //Florencij.opisUmetnika();
            Console.Out.WriteLine();
            Glasbenik Tino = new Flavtist("Tino", "prečno");
            Console.Out.WriteLine();
            Tino.opisUmetnika("Ty");
            
        }
    }

    abstract class Umetnik
    {
        public abstract void opisUmetnika(string Umjetnik);
    }

    abstract class Glasbenik : Umetnik
    {
        protected string ime;

        protected Glasbenik(string ime)
            {
            this.ime = ime;
            }
    }

    class Flavtist : Glasbenik
    {
        private string tip_flavte;
            
        public Flavtist(string ime, string tip_flavte) : base(ime)
        {
            this.tip_flavte = tip_flavte;
        }

        public override void opisUmetnika(string U)
        {
            Console.Out.WriteLine(String.Format("To je flavtist {0}, " +
                "ki igra na {1} flavto.", ime, tip_flavte));
        }
    }

    
}
