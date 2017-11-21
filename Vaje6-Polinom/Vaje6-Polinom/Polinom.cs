using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje6_Polinom
{
    class Polinom
    {
        private int[] Koeficienti;

        public Polinom()
        {
            Koeficienti = new int[0];
        }

        public Polinom(int a0)
        {
            Koeficienti = new int[] { a0 };
        }

        public Polinom(int a0, int a1)
        {
            Koeficienti = new int[] { a0, a1 };
        }

        public Polinom(int[] koef)
        {
            // Koeficienti = koef; // Tako ne smemo pisati, ker v tem primeru Koeficienti kažejo na koef
            Koeficienti = new int[koef.Length];
            for (int i=0; i<koef.Length; i++)
            {
                Koeficienti[i] = koef[i];
            }
        }
        
        /// <summary>
        /// Naredi kopijo polinoma p. Dostop do koeficientov preko metode Polinom.Koeficient(i).
        /// </summary>
        /// <param name="p"></param>
        public Polinom(Polinom p)
        {
            int[] koef = new int[p.Stopnja()];
            for (int i=0; i<=p.Stopnja(); i++)
            {
                koef[i] = p.Koeficienti[i];
            }
        }

        public override string ToString()
        {
            string niz = "";
            for (int i=0; i<Koeficienti.Length; i++)
            {
                niz += Koeficienti[i] + String.Format("x^{0} ", i);
            }
            return niz;
        }

        public int Koeficient(int i)
        {
            return Koeficienti[i];
        }

        public void NastaviKoeficient(int i, int a)
        {
            if (i > Koeficienti.Length) { 
                int[] daljsaTab = new int[i]; // Ustvarimo daljšo tabelo
                daljsaTab[i] = a;
                for (int ind=0; ind<Koeficienti.Length; ind++) // Prepišemo ostale koeficiente
                {
                    daljsaTab[i] = Koeficienti[i];
                }
            }
            else
            {
                Koeficienti[i] = a;
            }
        }

        public int Stopnja()
        {
            if (Koeficienti.Length == 0)
            {
                return -1;
            }
            return Koeficienti.Length;
        }

        public int Vrednost(int x)
        {
            int vrednost = 0;
            for (int i=0; i<Koeficienti.Length; i++)
            {
                vrednost += Koeficienti[i] * (int) Math.Pow(x, i);
            }
            return vrednost;
        }

        public bool JeEnak(Polinom p)
        {
            if (Koeficienti.Length != p.Koeficienti.Length)
            {
                return false;
            }
            for (int i=0; i<Koeficienti.Length; i++)
            {
                if (Koeficienti[i] != p.Koeficienti[i])
                {
                    return false;
                }
            }
            return true;
        }

        public Polinom Vsota(Polinom p)
        {
            int[] koefVsote = new int[Math.Max(Koeficienti.Length, p.Koeficienti.Length)];
            for (int i=0; i<Koeficienti.Length; i++)
            {
                koefVsote[i] = Koeficienti[i] + p.Koeficienti[i];
            }
            return new Polinom(koefVsote);
        }

        public Polinom Produkt(int k)
        {
            int[] koefProdukta = new int[Koeficienti.Length];
            for (int i=0; i<Koeficienti.Length; i++)
            {
                koefProdukta[i] = Koeficienti[i] * k;
            }
            return new Polinom(koefProdukta);
        }

        public Polinom Prodkut(Polinom p)
        {
            int[] koefProdukta = new int[Stopnja() + p.Stopnja() + 1];
            for (int mesto=0; mesto<koefProdukta.Length; mesto++)
            {
                int i = 0;
                while (i <= mesto && i <= Stopnja())
                {
                    int j = mesto - i;
                    if (j <= p.Koeficienti.Length)
                    {
                        koefProdukta[mesto] = Koeficienti[i] * p.Koeficienti[j];
                    }
                    i++;
                }
            }
            return new Polinom(koefProdukta);
            
        }
    }
}
