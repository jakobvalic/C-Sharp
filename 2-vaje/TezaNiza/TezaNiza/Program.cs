using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezaNiza
{
    class Program
    {
        // Izračuna težo slovenskega niza
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtnica: angleška");
            Console.Write("Vnesi niz: ");
            int vsota = 0;

            string vnos = Console.ReadLine();
            for (int i = 0; i < vnos.Length; i++)
            {
                char znak = vnos[i];
                if (('a' <= znak && znak <= 'z') || ('A' <= znak && znak <= 'z')) 
                {
                    string znakString = znak + "";
                    string maliZnakString = znakString.ToLower();
                    vsota += char.Parse(maliZnakString) - 'a' + 1;
                    Console.WriteLine(maliZnakString + " ima vrednost " + (0 + char.Parse(maliZnakString) - 'a' + 1));
                }

            }
            Console.WriteLine("Teža niza je " + vsota);
            Console.WriteLine("\"");
        }
    }
}
