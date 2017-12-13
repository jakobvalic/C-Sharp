using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Finance
{
    class Program
    {
        static void Main(string[] args)
        {
            analiza();
        }

        static void analiza()
        {
            double nakup = 0;
            double prodaja = 0;

            Console.WriteLine(Directory.GetCurrentDirectory());
            string pot = Path.Combine(Directory.GetCurrentDirectory(), "finance.csv");
            using (StreamReader sr = File.OpenText(pot))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    
                    string vrstica = sr.ReadLine().Trim();
                    string[] razberi = vrstica.Split(',');
                    string vrsta = razberi[0];
                    double znesek = double.Parse(razberi[1]);
                    if (vrsta.ToLower() == "nakup")
                    {
                        nakup += znesek;
                    }
                    else if (vrsta.ToLower() == "prodaja") 
                    {
                        prodaja += znesek;
                    }
                }
            }
            Console.WriteLine(String.Format("Skupni znesek znaša {0}.", nakup));
            Console.WriteLine(String.Format("Skupni dobiček znaša {0}.", prodaja));
            Console.WriteLine(String.Format("Izravnan znesek znaša {0}.", prodaja - nakup));
        }
    }
}
