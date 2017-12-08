using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzmuzljiviGumb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Gumb1_Click(object sender, EventArgs e)
        {
            int xGumba = Gumb1.Width;
            int yGumba = Gumb1.Height;
            Random nakljucnoCelo = new Random();
            int x = nakljucnoCelo.Next(0, ClientSize.Width - xGumba); // ClientSize upošteva le dejansko površino brez orodne vrstice
            int y = nakljucnoCelo.Next(0, ClientSize.Height - yGumba);
            Gumb1.Location = new Point(x, y);
        }

        // Hover je, če smo nad objektom malce več časa. Enter pa je, če se nahaja miška nad objektom.
        private void Gumb1_MouseHover(object sender, EventArgs e)
        {
            Gumb1.BackColor = Color.Green;
        }
    }
}
