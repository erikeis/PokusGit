using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokusGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int soucet = x + y;
            MessageBox.Show("Soucet cisel je " + soucet.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int rozdil = x - y;
            MessageBox.Show("Rozdil cisel je " + rozdil.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int soucin = x * y;
            MessageBox.Show("Soucin cisel je " + soucin.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int podil = x / y;
            MessageBox.Show("Podil cisel je " + podil.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ITA2 Erik Eis");
        }
    }
}
