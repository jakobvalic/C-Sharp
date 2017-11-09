using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datoteke
{
    class Program
    {
        static void Main(string[] args)
        {
            string pot = @"U:\2. letnik\NM2\nssorme.m";
            PreberiDat(pot);
            IzbrisiDat(pot);
            NajvecjaDat(@"U:\2. letnik\NM2");
        }

        static Tuple<string, int> NajvecjaDat(string pot)
        {
            string najIme = "";
            int najVel = 0;
            foreach (string datoteka in Directory.GetFiles(pot))
            {
                Console.WriteLine(datoteka);
                if (Directory.Exists(datoteka))
                {
                    Tuple<string, int> najPod = NajvecjaDat(datoteka);
                    string najImePodd = najPod.Item1;
                    int najVelPodd = najPod.Item2;
                    if (najVelPodd > najVel)
                    {
                        najIme = najImePodd;
                    }
                    // Nismo še upoštevali, če sta enake dolžine.
                }
                else if (File.Exists(datoteka))
                {
                    FileInfo dat = new FileInfo(datoteka);
                    long velDat = dat.Length;
                    
                }
                
            }
            return new Tuple<string, int> (najIme, najVel);
        }

        static void PreberiDat(string pot)
        {
            if (!File.Exists(pot))
            {
                using (StreamWriter sw = File.CreateText(pot))
                {
                    sw.WriteLine("Dihur");
                    sw.WriteLine("Dihurka");
                    sw.WriteLine("Dihurski par");
                }
            }          

            StreamReader sr = File.OpenText(pot);
            string vr = sr.ReadLine();
            while (vr != null)
            {
                Console.WriteLine(vr);
                vr = sr.ReadLine();
            }
            sr.Close();
        }

        static void IzbrisiDat(string pot)
        {
            File.Delete(pot);
        }
    }
}
