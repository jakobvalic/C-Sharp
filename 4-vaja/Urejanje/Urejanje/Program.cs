using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urejanje
{
    class Program
    {
        /// <summary>
        /// Uredi rekurzivno z razbitjem na manjše in večje elemente. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<int> neurejenSez = new List<int> { 3, 4, 2, 1, 1, 3, 2, 5, 7, 6 };
            Izpis(neurejenSez);
            Izpis(Uredi(neurejenSez));
        }

        static void Izpis(List<int> t)
        {
            String izpis = "";
            foreach(int stevilo in t)
            {
                izpis += stevilo + " ";
            }
            Console.WriteLine(izpis);
        }

        static List<int> Uredi(List<int> t)
        {
            if (t.Count <= 1)
            {
                return t;
            }
            int pivot = t[0];
            List<int> manjsi = new List<int>();
            List<int> vecji = new List<int>();
            for (int i=1; i<t.Count; i++)
            {
                if (t[i] > pivot)
                {
                    vecji.Add(t[i]);
                }
                else
                {
                    manjsi.Add(t[i]);
                }
            }
            List<int> pivotList = new List<int>();
            pivotList.Add(pivot);
            return Uredi(manjsi).Concat(pivotList.Concat(Uredi(vecji)).ToList()).ToList();
        }
    }
}
