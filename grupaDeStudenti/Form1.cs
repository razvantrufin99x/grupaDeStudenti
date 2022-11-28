using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupaDeStudenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public grupaDeStudenti gr = new grupaDeStudenti();

        private void button3_Click(object sender, EventArgs e)
        {
            gr.numarulDeStudenti(int.Parse(this.textBox3.Text));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gr.loadNotaStudent(float.Parse(this.textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gr.calculareDate();
            this.textBox2.Text = " este grupa integralista = " + gr.eIntegralista().ToString() +
                " procentul de note bune " + gr.procentajDeNoteFoarteBune().ToString() + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = "";
            gr.printStudenti(ref s);
            this.textBox4.Text = s;
        }
    }
}
