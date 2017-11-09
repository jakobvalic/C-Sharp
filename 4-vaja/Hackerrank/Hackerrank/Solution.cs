using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Solution
    {
        /// <summary>
        /// Prebere vnose in za vsakega izpiše, ali vsebuje vse črke besede "hackerrank" v pravilnem zaporedju.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            String hack = "hackerrank";
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0=0; a0<q; a0++)
            {
                int indexHack = 0;
                Boolean vsebuje = false;
                String s = Console.ReadLine();
                for (int i=0; i<s.Length; i++)
                {
                    if (s[i] == hack[indexHack])
                    {
                        indexHack++;
                    }
                    if (indexHack == hack.Length - 1)
                    {
                        vsebuje = true;
                        break;
                    }
                }
                if (vsebuje) {
                    Console.WriteLine("YES");
                }
                else { Console.WriteLine("NO"); }
            }
        }
    }
}
