using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Form okvir = new Form1();
            okvir.BackColor = System.Drawing.Color.Magenta;

            Application.EnableVisualStyles();

            Application.Run(okvir);

            Button klik = new Button();
            




        }
    }
}
