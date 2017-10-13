using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugibanje
{
    class Program
    {
        static void Main(string[] args)
        {
            // PitonNaObisku();
            Karo();
            // Boris();
            // Ugibanje();
        }

        static void Karo()
        {
            Console.Write("Vpiši število: ");
            string vnos = Console.ReadLine();
            for (int i = 0; i < vnos.Length; i++)
            {
                char stevka = vnos[i];
                Console.WriteLine(String.Format("Vnešeno je število {0}", stevka));
            }
        }


        static void PitonNaObisku()
        {
            Console.Write("Vnesi celi števili n in k, ločeni z vejico: ");
            string vnos = Console.ReadLine();
            string[] razbij = vnos.Split(new string[] { ", ", " ", "," }, StringSplitOptions.None);
            long n = int.Parse(razbij[0]);
            long k = int.Parse(razbij[1]);
            long i = 1, vsota = 0;
            while (i <= n) {
                vsota += (long) Math.Pow(i, k);
                i++;
            }
            Console.WriteLine(vsota);
        }


        static void Ugibanje()
        {
            int racunalnik = new Random().Next(1, 101);
            int clovek = -1;

            while (clovek != racunalnik)
            {
                Console.Write("Vpiši število med 1 in 100: ");
                string vnos = Console.ReadLine();
                clovek = int.Parse(vnos);
                if (clovek > racunalnik)
                {
                    Console.WriteLine("Manj");
                }
                else if (clovek < racunalnik)
                {
                    Console.WriteLine("Več");
                }
                else
                {
                    Console.WriteLine("Uganil si!");
                }
            }
        }

        static void Boris()
        {
            Console.Write("Masa v regiji A: ");
            double masaA = double.Parse(Console.ReadLine());
            Console.Write("Masa v regiji B: ");
            double masaB = double.Parse(Console.ReadLine());
            int korak = 0;
            double masaAvB, masaBvA;
            while ((masaA + masaB) >= 0.001)
            {
                masaAvB = masaA * 0.22;
                masaBvA = masaB * 0.22;
                masaA = masaA * 0.12 + masaBvA;
                masaB = masaB * 0.12 + masaAvB;
                Console.WriteLine(String.Format("Korak {0}:, masaA: {1}, masaB: {2}", korak, masaA, masaB));
                // Console.WriteLine("Korak: " + korak.ToString() + ", masa A: " + masaA.ToString() + ", masa B: " + masaB.ToString());
                korak++;
            }
        }
    }
}
