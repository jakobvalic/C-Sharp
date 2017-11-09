using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace Album
{
    class Program
    {
        

        static void Main(string[] args)
        {
            for (int i=0; i<1000; i++)
            {
                int velikostAlbuma = 200;
                Console.Write(String.Format("Polnjenje albuma številka {0}: za {1} sličic smo morali kupiti: ", i + 1, velikostAlbuma));
                System.Threading.Thread.Sleep(100);
                List<int> t = AlbumMnozica(velikostAlbuma, 10); // Drugače vrne isti rezultat za več zaporednih klicev funkcije.
                //Console.WriteLine(String.Join(" ", t));
            }
        }

        /// <summary>
        /// Že izžrebane številke shranjuje v množico. Vrne število sličic, ki smo jih kupili.
        /// </summary>
        /// <param name="velikostAlbuma"></param>
        /// <param name="velikostPaketa"></param>
        /// <returns></returns>
        static List<int> AlbumMnozica(int velikostAlbuma, int velikostPaketa)
        {
            int stevecKartic = 0;
            Random genNaklj = new Random();
            HashSet<int> razlicne = new HashSet<int>();
            while (razlicne.Count != velikostAlbuma)
            {
                int novoNaklj = genNaklj.Next(0, velikostAlbuma) + 1;
                // Console.Write(novoNaklj);
                razlicne.Add(novoNaklj);
                stevecKartic++;
            }
            List<int> urejenSeznam = razlicne.ToList();
            urejenSeznam.Sort();
            Console.WriteLine(stevecKartic);
            return urejenSeznam;
        }



        //static int[] AlbumAlgoritem(int velikostAlbuma, int velikostPaketa)
        //{
        //    Random genNaklj = new Random();
        //    int[] kupimo = new int[velikostPaketa];
        //    for (int i=0; i<velikostPaketa; i++)
        //    {
        //        kupimo[i] = i;
        //    }
        //    for (int i=0; i<velikostAlbuma; i++)
        //    {
        //        int izbira = genNaklj.Next(i, velikostPaketa);
        //        int pomozni = kupimo[i];
        //        kupimo[i] = kupimo[izbira];
        //        kupimo[izbira] = pomozni;
        //    }
        //    return kupimo.Take(velikostAlbuma).ToArray();    
        //}
    }
}
