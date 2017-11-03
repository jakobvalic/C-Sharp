using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Knjiznica
{
    class Knjiznica
    {
        public static int[] NakljucnaTabela(int d, int m)
        {
            Random nakljucnaSt = new Random();
            int[] tabNakljSt = new int[d];
            for (int i=0; i<d; i++)
            {
                tabNakljSt[i] = nakljucnaSt.Next(1, m + 1);
            }
            return tabNakljSt;
        }

        public static string TabelaKotNiz(int[] t)
        {
            return Tabela.Izpisi(t, " ");
        }

        public static int[] NizKotTabela(string s)
        {
            string[] tabelaNizov = s.Split(new char[] { ' ' }, StringSplitOptions.None);
            int[] tabelaStevil = new int[tabelaNizov.Length];
            for (int i=0; i<tabelaNizov.Length; i++)
            {
                tabelaStevil[i] = Int32.Parse(tabelaNizov[i]); 
            }
            TabelaKotNiz(tabelaStevil);
            return tabelaStevil;
        }

    }
}
