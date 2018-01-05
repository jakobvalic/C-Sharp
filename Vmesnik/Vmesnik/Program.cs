using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vmesnik
{
    interface IEnojnoPovezanSeznam<T>
    {
        int Dolzina();
        void Dodaj(T vrednost, int n);
        void Odstrani(int n);
        T VrednostNaMestu(int n);
        string ToString();
    }


    class Program
    {



        static void Main(string[] args)
        {


        }
    }
}
