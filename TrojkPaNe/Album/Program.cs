using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] t = Album(10, 40);
            Console.WriteLine(String.Join(" ", t));
        }


        static int[] Album(int velikostAlbuma, int velikostPaketa)
        {
            Random genNaklj = new Random();
            int[] kupimo = new int[velikostPaketa];
            for (int i=0; i<velikostPaketa; i++)
            {
                kupimo[i] = i;
            }
            for (int i=0; i<velikostAlbuma; i++)
            {
                int izbira = genNaklj.Next(i, velikostPaketa);
                int pomozni = kupimo[i];
                kupimo[i] = kupimo[izbira];
                kupimo[izbira] = pomozni;
            }
            return kupimo.Take(velikostAlbuma).ToArray();

              
        }
    }
}
