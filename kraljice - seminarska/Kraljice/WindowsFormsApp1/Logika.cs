using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class Logika
    {

        public List<int[,]> korakiPosamezneRešitve = new List<int[,]>(); // V ta seznam shranimo korake posamezne rešitve.
        public List<string> opisKorakovPosamezneRešitve = new List<string>(); // Shranjujemo opis posameznega koraka.
        public List<int[,]> vseRešitve = new List<int[,]>();

        /// <summary>
        /// Funkcija, ki poišče vse rešitve in jih izpiše v konzolo. 
        /// </summary>
        /// <param name="grafika"></param>
        /// <param name="sahovnica"></param>
        public void Krovna_funkcija_konzola(int[,] sahovnica)
        {

            Boolean izpis = true;

            for (int stevec_resitev = 1; stevec_resitev <= 92; stevec_resitev++)
            {
                int[,] resitev = Postavljaj_kraljice(sahovnica);

                if (resitev[0, 0] == -1) // Preverimo zaustavitveni pogoj, ki se sproži takrat, ko premaknemo kraljico v prvi vrstici s šahovnice
                {
                    break;
                }
                if (izpis)
                {
                    Console.Out.WriteLine(String.Format("Reštev številka {0}:", stevec_resitev));
                    Izpisi_sahovnico(resitev);
                    Console.Out.WriteLine();
                }
                sahovnica = resitev; // Nadaljno rešitev dobimo iz predhodnje. :)
            }
        }

        /// <summary>
        /// Funkcija, ki poišče vse rešitve problema osmih kraljic in jih shrani v seznam.
        /// </summary>
        /// <param name="sahovnica">Na začetku prazna šahovnica.</param>
        public void PoiščiVseRešitve(int[,] sahovnica)
        {
            ShraniŠahovnico(sahovnica, vseRešitve); // Dodamo začetno sliko
            int steviloRešitev = 1;
            while (sahovnica[0, 0] != -1) // TODO: Začetni pogoj ne deluje
            {
                sahovnica = Postavljaj_kraljice(sahovnica, false);
                ShraniŠahovnico(sahovnica, vseRešitve); // Dodamo posamezno rešitev
                if (steviloRešitev >= 92) // Namesto začetnega pogoja. Vemo, da je vseh rešitev 92. 
                {
                    break;
                }
                steviloRešitev++;
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
        /// <returns>Seznam s pozicijami napadajočih kraljic. Če take kraljice ni, vrne prazen seznam.</returns>
        public static List<int[]> Dovoljeno_polje(int[,] sahovnica, int[] kraljica)
        {
            List<int[]> pozicijaNapadajočihKraljic = new List<int[]>();
            if (sahovnica[kraljica[0], kraljica[1]] != 0) // Če polje, na katero želimo dati kraljico slučajno ni prosto.
            {
                pozicijaNapadajočihKraljic.Add(kraljica);
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
                        pozicijaNapadajočihKraljic.Add(new int[] { i, j });
                    }
                }
            }
            return pozicijaNapadajočihKraljic;
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
        /// Označi napadajoče kraljice.
        /// </summary>
        /// <param name="sahovnica"></param>
        /// <param name="napadajočeKraljice"></param>
        /// <returns>Šahovnico s pobarvanimi napadajočimi kraljicami.</returns>
        public int[,] označiNapadajočeKraljice(int[,] sahovnica, List<int[]> napadajočeKraljice)
        {
            foreach (int[] napadajočaKraljica in napadajočeKraljice)
            {
                int iNapadajočeKraljice = napadajočaKraljica[0];
                int jNapadajočeKraljice = napadajočaKraljica[1];
                sahovnica[iNapadajočeKraljice, jNapadajočeKraljice] = 3; // Rdeče-belo obarvamo kraljico, ki napada
            }
            return sahovnica;
        }

        /// <summary>
        /// Napadajoče kraljice ponastavi na 1, jih obarva nazaj v belo barvo. 
        /// </summary>
        /// <param name="šahovnica"></param>
        /// <param name="napadajočeKraljice"></param>
        public void odznačiNapadajočeKraljice(int[,] šahovnica, List<int[]> napadajočeKraljice)
        {
            foreach (int[] napadajočaKraljica in napadajočeKraljice) // Ponastavimo napadajoče kraljice
            {
                int iNapadajočeKraljice = napadajočaKraljica[0];
                int jNapadajočeKraljice = napadajočaKraljica[1];
                šahovnica[iNapadajočeKraljice, jNapadajočeKraljice] = 1;
            }
        }

        /// <summary>
        /// Postavlja kraljice in jih premika, dokler ne dobi mesta, na katerem je lahko naslednja kraljica.
        /// Če ne more postaviti kraljice na nobeno mesto v vrstici, pokliče funkcijo za premikanje kraljic.
        /// </summary>
        /// <param name="sahovnica">Šahovnica.</param>
        /// <param name="shraniKorake">True, kadar iščemo posamezno rešitev, false ko iščemo vse rešitve.</param>
        /// <returns>Šahovnico z eno kraljico več.</returns>
        public int[,] Postavljaj_kraljice(int[,] sahovnica, Boolean shraniKorake = true)
        {
            if (shraniKorake)
            {
                ShraniŠahovnico(sahovnica, korakiPosamezneRešitve);
                opisKorakovPosamezneRešitve.Add("Prosto polje.");
            }
            int n = (int)Math.Sqrt(sahovnica.Length);
            int[] kraljica = Poisci_zadnjo_kraljico(sahovnica);
            int i_zadnje_kraljice = kraljica[0];
            int j_zadnje_kraljice = kraljica[1];
            if (i_zadnje_kraljice == (n - 1))
            {
                return Premakni_kraljico_za_eno_naprej(sahovnica, shraniKorake);
            }
            for (int i = i_zadnje_kraljice + 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    List<int[]> napadajočeKraljice = Dovoljeno_polje(sahovnica, new int[] { i, j });
                    if (napadajočeKraljice.Count == 0) // Dobili smo mesto, na katero lahko postavimo kraljico.
                    {
                        sahovnica[i, j] = 1;
                        if (shraniKorake)
                        {
                            ShraniŠahovnico(sahovnica, korakiPosamezneRešitve);
                            if (i == 7) // Postavili smo kraljico v zadnji vrstici
                            {
                                opisKorakovPosamezneRešitve.Add("Dobili smo rešitev. :)");
                            }
                            else
                            {
                                opisKorakovPosamezneRešitve.Add("Prosto polje.");
                            }
                        }
                        break;
                    }
                    else if (shraniKorake) // Na želeno polje ne moremo postaviti kraljice. Shranimo korak s ponazoritvijo nedovoljenega polja.
                    {
                        označiNapadajočeKraljice(sahovnica, napadajočeKraljice);
                        sahovnica[i, j] = 2; // Premikajočo kraljico obarvamo rdeče.
                        ShraniŠahovnico(sahovnica, korakiPosamezneRešitve);
                        opisKorakovPosamezneRešitve.Add("Napadeno polje.");
                        sahovnica[i, j] = 0; // Ponastavimo
                        odznačiNapadajočeKraljice(sahovnica, napadajočeKraljice);
                    }
                }
                // Če v trenutni vrstici nismo mogli postaviti kraljice, pokličemo funkcijo za premikanje kraljic.
                Boolean kraljica_je_v_vrstici = false;
                for (int j = 0; j < n; j++)
                {
                    if (sahovnica[i, j] == 1)
                    {
                        kraljica_je_v_vrstici = true;
                        break;
                    }
                }
                if (!kraljica_je_v_vrstici)
                {
                    return Premakni_kraljico_za_eno_naprej(sahovnica, shraniKorake);
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
        /// <param name="shraniKorake">Določa, ali shranimo korake posamezne rešitve.</param>
        /// <returns>Šahovnico s premaknjeno kraljico.</returns>
        public int[,] Premakni_kraljico_za_eno_naprej(int[,] sahovnica, Boolean shraniKorake)
        {
            if (shraniKorake)
            {
                ShraniŠahovnico(sahovnica, korakiPosamezneRešitve);
                opisKorakovPosamezneRešitve.Add("Popravimo zgornjo vrsto.");
            }
            int n = (int)Math.Sqrt(sahovnica.Length);
            int[] kraljica = Poisci_zadnjo_kraljico(sahovnica);
            int i = kraljica[0];
            int j_zadnje_kraljice = kraljica[1];
            if (i == -1 && j_zadnje_kraljice == -1)
            {
                Console.Out.Write("Našli smo vse rešitve. :)");
                return sahovnica;
            }
            sahovnica[i, j_zadnje_kraljice] = 0; // Odmaknemo kraljico
            for (int j = j_zadnje_kraljice + 1; j < 8; j++)
            {
                List<int[]> napadajočeKraljice = Dovoljeno_polje(sahovnica, new int[] { i, j });
                if (napadajočeKraljice.Count == 0) // Nobena kraljice ne napada polja.
                {
                    sahovnica[i, j] = 1; // Na prosto polje postavimo kraljico.
                    return Postavljaj_kraljice(sahovnica, shraniKorake); // Postavljamo naprej kraljice.
                }
                else if (shraniKorake)
                {
                    označiNapadajočeKraljice(sahovnica, napadajočeKraljice);
                    sahovnica[i, j] = 2; // Premikajočo kraljico obarvamo rdeče.
                    ShraniŠahovnico(sahovnica, korakiPosamezneRešitve);
                    opisKorakovPosamezneRešitve.Add("Napadeno polje.");
                    sahovnica[i, j] = 0; // Ponastavimo
                    odznačiNapadajočeKraljice(sahovnica, napadajočeKraljice);
                }

            }
            // Zanka se je iztekla in v vrstici nismo dobili polja, na katerega bi lahko postavili kraljico. 
            // Zato začnemo premikati kraljico, ki je v zgornji vrstici. 
            return Premakni_kraljico_za_eno_naprej(sahovnica, shraniKorake);
        }


        public int[,] KopirajŠahovnico(int[,] šahovnica)
        {
            int[,] kopija =  {{0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0} };
            int n = (int)Math.Sqrt(šahovnica.Length);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    kopija[i, j] = šahovnica[i, j];
                }
            }
            return kopija;
        }

        /// <summary>
        /// Naredimo kopijo šahovnice in jo shranimo v seznam posameznih korakov. 
        /// </summary>
        /// <param name="šahovnica"></param>
        /// <param name="seznamShranjevanja">Določa, v kateri seznam shranimo šahovnico.</param>
        public void ShraniŠahovnico(int[,] šahovnica, List<int[,]> seznamShranjevanja)
        {
            int[,] kopija = KopirajŠahovnico(šahovnica);
            seznamShranjevanja.Add(kopija);
        }

    }
}
