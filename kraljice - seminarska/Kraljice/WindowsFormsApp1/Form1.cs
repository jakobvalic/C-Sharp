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
        List<string> opisKorakovRešitve;
        List<int[,]> vseRešitve;

        int zaporednaRešitev = 1;
        int števecKorakovRešitve = 1;


        int[,] SAHOVNICA =  {{0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0} };

        public Form1()
        {
            InitializeComponent();

            logika = new Logika();
            korakiRešitve = logika.korakiPosamezneRešitve; // Povežemo s spremenljivko iz logike.
            opisKorakovRešitve = logika.opisKorakovPosamezneRešitve;
            logika.PoiščiVseRešitve(SAHOVNICA); // Napolnimo seznam vseh rešitev.
            vseRešitve = logika.vseRešitve;

            časovnikVseRešitve.Enabled = true;
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
            using (Brush ČrnČopič = new SolidBrush(Color.Navy))
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
        private void DodajVseKraljice(int[,] sahovnica)
        {
            int n = (int)Math.Sqrt(sahovnica.Length);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int vrstaKraljice = sahovnica[i, j];
                    if (vrstaKraljice != 0)
                    {
                        vseSlikeKraljic.Add(DodajKraljico(i, j, vrstaKraljice));
                    }
                }
            }
        }

        /// <summary>
        /// Doda posamezno kraljico na ploščo. Ločimo 3 vrste kraljic: navadno, napadeno in napadajočo.
        /// </summary>
        /// <param name="vrstica"></param>
        /// <param name="stolpec"></param>
        /// <returns>Vrne okvir slike, da ga lahko shranimo v seznam 'vseSlikeKraljic'.</returns>
        private PictureBox DodajKraljico(int vrstica, int stolpec, int vrstaKraljice)
        {
            Image slika;
            if (vrstaKraljice == 1) // Navadna, belo obarvana kraljica.
            {
                slika = Properties.Resources.kraljica_bela;
            }
            else if (vrstaKraljice == 2) // Napadena, rdeče obarvana kraljica.
            {
                slika = Properties.Resources.kraljica_rdeca;
            }
            else // Napadajoča, belo-rdeče obarvana kraljica.
            {
                slika = Properties.Resources.kraljica_bela_rdeca;
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
        /// Zažene časovnik za prikaz vseh rešitev.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbPrikažiVseRešitve_Click(object sender, EventArgs e)
        {
            časovnikVseRešitve.Enabled = true;
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

        /// <summary>
        /// Nastavi hitrost predvajanja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hitrostPredvajanja(object sender, EventArgs e)
        {
            časovnikVseRešitve.Interval = (int)numericUpDown1.Value * 100;
            časovnikKorakiRešitve.Interval = (int)numericUpDown1.Value * 100;
        }

        /// <summary>
        /// Časovnik za predstavitev vseh rešitev. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void časovnikVseRešitve_Tick(object sender, EventArgs e)
        {
            if (zaporednaRešitev >= vseRešitve.Count()) // Na zaslonu ohranimo zadnjo rešitev.
            {
                zaporednaRešitev = 1; // Začnemo gledati rešitve znova, od začetka.
            }
            OdstraniVseKraljice();
            časovnikKorakiRešitve.Enabled = false;
            DodajVseKraljice(vseRešitve[zaporednaRešitev]);
            spremeniNapisRešitve(zaporednaRešitev);
            zaporednaRešitev++;
        }

        private void spremeniNapisRešitve(int zaporednaRešitev)
        {
            labelŠtevecRešitev.Text = String.Format("Rešitev številka: {0}", zaporednaRešitev.ToString());
        }

        /// <summary>
        /// Časovnik za predstavitev posameznih rešitev.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void časovnikKorakiRešitve_Tick(object sender, EventArgs e)
        {
            OdstraniVseKraljice();
            DodajVseKraljice(korakiRešitve[števecKorakovRešitve]); // Dodamo kraljice na šahovnico
            labelOpisKoraka.Text = opisKorakovRešitve[števecKorakovRešitve]; // Opis posameznega koraka rešitve
            labelŠtevecKorakov.Text = String.Format("Korak številka: {0}", števecKorakovRešitve);
            števecKorakovRešitve++;
            if (števecKorakovRešitve >= korakiRešitve.Count())
            {
                časovnikKorakiRešitve.Enabled = false;
                števecKorakovRešitve = 1;
                spremeniNapisRešitve(zaporednaRešitev);
                zaporednaRešitev++; // Ker smo prišli do konca
            }
        }


        /// <summary>
        /// Gumb za ustavitev aplikacije.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbUstavi_Click(object sender, EventArgs e)
        {
            bool časovnikaUstavljena = !časovnikVseRešitve.Enabled && !časovnikKorakiRešitve.Enabled;
            if (!časovnikaUstavljena) // Ustavimo oba časovnika in ponastavimo vrednost napisov
            {
                časovnikVseRešitve.Enabled = false;
                časovnikKorakiRešitve.Enabled = false;
                gumbUstaviZacni.Text = "Naslednja reštiev";
            }
            else // Poženemo časovnik za prikaz naslednje rešitve.
            {
                časovnikVseRešitve_Tick(sender, e);
                časovnikVseRešitve.Enabled = true;
                časovnikKorakiRešitve.Enabled = false;
                gumbUstaviZacni.Text = "Ustavi";
            }
            ponastaviOznakeKorakov();
        }

        private void ponastaviOznakeKorakov()
        {
            labelŠteviloKorakov.Text = "/";
            labelŠtevecKorakov.Text = "/";
            labelOpisKoraka.Text = "/";
        }

        /// <summary>
        /// Skrbi za prikaz naslednje rešitve po korakih.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbNaslednjaRešitevPoKorakih_Click(object sender, EventArgs e)
        {
            gumbUstaviZacni.Text = "Ustavi";
            časovnikVseRešitve.Enabled = false;
            // zaporednaRešitev nam da začetno pozicijo
            if (zaporednaRešitev >= vseRešitve.Count)
            {
                zaporednaRešitev = 1; // Naslednja rešitev od zadnje rešitve je prva.
            }
            // Sedaj logiko povprašamo za korake rešitve. Prej pobrišemo stare korake.
            korakiRešitve.Clear();
            opisKorakovRešitve.Clear();
            števecKorakovRešitve = 1;
            logika.Postavljaj_kraljice(vseRešitve[zaporednaRešitev - 1], true); // Zopet napolni korake rešitve.
            labelŠteviloKorakov.Text = String.Format("Vseh korakov: {0}", korakiRešitve.Count() - 1);
            labelŠtevecRešitev.Text = String.Format("Iščemo rešitev št. {0}", zaporednaRešitev); // Zaporedna številka rešitve.
            časovnikKorakiRešitve.Enabled = true;
        }

        /// <summary>
        /// Poskrbi za hitro navigacijo med rešitami.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbSkočiNaRešitev_Click(object sender, EventArgs e)
        {
            gumbUstaviZacni.Text = "Naslednja rešitev";
            ponastaviOznakeKorakov();
            časovnikVseRešitve.Enabled = false;
            časovnikKorakiRešitve.Enabled = false;
            OdstraniVseKraljice();
            zaporednaRešitev = (int)numericUpDownSkočiNaRešitev.Value;
            DodajVseKraljice(vseRešitve[zaporednaRešitev]);
            spremeniNapisRešitve(zaporednaRešitev);
            zaporednaRešitev++;
        }
    }
}
