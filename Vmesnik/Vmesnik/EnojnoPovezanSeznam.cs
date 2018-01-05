using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vmesnik
{
    class EnojnoPovezanSeznam<T> : IEnojnoPovezanSeznam<T>
    {
        public class Vozel<T>
        {
            public T vsebina { get; set; }
            public Vozel<T> naslednji { get; set; }

            public Vozel(T vsebina, Vozel<T> naslednji)
            {
                this.vsebina = vsebina;
                this.naslednji = naslednji;
            }

            public Vozel(T vsebina)
            {
                this.vsebina = vsebina;
            }
        }


        public Vozel<T> prvi { get; set; }
        
        public int Dolzina()
        {
            int dolzina = 0;
            while (prvi != null)
            {
                dolzina++;
                prvi = prvi.naslednji;
            }
            return dolzina;
        }

        public void DodajNaVrh(T podatek)
        {
            Vozel<T> nov = new Vozel<T>(podatek); // Ko kličemo metodo, že vemo, kakšnega tipa so argumenti
            nov.naslednji = prvi;
            prvi = nov;
        }

        public void Dodaj(T podatek, int mesto)
        {
            Vozel<T> prejsnjiVozel = prvi;
            Vozel<T> naslednjiVozel = prvi.naslednji;
            while (mesto > 0)
            {
                prejsnjiVozel = prejsnjiVozel.naslednji;
                naslednjiVozel = naslednjiVozel.naslednji;
                mesto--;
            }
            // Prišli smo na mesto, kamor dodamo nov vozel. Sedaj prevežemo.
            Vozel<T> nov = new Vozel<T>(podatek);
            prejsnjiVozel.naslednji = nov;
            nov.naslednji = naslednjiVozel;
        }

        public void Odstrani(int mesto)
        {
            Vozel<T> kjeSmo = prvi;
            while (mesto > 0)
            {
                kjeSmo = kjeSmo.naslednji;
                mesto--;
            }
            // Odstranimi element tako, da preskočimo vozel
            kjeSmo = kjeSmo.naslednji;
        }

        public T VrednostNaMestu(int mesto)
        {
            Vozel<T> kjeSmo = prvi;
            while (mesto > 0)
            {
                kjeSmo = kjeSmo.naslednji;
                mesto--;
            }
            return kjeSmo.vsebina;
        }

        public override string ToString()
        {
            string niz = "";
            while (prvi != null)
            {
                niz += prvi.vsebina + " ";
                prvi = prvi.naslednji;
            }
            return niz;
        }
        
    }


}
