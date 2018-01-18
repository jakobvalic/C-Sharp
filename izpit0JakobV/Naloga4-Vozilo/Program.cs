using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga4_Vozilo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /// <summary>
    /// Razred za hrambo podatkov o dosegu vozila.
    /// </summary>
    public class Vozilo
    {
        private double gorivo; // Trenutna količina
        private double kapaciteta; // Volumen rezervoarja
        private double poraba; // litrov/100 km

        public Vozilo(double kapaciteta, double poraba)
        {
            this.kapaciteta = kapaciteta;
            this.poraba = poraba;
            gorivo = kapaciteta;
        }

        public double PreostaliKilometri
        {
            get // Lastnost samo za branje, ker nimamo set
            {
                return (gorivo / poraba) * 100; 
            }
        }

        public void Crpalka ()
        {
            gorivo = kapaciteta;
        }

        public bool Prevozi(int dolzinaPoti)
        {
            if (dolzinaPoti <= PreostaliKilometri)
            {
                gorivo -= dolzinaPoti / (poraba * 100);
                return true;
            }
            else
            {
                gorivo = 0;
                return false;
            }
        }
    }
}
