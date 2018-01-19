using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga2_Stevila
{
    class Program
    {
        static void Main(string[] args)
        {
            Poisci(20, 52);
            Poisci(99, 17);
            Poisci(4, 270);
        }

        /// <summary>
        /// Poišče vsa števila, ki ležijo v intervalu [n, n^2] in vsebujejo a.
        /// </summary>
        /// <param name="n">Začetek intervala.</param>
        /// <param name="a">Vsebovano število.</param>
        /// <returns></returns>
        static List<int> Poisci(int n, int a)
        {
            List<int> vsebujejo = new List<int>();
            string nizA = a.ToString();
            for (int i = n; i <= n * n; i++)
            {
                if (i.ToString().Contains(nizA))
                {
                    vsebujejo.Add(i);
                }
            }
            if (vsebujejo.Count() > 0)
            {
                string vsebovanaStevila = "";
                foreach (int x in vsebujejo)
                {
                    vsebovanaStevila += x.ToString() + ", "; // Bolje delati s String.Join
                }
                vsebovanaStevila = vsebovanaStevila.Substring(0, vsebovanaStevila.Length - 2); // Odstranimo končni ",."
                Console.WriteLine(String.Format("Cela števila iz intervala [{0}, {1}], ki vsebujejo {2} so {3}.", n, n * n, a, vsebovanaStevila));
            }
            else
            {
                Console.WriteLine(String.Format("V intervalu [{0}, {1}] ni celih števil, ki bi v zapisu vsebovala število {2}.", n, n * n, a));
            }
            return vsebujejo;
        }

        // Raje napiši še metodo za preverjanje, ali vsebuje
        static bool Vsebuje(int a, int i)
        {
            return i.ToString().Contains(i.ToString());
        }
    }
}
