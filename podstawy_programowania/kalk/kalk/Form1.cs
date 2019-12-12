using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kalk
{
    public partial class Form1 : Form
    {
        public double b = 0;
        public char coRobi;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            result.Text += "1";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            result.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            result.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text += "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {

            
            result.Text = "";
            
            
        }
        

        private void button25_Click(object sender, EventArgs e)
        {
            
            switch (coRobi)
            {
                case '+':
                    b += double.Parse(result.Text);
                    
                    break;
                case '-':
                    b -= double.Parse(result.Text);
                    break;

            }

            result.Text = b.ToString();
            b = 0;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            result.Text += ((Button)sender).Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            b += double.Parse(result.Text);
            result.Clear();
            coRobi = '+';
            result.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            b -= double.Parse(result.Text);
            result.Clear();
            coRobi = '-';
            result.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}
