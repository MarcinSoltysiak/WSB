﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolokwium1
{
    public partial class kalkulator : Form
    {
        int click = 0;
        double pierwszy;
        string operacja;
        public kalkulator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = ",";
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            pierwszy = double.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            operacja = "+";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            pierwszy = double.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            operacja = "-";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pierwszy = double.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            operacja = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pierwszy = double.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            operacja = "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pierwszy = double.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            operacja = "%";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double drugi = double.Parse(textBox1.Text);
            double result;

            if (operacja == "+")
            {
                result = pierwszy + drugi;
                textBox1.Text = result.ToString();
            }
            if (operacja == "-")
            {
                result = pierwszy - drugi;
                textBox1.Text = result.ToString();
            }
            if (operacja == "*")
            {
                result = pierwszy * drugi;
                textBox1.Text = result.ToString();
            }
            if (operacja == "/")
            {
                if(drugi == 0)
                {
                    textBox1.Text = "nie można dzielić przez 0";
                }
                else
                {
                    result = pierwszy / drugi;
                    textBox1.Text = result.ToString();
                }
                
            }
            if (operacja == "%")
            {
                result = pierwszy % drugi;
                textBox1.Text = result.ToString();
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}
