using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbiralec_Smeti
{

    class MojZbiralecSmeti
    {
        private const long števec = 1000;

        static void Main()
        {
            MojZbiralecSmeti mojZbiralec = new MojZbiralecSmeti();

            Console.WriteLine("Najvišja generacija je {0}", GC.MaxGeneration);

            mojZbiralec.UstvariSmeti(); 
            mojZbiralec.IzpišiGeneracijo();
            mojZbiralec.IzpišiZasedenSpomin();
            GC.Collect(0); // Počistimo le generacijo 0
            mojZbiralec.IzpišiGeneracijo();
            mojZbiralec.IzpišiZasedenSpomin();
            GC.Collect(2); // Počistimo generacije 0, 1, 2
            mojZbiralec.IzpišiGeneracijo();
            mojZbiralec.IzpišiZasedenSpomin();
            Console.Read();
        }

        void IzpišiGeneracijo()
        {  Console.WriteLine("Generacija: {0}", GC.GetGeneration(this));   }

        void IzpišiZasedenSpomin()
        {  Console.WriteLine("Zaseden spomin: {0}", GC.GetTotalMemory(false));  }

        void UstvariSmeti()
        {
            Version vt;
            for (int i = 0; i < števec; i++)
            {
                vt = new Version();
            }
        }
    }
}
