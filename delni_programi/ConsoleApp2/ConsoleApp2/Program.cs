using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo v = new Vozilo(4.4, 700, 50);
            Console.WriteLine(v.getGorivo());
            Console.Write("Vpiši število: ");
            String niz = Console.ReadLine();
            Console.WriteLine(double.Parse(niz));
        }
    }

    class Vozilo
    {
        private int tovorMax;
        private int tovorTrenutni;
        private double gorivoMax;
        private double gorivoTrenutno;
        private double poraba;

        public Vozilo(double p, int k, double g)
        {
            tovorMax = k;
            tovorTrenutni = 0;
            gorivoMax = g;
            gorivoTrenutno = g;
            poraba = p;
        }

        public void spremeniTovor(int tovor)
        {
            tovorTrenutni += tovor;
        }

        public double getGorivo()
        {
            return gorivoTrenutno;
        }

    }
}
