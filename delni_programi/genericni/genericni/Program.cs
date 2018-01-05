using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericni
{
    public class Neki<G>
    {

        public G Podatek { get; set; }

        public override string ToString()
        {
            return Podatek + "";
        }

        public bool Equals(Neki<G> drugNeki)
        {
            return this.Equals(drugNeki);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabStevil = { 12, 4, 5 };
            char[] tabZnakov = { 'a', ',', 'ž' };
            izpis(tabStevil, tabZnakov);
            izpis(tabZnakov, tabZnakov);

            Neki<int>[] tabNeki = new Neki<int>[3];
            tabNeki[0] = new Neki<int>();
            tabNeki[0].Podatek = 42;
            izpis(tabNeki, tabZnakov);

            Neki<char> nekiZnak = new Neki<char>();
            nekiZnak.Podatek = 'm';
            Console.WriteLine(nekiZnak);
            Console.WriteLine(nekiZnak.Podatek == 'a');

            Console.WriteLine('a'.Equals(12));

        }

        public static void izpis<T, U>(T[] tabela, U[] tabela2)
        {
            foreach(T x in tabela)
            {
                Console.Write(x + " "); // Zato, da pretvorimo v niz
            }
            foreach(U x in tabela2)
            {
                Console.Write(x + " ");
            }
        }

        public static bool AliVsebuje<T>(T[] tab, T isci)
        {
            for (int i=0; i<tab.Length; i++)
            {
                if (tab[i].Equals(isci))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
