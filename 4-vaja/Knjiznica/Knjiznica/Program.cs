using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = NakljucnaTabela(10, 4);
            Console.WriteLine(TabelaKotNiz(tab));

        }
        /// <summary>
        /// Ustvari tabelo dolžine d, ki vsebuje naključna naravna števila do m.
        /// </summary>
        /// <param name="d">Dolžina tabele.</param>
        /// <param name="m">Vsebina tabele.</param>
        /// <returns></returns>
        static int[] NakljucnaTabela(int d, int m)
        {
            int[] tab = new int[d];
            Random iterator = new Random();
            for (int i=0; i<d; i++)
            {
                int stevilo = iterator.Next(1, m + 1);
                tab[i] = stevilo;
            }
            return tab;
        }

        /// <summary>
        /// Vrne vsebino tabele v obliki niza.
        /// </summary>
        /// <param name="t">Tabela števil.</param>
        /// <returns>Niz.</returns>
        static String TabelaKotNiz(int[] t)
        {
            String vsebina = "";
            for (int i=0; i<t.Length; i++)
            {
                vsebina += t[i];
                vsebina += " ";
            }
            return vsebina.Substring(0, vsebina.Length - 1);
        }

        

    }
}
