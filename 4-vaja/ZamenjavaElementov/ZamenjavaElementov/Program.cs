using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamenjavaElementov
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] a = { 1, 2, 3 }; int[] b = Kopija(a);
                Console.WriteLine("Prej: "); Izpisi("a", a); Izpisi("b", b);
                a[1] = b[2]; a[2] = b[1];
                Console.WriteLine("\nPotem: "); Izpisi("a", a); Izpisi("b", b);
            }
        

        static int[] Kopija(int[] t) {
            int[] novaT = new int[t.Length];
            for (int i=0; i<t.Length; i++)
            {
                novaT[i] = t[i];
            }
            return novaT; }

        static void Izpisi(string ime, int[] t) {
            Console.Write(ime + ": ");
            for (int i=0; i<t.Length; i++)
            {
                Console.Write(t[i] + " ");
            }
        }
    }
}
