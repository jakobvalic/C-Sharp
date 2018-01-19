using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naloga5_GraficniVmesnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Color> barve = new List<Color> { Color.Red, Color.Green, Color.Purple };
        private int[] stevci = { 0, 0, 0 };
        // private Label[] napisi = new Label[] 
        private int stevecZelenih = 0;

        private void uraBarvaj_Tick(object sender, EventArgs e)
        {
            Random izbirnik = new Random();
            int indeks = izbirnik.Next(barve.Count);
            barvnoPodrocje.BackColor = barve[indeks];
            stevci[indeks] += 1;
            izpisStevilaRdecih.Text = stevci[0].ToString();
            izpisStevilaZelenih.Text = stevci[1].ToString();
            izpisStevilaVijolicnih.Text = stevci[2].ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
