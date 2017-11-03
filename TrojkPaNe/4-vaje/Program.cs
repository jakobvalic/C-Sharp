using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrojkPaNe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 2, 33, 4333, 3353 };
            String izpis = String.Join(" ", tab);
            Console.WriteLine(izpis);
            int[] oskubljenaTabela = ZbrisiStevke(3, ref tab);
            Console.WriteLine(String.Join(" ", oskubljenaTabela));
        }

        static int[] ZbrisiStevke(int stevka, ref int[] tab)
        {
            List<int> brezStevk = new List<int>();
            foreach (int st in tab)
            {
                string stNiz = st.ToString();
                stNiz = stNiz.Replace(stevka.ToString(), "");
                if (stNiz.Length > 0)
                {
                    brezStevk.Add(int.Parse(stNiz));
                }
                // Sedaj prevežemo referenco tab na novo tabelo brez števk
            }
            tab = brezStevk.ToArray();
            return tab;
        }

    }
}
