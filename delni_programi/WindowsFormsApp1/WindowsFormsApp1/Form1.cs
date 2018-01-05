using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "WAKNCE";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Kliknil";
            this.BackColor = Color.DarkGreen;
            mojGumb.Text = "Klikniiiil";

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mojGumb_Click(object sender, EventArgs e)
        {
            mojGumb.Text = "auč";
            BackColor = Color.Magenta;
            while (true)
            {
                mojGumb.Text = "auč";
                BackColor = Color.Magenta;
                button1_Click(sender, e);
            }
        }
    }
}
