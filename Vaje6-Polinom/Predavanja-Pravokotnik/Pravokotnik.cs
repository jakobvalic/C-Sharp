using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanja_Pravokotnik
{
    class Pravokotnik
    {
        private int a_ { get; set; }
        private int b_ { get; set; }

        public Pravokotnik(int steviloA, int steviloB)
        {
            a = steviloA; // Uporabimo lastnost a
            b = steviloB; // Uporabimo lastnost b
        }

        /// <summary>
        /// Lastnost a
        /// </summary>
        public int a
        {
            get { return a_; }
            set
            {
                if (value <= 0) throw new Exception("Stranica a ne more biti negativna.");
                a_ = value;
            }
        }

        /// <summary>
        /// Lastnost b
        /// </summary>
        public int b
        {
            get { return b_; }
            set
            {
                if (value <= 0) throw new Exception("Stranica b ne more biti negativna.");
                b_ = value;
            }
        }

    }
}
