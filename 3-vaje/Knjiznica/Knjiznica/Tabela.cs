using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica
{
    class Tabela
    {

        public static void PreveriKopije()
        {
            int[] tab = new int[] { 1, 2, 4 };
            int[] kopija = Kopija(tab);
            kopija[0] = 17;
            Izpisi(tab);
            Izpisi(kopija);
        }


        static int[] Kopija(int[] t)
        {
            int[] novaT = new int[(t.Length)];
            for (int i = 0; i < t.Length; i++)
            {
                novaT[i] = t[i];
            }
            return novaT;
        }

        public static String Izpisi(int[] t, String lepilo=":")
        {
            String izpis = "";
            for (int i = 0; i < t.Length; i++)
            {
                izpis += t[i] + lepilo;
            }
            Console.WriteLine(izpis.Substring(0, izpis.Length - 1));
            return izpis.Substring(0, izpis.Length - 1);
        }
    }
}
