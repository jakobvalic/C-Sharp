using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkvirZaSlike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Če več izbirnikov uporablja to funkcijo
            OpenFileDialog izbirnikSlik = (OpenFileDialog)sender; // Pretvorimo iz object v OpenFileDialog
            String pot = izbirnikSlik.FileName;
            Image slika = Image.FromFile(pot);
            pictureBox1.Image = slika;
        }
    }
}
