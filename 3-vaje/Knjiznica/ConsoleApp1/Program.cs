using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Solution
    {

        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            String pregled = "hackerrank";
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                int kazalec = 0;
                Boolean vsebuje = false;
                for (int i=0; i<s.Length; i++)
                {
                    if (s[i] == pregled[kazalec]) // Dobili smo naslednjo črko v hackerranku
                        kazalec++;
                    if (kazalec == pregled.Length - 1)
                    {
                        vsebuje = true;
                        break;
                    }
                }
                if (vsebuje)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
                
            }
        }
    }
}
