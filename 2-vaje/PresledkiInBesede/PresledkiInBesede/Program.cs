using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresledkiInBesede
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Napiši poved: ");
            // String vnos = Console.ReadLine();
            //String vnos = "                Danes je lep in sončen dan, malce mrzel,                 ampak bo, razen          tega da         sem spet            prehlajen.             ";
            String vnos = "pet tri dva ena nič s d f   ";
            presledki(vnos);
        }

        static void presledki(string vnos)
        {
            string[] besede = vnos.Split(new char[] { ' ' }, StringSplitOptions.None);

            // Izpis brez presledkov
            Console.Write("Niz brez presledkov: ");
            for (int i = 0; i < besede.Length; i++)
            {
                Console.Write(besede[i]);
            }
            Console.WriteLine();


            // Izpis s presledki
            Console.Write("Niz brez zaporednih presledkov: ");
            for (int i = 0; i < besede.Length; i++)
            {
                if (besede[i].Length > 0)
                    Console.Write("_");
                Console.Write(besede[i]);
            }
            Console.WriteLine();

            // Najdaljša beseda
            Console.Write("Najdaljše besede: ");
            int najDolzina = 0;
            List<string> najBesede = new List<string>();
            for (int i = 0; i < besede.Length; i++)
            {
                string beseda = besede[i];
                if (beseda.Length > najDolzina)
                {
                    najBesede = new List<string>();
                    najBesede.Add(beseda);
                    najDolzina = beseda.Length;
                }
                else if (beseda.Length == najDolzina)
                    najBesede.Add(beseda);
            }
            foreach (string beseda in najBesede)
            {
                Console.Write(beseda + " ");
            }
            Console.WriteLine();
            
        }
    }
}
