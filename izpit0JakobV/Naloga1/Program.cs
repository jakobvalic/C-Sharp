using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[]{ 1, 2, 4 };
            int[][] A = new int[][] { new int[] { 1, 4, 3 }, new int[] { 1 }, new int[] { 4, 4, 7, 12, 2, 4, 2, 2, 2, 4} };
            Console.WriteLine(TabelaTabel(A));
            Console.WriteLine(TabelaTabelVsiTipi(new char[][] { new char[] { 'a', 'b' }, new char[] { 'š' }, new char[] { 'i', 'k', 's', 'n' } }));
        }

        public static float TabelaTabel(int[][] glavnaTabela)
        {
            int vsotaDolzin = 0;
            foreach(int[] podtabela in glavnaTabela)
            {
                vsotaDolzin += podtabela.Length;
            }
            return vsotaDolzin / glavnaTabela.Length;
        }

        public static decimal TabelaTabelVsiTipi <T>(T[][] glavnaTabela)
        {
            int vsotaDolzin = 0;
            foreach (T[] podtabela in glavnaTabela)
            {
                vsotaDolzin += podtabela.Length;
            }
            return (decimal) vsotaDolzin / glavnaTabela.Length;
        }




    }
}
