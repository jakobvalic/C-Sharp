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

        Logika logika;
        List<int[,]> korakiRešitve;
        

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

            logika = new Logika();
            korakiRešitve = logika.korakiPosamezneRešitve; // Povežemo spremenljivko iz logike

            logika.PritisniGumbDodajKraljico += new EventHandler<MyEventArgs>(DodajKraljicoIzLogike); // Naročimo se na poslušanje dogodkov iz logike
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
                    else if (sahovnica[i,j] == 2)
                    {
                        vseSlikeKraljic.Add(DodajKraljico(sender, e, i, j, true));
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
        private PictureBox DodajKraljico(object sender, EventArgs e, int vrstica, int stolpec, bool rdečaKraljica=false)
        {
            Image slika;
            if (rdečaKraljica)
            {
                slika = Properties.Resources.kraljica_rdeca_gif;
            }
            else
            {
                slika = Properties.Resources.kraljica_beli;
            }

            PictureBox okvirSlike = new PictureBox
            {
                BackColor = Color.Transparent,
                Size = new Size(razmik, razmik),
                Location = new Point((stolpec + 1) * 100, (vrstica + 1) * 100),
                Image = slika
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
            časovnikCelaRešitev.Interval = (int) numericUpDown1.Value * 100;
            časovnikKorakiRešitve.Interval = (int)numericUpDown1.Value * 100;
        }

        private void časovnik_Tick(object sender, EventArgs e)
        {
            if (!checkBoxUstavitev.Checked && !checkBoxRaziščiRešitev.Checked)
            {
                PoiščiEnoRešitev();
            }
            else if (checkBoxRaziščiRešitev.Checked)
            {
                časovnikKorakiRešitve.Enabled = true;
                časovnikCelaRešitev.Enabled = false;
            }
        }

        /// <summary>
        /// Funkcija, ki izriše korake posamezne rešitve.
        /// </summary>
        public void IzpišiPosameznoRešitev()
        {
            label5.Text = String.Format("Korakov te posamezne rešitve je {0}", korakiRešitve.Count());
            for (int i=0; i<korakiRešitve.Count(); i++)
            {
                int[,] korak = korakiRešitve[i];
                Console.Out.WriteLine(String.Format("Korak {0}: ", i));
                logika.Izpisi_sahovnico(korak);
            }
        }

        /// <summary>
        /// Naroči logiki, naj poišče naslednjo rešitev. 
        /// </summary>
        private void PoiščiEnoRešitev()
        {
            logika.PočistiKorakePosamezneRešitve(); // Izpraznimo seznam posameznih rešitev
            SAHOVNICA = logika.Krovna_funkcija(SAHOVNICA);
            if (SAHOVNICA[0,0] != -1)
            {
                OdstraniVseKraljice(); // Pobrišemo slike kraljic s plošče.

                DodajVseKraljice(this, EventArgs.Empty, SAHOVNICA); // Dodamo kraljice rešitve

                IzpišiPosameznoRešitev();
                zaporednaRešitev++;
                label2.Text = zaporednaRešitev.ToString(); // Zaporedna številka rešitve.
            } 
        }

        private void časovnikKorakiRešitve_Tick(object sender, EventArgs e)
        {
            OdstraniVseKraljice();
            if (korakiRešitve.Count > 0)
            {
                int[,] korak = korakiRešitve[0];
                korakiRešitve.RemoveAt(0); // Krajšamo seznam
                DodajVseKraljice(this, EventArgs.Empty, korak);
            }
            else
            {
                časovnikKorakiRešitve.Enabled = false; // Raziskali smo vse korake rešitev, torej ustavimo časovnik za prikaz posamezne rešitve.
                časovnikCelaRešitev.Enabled = true;
                checkBoxRaziščiRešitev.Checked = false;
            }
        }
    }
}
