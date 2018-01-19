using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Naloga3
{
    class Program
    {
        static void Main(string[] args)
        {
            string imeVhod = "mesaniDatumi.txt";
            string imeIzhod = "samoDatumi.txt";
            Beri(imeVhod, imeIzhod);
        }

        static void Beri(string imeVhodne, string imeIzhodne)
        {
            StreamReader vhod = File.OpenText(imeVhodne);
            StreamWriter izhod = File.CreateText(imeIzhodne);
            string vr = vhod.ReadLine();
            while (vr != null)
            {
                string[] datum = vr.Trim().Split(new string[] { ". " }, StringSplitOptions.None);
                if (datum.Length == 3)
                {
                    int dan, mesec, leto;
                    bool jeDanStevilo = Int32.TryParse(datum[0], out dan);
                    bool jeMesecStevilo = Int32.TryParse(datum[1], out mesec);
                    bool jeLetoStevilo = Int32.TryParse(datum[2], out leto);
                    if (jeDanStevilo && jeMesecStevilo && jeLetoStevilo && 1 <= dan && dan <= 31 && 1 <= mesec && mesec <= 12)
                    {
                        izhod.WriteLine(vr);
                        Console.WriteLine(vr + " je datum.");
                    }
                    else
                    {
                        Console.WriteLine(vr + " ni datum.");
                    }
                }
                vr = vhod.ReadLine();
            }
            vhod.Close();
            izhod.Close();

        }

        // Raje napiši metodo jeDatum
        static bool jeDatum(string vrstica)
        {
            DateTime t = new DateTime();
            return DateTime.TryParseExact(vrstica, "dd. MM. yyyy", null, System.Globalization.DateTimeStyles.None, out t);
        }

        static bool jeDatumPoDomace(string vrstica)
        {
            string[] besede = vrstica.Split(new string[] { ". " }, StringSplitOptions.None);
            // Preverjanje
            return true;
        }
    }
}
