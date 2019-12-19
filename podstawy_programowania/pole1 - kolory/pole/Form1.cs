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
            if (int.TryParse(textBox1.Text, out int bok) && bok > 0) 
            {
                bok = int.Parse(textBox1.Text);
                int suma = bok * bok;
                int obw = bok * 4;
                textBox2.Text = suma.ToString();
                textBox3.Text = obw.ToString();
            }
            else
            {
                label4.Text = "Podaj liczbę dodatnią";
                textBox2.Clear();
                textBox3.Clear();
            }
            
                
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kolor settingsForm = new kolor();
            settingsForm.Show();
        }
    }
}
