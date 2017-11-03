using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PomozniProgram2
{
    class Odpiranje
    {
        static void Main(string[] args)
        {
            string pot = @"U:\2. letnik\PRO2\sestevkiD.txt";
            if (!File.Exists(pot))
            {
                StreamWriter dat = File.CreateText(pot);
                dat.WriteLine("Ziujo, dihur!");
                dat.Close();
            }

            StreamReader sr = File.OpenText(pot);
            string vrstica = sr.ReadLine();
            while (vrstica != null)
            {
                Console.WriteLine(vrstica);
                vrstica = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
