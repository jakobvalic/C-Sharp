using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{



    public partial class Form1 : Form
    {

        int razmik = 100;
        List<PictureBox> vseSlikeKraljic = new List<PictureBox>();

        Logika logika = new Logika();
        int[,] SAHOVNICA =  {{0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0} };
        int zaporednaRešitev = 0;




        public Form1()
        {
            InitializeComponent();
            logika.PritisniGumbDodajKraljico += new EventHandler<MyEventArgs>(DodajKraljicoIzLogike); // Naročimo se na poslušanje dogodkov iz logike.
        }





        /// <summary>
        /// Poskuša dogodke iz logike. Sproži risanje posameznih kraljic.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Dodatni parameter, ki se nahaja v 'MyEventArgs' je šahovnica int[,].</param>
        private void DodajKraljicoIzLogike(object sender, MyEventArgs e)
        {
            int[,] sahovnica = e.Sahovnica;
            DodajVseKraljice(sender, e, sahovnica);
        }


        

        /// <summary>
        /// Nariše šahovnico.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int x = 0;
            int y = 0;
            Boolean bela = true;
            Brush čopič;

            Graphics g = e.Graphics;
            
            // Polja
            using (Brush ČrnČopič = new SolidBrush(Color.Black))
            using (Brush BelČopič = new SolidBrush(Color.White))
            {
                for (int i = 1; i <= 8; i++)
                {
                    y += razmik;
                    for (int j = 1; j <= 8; j++)
                    {
                        x = razmik * j;
                        bela = !bela;
                        if (bela)
                        {
                            čopič = ČrnČopič;
                        }
                        else { čopič = BelČopič; }

                        g.FillRectangle(čopič, x, y, razmik, razmik);
                    }
                    bela = !bela;
                }
            }

            // Okvir
            x = 0; y = 0;
            using (Pen čopičOkvir = new Pen(Color.Black))
            { g.DrawRectangle(čopičOkvir, x + razmik, y + razmik, razmik * 8, razmik * 8); }
        }


        /// <summary>
        /// Razbere, kje so kraljice na šahovnici in pokliče funkcijo za prikaz posamezne kraljice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="sahovnica"></param>
        private void DodajVseKraljice(object sender, EventArgs e, int[,] sahovnica)
        {
            int n = (int)Math.Sqrt(sahovnica.Length);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (sahovnica[i,j] == 1)
                    {
                        vseSlikeKraljic.Add(DodajKraljico(sender, e, i, j));
                    }
                }
            }
        }

        /// <summary>
        /// Doda posamezno kraljico na ploščo. Vrne okvir slike, ki ga lahko shranimo v seznam 'vseSlikeKraljic'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="vrstica"></param>
        /// <param name="stolpec"></param>
        /// <returns></returns>
        private PictureBox DodajKraljico(object sender, EventArgs e, int vrstica, int stolpec)
        {
            PictureBox okvirSlike = new PictureBox
            {
                BackColor = Color.Transparent,
                Size = new Size(razmik, razmik),
                Location = new Point((stolpec + 1) * 100, (vrstica + 1) * 100),
                Image = global::WindowsFormsApp1.Properties.Resources.kraljica_beli,
            };
            Controls.Add(okvirSlike);
            return okvirSlike;
        }

        /// <summary>
        /// Ročno odstranjevanje vseh kraljic ob pritisku na gumb.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbOdstrani_Click(object sender, EventArgs e)
        {
            OdstraniVseKraljice();
        }

        /// <summary>
        /// Odstrani vse kraljice s plošče tako, da izbriše vse okvirje slik kraljic iz seznama 'vseSlikeKraljic'.
        /// </summary>
        private void OdstraniVseKraljice()
        {
            while (vseSlikeKraljic.Count > 0)
            {
                Controls.Remove(vseSlikeKraljic.Last());
                vseSlikeKraljic.RemoveAt(vseSlikeKraljic.Count - 1);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            časovnik.Interval = (int) numericUpDown1.Value * 100;
        }

        private void časovnik_Tick(object sender, EventArgs e)
        {
            if (!checkBoxUstavitev.Checked)
            {
                PoiščiEnoRešitev();
            }
        }

        /// <summary>
        /// Funkcija, ki izriše korake posamezne rešitve.
        /// </summary>
        public void IzpišiPosameznoRešitev(List<int[,]> korakiRešitve)
        {
            label5.Text = String.Format("Korakov te posamezne rešitve je {0}", korakiRešitve.Count());
            foreach (int[,] korak in korakiRešitve)
            {
                Console.Out.WriteLine("\n Naslednji korak: ");
                logika.Izpisi_sahovnico(korak);
            }
        }

        /// <summary>
        /// Naroči logiki, naj poišče naslednjo rešitev. 
        /// </summary>
        private void PoiščiEnoRešitev()
        {
            SAHOVNICA = logika.Krovna_funkcija(SAHOVNICA);
            if (SAHOVNICA[0,0] != -1)
            {
                List<int[,]> korakiRešitve = logika.korakiPosamezneRešitve;
                OdstraniVseKraljice(); // Pobrišemo slike kraljic s plošče.

                if (checkBoxRaziščiRešitev.Checked)
                {
                    IzpišiPosameznoRešitev(korakiRešitve);
                }
                //logika.PočistiKorakePosamezneRešitve(); // Pobrišemo korake posamezne rešitve.


                DodajVseKraljice(this, EventArgs.Empty, SAHOVNICA); // Dodamo kraljice rešitve

                IzpišiPosameznoRešitev(korakiRešitve);
                zaporednaRešitev++;
                label2.Text = zaporednaRešitev.ToString(); // Zaporedna številka rešitve.
            } 
        }

    }
}
