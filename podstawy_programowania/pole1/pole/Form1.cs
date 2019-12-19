using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Podaj bok kwadratu";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int bok = int.Parse(textBox1.Text);
            int suma = bok * bok;
            textBox2.Text = bok.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int bok = int.Parse(textBox1.Text);
            int suma2 = bok * 4;
            textBox2.Text = bok.ToString();

        }
    }
}
