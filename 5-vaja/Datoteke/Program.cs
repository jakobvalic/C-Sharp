using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datoteke
{
    class Program
    {
        static void Main(string[] args)
        {
            string pot = @"\\Spin\ValicJ15$\_System\Desktop\___\vnos1";
            ZapisiIzpisi(pot);
        }

        static void ZapisiIzpisi(String pot)
        {
            StreamWriter dat;
            dat = File.AppendText(pot); // Če datoteke ni, jo naredi :)
            String vnos = "";
            while (vnos.ToLower() != "konec")
            {
                Console.Write("Napiši nekaj: ");
                if (vnos.ToLower() != "konec")
                {
                    dat.WriteLine(vnos);
                }
                vnos = Console.ReadLine();
            }
            dat.Close();
            using (StreamReader sr = File.OpenText(pot))
            {
                int stevec = 1;
                String vrstica = sr.ReadLine();
                while (vrstica != null)
                {
                    Console.WriteLine(stevec + ".vrstica: " + vrstica);
                    vrstica = sr.ReadLine();
                    stevec++;
                }
            }
            using (StreamReader sr = File.OpenText(pot))
            {
                while(!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
    }
}
