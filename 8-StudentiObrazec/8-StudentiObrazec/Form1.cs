using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_StudentiObrazec
{
    public partial class Form1 : Form
    {
        BindingList<Student> b = new BindingList<Student>();

        


        public Form1()
        {
            InitializeComponent();
            Student Tomi = new Student("Tomi", "Troha", "moški", new DateTime(1990, 3, 12));
            b.Add(Tomi);
            // listBox1.Items.Add(Tomi);

            listBox1.DataSource = b;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            b.Add(new Student(textBox_ime.Text, textBox_priimek.Text, "moški", new DateTime(1990, 2, 12)));
        }
    }
}
