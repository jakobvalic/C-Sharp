using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_vaja
{
    class Program
    {
        static void Main(string[] args)
        {
            LovljenjeNapak();
            
        }

        static void LovljenjeNapak()
        {
            Console.WriteLine("Program izpiše vrednost izraza (a+b)/c, za cela števila a,b,c");
            try
            {
                Console.Write("Vnesi a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Vnesi b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Vnesi c: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("(a+b)/c = " + ((a + b) / c));
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Vnesti morate število in ne drugih znakov.");
                Console.WriteLine(e.ToString()); // Koristno, da vemo, v kateri vrstici se je napaka zgodila.
                LovljenjeNapak();
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("Deljenje z ničlo ni dovoljeno.");
                Console.WriteLine(e.ToString());
                LovljenjeNapak();
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Presegli ste omejitev za tip int.");
                Console.WriteLine(e.ToString());
                LovljenjeNapak();
            }
            catch (Exception e)
            {
                Console.WriteLine("Nekaj drugega je šlo narobe:");
                Console.WriteLine(e.ToString());
                // Tu zaustavimo delovanje programa, ker program še ni dopolnjen.
            }
        }
    }
}
