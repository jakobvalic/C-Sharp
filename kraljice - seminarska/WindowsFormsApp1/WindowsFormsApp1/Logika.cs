using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MyEventArgs : EventArgs
    {
        public int[,] Sahovnica { get; private set; }

        public MyEventArgs(int[,] sahovnica) : base()
        {
            Sahovnica = sahovnica;
        }
    }

    public class Logika
    {
        public event EventHandler<MyEventArgs> PritisniGumbDodajKraljico;
        
        public void PokličiGrafiko(int[,] sahovnica)
        {

            EventHandler<MyEventArgs> rokovalec = PritisniGumbDodajKraljico;
            if (rokovalec != null)
            {
                MyEventArgs parametri = new MyEventArgs(sahovnica);
                rokovalec(this, parametri);
            }
        }

        /// <summary>
        /// Vrne šahovnico z rešitvijo.
        /// </summary>
        /// <param name="sahovnica">Začetno postavitev, s katere išče rešitve.</param>
        /// <returns>Rešitev.</returns>
        public int[,] Krovna_funkcija(int[,] sahovnica)
        {
            int[,] resitev = Postavljaj_kraljice(sahovnica);
            return resitev;
        }

        /// <summary>
        /// Izpiše vse rešitve v konzolo. 
        /// </summary>
        /// <param name="grafika"></param>
        /// <param name="sahovnica0"></param>
        public void Krovna_funkcija_konzola(int[,] sahovnica0)
        {

            Boolean izpis = true;

            for (int stevec_resitev = 1; stevec_resitev <= 192; stevec_resitev++)
            {
                int[,] resitev = Postavljaj_kraljice(sahovnica0);

                if (resitev[0, 0] == -1) // Preverimo zaustavitveni pogoj, ki se sproži takrat, ko premaknemo kraljico v prvi vrstici s plošče.
                {
                    break;
                }
                if (izpis)
                {
                    Console.Out.WriteLine(String.Format("Reštev številka {0}:", stevec_resitev));
                    Izpisi_sahovnico(resitev);
                    Console.Out.WriteLine();
                }
                sahovnica0 = resitev; // Nadaljno rešitev dobimo iz predhodnje. :)
            }
        }

        /// <summary>
        /// Funkcija za izpis šahovnice v konzoli.
        /// </summary>
        /// <param name="sahovnica"></param>
        public void Izpisi_sahovnico(int[,] sahovnica)
        {
            int n = (int)Math.Sqrt(sahovnica.Length);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Out.Write(sahovnica[i, j]);
                    Console.Out.Write(' ');
                }
                Console.Out.WriteLine();
            }
        }

        /// <summary>
        /// Preveri, ali lahko na dano polje postavimo kraljico.
        /// </summary>
        /// <param name="sahovnica">Šahovnica.</param>
        /// <param name="kraljica">Polje, na katero želimo postaviti kraljico.</param>
        /// <returns></returns>
        public static Boolean Dovoljeno_polje(int[,] sahovnica, int[] kraljica)
        {
            if (sahovnica[kraljica[0], kraljica[1]] != 0)
            {
                return false;
            }
            // 4 smeri premih premikov + 4 smeri diagonalnih premikov
            int[][] premiki = new int[][] { new int[] { 0, -1 }, new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { -1, 0 },
                new int[] { -1, -1 }, new int[] { -1, 1 }, new int[] { 1, -1 }, new int[] { 1, 1 } };
            int n = (int)Math.Sqrt(sahovnica.Length);
            foreach (int[] vektor_premika in premiki)
            {
                int i = kraljica[0];
                int j = kraljica[1];
                int i_vektorja_premika = vektor_premika[0];
                int j_vektorja_premika = vektor_premika[1];
                while (0 <= i + i_vektorja_premika && i + i_vektorja_premika < n && 0 <= j + j_vektorja_premika && j + j_vektorja_premika < n)
                {
                    i = i + i_vektorja_premika;
                    j = j + j_vektorja_premika;
                    if (sahovnica[i, j] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Pove, v kateri vrstici se nahaja zadnja kraljica. Če ni nobene, vrne {-1, -1}.
        /// </summary>
        /// <param name="sahovnica">Šahovnica.</param>
        /// <returns>{indeks_vrstice, indeks_stolpca}</returns>
        public int[] Poisci_zadnjo_kraljico(int[,] sahovnica)
        {
            int n = (int)Math.Sqrt(sahovnica.Length);
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (sahovnica[i, j] == 1)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            // Ni kraljice
            return new int[] { -1, -1 };
        }

        /// <summary>
        /// Postavlja kraljice in jih premika, dokler ne dobi mesta, na katerem je lahko naslednja kraljica.
        /// Če ne more postaviti kraljice na nobeno mesto v vrstici, pokliče funkcijo za premikanje kraljic.
        /// </summary>
        /// <param name="sahovnica">Šahovnica.</param>
        /// <returns>Šahovnico z eno kraljico več.</returns>
        public int[,] Postavljaj_kraljice(int[,] sahovnica)
        {
            int n = (int)Math.Sqrt(sahovnica.Length);
            int[] kraljica = Poisci_zadnjo_kraljico(sahovnica);
            int i_zadnje_kraljice = kraljica[0];
            int j_zadnje_kraljice = kraljica[1];
            if (i_zadnje_kraljice == (n - 1))
            {
                Premakni_kraljico_za_eno_naprej(sahovnica);
            }
            for (int i = i_zadnje_kraljice + 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Dovoljeno_polje(sahovnica, new int[] { i, j })) // Dobili smo mesto, na katero lahko postavimo kraljico.
                    {
                        sahovnica[i, j] = 1;
                    }
                }
                // Če v trenutni vrstici nismo mogli postaviti kraljice, pokličemo funkcijo za premikanje kraljic.
                Boolean kraljica_je_v_vrstici = false;
                for (int j = 0; j < n; j++)
                {
                    if (sahovnica[i,j] == 1) 
                    {
                        kraljica_je_v_vrstici = true;
                        break;
                    }
                }
                if (!kraljica_je_v_vrstici)
                {
                    return Premakni_kraljico_za_eno_naprej(sahovnica);
                }
            }
            // Če kraljice po premikanju ni več v prvi vrstici, smo končali naš algoritem
            Boolean kraljica_je_v_prvi_vrstici = false;
            for (int j = 0; j < n; j++)
            {
                if (sahovnica[0, j] == 1)
                {
                    kraljica_je_v_prvi_vrstici = true;
                    break;
                }
            }
            // Če premaknemo kraljico iz prve vrstice s šahovnice, smo dobili vse rešitve.
            if (!kraljica_je_v_prvi_vrstici)
            {
                return new int[,] { { -1 } }; // Zaustavitveni pogoj.
            }
            // Dobili smo rešitev
            return sahovnica;
        }

        /// <summary>
        /// Premakne kraljico na prvo prosto polje v vrstici.
        /// </summary>
        /// <param name="sahovnica"></param>
        /// <returns>Šahovnico s premaknjeno kraljico.</returns>
        public int[,] Premakni_kraljico_za_eno_naprej(int[,] sahovnica)
        {
            int n = (int)Math.Sqrt(sahovnica.Length);
            int[] kraljica = Poisci_zadnjo_kraljico(sahovnica);
            int i_zadnje_kraljice = kraljica[0];
            int j_zadnje_kraljice = kraljica[1];
            if (i_zadnje_kraljice == -1 && j_zadnje_kraljice == -1)
                {
                Console.Out.Write("Našli smo vse rešitve. :)");
                return sahovnica;
                }
            sahovnica[i_zadnje_kraljice, j_zadnje_kraljice] = 0; // Odmaknemo kraljico
            for (int j = j_zadnje_kraljice + 1; j < 8; j++)
            {
                if (Dovoljeno_polje(sahovnica, new int[] { i_zadnje_kraljice, j }))
                {
                    sahovnica[i_zadnje_kraljice, j] = 1; // Dobili smo prosto polje, na katero lahko postavimo kraljico.
                    return Postavljaj_kraljice(sahovnica); // Postavljamo naprej kraljice.
                }

            }
            // Zanka se je iztekla in v vrstici nismo dobili polja, na katerega bi lahko postavili kraljico. 
            // Zato začnemo premikati kraljico, ki je v zgornji vrstici. 
            return Premakni_kraljico_za_eno_naprej(sahovnica);
        }
  
    }
}
