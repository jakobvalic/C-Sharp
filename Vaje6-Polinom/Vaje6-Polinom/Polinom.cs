using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje6_Polinom
{
    partial class Polinom
    {
        private int[] Koeficienti;

        public Polinom() : this(new int[0])
        {
        }

        public Polinom(int a0) : this(new int[] { a0 })
        {
        }

        public Polinom(int a0, int a1) : this(new int[] { a0, a1 })
        {
        }

        public Polinom(int[] koef)
        {
            // Koeficienti = koef; // Tako ne smemo pisati, ker v tem primeru Koeficienti kažejo na koef
            Koeficienti = new int[koef.Length];
            Array.Copy(koef, Koeficienti, koef.Length);
            PobrisiPrazneKoeficiente();
        }

        /// <summary>
        /// Izbriše vse prazne koeficiente na koncu
        /// </summary>
        private void PobrisiPrazneKoeficiente()
        {
            while (Koeficienti.Length > 0 && Koeficienti[Koeficienti.Length - 1] == 0)
            {
                // Izbrišemo zadnji koeficient, ki je 0
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

        /// <summary>
        /// Spremeni koeficient polinoma. Če tega koeficienta še ni, ga doda.
        /// </summary>
        /// <param name="i">Indeks koeficienta.</param>
        /// <param name="a">Nova vrednost koeficienta.</param>
        public void NastaviKoeficient(int i, int a)
        {
            if (i > Koeficienti.Length) { 
                int[] daljsaTab = new int[i + 1]; // Ustvarimo daljšo tabelo
                daljsaTab[i] = a;
                for (int ind=0; ind<Koeficienti.Length; ind++) // Prepišemo ostale koeficiente
                {
                    daljsaTab[ind] = Koeficienti[ind];
                }
                Koeficienti = daljsaTab; // Preusmerimo kazalec
            }
            else
            {
                Koeficienti[i] = a;
            }
        }

        public int Stopnja
        {
            get
            {
                if (Koeficienti.Length == 0)
                {
                    return -1;
                }
                return Koeficienti.Length;
            }
            set { }

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

        /// <summary>
        /// Pomnožimo koeficiente s faktorjem k.
        /// </summary>
        /// <param name="k">Faktor</param>
        /// <returns></returns>
        public Polinom Produkt(int k)
        {
            int[] koefProdukta = new int[Koeficienti.Length];
            for (int i = 0; i < Koeficienti.Length; i++)
            {
                koefProdukta[i] = Koeficienti[i] * k;
            }
            return new Polinom(koefProdukta);
        }

        /// <summary>
        /// Pomnožimo dva polinoma.
        /// </summary>
        /// <param name="p">Polinom, s katerim množimo.</param>
        /// <returns></returns>
        public Polinom Produkt(Polinom p)
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
