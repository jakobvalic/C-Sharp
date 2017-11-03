using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomozniProgram
{
    class LovljenjeIzjem
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Int32.Parse(Console.ReadLine());
                int b = 7 / a;
            }
            catch {
                Console.WriteLine("Deljenje z 0.");
            }
        }
    }
}
