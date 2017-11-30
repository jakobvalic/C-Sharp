using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje6_Polinom
{
    partial class Polinom
    {
        public static Polinom Vsota(Polinom p, Polinom q)
        {
            int dolzina = Math.Max(p.Stopnja, q.Stopnja) + 1;
            int[] noviKoeficienti = new int[dolzina];
            for (int i = 0; i < dolzina; i++)
            {
                noviKoeficienti[i] = p.Koeficient(i) + q.Koeficient(i);
            }
        }

        public Polinom Produkt(Polinom p)
        {
            if (Stopnja == -1 || p.Stopnja == -1) return new Polinom();

            int novaStopnja = Stopnja + p.Stopnja;
            int[] noviKoef = new int[novaStopnja + 1];
            for (int i = 0; i < Stopnja; i++)
            {
                for (int j = 0; j < p.Stopnja; j++)
                {
                    noviKoef[i + j] = Koeficient(i) * p.Koeficient(j);
                }
            }
            return new Polinom(noviKoef);
        }

        public Polinom Produkt(int k)
        {
            return Produkt(new Polinom(k));
        }

        public static Polinom operator +(Polinom p, Polinom q)
        {
            return p.Vsota(q);
        }

        public static Polinom operator *(Polinom p, Polinom q)
        {
            return p.Produkt(q);
        }

        public static Polinom operator *(Polinom p, int k)
        {
            return p.Produkt(k);
        }

        public static Polinom operator *(int k, Polinom q)
        {
            return q * k;
        }


    }
}


