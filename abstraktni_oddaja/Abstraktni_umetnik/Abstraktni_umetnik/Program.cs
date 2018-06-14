using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktni_umetnik
{
    class Program
    {
        static void Main(string[] args)
        {

            Umetnik Joško = new Umetnik("Jože", "Dolinšek", 5, "Črnomelj");
            Console.Out.WriteLine(Joško.opisi_umetnika());

            Slikar Mare = new Slikar("Mare", "Gorišek", 5, "Jelenov Žleb", "voščenke");
            Console.Out.WriteLine(Mare.opisi_umetnika());
            Console.Out.WriteLine(Mare.opisi_tehniko());

        }
    }

    class Umetnik
    {
        protected string ime;
        protected string priimek;
        protected int stevilo_ur_dnevno;
        protected string kraj_delovanja;

        public Umetnik(string ime, string priimek, int stevilo_ur_dnevno, string kraj_delovanja)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.kraj_delovanja = kraj_delovanja;
            this.stevilo_ur_dnevno = stevilo_ur_dnevno;
        }

        public string opisi_umetnika()
        {
            return String.Format("To je umetnik {0} {1}, ki deluje v kraju {2}. Ustvarja " +
                "povprečno {3} ur dnevno.",ime, priimek, kraj_delovanja, stevilo_ur_dnevno);
        }
    }

    class Slikar : Umetnik
    {
        private string tehnika;
        public Slikar(string ime, string priimek, int stevilo_ur_dnevno, string kraj_delovanja, 
            string tehnika) : base(ime, priimek, stevilo_ur_dnevno, kraj_delovanja)
        {
            this.tehnika = tehnika;
        }

        public string opisi_tehniko()
        {
            return String.Format("Slikar {0} {1} najraje ustvarja svoje umetnine " +
                "s tehniko {2}.", ime, priimek, tehnika);
        }
    }     
              
            
    
    



}
