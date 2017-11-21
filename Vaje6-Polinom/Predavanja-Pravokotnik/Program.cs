using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanja_Pravokotnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Kvadrat k = new Kvadrat();
            //k.a = 7;
            Console.WriteLine(k.a);

            Console.Write("Vnesi stranico a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Vnesi stranico b: ");
            int b = Int32.Parse(Console.ReadLine());

            Pravokotnik p = new Pravokotnik(a, b);
            Console.WriteLine(p.a + " " + p.b);
        }
    }
}
